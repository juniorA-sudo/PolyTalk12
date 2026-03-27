using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentation
{
    public partial class FrmLogin : Form
    {
        private readonly string cadenaConexion = ConfigurationHelper.GetConnectionString();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e) { }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.DimGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e) { }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!ValidarCredenciales())
                return;

            string nombreUsuario = txtUsuario.Text.Trim();
            string contrasenia = txtContrasena.Text.Trim();

            AutenticarUsuario(nombreUsuario, contrasenia);
        }

        /// <summary>Valida que los campos de login no estén vacíos</summary>
        private bool ValidarCredenciales()
        {
            var errores = new System.Collections.Generic.List<string>();

            // Validar usuario
            string usuario = txtUsuario.Text.Trim();
            if (usuario == "USUARIO" || string.IsNullOrWhiteSpace(usuario))
                errores.Add("Ingresa tu nombre de usuario.");
            else if (usuario.Length < 3)
                errores.Add("El nombre de usuario debe tener al menos 3 caracteres.");
            else if (usuario.Length > 50)
                errores.Add("El nombre de usuario no puede exceder 50 caracteres.");

            // Validar contraseña
            string contrasena = txtContrasena.Text.Trim();
            if (contrasena == "CONTRASEÑA" || string.IsNullOrWhiteSpace(contrasena))
                errores.Add("Ingresa tu contraseña.");
            else if (contrasena.Length < 6)
                errores.Add("La contraseña debe tener al menos 6 caracteres.");

            // Mostrar errores si hay
            if (errores.Count > 0)
            {
                FormValidator.MostrarErrores(errores);
                return false;
            }

            return true;
        }

        /// <summary>Autentica el usuario contra la base de datos</summary>
        private void AutenticarUsuario(string nombreUsuario, string contrasenia)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT user_id, user_role, username, is_active FROM users WHERE username = @nombreusuario AND password = @contrasenia";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombreusuario", nombreUsuario);
                        comando.Parameters.AddWithValue("@contrasenia", contrasenia);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = Convert.ToInt32(reader["user_id"]);
                                string rol = reader["user_role"].ToString().ToUpper();
                                string username = reader["username"].ToString();
                                int isActive = Convert.ToInt32(reader["is_active"]);

                                // Verificar que el usuario está activo
                                if (isActive == 0)
                                {
                                    FormValidator.MostrarError("Esta cuenta está desactivada.\n\nContacta al administrador para reactivarla.");
                                    return;
                                }

                                // Login exitoso
                                this.Hide();
                                FrmPrincipal frmPrincipal = new FrmPrincipal(rol, username, userId);
                                frmPrincipal.Show();
                            }
                            else
                            {
                                FormValidator.MostrarError("❌ Usuario o contraseña incorrectos.\n\nVerifica que escribiste correctamente tus credenciales.");
                                txtContrasena.Clear();
                                txtContrasena.Text = "CONTRASEÑA";
                                txtContrasena.ForeColor = Color.DimGray;
                                txtContrasena.UseSystemPasswordChar = false;
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    FormValidator.MostrarError(
                        $"❌ Error de conexión a la base de datos.\n\n{sqlEx.Message}\n\n" +
                        "Verifica que:\n" +
                        "1. SQL Server está ejecutándose\n" +
                        "2. La base de datos 'PruebaPolyTalk' existe\n" +
                        "3. La conexión está configurada correctamente");
                }
                catch (Exception ex)
                {
                    FormValidator.MostrarError($"❌ Error inesperado: {ex.Message}");
                }
            }
        }
    }
}