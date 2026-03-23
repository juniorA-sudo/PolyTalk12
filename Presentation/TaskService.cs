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
                string query = @"
                    SELECT
                        t.task_id,
                        t.title,
                        t.description,
                        g.group_name,
                        t.assigned_date,
                        t.due_date,
                        t.max_score,
                        t.submission_type,
                        t.status,
                        DATEDIFF(DAY, GETDATE(), t.due_date) AS days_remaining,
                        (SELECT COUNT(*) FROM task_submissions ts WHERE ts.task_id = t.task_id) AS total_submissions,
                        (SELECT COUNT(*) FROM enrollments e WHERE e.group_id = t.group_id AND e.status = 'activo') AS total_students
                    FROM tasks t
                    INNER JOIN groups g ON t.group_id = g.group_id
                    WHERE t.teacher_id = @teacher_id
                    ORDER BY t.due_date DESC";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
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
                string query = @"
                    INSERT INTO tasks (title, description, teacher_id, group_id, unit_id,
                                       assigned_date, due_date, max_score, submission_type,
                                       allow_late, show_grade, status)
                    VALUES (@title, @description, @teacher_id, @group_id, @unit_id,
                            @assigned_date, @due_date, @max_score, @submission_type,
                            @allow_late, @show_grade, @status);
                    SELECT SCOPE_IDENTITY();";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
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
                string query = @"
                    UPDATE task_submissions
                    SET score     = @score,
                        feedback  = @feedback,
                        status    = 'Graded',
                        graded_at = GETDATE()
                    WHERE submission_id = @submission_id";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
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
                string query = @"
                    SELECT
                        t.task_id,
                        t.title,
                        t.description,
                        g.group_name,
                        u.username                              AS teacher_name,
                        t.assigned_date,
                        t.due_date,
                        t.max_score,
                        t.submission_type,
                        DATEDIFF(DAY, GETDATE(), t.due_date)    AS days_remaining,
                        CASE
                            WHEN ts.submission_id IS NULL AND t.due_date < CAST(GETDATE() AS DATE) THEN 'Expired'
                            WHEN ts.submission_id IS NULL THEN 'Pending'
                            WHEN ts.status = 'Graded' THEN 'Graded'
                            ELSE 'Submitted'
                        END                                     AS task_status,
                        ts.score,
                        ts.feedback,
                        ts.file_name                            AS submitted_file,
                        ts.comment                              AS student_comment,
                        ts.submitted_at,
                        ts.submission_id
                    FROM tasks t
                    INNER JOIN groups g      ON t.group_id   = g.group_id
                    INNER JOIN teachers tc   ON t.teacher_id = tc.teacher_id
                    INNER JOIN users u       ON tc.user_id   = u.user_id
                    INNER JOIN enrollments e ON e.group_id   = t.group_id
                                            AND e.student_id = @student_id
                                            AND e.status     = 'activo'
                    LEFT JOIN task_submissions ts ON ts.task_id    = t.task_id
                                                 AND ts.student_id = @student_id
                    WHERE t.status = 'Active'
                    ORDER BY t.due_date ASC";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
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
                string query = @"
                    DECLARE @due_date DATE;
                    SELECT @due_date = due_date FROM tasks WHERE task_id = @task_id;
                    DECLARE @is_late BIT = CASE WHEN CAST(GETDATE() AS DATE) > @due_date THEN 1 ELSE 0 END;

                    IF EXISTS (SELECT 1 FROM task_submissions WHERE task_id = @task_id AND student_id = @student_id)
                    BEGIN
                        UPDATE task_submissions
                        SET comment      = @comment,
                            file_path    = @file_name,
                            file_name    = @file_name,
                            submitted_at = GETDATE(),
                            is_late      = @is_late,
                            status       = 'Submitted',
                            score        = NULL,
                            feedback     = NULL,
                            graded_at    = NULL
                        WHERE task_id = @task_id AND student_id = @student_id;
                    END
                    ELSE
                    BEGIN
                        INSERT INTO task_submissions (task_id, student_id, comment, file_path, file_name, submitted_at, is_late, status)
                        VALUES (@task_id, @student_id, @comment, @file_name, @file_name, GETDATE(), @is_late, 'Submitted');
                    END";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@task_id", taskId);
                    cmd.Parameters.AddWithValue("@student_id", studentId);
                    cmd.Parameters.AddWithValue("@comment", comentario ?? "");
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
