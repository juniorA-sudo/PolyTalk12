using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FastReport;
using FastReport.Export.PdfSimple;

namespace Presentation
{
    public partial class FrmReporteEstudiantesPorNivel : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable niveles;

        public FrmReporteEstudiantesPorNivel()
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

        private void CargarEstudiantesPorNivel(string nivelSeleccionado)
        {
            try
            {
                dgvEstudiantes.Rows.Clear();
                DataTable estudiantes;

                if (nivelSeleccionado == "Todos los niveles")
                {
                    estudiantes = dbHelper.ObtenerEstudiantesConDetalle(null);
                }
                else
                {
                    // Buscar el código del nivel seleccionado
                    string nivelCodigo = ObtenerCodigoNivel(nivelSeleccionado);
                    estudiantes = dbHelper.ObtenerEstudiantesConDetalle(nivelCodigo);
                }

                if (estudiantes.Rows.Count > 0)
                {
                    foreach (DataRow row in estudiantes.Rows)
                    {
                        string nombre = row["Nombre"].ToString();
                        string nivel = row["Nivel"].ToString();
                        string fechaIngreso = Convert.ToDateTime(row["FechaIngreso"]).ToString("dd/MM/yyyy");
                        string grupo = row["Grupo"] == DBNull.Value ? "Sin grupo" : row["Grupo"].ToString();
                        string maestro = row["Maestro"] == DBNull.Value ? "Sin asignar" : row["Maestro"].ToString();

                        // Obtener progreso y calificación reales de la base de datos
                        string progreso = "0%";
                        string calificacion = "0";

                        if (row.Table.Columns.Contains("Progreso") && row["Progreso"] != DBNull.Value)
                            progreso = row["Progreso"].ToString();
                        if (row.Table.Columns.Contains("Calificacion") && row["Calificacion"] != DBNull.Value)
                            calificacion = row["Calificacion"].ToString();

                        if (nombre.Length > 15)
                            nombre = nombre.Substring(0, 12) + "...";

                        dgvEstudiantes.Rows.Add(nombre, nivel, progreso, calificacion, fechaIngreso, grupo, maestro);
                    }
                }
                else
                {
                    dgvEstudiantes.Rows.Add("No hay estudiantes", nivelSeleccionado, "0%", "0", "N/A", "N/A", "N/A");
                }

                this.Text = $"Reporte: Estudiantes por Nivel - {nivelSeleccionado} ({dgvEstudiantes.Rows.Count} estudiantes)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}", "Error",
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

        private string ObtenerGrupoEstudiante(int studentId)
        {
            try
            {
                string[] grupos = { "A1-01", "A2-01", "B1-01", "B2-01", "C1-01" };
                Random rand = new Random();
                return grupos[rand.Next(grupos.Length)];
            }
            catch
            {
                return "N/A";
            }
        }

        private string ObtenerMaestroDelGrupo(string grupo)
        {
            try
            {
                string[] maestros = { "Laura Gómez", "Roberto Díaz", "Carolina Silva", "Pedro Méndez", "Ana Torres" };
                Random rand = new Random();
                return maestros[rand.Next(maestros.Length)];
            }
            catch
            {
                return "N/A";
            }
        }

        private string CalcularProgresoAleatorio()
        {
            Random rand = new Random();
            int progreso = rand.Next(40, 101);
            return $"{progreso}%";
        }

        private string CalcularCalificacionAleatoria()
        {
            Random rand = new Random();
            double calificacion = rand.Next(50, 101) / 10.0;
            return calificacion.ToString("0.0");
        }

        private void CmbNivel_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbNivel.SelectedItem != null)
            {
                string nivelSeleccionado = cmbNivel.SelectedItem.ToString() ?? "";
                CargarEstudiantesPorNivel(nivelSeleccionado);
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

                ReportFilterHelper.ApplyDateFilter(dgvEstudiantes, dtpFechaDesde.Value, dtpFechaHasta.Value, "FechaIngreso");
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
                if (dgvEstudiantes.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para imprimir.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = $"ReporteEstudiantesPorNivel_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Report reporte = new Report();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Nivel");
                    dt.Columns.Add("Progreso");
                    dt.Columns.Add("Calificación");
                    dt.Columns.Add("Fecha Ingreso");
                    dt.Columns.Add("Grupo");
                    dt.Columns.Add("Maestro");

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
                                row.Cells[6].Value
                            );
                        }
                    }

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