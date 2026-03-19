using System;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace Presentation.Login__Register__Principal
{
    public partial class FrmAgregarPalabra : Form
    {
        private readonly VocabularyService vocabularyService;
        private readonly int listId;
        private string imageUrlSeleccionada = "";

        private static readonly HttpClient client = new HttpClient()
        {
            Timeout = TimeSpan.FromSeconds(10)
        };

        private const string UNSPLASH_KEY = "CP3bJEd1OGbmc9jfGGiCrVEk6dKKkDRB3zGKVoWwt6E";

        public FrmAgregarPalabra(int listId)
        {
            InitializeComponent();
            this.listId = listId;
            vocabularyService = new VocabularyService();
        }

        private void FrmAgregarPalabra_Load(object sender, EventArgs e)
        {
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.BackColor = Color.FromArgb(247, 250, 252);
            picImagen.BorderStyle = BorderStyle.FixedSingle;
        }

        // =====================================================
        // PLACEHOLDERS - ESPAÑOL
        // =====================================================
        private void txtEspanol_Enter(object sender, EventArgs e)
        {
            // ✅ Al entrar siempre limpia el campo
            txtEspanol.Text = "";
            txtEspanol.ForeColor = Color.Black;
        }
        private void txtEspanol_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEspanol.Text))
            {
                txtEspanol.Text = "Ej: Perro";
                txtEspanol.ForeColor = Color.Gray;
            }
        }

        // PLACEHOLDERS - INGLÉS
        private void txtIngles_Enter(object sender, EventArgs e)
        {
            // ✅ Al entrar siempre limpia el campo
            txtIngles.Text = "";
            txtIngles.ForeColor = Color.Black;
        }
        private void txtIngles_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIngles.Text))
            {
                txtIngles.Text = "Ej: Dog";
                txtIngles.ForeColor = Color.Gray;
            }
        }

        // =====================================================
        // TRADUCCIÓN - MyMemory (gratuita, sin API key)
        // =====================================================
        private async void btnTraducir_Click(object sender, EventArgs e)
        {
            string espanol = txtEspanol.Text.Trim();

            if (string.IsNullOrEmpty(espanol))
            {
                MessageBox.Show("Escribe la palabra en español primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btnTraducir.Enabled = false;
            btnTraducir.Text = "Traduciendo...";

            string traduccion = await TraducirEspanolIngles(espanol);

            if (!string.IsNullOrEmpty(traduccion))
            {
                txtIngles.Text = traduccion;
                txtIngles.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("No se pudo traducir.\nRevisa tu conexión a internet.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btnTraducir.Enabled = true;
            btnTraducir.Text = "🔄 Traducir";
        }

        private async Task<string> TraducirEspanolIngles(string texto)
        {
            try
            {
                // ✅ MyMemory — gratuita, sin API key, estable
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
            catch { return null; }
        }

        // =====================================================
        // AUDIO - SAPI (Windows nativo)
        // =====================================================
        private void btnEscuchar_Click(object sender, EventArgs e)
        {
            string palabra = txtIngles.Text.Trim();
            if (string.IsNullOrEmpty(palabra))
            {
                MessageBox.Show("Primero traduce la palabra.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            EscucharPalabra(palabra);
        }

        private void EscucharPalabra(string palabra)
        {
            Task.Run(() =>
            {
                try
                {
                    using (var synth = new System.Speech.Synthesis.SpeechSynthesizer())
                    {
                        synth.Rate = -1;
                        try
                        {
                            synth.SelectVoiceByHints(
                                System.Speech.Synthesis.VoiceGender.Female,
                                System.Speech.Synthesis.VoiceAge.Adult,
                                0, new System.Globalization.CultureInfo("en-US"));
                        }
                        catch { }
                        synth.Speak(palabra);
                    }
                }
                catch { }
            });
        }

        // =====================================================
        // IMAGEN - Unsplash
        // =====================================================
        private async void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            string palabra = txtIngles.Text.Trim();
            if (string.IsNullOrEmpty(palabra))
            {
                MessageBox.Show("Primero traduce la palabra.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                btnBuscarImagen.Enabled = false;
                lblEstadoImagen.Text = "Buscando...";
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
                    lblEstadoImagen.Text = "❌ No encontrada";
                    lblEstadoImagen.ForeColor = Color.Red;
                }
            }
            catch
            {
                lblEstadoImagen.Text = "❌ Error de conexión";
                lblEstadoImagen.ForeColor = Color.Red;
            }
            finally
            {
                btnBuscarImagen.Enabled = true;
            }
        }

        private async Task<string> BuscarImagenUnsplash(string query)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://api.unsplash.com/search/photos?query={Uri.EscapeDataString(query)}&per_page=1&orientation=squarish");
            request.Headers.Add("Authorization", $"Client-ID {UNSPLASH_KEY}");
            HttpResponseMessage response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode) return null;
            string json = await response.Content.ReadAsStringAsync();
            using JsonDocument doc = JsonDocument.Parse(json);
            var results = doc.RootElement.GetProperty("results");
            if (results.GetArrayLength() == 0) return null;
            return results[0].GetProperty("urls").GetProperty("small").GetString();
        }

        private async Task MostrarImagen(string url)
        {
            try
            {
                byte[] data = await client.GetByteArrayAsync(url);
                picImagen.Image = Image.FromStream(new MemoryStream(data));
            }
            catch { picImagen.Image = null; }
        }

        // =====================================================
        // GUARDAR
        // =====================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string espanol = txtEspanol.Text.Trim();
            string ingles = txtIngles.Text.Trim();

            if (string.IsNullOrEmpty(espanol))
            {
                MessageBox.Show("Escribe la palabra en español.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEspanol.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ingles))
            {
                MessageBox.Show("Traduce la palabra primero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                vocabularyService.AgregarPalabra(listId, ingles, espanol, imageUrlSeleccionada, "");

                if (MessageBox.Show("✅ Palabra guardada.\n¿Agregar otra?", "Éxito",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtEspanol.Text = "Ej: Perro";
                    txtEspanol.ForeColor = Color.Gray;
                    txtIngles.Text = "Ej: Dog";
                    txtIngles.ForeColor = Color.Gray;
                    picImagen.Image = null;
                    imageUrlSeleccionada = "";
                    lblEstadoImagen.Text = "";
                    txtEspanol.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}