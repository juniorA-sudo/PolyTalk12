using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FastReport;
using FastReport.Export.PdfSimple;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmReporteEstudiantes : Form
    {
        private DatabaseHelper dbHelper;

        public FrmReporteEstudiantes()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            ActualizarInfoHeader();
            CargarEstudiantes();
        }

        private void CargarEstudiantes()
        {
            try
            {
                dgvEstudiantes.Rows.Clear();
                DataTable estudiantes = dbHelper.ObtenerEstudiantesConDetalle(null);

                if (estudiantes.Rows.Count > 0)
                {
                    foreach (DataRow row in estudiantes.Rows)
                    {
                        string usuario = row["Nombre"].ToString();
                        string email = row["Email"] != DBNull.Value ? row["Email"].ToString() : "N/A";
                        string telefono = row["Telefono"] != DBNull.Value ? row["Telefono"].ToString() : "N/A";
                        string nivel = row["Nivel"].ToString();
                        string fechaIngreso = row["FechaIngreso"] != DBNull.Value
                            ? Convert.ToDateTime(row["FechaIngreso"]).ToString("dd/MM/yyyy")
                            : "N/A";
                        string grupo = row["Grupo"] != DBNull.Value ? row["Grupo"].ToString() : "Sin grupo";
                        string maestro = row["Maestro"] != DBNull.Value ? row["Maestro"].ToString() : "Sin asignar";
                        string estado = "Activo"; // Por defecto, podrías obtenerlo de la BD

                        if (usuario.Length > 12)
                            usuario = usuario.Substring(0, 10) + "...";

                        dgvEstudiantes.Rows.Add(usuario, email, telefono, nivel, fechaIngreso, grupo, maestro, estado);
                    }
                }
                else
                {
                    dgvEstudiantes.Rows.Add("No hay estudiantes registrados", "-", "-", "-", "-", "-", "-", "-");
                }

                this.Text = $"Reporte General de Estudiantes ({dgvEstudiantes.Rows.Count} registros)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}", "Error",
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

                ReportFilterHelper.ApplyDateFilter(dgvEstudiantes, dtpFechaDesde.Value, dtpFechaHasta.Value, "Fecha Ingreso");
                MessageBox.Show($"Filtro aplicado: {dgvEstudiantes.Rows.Count} registros visibles", "Filtro Aplicado",
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
                ReportFilterHelper.ClearDateFilter(dgvEstudiantes);
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
                save.FileName = $"ReporteEstudiantes_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (save.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Usuario");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Teléfono");
                    dt.Columns.Add("Nivel");
                    dt.Columns.Add("F. Ingreso");
                    dt.Columns.Add("Grupo");
                    dt.Columns.Add("Maestro");
                    dt.Columns.Add("Estado");

                    foreach (DataGridViewRow row in dgvEstudiantes.Rows)
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
                    reporte.RegisterData(dt, "estudiantes");
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