using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmPracticarLeccion : Form
    {
        private readonly LessonService lessonService;
        private readonly int lessonId;
        private readonly int studentId;
        private readonly FrmPrincipal frmPrincipal; // ✅ referencia al padre

        private DataTable dtActividades;
        private int actividadActual = 0;
        private int respuestasCorrectas = 0;
        private bool respondioActual = false;

        private static readonly HttpClient client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

        // ✅ Constructor con FrmPrincipal opcional
        public FrmPracticarLeccion(int lessonId, int studentId, FrmPrincipal frmPrincipal = null)
        {
            InitializeComponent();
            this.lessonId = lessonId;
            this.studentId = studentId;
            this.frmPrincipal = frmPrincipal;
            lessonService = new LessonService();
        }

        private void FrmPracticarLeccion_Load(object sender, EventArgs e)
        {
            dtActividades = lessonService.ObtenerActividades(lessonId);
            lessonService.IniciarLeccion(studentId, lessonId, dtActividades.Rows.Count);
            MostrarActividad(0);
        }

        // =====================================================
        // MOSTRAR ACTIVIDAD
        // =====================================================
        private async void MostrarActividad(int index)
        {
            if (index >= dtActividades.Rows.Count)
            {
                MostrarResultados();
                return;
            }

            respondioActual = false;
            actividadActual = index;
            DataRow row = dtActividades.Rows[index];

            string tipo = row["activity_type"].ToString();
            string instruction = row["instruction"].ToString();
            string content = row["content"].ToString();
            int activityId = Convert.ToInt32(row["activity_id"]);
            string imageUrl = row["image_url"]?.ToString() ?? "";

            lblProgreso.Text = $"Actividad {index + 1} de {dtActividades.Rows.Count}";
            progressBar.Value = (int)((double)index / dtActividades.Rows.Count * 100);
            lblInstruccion.Text = instruction;
            lblFeedback.Visible = false;
            btnSiguiente.Visible = false;
            btnSiguiente.Text = index == dtActividades.Rows.Count - 1 ? "🏆 Finalizar" : "Siguiente →";

            LimpiarAreaActividad();

            if (!string.IsNullOrEmpty(imageUrl)) await CargarImagen(imageUrl);
            else picActividad.Visible = false;

            switch (tipo)
            {
                case "multiple_choice": MostrarOpcionMultiple(activityId, row["correct_answer"].ToString()); break;
                case "fill_blank": MostrarRellenarEspacio(content, row["correct_answer"].ToString()); break;
                case "translate": MostrarTraduccion(content, row["correct_answer"].ToString()); break;
                case "listen_respond": MostrarEscucharResponder(content, row["correct_answer"].ToString(), row["audio_url"]?.ToString()); break;
                case "vocabulary": MostrarVocabulario(content, imageUrl); break;
            }
        }

        // =====================================================
        // OPCIÓN MÚLTIPLE — colores pastel kawaii
        // =====================================================
        private void MostrarOpcionMultiple(int activityId, string correctAnswer)
        {
            DataTable opciones = lessonService.ObtenerOpciones(activityId);
            int y = 10;
            Color[] bgs = { Color.FromArgb(255, 220, 230), Color.FromArgb(220, 240, 255), Color.FromArgb(220, 255, 235), Color.FromArgb(255, 245, 210) };
            Color[] fgs = { Color.FromArgb(180, 40, 90), Color.FromArgb(30, 90, 180), Color.FromArgb(30, 150, 80), Color.FromArgb(160, 100, 0) };
            int idx = 0;

            foreach (DataRow op in opciones.Rows)
            {
                string texto = op["option_text"].ToString();
                bool esCorrecta = Convert.ToBoolean(op["is_correct"]);

                Button btn = new Button
                {
                    Text = texto,
                    Size = new Size(panelActividad.Width - 40, 46),
                    Location = new Point(20, y),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    BackColor = bgs[idx % 4],
                    ForeColor = fgs[idx % 4],
                    Tag = esCorrecta,
                    Cursor = Cursors.Hand
                };
                btn.FlatAppearance.BorderColor = Color.FromArgb(220, 210, 195);
                btn.FlatAppearance.BorderSize = 1;
                btn.Click += (s, e) => VerificarOpcionMultiple(btn, (bool)btn.Tag);
                panelActividad.Controls.Add(btn);
                y += 56;
                idx++;
            }
        }

        private void VerificarOpcionMultiple(Button btnSeleccionado, bool esCorrecta)
        {
            if (respondioActual) return;
            respondioActual = true;

            foreach (Control c in panelActividad.Controls)
            {
                if (c is Button b)
                {
                    bool ok = (bool)b.Tag;
                    b.BackColor = ok ? Color.FromArgb(200, 255, 220) : Color.FromArgb(255, 200, 200);
                    b.ForeColor = ok ? Color.FromArgb(20, 120, 60) : Color.FromArgb(160, 30, 30);
                    b.FlatAppearance.BorderColor = ok ? Color.FromArgb(100, 220, 140) : Color.FromArgb(220, 130, 130);
                    b.Enabled = false;
                }
            }
            MostrarFeedback(esCorrecta);
            if (esCorrecta) respuestasCorrectas++;
        }

        // =====================================================
        // RELLENAR ESPACIO
        // =====================================================
        private void MostrarRellenarEspacio(string content, string correctAnswer)
        {
            Label lbl = new Label
            {
                Text = content,
                Font = new Font("Segoe UI", 12F),
                ForeColor = Color.FromArgb(45, 55, 72),
                Location = new Point(20, 10),
                Size = new Size(panelActividad.Width - 40, 50),
                AutoSize = false
            };

            TextBox txt = new TextBox
            {
                Font = new Font("Segoe UI", 13F),
                Location = new Point(20, 70),
                Size = new Size(300, 40),
                Name = "txtRespuesta",
                BackColor = Color.FromArgb(255, 252, 242)
            };

            Button btnVerificar = CrearBtnVerificar(340, 70);
            btnVerificar.Click += (s, e) =>
            {
                if (respondioActual) return;
                respondioActual = true;
                bool correcto = txt.Text.Trim().ToLower() == correctAnswer.Trim().ToLower();
                txt.BackColor = correcto ? Color.FromArgb(200, 255, 220) : Color.FromArgb(255, 200, 200);
                if (!correcto)
                    panelActividad.Controls.Add(new Label { Text = $"✓ Respuesta: {correctAnswer}", Font = new Font("Segoe UI", 10F), ForeColor = Color.FromArgb(22, 101, 52), Location = new Point(20, 120), AutoSize = true });
                MostrarFeedback(correcto);
                if (correcto) respuestasCorrectas++;
                txt.ReadOnly = true;
                btnVerificar.Enabled = false;
            };

            panelActividad.Controls.Add(lbl);
            panelActividad.Controls.Add(txt);
            panelActividad.Controls.Add(btnVerificar);
        }

        // =====================================================
        // TRADUCCIÓN
        // =====================================================
        private void MostrarTraduccion(string content, string correctAnswer)
        {
            Label lbl = new Label
            {
                Text = $"Traduce: \"{content}\"",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(45, 55, 72),
                Location = new Point(20, 10),
                AutoSize = true
            };

            TextBox txt = new TextBox
            {
                Font = new Font("Segoe UI", 13F),
                Location = new Point(20, 60),
                Size = new Size(300, 40),
                Name = "txtTraduccion",
                BackColor = Color.FromArgb(240, 248, 255)
            };

            Button btnVerificar = CrearBtnVerificar(340, 60);
            btnVerificar.Click += (s, e) =>
            {
                if (respondioActual) return;
                respondioActual = true;
                bool correcto = txt.Text.Trim().ToLower() == correctAnswer.Trim().ToLower();
                txt.BackColor = correcto ? Color.FromArgb(200, 255, 220) : Color.FromArgb(255, 200, 200);
                if (!correcto)
                    panelActividad.Controls.Add(new Label { Text = $"✓ Respuesta: {correctAnswer}", Font = new Font("Segoe UI", 10F), ForeColor = Color.FromArgb(22, 101, 52), Location = new Point(20, 110), AutoSize = true });
                MostrarFeedback(correcto);
                if (correcto) respuestasCorrectas++;
                txt.ReadOnly = true;
                btnVerificar.Enabled = false;
            };

            panelActividad.Controls.Add(lbl);
            panelActividad.Controls.Add(txt);
            panelActividad.Controls.Add(btnVerificar);
        }

        // =====================================================
        // ESCUCHAR Y RESPONDER
        // =====================================================
        private void MostrarEscucharResponder(string content, string correctAnswer, string audioUrl)
        {
            Button btnEscuchar = new Button
            {
                Text = "🔊  Escuchar",
                Size = new Size(160, 44),
                Location = new Point(20, 10),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                BackColor = Color.FromArgb(220, 240, 255),
                ForeColor = Color.FromArgb(29, 78, 216),
                Cursor = Cursors.Hand
            };
            btnEscuchar.FlatAppearance.BorderColor = Color.FromArgb(147, 197, 253);
            btnEscuchar.Click += (s, e) => EscucharTexto(content);

            TextBox txt = new TextBox
            {
                Font = new Font("Segoe UI", 13F),
                Location = new Point(20, 65),
                Size = new Size(300, 40),
                PlaceholderText = "Escribe lo que escuchaste...",
                BackColor = Color.FromArgb(240, 248, 255)
            };

            Button btnVerificar = CrearBtnVerificar(340, 65);
            btnVerificar.Click += (s, e) =>
            {
                if (respondioActual) return;
                respondioActual = true;
                bool correcto = txt.Text.Trim().ToLower() == correctAnswer.Trim().ToLower();
                txt.BackColor = correcto ? Color.FromArgb(200, 255, 220) : Color.FromArgb(255, 200, 200);
                if (!correcto)
                    panelActividad.Controls.Add(new Label { Text = $"✓ Respuesta: {correctAnswer}", Font = new Font("Segoe UI", 10F), ForeColor = Color.FromArgb(22, 101, 52), Location = new Point(20, 115), AutoSize = true });
                MostrarFeedback(correcto);
                if (correcto) respuestasCorrectas++;
                txt.ReadOnly = true;
                btnVerificar.Enabled = false;
            };

            panelActividad.Controls.Add(btnEscuchar);
            panelActividad.Controls.Add(txt);
            panelActividad.Controls.Add(btnVerificar);
        }

        // =====================================================
        // VOCABULARIO
        // =====================================================
        private void MostrarVocabulario(string content, string imageUrl)
        {
            Label lbl = new Label
            {
                Text = content,
                Font = new Font("Segoe UI Black", 26F, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 60, 120),
                Location = new Point(20, 20),
                AutoSize = true
            };

            Button btnEscuchar = new Button
            {
                Text = "🔊  Escuchar pronunciación",
                Size = new Size(240, 42),
                Location = new Point(20, 82),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.FromArgb(220, 240, 255),
                ForeColor = Color.FromArgb(29, 78, 216),
                Cursor = Cursors.Hand
            };
            btnEscuchar.FlatAppearance.BorderColor = Color.FromArgb(147, 197, 253);
            btnEscuchar.Click += (s, e) => EscucharTexto(content);

            respondioActual = true;
            respuestasCorrectas++;
            btnSiguiente.Visible = true;

            panelActividad.Controls.Add(lbl);
            panelActividad.Controls.Add(btnEscuchar);
        }

        // =====================================================
        // FEEDBACK
        // =====================================================
        private void MostrarFeedback(bool correcto)
        {
            lblFeedback.Text = correcto ? "✓  ¡Correcto! 🌟" : "✗  Incorrecto";
            lblFeedback.ForeColor = correcto ? Color.FromArgb(22, 101, 52) : Color.FromArgb(153, 27, 27);
            lblFeedback.BackColor = correcto ? Color.FromArgb(210, 255, 225) : Color.FromArgb(255, 215, 215);
            lblFeedback.Visible = true;
            btnSiguiente.Visible = true;
        }

        // =====================================================
        // RESULTADOS FINALES
        // =====================================================
        private void MostrarResultados()
        {
            int total = dtActividades.Rows.Count;
            int pct = total > 0 ? (int)((double)respuestasCorrectas / total * 100) : 0;

            lessonService.CompletarLeccion(studentId, lessonId, respuestasCorrectas, total);
            progressBar.Value = 100;

            LimpiarAreaActividad();
            panelActividad.Visible = false;
            lblInstruccion.Visible = false;
            lblFeedback.Visible = false;
            btnSiguiente.Visible = false;
            picActividad.Visible = false;
            panelContenido.Visible = false;

            panelResultados.Visible = true;
            lblPuntaje.Text = $"{pct}%";
            lblResumen.Text = $"Respondiste correctamente {respuestasCorrectas} de {total} actividades";
            lblMedalla.Text = pct >= 80 ? "🏆" : pct >= 60 ? "⭐" : "📚";
            lblMensaje.Text = pct >= 80 ? "¡Eres increíble! 🌟" :
                               pct >= 60 ? "¡Buen trabajo! Sigue así." :
                                           "¡Sigue practicando! 💪";
        }

        // =====================================================
        // NAVEGACIÓN
        // =====================================================
        private void btnSiguiente_Click(object sender, EventArgs e) => MostrarActividad(actividadActual + 1);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // ✅ Volver a FrmLecciones en el panel
            if (frmPrincipal != null)
                frmPrincipal.AbrirFormEnPanel(new FrmLecciones(studentId));
            else
                this.Close();
        }

        private void btnVolverLecciones_Click(object sender, EventArgs e)
        {
            // ✅ Volver a FrmLecciones en el panel
            if (frmPrincipal != null)
                frmPrincipal.AbrirFormEnPanel(new FrmLecciones(studentId));
            else
                this.Close();
        }

        // =====================================================
        // HELPERS
        // =====================================================
        private void LimpiarAreaActividad() => panelActividad.Controls.Clear();

        private Button CrearBtnVerificar(int x, int y)
        {
            var btn = new Button
            {
                Text = "Verificar ✓",
                Size = new Size(130, 40),
                Location = new Point(x, y),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.FromArgb(255, 140, 0),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        private async Task CargarImagen(string url)
        {
            try
            {
                byte[] data = await client.GetByteArrayAsync(url);
                picActividad.Image = Image.FromStream(new MemoryStream(data));
                picActividad.Visible = true;
            }
            catch { picActividad.Visible = false; }
        }

        private void EscucharTexto(string texto)
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                try
                {
                    string vbs = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "tts_leccion.vbs");
                    System.IO.File.WriteAllText(vbs, $"CreateObject(\"SAPI.SpVoice\").Speak \"{texto}\"");
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "cscript",
                        Arguments = $"//NoLogo \"{vbs}\"",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    using (var proc = System.Diagnostics.Process.Start(psi))
                        proc.WaitForExit();
                    if (System.IO.File.Exists(vbs)) System.IO.File.Delete(vbs);
                }
                catch { }
            });
        }
    }
}