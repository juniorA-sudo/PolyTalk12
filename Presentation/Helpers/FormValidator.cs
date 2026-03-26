using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation
{
    /// <summary>
    /// Clase centralizada para validación de datos en formularios
    /// Reutilizable en todos los módulos (entrada, proceso, salida)
    /// </summary>
    public static class FormValidator
    {
        // =====================================================================
        // VALIDACIONES COMUNES
        // =====================================================================

        /// <summary>Valida que un campo no esté vacío</summary>
        public static bool ValidarNoVacio(string valor, string nombreCampo, out string error)
        {
            error = null;
            if (string.IsNullOrWhiteSpace(valor))
            {
                error = $"{nombreCampo} es requerido.";
                return false;
            }
            return true;
        }

        /// <summary>Valida email con patrón estándar</summary>
        public static bool ValidarEmail(string email, out string error)
        {
            error = null;
            if (!ValidarNoVacio(email, "Email", out error))
                return false;

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email.Trim(), patron))
            {
                error = "Email inválido. Usa formato: usuario@dominio.com";
                return false;
            }
            return true;
        }

        /// <summary>Valida que sea números solamente</summary>
        public static bool ValidarNumeros(string valor, string nombreCampo, out string error)
        {
            error = null;
            if (!ValidarNoVacio(valor, nombreCampo, out error))
                return false;

            if (!int.TryParse(valor.Trim(), out _))
            {
                error = $"{nombreCampo} debe ser un número.";
                return false;
            }
            return true;
        }

        /// <summary>Valida número positivo</summary>
        public static bool ValidarNumeroPositivo(string valor, string nombreCampo, out string error)
        {
            error = null;
            if (!ValidarNumeros(valor, nombreCampo, out error))
                return false;

            if (!int.TryParse(valor.Trim(), out int num) || num <= 0)
            {
                error = $"{nombreCampo} debe ser un número positivo.";
                return false;
            }
            return true;
        }

        /// <summary>Valida solo letras (con tildes)</summary>
        public static bool ValidarSoloLetras(string valor, string nombreCampo, out string error)
        {
            error = null;
            if (!ValidarNoVacio(valor, nombreCampo, out error))
                return false;

            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$";
            if (!Regex.IsMatch(valor.Trim(), patron))
            {
                error = $"{nombreCampo} solo puede contener letras.";
                return false;
            }
            return true;
        }

        /// <summary>Valida longitud de texto</summary>
        public static bool ValidarLongitud(string valor, int minimo, int maximo, string nombreCampo, out string error)
        {
            error = null;
            if (!ValidarNoVacio(valor, nombreCampo, out error))
                return false;

            int len = valor.Trim().Length;
            if (len < minimo || len > maximo)
            {
                error = $"{nombreCampo} debe tener entre {minimo} y {maximo} caracteres.";
                return false;
            }
            return true;
        }

        /// <summary>Valida contraseña (letras + números, mínimo 6 caracteres)</summary>
        public static bool ValidarContrasena(string password, string nombreCampo, out string error)
        {
            error = null;
            if (!ValidarNoVacio(password, nombreCampo, out error))
                return false;

            if (password.Length < 6)
            {
                error = $"{nombreCampo} debe tener al menos 6 caracteres.";
                return false;
            }

            string patron = @"^(?=.*[a-zA-Z])(?=.*\d).+$";
            if (!Regex.IsMatch(password, patron))
            {
                error = $"{nombreCampo} debe contener al menos una letra y un número.";
                return false;
            }
            return true;
        }

        /// <summary>Valida que dos campos coincidan</summary>
        public static bool ValidarCoincidencia(string valor1, string valor2, string nombreCampo, out string error)
        {
            error = null;
            if (valor1 != valor2)
            {
                error = $"Los campos de {nombreCampo} no coinciden.";
                return false;
            }
            return true;
        }

        /// <summary>Valida fecha no vacía</summary>
        public static bool ValidarFecha(DateTime fecha, string nombreCampo, out string error)
        {
            error = null;
            if (fecha == DateTime.MinValue)
            {
                error = $"{nombreCampo} es requerida.";
                return false;
            }
            return true;
        }

        /// <summary>Valida que la fecha sea futura</summary>
        public static bool ValidarFechaFutura(DateTime fecha, string nombreCampo, out string error)
        {
            error = null;
            if (!ValidarFecha(fecha, nombreCampo, out error))
                return false;

            if (fecha <= DateTime.Today)
            {
                error = $"{nombreCampo} debe ser una fecha futura.";
                return false;
            }
            return true;
        }

        /// <summary>Valida que sea selección (índice >= 0)</summary>
        public static bool ValidarSeleccion(int selectedIndex, string nombreCampo, out string error)
        {
            error = null;
            if (selectedIndex < 0)
            {
                error = $"Selecciona una opción para {nombreCampo}.";
                return false;
            }
            return true;
        }

        // =====================================================================
        // UTILIDADES DE MENSAJES
        // =====================================================================

        /// <summary>Muestra error y enfoca control</summary>
        public static void MostrarError(string mensaje, Control control = null)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control?.Focus();
        }

        /// <summary>Muestra múltiples errores en una lista</summary>
        public static void MostrarErrores(List<string> errores)
        {
            string mensaje = "Se encontraron los siguientes errores:\n\n";
            foreach (var error in errores)
                mensaje += $"• {error}\n";

            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>Muestra confirmación</summary>
        public static bool MostrarConfirmacion(string mensaje)
        {
            return MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        // =====================================================================
        // VALIDACIONES ESPECÍFICAS DEL DOMINIO
        // =====================================================================

        /// <summary>Valida nivel MCER</summary>
        public static bool ValidarNivelMCER(string nivel, out string error)
        {
            error = null;
            var nivelesValidos = new[] { "A1", "A2", "B1", "B2", "C1", "C2" };

            if (!Array.Exists(nivelesValidos, e => e == nivel))
            {
                error = $"Nivel MCER inválido. Debe ser uno de: {string.Join(", ", nivelesValidos)}";
                return false;
            }
            return true;
        }

        /// <summary>Valida estado de tarea</summary>
        public static bool ValidarEstadoTarea(string estado, out string error)
        {
            error = null;
            var estadosValidos = new[] { "Pending", "Submitted", "Expired", "Graded" };

            if (!Array.Exists(estadosValidos, e => e == estado))
            {
                error = $"Estado inválido. Debe ser uno de: {string.Join(", ", estadosValidos)}";
                return false;
            }
            return true;
        }

        /// <summary>Valida que archivo existe y tiene tamaño válido (máx 10MB)</summary>
        public static bool ValidarArchivo(string rutaArchivo, out string error)
        {
            error = null;
            if (string.IsNullOrWhiteSpace(rutaArchivo))
            {
                error = "Selecciona un archivo.";
                return false;
            }

            if (!System.IO.File.Exists(rutaArchivo))
            {
                error = "El archivo seleccionado no existe.";
                return false;
            }

            var info = new System.IO.FileInfo(rutaArchivo);
            if (info.Length > 10 * 1024 * 1024) // 10MB
            {
                error = "El archivo no puede exceder 10 MB.";
                return false;
            }

            return true;
        }

        /// <summary>Valida búsqueda de texto (mínimo 2 caracteres)</summary>
        public static bool ValidarBusqueda(string termino, out string error)
        {
            error = null;
            if (string.IsNullOrWhiteSpace(termino) || termino.Length < 2)
            {
                error = "Ingresa al menos 2 caracteres para buscar.";
                return false;
            }
            return true;
        }
    }
}
