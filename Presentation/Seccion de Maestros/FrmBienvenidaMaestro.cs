using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentation.Seccion_de_Maestros
{
    public partial class FrmBienvenidaMaestro : Form
    {
        private readonly string username;
        private readonly int teacherId;
        private readonly Form parentForm;

        public FrmBienvenidaMaestro(string username, int teacherId, Form parentForm = null)
        {
            InitializeComponent();
            this.username = username;
            this.teacherId = teacherId;
            this.parentForm = parentForm;
        }

        private void FrmBienvenidaMaestro_Load(object sender, EventArgs e)
        {
            ActualizarUI();
            CargarEstadisticas();
            timerAutoCerrar.Start();
        }

        private void ActualizarUI()
        {
            lblSaludo.Text = "¡Bienvenido, " + username + "!";
            lblRol.Text = "Profesor";
        }

        private void CargarEstadisticas()
        {
            try
            {
                var db = new DatabaseHelper();
                using (var conn = new SqlConnection(db.ConnectionString))
                {
                    conn.Open();

                    // Total Estudiantes (in MY groups)
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(DISTINCT e.student_id)
                          FROM enrollments e
                          INNER JOIN groups g ON e.group_id = g.group_id
                          WHERE g.teacher_id = @teacher_id AND e.status = 'activo'", conn))
                    {
                        cmd.Parameters.AddWithValue("@teacher_id", teacherId);
                        var result = cmd.ExecuteScalar();
                        lblTotalEstudiantes.Text = result?.ToString() ?? "0";
                    }

                    // Total Grupos (where teacher_id = @teacherId)
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(*) FROM groups WHERE teacher_id = @teacher_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@teacher_id", teacherId);
                        var result = cmd.ExecuteScalar();
                        lblTotalGrupos.Text = result?.ToString() ?? "0";
                    }

                    // Entregas Pendientes (ungraded submissions from MY tasks)
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(*)
                          FROM task_submissions ts
                          INNER JOIN tasks t ON ts.task_id = t.task_id
                          WHERE t.teacher_id = @teacher_id
                          AND (ts.status = 'Submitted' OR ts.status IS NULL)", conn))
                    {
                        cmd.Parameters.AddWithValue("@teacher_id", teacherId);
                        var result = cmd.ExecuteScalar();
                        lblEntregasPendientes.Text = result?.ToString() ?? "0";
                    }

                    // Lecciones Creadas (lessons where teacher_id = @teacherId)
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(*) FROM lessons WHERE teacher_id = @teacher_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@teacher_id", teacherId);
                        var result = cmd.ExecuteScalar();
                        lblLeccionesCreadas.Text = result?.ToString() ?? "0";
                    }
                }
            }
            catch
            {
                // Si falla la carga de datos, mostrar 0s
                lblTotalEstudiantes.Text = "0";
                lblTotalGrupos.Text = "0";
                lblEntregasPendientes.Text = "0";
                lblLeccionesCreadas.Text = "0";
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
