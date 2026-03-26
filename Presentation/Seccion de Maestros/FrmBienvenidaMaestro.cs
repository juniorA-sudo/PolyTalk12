using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Guna.UI2.WinForms;

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
            this.DoubleBuffered = true;
        }

        private void FrmBienvenidaMaestro_Load(object sender, EventArgs e)
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
                lblRol.Text = "👨‍🏫 Profesor";
        }

        private void CargarEstadisticas()
        {
            try
            {
                var db = new DatabaseHelper();
                using (var conn = new SqlConnection(db.ConnectionString))
                {
                    conn.Open();

                    // Total Estudiantes en mis grupos
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(DISTINCT e.student_id)
                          FROM enrollments e
                          INNER JOIN groups g ON e.group_id = g.group_id
                          WHERE g.teacher_id = @teacher_id AND e.status = 'activo'", conn))
                    {
                        cmd.Parameters.AddWithValue("@teacher_id", teacherId);
                        var result = cmd.ExecuteScalar();
                        if (lblTotalEstudiantes != null)
                            lblTotalEstudiantes.Text = result?.ToString() ?? "0";
                    }

                    // Total Grupos del maestro
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(*) FROM groups WHERE teacher_id = @teacher_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@teacher_id", teacherId);
                        var result = cmd.ExecuteScalar();
                        if (lblTotalGrupos != null)
                            lblTotalGrupos.Text = result?.ToString() ?? "0";
                    }

                    // Entregas pendientes de calificar (mis tareas)
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(*)
                          FROM task_submissions ts
                          INNER JOIN tasks t ON ts.task_id = t.task_id
                          WHERE t.teacher_id = @teacher_id
                          AND (ts.status = 'Submitted' OR ts.status IS NULL)", conn))
                    {
                        cmd.Parameters.AddWithValue("@teacher_id", teacherId);
                        var result = cmd.ExecuteScalar();
                        if (lblEntregasPendientes != null)
                            lblEntregasPendientes.Text = result?.ToString() ?? "0";
                    }

                    // Lecciones creadas por el maestro
                    using (var cmd = new SqlCommand(
                        @"SELECT COUNT(*) FROM lessons WHERE teacher_id = @teacher_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@teacher_id", teacherId);
                        var result = cmd.ExecuteScalar();
                        if (lblLeccionesCreadas != null)
                            lblLeccionesCreadas.Text = result?.ToString() ?? "0";
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error cargando estadísticas: {ex.Message}");
                if (lblTotalEstudiantes != null) lblTotalEstudiantes.Text = "0";
                if (lblTotalGrupos != null) lblTotalGrupos.Text = "0";
                if (lblEntregasPendientes != null) lblEntregasPendientes.Text = "0";
                if (lblLeccionesCreadas != null) lblLeccionesCreadas.Text = "0";
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