using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Presentation
{
    public class VocabularyService
    {
        private readonly DatabaseHelper dbHelper;
        private readonly string connectionString;

        public VocabularyService()
        {
            dbHelper = new DatabaseHelper();
            connectionString = dbHelper?.ConnectionString ?? string.Empty;
        }

        // =====================================================
        // LISTAS
        // =====================================================

        public DataTable ObtenerListasUsuario(int userId, bool incluirPublicas = true)
        {
            var dt = new DataTable();
            try
            {
                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand("sp_GetUserVocabularyLists", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@IncludePublic", incluirPublicas);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener listas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public int CrearLista(int userId, string nombre, string descripcion,
                              string icono, string colorHex, bool isPublic = false)
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand("sp_InsertVocabularyList", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@ListName", nombre ?? string.Empty);
                cmd.Parameters.AddWithValue("@Description", descripcion ?? string.Empty);
                cmd.Parameters.AddWithValue("@Icon", icono ?? "📚");
                cmd.Parameters.AddWithValue("@ColorCode", colorHex ?? "#4299E1");
                cmd.Parameters.AddWithValue("@IsPublic", isPublic);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la lista: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public bool EliminarLista(int listId)
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand(
                    "UPDATE vocabulary_lists SET is_active=0 WHERE list_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", listId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar lista: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // =====================================================
        // PALABRAS
        // =====================================================

        public DataTable ObtenerPalabrasDeLista(int listId)
        {
            var dt = new DataTable();
            try
            {
                string q = @"SELECT word_id, word_english, word_spanish,
                                    image_url, audio_url, date_added
                             FROM list_words
                             WHERE list_id=@listId AND is_active=1
                             ORDER BY date_added DESC";
                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@listId", listId);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener palabras: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public int AgregarPalabra(int listId, string wordEnglish, string wordSpanish,
                                   string imageUrl, string audioUrl)
        {
            try
            {
                string q = @"INSERT INTO list_words
                                 (list_id,word_english,word_spanish,image_url,audio_url,date_added,is_active)
                             VALUES(@listId,@we,@ws,@img,@aud,GETDATE(),1);
                             SELECT SCOPE_IDENTITY();";
                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@listId", listId);
                cmd.Parameters.AddWithValue("@we", wordEnglish);
                cmd.Parameters.AddWithValue("@ws", wordSpanish);
                cmd.Parameters.AddWithValue("@img", string.IsNullOrEmpty(imageUrl) ? (object)DBNull.Value : imageUrl);
                cmd.Parameters.AddWithValue("@aud", string.IsNullOrEmpty(audioUrl) ? (object)DBNull.Value : audioUrl);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar palabra: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public bool EliminarPalabra(int wordId)
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand(
                    "UPDATE list_words SET is_active=0 WHERE word_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", wordId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar palabra: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // =====================================================
        // ANKI / PRÁCTICA
        // =====================================================

        /// <summary>Palabras que vencen hoy o sin progreso previo.</summary>
        public DataTable ObtenerPalabrasParaPracticar(int userId, int listId)
        {
            var dt = new DataTable();
            try
            {
                string q = @"
                    SELECT lw.word_id, lw.word_english, lw.word_spanish,
                           ISNULL(lw.image_url,'')      AS image_url,
                           ISNULL(lw.audio_url,'')      AS audio_url,
                           ISNULL(wp.ease_factor, 2.5)  AS ease_factor,
                           ISNULL(wp.interval_days, 1)  AS interval_days,
                           ISNULL(wp.times_correct, 0)  AS times_correct,
                           ISNULL(wp.times_wrong, 0)    AS times_wrong
                    FROM list_words lw
                    LEFT JOIN word_progress wp
                           ON lw.word_id = wp.word_id AND wp.user_id = @userId
                    WHERE lw.list_id = @listId
                      AND lw.is_active = 1
                      AND (wp.next_review IS NULL OR wp.next_review <= GETDATE())
                    ORDER BY wp.next_review ASC, lw.date_added ASC";

                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@listId", listId);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener palabras para practicar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        /// <summary>Todas las palabras de una lista (para generar distractores).</summary>
        public DataTable ObtenerTodasLasPalabras(int listId)
        {
            var dt = new DataTable();
            try
            {
                string q = @"SELECT word_id, word_english, word_spanish,
                                    ISNULL(image_url,'') AS image_url,
                                    ISNULL(audio_url,'') AS audio_url
                             FROM list_words
                             WHERE list_id=@listId AND is_active=1";
                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@listId", listId);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        /// <summary>Actualiza progreso SM-2. calidad: 0=difícil, 3=bien, 5=fácil.</summary>
        public void ActualizarProgresoAnki(int userId, int wordId, int calidad)
        {
            try
            {
                string selectQ = @"SELECT progress_id, ease_factor, interval_days
                                   FROM word_progress
                                   WHERE user_id=@userId AND word_id=@wordId";

                int progressId = 0;
                double easeFactor = 2.5;
                int intervalDays = 1;

                using var conn = new SqlConnection(connectionString);
                conn.Open();

                using (var cmd = new SqlCommand(selectQ, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@wordId", wordId);
                    using var r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        progressId = Convert.ToInt32(r["progress_id"]);
                        easeFactor = Convert.ToDouble(r["ease_factor"]);
                        intervalDays = Convert.ToInt32(r["interval_days"]);
                    }
                }

                // SM-2
                if (calidad >= 3)
                {
                    intervalDays = intervalDays <= 1 ? 3
                                 : intervalDays == 3 ? 7
                                 : (int)Math.Round(intervalDays * easeFactor);
                    easeFactor = Math.Max(1.3,
                        easeFactor + 0.1 - (5 - calidad) * (0.08 + (5 - calidad) * 0.02));
                }
                else
                {
                    intervalDays = 1;
                    easeFactor = Math.Max(1.3, easeFactor - 0.2);
                }

                DateTime next = DateTime.Now.AddDays(intervalDays);
                int cor = calidad >= 3 ? 1 : 0;
                int wrg = calidad < 3 ? 1 : 0;

                if (progressId == 0)
                {
                    string ins = @"INSERT INTO word_progress
                        (user_id,word_id,ease_factor,interval_days,next_review,
                         times_correct,times_wrong,last_reviewed)
                        VALUES(@uid,@wid,@ef,@iv,@nr,@tc,@tw,GETDATE())";
                    using var cmd = new SqlCommand(ins, conn);
                    cmd.Parameters.AddWithValue("@uid", userId);
                    cmd.Parameters.AddWithValue("@wid", wordId);
                    cmd.Parameters.AddWithValue("@ef", easeFactor);
                    cmd.Parameters.AddWithValue("@iv", intervalDays);
                    cmd.Parameters.AddWithValue("@nr", next);
                    cmd.Parameters.AddWithValue("@tc", cor);
                    cmd.Parameters.AddWithValue("@tw", wrg);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string upd = @"UPDATE word_progress SET
                        ease_factor=@ef, interval_days=@iv, next_review=@nr,
                        times_correct=times_correct+@tc,
                        times_wrong=times_wrong+@tw,
                        last_reviewed=GETDATE()
                        WHERE progress_id=@pid";
                    using var cmd = new SqlCommand(upd, conn);
                    cmd.Parameters.AddWithValue("@ef", easeFactor);
                    cmd.Parameters.AddWithValue("@iv", intervalDays);
                    cmd.Parameters.AddWithValue("@nr", next);
                    cmd.Parameters.AddWithValue("@tc", cor);
                    cmd.Parameters.AddWithValue("@tw", wrg);
                    cmd.Parameters.AddWithValue("@pid", progressId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar progreso: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // DEPURACIÓN
        // =====================================================

        public DataTable ObtenerTodasLasListas()
        {
            var dt = new DataTable();
            try
            {
                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand(
                    "SELECT * FROM vocabulary_lists ORDER BY created_at DESC", conn);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
            return dt;
        }
    }
}