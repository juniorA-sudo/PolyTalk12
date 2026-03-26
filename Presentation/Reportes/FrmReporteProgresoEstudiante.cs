using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Reportes
{
    public partial class FrmReporteProgresoEstudiante : Form
    {
        private DatabaseHelper dbHelper;
        private int studentId;

        public FrmReporteProgresoEstudiante(int studentId = -1)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            this.studentId = studentId;
            CargarProgresoEstudiante();
        }

        private void CargarProgresoEstudiante()
        {
            try
            {
                if (studentId <= 0)
                {
                    lblNombreEstudiante.Text = "Estudiante no seleccionado";
                    return;
                }

                // Obtener nombre del estudiante
                string nombreEstudiante = "Desconocido";
                try
                {
                    string queryEstudiante = @"SELECT u.username FROM students s
                                               INNER JOIN users u ON s.user_id = u.user_id
                                               WHERE s.student_id = @studentId";
                    using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                    using (var cmd = new System.Data.SqlClient.SqlCommand(queryEstudiante, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        conn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                            nombreEstudiante = result.ToString();
                    }
                }
                catch { }

                // Calcular progreso
                try
                {
                    int leccionesCompletadas = ObtenerLeccionesCompletadas(studentId);
                    int leccionesTotales = ObtenerTotalLecciones();
                    decimal leccionesPorcentaje = leccionesTotales > 0 ? (decimal)leccionesCompletadas * 100 / leccionesTotales : 0;

                    int palabrasAprendidas = ObtenerPalabrasAprendidas(studentId);
                    int palabrasTotales = ObtenerTotalPalabras();
                    decimal vocabularioPorcentaje = palabrasTotales > 0 ? (decimal)palabrasAprendidas * 100 / palabrasTotales : 0;

                    int tareasEntregadas = ObtenerTareasEntregadas(studentId);
                    int tareasTotales = ObtenerTotalTareas();
                    decimal tareasPorcentaje = tareasTotales > 0 ? (decimal)tareasEntregadas * 100 / tareasTotales : 0;

                    decimal promedioCalificaciones = ObtenerPromedioCalificaciones(studentId);

                    // Actualizar UI
                    lblNombreEstudiante.Text = nombreEstudiante;
                    lblFecha.Text = DateTime.Now.ToString("dd 'de' MMMM, yyyy");

                    // Limitar valores a 100
                    prgLecciones.Value = Math.Min((int)leccionesPorcentaje, 100);
                    lblLeccionesVal.Text = $"{leccionesCompletadas}/{leccionesTotales} ({leccionesPorcentaje:F1}%)";

                    prgVocabulario.Value = Math.Min((int)vocabularioPorcentaje, 100);
                    lblVocabularioVal.Text = $"{palabrasAprendidas}/{palabrasTotales} ({vocabularioPorcentaje:F1}%)";

                    prgTareas.Value = Math.Min((int)tareasPorcentaje, 100);
                    lblTareasVal.Text = $"{tareasEntregadas}/{tareasTotales} ({tareasPorcentaje:F1}%)";

                    lblPromedioVal.Text = promedioCalificaciones > 0 ? promedioCalificaciones.ToString("F2") : "N/A";

                    // Calcular nivel estimado
                    string nivelEstimado = DeterminarNivel(leccionesPorcentaje, promedioCalificaciones);
                    lblNivelVal.Text = nivelEstimado;

                    // Actualizar resumen
                    decimal progresoGeneral = (leccionesPorcentaje + vocabularioPorcentaje + tareasPorcentaje) / 3;
                    prgGeneral.Value = Math.Min((int)progresoGeneral, 100);
                    lblGeneralVal.Text = $"{progresoGeneral:F1}%";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al calcular progreso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar progreso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerLeccionesCompletadas(int studentId)
        {
            string query = "SELECT COUNT(*) FROM lesson_progress WHERE student_id = @studentId AND completed_at IS NOT NULL";
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
                return result != null ? (int)result : 0;
            }
        }

        private int ObtenerTotalPalabras()
        {
            string query = "SELECT COUNT(*) FROM vocabulary_items";
            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private int ObtenerTareasEntregadas(int studentId)
        {
            string query = "SELECT COUNT(*) FROM task_submissions WHERE student_id = @studentId";
            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@studentId", studentId);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private int ObtenerTotalTareas()
        {
            string query = "SELECT COUNT(*) FROM tasks WHERE status IN ('Active', 'Completed')";
            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private decimal ObtenerPromedioCalificaciones(int studentId)
        {
            string query = "SELECT AVG(CAST(score AS DECIMAL(5,2))) FROM task_submissions WHERE student_id = @studentId AND score IS NOT NULL";
            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@studentId", studentId);
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null && result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private string DeterminarNivel(decimal leccionesCompletas, decimal promedio)
        {
            if (leccionesCompletas >= 80 && promedio >= 80)
                return "🟢 Avanzado (C1-C2)";
            else if (leccionesCompletas >= 60 && promedio >= 70)
                return "🟡 Intermedio (B1-B2)";
            else if (leccionesCompletas >= 40 && promedio >= 60)
                return "🟠 Básico (A2)";
            else
                return "🔵 Elemental (A1)";
        }
    }
}
