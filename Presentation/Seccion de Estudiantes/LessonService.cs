using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Presentation
{
    public class LessonService
    {
        private readonly string connectionString;

        public LessonService()
        {
            connectionString = ConfigurationHelper.GetConnectionString();
        }

        // =====================================================
        // CONTENIDO DE LA LECCIÓN (explicación)
        // =====================================================
        public DataTable ObtenerContenidoLeccion(int lessonId)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT content_id, title, explanation, image_url, audio_url, display_order
                FROM lesson_content
                WHERE lesson_id = @lessonId
                ORDER BY display_order";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@lessonId", lessonId);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        public void GuardarContenido(int lessonId, string title, string explanation,
                                     string imageUrl, string audioUrl, int displayOrder)
        {
            string query = @"
                INSERT INTO lesson_content (lesson_id, title, explanation, image_url, audio_url, display_order)
                VALUES (@lessonId, @title, @explanation, @imageUrl, @audioUrl, @displayOrder)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@lessonId", lessonId);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@explanation", explanation);
                cmd.Parameters.AddWithValue("@imageUrl", (object)imageUrl ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@audioUrl", (object)audioUrl ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@displayOrder", displayOrder);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // =====================================================
        // ACTIVIDADES
        // =====================================================
        public DataTable ObtenerActividades(int lessonId)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT activity_id, activity_type, instruction, content,
                       correct_answer, audio_url, image_url, display_order
                FROM lesson_activities
                WHERE lesson_id = @lessonId
                ORDER BY display_order";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@lessonId", lessonId);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        public int GuardarActividad(int lessonId, string activityType, string instruction,
                                    string content, string correctAnswer,
                                    string audioUrl, string imageUrl, int displayOrder)
        {
            string query = @"
                INSERT INTO lesson_activities
                    (lesson_id, activity_type, instruction, content, correct_answer, audio_url, image_url, display_order)
                VALUES
                    (@lessonId, @type, @instruction, @content, @correctAnswer, @audioUrl, @imageUrl, @displayOrder);
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@lessonId", lessonId);
                cmd.Parameters.AddWithValue("@type", activityType);
                cmd.Parameters.AddWithValue("@instruction", instruction);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.Parameters.AddWithValue("@correctAnswer", correctAnswer);
                cmd.Parameters.AddWithValue("@audioUrl", (object)audioUrl ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@imageUrl", (object)imageUrl ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@displayOrder", displayOrder);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // =====================================================
        // OPCIONES (opción múltiple)
        // =====================================================
        public DataTable ObtenerOpciones(int activityId)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT option_id, option_text, is_correct, display_order
                FROM activity_options
                WHERE activity_id = @activityId
                ORDER BY display_order";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@activityId", activityId);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        public void GuardarOpcion(int activityId, string optionText, bool isCorrect, int displayOrder)
        {
            string query = @"
                INSERT INTO activity_options (activity_id, option_text, is_correct, display_order)
                VALUES (@activityId, @optionText, @isCorrect, @displayOrder)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@activityId", activityId);
                cmd.Parameters.AddWithValue("@optionText", optionText);
                cmd.Parameters.AddWithValue("@isCorrect", isCorrect ? 1 : 0);
                cmd.Parameters.AddWithValue("@displayOrder", displayOrder);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // =====================================================
        // PROGRESO DEL ESTUDIANTE
        // =====================================================
        public void IniciarLeccion(int studentId, int lessonId, int totalActividades)
        {
            // Si ya existe, no duplicar
            string check = "SELECT COUNT(*) FROM lesson_progress WHERE student_id=@s AND lesson_id=@l";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(check, conn))
                {
                    cmd.Parameters.AddWithValue("@s", studentId);
                    cmd.Parameters.AddWithValue("@l", lessonId);
                    int existe = (int)cmd.ExecuteScalar();
                    if (existe > 0) return;
                }

                string insert = @"
                    INSERT INTO lesson_progress
                        (student_id, lesson_id, total_activities, completed_activities,
                         score, started_at, completed_at)
                    VALUES (@s, @l, @total, 0, 0, GETDATE(), NULL)";

                using (SqlCommand cmd = new SqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@s", studentId);
                    cmd.Parameters.AddWithValue("@l", lessonId);
                    cmd.Parameters.AddWithValue("@total", totalActividades);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CompletarLeccion(int studentId, int lessonId, int correctas, int total)
        {
            decimal score = total > 0 ? Math.Round((decimal)correctas / total * 100, 2) : 0;

            string query = @"
                UPDATE lesson_progress
                SET completed_activities = @correctas,
                    total_activities     = @total,
                    score                = @score,
                    completed_at         = GETDATE()
                WHERE student_id = @s AND lesson_id = @l";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@correctas", correctas);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.Parameters.AddWithValue("@s", studentId);
                cmd.Parameters.AddWithValue("@l", lessonId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public (int completadas, int total, decimal score) ObtenerProgreso(int studentId, int lessonId)
        {
            string query = @"
                SELECT completed_activities, total_activities, score
                FROM lesson_progress
                WHERE student_id = @s AND lesson_id = @l";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@s", studentId);
                cmd.Parameters.AddWithValue("@l", lessonId);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                        return (r.GetInt32(0), r.GetInt32(1), r.IsDBNull(2) ? 0 : r.GetDecimal(2));
                }
            }
            return (0, 0, 0);
        }

        // =====================================================
        // INFO BÁSICA DE LECCIÓN
        // =====================================================
        public DataRow ObtenerInfoLeccion(int lessonId)
        {
            string query = @"
                SELECT l.lesson_id, l.lesson_title, l.lesson_description,
                       l.lesson_type, l.duration_minutes,
                       u.unit_title, lv.level_code
                FROM lessons l
                INNER JOIN units u  ON l.unit_id  = u.unit_id
                INNER JOIN levels lv ON u.level_id = lv.level_id
                WHERE l.lesson_id = @lessonId";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@lessonId", lessonId);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        // =====================================================
        // LECCIONES POR UNIDAD (para el maestro)
        // =====================================================
        public DataTable ObtenerLeccionesPorUnidad(int unitId)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT l.lesson_id, l.lesson_title, l.lesson_type,
                       l.duration_minutes, l.display_order,
                       (SELECT COUNT(*) FROM lesson_activities WHERE lesson_id = l.lesson_id) AS total_actividades,
                       (SELECT COUNT(*) FROM lesson_content    WHERE lesson_id = l.lesson_id) AS tiene_contenido
                FROM lessons l
                WHERE l.unit_id = @unitId AND l.is_active = 1
                ORDER BY l.display_order";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@unitId", unitId);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        // =====================================================
        // CREAR LECCIÓN
        // =====================================================
        public int CrearLeccion(int unitId, string title, string description,
                                string lessonType, int durationMinutes, int displayOrder)
        {
            string query = @"
                INSERT INTO lessons (unit_id, lesson_number, lesson_title, lesson_description,
                                     lesson_type, duration_minutes, display_order, is_active, created_at)
                VALUES (@unitId,
                        (SELECT ISNULL(MAX(lesson_number),0)+1 FROM lessons WHERE unit_id=@unitId),
                        @title, @desc, @type, @duration, @order, 1, GETDATE());
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@unitId", unitId);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@desc", description);
                cmd.Parameters.AddWithValue("@type", lessonType);
                cmd.Parameters.AddWithValue("@duration", durationMinutes);
                cmd.Parameters.AddWithValue("@order", displayOrder);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}