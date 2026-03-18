using Domain;
using ProyectoFInal;
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
        private readonly string cadenaConexion = @"Data Source=JUNIOR;Initial Catalog=BasePrueba3;Integrated Security=True;TrustServerCertificate=True;";
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
        //


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
                            string consulta = "SELECT Rol FROM Usuarios WHERE Usuario = @nombreusuario AND Password = @contrasenia";
                            using (SqlCommand comando = new SqlCommand(consulta, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombreusuario", nombreUsuario);
                                comando.Parameters.AddWithValue("@contrasenia", contrasenia);

                                object resultado = comando.ExecuteScalar();

                                if (resultado != null)
                                {
                                    string rol = resultado.ToString();

                                    this.Hide();
                                    switch(rol)
                                    {
                                        case "ESTUDIANTE":
                                            new FrmEstudiante().Show();
                                            break;

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Nombre de usuario o contrasenia incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    txtContrasena.Text = "ⓧ Ingrese una contraseña";
                }
            }
            else
            {
                lblMensajeError.Visible = true;
                lblMensajeError.Text = "ⓧ Ingrese un usuario";
            }
        }
    }

}
