using System;

namespace LoginLayeredCSharp.Domain.Models
{
    /// <summary>
    /// Modelo estandarizado para estudiante
    /// Contiene información específica del rol estudiante
    /// </summary>
    public class Student
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public string StudentCode { get; set; } = string.Empty;
        public string CurrentEnglishLevel { get; set; } = string.Empty;  // A1-C2
        public DateTime EnrollmentDate { get; set; }

        // Información del usuario relacionado
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Propiedades calculadas
        public int MonthsEnrolled => (DateTime.Now - EnrollmentDate).Days / 30;

        public string LevelDisplay => CurrentEnglishLevel switch
        {
            "A1" => "🌱 Beginner (A1)",
            "A2" => "🌿 Elementary (A2)",
            "B1" => "🌳 Intermediate (B1)",
            "B2" => "🏔️ Upper Intermediate (B2)",
            "C1" => "🦅 Advanced (C1)",
            "C2" => "🚀 Proficiency (C2)",
            _ => CurrentEnglishLevel
        };

        public Student()
        {
            EnrollmentDate = DateTime.Now;
        }
    }
}
