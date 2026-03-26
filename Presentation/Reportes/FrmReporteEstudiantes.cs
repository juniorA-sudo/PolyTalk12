using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FastReport;
using FastReport.Export.PdfSimple;
using Presentation.Helpers;
using Presentation.Services;

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

        /// <summary>Exporta reporte a PDF (método mejorado)</summary>
        private void ExportarAPDF()
        {
            if (!ReportHelper.ValidarDatosParaExportar(dgvEstudiantes, "Reporte de Estudiantes"))
                return;

            ReportHelper.ExportarAPDF(dgvEstudiantes, "ReporteEstudiantes", "REPORTE GENERAL DE ESTUDIANTES");
        }

        /// <summary>Imprime reporte directamente</summary>
        private void ImprimirReporte()
        {
            if (!ReportHelper.ValidarDatosParaExportar(dgvEstudiantes, "Reporte de Estudiantes"))
                return;

            ReportHelper.Imprimir(dgvEstudiantes, "ReporteEstudiantes", "REPORTE GENERAL DE ESTUDIANTES");
        }

        /// <summary>Exporta a CSV para Excel (método mejorado)</summary>
        private void ExportarACSV()
        {
            if (!ReportHelper.ValidarDatosParaExportar(dgvEstudiantes, "Reporte de Estudiantes"))
                return;

            ReportHelper.ExportarACSV(dgvEstudiantes, "ReporteEstudiantes");
        }

        /// <summary>Abre la carpeta de reportes generados</summary>
        private void AbrirCarpetaReportes()
        {
            ReportHelper.AbrirCarpetaReportes();
        }

        // ===== MÉTODO HEREDADO (se mantiene por compatibilidad) =====
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ExportarAPDF();
        }
    }
}