using System;

namespace LoginLayeredCSharp.Domain.Models
{
    /// <summary>
    /// Modelo estandarizado para usuario del sistema
    /// Representa: Admin, Teacher, Student
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string UserRole { get; set; } = string.Empty;  // ADMINISTRADOR, MAESTRO, ESTUDIANTE
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }

        // Propiedades calculadas
        public string DisplayName => Username.ToUpper();

        public string RoleDisplay => UserRole?.ToUpper() switch
        {
            "ADMINISTRADOR" => "👨‍💼 Administrador",
            "MAESTRO" => "👨‍🏫 Maestro",
            "ESTUDIANTE" => "👤 Estudiante",
            _ => UserRole
        };

        public string StatusDisplay => IsActive ? "✅ Activo" : "❌ Inactivo";

        public User()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
