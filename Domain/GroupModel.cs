using System;

namespace LoginLayeredCSharp.Domain.Models
{
    /// <summary>
    /// Modelo estandarizado para grupo/clase
    /// Representa un grupo de estudiantes que comparten clase
    /// </summary>
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public string GroupCode { get; set; } = string.Empty;
        public string EnglishLevel { get; set; } = string.Empty;  // A1-C2
        public int MaxCapacity { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        // Información actualizada
        public int CurrentEnrollment { get; set; }

        // Propiedades calculadas
        public int AvailableSpots => MaxCapacity - CurrentEnrollment;
        public bool IsFull => CurrentEnrollment >= MaxCapacity;

        public string LevelDisplay => EnglishLevel switch
        {
            "A1" => "🌱 A1 (Beginner)",
            "A2" => "🌿 A2 (Elementary)",
            "B1" => "🌳 B1 (Intermediate)",
            "B2" => "🏔️ B2 (Upper Intermediate)",
            "C1" => "🦅 C1 (Advanced)",
            "C2" => "🚀 C2 (Proficiency)",
            _ => EnglishLevel
        };

        public string CapacityDisplay => $"{CurrentEnrollment} / {MaxCapacity}";

        public string CapacityStatus
        {
            get
            {
                if (IsFull)
                    return $"🔴 Lleno ({AvailableSpots} disponibles)";
                else if (AvailableSpots <= 2)
                    return $"🟡 Casi lleno ({AvailableSpots} disponibles)";
                else
                    return $"🟢 Con cupo ({AvailableSpots} disponibles)";
            }
        }

        public Group()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
