using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

namespace Presentation
{
    public partial class FrmNuevoEstudiante : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtGrupos;
        private int? grupoSeleccionadoId = null;
        private string grupoSeleccionadoNombre = "";

        public FrmNuevoEstudiante()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarNiveles();
            CargarGrupos();
            ConfigurarPlaceholders();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Nuevo Estudiante";
            this.Size = new Size(450, 558); // Ajustado para dar espacio al DataGridView
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void ConfigurarPlaceholders()
        {
            txtNombre.ForeColor = Color.Gray;
            txtEmail.ForeColor = Color.Gray;
            txtTelefono.ForeColor = Color.Gray;
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

        private void CargarGrupos()
        {
            try
            {
                string query = @"
                    SELECT g.group_id, g.group_name, g.english_level, 
                           g.max_capacity - COUNT(e.student_id) AS CupoDisponible
                    FROM groups g
                    LEFT JOIN enrollments e ON g.group_id = e.group_id AND e.status = 'activo'
                    GROUP BY g.group_id, g.group_name, g.english_level, g.max_capacity
                    HAVING g.max_capacity - COUNT(e.student_id) > 0
                    ORDER BY g.group_name";

                using (SqlConnection conn = new SqlConnection(db.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        dtGrupos = new DataTable();
                        da.Fill(dtGrupos);
                    }
                }

                dgvGrupos.Rows.Clear();
                foreach (DataRow row in dtGrupos.Rows)
                {
                    int id = Convert.ToInt32(row["group_id"]);
                    string nombre = row["group_name"].ToString();
                    string nivel = row["english_level"].ToString();
                    int cupo = Convert.ToInt32(row["CupoDisponible"]);
                    dgvGrupos.Rows.Add(id, nombre, nivel, cupo);
                }

                if (dgvGrupos.Rows.Count > 0)
                {
                    dgvGrupos.Rows[0].Selected = true;
                    SeleccionarGrupo(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar grupos: " + ex.Message);
            }
        }

        private void dgvGrupos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrupos.SelectedRows.Count > 0)
            {
                int index = dgvGrupos.SelectedRows[0].Index;
                SeleccionarGrupo(index);
            }
        }

        private void SeleccionarGrupo(int rowIndex)
        {
            DataGridViewRow row = dgvGrupos.Rows[rowIndex];
            grupoSeleccionadoId = Convert.ToInt32(row.Cells["colId"].Value);
            grupoSeleccionadoNombre = row.Cells["colNombre"].Value.ToString();
        }

        private bool ValidarCampos()
        {
            if (txtNombre.Text == "Ej: Juan Perez" || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre completo es requerido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (txtEmail.Text == "maestro@polytalk.com" || string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Ingresa un email válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (cmbNivel.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un nivel.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNivel.Focus();
                return false;
            }

            if (grupoSeleccionadoId == null)
            {
                MessageBox.Show("Selecciona un grupo de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void GuardarEstudiante()
        {
            using (SqlConnection conn = new SqlConnection(db.ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Generar username
                    string username = GenerarUsername(txtNombre.Text.Trim());

                    // Insertar en users
                    string queryUser = @"
                        INSERT INTO users (username, email, phone, password, user_role, is_active, created_at)
                        VALUES (@username, @email, @phone, 'estudiante123', 'estudiante', 1, GETDATE());
                        SELECT SCOPE_IDENTITY();";

                    int userId;
                    using (SqlCommand cmd = new SqlCommand(queryUser, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtTelefono.Text == "+1 809-123-456" ? "" : txtTelefono.Text.Trim());
                        userId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Generar código de estudiante
                    string studentCode = "EST" + DateTime.Now.ToString("yyMMdd") + userId;

                    // Insertar en students
                    string queryStudent = @"
                        INSERT INTO students (user_id, student_code, current_english_level, enrollment_date)
                        VALUES (@userId, @studentCode, @level, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(queryStudent, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@studentCode", studentCode);
                        cmd.Parameters.AddWithValue("@level", cmbNivel.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    // Asignar al grupo (inscripción)
                    string queryEnroll = @"
                        INSERT INTO enrollments (student_id, group_id, enrollment_date, status)
                        VALUES (@studentId, @groupId, GETDATE(), 'activo')";

                    using (SqlCommand cmd = new SqlCommand(queryEnroll, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@studentId", userId); // Nota: student_id = user_id en este diseño (uno a uno)
                        cmd.Parameters.AddWithValue("@groupId", grupoSeleccionadoId.Value);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private string GenerarUsername(string nombreCompleto)
        {
            string username = nombreCompleto.ToLower()
                .Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u")
                .Replace("ñ", "n").Replace(" ", "_");

            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                username = username.Replace(c.ToString(), "");

            if (username.Length > 30)
                username = username.Substring(0, 30);

            return username;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                GuardarEstudiante();
                MessageBox.Show("Estudiante guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtNombre.Text == "Ej: Juan Perez")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Ej: Juan Perez";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "maestro@polytalk.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "maestro@polytalk.com";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "+1 809-123-456")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                txtTelefono.Text = "+1 809-123-456";
                txtTelefono.ForeColor = Color.Gray;
            }
        }
    }
}