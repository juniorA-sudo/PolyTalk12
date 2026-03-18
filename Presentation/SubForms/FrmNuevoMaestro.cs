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
    public partial class FrmNuevoMaestro : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public FrmNuevoMaestro()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarNiveles();
            ConfigurarPlaceholders();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Nuevo Maestro";
            this.Size = new Size(450, 500);
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

        private void ConfigurarPlaceholders()
        {
            // Placeholder para Nombre
            txtNombre.Text = "Ej: Juan Perez";
            txtNombre.ForeColor = Color.Gray;

            // Placeholder para Email
            txtEmail.Text = "maestro@polytalk.com";
            txtEmail.ForeColor = Color.Gray;

            // Placeholder para Teléfono
            txtTelefono.Text = "+1 809-123-456";
            txtTelefono.ForeColor = Color.Gray;

            // Fecha por defecto = hoy
            dtpFechaIngreso.Value = DateTime.Now;
        }

        // =====================================================
        // EVENTOS DE PLACEHOLDERS
        // =====================================================
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

        // =====================================================
        // VALIDACIÓN
        // =====================================================
        private bool ValidarCampos()
        {
            // Validar nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text == "Ej: Juan Perez")
            {
                MessageBox.Show("El nombre completo es requerido", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            // Validar email
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                txtEmail.Text == "maestro@polytalk.com" ||
                !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Ingresa un email válido", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        // =====================================================
        // GUARDAR MAESTRO
        // =====================================================
        private void GuardarMaestro()
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string email = txtEmail.Text.Trim();
                string telefono = txtTelefono.Text;
                string nivel = cmbNivel.SelectedItem.ToString();
                DateTime fechaIngreso = dtpFechaIngreso.Value;

                // Limpiar placeholder del teléfono
                if (telefono == "+1 809-123-456")
                    telefono = "";

                // Generar username a partir del nombre
                string username = GenerarUsername(nombre);

                // Generar código de maestro
                string teacherCode = "TCH" + DateTime.Now.ToString("yyMMddHHmmss");

                // Guardar en la base de datos
                bool resultado = db.InsertarMaestro(username, email, telefono, nivel, fechaIngreso, teacherCode);

                if (resultado)
                {
                    MessageBox.Show("Maestro guardado correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerarUsername(string nombreCompleto)
        {
            string username = nombreCompleto.ToLower()
                .Replace("á", "a").Replace("é", "e").Replace("í", "i")
                .Replace("ó", "o").Replace("ú", "u").Replace("ñ", "n");

            username = username.Replace(' ', '_');

            // Eliminar caracteres especiales
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                username = username.Replace(c.ToString(), "");
            }

            if (username.Length > 30)
                username = username.Substring(0, 30);

            return username;
        }

        // =====================================================
        // EVENTOS DE BOTONES
        // =====================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GuardarMaestro();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}