using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Reportes
{
    public partial class FrmReporteCalificacionesEstudiante : Form
    {
        private DatabaseHelper dbHelper;
        private int studentId;

        public FrmReporteCalificacionesEstudiante(int studentId = -1)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            this.studentId = studentId;
            CargarCalificacionesEstudiante();
        }

        private void CargarCalificacionesEstudiante()
        {
            try
            {
                if (studentId <= 0)
                    return;

                // Obtener nombre del estudiante
                string queryEstudiante = @"
                    SELECT u.username FROM students s
                    INNER JOIN users u ON s.user_id = u.user_id
                    WHERE s.student_id = @studentId";

                string nombreEstudiante = "Desconocido";
                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(queryEstudiante, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        nombreEstudiante = result.ToString();
                }

                // Actualizar encabezado
                lblNombreEstudiante.Text = nombreEstudiante;
                lblFecha.Text = DateTime.Now.ToString("dd 'de' MMMM, yyyy");

                // Cargar calificaciones
                CargarCalificacionesEnDataGrid();

                // Calcular estadísticas
                ActualizarEstadisticas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar calificaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCalificacionesEnDataGrid()
        {
            try
            {
                string query = @"
                    SELECT
                        t.title AS Tarea,
                        FORMAT(ts.submitted_at, 'dd/MM/yyyy HH:mm') AS FechaEntrega,
                        ISNULL(ts.score, 'N/A') AS Calificacion,
                        ISNULL(ts.feedback, 'Sin comentarios') AS Feedback,
                        CASE
                            WHEN ts.score IS NULL THEN '⏳ Pendiente'
                            ELSE '✅ Calificada'
                        END AS Estado
                    FROM task_submissions ts
                    INNER JOIN tasks t ON ts.task_id = t.task_id
                    WHERE ts.student_id = @studentId
                    ORDER BY ts.submitted_at DESC";

                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    DataTable dt = new DataTable();
                    using (var adapter = new System.Data.SqlClient.SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    dgvCalificaciones.DataSource = dt;

                    // Ajustar ancho de columnas
                    if (dgvCalificaciones.Columns.Count > 0)
                    {
                        dgvCalificaciones.Columns[0].Width = 150; // Tarea
                        dgvCalificaciones.Columns[1].Width = 130; // FechaEntrega
                        dgvCalificaciones.Columns[2].Width = 100; // Calificacion
                        dgvCalificaciones.Columns[3].Width = 250; // Feedback
                        dgvCalificaciones.Columns[4].Width = 110; // Estado
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar calificaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEstadisticas()
        {
            try
            {
                string query = @"
                    SELECT
                        COUNT(*) AS TotalTareas,
                        COUNT(CASE WHEN score IS NOT NULL THEN 1 END) AS Calificadas,
                        AVG(CAST(score AS DECIMAL(5,2))) AS Promedio,
                        MAX(CAST(score AS DECIMAL(5,2))) AS MaximaCalificacion,
                        MIN(CAST(score AS DECIMAL(5,2))) AS MinimaCalificacion
                    FROM task_submissions
                    WHERE student_id = @studentId";

                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int totalTareas = Convert.ToInt32(reader["TotalTareas"]);
                            int calificadas = Convert.ToInt32(reader["Calificadas"]);
                            decimal promedio = reader["Promedio"] != DBNull.Value ? Convert.ToDecimal(reader["Promedio"]) : 0;
                            decimal maxima = reader["MaximaCalificacion"] != DBNull.Value ? Convert.ToDecimal(reader["MaximaCalificacion"]) : 0;
                            decimal minima = reader["MinimaCalificacion"] != DBNull.Value ? Convert.ToDecimal(reader["MinimaCalificacion"]) : 0;

                            // Actualizar labels
                            lblTotalTareas.Text = totalTareas.ToString();
                            lblCalificadas.Text = calificadas.ToString();
                            lblPromedio.Text = promedio > 0 ? promedio.ToString("F2") : "N/A";
                            lblMaxima.Text = maxima > 0 ? maxima.ToString("F2") : "N/A";
                            lblMinima.Text = minima > 0 ? minima.ToString("F2") : "N/A";

                            // Actualizar barra de progreso
                            if (totalTareas > 0)
                            {
                                decimal porcentajeCalificado = (decimal)calificadas * 100 / totalTareas;
                                prgCalificadas.Value = (int)porcentajeCalificado;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular estadísticas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
