using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using FastReport;
using FastReport.Export.PdfSimple;
using FastReportExtensions = FastReport;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmReporteEstudiantesPorGrupo : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable grupos;

        public FrmReporteEstudiantesPorGrupo()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            CargarGrupos();
            ConfigurarEventos();
            ActualizarInfoHeader();
        }

        private void ConfigurarEventos()
        {
            cmbGrupo.SelectedIndexChanged += CmbGrupo_SelectedIndexChanged;
        }

        private void CargarGrupos()
        {
            try
            {
                grupos = dbHelper.ObtenerGruposParaCombo();
                cmbGrupo.Items.Clear();

                if (grupos.Rows.Count > 0)
                {
                    cmbGrupo.Items.Add("Todos los grupos");

                    foreach (DataRow row in grupos.Rows)
                    {
                        string grupoNombre = row["group_name"].ToString();
                        cmbGrupo.Items.Add(grupoNombre);
                    }

                    cmbGrupo.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron grupos en la base de datos.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar grupos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstudiantesPorGrupo(string grupoSeleccionado)
        {
            try
            {
                dgvEstudiantes.Rows.Clear();
                DataTable estudiantes;

                if (grupoSeleccionado == "Todos los grupos")
                {
                    estudiantes = ObtenerTodosLosEstudiantes();
                }
                else
                {
                    int grupoId = ObtenerIdGrupo(grupoSeleccionado);
                    estudiantes = dbHelper.ObtenerEstudiantesPorGrupo(grupoId);
                }

                if (estudiantes.Rows.Count > 0)
                {
                    foreach (DataRow row in estudiantes.Rows)
                    {
                        string nombre = row["Nombre"].ToString();
                        string nivel = row["Nivel"] == DBNull.Value ? "N/A" : row["Nivel"].ToString();

                        int studentId = Convert.ToInt32(row["student_id"]);
                        string progreso = CalcularProgreso(studentId);

                        string asistencia = "N/A";
                        string calificacion = "N/A";
                        string fechaIngreso = row.Table.Columns.Contains("FechaInscripcion") && row["FechaInscripcion"] != DBNull.Value
                            ? Convert.ToDateTime(row["FechaInscripcion"]).ToString("dd/MM/yyyy")
                            : "N/A";

                        if (nombre.Length > 18)
                            nombre = nombre.Substring(0, 15) + "...";

                        dgvEstudiantes.Rows.Add(nombre, nivel, progreso, asistencia, calificacion, fechaIngreso);
                    }
                }
                else
                {
                    string mensaje = grupoSeleccionado == "Todos los grupos"
                        ? "No hay estudiantes en ningún grupo"
                        : $"No hay estudiantes en el grupo {grupoSeleccionado}";

                    dgvEstudiantes.Rows.Add(mensaje, "-", "0%", "0%", "0", "-");
                }

                this.Text = $"Reporte: Estudiantes por Grupo - {grupoSeleccionado} ({dgvEstudiantes.Rows.Count} estudiantes)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObtenerTodosLosEstudiantes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(dbHelper.ConnectionString))
            {
                string query = @"
                    SELECT 
                        s.student_id,
                        u.username AS Nombre,
                        s.current_english_level AS Nivel,
                        g.group_name AS Grupo,
                        e.enrollment_date AS FechaInscripcion
                    FROM students s
                    INNER JOIN users u ON s.user_id = u.user_id
                    LEFT JOIN enrollments e ON s.student_id = e.student_id AND e.status = 'activo'
                    LEFT JOIN groups g ON e.group_id = g.group_id
                    WHERE u.is_active = 1
                    ORDER BY g.group_name, u.username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        private int ObtenerIdGrupo(string grupoNombre)
        {
            foreach (DataRow row in grupos.Rows)
            {
                if (row["group_name"].ToString() == grupoNombre)
                {
                    return Convert.ToInt32(row["group_id"]);
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

        private void CmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGrupo.SelectedItem != null)
            {
                string grupoSeleccionado = cmbGrupo.SelectedItem.ToString() ?? "";
                CargarEstudiantesPorGrupo(grupoSeleccionado);
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

                ReportFilterHelper.ApplyDateFilter(dgvEstudiantes, dtpFechaDesde.Value, dtpFechaHasta.Value, "FechaInscripcion");
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
                save.FileName = $"ReporteEstudiantesPorGrupo_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (save.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Nivel");
                    dt.Columns.Add("Progreso");
                    dt.Columns.Add("Asistencia");
                    dt.Columns.Add("Calificación");
                    dt.Columns.Add("FechaInscripcion");

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
                                row.Cells[5].Value
                            );
                        }
                    }

                    Report reporte = new Report();
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