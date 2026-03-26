using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Guna.UI2.WinForms;

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
            this.DoubleBuffered = true;
        }

        private void FrmBienvenidaAdmin_Load(object sender, EventArgs e)
        {
            ActualizarUI();
            CargarEstadisticas();
            timerAutoCerrar.Start();
        }

        private void ActualizarUI()
        {
            if (lblSaludo != null)
                lblSaludo.Text = $"¡Bienvenido, {username}!";
            if (lblRol != null)
                lblRol.Text = "👨‍💼 Administrador";
        }

        private void CargarEstadisticas()
        {
            try
            {
                var db = new DatabaseHelper();
                using (var conn = new SqlConnection(db.ConnectionString))
                {
                    conn.Open();

                    // Total Estudiantes (de tabla students)
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(DISTINCT s.student_id) 
                          FROM students s
                          INNER JOIN users u ON s.user_id = u.user_id
                          WHERE u.is_active = 1", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        if (lblTotalEstudiantes != null)
                            lblTotalEstudiantes.Text = result?.ToString() ?? "0";
                    }

                    // Total Maestros (de tabla teachers)
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(DISTINCT t.teacher_id) 
                          FROM teachers t
                          INNER JOIN users u ON t.user_id = u.user_id
                          WHERE u.is_active = 1", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        if (lblTotalMaestros != null)
                            lblTotalMaestros.Text = result?.ToString() ?? "0";
                    }

                    // Total Grupos
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(*) FROM groups", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        if (lblTotalGrupos != null)
                            lblTotalGrupos.Text = result?.ToString() ?? "0";
                    }

                    // Tareas en estado Draft
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(*) FROM tasks WHERE status = 'Draft'", conn))
                    {
                        var result = cmd.ExecuteScalar();
                        if (lblTareasPendientes != null)
                            lblTareasPendientes.Text = result?.ToString() ?? "0";
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error cargando estadísticas: {ex.Message}");
                if (lblTotalEstudiantes != null) lblTotalEstudiantes.Text = "0";
                if (lblTotalMaestros != null) lblTotalMaestros.Text = "0";
                if (lblTotalGrupos != null) lblTotalGrupos.Text = "0";
                if (lblTareasPendientes != null) lblTareasPendientes.Text = "0";
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}