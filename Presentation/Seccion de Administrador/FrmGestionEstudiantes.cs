using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmGestionEstudiantes : Form
    {
        // =====================================================
        // CAMPOS PRIVADOS
        // =====================================================
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtEstudiantes;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================
        public FrmGestionEstudiantes()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ConfigurarPlaceholderBusqueda();
            CargarNivelesEnComboBox();
            CargarEstudiantes();
            ActualizarContadoresNiveles();
        }

        // =====================================================
        // CONFIGURACIÓN INICIAL
        // =====================================================

        private void ConfigurarDataGridView()
        {
            dgvEstudiantes.BackgroundColor = Color.White;
            dgvEstudiantes.BorderStyle = BorderStyle.None;
            dgvEstudiantes.RowHeadersVisible = false;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstudiantes.RowTemplate.Height = 25;
            dgvEstudiantes.ColumnHeadersHeight = 20;
            dgvEstudiantes.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvEstudiantes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvEstudiantes.EnableHeadersVisualStyles = false;
            dgvEstudiantes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 70, 229);
            dgvEstudiantes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void ConfigurarPlaceholderBusqueda()
        {
            txtBuscar.Text = "Buscar estudiante por nombre, email o nivel...";
            txtBuscar.ForeColor = Color.Gray;
        }

        private void CargarNivelesEnComboBox()
        {
            cmbFiltroNivel.Items.Clear();
            cmbFiltroNivel.Items.Add("Todos los niveles");
            cmbFiltroNivel.Items.Add("A1");
            cmbFiltroNivel.Items.Add("A2");
            cmbFiltroNivel.Items.Add("B1");
            cmbFiltroNivel.Items.Add("B2");
            cmbFiltroNivel.Items.Add("C1");
            cmbFiltroNivel.Items.Add("C2");
            cmbFiltroNivel.SelectedIndex = 0;
        }

        // =====================================================
        // CARGA DE DATOS
        // =====================================================

        private void CargarEstudiantes()
        {
            try
            {
                dtEstudiantes = db.ObtenerEstudiantes();
                dgvEstudiantes.DataSource = dtEstudiantes;

                if (dgvEstudiantes.Columns["ID"] != null)
                    dgvEstudiantes.Columns["ID"].Visible = false;

                ActualizarContadoresNiveles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estudiantes: " + ex.Message);
            }
        }

        private void ActualizarContadoresNiveles()
        {
            try
            {
                Dictionary<string, int> conteo = db.ObtenerConteoPorNivel();

                lblA1.Text = conteo.ContainsKey("A1") ? conteo["A1"].ToString() : "0";
                lblA2.Text = conteo.ContainsKey("A2") ? conteo["A2"].ToString() : "0";
                lblB1.Text = conteo.ContainsKey("B1") ? conteo["B1"].ToString() : "0";
                lblB2.Text = conteo.ContainsKey("B2") ? conteo["B2"].ToString() : "0";
                lblC1.Text = conteo.ContainsKey("C1") ? conteo["C1"].ToString() : "0";
                lblC2.Text = conteo.ContainsKey("C2") ? conteo["C2"].ToString() : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar contadores: " + ex.Message);
            }
        }

        // =====================================================
        // EVENTOS DEL TEXTBOX DE BÚSQUEDA
        // =====================================================

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar estudiante por nombre, email o nivel..." || txtBuscar.ForeColor == Color.Gray)
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar estudiante por nombre, email o nivel...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "Buscar estudiante por nombre, email o nivel..." && txtBuscar.ForeColor == Color.Black)
            {
                string busqueda = txtBuscar.Text.Trim();

                if (busqueda == "")
                {
                    CargarEstudiantes();
                }
                else
                {
                    try
                    {
                        dtEstudiantes = db.BuscarEstudiantes(busqueda);
                        dgvEstudiantes.DataSource = dtEstudiantes;

                        if (dgvEstudiantes.Columns["ID"] != null)
                            dgvEstudiantes.Columns["ID"].Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar: " + ex.Message);
                    }
                }
            }
        }

        // =====================================================
        // EVENTOS DEL COMBOBOX DE NIVEL
        // =====================================================

        private void cmbFiltroNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbFiltroNivel.SelectedItem.ToString();

            if (seleccion == "Todos los niveles")
            {
                CargarEstudiantes();
            }
            else
            {
                try
                {
                    dtEstudiantes = db.FiltrarEstudiantesPorNivel(seleccion);
                    dgvEstudiantes.DataSource = dtEstudiantes;

                    if (dgvEstudiantes.Columns["ID"] != null)
                        dgvEstudiantes.Columns["ID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al filtrar por nivel: " + ex.Message);
                }
            }
        }

        // =====================================================
        // EVENTOS DE BOTONES
        // =====================================================

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmNuevoEstudiante frmnuevoestudiante = new FrmNuevoEstudiante();
            frmnuevoestudiante.StartPosition = FormStartPosition.CenterParent;
            frmnuevoestudiante.ShowDialog();

            CargarEstudiantes();
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Código para cuando hacen clic en algún estudiante
            if (e.RowIndex >= 0)
            {
                int idEstudiante = Convert.ToInt32(dgvEstudiantes.Rows[e.RowIndex].Cells["ID"].Value);
                string nombre = dgvEstudiantes.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();

                MessageBox.Show($"Estudiante seleccionado: {nombre}");
            }
        }

        // =====================================================
        // NOTA: Eliminé el evento duplicado cmbFiltroNivel_SelectedIndexChanged_1
        // =====================================================
    }
}