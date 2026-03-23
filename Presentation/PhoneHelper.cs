using System.Text.RegularExpressions;

namespace Presentation
{
    public static class PhoneHelper
    {
        /// <summary>
        /// Valida y formatea un número telefónico dominicano
        /// Acepta: 809-123-4567, 8091234567, +1 809-123-4567, etc.
        /// Retorna: 809-123-4567
        /// </summary>
        public static string FormatearTelefonoDominicano(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono))
                return "";

            // Eliminar espacios, guiones, paréntesis y el +1
            string limpio = Regex.Replace(telefono.Trim(), @"[\s\-()]+", "");
            limpio = limpio.Replace("+1", "").Replace("+", "");

            // Validar que solo tenga números
            if (!Regex.IsMatch(limpio, @"^\d+$"))
                return null; // Inválido

            // Si empieza con 1, remover el 1 (en caso de +1-809-...)
            if (limpio.StartsWith("1") && limpio.Length == 11)
                limpio = limpio.Substring(1);

            // Validar que sea 10 dígitos
            if (limpio.Length != 10)
                return null; // Inválido

            // Validar que empiece con 809, 829 o 849
            if (!Regex.IsMatch(limpio, @"^(809|829|849)\d{7}$"))
                return null; // Inválido

            // Formatear: 809-123-4567
            return $"{limpio.Substring(0, 3)}-{limpio.Substring(3, 3)}-{limpio.Substring(6, 4)}";
        }

        /// <summary>
        /// Valida si un número telefónico dominicano es válido
        /// </summary>
        public static bool EsTelefonoDominicanoValido(string telefono)
        {
            return FormatearTelefonoDominicano(telefono) != null;
        }

        /// <summary>
        /// Obtiene solo los dígitos del teléfono (sin guiones)
        /// Útil para almacenamiento o búsqueda en BD
        /// </summary>
        public static string ObtenerSoloDigitos(string telefono)
        {
            string formateado = FormatearTelefonoDominicano(telefono);
            if (formateado == null) return "";
            return Regex.Replace(formateado, @"\D", "");
        }
    }
}
