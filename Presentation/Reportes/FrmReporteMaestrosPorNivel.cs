using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using FastReport;
using FastReport.Export.PdfSimple;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmReporteMaestrosPorNivel : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable niveles;

        public FrmReporteMaestrosPorNivel()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            CargarNiveles();
            ConfigurarEventos();
            ActualizarInfoHeader();
        }

        private void ConfigurarEventos()
        {
            cmbNivel.SelectedIndexChanged += CmbNivel_SelectedIndexChanged;
        }

        private void CargarNiveles()
        {
            try
            {
                niveles = dbHelper.ObtenerNiveles();
                cmbNivel.Items.Clear();

                if (niveles.Rows.Count > 0)
                {
                    cmbNivel.Items.Add("Todos los niveles");

                    foreach (DataRow row in niveles.Rows)
                    {
                        string nivelNombre = row["level_name"].ToString();
                        cmbNivel.Items.Add(nivelNombre);
                    }

                    cmbNivel.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron niveles en la base de datos.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar niveles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMaestrosPorNivel(string nivelSeleccionado)
        {
            try
            {
                dgvMaestros.Rows.Clear();
                DataTable maestros;

                if (nivelSeleccionado == "Todos los niveles")
                {
                    // Usar el método existente ObtenerMaestros()
                    maestros = dbHelper.ObtenerMaestros();
                }
                else
                {
                    // Obtener el código del nivel
                    string nivelCodigo = ObtenerCodigoNivel(nivelSeleccionado);

                    // Usar el método existente FiltrarMaestrosPorNivel()
                    maestros = dbHelper.FiltrarMaestrosPorNivel(nivelCodigo);
                }

                if (maestros.Rows.Count > 0)
                {
                    foreach (DataRow row in maestros.Rows)
                    {
                        string usuario = row["Usuario"].ToString();
                        string nivel = row["Nivel"].ToString();
                        string grupos = row["Grupos"] != DBNull.Value ? row["Grupos"].ToString() : "0";
                        string fechaIngreso = row["Fecha Ingreso"] != DBNull.Value
                            ? Convert.ToDateTime(row["Fecha Ingreso"]).ToString("dd/MM/yyyy")
                            : "N/A";

                        if (usuario.Length > 18)
                            usuario = usuario.Substring(0, 15) + "...";

                        // Las columnas son: Usuario, Grupo, Maestro, FechaIngreso
                        dgvMaestros.Rows.Add(usuario, grupos, usuario, fechaIngreso);
                    }
                }
                else
                {
                    string mensaje = nivelSeleccionado == "Todos los niveles"
                        ? "No hay maestros registrados"
                        : $"No hay maestros en el nivel {nivelSeleccionado}";

                    dgvMaestros.Rows.Add(mensaje, "-", "-", "-");
                }

                this.Text = $"Reporte: Maestros por Nivel - {nivelSeleccionado} ({dgvMaestros.Rows.Count} maestros)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar maestros: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerCodigoNivel(string nivelNombre)
        {
            foreach (DataRow row in niveles.Rows)
            {
                if (row["level_name"].ToString() == nivelNombre)
                {
                    return row["level_code"].ToString();
                }
            }
            return null;
        }

        private void CmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedItem != null)
            {
                string nivelSeleccionado = cmbNivel.SelectedItem.ToString() ?? "";
                CargarMaestrosPorNivel(nivelSeleccionado);
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
                if (dgvMaestros.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para imprimir.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = $"ReporteMaestrosPorNivel_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Report reporte = new Report();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Usuario");
                    dt.Columns.Add("Grupos");
                    dt.Columns.Add("Maestro");
                    dt.Columns.Add("Fecha Ingreso");

                    foreach (DataGridViewRow row in dgvMaestros.Rows)
                    {
                        if (!row.IsNewRow && row.Visible)
                        {
                            dt.Rows.Add(
                                row.Cells[0].Value,
                                row.Cells[1].Value,
                                row.Cells[2].Value,
                                row.Cells[3].Value
                            );
                        }
                    }

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