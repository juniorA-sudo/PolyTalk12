using System;
using System.Windows.Forms;
using Presentation.Seccion_de_Administrador;
using Presentation.Reportes;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmGestionReportes : Form
    {
        private string rolUsuario;
        private int studentId = -1;
        private string nombreUsuario = "";

        public FrmGestionReportes(string rol = "ADMIN", int studentId = -1, string nombreUsuario = "")
        {
            InitializeComponent();
            rolUsuario = rol?.ToUpper().Trim() ?? "ADMIN";
            this.studentId = studentId;
            this.nombreUsuario = nombreUsuario;
            ConfigurarReportesSegunRol();
        }

        private void ConfigurarReportesSegunRol()
        {
            // Ocultar todos los botones por defecto
            OcultarTodosBotones();

            // Mostrar botones según rol
            switch (rolUsuario)
            {
                case "ADMIN":
                case "ADMINISTRADOR":
                    MostrarReportesAdmin();
                    break;
                case "MAESTRO":
                case "TEACHER":
                    MostrarReportesMaestro();
                    break;
                case "ESTUDIANTE":
                case "STUDENT":
                    MostrarReportesEstudiante();
                    break;
            }
        }

        private void OcultarTodosBotones()
        {
            btnUnidadesPorNivel.Visible = false;
            btnEstudiantesPorNivel.Visible = false;
            btnEstudiantesPorGrupo.Visible = false;
            btnEstudiantesPorMaestro.Visible = false;
            btnMaestrosPorNivel.Visible = false;
            btnMaestros.Visible = false;
            btnGrupos.Visible = false;
            btnEstudiantes.Visible = false;
            btnProgresoGrupo.Visible = false;
            btnDesempenioTareas.Visible = false;
            btnProgresoEstudiante.Visible = false;
            btnMisCalificaciones.Visible = false;
        }

        private void MostrarReportesAdmin()
        {
            // Admin ve todos los reportes
            btnUnidadesPorNivel.Visible = true;
            btnEstudiantesPorNivel.Visible = true;
            btnEstudiantesPorGrupo.Visible = true;
            btnEstudiantesPorMaestro.Visible = true;
            btnMaestrosPorNivel.Visible = true;
            btnMaestros.Visible = true;
            btnGrupos.Visible = true;
            btnEstudiantes.Visible = true;
            btnProgresoGrupo.Visible = true;
            btnDesempenioTareas.Visible = true;
        }

        private void MostrarReportesMaestro()
        {
            // Maestros ven reportes de sus grupos y tareas
            btnProgresoGrupo.Visible = true;
            btnDesempenioTareas.Visible = true;
            btnEstudiantesPorGrupo.Visible = true;
        }

        private void MostrarReportesEstudiante()
        {
            // Estudiantes ven reportes personales
            btnProgresoEstudiante.Visible = true;
            btnMisCalificaciones.Visible = true;
        }

        // Método para abrir formularios hijos dentro del panel
        private void AbrirFormEnPanel(Form formHijo)
        {
            panelReportes.Controls.Clear();          // Limpiar el panel
            formHijo.TopLevel = false;                // No es una ventana independiente
            formHijo.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            formHijo.Dock = DockStyle.Fill;           // Que ocupe todo el panel
            panelReportes.Controls.Add(formHijo);     // Agregar al panel
            formHijo.Show();                           // Mostrar
        }

        private void btnEstudiantesPorNivel_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteEstudiantesPorNivel());
        }

        private void btnUnidadesPorNivel_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteUnidadesPorNivel());
        }

        private void btnEstudiantesPorGrupo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteEstudiantesPorGrupo());
        }

        private void btnEstudiantesPorMaestro_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteEstudiantesPorMaestro());
        }

        private void btnMaestrosPorNivel_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteMaestrosPorNivel());
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteMaestros());
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteGrupos());
        }

        private void btnProgresoGrupo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteProgresoGrupo());
        }

        private void btnDesempenioTareas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteDesempenioTareas());
        }

        private void btnProgresoEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                int idEstudiante = studentId;

                if (idEstudiante <= 0 && !string.IsNullOrEmpty(nombreUsuario))
                {
                    // Obtener student ID desde la base de datos si es necesario
                    DatabaseHelper db = new DatabaseHelper();
                    string query = @"SELECT s.student_id FROM students s
                                     INNER JOIN users u ON s.user_id = u.user_id
                                     WHERE u.username = @username";
                    try
                    {
                        using (var conn = new System.Data.SqlClient.SqlConnection(db.ConnectionString))
                        using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", nombreUsuario);
                            conn.Open();
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                                idEstudiante = Convert.ToInt32(result);
                        }
                    }
                    catch { }
                }

                AbrirFormEnPanel(new FrmReporteProgresoEstudiante(idEstudiante));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al abrir reporte: {ex.Message}", "Error",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void btnMisCalificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                int idEstudiante = studentId;

                if (idEstudiante <= 0 && !string.IsNullOrEmpty(nombreUsuario))
                {
                    // Obtener student ID desde la base de datos si es necesario
                    DatabaseHelper db = new DatabaseHelper();
                    string query = @"SELECT s.student_id FROM students s
                                     INNER JOIN users u ON s.user_id = u.user_id
                                     WHERE u.username = @username";
                    try
                    {
                        using (var conn = new System.Data.SqlClient.SqlConnection(db.ConnectionString))
                        using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", nombreUsuario);
                            conn.Open();
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                                idEstudiante = Convert.ToInt32(result);
                        }
                    }
                    catch { }
                }

                AbrirFormEnPanel(new FrmReporteCalificacionesEstudiante(idEstudiante));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error al abrir reporte: {ex.Message}", "Error",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void btnProgresoGrupo_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteProgresoGrupo());
        }

        private void btnDesempenioTareas_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteDesempenioTareas());
        }

        private void btnProgresoEstudiante_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteProgresoEstudiante());
        }

        private void btnMisCalificaciones_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteCalificacionesEstudiante());
        }
    }
}