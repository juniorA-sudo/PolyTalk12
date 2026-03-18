using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

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
    }
}