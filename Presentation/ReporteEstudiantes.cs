using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using FastReport;
using FastReport.Export.PdfSimple;

namespace Presentation
{
    public partial class ReporteEstudiantes : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtEstudiantes;

        public ReporteEstudiantes()
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
                        s.current_english_level,
                        s.enrollment_date,
                        g.group_name,
                        CONCAT(t_user.username) AS maestro,
                        CASE WHEN u.is_active = 1 THEN 'Activo' ELSE 'Inactivo' END AS estado
                    FROM users u
                    LEFT JOIN students s ON u.user_id = s.user_id
                    LEFT JOIN enrollments e ON s.student_id = e.student_id AND e.status = 'activo'
                    LEFT JOIN groups g ON e.group_id = g.group_id
                    LEFT JOIN users t_user ON g.teacher_id = t_user.user_id
                    WHERE u.user_role = 'estudiante'
                    ORDER BY u.username";

                using (SqlConnection conn = new SqlConnection(db.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtEstudiantes = new DataTable();
                    da.Fill(dtEstudiantes);
                }

                dgvEstudiantes.DataSource = dtEstudiantes;
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
                save.FileName = "Reporte_Estudiantes_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Report reporte = new Report();
                    string rutaReporte = FindReportFile("ReporteEstudiantes.frx");

                    if (string.IsNullOrEmpty(rutaReporte))
                    {
                        MessageBox.Show("No se encontró el archivo de reporte.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    reporte.Load(rutaReporte);
                    reporte.RegisterData(dtEstudiantes, "students");
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
