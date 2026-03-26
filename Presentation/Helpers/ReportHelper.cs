using System;
using System.Data;
using System.Windows.Forms;
using FastReport;
using FastReport.Export.PdfSimple;
using Presentation.Services;

namespace Presentation.Helpers
{
    /// <summary>
    /// Helper centralizado para manejo estandarizado de reportes
    /// Proporciona métodos reutilizables para todos los reportes de la aplicación
    /// </summary>
    public static class ReportHelper
    {
        private static ReportService reportService = new ReportService();

        /// <summary>Exporta DataGridView a PDF usando ReportService</summary>
        public static bool ExportarAPDF(DataGridView dgv, string nombreReporte, string titulo)
        {
            return reportService.ExportarAPDF(dgv, nombreReporte, titulo);
        }

        /// <summary>Imprime DataGridView</summary>
        public static bool Imprimir(DataGridView dgv, string nombreReporte, string titulo)
        {
            return reportService.ImprimirReporte(dgv, nombreReporte, titulo);
        }

        /// <summary>Exporta DataGridView a CSV</summary>
        public static bool ExportarACSV(DataGridView dgv, string nombreReporte)
        {
            return reportService.ExportarACSV(dgv, nombreReporte);
        }

        /// <summary>Abre carpeta de reportes</summary>
        public static void AbrirCarpetaReportes()
        {
            reportService.AbrirCarpetaReportes();
        }

        /// <summary>Exporta usando FastReport (método heredado, se mantiene por compatibilidad)</summary>
        public static bool ExportarConFastReport(DataTable dt, string nombreDataSet, string rutaPDF, string titulo)
        {
            try
            {
                Report reporte = new Report();
                reporte.RegisterData(dt, nombreDataSet);
                reporte.Prepare();

                PDFSimpleExport pdf = new PDFSimpleExport();
                reporte.Export(pdf, rutaPDF);

                MessageBox.Show($"✅ Reporte exportado correctamente.\n\nUbicación: {rutaPDF}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al exportar reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Crea dialogo Save con configuración estándar para reportes</summary>
        public static SaveFileDialog CrearDialogoGuardarReporte(string nombreReporte)
        {
            var dialog = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf|CSV (*.csv)|*.csv",
                FileName = $"{nombreReporte}_{DateTime.Now:yyyyMMdd_HHmmss}",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            return dialog;
        }

        /// <summary>Valida que haya datos antes de exportar</summary>
        public static bool ValidarDatosParaExportar(DataGridView dgv, string nombreReporte)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show($"No hay datos en {nombreReporte} para exportar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            int rowsVisibles = 0;
            foreach (DataGridViewRow row in dgv.Rows)
                if (row.Visible) rowsVisibles++;

            if (rowsVisibles == 0)
            {
                MessageBox.Show("Todos los registros están filtrados. No hay datos visibles para exportar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        /// <summary>Obtiene resumen estadístico del reporte</summary>
        public static string ObtenerResumenReporte(DataGridView dgv)
        {
            int totalRows = 0;
            int visibleRows = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                totalRows++;
                if (row.Visible) visibleRows++;
            }

            return $"Total: {totalRows} registros | Visibles: {visibleRows} registros";
        }

        /// <summary>Actualiza título de forma con información del reporte</summary>
        public static void ActualizarTituloFormulario(Form form, string nombreReporte, int totalRegistros)
        {
            form.Text = $"{nombreReporte} ({totalRegistros} registros)";
        }

        /// <summary>Muestra información de exportación exitosa</summary>
        public static void MostrarExitoExportacion(string nombreArchivo, string ruta)
        {
            string mensaje = $"✅ {nombreArchivo} exportado correctamente.\n\n" +
                           $"Ubicación: {ruta}\n\n" +
                           $"¿Deseas abrir el archivo?";

            if (MessageBox.Show(mensaje, "Éxito",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(ruta)
                    {
                        UseShellExecute = true
                    });
                }
                catch { }
            }
        }

        /// <summary>Aplica filtros estándar con validación</summary>
        public static void AplicarFiltroFechas(DataGridView dgv, DateTime desde, DateTime hasta, string columnaFecha)
        {
            try
            {
                if (hasta < desde)
                {
                    MessageBox.Show("La fecha 'hasta' debe ser igual o mayor que la fecha 'desde'.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ReportFilterHelper.ApplyDateFilter(dgv, desde, hasta, columnaFecha);

                int visibles = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                    if (row.Visible) visibles++;

                MessageBox.Show($"Filtro aplicado: {visibles} registros visibles",
                    "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtro: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Limpia todos los filtros aplicados</summary>
        public static void LimpiarFiltros(DataGridView dgv)
        {
            try
            {
                ReportFilterHelper.ClearDateFilter(dgv);
                MessageBox.Show($"Filtro limpiado: {dgv.Rows.Count} registros visibles",
                    "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar filtro: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
