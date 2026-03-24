using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FastReport;
using FastReport.Export.PdfSimple;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmReporteMaestros : Form
    {
        private DatabaseHelper dbHelper;

        public FrmReporteMaestros()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            ActualizarInfoHeader();
            CargarMaestros();
        }

        private void CargarMaestros()
        {
            try
            {
                dgvMaestros.Rows.Clear();
                DataTable maestros = dbHelper.ObtenerMaestros();

                if (maestros.Rows.Count > 0)
                {
                    foreach (DataRow row in maestros.Rows)
                    {
                        string usuario = row["Usuario"].ToString();
                        string email = row["Email"].ToString();
                        string telefono = row["Teléfono"].ToString();
                        string nivel = row["Nivel"].ToString();
                        string fechaIngreso = Convert.ToDateTime(row["Fecha Ingreso"]).ToString("dd/MM/yyyy");
                        string grupos = row["Grupos"].ToString();
                        string estudiantes = row["Estudiantes"].ToString();
                        string estado = row["Estado"].ToString();

                        if (usuario.Length > 12)
                            usuario = usuario.Substring(0, 10) + "...";

                        dgvMaestros.Rows.Add(usuario, email, telefono, nivel, fechaIngreso, grupos, estudiantes, estado);
                    }
                }
                else
                {
                    dgvMaestros.Rows.Add("No hay maestros registrados", "-", "-", "-", "-", "-", "-", "-");
                }

                this.Text = $"Reporte General de Maestros ({dgvMaestros.Rows.Count} registros)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar maestros: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarInfoHeader()
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMMM, yyyy");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ReportFilterHelper.ValidateDateRange(dtpFechaDesde.Value, dtpFechaHasta.Value))
                    return;

                ReportFilterHelper.ApplyDateFilter(dgvMaestros, dtpFechaDesde.Value, dtpFechaHasta.Value, "Fecha Ingreso");
                MessageBox.Show($"Filtro aplicado: {dgvMaestros.Rows.Count} registros visibles", "Filtro Aplicado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtro:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                ReportFilterHelper.ClearDateFilter(dgvMaestros);
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
                MessageBox.Show("Filtro limpiado: todos los registros visibles", "Filtro Limpiado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar filtro:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = $"ReporteMaestros_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (save.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Usuario");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Teléfono");
                    dt.Columns.Add("Nivel");
                    dt.Columns.Add("Fecha Ingreso");
                    dt.Columns.Add("Grupos");
                    dt.Columns.Add("Estudiantes");
                    dt.Columns.Add("Estado");

                    foreach (DataGridViewRow row in dgvMaestros.Rows)
                    {
                        if (!row.IsNewRow && row.Visible)
                        {
                            dt.Rows.Add(
                                row.Cells[0].Value,
                                row.Cells[1].Value,
                                row.Cells[2].Value,
                                row.Cells[3].Value,
                                row.Cells[4].Value,
                                row.Cells[5].Value,
                                row.Cells[6].Value,
                                row.Cells[7].Value
                            );
                        }
                    }

                    Report reporte = new Report();
                    reporte.RegisterData(dt, "maestros");
                    reporte.Prepare();

                    PDFSimpleExport pdf = new PDFSimpleExport();
                    reporte.Export(pdf, save.FileName);

                    MessageBox.Show($"Reporte exportado correctamente en:\n{save.FileName}", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}