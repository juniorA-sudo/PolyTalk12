using Domain;
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
        private readonly string cadenaConexion = @"Data Source=JUNIOR\JUNIOR;Initial Catalog=PruebaPolyTalk;Integrated Security=True;TrustServerCertificate=True;";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContrasena.Text != "CONTRASEÑA")
                {
                    string nombreUsuario = txtUsuario.Text;
                    string contrasenia = txtContrasena.Text;

                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    {
                        try
                        {
                            conexion.Open();

                            // MODIFICA ESTA CONSULTA: agregar también el username para pasarlo al FrmPrincipal
                            string consulta = "SELECT user_role, username FROM users WHERE username = @nombreusuario AND password = @contrasenia";

                            using (SqlCommand comando = new SqlCommand(consulta, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombreusuario", nombreUsuario);
                                comando.Parameters.AddWithValue("@contrasenia", contrasenia);

                                using (SqlDataReader reader = comando.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        string rol = reader["user_role"].ToString().ToUpper();
                                        string username = reader["username"].ToString();

                                        MessageBox.Show($"Login exitoso - Rol: {rol}", "DEBUG"); // 👈 VERIFICAR

                                        this.Hide();

                                        // CREAR el formulario PRINCIPAL y pasarle los datos
                                        FrmPrincipal frmPrincipal = new FrmPrincipal(rol, username);
                                        frmPrincipal.RolUsuario = rol;
                                        frmPrincipal.NombreUsuario = username; // ¡IMPORTANTE!
                                        frmPrincipal.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        catch (SqlException sqlEx)
                        {
                            // Error específico de SQL
                            MessageBox.Show($"Error SQL: {sqlEx.Message}\n\nVerifica que:\n1. La base de datos existe\n2. La tabla 'users' existe\n3. La conexión es correcta",
                                          "Error de Base de Datos",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}