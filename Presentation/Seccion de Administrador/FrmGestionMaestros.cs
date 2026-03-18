using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmGestionMaestros : Form
    {
        // =====================================================
        // CAMPOS PRIVADOS
        // =====================================================
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtMaestros;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================
        public FrmGestionMaestros()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ConfigurarPlaceholderBusqueda();
            CargarNivelesEnComboBox();
            CargarMaestros();
            dgvMaestros.DataBindingComplete += DgvMaestros_DataBindingComplete;
            ActualizarContadoresNiveles();
        }

        // =====================================================
        // CONFIGURACIÓN INICIAL (CON LOS MISMOS VALORES QUE GRUPOS)
        // =====================================================
        private void ConfigurarDataGridView()
        {
            dgvMaestros.BackgroundColor = Color.White;
            dgvMaestros.BorderStyle = BorderStyle.None;
            dgvMaestros.RowHeadersVisible = false;
            dgvMaestros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaestros.AllowUserToAddRows = false;
            dgvMaestros.ReadOnly = true;
            dgvMaestros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 👇 MISMOS VALORES QUE EN GRUPOS
            dgvMaestros.RowTemplate.Height = 25;        // Antes 35, ahora 25
            dgvMaestros.ColumnHeadersHeight = 20;       // Antes 40, ahora 20

            dgvMaestros.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvMaestros.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvMaestros.EnableHeadersVisualStyles = false;
            dgvMaestros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 70, 229);
            dgvMaestros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void ConfigurarPlaceholderBusqueda()
        {
            txtBuscar.Text = "Buscar maestro por nombre, email o nivel...";
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
        private void CargarMaestros()
        {
            try
            {
                if (dgvMaestros == null)
                {
                    MessageBox.Show("Error: DataGridView no inicializado");
                    return;
                }

                dtMaestros = db.ObtenerMaestros();

                if (dtMaestros == null)
                {
                    MessageBox.Show("Error: No se pudieron obtener los maestros");
                    return;
                }

                dgvMaestros.DataSource = dtMaestros;
                ActualizarContadoresNiveles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar maestros: " + ex.Message);
            }
        }

        private void ActualizarContadoresNiveles()
        {
            try
            {
                Dictionary<string, int> conteo = db.ObtenerConteoMaestrosPorNivel();

                if (lblA1 != null)
                    lblA1.Text = conteo.ContainsKey("A1") ? conteo["A1"].ToString() : "0";

                if (lblA2 != null)
                    lblA2.Text = conteo.ContainsKey("A2") ? conteo["A2"].ToString() : "0";

                if (lblB1 != null)
                    lblB1.Text = conteo.ContainsKey("B1") ? conteo["B1"].ToString() : "0";

                if (lblB2 != null)
                    lblB2.Text = conteo.ContainsKey("B2") ? conteo["B2"].ToString() : "0";

                if (lblC1 != null)
                    lblC1.Text = conteo.ContainsKey("C1") ? conteo["C1"].ToString() : "0";

                if (lblC2 != null)
                    lblC2.Text = conteo.ContainsKey("C2") ? conteo["C2"].ToString() : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar contadores: " + ex.Message);
            }
        }

        // =====================================================
        // EVENTOS DE BÚSQUEDA
        // =====================================================
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar maestro por nombre, email o nivel..." || txtBuscar.ForeColor == Color.Gray)
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar maestro por nombre, email o nivel...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "Buscar maestro por nombre, email o nivel..." && txtBuscar.ForeColor == Color.Black)
            {
                string busqueda = txtBuscar.Text.Trim();

                if (busqueda == "")
                {
                    CargarMaestros();
                }
                else
                {
                    try
                    {
                        dtMaestros = db.BuscarMaestros(busqueda);
                        dgvMaestros.DataSource = dtMaestros;
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
                CargarMaestros();
            }
            else
            {
                try
                {
                    dtMaestros = db.FiltrarMaestrosPorNivel(seleccion);
                    dgvMaestros.DataSource = dtMaestros;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al filtrar por nivel: " + ex.Message);
                }
            }
        }

        // =====================================================
        // EVENTO DATABINDINGCOMPLETE - CONFIGURA LAS COLUMNAS
        // =====================================================
        private void DgvMaestros_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvMaestros.Columns["ID"] != null)
                    dgvMaestros.Columns["ID"].Visible = false;

                if (dgvMaestros.Columns["Usuario"] != null)
                    dgvMaestros.Columns["Usuario"].HeaderText = "Maestro";

                if (dgvMaestros.Columns["Nivel"] != null)
                    dgvMaestros.Columns["Nivel"].Width = 60;

                if (dgvMaestros.Columns["Grupos"] != null)
                    dgvMaestros.Columns["Grupos"].Width = 70;

                if (dgvMaestros.Columns["Estudiantes"] != null)
                    dgvMaestros.Columns["Estudiantes"].Width = 80;

                if (dgvMaestros.Columns["Estado"] != null)
                {
                    dgvMaestros.Columns["Estado"].Width = 80;
                    dgvMaestros.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception)
            {
                // Ignorar
            }
        }

        // =====================================================
        // EVENTOS DE BOTONES
        // =====================================================
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmNuevoMaestro frmnuevomaestro = new FrmNuevoMaestro();
            frmnuevomaestro.StartPosition = FormStartPosition.CenterParent;

            if (frmnuevomaestro.ShowDialog() == DialogResult.OK)
            {
                CargarMaestros();
                ActualizarContadoresNiveles();
                txtBuscar.Text = "Buscar maestro por nombre, email o nivel...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }
    }
}