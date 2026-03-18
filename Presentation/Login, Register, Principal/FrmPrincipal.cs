using Presentation.Seccion_de_Administrador;
using Presentation.Seccion_de_Estudiantes;
using Presentation.Seccion_de_Maestros;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmPrincipal : Form
    {
        public string RolUsuario { get; set; }
        public string NombreUsuario { get; set; }

        public FrmPrincipal(string rol, string usuario)
        {
            InitializeComponent();

            RolUsuario = rol;
            NombreUsuario = usuario;

            ConfigurarVisibilidadInicial();
            ConfigurarMenuPorRol();
        }

        private void ConfigurarVisibilidadInicial()
        {
            panelAdmin.Visible = false;
            panelMaestros.Visible = false;
            panelEstudiantes.Visible = false;

            btnAdmin.Visible = false;
            btnMaestros.Visible = false;
            btnEstudiantes.Visible = false;

            panelAdminSubMenu.Visible = false;
            panelTeacherSubMenu.Visible = false;
            panelStudentSubMenu.Visible = false;
        }

        public void AbrirFormEnPanel(Form form)
        {
            panelContenedor.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(form);
            form.Show();
        }

        private void ConfigurarMenuPorRol()
        {
            if (string.IsNullOrEmpty(RolUsuario))
            {
                MessageBox.Show("Error: No se recibió el rol del usuario", "ERROR");
                return;
            }

            string rol = RolUsuario.ToUpper().Trim();

            switch (rol)
            {
                case "ADMIN":
                case "ADMINISTRADOR":
                    ConfigurarMenuAdministrador();
                    break;

                case "MAESTRO":
                case "TEACHER":
                    ConfigurarMenuMaestro();
                    break;

                case "ESTUDIANTE":
                case "STUDENT":
                    ConfigurarMenuEstudiante();
                    break;

                default:
                    MessageBox.Show($"Rol no reconocido: {rol}", "ERROR");
                    break;
            }
        }

        private void ConfigurarMenuAdministrador()
        {
            panelAdmin.Visible = true;
            panelAdmin.Dock = DockStyle.Top;
            btnAdmin.Visible = true;

            panelMaestros.Visible = true;
            panelMaestros.Dock = DockStyle.Top;
            btnMaestros.Visible = true;

            panelEstudiantes.Visible = true;
            panelEstudiantes.Dock = DockStyle.Top;
            btnEstudiantes.Visible = true;

            panelAdminSubMenu.Visible = false;
            panelTeacherSubMenu.Visible = false;
            panelStudentSubMenu.Visible = false;

            this.Text = "PolyTalk - Administrador";
        }

        private void ConfigurarMenuMaestro()
        {
            panelMaestros.Visible = false;
            btnMaestros.Visible = false;

            panelTeacherSubMenu.Visible = true;
            panelTeacherSubMenu.Dock = DockStyle.Top;
            panelTeacherSubMenu.FillColor = Color.FromArgb(249, 199, 79);

            btnMisEstudiantes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLessons.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTareas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            panelAdmin.Visible = false;
            panelEstudiantes.Visible = false;

            this.Text = "PolyTalk - Maestro";
        }

        private void ConfigurarMenuEstudiante()
        {
            panelEstudiantes.Visible = false;
            btnEstudiantes.Visible = false;

            panelStudentSubMenu.Visible = true;
            panelStudentSubMenu.Dock = DockStyle.Top;
            panelStudentSubMenu.FillColor = Color.FromArgb(249, 199, 79);

            btnMisionEstudiante.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLecciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVocabulario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            panelAdmin.Visible = false;
            panelMaestros.Visible = false;

            this.Text = "PolyTalk - Estudiante";
        }

        // =====================================================
        // CONTROL DE SUBMENÚS
        // =====================================================
        private void hideSubMenu()
        {
            if (panelAdminSubMenu.Visible) panelAdminSubMenu.Visible = false;
            if (panelStudentSubMenu.Visible) panelStudentSubMenu.Visible = false;
            if (panelTeacherSubMenu.Visible) panelTeacherSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        // =====================================================
        // BOTONES - ADMINISTRADOR
        // =====================================================
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdminSubMenu);
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTeacherSubMenu);
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentSubMenu);
        }

        private void btnGestionMaestros_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmGestionMaestros());
            hideSubMenu();
        }

        private void btnGestionGrupos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmGestionGrupos());
            hideSubMenu();
        }

        private void btnGestionEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmGestionEstudiantes());
            hideSubMenu();
        }

        private void btnContenido_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmContenido());
            hideSubMenu();
        }

        // =====================================================
        // BOTONES - MAESTRO
        // =====================================================
        private void btnMisEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmMisEstudiantes());
        }

        private void btnLessons_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmMisLecciones());
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmMisTareas());
        }

        // =====================================================
        // BOTONES - ESTUDIANTE
        // =====================================================
        private void btnMisionEstudiante_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmMisionEstudiante(this));
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmLecciones());
        }

        private void btnVocabulario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmVocabulario());
        }

        // =====================================================
        // REPORTES
        // =====================================================
        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de reportes en construcción", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =====================================================
        // PERFIL - Abre el perfil según el rol del usuario
        // =====================================================
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string rol = RolUsuario?.ToUpper().Trim();

            try
            {
                if (rol == "MAESTRO" || rol == "TEACHER")
                {
                    DatabaseHelper db = new DatabaseHelper();
                    DataTable dt = db.ObtenerMaestros();
                    DataRow[] filas = dt.Select($"Usuario = '{NombreUsuario}'");

                    if (filas.Length > 0)
                    {
                        int teacherId = Convert.ToInt32(filas[0]["ID"]);
                        AbrirFormEnPanel(new FrmPerfilMaestro(teacherId));
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el perfil del maestro.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rol == "ADMIN" || rol == "ADMINISTRADOR")
                {
                    DatabaseHelper db = new DatabaseHelper();

                    string query = @"
                        SELECT user_id 
                        FROM users 
                        WHERE username = @username 
                          AND user_role IN ('admin', 'administrador')";

                    using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", NombreUsuario);
                        conn.Open();
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int userId = Convert.ToInt32(result);
                            AbrirFormEnPanel(new FrmPerfilAdmin(userId));
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el perfil del administrador.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else if (rol == "ESTUDIANTE" || rol == "STUDENT")
                {
                    // 👇 Busca el student_id por username y abre FrmPerfilEstudiante
                    DatabaseHelper db = new DatabaseHelper();

                    string query = @"
                        SELECT s.student_id
                        FROM students s
                        INNER JOIN users u ON s.user_id = u.user_id
                        WHERE u.username = @username";

                    using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", NombreUsuario);
                        conn.Open();
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int studentId = Convert.ToInt32(result);
                            AbrirFormEnPanel(new FrmPerfilEstudiante(studentId));
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el perfil del estudiante.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el perfil: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // CONTROL DE VENTANA
        // =====================================================
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmLogin().Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Eventos sin usar
        private void btnSeccionesYCursos_Click(object sender, EventArgs e) { }
        private void btnReportes_Click(object sender, EventArgs e) { }
        private void btnPractica_Click(object sender, EventArgs e) { }
        private void btnTop_Click(object sender, EventArgs e) { }
        private void btnMisClases_Click(object sender, EventArgs e) { }
        private void btnMensajes_Click(object sender, EventArgs e) { }
        private void guna2Button5_Click(object sender, EventArgs e) { }
        private void guna2Button4_Click_1(object sender, EventArgs e) { }
        private void btnReporteEstudiante_Click(object sender, EventArgs e) { }
    }
}