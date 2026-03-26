using System;

namespace LoginLayeredCSharp.Domain.Models
{
    /// <summary>
    /// Modelo estandarizado para lista de vocabulario
    /// </summary>
    public class VocabularyList
    {
        public int ListId { get; set; }
        public int GroupId { get; set; }
        public string ListName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int TeacherId { get; set; }
        public string TeacherName { get; set; } = string.Empty;
        public bool IsPublished { get; set; } = false;
        public DateTime CreatedAt { get; set; }

        // Información relacionada
        public string GroupName { get; set; } = string.Empty;

        // Propiedades calculadas
        public int TotalWords { get; set; }
        public string StatusDisplay => IsPublished ? "✅ Publicada" : "📝 Borrador";
        public string DisplayName => $"{ListName} ({TotalWords} palabras)";

        public VocabularyList()
        {
            CreatedAt = DateTime.Now;
        }
    }

    /// <summary>
    /// Modelo estandarizado para palabra en vocabulario
    /// </summary>
    public class VocabularyItem
    {
        public int ItemId { get; set; }
        public int ListId { get; set; }
        public string EnglishWord { get; set; } = string.Empty;
        public string SpanishWord { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Pronunciation { get; set; } = string.Empty;
        public int OrderNumber { get; set; }
        public DateTime CreatedAt { get; set; }

        // Información relacionada
        public string ListName { get; set; } = string.Empty;

        // Propiedades calculadas
        public string DisplayName => $"{EnglishWord} - {SpanishWord}";
        public bool HasImage => !string.IsNullOrEmpty(ImageUrl);
        public bool HasPronunciation => !string.IsNullOrEmpty(Pronunciation);

        public VocabularyItem()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
