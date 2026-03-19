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

        private DataTable dtActividades;
        private int actividadActual = 0;
        private int respuestasCorrectas = 0;
        private bool respondioActual = false;

        private static readonly HttpClient client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

        public FrmPracticarLeccion(int lessonId, int studentId)
        {
            InitializeComponent();
            this.lessonId = lessonId;
            this.studentId = studentId;
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

            // Actualizar progreso
            lblProgreso.Text = $"Actividad {index + 1} de {dtActividades.Rows.Count}";
            progressBar.Value = (int)((double)(index) / dtActividades.Rows.Count * 100);
            lblInstruccion.Text = instruction;
            lblFeedback.Visible = false;
            btnSiguiente.Visible = false;
            btnSiguiente.Text = index == dtActividades.Rows.Count - 1 ? "Finalizar" : "Siguiente →";

            // Limpiar área de actividad
            LimpiarAreaActividad();

            // Imagen si existe
            if (!string.IsNullOrEmpty(imageUrl))
                await CargarImagen(imageUrl);
            else
                picActividad.Visible = false;

            // Renderizar según tipo
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
        // OPCIÓN MÚLTIPLE
        // =====================================================
        private void MostrarOpcionMultiple(int activityId, string correctAnswer)
        {
            DataTable opciones = lessonService.ObtenerOpciones(activityId);
            int y = 10;

            foreach (DataRow op in opciones.Rows)
            {
                string texto = op["option_text"].ToString();
                bool esCorrecta = Convert.ToBoolean(op["is_correct"]);

                Button btn = new Button
                {
                    Text = texto,
                    Size = new Size(panelActividad.Width - 40, 44),
                    Location = new Point(20, y),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 11F),
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(45, 55, 72),
                    Tag = esCorrecta,
                    Cursor = Cursors.Hand
                };
                btn.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
                btn.FlatAppearance.BorderSize = 1;
                btn.Click += (s, e) => VerificarOpcionMultiple(btn, (bool)btn.Tag);
                panelActividad.Controls.Add(btn);
                y += 54;
            }
        }

        private void VerificarOpcionMultiple(Button btnSeleccionado, bool esCorrecta)
        {
            if (respondioActual) return;
            respondioActual = true;

            // Colorear la opción correcta e incorrecta
            foreach (Control c in panelActividad.Controls)
            {
                if (c is Button b)
                {
                    bool estaCorrecta = (bool)b.Tag;
                    b.BackColor = estaCorrecta ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 226, 226);
                    b.ForeColor = estaCorrecta ? Color.FromArgb(22, 101, 52) : Color.FromArgb(153, 27, 27);
                    b.FlatAppearance.BorderColor = estaCorrecta ? Color.FromArgb(34, 197, 94) : Color.FromArgb(239, 68, 68);
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
                Name = "txtRespuesta"
            };

            Button btnVerificar = new Button
            {
                Text = "Verificar",
                Size = new Size(110, 40),
                Location = new Point(340, 70),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.FromArgb(79, 70, 229),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.Click += (s, e) =>
            {
                if (respondioActual) return;
                respondioActual = true;
                bool correcto = txt.Text.Trim().ToLower() == correctAnswer.Trim().ToLower();
                txt.BackColor = correcto ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 226, 226);
                if (!correcto)
                {
                    Label lblCorrecta = new Label
                    {
                        Text = $"✓ Respuesta: {correctAnswer}",
                        Font = new Font("Segoe UI", 10F),
                        ForeColor = Color.FromArgb(22, 101, 52),
                        Location = new Point(20, 120),
                        AutoSize = true
                    };
                    panelActividad.Controls.Add(lblCorrecta);
                }
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
                Name = "txtTraduccion"
            };

            Button btnVerificar = new Button
            {
                Text = "Verificar",
                Size = new Size(110, 40),
                Location = new Point(340, 60),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.FromArgb(79, 70, 229),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.Click += (s, e) =>
            {
                if (respondioActual) return;
                respondioActual = true;
                bool correcto = txt.Text.Trim().ToLower() == correctAnswer.Trim().ToLower();
                txt.BackColor = correcto ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 226, 226);
                if (!correcto)
                {
                    Label lblCorrecta = new Label
                    {
                        Text = $"✓ Respuesta: {correctAnswer}",
                        Font = new Font("Segoe UI", 10F),
                        ForeColor = Color.FromArgb(22, 101, 52),
                        Location = new Point(20, 110),
                        AutoSize = true
                    };
                    panelActividad.Controls.Add(lblCorrecta);
                }
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
                BackColor = Color.FromArgb(239, 246, 255),
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
                PlaceholderText = "Escribe lo que escuchaste..."
            };

            Button btnVerificar = new Button
            {
                Text = "Verificar",
                Size = new Size(110, 40),
                Location = new Point(340, 65),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BackColor = Color.FromArgb(79, 70, 229),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.Click += (s, e) =>
            {
                if (respondioActual) return;
                respondioActual = true;
                bool correcto = txt.Text.Trim().ToLower() == correctAnswer.Trim().ToLower();
                txt.BackColor = correcto ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 226, 226);
                if (!correcto)
                {
                    Label lblCorrecta = new Label
                    {
                        Text = $"✓ Respuesta: {correctAnswer}",
                        Font = new Font("Segoe UI", 10F),
                        ForeColor = Color.FromArgb(22, 101, 52),
                        Location = new Point(20, 115),
                        AutoSize = true
                    };
                    panelActividad.Controls.Add(lblCorrecta);
                }
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
        // VOCABULARIO (mostrar palabra + imagen)
        // =====================================================
        private void MostrarVocabulario(string content, string imageUrl)
        {
            Label lbl = new Label
            {
                Text = content,
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.FromArgb(79, 70, 229),
                Location = new Point(20, 20),
                AutoSize = true
            };

            Button btnEscuchar = new Button
            {
                Text = "🔊  Escuchar pronunciación",
                Size = new Size(220, 40),
                Location = new Point(20, 80),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.FromArgb(239, 246, 255),
                ForeColor = Color.FromArgb(29, 78, 216),
                Cursor = Cursors.Hand
            };
            btnEscuchar.FlatAppearance.BorderColor = Color.FromArgb(147, 197, 253);
            btnEscuchar.Click += (s, e) => EscucharTexto(content);

            // En vocabulario se avanza automáticamente después de escuchar
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
            lblFeedback.Text = correcto ? "✓  ¡Correcto!" : "✗  Incorrecto";
            lblFeedback.ForeColor = correcto ? Color.FromArgb(22, 101, 52) : Color.FromArgb(153, 27, 27);
            lblFeedback.BackColor = correcto ? Color.FromArgb(220, 252, 231) : Color.FromArgb(254, 226, 226);
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

            panelResultados.Visible = true;
            lblPuntaje.Text = $"{pct}%";
            lblResumen.Text = $"Respondiste correctamente {respuestasCorrectas} de {total} actividades";
            lblMedalla.Text = pct >= 80 ? "🏆" : pct >= 60 ? "⭐" : "📚";
            lblMensaje.Text = pct >= 80 ? "¡Excelente trabajo!" :
                               pct >= 60 ? "¡Buen trabajo! Sigue practicando." :
                                           "Sigue estudiando. ¡Tú puedes!";
        }

        // =====================================================
        // NAVEGACIÓN
        // =====================================================
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MostrarActividad(actividadActual + 1);
        }

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();

        private void btnVolverLecciones_Click(object sender, EventArgs e) => this.Close();

        // =====================================================
        // HELPERS
        // =====================================================
        private void LimpiarAreaActividad()
        {
            panelActividad.Controls.Clear();
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
                        synth.Speak(texto);
                    }
                }
                catch { }
            });
        }
    }
}