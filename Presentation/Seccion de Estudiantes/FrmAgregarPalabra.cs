using System;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using System.IO;

namespace Presentation.Login__Register__Principal
{
    public partial class FrmAgregarPalabra : Form
    {
        private readonly VocabularyService vocabularyService;
        private readonly int listId;
        private string imageUrlSeleccionada = "";
        private const string UNSPLASH_KEY = "CP3bJEd1OGbmc9jfGGiCrVEk6dKKkDRB3zGKVoWwt6E";

        public FrmAgregarPalabra(int listId)
        {
            InitializeComponent();
            this.listId = listId;
            vocabularyService = new VocabularyService();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Agregar Palabra";
            this.Size = new System.Drawing.Size(480, 600);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmAgregarPalabra_Load(object sender, EventArgs e)
        {
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.BackColor = Color.FromArgb(247, 250, 252);
            picImagen.BorderStyle = BorderStyle.FixedSingle;
        }

        // =====================================================
        // TRADUCCIÓN — MyMemory API (gratis, sin API key)
        // =====================================================
        private async void btnTraducir_Click(object sender, EventArgs e)
        {
            string espanol = txtEspanol.Text.Trim();

            if (string.IsNullOrEmpty(espanol) || espanol == "Ej: Perro")
            {
                MessageBox.Show("Escribe la palabra en español primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                btnTraducir.Enabled = false;
                btnTraducir.Text = "Traduciendo...";

                string traduccion = await TraducirEspanolIngles(espanol);

                if (!string.IsNullOrEmpty(traduccion))
                {
                    txtIngles.Text = traduccion;
                    txtIngles.ForeColor = Color.FromArgb(45, 55, 72);
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la traducción.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al traducir: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnTraducir.Enabled = true;
                btnTraducir.Text = "🔄 Traducir";
            }
        }

        private async System.Threading.Tasks.Task<string> TraducirEspanolIngles(string texto)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://api.mymemory.translated.net/get?q={Uri.EscapeDataString(texto)}&langpair=es|en";
                HttpResponseMessage response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode) return null;

                string json = await response.Content.ReadAsStringAsync();
                using JsonDocument doc = JsonDocument.Parse(json);

                return doc.RootElement
                    .GetProperty("responseData")
                    .GetProperty("translatedText")
                    .GetString();
            }
        }

        // =====================================================
        // AUDIO — VBScript + SAPI (rápido, sin internet)
        // =====================================================
        private void btnEscuchar_Click(object sender, EventArgs e)
        {
            string palabra = txtIngles.Text.Trim();

            if (string.IsNullOrEmpty(palabra) || palabra == "Ej: Dog")
            {
                MessageBox.Show("Primero traduce la palabra al inglés.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EscucharPalabra(palabra);
        }

        private void EscucharPalabra(string palabra)
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                try
                {
                    string vbs = Path.Combine(Path.GetTempPath(), "tts_temp.vbs");
                    File.WriteAllText(vbs, $"CreateObject(\"SAPI.SpVoice\").Speak \"{palabra}\"");

                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "cscript",
                        Arguments = $"//NoLogo \"{vbs}\"",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (var proc = System.Diagnostics.Process.Start(psi))
                    {
                        proc.WaitForExit();
                    }

                    if (File.Exists(vbs)) File.Delete(vbs);
                }
                catch (Exception ex)
                {
                    this.Invoke((Action)(() =>
                        MessageBox.Show($"Error: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                }
            });
        }

        // =====================================================
        // IMAGEN - Unsplash
        // =====================================================
        private async void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            string palabra = txtIngles.Text.Trim();

            if (string.IsNullOrEmpty(palabra) || palabra == "Ej: Dog")
            {
                MessageBox.Show("Primero traduce la palabra al inglés.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                btnBuscarImagen.Enabled = false;
                btnBuscarImagen.Text = "Buscando...";
                lblEstadoImagen.Text = "Buscando imagen...";
                lblEstadoImagen.ForeColor = Color.Gray;

                string url = await BuscarImagenUnsplash(palabra);

                if (!string.IsNullOrEmpty(url))
                {
                    imageUrlSeleccionada = url;
                    await MostrarImagen(url);
                    lblEstadoImagen.Text = "✅ Imagen encontrada";
                    lblEstadoImagen.ForeColor = Color.Green;
                }
                else
                {
                    lblEstadoImagen.Text = "❌ No se encontró imagen";
                    lblEstadoImagen.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblEstadoImagen.Text = "❌ Error al buscar";
                lblEstadoImagen.ForeColor = Color.Red;
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnBuscarImagen.Enabled = true;
                btnBuscarImagen.Text = "🖼 Buscar imagen (IA)";
            }
        }

        private async System.Threading.Tasks.Task<string> BuscarImagenUnsplash(string query)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Client-ID {UNSPLASH_KEY}");
                string url = $"https://api.unsplash.com/search/photos?query={Uri.EscapeDataString(query)}&per_page=1&orientation=squarish";

                HttpResponseMessage response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode) return null;

                string json = await response.Content.ReadAsStringAsync();
                using JsonDocument doc = JsonDocument.Parse(json);

                var results = doc.RootElement.GetProperty("results");
                if (results.GetArrayLength() == 0) return null;

                return results[0].GetProperty("urls").GetProperty("small").GetString();
            }
        }

        private async System.Threading.Tasks.Task MostrarImagen(string imageUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageData = await client.GetByteArrayAsync(imageUrl);
                    var img = Image.FromStream(new MemoryStream(imageData));
                    picImagen.Image = img;
                }
            }
            catch { picImagen.Image = null; }
        }

        // =====================================================
        // GUARDAR
        // =====================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ingles = txtIngles.Text.Trim();
            string espanol = txtEspanol.Text.Trim();

            if (string.IsNullOrEmpty(espanol) || espanol == "Ej: Perro")
            {
                MessageBox.Show("Escribe la palabra en español.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEspanol.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ingles) || ingles == "Ej: Dog")
            {
                MessageBox.Show("Traduce la palabra al inglés primero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEspanol.Focus();
                return;
            }

            try
            {
                int wordId = vocabularyService.AgregarPalabra(listId, ingles, espanol, imageUrlSeleccionada, "");

                if (wordId > 0)
                {
                    txtEspanol.Text = "Ej: Perro";
                    txtEspanol.ForeColor = Color.Gray;
                    txtIngles.Text = "Ej: Dog";
                    txtIngles.ForeColor = Color.Gray;
                    picImagen.Image = null;
                    imageUrlSeleccionada = "";
                    lblEstadoImagen.Text = "";

                    if (MessageBox.Show("✅ Palabra guardada.\n¿Quieres agregar otra?", "Éxito",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        txtEspanol.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // =====================================================
        // PLACEHOLDER TEXTBOXES
        // =====================================================
        private void txtEspanol_Enter(object sender, EventArgs e)
        {
            if (txtEspanol.Text == "Ej: Perro")
            {
                txtEspanol.Text = "";
                txtEspanol.ForeColor = Color.FromArgb(45, 55, 72);
            }
        }

        private void txtEspanol_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEspanol.Text))
            {
                txtEspanol.Text = "Ej: Perro";
                txtEspanol.ForeColor = Color.Gray;
            }
        }
    }
}