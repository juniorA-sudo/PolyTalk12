using Microsoft.Data.SqlClient;
using Presentation.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmGestionarVocabulario : Form
    {
        private int lessonId;
        private string lessonTitle;
        private string connectionString = ConfigurationHelper.GetConnectionString();

        // 👈 REFERENCIA AL FORMULARIO PRINCIPAL
        public FrmPrincipal FormPrincipal { get; set; }

        public event EventHandler VolverClicked;

        public FrmGestionarVocabulario(int lessonId, string lessonTitle)
        {
            InitializeComponent();
            this.lessonId = lessonId;
            this.lessonTitle = lessonTitle;
            this.lblTitulo.Text = $"Vocabulario: {lessonTitle}";

            // Cargar icono
            try
            {
                this.iconoLibro.Image = System.Drawing.SystemIcons.Information.ToBitmap();
            }
            catch { }

            // Configurar para que se pueda incrustar en panel
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // ✅ EVENTOS CORREGIDOS
            try
            {
                if (btnAgregar != null) btnAgregar.Click += BtnAgregar_Click;
                if (btnEditar != null) btnEditar.Click += BtnEditar_Click;
                if (btnEliminar != null) btnEliminar.Click += BtnEliminar_Click;
                if (btnBuscar != null) btnBuscar.Click += BtnBuscar_Click;
                if (txtBuscar != null) txtBuscar.TextChanged += TxtBuscar_TextChanged;
                if (cmbFiltro != null) cmbFiltro.SelectedIndexChanged += CmbFiltro_SelectedIndexChanged;
                if (dgvPalabras != null) dgvPalabras.CellDoubleClick += DgvPalabras_CellDoubleClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar eventos: {ex.Message}");
            }

            CargarPalabras();
            ActualizarEstadisticas();
        }

        // 👈 NUEVO MÉTODO PARA VOLVER AL CONTENIDO


        private void CargarPalabras(string filtro = "")
        {
            try
            {
                // ✅ Verificación de seguridad
                if (dgvPalabras == null)
                {
                    MessageBox.Show("Error: DataGridView no inicializado");
                    return;
                }

                string query = @"
                    SELECT 
                        w.word_english AS Inglés,
                        w.word_spanish AS Español,
                        CASE WHEN w.image_url IS NOT NULL AND w.image_url != '' THEN '✅' ELSE '❌' END AS Imagen,
                        CASE WHEN w.audio_url IS NOT NULL AND w.audio_url != '' THEN '✅' ELSE '❌' END AS Audio,
                        w.example_sentence AS Ejemplo,
                        (SELECT COUNT(*) FROM vocabulary_distractors d WHERE d.word_id = w.word_id) AS Distractores
                    FROM vocabulary_words w
                    WHERE w.lesson_id = @lessonId AND w.is_active = 1";

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    query += @" AND (w.word_english LIKE @filtro OR w.word_spanish LIKE @filtro)";
                }

                query += " ORDER BY w.word_english";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@lessonId", lessonId);

                        if (!string.IsNullOrWhiteSpace(filtro))
                        {
                            cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvPalabras.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar palabras: {ex.Message}");
            }
        }

        private void ActualizarEstadisticas()
        {
            try
            {
                if (lblEstadisticas == null) return;

                string query = @"
                    SELECT 
                        COUNT(*) AS Total,
                        SUM(CASE WHEN image_url IS NOT NULL AND image_url != '' THEN 1 ELSE 0 END) AS ConImagen,
                        SUM(CASE WHEN audio_url IS NOT NULL AND audio_url != '' THEN 1 ELSE 0 END) AS ConAudio
                    FROM vocabulary_words
                    WHERE lesson_id = @lessonId AND is_active = 1";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@lessonId", lessonId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int total = reader.GetInt32(0);
                                int conImagen = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                                int conAudio = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);

                                lblEstadisticas.Text = $"📊 {total} palabras • {conImagen} con imagen • {conAudio} con audio";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (lblEstadisticas != null)
                    lblEstadisticas.Text = "Error al cargar estadísticas";
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //FrmAgregarPalabra frm = new FrmAgregarPalabra(lessonId);
                //frm.StartPosition = FormStartPosition.CenterParent;

                //if (frm.ShowDialog() == DialogResult.OK)
                //{
                   // CargarPalabras(txtBuscar?.Text ?? "");
                    //ActualizarEstadisticas();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPalabras != null && dgvPalabras.SelectedRows.Count > 0)
                {
                    string english = dgvPalabras.SelectedRows[0].Cells["Inglés"].Value?.ToString() ?? "";
                    MessageBox.Show($"Editando palabra: {english}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecciona una palabra para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPalabras != null && dgvPalabras.SelectedRows.Count > 0)
                {
                    string english = dgvPalabras.SelectedRows[0].Cells["Inglés"].Value?.ToString() ?? "";
                    MessageBox.Show($"Función eliminar para: {english}", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecciona una palabra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar != null && (txtBuscar.Text.Length >= 3 || txtBuscar.Text.Length == 0))
                {
                    CargarPalabras(txtBuscar.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarPalabras(txtBuscar?.Text ?? "");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarPalabras(txtBuscar?.Text ?? "");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DgvPalabras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvPalabras != null)
                {
                    string english = dgvPalabras.Rows[e.RowIndex].Cells["Inglés"].Value?.ToString() ?? "";
                    MessageBox.Show($"Editando: {english}", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}