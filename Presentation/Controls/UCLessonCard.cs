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
            InitializeComponent(); // Este llama al del Designer
        }

        public void SetLessonData(string title, string type, bool completed)
        {
            LessonTitle = title;
            LessonType = type;
            IsCompleted = completed;

            if (lblTitulo == null) return; // Seguridad

            lblTitulo.Text = title;
            lblTipo.Text = GetTypeIcon(type);

            if (completed)
            {
                lblTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout);
                lblTitulo.ForeColor = Color.Gray;
            }
            else
            {
                lblTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                lblTitulo.ForeColor = Color.Black;
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
                "exercise" => "✏️ Ejercicio",
                "quiz" => "📝 Quiz",
                _ => $"📘 {type}"
            };
        }

        private void UCLessonCard_Click(object? sender, EventArgs e)
        {
            LessonClicked?.Invoke(this, LessonId);
        }
    }
}