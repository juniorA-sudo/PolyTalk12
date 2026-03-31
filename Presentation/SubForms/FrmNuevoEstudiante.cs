using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentation
{
    public partial class FrmNuevoEstudiante : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtGrupos;
        private int? grupoSeleccionadoId = null;

        public FrmNuevoEstudiante()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarNiveles();
            CargarGrupos();
        }

        private void CargarNiveles()
        {
            cmbNivel.Items.Clear();
            cmbNivel.Items.AddRange(new[] { "A1", "A2", "B1", "B2", "C1", "C2" });
            cmbNivel.SelectedIndex = 0;
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Nuevo Estudiante";
            this.Size = new Size(450, 460);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtGrupos = new DataTable();
                    da.Fill(dtGrupos);
                }

                dgvGrupos.Rows.Clear();
                foreach (DataRow row in dtGrupos.Rows)
                {
                    dgvGrupos.Rows.Add(
                        Convert.ToInt32(row["group_id"]),
                        row["group_name"].ToString(),
                        row["english_level"].ToString(),
                        Convert.ToInt32(row["CupoDisponible"])
                    );
                }

                if (dgvGrupos.Rows.Count > 0)
                {
                    dgvGrupos.Rows[0].Selected = true;
                    grupoSeleccionadoId = Convert.ToInt32(dgvGrupos.Rows[0].Cells["colId"].Value);
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
                grupoSeleccionadoId = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells["colId"].Value);
        }

        // =====================================================
        // PLACEHOLDERS - NOMBRE
        // =====================================================
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.ForeColor == Color.Gray)
            { txtNombre.Text = ""; txtNombre.ForeColor = Color.Black; }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { txtNombre.Text = "Ej: Juan"; txtNombre.ForeColor = Color.Gray; }
        }

        // APELLIDO
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.ForeColor == Color.Gray)
            { txtApellido.Text = ""; txtApellido.ForeColor = Color.Black; }
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            { txtApellido.Text = "Ej: Pérez"; txtApellido.ForeColor = Color.Gray; }
        }

        // EMAIL
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.ForeColor == Color.Gray)
            { txtEmail.Text = ""; txtEmail.ForeColor = Color.Black; }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            { txtEmail.Text = "estudiante@polytalk.com"; txtEmail.ForeColor = Color.Gray; }
        }

        // TELÉFONO
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.ForeColor == Color.Gray)
            { txtTelefono.Text = ""; txtTelefono.ForeColor = Color.Black; }
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            { txtTelefono.Text = "809-123-4567"; txtTelefono.ForeColor = Color.Gray; }
        }

        // CONTRASEÑA
        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.ForeColor == Color.Gray)
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }
        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.Text = "Mínimo 6 caracteres";
                txtContrasena.ForeColor = Color.Gray;
            }
        }

        // CONFIRMAR
        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            if (txtConfirmar.ForeColor == Color.Gray)
            {
                txtConfirmar.Text = "";
                txtConfirmar.ForeColor = Color.Black;
                txtConfirmar.UseSystemPasswordChar = true;
            }
        }
        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmar.Text))
            {
                txtConfirmar.UseSystemPasswordChar = false;
                txtConfirmar.Text = "Repetir contraseña";
                txtConfirmar.ForeColor = Color.Gray;
            }
        }

        // =====================================================
        // VALIDACIÓN
        // =====================================================
        private bool ValidarCampos()
        {
            // Nombre
            if (txtNombre.ForeColor == Color.Gray || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MostrarError("El nombre es requerido.", txtNombre); return false;
            }
            if (!Regex.IsMatch(txtNombre.Text.Trim(), @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MostrarError("El nombre solo puede contener letras.", txtNombre); return false;
            }

            // Apellido
            if (txtApellido.ForeColor == Color.Gray || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MostrarError("El apellido es requerido.", txtApellido); return false;
            }
            if (!Regex.IsMatch(txtApellido.Text.Trim(), @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MostrarError("El apellido solo puede contener letras.", txtApellido); return false;
            }

            // Email
            if (txtEmail.ForeColor == Color.Gray || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MostrarError("El email es requerido.", txtEmail); return false;
            }
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MostrarError("Ingresa un email válido (ej: juan@polytalk.com).", txtEmail); return false;
            }

            // Teléfono — opcional, solo República Dominicana
            if (txtTelefono.ForeColor != Color.Gray && !string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                if (!PhoneHelper.EsTelefonoDominicanoValido(txtTelefono.Text))
                {
                    MostrarError(
                        "Ingresa un número dominicano válido.\n" +
                        "Ejemplos: 809-123-4567 | 829-123-4567 | 849-123-4567",
                        txtTelefono);
                    return false;
                }
                // Formatear el teléfono
                txtTelefono.Text = PhoneHelper.FormatearTelefonoDominicano(txtTelefono.Text);
            }

            // Nivel
            if (cmbNivel.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un nivel MCER.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNivel.Focus();
                return false;
            }

            // Grupo
            if (grupoSeleccionadoId == null)
            {
                MessageBox.Show("Selecciona un grupo de la lista.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Contraseña
            if (txtContrasena.ForeColor == Color.Gray || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MostrarError("La contraseña es requerida.", txtContrasena); return false;
            }
            if (txtContrasena.Text.Length < 6)
            {
                MostrarError("La contraseña debe tener al menos 6 caracteres.", txtContrasena); return false;
            }
            if (!Regex.IsMatch(txtContrasena.Text, @"^(?=.*[a-zA-Z])(?=.*\d).+$"))
            {
                MostrarError("La contraseña debe tener al menos una letra y un número.", txtContrasena); return false;
            }

            // Confirmar
            if (txtConfirmar.ForeColor == Color.Gray || txtConfirmar.Text != txtContrasena.Text)
            {
                MostrarError("Las contraseñas no coinciden.", txtConfirmar); return false;
            }

            return true;
        }

        private void MostrarError(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        // =====================================================
        // GUARDAR
        // =====================================================
        private void GuardarEstudiante()
        {
            using (SqlConnection conn = new SqlConnection(db.ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string nombre = CapitalizeWords(txtNombre.Text.Trim());
                    string apellido = CapitalizeWords(txtApellido.Text.Trim());
                    string email = txtEmail.Text.Trim().ToLower();
                    string telefono = "";

                    // Formatear teléfono si existe
                    if (txtTelefono.ForeColor != Color.Gray && !string.IsNullOrWhiteSpace(txtTelefono.Text))
                    {
                        telefono = PhoneHelper.FormatearTelefonoDominicano(txtTelefono.Text) ?? "";
                    }

                    string contrasena = txtContrasena.Text;
                    string username = GenerarUsername(nombre, apellido);

                    // 1. Insertar en users
                    string queryUser = @"
                        INSERT INTO users (username, email, phone, password, role, is_active, created_at)
                        VALUES (@username, @email, @phone, @password, 'estudiante', 1, GETDATE());
                        SELECT SCOPE_IDENTITY();";

                    int userId;
                    using (SqlCommand cmd = new SqlCommand(queryUser, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", telefono);
                        cmd.Parameters.AddWithValue("@password", contrasena);
                        userId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Insertar en students
                    string studentCode = "EST" + DateTime.Now.ToString("yyMMdd") + userId;
                    string queryStudent = @"
                        INSERT INTO students (user_id, student_code, current_english_level, enrollment_date)
                        VALUES (@userId, @studentCode, @level, GETDATE());
                        SELECT SCOPE_IDENTITY();";

                    int studentId;
                    using (SqlCommand cmd = new SqlCommand(queryStudent, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@studentCode", studentCode);
                        cmd.Parameters.AddWithValue("@level", cmbNivel.SelectedItem.ToString());
                        studentId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 3. Inscribir en el grupo
                    string queryEnroll = @"
                        INSERT INTO enrollments (student_id, group_id, enrollment_date, status)
                        VALUES (@studentId, @groupId, GETDATE(), 'activo')";

                    using (SqlCommand cmd = new SqlCommand(queryEnroll, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@groupId", grupoSeleccionadoId.Value);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show(
                        $"✅ Estudiante registrado correctamente.\n\n" +
                        $"👤 Usuario: {username}\n" +
                        $"🔑 Contraseña: {contrasena}\n\n" +
                        "Comparte estos datos con el estudiante.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private string GenerarUsername(string nombre, string apellido)
        {
            string normalizado = (nombre.Split(' ')[0] + "." + apellido.Split(' ')[0])
                .ToLower()
                .Replace("á", "a").Replace("é", "e").Replace("í", "i")
                .Replace("ó", "o").Replace("ú", "u").Replace("ñ", "n");

            normalizado = Regex.Replace(normalizado, @"[^a-z0-9\.]", "");
            return normalizado.Length > 30 ? normalizado.Substring(0, 30) : normalizado;
        }

        private string CapitalizeWords(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return texto;
            var palabras = texto.ToLower().Split(' ');
            for (int i = 0; i < palabras.Length; i++)
                if (palabras[i].Length > 0)
                    palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1);
            return string.Join(" ", palabras);
        }

        // =====================================================
        // BOTONES
        // =====================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            try { GuardarEstudiante(); }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}