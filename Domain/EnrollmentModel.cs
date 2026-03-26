using System;

namespace LoginLayeredCSharp.Domain.Models
{
    /// <summary>
    /// Modelo estandarizado para inscripción de estudiante en grupo
    /// </summary>
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Status { get; set; } = "activo";  // activo, completado, abandonado

        // Información relacionada
        public string StudentName { get; set; } = string.Empty;
        public string StudentCode { get; set; } = string.Empty;
        public string GroupName { get; set; } = string.Empty;
        public string GroupCode { get; set; } = string.Empty;
        public string EnglishLevel { get; set; } = string.Empty;

        // Propiedades calculadas
        public string StatusDisplay => Status?.ToLower() switch
        {
            "activo" => "✅ Activo",
            "completado" => "✔️ Completado",
            "abandonado" => "❌ Abandonado",
            _ => Status
        };

        public int DaysEnrolled => (DateTime.Now - EnrollmentDate).Days;

        public string EnrollmentDurationDisplay
        {
            get
            {
                if (DaysEnrolled < 30)
                    return $"{DaysEnrolled} días";
                else if (DaysEnrolled < 365)
                    return $"{DaysEnrolled / 30} meses";
                else
                    return $"{DaysEnrolled / 365} años";
            }
        }

        public Enrollment()
        {
            EnrollmentDate = DateTime.Now;
        }
    }
}
