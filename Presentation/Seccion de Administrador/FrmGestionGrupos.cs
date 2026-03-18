using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmGestionGrupos : Form
    {
        // =====================================================
        // CAMPOS PRIVADOS
        // =====================================================
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtGrupos;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================
        public FrmGestionGrupos()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ConfigurarPlaceholderBusqueda();
            dgvGrupos.DataBindingComplete += DgvGrupos_DataBindingComplete;
            CargarGrupos();
            ActualizarContadoresNiveles();
        }

        // =====================================================
        // CONFIGURACIÓN INICIAL
        // =====================================================
        private void ConfigurarDataGridView()
        {
            dgvGrupos.BackgroundColor = Color.White;
            dgvGrupos.BorderStyle = BorderStyle.None;
            dgvGrupos.RowHeadersVisible = false;
            dgvGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrupos.AllowUserToAddRows = false;
            dgvGrupos.ReadOnly = true;
            dgvGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrupos.RowTemplate.Height = 25;
            dgvGrupos.ColumnHeadersHeight = 20;
            dgvGrupos.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvGrupos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvGrupos.EnableHeadersVisualStyles = false;
            dgvGrupos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 70, 229);
            dgvGrupos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void ConfigurarPlaceholderBusqueda()
        {
            txtBuscar.Text = "Buscar grupo por nombre, código, nivel o maestro...";
            txtBuscar.ForeColor = Color.Gray;
        }

        // =====================================================
        // MÉTODOS DE CARGA DE DATOS
        // =====================================================
        private void CargarGrupos()
        {
            try
            {
                if (dgvGrupos == null)
                {
                    MessageBox.Show("Error: DataGridView no inicializado");
                    return;
                }

                dtGrupos = db.ObtenerGrupos();

                if (dtGrupos == null)
                {
                    MessageBox.Show("Error: No se pudieron obtener los grupos");
                    return;
                }

                dgvGrupos.DataSource = dtGrupos;
                ActualizarContadoresNiveles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar grupos: " + ex.Message);
            }
        }

        private void ActualizarContadoresNiveles()
        {
            try
            {
                Dictionary<string, int> conteo = db.ObtenerConteoGruposPorNivel();

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
        // EVENTOS DE BÚSQUEDA (VERSIÓN ÚNICA)
        // =====================================================
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar grupo por nombre, código, nivel o maestro..." || txtBuscar.ForeColor == Color.Gray)
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar grupo por nombre, código, nivel o maestro...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "Buscar grupo por nombre, código, nivel o maestro..." && txtBuscar.ForeColor == Color.Black)
            {
                string busqueda = txtBuscar.Text.Trim();

                if (busqueda == "")
                {
                    CargarGrupos();
                }
                else
                {
                    try
                    {
                        dtGrupos = db.BuscarGrupos(busqueda);
                        dgvGrupos.DataSource = dtGrupos;

                        if (dgvGrupos.Columns["ID"] != null)
                            dgvGrupos.Columns["ID"].Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar: " + ex.Message);
                    }
                }
            }
        }

        // =====================================================
        // EVENTOS DE BOTONES PRINCIPALES (VERSIÓN ÚNICA)
        // =====================================================
        private void btnNuevoGrupo_Click(object sender, EventArgs e)
        {
            FrmNuevoGrupo frmNuevo = new FrmNuevoGrupo();
            frmNuevo.StartPosition = FormStartPosition.CenterParent;

            if (frmNuevo.ShowDialog() == DialogResult.OK)
            {
                CargarGrupos();
                ActualizarContadoresNiveles();
                txtBuscar.Text = "Buscar grupo por nombre, código, nivel o maestro...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.SelectedRows.Count > 0)
            {
                int idGrupo = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells["ID"].Value);
                string nombreGrupo = dgvGrupos.SelectedRows[0].Cells["Grupo"].Value.ToString();

                // Crear y mostrar formulario de asignación
                FrmAsignarEstudiantes frmAsignar = new FrmAsignarEstudiantes();
                frmAsignar.StartPosition = FormStartPosition.CenterParent;

                // 👇 IMPORTANTE: Recargar cuando se cierra
                if (frmAsignar.ShowDialog() == DialogResult.OK)
                {
                    CargarGrupos();  // Recargar la lista para actualizar inscritos
                    ActualizarContadoresNiveles();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un grupo primero", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVisualizarGrupo_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvGrupos.SelectedRows[0];

                int idGrupo = Convert.ToInt32(fila.Cells["ID"].Value);
                string nombreGrupo = fila.Cells["Grupo"].Value.ToString();
                string codigoGrupo = fila.Cells["Código"].Value.ToString();
                string nivel = fila.Cells["Nivel"].Value.ToString();
                string maestro = fila.Cells["Maestro"].Value.ToString();
                int cupo = Convert.ToInt32(fila.Cells["Cupo"].Value);
                int inscritos = Convert.ToInt32(fila.Cells["Inscritos"].Value);

                FrmVisualizarGrupo frmvisualizar = new FrmVisualizarGrupo(
                    idGrupo, nombreGrupo, codigoGrupo, nivel, maestro, cupo, inscritos
                );

                frmvisualizar.StartPosition = FormStartPosition.CenterParent;
                frmvisualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un grupo primero", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =====================================================
        // EVENTOS DEL DATAGRIDVIEW
        // =====================================================
        private void DgvGrupos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (dgvGrupos.Columns["ID"] != null)
                    dgvGrupos.Columns["ID"].Visible = false;

                if (dgvGrupos.Columns["Grupo"] != null)
                    dgvGrupos.Columns["Grupo"].MinimumWidth = 120;

                if (dgvGrupos.Columns["Maestro"] != null)
                    dgvGrupos.Columns["Maestro"].MinimumWidth = 100;

                if (dgvGrupos.Columns["Nivel"] != null)
                    dgvGrupos.Columns["Nivel"].MinimumWidth = 60;
            }
            catch (Exception)
            {
                // Ignorar
            }
        }
    }
}