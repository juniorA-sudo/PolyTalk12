using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmBienvenidaAdmin : Form
    {
        private readonly string username;
        private readonly Form parentForm;

        public FrmBienvenidaAdmin(string username, Form parentForm = null)
        {
            InitializeComponent();
            this.username = username;
            this.parentForm = parentForm;
        }

        private void FrmBienvenidaAdmin_Load(object sender, EventArgs e)
        {
            ActualizarUI();
            CargarEstadisticas();
            timerAutoCerrar.Start();
        }

        private void ActualizarUI()
        {
            lblSaludo.Text = "¡Bienvenido, " + username + "!";
            lblRol.Text = "Administrador";
        }

        private void CargarEstadisticas()
        {
            try
            {
                var db = new DatabaseHelper();
                using (var conn = new SqlConnection(db.ConnectionString))
                {
                    conn.Open();

                    // Total Estudiantes
                    using (var cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM users WHERE user_role='ESTUDIANTE' AND is_active=1", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        lblTotalEstudiantes.Text = result?.ToString() ?? "0";
                    }

                    // Total Maestros
                    using (var cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM users WHERE user_role='MAESTRO' AND is_active=1", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        lblTotalMaestros.Text = result?.ToString() ?? "0";
                    }

                    // Total Grupos
                    using (var cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM groups", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        lblTotalGrupos.Text = result?.ToString() ?? "0";
                    }

                    // Tareas Pendientes (Draft)
                    using (var cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM tasks WHERE status='Draft'", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        lblTareasPendientes.Text = result?.ToString() ?? "0";
                    }
                }
            }
            catch
            {
                // Si falla la carga de datos, mostrar 0s
                lblTotalEstudiantes.Text = "0";
                lblTotalMaestros.Text = "0";
                lblTotalGrupos.Text = "0";
                lblTareasPendientes.Text = "0";
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            timerAutoCerrar.Stop();
            Cerrar();
        }

        private void timerAutoCerrar_Tick(object sender, EventArgs e)
        {
            timerAutoCerrar.Stop();
            Cerrar();
        }

        private void Cerrar()
        {
            if (parentForm != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
