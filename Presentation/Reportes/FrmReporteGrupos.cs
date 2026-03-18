using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmReporteGrupos : Form
    {
        private DatabaseHelper dbHelper;

        public FrmReporteGrupos()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            ActualizarInfoHeader();
            CargarGrupos();
        }

        private void CargarGrupos()
        {
            try
            {
                dgvGrupos.Rows.Clear();
                DataTable grupos = dbHelper.ObtenerGruposConCupo();

                if (grupos.Rows.Count > 0)
                {
                    foreach (DataRow row in grupos.Rows)
                    {
                        string nombreGrupo = row["group_name"].ToString();
                        string codigo = row["group_code"].ToString();
                        string nivel = row["english_level"].ToString();
                        string maestro = row["Maestro"] != DBNull.Value ? row["Maestro"].ToString() : "Sin asignar";
                        string cupo = row["max_capacity"].ToString();
                        string inscritos = row["Inscritos"].ToString();
                        string disponible = row["CupoDisponible"].ToString();

                        // Acortar nombre del grupo si es muy largo
                        if (nombreGrupo.Length > 15)
                            nombreGrupo = nombreGrupo.Substring(0, 12) + "...";

                        dgvGrupos.Rows.Add(nombreGrupo, codigo, nivel, maestro, cupo, inscritos, disponible);
                    }
                }
                else
                {
                    dgvGrupos.Rows.Add("No hay grupos registrados", "-", "-", "-", "-", "-", "-");
                }

                this.Text = $"Reporte General de Grupos ({dgvGrupos.Rows.Count} registros)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar grupos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarInfoHeader()
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMMM, yyyy");
        }
    }
}