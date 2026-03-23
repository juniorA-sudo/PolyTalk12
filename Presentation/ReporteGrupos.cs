using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using FastReport;
using FastReport.Export.PdfSimple;

namespace Presentation
{
    public partial class ReporteGrupos : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtGrupos;

        public ReporteGrupos()
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
                        g.group_name,
                        g.english_level,
                        u.username AS maestro,
                        g.max_capacity,
                        COUNT(e.student_id) AS estudiantes_inscritos,
                        g.max_capacity - COUNT(e.student_id) AS cupo_disponible
                    FROM groups g
                    LEFT JOIN users u ON g.teacher_id = u.user_id
                    LEFT JOIN enrollments e ON g.group_id = e.group_id AND e.status = 'activo'
                    GROUP BY g.group_id, g.group_name, g.english_level, u.username, g.max_capacity
                    ORDER BY g.group_name";

                using (SqlConnection conn = new SqlConnection(db.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtGrupos = new DataTable();
                    da.Fill(dtGrupos);
                }

                dgvGrupos.DataSource = dtGrupos;
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
                save.FileName = "Reporte_Grupos_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Report reporte = new Report();
                    string rutaReporte = FindReportFile("ReporteGrupos.frx");

                    if (string.IsNullOrEmpty(rutaReporte))
                    {
                        MessageBox.Show("No se encontró el archivo de reporte.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    reporte.Load(rutaReporte);
                    reporte.RegisterData(dtGrupos, "groups");
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
