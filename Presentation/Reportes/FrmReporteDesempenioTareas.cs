using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmReporteDesempenioTareas : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable tareasData;

        public FrmReporteDesempenioTareas()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            CargarTareas();
        }

        private void CargarTareas()
        {
            try
            {
                string query = @"
                    SELECT t.task_id, t.title, g.group_name
                    FROM tasks t
                    INNER JOIN groups g ON t.group_id = g.group_id
                    WHERE t.status IN ('Active', 'Completed')
                    ORDER BY t.title";

                DataTable dt = new DataTable();
                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    conn.Open();
                    new System.Data.SqlClient.SqlDataAdapter(cmd).Fill(dt);
                }

                tareasData = dt;
                cmbTarea.Items.Clear();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string display = $"{row["title"]} ({row["group_name"]})";
                        cmbTarea.Items.Add(display);
                    }
                    cmbTarea.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No hay tareas disponibles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDesempenioTarea(int tareaIndex)
        {
            try
            {
                if (tareaIndex < 0 || tareaIndex >= tareasData.Rows.Count)
                    return;

                int taskId = Convert.ToInt32(tareasData.Rows[tareaIndex]["task_id"]);
                dgvDesempenio.Rows.Clear();

                // Obtener entregas de la tarea
                string queryEntregas = @"
                    SELECT
                        u.username,
                        ts.submission_date,
                        ts.score,
                        ts.feedback,
                        ts.status
                    FROM task_submissions ts
                    INNER JOIN students s ON ts.student_id = s.student_id
                    INNER JOIN users u ON s.user_id = u.user_id
                    WHERE ts.task_id = @taskId
                    ORDER BY u.username";

                DataTable dtEntregas = new DataTable();
                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(queryEntregas, conn))
                {
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    conn.Open();
                    new System.Data.SqlClient.SqlDataAdapter(cmd).Fill(dtEntregas);
                }

                int calificadas = 0;
                int entregadas = 0;

                foreach (DataRow row in dtEntregas.Rows)
                {
                    string nombre = row["username"].ToString();
                    string fechaEntrega = row["submission_date"] != DBNull.Value
                        ? Convert.ToDateTime(row["submission_date"]).ToString("dd/MM/yyyy HH:mm")
                        : "No entregó";
                    string calificacion = row["score"] != DBNull.Value
                        ? Convert.ToDecimal(row["score"]).ToString("F2")
                        : "---";
                    string feedback = row["feedback"] != DBNull.Value
                        ? row["feedback"].ToString().Substring(0, Math.Min(50, row["feedback"].ToString().Length)) + "..."
                        : "Sin retroalimentación";
                    string estado = DeterminarEstado(row["status"].ToString(), row["score"] != DBNull.Value);

                    if (row["submission_date"] != DBNull.Value)
                        entregadas++;
                    if (row["score"] != DBNull.Value)
                        calificadas++;

                    dgvDesempenio.Rows.Add(nombre, fechaEntrega, calificacion, feedback, estado);
                }

                ActualizarEstadisticas(dtEntregas.Rows.Count, entregadas, calificadas, taskId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar desempeño: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DeterminarEstado(string status, bool tieneCalificacion)
        {
            if (tieneCalificacion)
                return "✅ Calificada";
            else if (status == "Submitted")
                return "⏳ Pendiente";
            else
                return "🔴 No entregó";
        }

        private void ActualizarEstadisticas(int total, int entregadas, int calificadas, int taskId)
        {
            decimal porcentajeEntrega = total > 0 ? (decimal)entregadas * 100 / total : 0;
            decimal porcentajeCalificacion = total > 0 ? (decimal)calificadas * 100 / total : 0;

            // Obtener calificación promedio
            string queryPromedio = @"
                SELECT AVG(CAST(score AS DECIMAL(5,2)))
                FROM task_submissions
                WHERE task_id = @taskId AND score IS NOT NULL";

            decimal promedio = 0;
            using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(queryPromedio, conn))
            {
                cmd.Parameters.AddWithValue("@taskId", taskId);
                conn.Open();
                var result = cmd.ExecuteScalar();
                promedio = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }

            lblEstadisticas.Text = $"Total: {total} | Entregadas: {entregadas} ({porcentajeEntrega:F1}%) | Calificadas: {calificadas} ({porcentajeCalificacion:F1}%) | Promedio: {promedio:F2}";
        }

        private void CmbTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDesempenioTarea(cmbTarea.SelectedIndex);
        }
    }
}
