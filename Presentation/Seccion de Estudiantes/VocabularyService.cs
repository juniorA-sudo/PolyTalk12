using System;
using System.Data;
using System.Data.SqlClient;
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
        // MÉTODOS PARA LISTAS
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
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener listas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public int CrearLista(int userId, string nombre, string descripcion, string icono, string colorHex, bool isPublic = true)
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
                    cmd.Parameters.AddWithValue("@ColorCode", colorHex ?? "#4361ee");
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
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
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
        // MÉTODO PARA DEPURACIÓN
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
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
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