using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Presentation
{
    public class TaskService
    {
        private readonly string connectionString;

        public TaskService()
        {
            var db = new DatabaseHelper();
            connectionString = db.ConnectionString;
        }

        // =====================================================
        // MAESTRO - TAREAS
        // =====================================================

        public DataTable ObtenerTareasMaestro(int teacherId)
        {
            var dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("SP_GetTasksByTeacher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@teacher_id", teacherId);
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener tareas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public int CrearTarea(string titulo, string descripcion, int teacherId, int groupId,
            int? unitId, DateTime fechaAsignacion, DateTime fechaEntrega,
            int maxScore, string tipoEntrega, bool allowLate, bool showGrade, string status)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("SP_CreateTask", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@title", titulo);
                    cmd.Parameters.AddWithValue("@description", descripcion ?? "");
                    cmd.Parameters.AddWithValue("@teacher_id", teacherId);
                    cmd.Parameters.AddWithValue("@group_id", groupId);
                    cmd.Parameters.AddWithValue("@unit_id", unitId.HasValue ? (object)unitId.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@assigned_date", fechaAsignacion.Date);
                    cmd.Parameters.AddWithValue("@due_date", fechaEntrega.Date);
                    cmd.Parameters.AddWithValue("@max_score", maxScore);
                    cmd.Parameters.AddWithValue("@submission_type", tipoEntrega);
                    cmd.Parameters.AddWithValue("@allow_late", allowLate);
                    cmd.Parameters.AddWithValue("@show_grade", showGrade);
                    cmd.Parameters.AddWithValue("@status", status);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear tarea: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public DataTable ObtenerEntregasDeTarea(int taskId)
        {
            var dt = new DataTable();
            try
            {
                string query = @"
                    SELECT
                        ts.submission_id,
                        ts.student_id,
                        u.username          AS student_name,
                        ts.comment,
                        ts.file_name,
                        ts.submitted_at,
                        ts.is_late,
                        ts.status,
                        ts.score,
                        ts.feedback,
                        ts.graded_at
                    FROM task_submissions ts
                    INNER JOIN students s ON ts.student_id = s.student_id
                    INNER JOIN users u    ON s.user_id     = u.user_id
                    WHERE ts.task_id = @taskId
                    ORDER BY ts.submitted_at DESC";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener entregas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public bool CalificarEntrega(int submissionId, decimal score, string feedback)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("SP_GradeSubmission", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@submission_id", submissionId);
                    cmd.Parameters.AddWithValue("@score", score);
                    cmd.Parameters.AddWithValue("@feedback", feedback ?? "");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calificar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable ObtenerGruposDelMaestro(int teacherId)
        {
            var dt = new DataTable();
            try
            {
                string query = @"
                    SELECT g.group_id, g.group_name, g.english_level
                    FROM groups g
                    WHERE g.teacher_id = @teacherId
                    ORDER BY g.group_name";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener grupos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable ObtenerUnidades()
        {
            var dt = new DataTable();
            try
            {
                string query = @"
                    SELECT u.unit_id, u.unit_title, l.level_name
                    FROM units u
                    INNER JOIN levels l ON u.level_id = l.level_id
                    WHERE u.is_active = 1
                    ORDER BY l.display_order, u.unit_number";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener unidades: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        // =====================================================
        // ESTUDIANTE - TAREAS
        // =====================================================

        public DataTable ObtenerTareasEstudiante(int studentId)
        {
            var dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("SP_GetTasksByStudent", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@student_id", studentId);
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener tareas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public bool EntregarTarea(int taskId, int studentId, string comentario, string nombreArchivo)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("SP_SubmitTask", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@task_id", taskId);
                    cmd.Parameters.AddWithValue("@student_id", studentId);
                    cmd.Parameters.AddWithValue("@comment", comentario ?? "");
                    cmd.Parameters.AddWithValue("@file_path", nombreArchivo ?? "");
                    cmd.Parameters.AddWithValue("@file_name", nombreArchivo ?? "");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al entregar tarea: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable ObtenerDetalleTarea(int taskId)
        {
            var dt = new DataTable();
            try
            {
                string query = @"
                    SELECT
                        t.task_id, t.title, t.description,
                        t.assigned_date, t.due_date, t.max_score,
                        t.submission_type, t.allow_late, t.show_grade,
                        u.username AS teacher_name,
                        g.group_name
                    FROM tasks t
                    INNER JOIN teachers tc ON t.teacher_id = tc.teacher_id
                    INNER JOIN users u     ON tc.user_id   = u.user_id
                    INNER JOIN groups g    ON t.group_id   = g.group_id
                    WHERE t.task_id = @taskId";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}