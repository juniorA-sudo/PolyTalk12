using System;
using System.Data;
using System.Windows.Forms;
using FastReport;
using FastReport.Export.PdfSimple;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmReporteGrupos : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable dtGrupos;

        public FrmReporteGrupos()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            ConfigurarGrid();
            ActualizarInfoHeader();
            CargarGrupos();
        }

        private void ConfigurarGrid()
        {
            dgvGrupos.Rows.Clear();
            dgvGrupos.Columns.Clear();
            dgvGrupos.AllowUserToAddRows = false;
            dgvGrupos.ReadOnly = true;
            dgvGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrupos.ColumnCount = 7;

            dgvGrupos.Columns[0].Name = "Grupo";
            dgvGrupos.Columns[1].Name = "Código";
            dgvGrupos.Columns[2].Name = "Nivel";
            dgvGrupos.Columns[3].Name = "Maestro";
            dgvGrupos.Columns[4].Name = "Cupo";
            dgvGrupos.Columns[5].Name = "Inscritos";
            dgvGrupos.Columns[6].Name = "Disponible";
        }

        private void CargarGrupos()
        {
            try
            {
                dgvGrupos.Rows.Clear();
                dtGrupos = dbHelper.ObtenerGruposConCupo();

                if (dtGrupos == null || dtGrupos.Rows.Count == 0)
                {
                    dgvGrupos.Rows.Add("No hay grupos registrados", "-", "-", "-", "-", "-", "-");
                    return;
                }

                foreach (DataRow row in dtGrupos.Rows)
                {
                    string nombreGrupo = ObtenerValor(row, "group_name");
                    string codigo = ObtenerValor(row, "group_code");
                    string nivel = ObtenerValor(row, "english_level");
                    string maestro = ObtenerValor(row, "teacher_name");
                    string cupo = ObtenerValor(row, "max_capacity");
                    string inscritos = ObtenerValor(row, "Inscritos");
                    string disponible = ObtenerValor(row, "CupoDisponible");

                    if (nombreGrupo.Length > 20)
                        nombreGrupo = nombreGrupo.Substring(0, 17) + "...";

                    dgvGrupos.Rows.Add(nombreGrupo, codigo, nivel, maestro, cupo, inscritos, disponible);
                }

                this.Text = $"Reporte General de Grupos ({dgvGrupos.Rows.Count} registros)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar grupos:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerValor(DataRow row, string columna, string valorDefault = "-")
        {
            try
            {
                if (!row.Table.Columns.Contains(columna))
                    return valorDefault;

                if (row[columna] == DBNull.Value)
                    return valorDefault;

                return row[columna].ToString();
            }
            catch
            {
                return valorDefault;
            }
        }

        private void ActualizarInfoHeader()
        {
            lblFecha.Text = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy");
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtGrupos == null || dtGrupos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para imprimir.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Report reporte = new Report();

                // 🔥 SOLUCIÓN: Buscar desde la carpeta del proyecto
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string[] rutasPosibles = new string[]
                {
            // Desde bin/Debug/net8.0-windows/ sube 4 niveles a la carpeta del proyecto
            System.IO.Path.Combine(baseDir, @"..\..\..\Presentation\ReporteGrupos.frx"),
            System.IO.Path.Combine(baseDir, @"..\..\..\..\Presentation\ReporteGrupos.frx"),
            // También intenta en la carpeta bin directamente
            System.IO.Path.Combine(baseDir, "ReporteGrupos.frx"),
            // Y en Reports si existe
            System.IO.Path.Combine(baseDir, "Reports", "ReporteGrupos.frx")
                };

                string rutaReporte = null;
                foreach (var ruta in rutasPosibles)
                {
                    string rutaCompleta = System.IO.Path.GetFullPath(ruta);
                    if (System.IO.File.Exists(rutaCompleta))
                    {
                        rutaReporte = rutaCompleta;
                        break;
                    }
                }

                if (string.IsNullOrEmpty(rutaReporte))
                {
                    MessageBox.Show($"No se encontró ReporteGrupos.frx\n\nEl archivo debe estar en:\nC:\\Users\\grego\\OneDrive\\Escritorio\\LoginLayeredCSharp\\Presentation\\ReporteGrupos.frx",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                reporte.Load(rutaReporte);

                // Registrar DataTable
                reporte.RegisterData(dtGrupos, "groups");

                // Habilitar DataSource
                var dataSource = reporte.GetDataSource("groups");
                if (dataSource != null)
                    dataSource.Enabled = true;

                // Conectar el DataBand
                DataBand dataBand = reporte.FindObject("Data1") as DataBand;
                if (dataBand != null)
                {
                    dataBand.DataSource = dataSource;
                }

                // Preparar reporte
                reporte.Prepare();

                // Exportar a PDF
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
                save.FileName = $"ReporteGrupos_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (save.ShowDialog() == DialogResult.OK)
                {
                    PDFSimpleExport pdf = new PDFSimpleExport();
                    reporte.Export(pdf, save.FileName);
                    MessageBox.Show($"Reporte exportado correctamente en:\n{save.FileName}", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte:\n{ex.Message}\n\n{ex.StackTrace}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
