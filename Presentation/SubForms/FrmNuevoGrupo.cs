using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient; // Asegúrate de tener esta referencia

namespace Presentation
{
    public partial class FrmNuevoGrupo : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int? maestroSeleccionadoId = null;
        private string maestroSeleccionadoNombre = "";

        public FrmNuevoGrupo()
        {
            InitializeComponent();
            ConfigurarFormulario();
            ConfigurarPlaceholders();
            CargarNiveles();
            CargarMaestrosTop5();
        }

        private void ConfigurarPlaceholders()
        {
            // Placeholders ya están en el diseñador, solo aseguramos color inicial
            txtNombre.ForeColor = Color.Gray;
            txtCapacidad.ForeColor = Color.Gray;
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Nuevo Grupo";
            this.Size = new Size(450, 489);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void CargarNiveles()
        {
            cmbNivel.Items.Clear();
            cmbNivel.Items.Add("A1");
            cmbNivel.Items.Add("A2");
            cmbNivel.Items.Add("B1");
            cmbNivel.Items.Add("B2");
            cmbNivel.Items.Add("C1");
            cmbNivel.Items.Add("C2");
            cmbNivel.SelectedIndex = 0;
        }

        private void CargarMaestrosTop5()
        {
            string query = @"
                SELECT TOP 5 t.teacher_id, u.username, u.email
                FROM teachers t
                INNER JOIN users u ON t.user_id = u.user_id
                WHERE u.is_active = 1
                ORDER BY u.username";
            CargarMaestros(query);
        }

        private void CargarMaestrosBusqueda(string filtro)
        {
            string query = @"
                SELECT TOP 10 t.teacher_id, u.username, u.email
                FROM teachers t
                INNER JOIN users u ON t.user_id = u.user_id
                WHERE u.is_active = 1 AND u.username LIKE @filtro
                ORDER BY u.username";
            using (SqlConnection conn = new SqlConnection(db.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                LlenarDataGridView(dt);
            }
        }

        private void CargarMaestros(string query, string filtro = null)
        {
            using (SqlConnection conn = new SqlConnection(db.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (filtro != null)
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                LlenarDataGridView(dt);
            }
        }

        private void LlenarDataGridView(DataTable dt)
        {
            dgvMaestros.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["teacher_id"]);
                string nombre = row["username"].ToString();
                string email = row["email"].ToString();
                dgvMaestros.Rows.Add(id, nombre, email);
            }
        }

        private void txtBuscarMaestro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarMaestro.Text.Trim();
            if (filtro.Length >= 2)
            {
                CargarMaestrosBusqueda(filtro);
            }
            else if (filtro.Length == 0)
            {
                CargarMaestrosTop5();
            }
        }

        private void dgvMaestros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMaestros.Rows[e.RowIndex];
                maestroSeleccionadoId = Convert.ToInt32(row.Cells["colId"].Value);
                maestroSeleccionadoNombre = row.Cells["colNombre"].Value.ToString();
                // Resaltar la fila seleccionada
                foreach (DataGridViewRow r in dgvMaestros.Rows)
                    r.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.BackColor = Color.FromArgb(230, 240, 255);
            }
        }

        private bool ValidarCampos()
        {
            if (txtNombre.Text == "Ej: Grupo D" || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa el nombre del grupo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (cmbNivel.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un nivel.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNivel.Focus();
                return false;
            }

            if (txtCapacidad.Text == "Ej: 20" || string.IsNullOrWhiteSpace(txtCapacidad.Text))
            {
                MessageBox.Show("Ingresa la capacidad máxima.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCapacidad.Focus();
                return false;
            }

            if (!int.TryParse(txtCapacidad.Text, out int cap) || cap <= 0)
            {
                MessageBox.Show("Capacidad debe ser un número positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCapacidad.Focus();
                return false;
            }

            if (maestroSeleccionadoId == null)
            {
                MessageBox.Show("Selecciona un maestro de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidarNombreUnico(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Ya existe un grupo con ese nombre.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                string nombre = txtNombre.Text.Trim();
                string nivel = cmbNivel.SelectedItem.ToString();
                int capacidad = int.Parse(txtCapacidad.Text);
                int nuevoId = db.InsertarGrupo(nombre, nivel, maestroSeleccionadoId, capacidad, "", "");

                if (nuevoId > 0)
                {
                    MessageBox.Show("Grupo creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el grupo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Placeholders
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Ej: Grupo D")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Ej: Grupo D";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtCapacidad_Enter(object sender, EventArgs e)
        {
            if (txtCapacidad.Text == "Ej: 20")
            {
                txtCapacidad.Text = "";
                txtCapacidad.ForeColor = Color.Black;
            }
        }

        private void txtCapacidad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCapacidad.Text))
            {
                txtCapacidad.Text = "Ej: 20";
                txtCapacidad.ForeColor = Color.Gray;
            }
        }

        private bool ValidarNombreUnico(string nombre)
        {
            string query = "SELECT COUNT(*) FROM groups WHERE group_name = @nombre";
            using (SqlConnection conn = new SqlConnection(db.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count == 0;
            }
        }
    }
}