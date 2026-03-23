using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;                          // FrmPrincipal, VocabularyService
using Presentation.Login__Register__Principal; // FrmDetalleLista

namespace Presentation.Seccion_de_Estudiantes
{
    public partial class FrmPracticar : Form
    {
        private readonly VocabularyService vocabularyService;
        private readonly int listId;
        private readonly int userId;
        private readonly string listName;
        private readonly string colorHex;
        private readonly string icono;
        private readonly FrmPrincipal frmPrincipal;
        private List<DataRow> palabrasParaPracticar;
        private List<DataRow> todasLasPalabras;
        private int indiceActual = 0;
        private int correctas = 0;
        private int incorrectas = 0;
        private TipoEjercicio tipoActual;
        private DataRow palabraActual;
        private bool respondido = false;

        private static readonly HttpClient httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
        private const string UNSPLASH_KEY = "CP3bJEd1OGbmc9jfGGiCrVEk6dKKkDRB3zGKVoWwt6E";

        private static readonly Color[] coloresPastel =
        {
            Color.FromArgb(255, 220, 230),
            Color.FromArgb(220, 240, 255),
            Color.FromArgb(220, 255, 235),
            Color.FromArgb(255, 245, 210),
            Color.FromArgb(240, 220, 255),
            Color.FromArgb(255, 230, 210),
        };

        private enum TipoEjercicio
        {
            ImagenElegirPalabra,
            AudioElegirPalabra,
            EspanolEscribirIngles,
            InglesElegirTraduccion
        }

        public FrmPracticar(int listId, int userId, string listName,
                            FrmPrincipal frmPrincipal, string colorHex = "", string icono = "")
        {
            InitializeComponent();
            this.listId = listId;
            this.userId = userId;
            this.listName = listName;
            this.frmPrincipal = frmPrincipal;
            this.colorHex = colorHex;
            this.icono = icono;
            vocabularyService = new VocabularyService();
        }

