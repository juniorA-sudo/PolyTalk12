using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using FastReport;
using FastReport.Export.PdfSimple;

namespace Presentation
{
    public partial class ReporteMaestros : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtMaestros;

        public ReporteMaestros()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                string query = @"
                    SELECT
                        u.username,
                        u.email,
                        u.phone,
                        t.specialization,
                        t.hire_date,
                        COUNT(DISTINCT g.group_id) AS grupos_asignados,
                        CASE WHEN u.is_active = 1 THEN 'Activo' ELSE 'Inactivo' END AS estado
                    FROM users u
                    LEFT JOIN teachers t ON u.user_id = t.user_id
                    LEFT JOIN groups g ON t.teacher_id = g.teacher_id
                    WHERE u.role = 'maestro'
                    GROUP BY u.user_id, u.username, u.email, u.phone, t.specialization, t.hire_date, u.is_active
                    ORDER BY u.username";

                using (SqlConnection conn = new SqlConnection(db.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtMaestros = new DataTable();
                    da.Fill(dtMaestros);
                }

                dgvMaestros.DataSource = dtMaestros;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Reporte_Maestros_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Report reporte = new Report();
                    string rutaReporte = FindReportFile("ReporteMaestros.frx");

                    if (string.IsNullOrEmpty(rutaReporte))
                    {
                        MessageBox.Show("No se encontró el archivo de reporte.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    reporte.Load(rutaReporte);
                    reporte.RegisterData(dtMaestros, "teachers");
                    reporte.Prepare();

                    PDFSimpleExport pdf = new PDFSimpleExport();
                    reporte.Export(pdf, save.FileName);

                    MessageBox.Show("Reporte exportado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FindReportFile(string nombreArchivo)
        {
            string[] posiblesPaths = new string[]
            {
                System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreArchivo),
                System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", nombreArchivo),
                System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PolyTalk", nombreArchivo)
            };

            foreach (string path in posiblesPaths)
            {
                if (System.IO.File.Exists(path))
                    return path;
            }

            return null;
        }
    }
}
