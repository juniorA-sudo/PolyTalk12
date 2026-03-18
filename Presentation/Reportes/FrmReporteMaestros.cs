using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

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
    }
}