using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using FastReport;
using FastReport.Export.PdfSimple;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmReporteEstudiantesPorMaestro : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable maestros;

        public FrmReporteEstudiantesPorMaestro()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            CargarMaestros();
            ConfigurarEventos();
            ActualizarInfoHeader();
        }

        private void ConfigurarEventos()
        {
            cmbMaestro.SelectedIndexChanged += CmbMaestro_SelectedIndexChanged;
        }

        private void CargarMaestros()
        {
            try
            {
                maestros = dbHelper.ObtenerMaestrosParaCombo();
                cmbMaestro.Items.Clear();

                if (maestros.Rows.Count > 0)
                {
                    cmbMaestro.Items.Add("Todos los maestros");

                    foreach (DataRow row in maestros.Rows)
                    {
                        string maestroNombre = row["username"].ToString();
                        cmbMaestro.Items.Add(maestroNombre);
                    }

                    cmbMaestro.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron maestros en la base de datos.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar maestros: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstudiantesPorMaestro(string maestroSeleccionado)
        {
            try
            {
                dgvEstudiantes.Rows.Clear();
                DataTable estudiantes;

                if (maestroSeleccionado == "Todos los maestros")
                {
                    estudiantes = ObtenerTodosLosEstudiantesConMaestro();
                }
                else
                {
                    int maestroId = ObtenerIdMaestro(maestroSeleccionado);
                    estudiantes = ObtenerEstudiantesPorMaestro(maestroId);
                }

                if (estudiantes.Rows.Count > 0)
                {
                    foreach (DataRow row in estudiantes.Rows)
                    {
                        string nombre = row["Nombre"].ToString();
                        string nivel = row["Nivel"] == DBNull.Value ? "N/A" : row["Nivel"].ToString();
                        string grupo = row["Grupo"] == DBNull.Value ? "Sin grupo" : row["Grupo"].ToString();

                        int studentId = Convert.ToInt32(row["student_id"]);
                        string progreso = CalcularProgreso(studentId);

                        string asistencia = "N/A";
                        string calificacion = "N/A";
                        string fechaIngreso = row["FechaIngreso"] != DBNull.Value
                            ? Convert.ToDateTime(row["FechaIngreso"]).ToString("dd/MM/yyyy")
                            : "N/A";

                        if (nombre.Length > 18)
                            nombre = nombre.Substring(0, 15) + "...";

                        dgvEstudiantes.Rows.Add(nombre, nivel, progreso, asistencia, calificacion, fechaIngreso, grupo);
                    }
                }
                else
                {
                    string mensaje = maestroSeleccionado == "Todos los maestros"
                        ? "No hay estudiantes asignados a maestros"
                        : $"No hay estudiantes asignados al maestro {maestroSeleccionado}";

                    dgvEstudiantes.Rows.Add(mensaje, "-", "0%", "0%", "0", "-", "-");
                }

                this.Text = $"Reporte: Estudiantes por Maestro - {maestroSeleccionado} ({dgvEstudiantes.Rows.Count} estudiantes)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObtenerTodosLosEstudiantesConMaestro()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(dbHelper.ConnectionString))
            {
                string query = @"
                    SELECT 
                        s.student_id,
                        u.username AS Nombre,
                        s.current_english_level AS Nivel,
                        s.enrollment_date AS FechaIngreso,
                        g.group_name AS Grupo,
                        u2.username AS Maestro
                    FROM students s
                    INNER JOIN users u ON s.user_id = u.user_id
                    LEFT JOIN enrollments e ON s.student_id = e.student_id AND e.status = 'activo'
                    LEFT JOIN groups g ON e.group_id = g.group_id
                    LEFT JOIN teachers t ON g.teacher_id = t.teacher_id
                    LEFT JOIN users u2 ON t.user_id = u2.user_id
                    WHERE u.is_active = 1 AND u2.username IS NOT NULL
                    ORDER BY u2.username, u.username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        private DataTable ObtenerEstudiantesPorMaestro(int maestroId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(dbHelper.ConnectionString))
            {
                string query = @"
                    SELECT 
                        s.student_id,
                        u.username AS Nombre,
                        s.current_english_level AS Nivel,
                        s.enrollment_date AS FechaIngreso,
                        g.group_name AS Grupo
                    FROM students s
                    INNER JOIN users u ON s.user_id = u.user_id
                    INNER JOIN enrollments e ON s.student_id = e.student_id AND e.status = 'activo'
                    INNER JOIN groups g ON e.group_id = g.group_id
                    WHERE g.teacher_id = @maestroId
                    ORDER BY u.username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maestroId", maestroId);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        private int ObtenerIdMaestro(string maestroNombre)
        {
            foreach (DataRow row in maestros.Rows)
            {
                if (row["username"].ToString() == maestroNombre)
                {
                    return Convert.ToInt32(row["teacher_id"]);
                }
            }
            return -1;
        }

        private string CalcularProgreso(int studentId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(dbHelper.ConnectionString))
                {
                    string query = @"
                        SELECT 
                            COUNT(DISTINCT l.lesson_id) AS TotalLecciones,
                            COUNT(DISTINCT CASE WHEN lp.completed_at IS NOT NULL THEN l.lesson_id END) AS Completadas
                        FROM lessons l
                        LEFT JOIN lesson_progress lp ON l.lesson_id = lp.lesson_id AND lp.student_id = @studentId
                        WHERE l.is_active = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int total = reader["TotalLecciones"] == DBNull.Value ? 0 : Convert.ToInt32(reader["TotalLecciones"]);
                                int completadas = reader["Completadas"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Completadas"]);

                                if (total > 0)
                                {
                                    int progreso = (completadas * 100) / total;
                                    return $"{progreso}%";
                                }
                            }
                        }
                    }
                }
                return "0%";
            }
            catch
            {
                return "0%";
            }
        }

        private void CmbMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaestro.SelectedItem != null)
            {
                string maestroSeleccionado = cmbMaestro.SelectedItem.ToString() ?? "";
                CargarEstudiantesPorMaestro(maestroSeleccionado);
            }
        }

        private void ActualizarInfoHeader()
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMMM, yyyy");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ReportFilterHelper.ValidateDateRange(dtpFechaDesde.Value, dtpFechaHasta.Value))
                    return;

                ReportFilterHelper.ApplyDateFilter(dgvEstudiantes, dtpFechaDesde.Value, dtpFechaHasta.Value, "FechaIngreso");
                MessageBox.Show($"Filtro aplicado: {dgvEstudiantes.Rows.Count} registros visibles", "Filtro Aplicado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtro:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                ReportFilterHelper.ClearDateFilter(dgvEstudiantes);
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
                MessageBox.Show("Filtro limpiado: todos los registros visibles", "Filtro Limpiado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar filtro:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEstudiantes.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para imprimir.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = $"ReporteEstudiantesPorMaestro_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Report reporte = new Report();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Nivel");
                    dt.Columns.Add("Progreso");
                    dt.Columns.Add("Asistencia");
                    dt.Columns.Add("Calificación");
                    dt.Columns.Add("Fecha Ingreso");
                    dt.Columns.Add("Grupo");

                    foreach (DataGridViewRow row in dgvEstudiantes.Rows)
                    {
                        if (!row.IsNewRow && row.Visible)
                        {
                            dt.Rows.Add(
                                row.Cells[0].Value,
                                row.Cells[1].Value,
                                row.Cells[2].Value,
                                row.Cells[3].Value,
                                row.Cells[4].Value,
                                row.Cells[5].Value,
                                row.Cells[6].Value
                            );
                        }
                    }

                    reporte.RegisterData(dt, "estudiantes");
                    reporte.Prepare();

                    PDFSimpleExport pdf = new PDFSimpleExport();
                    reporte.Export(pdf, save.FileName);

                    MessageBox.Show($"Reporte exportado correctamente en:\n{save.FileName}", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}