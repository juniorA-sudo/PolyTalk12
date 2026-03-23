using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmVerLeccion : Form
    {
        private readonly LessonService lessonService;
        private readonly int lessonId;
        private readonly int studentId;
        private readonly FrmPrincipal frmPrincipal; // ✅ referencia al padre

        private DataTable dtContenido;
        private int paginaActual = 0;
        private static readonly HttpClient client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

        // ✅ Constructor con FrmPrincipal opcional para abrir en panel
        public FrmVerLeccion(int lessonId, int studentId, FrmPrincipal frmPrincipal = null)
        {
            InitializeComponent();
            this.lessonId = lessonId;
            this.studentId = studentId;
            this.frmPrincipal = frmPrincipal;
            lessonService = new LessonService();
        }

        private void FrmVerLeccion_Load(object sender, EventArgs e)
        {
            CargarInfoLeccion();
            CargarContenido();
        }

        private void CargarInfoLeccion()
        {
            DataRow info = lessonService.ObtenerInfoLeccion(lessonId);
            if (info == null) return;

            lblTituloLeccion.Text = info["lesson_title"].ToString();
            lblSubtitulo.Text = $"{info["level_code"]} · {info["unit_title"]}";
            lblDuracion.Text = $"⏱ {info["duration_minutes"]} min";
            lblTipo.Text = TipoAmigable(info["lesson_type"].ToString());
        }

        private void CargarContenido()
        {
            dtContenido = lessonService.ObtenerContenidoLeccion(lessonId);

            if (dtContenido.Rows.Count == 0)
            {
                lblTituloContenido.Text = "Sin contenido";
                rtbExplicacion.Text = "Esta lección aún no tiene contenido explicativo.";
                btnSiguientePagina.Visible = false;
                btnAnteriorPagina.Visible = false;
                return;
            }

            MostrarPagina(0);
        }

        private async void MostrarPagina(int index)
        {
            if (dtContenido == null || index < 0 || index >= dtContenido.Rows.Count) return;

            DataRow row = dtContenido.Rows[index];
            paginaActual = index;

            lblTituloContenido.Text = row["title"].ToString();
            rtbExplicacion.Text = row["explanation"].ToString();
            lblPagina.Text = $"{index + 1} / {dtContenido.Rows.Count}";

            btnAnteriorPagina.Enabled = index > 0;
            btnSiguientePagina.Visible = true;

            bool esUltima = index == dtContenido.Rows.Count - 1;
            btnSiguientePagina.Text = esUltima ? "▶  Empezar lección" : "Siguiente →";
            btnSiguientePagina.FillColor = esUltima
                ? Color.FromArgb(255, 60, 120)   // fucsia en la última
                : Color.FromArgb(255, 140, 0);   // naranja normal

            // Imagen
            string imageUrl = row["image_url"]?.ToString() ?? "";
            if (!string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    byte[] data = await client.GetByteArrayAsync(imageUrl);
                    picContenido.Image = Image.FromStream(new MemoryStream(data));
                    picContenido.Visible = true;
                    rtbExplicacion.Size = new Size(578, 222);
                }
                catch { picContenido.Visible = false; }
            }
            else
            {
                picContenido.Image = null;
                picContenido.Visible = false;
                rtbExplicacion.Size = new Size(774, 222); // ocupa todo el ancho
            }
        }

        private void btnSiguientePagina_Click(object sender, EventArgs e)
        {
            if (paginaActual < dtContenido.Rows.Count - 1)
            {
                MostrarPagina(paginaActual + 1);
            }
            else
            {
                AbrirPractica();
            }
        }

        private void btnAnteriorPagina_Click(object sender, EventArgs e)
        {
            MostrarPagina(paginaActual - 1);
        }

        private void AbrirPractica()
        {
            // Verificar que tenga actividades
            DataTable actividades = lessonService.ObtenerActividades(lessonId);
            if (actividades.Rows.Count == 0)
            {
                MessageBox.Show("Esta lección no tiene actividades aún.", "Sin actividades",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ✅ Abrir FrmPracticarLeccion en el panel del FrmPrincipal
            if (frmPrincipal != null)
            {
                var frm = new FrmPracticarLeccion(lessonId, studentId, frmPrincipal);
                frmPrincipal.AbrirFormEnPanel(frm);
            }
            else
            {
                // Fallback: ShowDialog si no hay FrmPrincipal
                this.Hide();
                using var frm = new FrmPracticarLeccion(lessonId, studentId);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // ✅ Volver a FrmLecciones en el panel
            if (frmPrincipal != null)
                frmPrincipal.AbrirFormEnPanel(new FrmLecciones(studentId));
            else
                this.Close();
        }

        private string TipoAmigable(string tipo) => tipo switch
        {
            "vocabulary" => "📖 Vocabulario",
            "grammar" => "✏️ Gramática",
            "conversation" => "💬 Conversación",
            "listening" => "🎧 Escucha",
            _ => tipo
        };
    }
}