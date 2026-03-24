using System;
using System.Windows.Forms;
using System.Globalization;

namespace Presentation
{
    /// <summary>
    /// Helper class para aplicar filtros de fecha a DataGridView en formularios de reportes.
    /// Proporciona métodos reutilizables para filtrar datos por rango de fechas.
    /// </summary>
    public static class ReportFilterHelper
    {
        /// <summary>
        /// Aplica un filtro de rango de fechas a un DataGridView.
        /// Oculta las filas que no coincidan con el rango especificado.
        /// </summary>
        /// <param name="dgv">DataGridView a filtrar</param>
        /// <param name="dateFrom">Fecha inicial del rango (inclusive)</param>
        /// <param name="dateTo">Fecha final del rango (exclusive - no incluye este día completo)</param>
        /// <param name="dateColumnName">Nombre de la columna que contiene las fechas</param>
        public static void ApplyDateFilter(DataGridView dgv, DateTime dateFrom, DateTime dateTo, string dateColumnName)
        {
            if (dgv == null || dgv.Columns.Count == 0)
                return;

            // Añadir un día a 'dateTo' para incluir todo el día final
            dateTo = dateTo.AddDays(1);

            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    var row = dgv.Rows[i];

                    // Verificar que la columna existe
                    if (!dgv.Columns.Contains(dateColumnName))
                    {
                        row.Visible = true;
                        continue;
                    }

                    var cellValue = row.Cells[dateColumnName].Value;

                    // Intentar parsear la fecha de diferentes formatos
                    DateTime rowDate;
                    if (cellValue == null || cellValue == DBNull.Value)
                    {
                        row.Visible = false;
                        continue;
                    }

                    if (cellValue is DateTime dt)
                    {
                        rowDate = dt;
                    }
                    else if (DateTime.TryParse(cellValue.ToString(), out rowDate))
                    {
                        // Parsing exitoso
                    }
                    else
                    {
                        // Si no se puede parsear, ocultar la fila
                        row.Visible = false;
                        continue;
                    }

                    // Aplicar el filtro: verificar si la fecha está en el rango
                    row.Visible = rowDate >= dateFrom && rowDate < dateTo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtro de fecha:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Limpia el filtro de fecha mostrando todas las filas del DataGridView.
        /// </summary>
        /// <param name="dgv">DataGridView al que limpiar el filtro</param>
        public static void ClearDateFilter(DataGridView dgv)
        {
            if (dgv == null || dgv.Rows.Count == 0)
                return;

            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    dgv.Rows[i].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar filtro:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Valida que la fecha inicial sea menor o igual a la fecha final.
        /// </summary>
        /// <param name="dateFrom">Fecha inicial</param>
        /// <param name="dateTo">Fecha final</param>
        /// <returns>true si las fechas son válidas, false en caso contrario</returns>
        public static bool ValidateDateRange(DateTime dateFrom, DateTime dateTo)
        {
            if (dateFrom > dateTo)
            {
                MessageBox.Show("La fecha inicial debe ser menor o igual a la fecha final.", "Validación de Fecha",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
