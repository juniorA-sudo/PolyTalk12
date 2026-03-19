using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmGestionMaestros : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtMaestros;

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

        private void ConfigurarDataGridView()
        {
            dgvMaestros.BackgroundColor = Color.White;
            dgvMaestros.BorderStyle = BorderStyle.None;
            dgvMaestros.RowHeadersVisible = false;
            dgvMaestros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaestros.AllowUserToAddRows = false;
            dgvMaestros.ReadOnly = true;
            dgvMaestros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaestros.RowTemplate.Height = 25;
            dgvMaestros.ColumnHeadersHeight = 20;
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
            cmbFiltroNivel.Items.AddRange(new[] { "A1", "A2", "B1", "B2", "C1", "C2" });
            cmbFiltroNivel.SelectedIndex = 0;
        }

        private void CargarMaestros()
        {
            try
            {
                dtMaestros = db.ObtenerMaestros();
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
                if (lblA1 != null) lblA1.Text = conteo.ContainsKey("A1") ? conteo["A1"].ToString() : "0";
                if (lblA2 != null) lblA2.Text = conteo.ContainsKey("A2") ? conteo["A2"].ToString() : "0";
                if (lblB1 != null) lblB1.Text = conteo.ContainsKey("B1") ? conteo["B1"].ToString() : "0";
                if (lblB2 != null) lblB2.Text = conteo.ContainsKey("B2") ? conteo["B2"].ToString() : "0";
                if (lblC1 != null) lblC1.Text = conteo.ContainsKey("C1") ? conteo["C1"].ToString() : "0";
                if (lblC2 != null) lblC2.Text = conteo.ContainsKey("C2") ? conteo["C2"].ToString() : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar contadores: " + ex.Message);
            }
        }

        // =====================================================
        // BÚSQUEDA
        // =====================================================
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.ForeColor == Color.Gray)
            { txtBuscar.Text = ""; txtBuscar.ForeColor = Color.Black; }
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
            if (txtBuscar.ForeColor == Color.Black)
            {
                string busqueda = txtBuscar.Text.Trim();
                try
                {
                    dtMaestros = string.IsNullOrEmpty(busqueda)
                        ? db.ObtenerMaestros()
                        : db.BuscarMaestros(busqueda);
                    dgvMaestros.DataSource = dtMaestros;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
            }
        }

        private void cmbFiltroNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbFiltroNivel.SelectedItem.ToString();
            try
            {
                dtMaestros = seleccion == "Todos los niveles"
                    ? db.ObtenerMaestros()
                    : db.FiltrarMaestrosPorNivel(seleccion);
                dgvMaestros.DataSource = dtMaestros;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message);
            }
        }

        // =====================================================
        // CONFIGURAR COLUMNAS DEL DGV
        // =====================================================
        private void DgvMaestros_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                // Ocultar columnas que no se muestran
                string[] ocultas = { "ID", "Estado" };
                foreach (string col in ocultas)
                    if (dgvMaestros.Columns[col] != null)
                        dgvMaestros.Columns[col].Visible = false;

                // ✅ Columnas visibles con headers amigables
                ConfigCol("Usuario", "👤 Usuario", 130);
                ConfigCol("Email", "📧 Email", 200);
                ConfigCol("Teléfono", "📱 Teléfono", 120);
                ConfigCol("Nivel", "🎓 Nivel", 70);
                ConfigCol("Grupos", "👥 Grupos", 70);
                ConfigCol("Estudiantes", "🧑‍🎓 Estudiantes", 90);
                ConfigCol("Fecha Ingreso", "📅 Fecha Ingreso", 120);
            }
            catch { }
        }

        private void ConfigCol(string nombre, string header, int width)
        {
            if (dgvMaestros.Columns[nombre] != null)
            {
                dgvMaestros.Columns[nombre].Visible = true;
                dgvMaestros.Columns[nombre].HeaderText = header;
                dgvMaestros.Columns[nombre].Width = width;
            }
        }

        // =====================================================
        // BOTÓN NUEVO MAESTRO
        // =====================================================
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmNuevoMaestro frm = new FrmNuevoMaestro();
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarMaestros();
                ActualizarContadoresNiveles();
                txtBuscar.Text = "Buscar maestro por nombre, email o nivel...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }
    }
}