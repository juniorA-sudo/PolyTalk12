using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FastReport;
using FastReport.Export.PdfSimple;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmReporteUnidadesPorNivel : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable niveles;

        public FrmReporteUnidadesPorNivel()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            CargarNiveles();
            ConfigurarEventos();
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
                    foreach (DataRow row in niveles.Rows)
                    {
                        string nivelNombre = row["level_name"].ToString();
                        cmbNivel.Items.Add(nivelNombre);
                    }

                    // Seleccionar el primer nivel por defecto
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

        private void CargarUnidadesPorNivel(string nivelNombre)
        {
            try
            {
                // Obtener el ID del nivel seleccionado
                int nivelId = -1;
                foreach (DataRow row in niveles.Rows)
                {
                    if (row["level_name"].ToString() == nivelNombre)
                    {
                        nivelId = Convert.ToInt32(row["level_id"]);
                        break;
                    }
                }

                if (nivelId == -1) return;

                // Limpiar filas actuales
                dgvUnidades.Rows.Clear();

                // Obtener unidades del nivel seleccionado
                DataTable unidades = dbHelper.ObtenerUnidadesPorNivel(nivelId);

                if (unidades.Rows.Count > 0)
                {
                    foreach (DataRow row in unidades.Rows)
                    {
                        string unitNumber = row["unit_number"].ToString();
                        string unitTitle = row["unit_title"].ToString();
                        string unitDescription = row["unit_description"].ToString();

                        // Formatear el número de unidad
                        string unidadFormateada = $"{unitNumber}. {unitTitle}";

                        // Obtener lecciones de esta unidad
                        int unitId = Convert.ToInt32(row["unit_id"]);
                        DataTable lecciones = dbHelper.ObtenerLeccionesPorUnidad(unitId);

                        int totalLecciones = lecciones.Rows.Count;
                        int duracionTotal = 0;

                        foreach (DataRow lecRow in lecciones.Rows)
                        {
                            duracionTotal += Convert.ToInt32(lecRow["duration_minutes"]);
                        }

                        // Formatear duración
                        string duracion = duracionTotal > 0 ? $"{duracionTotal} min" : "N/A";

                        // Obtener cupo (puedes ajustar según tu lógica de negocio)
                        int cupo = 30; // Valor por defecto, puedes modificarlo

                        dgvUnidades.Rows.Add(
                            unidadFormateada,
                            unitDescription.Length > 30 ? unitDescription.Substring(0, 27) + "..." : unitDescription,
                            totalLecciones,
                            duracion,
                            cupo.ToString()
                        );
                    }
                }
                else
                {
                    dgvUnidades.Rows.Add("No hay unidades", "No disponible", "0", "0 min", "0");
                }

                // Actualizar contador de unidades
                this.Text = $"Reporte: Unidades por Nivel - {nivelNombre} ({unidades.Rows.Count} unidades)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar unidades: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedItem != null)
            {
                string nivelSeleccionado = cmbNivel.SelectedItem.ToString();
                CargarUnidadesPorNivel(nivelSeleccionado);
            }
        }

        private void ActualizarInfoHeader()
        {
            // Actualizar fecha actual
            lblFecha.Text = DateTime.Now.ToString("dd MMMM, yyyy");

            // Puedes cargar información del usuario desde donde la tengas almacenada
            // Por ejemplo:
            // lblUsuario.Text = SesionActual.UsuarioNombre;
            // lblEmail.Text = SesionActual.UsuarioEmail;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUnidades.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para imprimir.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = $"ReporteUnidadesPorNivel_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Report reporte = new Report();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Unidad");
                    dt.Columns.Add("Descripción");
                    dt.Columns.Add("Lecciones");
                    dt.Columns.Add("Duración");
                    dt.Columns.Add("Cupo");

                    foreach (DataGridViewRow row in dgvUnidades.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            dt.Rows.Add(
                                row.Cells[0].Value,
                                row.Cells[1].Value,
                                row.Cells[2].Value,
                                row.Cells[3].Value,
                                row.Cells[4].Value
                            );
                        }
                    }

                    reporte.RegisterData(dt, "unidades");
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