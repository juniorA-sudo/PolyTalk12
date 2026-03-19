using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmGestionEstudiantes : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtEstudiantes;

        public FrmGestionEstudiantes()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ConfigurarPlaceholderBusqueda();
            CargarNivelesEnComboBox();
            CargarEstudiantes();
            dgvEstudiantes.DataBindingComplete += DgvEstudiantes_DataBindingComplete;
            ActualizarContadoresNiveles();
        }

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
            cmbFiltroNivel.Items.AddRange(new[] { "A1", "A2", "B1", "B2", "C1", "C2" });
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
        // CONFIGURAR COLUMNAS DEL DGV
        // =====================================================
        private void DgvEstudiantes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                // Ocultar columnas técnicas
                string[] ocultas = { "ID" };
                foreach (string col in ocultas)
                    if (dgvEstudiantes.Columns[col] != null)
                        dgvEstudiantes.Columns[col].Visible = false;

                // ✅ Columnas visibles con headers amigables
                ConfigCol("Usuario", "👤 Usuario", 150);
                ConfigCol("Email", "📧 Email", 200);
                ConfigCol("Teléfono", "📱 Teléfono", 120);
                ConfigCol("Nivel", "🎓 Nivel", 70);
                ConfigCol("Fecha Ingreso", "📅 Fecha Ingreso", 120);
            }
            catch { }
        }

        private void ConfigCol(string nombre, string header, int width)
        {
            if (dgvEstudiantes.Columns[nombre] != null)
            {
                dgvEstudiantes.Columns[nombre].Visible = true;
                dgvEstudiantes.Columns[nombre].HeaderText = header;
                dgvEstudiantes.Columns[nombre].Width = width;
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
                txtBuscar.Text = "Buscar estudiante por nombre, email o nivel...";
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
                    dtEstudiantes = string.IsNullOrEmpty(busqueda)
                        ? db.ObtenerEstudiantes()
                        : db.BuscarEstudiantes(busqueda);
                    dgvEstudiantes.DataSource = dtEstudiantes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
            }
        }

        // =====================================================
        // FILTRO POR NIVEL
        // =====================================================
        private void cmbFiltroNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbFiltroNivel.SelectedItem.ToString();
            try
            {
                dtEstudiantes = seleccion == "Todos los niveles"
                    ? db.ObtenerEstudiantes()
                    : db.FiltrarEstudiantesPorNivel(seleccion);
                dgvEstudiantes.DataSource = dtEstudiantes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message);
            }
        }

        // =====================================================
        // BOTÓN NUEVO ESTUDIANTE
        // =====================================================
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmNuevoEstudiante frm = new FrmNuevoEstudiante();
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarEstudiantes();
                ActualizarContadoresNiveles();
                txtBuscar.Text = "Buscar estudiante por nombre, email o nivel...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Reservado para futuras acciones al seleccionar un estudiante
        }
    }
}