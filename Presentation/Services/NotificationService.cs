using System;
using System.Data;
using System.Collections.Generic;
using Presentation.Helpers;

namespace Presentation.Services
{
    /// <summary>
    /// Servicio centralizado para gestión de notificaciones
    /// Proporciona conteos de tareas pendientes, entregas, etc.
    /// </summary>
    public class NotificationService
    {
        private readonly DatabaseHelper dbHelper;

        public NotificationService()
        {
            dbHelper = new DatabaseHelper();
        }

        /// <summary>Obtiene conteo de tareas pendientes para un estudiante</summary>
        public int ObtenerTareasPendientesEstudiante(int studentId)
        {
            try
            {
                string query = @"
                    SELECT COUNT(*) as 'Count'
                    FROM task_submissions ts
                    WHERE ts.student_id = @studentId
                    AND ts.status != 'Graded'";

                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
            catch { return 0; }
        }

        /// <summary>Obtiene conteo de calificaciones pendientes para un maestro</summary>
        public int ObtenerCalificacionesPendientesMaestro(int teacherId)
        {
            try
            {
                string query = @"
                    SELECT COUNT(*) as 'Count'
                    FROM task_submissions ts
                    INNER JOIN tasks t ON ts.task_id = t.task_id
                    WHERE t.teacher_id = @teacherId
                    AND ts.status = 'Submitted'";

                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
            catch { return 0; }
        }

        /// <summary>Obtiene tareas próximas a vencer (próximos 3 días) para un estudiante</summary>
        public DataTable ObtenerTareasProximasAVencer(int studentId)
        {
            try
            {
                string query = @"
                    SELECT TOP 5
                        t.task_id,
                        t.title,
                        t.due_date,
                        DATEDIFF(DAY, GETDATE(), t.due_date) as 'DiasRestantes'
                    FROM tasks t
                    WHERE DATEDIFF(DAY, GETDATE(), t.due_date) BETWEEN 0 AND 3
                    AND t.task_id IN (
                        SELECT DISTINCT ts.task_id
                        FROM task_submissions ts
                        WHERE ts.student_id = @studentId
                        AND ts.status != 'Graded'
                    )
                    ORDER BY t.due_date ASC";

                DataTable dt = new DataTable();
                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    new System.Data.SqlClient.SqlDataAdapter(cmd).Fill(dt);
                }
                return dt;
            }
            catch { return new DataTable(); }
        }

        /// <summary>Obtiene tareas sin calificar próximas a vencer para un maestro</summary>
        public DataTable ObtenerEntregasSinCalificarProximas(int teacherId)
        {
            try
            {
                string query = @"
                    SELECT TOP 5
                        ts.submission_id,
                        t.title,
                        u.name as 'StudentName',
                        ts.submitted_at,
                        DATEDIFF(DAY, GETDATE(), t.due_date) as 'DiasRestantes'
                    FROM task_submissions ts
                    INNER JOIN tasks t ON ts.task_id = t.task_id
                    INNER JOIN users u ON ts.student_id = u.user_id
                    WHERE t.teacher_id = @teacherId
                    AND ts.status = 'Submitted'
                    AND DATEDIFF(DAY, GETDATE(), t.due_date) <= 3
                    ORDER BY ts.submitted_at ASC";

                DataTable dt = new DataTable();
                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    conn.Open();
                    new System.Data.SqlClient.SqlDataAdapter(cmd).Fill(dt);
                }
                return dt;
            }
            catch { return new DataTable(); }
        }

        /// <summary>Obtiene conteo de lecciones sin completar para un estudiante</summary>
        public int ObtenerLeccionesIncompletas(int studentId)
        {
            try
            {
                string query = @"
                    SELECT COUNT(*) as 'Count'
                    FROM lessons l
                    WHERE l.lesson_id NOT IN (
                        SELECT lp.lesson_id
                        FROM lesson_progress lp
                        WHERE lp.student_id = @studentId
                        AND lp.completed_at IS NOT NULL
                    )";

                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
            catch { return 0; }
        }

        /// <summary>Obtiene conteo de estudiantes sin calificar para un maestro</summary>
        public int ObtenerEstudiantesSinCalificar(int teacherId)
        {
            try
            {
                string query = @"
                    SELECT COUNT(DISTINCT ts.student_id) as 'Count'
                    FROM task_submissions ts
                    INNER JOIN tasks t ON ts.task_id = t.task_id
                    WHERE t.teacher_id = @teacherId
                    AND ts.status = 'Submitted'";

                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
            catch { return 0; }
        }
    }
}
