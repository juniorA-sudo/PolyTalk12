using System;

namespace LoginLayeredCSharp.Domain.Models
{
    /// <summary>
    /// Modelo estandarizado para maestro
    /// Contiene información específica del rol maestro
    /// </summary>
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int UserId { get; set; }
        public string TeacherCode { get; set; } = string.Empty;
        public string EnglishLevel { get; set; } = string.Empty;  // A1-C2
        public DateTime HireDate { get; set; }

        // Información del usuario relacionado
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        // Propiedades calculadas
        public int YearsExperience => (DateTime.Now - HireDate).Days / 365;

        public string LevelDisplay => EnglishLevel switch
        {
            "A1" => "🌱 Beginner (A1)",
            "A2" => "🌿 Elementary (A2)",
            "B1" => "🌳 Intermediate (B1)",
            "B2" => "🏔️ Upper Intermediate (B2)",
            "C1" => "🦅 Advanced (C1)",
            "C2" => "🚀 Proficiency (C2)",
            _ => EnglishLevel
        };

        public string StatusDisplay => IsActive ? "✅ Activo" : "❌ Inactivo";

        public Teacher()
        {
            HireDate = DateTime.Now;
        }
    }
}
