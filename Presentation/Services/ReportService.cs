using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Presentation.Services
{
    /// <summary>
    /// Servicio centralizado para generación, visualización e impresión de reportes
    /// Proporciona métodos estandarizados para exportar a PDF desde cualquier DataGridView
    /// </summary>
    public class ReportService
    {
        private const string ReportsFolder = "Reportes";

        public ReportService()
        {
            EnsureReportsFolderExists();
        }

        /// <summary>Crea carpeta de reportes si no existe</summary>
        private void EnsureReportsFolderExists()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ReportsFolder);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        /// <summary>Exporta un DataGridView a PDF con estilos profesionales</summary>
        public bool ExportarAPDF(DataGridView dgv, string nombreReporte, string titulo)
        {
            try
            {
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                string rutaArchivo = GenerarRutaArchivo(nombreReporte);

                // Crear documento PDF con using para asegurar disposición correcta
                using (Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10))
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                {
                    doc.Open();

                    // Agregar encabezado
                    AgregarEncabezado(doc, titulo);

                    // Agregar tabla con datos
                    AgregarTablaAlPDF(doc, dgv);

                    // Agregar pie de página
                    AgregarPieDePagina(doc);

                    doc.Close();
                }

                // Preguntar si abrir el archivo
                if (MessageBox.Show($"✅ Reporte exportado correctamente.\n\n" +
                    $"Ubicación: {rutaArchivo}\n\n" +
                    $"¿Deseas abrir el archivo?", "Éxito",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaArchivo) { UseShellExecute = true });
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar PDF: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Agrega encabezado profesional al PDF</summary>
        private void AgregarEncabezado(Document doc, string titulo)
        {
            // Título principal
            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            var titleParagraph = new Paragraph(titulo, titleFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 5f
            };
            doc.Add(titleParagraph);

            // Fecha de generación
            var dateFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
            var dateParagraph = new Paragraph($"Generado: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", dateFont)
            {
                Alignment = Element.ALIGN_RIGHT,
                SpacingAfter = 20f
            };
            doc.Add(dateParagraph);

            // Línea separadora
            var line = new iTextSharp.text.pdf.draw.VerticalPositionMark()
            {
                Offset = -3f
            };
            var separator = new Paragraph("_", dateFont);
            separator.SpacingAfter = 15f;
            doc.Add(separator);
        }

        /// <summary>Agrega tabla con datos del DataGridView al PDF</summary>
        private void AgregarTablaAlPDF(Document doc, DataGridView dgv)
        {
            // Crear tabla con columnas del DataGridView
            PdfPTable table = new PdfPTable(dgv.Columns.Count)
            {
                WidthPercentage = 100f,
                SpacingBefore = 10f,
                SpacingAfter = 10f
            };

            // Fuentes para la tabla
            var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, BaseColor.WHITE);
            var cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

            // Encabezados
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                var headerCell = new PdfPCell(new Phrase(col.HeaderText, headerFont))
                {
                    BackgroundColor = new BaseColor(30, 90, 160),
                    Padding = 8f,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_MIDDLE
                };
                table.AddCell(headerCell);
            }

            // Datos
            bool alternateColor = false;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    var content = cell.Value?.ToString() ?? "—";
                    var pdfCell = new PdfPCell(new Phrase(content, cellFont))
                    {
                        BackgroundColor = alternateColor ? new BaseColor(240, 245, 250) : BaseColor.WHITE,
                        Padding = 6f,
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_MIDDLE
                    };
                    table.AddCell(pdfCell);
                }
                alternateColor = !alternateColor;
            }

            doc.Add(table);
        }

        /// <summary>Agrega pie de página con información de resumen</summary>
        private void AgregarPieDePagina(Document doc)
        {
            var footerFont = FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.GRAY);
            var footerParagraph = new Paragraph("PolyTalk - Sistema de Gestión de Aprendizaje de Inglés",
                footerFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingBefore = 20f
            };
            doc.Add(footerParagraph);
        }

        /// <summary>Genera ruta única para archivo PDF con timestamp</summary>
        private string GenerarRutaArchivo(string nombreReporte)
        {
            string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ReportsFolder);
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string nombreArchivo = $"{nombreReporte}_{timestamp}.pdf";
            return Path.Combine(carpeta, nombreArchivo);
        }

        /// <summary>Abre diálogo de impresión para PDF</summary>
        public bool ImprimirReporte(DataGridView dgv, string nombreReporte, string titulo)
        {
            try
            {
                string rutaPdf = GenerarRutaArchivo(nombreReporte);

                // Primero exportar a PDF temporal
                using (Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10))
                using (FileStream fs = new FileStream(rutaPdf, FileMode.Create))
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                {
                    doc.Open();
                    AgregarEncabezado(doc, titulo);
                    AgregarTablaAlPDF(doc, dgv);
                    AgregarPieDePagina(doc);
                    doc.Close();
                }

                // Abrir en lector PDF para impresión
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaPdf)
                {
                    UseShellExecute = true,
                    Verb = "print"
                });

                MessageBox.Show("Abriendo diálogo de impresión...", "Impresión",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Exporta a CSV para compatibilidad con Excel</summary>
        public bool ExportarACSV(DataGridView dgv, string nombreReporte)
        {
            try
            {
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                string rutaArchivo = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    ReportsFolder,
                    $"{nombreReporte}_{DateTime.Now:yyyyMMdd_HHmmss}.csv");

                using (var writer = File.CreateText(rutaArchivo))
                {
                    // Encabezados
                    var headers = new List<string>();
                    foreach (DataGridViewColumn col in dgv.Columns)
                        headers.Add($"\"{col.HeaderText}\"");
                    writer.WriteLine(string.Join(",", headers));

                    // Datos
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        var values = new List<string>();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string value = cell.Value?.ToString() ?? "";
                            values.Add($"\"{value}\"");
                        }
                        writer.WriteLine(string.Join(",", values));
                    }
                }

                MessageBox.Show($"✅ Reporte exportado a CSV.\n\nUbicación: {rutaArchivo}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar CSV: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Abre carpeta de reportes generados</summary>
        public void AbrirCarpetaReportes()
        {
            try
            {
                string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ReportsFolder);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaCarpeta)
                {
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir carpeta: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
