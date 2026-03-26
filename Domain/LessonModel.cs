using System;

namespace LoginLayeredCSharp.Domain.Models
{
    /// <summary>
    /// Modelo estandarizado para lección
    /// Contiene contenido educativo de una lección
    /// </summary>
    public class Lesson
    {
        public int LessonId { get; set; }
        public int UnitId { get; set; }
        public string LessonTitle { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int OrderNumber { get; set; }
        public bool IsPublished { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Información relacionada
        public string UnitTitle { get; set; } = string.Empty;
        public int TeacherId { get; set; }
        public string TeacherName { get; set; } = string.Empty;

        // Propiedades calculadas
        public string StatusDisplay => IsPublished ? "✅ Publicada" : "📝 Borrador";

        public string LastModifiedDisplay
        {
            get
            {
                var date = UpdatedAt ?? CreatedAt;
                return date.ToString("dd/MM/yyyy HH:mm");
            }
        }

        public Lesson()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
