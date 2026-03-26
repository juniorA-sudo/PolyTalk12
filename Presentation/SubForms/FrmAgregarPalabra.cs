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
            if (txtEspanol.Text == "Ej: Perro" || string.IsNullOrWhiteSpace(txtEspanol.Text))
            {
                txtEspanol.Text = "";
                txtEspanol.ForeColor = Color.Black;
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

        // PLACEHOLDERS - INGLÉS
        private void txtIngles_Enter(object sender, EventArgs e)
        {
            if (txtIngles.Text == "Ej: Dog" || string.IsNullOrWhiteSpace(txtIngles.Text))
            {
                txtIngles.Text = "";
                txtIngles.ForeColor = Color.Black;
            }
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

            if (string.IsNullOrEmpty(espanol) || espanol == "Ej: Perro")
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
        // AUDIO — VBScript + SAPI (igual que FrmDetalleLista)
        // =====================================================
        private void btnEscuchar_Click(object sender, EventArgs e)
        {
            string palabra = txtIngles.Text.Trim();
            if (string.IsNullOrEmpty(palabra) || palabra == "Ej: Dog")
            {
                MessageBox.Show("Primero traduce la palabra.", "Aviso",
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
                        proc.WaitForExit();

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
            try
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
            catch
            {
                return null;
            }
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
            if (!ValidarPalabra())
                return;

            GuardarPalabra();
        }

        /// <summary>Valida todos los campos de la palabra</summary>
        private bool ValidarPalabra()
        {
            var errores = new System.Collections.Generic.List<string>();
            string espanol = txtEspanol.Text.Trim();
            string ingles = txtIngles.Text.Trim();

            // Validar español
            if (!FormValidator.ValidarNoVacio(espanol, "La palabra en español", out string error1))
                errores.Add(error1);
            else if (espanol == "Ej: Perro")
                errores.Add("Debes escribir una palabra en español (no el placeholder).");
            else if (!FormValidator.ValidarSoloLetras(espanol, "La palabra en español", out string error2))
                errores.Add(error2);
            else if (!FormValidator.ValidarLongitud(espanol, 2, 30, "La palabra en español", out string error3))
                errores.Add(error3);

            // Validar inglés
            if (!FormValidator.ValidarNoVacio(ingles, "La palabra en inglés", out string error4))
                errores.Add(error4);
            else if (ingles == "Ej: Dog")
                errores.Add("Debes traducir la palabra primero (no el placeholder).");
            else if (!FormValidator.ValidarSoloLetras(ingles, "La palabra en inglés", out string error5))
                errores.Add(error5);
            else if (!FormValidator.ValidarLongitud(ingles, 2, 30, "La palabra en inglés", out string error6))
                errores.Add(error6);

            // Si hay errores, mostrar todos
            if (errores.Count > 0)
            {
                FormValidator.MostrarErrores(errores);
                return false;
            }

            return true;
        }

        /// <summary>Guarda la palabra en la base de datos</summary>
        private void GuardarPalabra()
        {
            try
            {
                string espanol = txtEspanol.Text.Trim();
                string ingles = txtIngles.Text.Trim();

                // Guardar en BD
                vocabularyService.AgregarPalabra(listId, ingles, espanol, imageUrlSeleccionada, "");

                // 🔊 Reproducir la pronunciación de la palabra en inglés
                EscucharPalabra(ingles);

                // Preguntar si agregar otra
                if (FormValidator.MostrarConfirmacion("✅ Palabra guardada correctamente.\n\n¿Deseas agregar otra palabra?"))
                {
                    LimpiarFormulario();
                    txtEspanol.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (InvalidOperationException ex)
            {
                FormValidator.MostrarError($"Error de conexión: {ex.Message}");
            }
            catch (Exception ex)
            {
                FormValidator.MostrarError($"Error al guardar la palabra: {ex.Message}");
            }
        }

        private void LimpiarFormulario()
        {
            txtEspanol.Text = "Ej: Perro";
            txtEspanol.ForeColor = Color.Gray;
            txtIngles.Text = "Ej: Dog";
            txtIngles.ForeColor = Color.Gray;
            picImagen.Image = null;
            imageUrlSeleccionada = "";
            lblEstadoImagen.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}