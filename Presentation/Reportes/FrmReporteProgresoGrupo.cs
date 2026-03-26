using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmReporteProgresoGrupo : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable gruposData;
        private int maestroId;

        public FrmReporteProgresoGrupo()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            maestroId = ObtenerMaestroIdActual();
            CargarGrupos();
            ConfigurarDataGridView();
        }

        private int ObtenerMaestroIdActual()
        {
            // Este método obtiene todos los grupos (ya que los reportes están en Admin)
            // Para maestros específicos, se filtraría por el usuario logueado
            // Por ahora, retornamos -1 y usamos CargarTodosLosGrupos
            return -1;
        }

        private void CargarGrupos()
        {
            try
            {
                string query = @"
                    SELECT g.group_id, g.group_name
                    FROM groups g
                    ORDER BY g.group_name";

                DataTable dt = new DataTable();
                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    conn.Open();
                    new System.Data.SqlClient.SqlDataAdapter(cmd).Fill(dt);
                }

                gruposData = dt;
                cmbGrupo.Items.Clear();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        cmbGrupo.Items.Add(row["group_name"].ToString());
                    }
                    cmbGrupo.SelectedIndex = 0;
                    CargarProgresoGrupo(0);
                }
                else
                {
                    MessageBox.Show("No tienes grupos asignados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar grupos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvProgreso.ColumnCount = 6;
            dgvProgreso.Columns[0].Name = "👤 Estudiante";
            dgvProgreso.Columns[1].Name = "📚 Lecciones %";
            dgvProgreso.Columns[2].Name = "📖 Vocabulario %";
            dgvProgreso.Columns[3].Name = "⭐ Calificación";
            dgvProgreso.Columns[4].Name = "✅ Tareas Entregadas";
            dgvProgreso.Columns[5].Name = "🎯 Estado";

            dgvProgreso.Columns[0].Width = 150;
            dgvProgreso.Columns[1].Width = 100;
            dgvProgreso.Columns[2].Width = 100;
            dgvProgreso.Columns[3].Width = 100;
            dgvProgreso.Columns[4].Width = 130;
            dgvProgreso.Columns[5].Width = 100;

            dgvProgreso.AllowUserToAddRows = false;
            dgvProgreso.ReadOnly = true;
            dgvProgreso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarProgresoGrupo(int grupoIndex)
        {
            try
            {
                if (grupoIndex < 0 || grupoIndex >= gruposData.Rows.Count)
                    return;

                int groupId = Convert.ToInt32(gruposData.Rows[grupoIndex]["group_id"]);
                dgvProgreso.Rows.Clear();

                // Obtener estudiantes del grupo
                string queryEstudiantes = @"
                    SELECT e.student_id, u.username
                    FROM enrollments e
                    INNER JOIN students s ON e.student_id = s.student_id
                    INNER JOIN users u ON s.user_id = u.user_id
                    WHERE e.group_id = @groupId
                    ORDER BY u.username";

                DataTable dtEstudiantes = new DataTable();
                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(queryEstudiantes, conn))
                {
                    cmd.Parameters.AddWithValue("@groupId", groupId);
                    conn.Open();
                    new System.Data.SqlClient.SqlDataAdapter(cmd).Fill(dtEstudiantes);
                }

                foreach (DataRow row in dtEstudiantes.Rows)
                {
                    int studentId = Convert.ToInt32(row["student_id"]);
                    string nombre = row["username"].ToString();

                    // Calcular porcentaje de lecciones
                    int leccionesCompletadas = ObtenerLeccionesCompletadas(studentId);
                    int leccionesTotales = ObtenerTotalLecciones();
                    decimal leccionesPorcentaje = leccionesTotales > 0 ? (decimal)leccionesCompletadas * 100 / leccionesTotales : 0;

                    // Calcular porcentaje de vocabulario
                    int palabrasAprendidas = ObtenerPalabrasAprendidas(studentId);
                    int palabrasTotales = ObtenerTotalPalabras();
                    decimal vocabularioPorcentaje = palabrasTotales > 0 ? (decimal)palabrasAprendidas * 100 / palabrasTotales : 0;

                    // Calcular calificación promedio
                    decimal calificacionPromedio = ObtenerCalificacionPromedio(studentId, groupId);

                    // Contar tareas entregadas
                    int tareasEntregadas = ObtenerTareasEntregadas(studentId, groupId);
                    int tareasTotales = ObtenerTareasTotales(groupId);

                    // Determinar estado
                    string estado = DeterminarEstado(leccionesPorcentaje, calificacionPromedio);

                    dgvProgreso.Rows.Add(
                        nombre,
                        leccionesPorcentaje.ToString("F1") + "%",
                        vocabularioPorcentaje.ToString("F1") + "%",
                        calificacionPromedio.ToString("F2"),
                        $"{tareasEntregadas}/{tareasTotales}",
                        estado
                    );
                }

                ActualizarResumen(dtEstudiantes.Rows.Count, gruposData.Rows[grupoIndex]["group_name"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar progreso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerLeccionesCompletadas(int studentId)
        {
            string query = "SELECT COUNT(*) FROM lesson_progress WHERE student_id = @studentId AND is_completed = 1";
            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@studentId", studentId);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private int ObtenerTotalLecciones()
        {
            string query = "SELECT COUNT(*) FROM lessons";
            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private int ObtenerPalabrasAprendidas(int studentId)
        {
            string query = "SELECT COUNT(*) FROM student_vocabulary WHERE student_id = @studentId AND mastered = 1";
            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@studentId", studentId);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != DBNull.Value ? (int)result : 0;
            }
        }

        private int ObtenerTotalPalabras()
        {
            string query = "SELECT COUNT(*) FROM vocabulary";
            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
            {
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != DBNull.Value ? (int)result : 0;
            }
        }

        private decimal ObtenerCalificacionPromedio(int studentId, int groupId)
        {
            string query = @"
                SELECT AVG(CAST(ts.score AS DECIMAL(5,2)))
                FROM task_submissions ts
                INNER JOIN tasks t ON ts.task_id = t.task_id
                WHERE ts.student_id = @studentId AND t.group_id = @groupId AND ts.score IS NOT NULL";

            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@groupId", groupId);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private int ObtenerTareasEntregadas(int studentId, int groupId)
        {
            string query = @"
                SELECT COUNT(*)
                FROM task_submissions ts
                INNER JOIN tasks t ON ts.task_id = t.task_id
                WHERE ts.student_id = @studentId AND t.group_id = @groupId";

            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@groupId", groupId);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private int ObtenerTareasTotales(int groupId)
        {
            string query = "SELECT COUNT(*) FROM tasks WHERE group_id = @groupId";
            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@groupId", groupId);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private string DeterminarEstado(decimal leccionesPorcentaje, decimal calificacion)
        {
            if (leccionesPorcentaje >= 80 && calificacion >= 80)
                return "🟢 Excelente";
            else if (leccionesPorcentaje >= 60 && calificacion >= 70)
                return "🟡 Bueno";
            else if (leccionesPorcentaje >= 40 && calificacion >= 60)
                return "🟠 Regular";
            else
                return "🔴 Riesgo";
        }

        private void ActualizarResumen(int totalEstudiantes, string nombreGrupo)
        {
            lblResumen.Text = $"Grupo: {nombreGrupo} | Total estudiantes: {totalEstudiantes}";
        }

        private void CmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProgresoGrupo(cmbGrupo.SelectedIndex);
        }
    }
}
