using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Controls
{
    public partial class UCLessonCard : UserControl
    {
        public int LessonId { get; set; }
        public string? LessonTitle { get; set; }
        public string? LessonType { get; set; }
        public bool IsCompleted { get; set; }

        public event EventHandler<int>? LessonClicked;

        public UCLessonCard()
        {
            InitializeComponent();
        }

        public void SetLessonData(string title, string type, bool completed)
        {
            LessonTitle = title;
            LessonType = type;
            IsCompleted = completed;

            if (lblTitulo == null) return;

            lblTitulo.Text = title;
            lblDescripcion.Text = GetTypeIcon(type);

            if (completed)
            {
                // Estado completado — verde suave
                panelCard.FillColor = Color.FromArgb(245, 255, 248);
                panelCard.BorderColor = Color.FromArgb(180, 230, 195);
                lblEstado.Text = "Completada";
                lblEstado.ForeColor = Color.FromArgb(22, 140, 70);
                lblEstado.BackColor = Color.FromArgb(210, 250, 225);
                lblIcono.Text = "✅";
                lblTitulo.ForeColor = Color.FromArgb(45, 55, 72);
                lblTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            else
            {
                // Estado pendiente — amarillo suave
                panelCard.FillColor = Color.White;
                panelCard.BorderColor = Color.FromArgb(230, 220, 200);
                lblEstado.Text = "Pendiente";
                lblEstado.ForeColor = Color.FromArgb(160, 100, 0);
                lblEstado.BackColor = Color.FromArgb(255, 240, 200);
                lblIcono.Text = "📖";
                lblTitulo.ForeColor = Color.FromArgb(45, 55, 72);
                lblTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private string GetTypeIcon(string type)
        {
            if (string.IsNullOrEmpty(type)) return "📘 Lección";
            return type.ToLower() switch
            {
                "vocabulary" => "🔤 Vocabulario",
                "speaking" => "🗣️ Speaking",
                "grammar" => "📚 Gramática",
                "listening" => "🎧 Listening",
                "reading" => "📖 Lectura",
                "writing" => "✍️ Escritura",
                "conversation" => "💬 Conversación",
                "exercise" => "✏️ Ejercicio",
                "quiz" => "📝 Quiz",
                _ => $"📘 {type}"
            };
        }

        private void DispararClick(object? sender, EventArgs e)
        {
            LessonClicked?.Invoke(this, LessonId);
        }

        // Hover effect
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            panelCard.ShadowDecoration.Depth = 10;
            panelCard.ShadowDecoration.Enabled = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            // Solo quitar sombra si el mouse salió del card completo
            var pos = PointToClient(Cursor.Position);
            if (!ClientRectangle.Contains(pos))
            {
                panelCard.ShadowDecoration.Depth = 4;
                panelCard.ShadowDecoration.Enabled = true;
            }
        }
    }
}