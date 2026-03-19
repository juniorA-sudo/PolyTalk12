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
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("sp_GetUserVocabularyLists", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@IncludePublic", incluirPublicas);
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener listas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public int CrearLista(int userId, string nombre, string descripcion, string icono, string colorHex, bool isPublic = false)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("sp_InsertVocabularyList", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@ListName", nombre ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(descripcion) ? "" : descripcion);
                    cmd.Parameters.AddWithValue("@Icon", icono ?? "📚");
                    cmd.Parameters.AddWithValue("@ColorCode", colorHex ?? "#4299E1");
                    cmd.Parameters.AddWithValue("@IsPublic", isPublic);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
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
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("UPDATE vocabulary_lists SET is_active = 0 WHERE list_id = @listId", conn))
                {
                    cmd.Parameters.AddWithValue("@listId", listId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
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
                string query = @"
                    SELECT word_id, word_english, word_spanish, image_url, audio_url, date_added
                    FROM list_words
                    WHERE list_id = @listId AND is_active = 1
                    ORDER BY date_added DESC";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@listId", listId);
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener palabras: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public int AgregarPalabra(int listId, string wordEnglish, string wordSpanish, string imageUrl, string audioUrl)
        {
            try
            {
                string query = @"
                    INSERT INTO list_words (list_id, word_english, word_spanish, image_url, audio_url, date_added, is_active)
                    VALUES (@listId, @wordEnglish, @wordSpanish, @imageUrl, @audioUrl, GETDATE(), 1);
                    SELECT SCOPE_IDENTITY();";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@listId", listId);
                    cmd.Parameters.AddWithValue("@wordEnglish", wordEnglish);
                    cmd.Parameters.AddWithValue("@wordSpanish", wordSpanish);
                    cmd.Parameters.AddWithValue("@imageUrl", string.IsNullOrEmpty(imageUrl) ? (object)DBNull.Value : imageUrl);
                    cmd.Parameters.AddWithValue("@audioUrl", string.IsNullOrEmpty(audioUrl) ? (object)DBNull.Value : audioUrl);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
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
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("UPDATE list_words SET is_active = 0 WHERE word_id = @wordId", conn))
                {
                    cmd.Parameters.AddWithValue("@wordId", wordId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar palabra: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // =====================================================
        // PROGRESO ANKI
        // =====================================================

        public DataTable ObtenerPalabrasParaPracticar(int userId, int listId)
        {
            var dt = new DataTable();
            try
            {
                string query = @"
                    SELECT
                        lw.word_id,
                        lw.word_english,
                        lw.word_spanish,
                        lw.image_url,
                        lw.audio_url,
                        ISNULL(wp.ease_factor, 2.5)  AS ease_factor,
                        ISNULL(wp.interval_days, 1)  AS interval_days,
                        ISNULL(wp.times_correct, 0)  AS times_correct,
                        ISNULL(wp.times_wrong, 0)    AS times_wrong
                    FROM list_words lw
                    LEFT JOIN word_progress wp ON lw.word_id = wp.word_id AND wp.user_id = @userId
                    WHERE lw.list_id = @listId
                      AND lw.is_active = 1
                      AND (wp.next_review IS NULL OR wp.next_review <= GETDATE())
                    ORDER BY wp.next_review ASC, lw.date_added ASC";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@listId", listId);
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener palabras para practicar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable ObtenerTodasLasPalabras(int listId)
        {
            var dt = new DataTable();
            try
            {
                string query = @"
                    SELECT word_id, word_english, word_spanish, image_url, audio_url
                    FROM list_words
                    WHERE list_id = @listId AND is_active = 1";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@listId", listId);
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

        /// <summary>
        /// Actualiza el progreso Anki usando el algoritmo SM-2.
        /// calidad: 0 = Difícil, 3 = Bien, 5 = Fácil
        /// </summary>
        public void ActualizarProgresoAnki(int userId, int wordId, int calidad)
        {
            try
            {
                string selectQuery = @"
                    SELECT progress_id, ease_factor, interval_days
                    FROM word_progress
                    WHERE user_id = @userId AND word_id = @wordId";

                int progressId = 0;
                double easeFactor = 2.5;
                int intervalDays = 1;

                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (var cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@wordId", wordId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                progressId = Convert.ToInt32(reader["progress_id"]);
                                easeFactor = Convert.ToDouble(reader["ease_factor"]);
                                intervalDays = Convert.ToInt32(reader["interval_days"]);
                            }
                        }
                    }

                    // Algoritmo SM-2
                    if (calidad >= 3) // Correcto
                    {
                        if (intervalDays == 1)
                            intervalDays = 3;
                        else if (intervalDays == 3)
                            intervalDays = 7;
                        else
                            intervalDays = (int)Math.Round(intervalDays * easeFactor);

                        easeFactor += 0.1 - (5 - calidad) * (0.08 + (5 - calidad) * 0.02);
                        if (easeFactor < 1.3) easeFactor = 1.3;
                    }
                    else // Difícil — reiniciar
                    {
                        intervalDays = 1;
                        easeFactor = Math.Max(1.3, easeFactor - 0.2);
                    }

                    DateTime nextReview = DateTime.Now.AddDays(intervalDays);

                    if (progressId == 0)
                    {
                        string insertQuery = @"
                            INSERT INTO word_progress
                                (user_id, word_id, ease_factor, interval_days, next_review, times_correct, times_wrong, last_reviewed)
                            VALUES
                                (@userId, @wordId, @easeFactor, @intervalDays, @nextReview, @correct, @wrong, GETDATE())";

                        using (var cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.Parameters.AddWithValue("@wordId", wordId);
                            cmd.Parameters.AddWithValue("@easeFactor", easeFactor);
                            cmd.Parameters.AddWithValue("@intervalDays", intervalDays);
                            cmd.Parameters.AddWithValue("@nextReview", nextReview);
                            cmd.Parameters.AddWithValue("@correct", calidad >= 3 ? 1 : 0);
                            cmd.Parameters.AddWithValue("@wrong", calidad < 3 ? 1 : 0);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string updateQuery = @"
                            UPDATE word_progress SET
                                ease_factor   = @easeFactor,
                                interval_days = @intervalDays,
                                next_review   = @nextReview,
                                times_correct = times_correct + @correct,
                                times_wrong   = times_wrong   + @wrong,
                                last_reviewed = GETDATE()
                            WHERE progress_id = @progressId";

                        using (var cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@easeFactor", easeFactor);
                            cmd.Parameters.AddWithValue("@intervalDays", intervalDays);
                            cmd.Parameters.AddWithValue("@nextReview", nextReview);
                            cmd.Parameters.AddWithValue("@correct", calidad >= 3 ? 1 : 0);
                            cmd.Parameters.AddWithValue("@wrong", calidad < 3 ? 1 : 0);
                            cmd.Parameters.AddWithValue("@progressId", progressId);
                            cmd.ExecuteNonQuery();
                        }
                    }
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
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("SELECT * FROM vocabulary_lists ORDER BY created_at DESC", conn))
                {
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return dt;
        }
    }
}