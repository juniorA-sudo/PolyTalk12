using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace Presentation.Login__Register__Principal
{
    public partial class FrmPracticar : Form
    {
        private readonly VocabularyService vocabularyService;
        private readonly int listId;
        private readonly int userId;
        private readonly string listName;
        private readonly string colorHex;
        private readonly string icono;
        private readonly FrmPrincipal frmPrincipal; // ✅ referencia al padre
        private List<DataRow> palabrasParaPracticar;
        private List<DataRow> todasLasPalabras;
        private int indiceActual = 0;
        private int correctas = 0;
        private int incorrectas = 0;
        private TipoEjercicio tipoActual;
        private DataRow palabraActual;
        private bool respondido = false;

        private enum TipoEjercicio
        {
            ImagenElegirPalabra,
            AudioElegirPalabra,
            EspanolEscribirIngles,
            InglesElegirTraduccion
        }

        // ✅ Constructor actualizado — recibe FrmPrincipal, colorHex e icono para volver al detalle
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
            if (indiceActual >= palabrasParaPracticar.Count)
            {
                MostrarResultadoFinal();
                return;
            }

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
            if (!string.IsNullOrEmpty(imgUrl))
                tipos.Add(TipoEjercicio.ImagenElegirPalabra);

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
            // Usamos FlowLayoutPanel para que los controles se acomoden solos
            panelEjercicio.Controls.Clear();
            panelEjercicio.AutoScroll = true;

            lblFeedback.Text = "";
            lblFeedback.Visible = false;
            panelBotonesAnki.Visible = false;
            btnVerificar.Visible = false;
        }

        // =====================================================
        // Helpers de layout — añaden controles bien posicionados
        // =====================================================
        private void AgregarControl(Control ctrl, int margenTop = 8)
        {
            // Centra horizontalmente dentro del panelEjercicio
            int x = (panelEjercicio.Width - ctrl.Width) / 2;
            int y = margenTop;

            // Si ya hay controles, apila debajo del último
            if (panelEjercicio.Controls.Count > 0)
            {
                var ultimo = panelEjercicio.Controls[panelEjercicio.Controls.Count - 1];
                y = ultimo.Bottom + margenTop;
            }

            ctrl.Location = new Point(Math.Max(0, x), y);
            panelEjercicio.Controls.Add(ctrl);
        }

        private Label CrearLabelPalabra(string texto, int fontSize = 26)
        {
            return new Label
            {
                Text = texto.ToUpper(),
                Font = new Font("Segoe UI", fontSize, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 82, 130),
                AutoSize = false,
                Size = new Size(380, 60),
                TextAlign = ContentAlignment.MiddleCenter
            };
        }

        private Button CrearBotonOpcion(string texto)
        {
            var btn = new Button
            {
                Text = texto,
                Size = new Size(360, 44),
                Font = new Font("Segoe UI", 11),
                BackColor = Color.FromArgb(247, 250, 252),
                ForeColor = Color.FromArgb(45, 55, 72),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Tag = texto
            };
            btn.FlatAppearance.BorderColor = Color.FromArgb(180, 198, 220);
            btn.FlatAppearance.BorderSize = 1;
            return btn;
        }

        // =====================================================
        // TIPO 1: Imagen → elegir palabra
        // =====================================================
        private async void MostrarEjercicioImagen()
        {
            lblInstruccion.Text = "¿Cuál es la palabra en inglés para esta imagen?";

            string imageUrl = palabraActual["image_url"].ToString();
            var pic = new PictureBox
            {
                Size = new Size(160, 140),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(230, 240, 255)
            };
            AgregarControl(pic, 10);

            try
            {
                using (var client = new HttpClient())
                {
                    byte[] data = await client.GetByteArrayAsync(imageUrl);
                    pic.Image = Image.FromStream(new MemoryStream(data));
                }
            }
            catch { }

            MostrarOpcionesMultiple(palabraActual["word_english"].ToString(), true);
        }

        // =====================================================
        // TIPO 2: Audio → elegir palabra
        // =====================================================
        private void MostrarEjercicioAudio()
        {
            lblInstruccion.Text = "Escucha el audio y elige la palabra correcta";

            var btnPlay = new Button
            {
                Text = "🔊  Escuchar palabra",
                Size = new Size(220, 50),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(66, 153, 225),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.Click += (s, e) => EscucharPalabra(palabraActual["word_english"].ToString());
            AgregarControl(btnPlay, 15);

            EscucharPalabra(palabraActual["word_english"].ToString());
            MostrarOpcionesMultiple(palabraActual["word_english"].ToString(), true);
        }

        // =====================================================
        // TIPO 3: Español → escribir inglés
        // =====================================================
        private void MostrarEjercicioEscribir()
        {
            lblInstruccion.Text = "Escribe la traducción en inglés";

            AgregarControl(CrearLabelPalabra(palabraActual["word_spanish"].ToString()), 20);

            var txtRespuesta = new TextBox
            {
                Name = "txtRespuesta",
                Size = new Size(300, 38),
                Font = new Font("Segoe UI", 13),
                TextAlign = HorizontalAlignment.Center,
                BorderStyle = BorderStyle.FixedSingle
            };
            txtRespuesta.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) btnVerificar_Click(null, null);
            };
            AgregarControl(txtRespuesta, 18);

            btnVerificar.Visible = true;
            txtRespuesta.Focus();
        }

        // =====================================================
        // TIPO 4: Inglés → elegir traducción
        // =====================================================
        private void MostrarEjercicioTraduccion()
        {
            lblInstruccion.Text = "¿Cuál es la traducción en español?";

            AgregarControl(CrearLabelPalabra(palabraActual["word_english"].ToString()), 20);
            MostrarOpcionesMultiple(palabraActual["word_spanish"].ToString(), false);
        }

        // =====================================================
        // OPCIONES MÚLTIPLES
        // =====================================================
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

            foreach (string opcion in opciones)
            {
                var btn = CrearBotonOpcion(opcion);
                string opcionCapturada = opcion;
                btn.Click += (s, e) =>
                {
                    if (!respondido)
                        EvaluarRespuestaMultiple(btn, opcionCapturada, respuestaCorrecta);
                };
                AgregarControl(btn, 8);
            }
        }

        // =====================================================
        // EVALUACIÓN
        // =====================================================
        private void EvaluarRespuestaMultiple(Button btnSeleccionado, string respuesta, string correcta)
        {
            respondido = true;
            bool esCorrecta = respuesta.Equals(correcta, StringComparison.OrdinalIgnoreCase);

            foreach (Control ctrl in panelEjercicio.Controls)
            {
                if (ctrl is Button btn && btn.Tag != null)
                {
                    if (btn.Tag.ToString().Equals(correcta, StringComparison.OrdinalIgnoreCase))
                        btn.BackColor = Color.FromArgb(154, 230, 180);
                    else if (btn == btnSeleccionado && !esCorrecta)
                        btn.BackColor = Color.FromArgb(254, 178, 178);
                }
            }

            MostrarFeedbackYAnki(esCorrecta);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (respondido) return;

            var txtRespuesta = panelEjercicio.Controls["txtRespuesta"] as TextBox;
            if (txtRespuesta == null || string.IsNullOrEmpty(txtRespuesta.Text.Trim())) return;

            string respuesta = txtRespuesta.Text.Trim();
            string correcta = palabraActual["word_english"].ToString();
            respondido = true;

            bool esCorrecta = respuesta.Equals(correcta, StringComparison.OrdinalIgnoreCase);
            txtRespuesta.BackColor = esCorrecta
                ? Color.FromArgb(154, 230, 180)
                : Color.FromArgb(254, 178, 178);

            if (!esCorrecta)
            {
                var lblCorrecta = new Label
                {
                    Text = $"✅ Respuesta correcta: {correcta}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.Green,
                    AutoSize = true
                };
                AgregarControl(lblCorrecta, 6);
            }

            btnVerificar.Visible = false;
            MostrarFeedbackYAnki(esCorrecta);
        }

        private void MostrarFeedbackYAnki(bool esCorrecta)
        {
            if (esCorrecta)
            {
                correctas++;
                lblFeedback.Text = "¡Correcto! 🎉";
                lblFeedback.ForeColor = Color.Green;
            }
            else
            {
                incorrectas++;
                lblFeedback.Text = $"Incorrecto 😅  →  {palabraActual["word_english"]}";
                lblFeedback.ForeColor = Color.Red;
            }

            lblFeedback.Visible = true;
            panelBotonesAnki.Visible = true;
        }

        // =====================================================
        // BOTONES ANKI
        // =====================================================
        private void btnDificil_Click(object sender, EventArgs e) => AvanzarConCalidad(0);
        private void btnBien_Click(object sender, EventArgs e) => AvanzarConCalidad(3);
        private void btnFacil_Click(object sender, EventArgs e) => AvanzarConCalidad(5);

        private void AvanzarConCalidad(int calidad)
        {
            try
            {
                int wordId = Convert.ToInt32(palabraActual["word_id"]);
                vocabularyService.ActualizarProgresoAnki(userId, wordId, calidad);
            }
            catch { }

            indiceActual++;
            MostrarSiguientePregunta();
        }

        // =====================================================
        // RESULTADO FINAL
        // =====================================================
        private void MostrarResultadoFinal()
        {
            LimpiarPanel();
            lblInstruccion.Text = "¡Sesión completada!";

            int total = correctas + incorrectas;
            double porcentaje = total > 0 ? (correctas * 100.0 / total) : 0;
            string emoji = porcentaje >= 80 ? "🏆" : porcentaje >= 60 ? "👍" : "💪";
            string mensaje = porcentaje >= 80 ? "¡Excelente!" : porcentaje >= 60 ? "¡Bien hecho!" : "¡Sigue practicando!";

            var lblResultado = new Label
            {
                Text = $"{emoji}\n{mensaje}\n\n✅ Correctas: {correctas}     ❌ Incorrectas: {incorrectas}\n\n📊 {porcentaje:0}% de aciertos",
                Font = new Font("Segoe UI", 13),
                ForeColor = Color.FromArgb(44, 82, 130),
                AutoSize = false,
                Size = new Size(380, 200),
                TextAlign = ContentAlignment.MiddleCenter
            };
            AgregarControl(lblResultado, 30);

            var btnTerminar = new Button
            {
                Text = "✔ Terminar sesión",
                Size = new Size(200, 44),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                BackColor = Color.FromArgb(66, 153, 225),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnTerminar.FlatAppearance.BorderSize = 0;
            btnTerminar.Click += (s, e) => VolverADetalle();
            AgregarControl(btnTerminar, 12);
        }

        // =====================================================
        // AUDIO — VBScript + SAPI (sin internet, sin System.Speech)
        // =====================================================
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
                catch { }
            });
        }

        // =====================================================
        // SALIR — regresa al FrmDetalleLista en el panel
        // =====================================================
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir? Se guardará el progreso actual.", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VolverADetalle();
            }
        }

        private void VolverADetalle()
        {
            if (frmPrincipal != null)
            {
                // Regresa al FrmDetalleLista dentro del panel del FrmPrincipal
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