        private void FrmPracticar_Load(object sender, EventArgs e)
        {
            this.Text = $"Practicar - {listName}";
            CargarPalabras();
            if (palabrasParaPracticar.Count == 0)
            {
                MessageBox.Show("¡No hay palabras para repasar hoy! Vuelve mañana.", "Sin palabras",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            MostrarSiguientePregunta();
        }

        private void CargarPalabras()
        {
            var rng = new Random();
            palabrasParaPracticar = vocabularyService.ObtenerPalabrasParaPracticar(userId, listId)
                .Rows.Cast<DataRow>().OrderBy(x => rng.Next()).ToList();
            todasLasPalabras = vocabularyService.ObtenerTodasLasPalabras(listId)
                .Rows.Cast<DataRow>().ToList();
        }

        private void MostrarSiguientePregunta()
        {
            if (indiceActual >= palabrasParaPracticar.Count) { MostrarResultadoFinal(); return; }

            respondido = false;
            palabraActual = palabrasParaPracticar[indiceActual];

            var rng = new Random();
            var tipos = new List<TipoEjercicio>
            {
                TipoEjercicio.AudioElegirPalabra,
                TipoEjercicio.EspanolEscribirIngles,
                TipoEjercicio.InglesElegirTraduccion
            };
            string imgUrl = palabraActual["image_url"]?.ToString();
            if (!string.IsNullOrEmpty(imgUrl)) tipos.Add(TipoEjercicio.ImagenElegirPalabra);
            tipoActual = tipos[rng.Next(tipos.Count)];

            lblProgreso.Text = $"{indiceActual + 1} / {palabrasParaPracticar.Count}";
            progressBar.Maximum = palabrasParaPracticar.Count;
            progressBar.Value = indiceActual;
            lblCorrectas.Text = $"✅ {correctas}";
            lblIncorrectas.Text = $"❌ {incorrectas}";
            LimpiarPanel();

            switch (tipoActual)
            {
                case TipoEjercicio.ImagenElegirPalabra: MostrarEjercicioImagen(); break;
                case TipoEjercicio.AudioElegirPalabra: MostrarEjercicioAudio(); break;
                case TipoEjercicio.EspanolEscribirIngles: MostrarEjercicioEscribir(); break;
                case TipoEjercicio.InglesElegirTraduccion: MostrarEjercicioTraduccion(); break;
            }
        }

        private void LimpiarPanel()
        {
            panelEjercicio.Controls.Clear();
            panelEjercicio.AutoScroll = true;
            lblFeedback.Text = "";
            lblFeedback.Visible = false;
            panelBotonesAnki.Visible = false;
            btnVerificar.Visible = false;
        }

        private void AgregarControl(Control ctrl, int margenTop = 8)
        {
            int x = (panelEjercicio.Width - ctrl.Width) / 2;
            int y = margenTop;
            if (panelEjercicio.Controls.Count > 0)
            {
                var ultimo = panelEjercicio.Controls[panelEjercicio.Controls.Count - 1];
                y = ultimo.Bottom + margenTop;
            }
            ctrl.Location = new Point(Math.Max(0, x), y);
            panelEjercicio.Controls.Add(ctrl);
        }

        private GraphicsPath CrearRoundedPath(Rectangle rect, int radio)
        {
            var path = new GraphicsPath();
            int d = radio * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private Button CrearBotonOpcion(string texto, int index = 0)
        {
            Color[] bgs = {
                Color.FromArgb(255, 200, 220),
                Color.FromArgb(200, 230, 255),
                Color.FromArgb(200, 255, 220),
                Color.FromArgb(255, 240, 180)
            };
            Color[] fgs = {
                Color.FromArgb(180, 40, 90),
                Color.FromArgb(30, 90, 180),
                Color.FromArgb(30, 150, 80),
                Color.FromArgb(160, 100, 0)
            };
            var btn = new Button
            {
                Text = texto,
                Size = new Size(340, 46),
                Font = new Font("Segoe UI", 11.5F, FontStyle.Bold),
                BackColor = bgs[index % 4],
                ForeColor = fgs[index % 4],
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Tag = texto
            };
            btn.FlatAppearance.BorderColor = Color.FromArgb(220, 200, 220);
            btn.FlatAppearance.BorderSize = 1;
            return btn;
        }

        // ── Tipo 1: Imagen ─────────────────────────────────────
        private async void MostrarEjercicioImagen()
        {
            lblInstruccion.Text = "¿Cuál es la palabra en inglés para esta imagen?";

            var rng = new Random();
            Color cf = coloresPastel[rng.Next(coloresPastel.Length)];

            var panelImg = new Panel { Size = new Size(200, 200), BackColor = cf };
            panelImg.Region = new Region(CrearRoundedPath(new Rectangle(0, 0, 200, 200), 24));
            AgregarControl(panelImg, 12);

            var pic = new PictureBox
            {
                Size = new Size(164, 164),
                Location = new Point(18, 18),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent
            };
            panelImg.Controls.Add(pic);

            string imgSaved = palabraActual["image_url"]?.ToString() ?? "";
            string word = palabraActual["word_english"].ToString();
            await CargarImagenKawaii(pic, imgSaved, word);

            MostrarOpcionesMultiple(word, true);
        }

        private async Task CargarImagenKawaii(PictureBox pic, string urlGuardada, string palabra)
        {
            // 1. URL guardada en BD
            if (!string.IsNullOrEmpty(urlGuardada))
            {
                try
                {
                    byte[] d = await httpClient.GetByteArrayAsync(urlGuardada);
                    if (!pic.IsDisposed) pic.Image = Image.FromStream(new MemoryStream(d));
                    return;
                }
                catch { }
            }

            // 2. Buscar en Unsplash
            string urlUnsplash = await BuscarUrlUnsplash(palabra);
            if (!string.IsNullOrEmpty(urlUnsplash))
            {
                try
                {
                    byte[] data = await httpClient.GetByteArrayAsync(urlUnsplash);
                    if (!pic.IsDisposed) pic.Image = Image.FromStream(new MemoryStream(data));
                    return;
                }
                catch { }
            }

            // 3. Emoji placeholder
            if (!pic.IsDisposed)
                pic.Image = DibujarEmojiPlaceholder(pic.Width, pic.Height, palabra);
        }

        private static async Task<string> BuscarUrlUnsplash(string palabra)
        {
            try
            {
                string q = Uri.EscapeDataString($"cute {palabra} cartoon illustration kids");
                var req = new HttpRequestMessage(HttpMethod.Get,
                    $"https://api.unsplash.com/search/photos?query={q}&per_page=1&orientation=squarish");
                req.Headers.Add("Authorization", $"Client-ID {UNSPLASH_KEY}");
                var resp = await httpClient.SendAsync(req);
                if (!resp.IsSuccessStatusCode) return null;

                string json = await resp.Content.ReadAsStringAsync();
                using var doc = System.Text.Json.JsonDocument.Parse(json);
                var results = doc.RootElement.GetProperty("results");
                if (results.GetArrayLength() == 0) return null;

                return results[0].GetProperty("urls").GetProperty("small").GetString() ?? "";
            }
            catch { return null; }
        }


        private Image DibujarEmojiPlaceholder(int w, int h, string palabra)
        {
            if (w <= 0) w = 164;
            if (h <= 0) h = 164;
            var bmp = new System.Drawing.Bitmap(w, h);
            using var g = Graphics.FromImage(bmp);
            g.Clear(Color.FromArgb(255, 243, 224));
            string emoji = ObtenerEmojiCategoria(palabra);
            var fEmoji = new Font("Segoe UI Emoji", 56F, FontStyle.Regular, GraphicsUnit.Point);
            var sz = g.MeasureString(emoji, fEmoji);
            g.DrawString(emoji, fEmoji, Brushes.Black,
                (w - sz.Width) / 2f, (h - sz.Height) / 2f);
            return bmp;
        }

        private string ObtenerEmojiCategoria(string p)
        {
            p = p.ToLower();
            if (p.Contains("dog") || p.Contains("cat") || p.Contains("animal")) return "🐾";
            if (p.Contains("food") || p.Contains("eat") || p.Contains("fruit")) return "🍎";
            if (p.Contains("car") || p.Contains("bus") || p.Contains("train")) return "🚗";
            if (p.Contains("house") || p.Contains("home") || p.Contains("room")) return "🏠";
            if (p.Contains("book") || p.Contains("school") || p.Contains("study")) return "📚";
            if (p.Contains("music") || p.Contains("song")) return "🎵";
            if (p.Contains("sport") || p.Contains("ball")) return "⚽";
            if (p.Contains("sun") || p.Contains("rain") || p.Contains("cloud")) return "⛅";
            return p.Length > 0 ? p[0].ToString().ToUpper() : "?";
        }

        // ── Tipo 2: Audio ──────────────────────────────────────
        private void MostrarEjercicioAudio()
        {
            lblInstruccion.Text = "¡Escucha y elige la palabra correcta!";

            var btnPlay = new Button
            {
                Text = "🔊 Escuchar",
                Size = new Size(200, 54),
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                BackColor = Color.FromArgb(255, 200, 220),
                ForeColor = Color.FromArgb(180, 40, 90),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.Click += (s, e) => EscucharPalabra(palabraActual["word_english"].ToString());
            AgregarControl(btnPlay, 15);

            EscucharPalabra(palabraActual["word_english"].ToString());
            MostrarOpcionesMultiple(palabraActual["word_english"].ToString(), true);
        }

        // ── Tipo 3: Escribir ───────────────────────────────────
        private void MostrarEjercicioEscribir()
        {
            lblInstruccion.Text = "Escribe la palabra en inglés";

            var panelP = new Panel { Size = new Size(380, 68), BackColor = Color.FromArgb(255, 245, 210) };
            panelP.Region = new Region(CrearRoundedPath(new Rectangle(0, 0, 380, 68), 18));
            var lbl = new Label
            {
                Text = palabraActual["word_spanish"].ToString().ToUpper(),
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.FromArgb(160, 100, 0),
                BackColor = Color.Transparent,
                AutoSize = false,
                Size = new Size(380, 68),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelP.Controls.Add(lbl);
            AgregarControl(panelP, 20);

            var txt = new TextBox
            {
                Name = "txtRespuesta",
                Size = new Size(280, 42),
                Font = new Font("Segoe UI", 14F),
                TextAlign = HorizontalAlignment.Center,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(255, 250, 240)
            };
            txt.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) btnVerificar_Click(null, null); };
            AgregarControl(txt, 14);
            btnVerificar.Visible = true;
            txt.Focus();
        }

        // ── Tipo 4: Traducción ─────────────────────────────────
        private void MostrarEjercicioTraduccion()
        {
            lblInstruccion.Text = "¿Cuál es la traducción en español?";

            var panelP = new Panel { Size = new Size(380, 68), BackColor = Color.FromArgb(220, 240, 255) };
            panelP.Region = new Region(CrearRoundedPath(new Rectangle(0, 0, 380, 68), 18));
            var lbl = new Label
            {
                Text = palabraActual["word_english"].ToString().ToUpper(),
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 90, 180),
                BackColor = Color.Transparent,
                AutoSize = false,
                Size = new Size(380, 68),
                TextAlign = ContentAlignment.MiddleCenter
            };
            panelP.Controls.Add(lbl);
            AgregarControl(panelP, 20);
            MostrarOpcionesMultiple(palabraActual["word_spanish"].ToString(), false);
        }

        // ── Opciones múltiple choice ───────────────────────────
        private void MostrarOpcionesMultiple(string respuestaCorrecta, bool esIngles)
        {
            var rng = new Random();
            string campo = esIngles ? "word_english" : "word_spanish";

            var distractores = todasLasPalabras
                .Where(r => r[campo].ToString() != respuestaCorrecta)
                .OrderBy(x => rng.Next()).Take(3)
                .Select(r => r[campo].ToString()).ToList();

            var opciones = new List<string>(distractores) { respuestaCorrecta };
            opciones = opciones.OrderBy(x => rng.Next()).ToList();

            int idx = 0;
            foreach (string op in opciones)
            {
                var btn = CrearBotonOpcion(op, idx);
                string opC = op;
                btn.Click += (s, e) =>
                {
                    if (!respondido) EvaluarRespuestaMultiple(btn, opC, respuestaCorrecta);
                };
                AgregarControl(btn, 8);
                idx++;
            }
        }

        private void EvaluarRespuestaMultiple(Button btnSel, string respuesta, string correcta)
        {
            respondido = true;
            bool ok = respuesta.Equals(correcta, StringComparison.OrdinalIgnoreCase);

            foreach (Control c in panelEjercicio.Controls)
            {
                if (c is Button b && b.Tag != null)
                {
                    if (b.Tag.ToString().Equals(correcta, StringComparison.OrdinalIgnoreCase))
                    {
                        b.BackColor = Color.FromArgb(180, 255, 200);
                        b.ForeColor = Color.FromArgb(20, 120, 60);
                    }
                    else if (b == btnSel && !ok)
                    {
                        b.BackColor = Color.FromArgb(255, 180, 180);
                        b.ForeColor = Color.FromArgb(180, 30, 30);
                    }
                    b.Enabled = false;
                }
            }
            MostrarFeedbackYAnki(ok);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (respondido) return;
            var txt = panelEjercicio.Controls["txtRespuesta"] as TextBox;
            if (txt == null || string.IsNullOrEmpty(txt.Text.Trim())) return;

            string resp = txt.Text.Trim();
            string cor = palabraActual["word_english"].ToString();
            respondido = true;
            bool ok = resp.Equals(cor, StringComparison.OrdinalIgnoreCase);

            txt.BackColor = ok ? Color.FromArgb(200, 255, 220) : Color.FromArgb(255, 200, 200);

            if (!ok)
            {
                var lblC = new Label
                {
                    Text = $"Respuesta: {cor}",
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(20, 120, 60),
                    AutoSize = true
                };
                AgregarControl(lblC, 6);
            }
            btnVerificar.Visible = false;
            MostrarFeedbackYAnki(ok);
        }

        private void MostrarFeedbackYAnki(bool ok)
        {
            if (ok)
            {
                correctas++;
                lblFeedback.Text = "¡Correcto! ¡Excelente! 🌟";
                lblFeedback.ForeColor = Color.FromArgb(20, 140, 60);
                lblFeedback.BackColor = Color.FromArgb(210, 255, 225);
            }
            else
            {
                incorrectas++;
                lblFeedback.Text = $"¡Casi! La respuesta es: {palabraActual["word_english"]}";
                lblFeedback.ForeColor = Color.FromArgb(180, 60, 30);
                lblFeedback.BackColor = Color.FromArgb(255, 220, 210);
            }
            lblFeedback.Visible = true;
            panelBotonesAnki.Visible = true;
        }

        // ── Botones Anki ───────────────────────────────────────
        private void btnDificil_Click(object sender, EventArgs e) => AvanzarConCalidad(0);
        private void btnBien_Click(object sender, EventArgs e) => AvanzarConCalidad(3);
        private void btnFacil_Click(object sender, EventArgs e) => AvanzarConCalidad(5);

        private void AvanzarConCalidad(int calidad)
        {
            try
            {
                vocabularyService.ActualizarProgresoAnki(
                    userId, Convert.ToInt32(palabraActual["word_id"]), calidad);
            }
            catch { }
            indiceActual++;
            MostrarSiguientePregunta();
        }

        // ── Resultado final ────────────────────────────────────
        private void MostrarResultadoFinal()
        {
            LimpiarPanel();
            lblInstruccion.Text = "¡Sesión completada!";

            int total = correctas + incorrectas;
            double pct = total > 0 ? (correctas * 100.0 / total) : 0;
            string emoji = pct >= 80 ? "¡EXCELENTE! 🏆"
                         : pct >= 60 ? "¡MUY BIEN! ⭐"
                         : "¡SIGUE PRACTICANDO! 💪";

            var lblR = new Label
            {
                Text = $"{emoji}\n\nCorrectas: {correctas}   Incorrectas: {incorrectas}\n\n{pct:0}% de aciertos",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.FromArgb(180, 40, 120),
                AutoSize = false,
                Size = new Size(380, 180),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(255, 240, 250)
            };
            lblR.Region = new Region(CrearRoundedPath(new Rectangle(0, 0, 380, 180), 20));
            AgregarControl(lblR, 20);

            var btnT = new Button
            {
                Text = "✅ Terminar",
                Size = new Size(200, 48),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                BackColor = Color.FromArgb(255, 200, 220),
                ForeColor = Color.FromArgb(180, 40, 90),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnT.FlatAppearance.BorderSize = 0;
            btnT.Click += (s, e) => VolverADetalle();
            AgregarControl(btnT, 14);
        }

        // ── TTS ────────────────────────────────────────────────
        private void EscucharPalabra(string palabra)
        {
            Task.Run(() =>
            {
                try
                {
                    string vbs = Path.Combine(Path.GetTempPath(), "tts_practicar.vbs");
                    File.WriteAllText(vbs, $"CreateObject(\"SAPI.SpVoice\").Speak \"{palabra}\"");
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "cscript",
                        Arguments = $"//NoLogo \"{vbs}\"",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    using (var proc = System.Diagnostics.Process.Start(psi)) proc.WaitForExit();
                    if (File.Exists(vbs)) File.Delete(vbs);
                }
                catch { }
            });
        }

        // ── Salir / Volver ─────────────────────────────────────
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir? Se guardará el progreso actual.", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                VolverADetalle();
        }

        private void VolverADetalle()
        {
            if (frmPrincipal != null)
            {
                var frm = new FrmDetalleLista(listId, userId, listName, icono, colorHex, frmPrincipal);
                frmPrincipal.AbrirFormEnPanel(frm);
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}