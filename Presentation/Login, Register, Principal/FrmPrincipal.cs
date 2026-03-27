using Presentation.Seccion_de_Administrador;
using Presentation.Seccion_de_Estudiantes;
using Presentation.Seccion_de_Maestros;
using Presentation.Services;
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
        private int userId;
        private NotificationService notificationService;
        private System.Windows.Forms.Timer notificationTimer;

        public FrmPrincipal(string rol, string usuario, int userId)
        {
            InitializeComponent();
            RolUsuario = rol;
            NombreUsuario = usuario;
            this.userId = userId;
            notificationService = new NotificationService();

            // Configurar timer para actualizar notificaciones cada 30 segundos
            notificationTimer = new System.Windows.Forms.Timer();
            notificationTimer.Interval = 30000;
            notificationTimer.Tick += (s, e) => ActualizarNotificaciones();

            ConfigurarVisibilidadInicial();
            ConfigurarMenuPorRol();

            this.Load += (s, e) =>
            {
                ActualizarNotificaciones();
                notificationTimer.Start();
            };

            this.FormClosing += (s, e) => notificationTimer?.Stop();
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
            { MessageBox.Show("Error: No se recibió el rol del usuario", "ERROR"); return; }

            string rol = RolUsuario.ToUpper().Trim();
            switch (rol)
            {
                case "ADMIN": case "ADMINISTRADOR": ConfigurarMenuAdministrador(); break;
                case "MAESTRO": case "TEACHER": ConfigurarMenuMaestro(); break;
                case "ESTUDIANTE": case "STUDENT": ConfigurarMenuEstudiante(); break;
                default: MessageBox.Show($"Rol no reconocido: {rol}", "ERROR"); break;
            }
        }

        private void ConfigurarMenuAdministrador()
        {
            panelAdmin.Visible = true; panelAdmin.Dock = DockStyle.Top; btnAdmin.Visible = true;
            panelMaestros.Visible = true; panelMaestros.Dock = DockStyle.Top; btnMaestros.Visible = true;
            panelEstudiantes.Visible = true; panelEstudiantes.Dock = DockStyle.Top; btnEstudiantes.Visible = true;
            panelAdminSubMenu.Visible = false; panelTeacherSubMenu.Visible = false; panelStudentSubMenu.Visible = false;
            this.Text = "PolyTalk - Administrador";

            // ✅ Mostrar FrmBienvenida al entrar como administrador
            MostrarBienvenidaAdmin();
        }

        private void ConfigurarMenuMaestro()
        {
            panelMaestros.Visible = false; btnMaestros.Visible = false;
            panelTeacherSubMenu.Visible = true; panelTeacherSubMenu.Dock = DockStyle.Top;
            panelTeacherSubMenu.FillColor = Color.FromArgb(249, 199, 79);
            btnMisEstudiantes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLessons.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMisTareas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCalificarTareas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            panelAdmin.Visible = false; panelEstudiantes.Visible = false;
            this.Text = "PolyTalk - Maestro";

            // ✅ Mostrar FrmBienvenida al entrar como maestro
            MostrarBienvenidaMaestro();
        }

        private void BtnDashboardMaestro_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new Presentation.Seccion_de_Maestros.FrmDashboardMaestro(ObtenerTeacherId()));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarMenuEstudiante()
        {
            panelEstudiantes.Visible = false; btnEstudiantes.Visible = false;
            panelStudentSubMenu.Visible = true; panelStudentSubMenu.Dock = DockStyle.Top;
            panelStudentSubMenu.FillColor = Color.FromArgb(249, 199, 79);
            btnMisionEstudiante.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLecciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVocabulario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTareasEstudiante.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalificacionesEstudiante.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            panelAdmin.Visible = false; panelMaestros.Visible = false;
            this.Text = "PolyTalk - Estudiante";

            // ✅ Mostrar FrmBienvenida al entrar como estudiante
            MostrarBienvenidaEstudiante();
        }

        private void BtnDashboardEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel(new Presentation.Seccion_de_Estudiantes.FrmDashboardEstudiante(ObtenerStudentId()));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Guna.UI2.WinForms.Guna2Button btnCalificacionesEstudiante;

        // ── FrmBienvenida ──────────────────────────────────────
        private void MostrarBienvenidaEstudiante()
        {
            try
            {
                // Obtener datos del estudiante para la bienvenida
                DatabaseHelper db = new DatabaseHelper();
                string query = @"
                    SELECT s.current_english_level,
                           ISNULL((SELECT COUNT(*) FROM lesson_progress lp2
                                   WHERE lp2.student_id = s.student_id
                                   AND CAST(lp2.completed_at AS DATE) = CAST(GETDATE()-1 AS DATE)), 0) AS racha
                    FROM students s
                    INNER JOIN users u ON s.user_id = u.user_id
                    WHERE u.username = @username";

                string nivel = "A1";
                int racha = 0;

                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", NombreUsuario);
                    conn.Open();
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            nivel = r.GetString(0);
                            racha = Convert.ToInt32(r[1]);
                        }
                    }
                }

                // ✅ Abrir FrmBienvenida dentro del panel contenedor
                AbrirFormEnPanel(new FrmBienvenidaEstudiante(NombreUsuario, nivel, racha, this));
            }
            catch
            {
                // Si falla, simplemente no muestra la bienvenida — no interrumpe la app
            }
        }

        private void MostrarBienvenidaAdmin()
        {
            try
            {
                AbrirFormEnPanel(new Presentation.Seccion_de_Administrador.FrmBienvenidaAdmin(NombreUsuario, this));
            }
            catch
            {
                // Si falla, simplemente no muestra la bienvenida — no interrumpe la app
            }
        }

        private void MostrarBienvenidaMaestro()
        {
            try
            {
                int teacherId = ObtenerTeacherId();
                AbrirFormEnPanel(new Presentation.Seccion_de_Maestros.FrmBienvenidaMaestro(NombreUsuario, teacherId, this));
            }
            catch
            {
                // Si falla, simplemente no muestra la bienvenida — no interrumpe la app
            }
        }

        private int ObtenerTeacherId()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                string query = @"SELECT t.teacher_id FROM teachers t
                                 INNER JOIN users u ON t.user_id = u.user_id
                                 WHERE u.username = @username";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", NombreUsuario);
                    conn.Open();
                    var r = cmd.ExecuteScalar();
                    return r != null ? Convert.ToInt32(r) : 1;
                }
            }
            catch { return 1; }
        }

        private void hideSubMenu()
        {
            if (panelAdminSubMenu.Visible) panelAdminSubMenu.Visible = false;
            if (panelStudentSubMenu.Visible) panelStudentSubMenu.Visible = false;
            if (panelTeacherSubMenu.Visible) panelTeacherSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible) { hideSubMenu(); subMenu.Visible = true; }
            else subMenu.Visible = false;
        }

        // ── ADMIN ──────────────────────────────────────────────
        private void btnAdmin_Click(object sender, EventArgs e) => showSubMenu(panelAdminSubMenu);
        private void btnMaestros_Click(object sender, EventArgs e) => showSubMenu(panelTeacherSubMenu);
        private void btnEstudiantes_Click(object sender, EventArgs e) => showSubMenu(panelStudentSubMenu);

        private void btnGestionMaestros_Click(object sender, EventArgs e)
        { AbrirFormEnPanel(new FrmGestionMaestros()); hideSubMenu(); }
        private void btnGestionGrupos_Click(object sender, EventArgs e)
        { AbrirFormEnPanel(new FrmGestionGrupos()); hideSubMenu(); }
        private void btnGestionEstudiantes_Click(object sender, EventArgs e)
        { AbrirFormEnPanel(new FrmGestionEstudiantes()); hideSubMenu(); }
        private void btnContenido_Click(object sender, EventArgs e) { hideSubMenu(); }

        // ── MAESTRO ────────────────────────────────────────────
        private void btnMisEstudiantes_Click(object sender, EventArgs e)
            => AbrirFormEnPanel(new FrmMisEstudiantes());

        private void btnLessons_Click_1(object sender, EventArgs e)
            => AbrirFormEnPanel(new FrmCrearLeccionIA());

        private void btnTareas_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                DataTable dt = db.ObtenerMaestros();
                DataRow[] filas = dt.Select($"Usuario = '{NombreUsuario}'");
                if (filas.Length > 0)
                    AbrirFormEnPanel(new FrmMisTareas(Convert.ToInt32(filas[0]["ID"])));
                else
                    MessageBox.Show("No se encontró el perfil del maestro.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            { MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCalificarTareas_Click(object sender, EventArgs e)
        {
            try
            {
                int teacherId = ObtenerTeacherId();
                AbrirFormEnPanel(new FrmCalificarTareas(teacherId));
            }
            catch (Exception ex)
            { MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // ── ESTUDIANTE ─────────────────────────────────────────
        private void btnMisionEstudiante_Click(object sender, EventArgs e)
            => AbrirFormEnPanel(new FrmMisionEstudiante(this, ObtenerStudentId()));

        private void btnLecciones_Click(object sender, EventArgs e)
            => AbrirFormEnPanel(new FrmLecciones(ObtenerStudentId(), this));

        private void btnVocabulario_Click(object sender, EventArgs e)
            => AbrirFormEnPanel(new FrmVocabulario(userId));

        private void btnCalificacionesEstudiante_Click(object sender, EventArgs e)
            => AbrirFormEnPanel(new FrmMisCalificaciones(ObtenerStudentId()));

        private void btnTareasEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                string query = @"SELECT s.student_id FROM students s
                                 INNER JOIN users u ON s.user_id = u.user_id
                                 WHERE u.username = @username";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", NombreUsuario);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        AbrirFormEnPanel(new FrmTareasEstudiante(Convert.ToInt32(result)));
                    else
                        MessageBox.Show("No se encontró el perfil del estudiante.", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private int ObtenerStudentId()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                string query = @"SELECT s.student_id FROM students s
                                 INNER JOIN users u ON s.user_id = u.user_id
                                 WHERE u.username = @username";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", NombreUsuario);
                    conn.Open();
                    var r = cmd.ExecuteScalar();
                    return r != null ? Convert.ToInt32(r) : 1;
                }
            }
            catch { return 1; }
        }

        // ── REPORTES ───────────────────────────────────────────
        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            int studentId = ObtenerStudentId();
            AbrirFormEnPanel(new FrmGestionReportes(RolUsuario, studentId, NombreUsuario));
        }

        // ── PERFIL ─────────────────────────────────────────────
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string rol = RolUsuario?.ToUpper().Trim();
            try
            {
                if (rol is "MAESTRO" or "TEACHER")
                {
                    DatabaseHelper db = new DatabaseHelper();
                    DataTable dt = db.ObtenerMaestros();
                    DataRow[] filas = dt.Select($"Usuario = '{NombreUsuario}'");
                    if (filas.Length > 0)
                        AbrirFormEnPanel(new FrmPerfilMaestro(Convert.ToInt32(filas[0]["ID"])));
                    else
                        MessageBox.Show("No se encontró el perfil del maestro.", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (rol is "ADMIN" or "ADMINISTRADOR")
                {
                    DatabaseHelper db = new DatabaseHelper();
                    string query = @"SELECT user_id FROM users
                                     WHERE username = @username
                                     AND user_role IN ('admin', 'administrador')";
                    using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", NombreUsuario);
                        conn.Open();
                        var r = cmd.ExecuteScalar();
                        if (r != null) AbrirFormEnPanel(new FrmPerfilAdmin(Convert.ToInt32(r)));
                        else MessageBox.Show("No se encontró el perfil del administrador.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else // ESTUDIANTE
                {
                    DatabaseHelper db = new DatabaseHelper();
                    string query = @"SELECT s.student_id FROM students s
                                     INNER JOIN users u ON s.user_id = u.user_id
                                     WHERE u.username = @username";
                    using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", NombreUsuario);
                        conn.Open();
                        var r = cmd.ExecuteScalar();
                        if (r != null) AbrirFormEnPanel(new FrmPerfilEstudiante(Convert.ToInt32(r)));
                        else MessageBox.Show("No se encontró el perfil del estudiante.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el perfil: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── VENTANA ────────────────────────────────────────────
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        { this.Close(); new FrmLogin().Show(); }
        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

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

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        // ── NOTIFICACIONES ──────────────────────────────────────
        private void ActualizarNotificaciones()
        {
            try
            {
                if (RolUsuario?.ToUpper().Contains("STUDENT") == true)
                    ActualizarNotificacionesEstudiante();
                else if (RolUsuario?.ToUpper().Contains("MAESTRO") == true || RolUsuario?.ToUpper().Contains("TEACHER") == true)
                    ActualizarNotificacionesMaestro();
            }
            catch { }
        }

        private void ActualizarNotificacionesEstudiante()
        {
            try
            {
                // Obtener ID del estudiante
                DatabaseHelper db = new DatabaseHelper();
                string query = "SELECT student_id FROM students INNER JOIN users ON students.user_id = users.user_id WHERE users.username = @username";
                int studentId = 1;

                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", NombreUsuario);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null) studentId = Convert.ToInt32(result);
                }

                // Actualizar badges
                int tareasPendientes = notificationService.ObtenerTareasPendientesEstudiante(studentId);
                ActualizarBadgeBoton(btnTareasEstudiante, tareasPendientes);

                int leccionesIncompletas = notificationService.ObtenerLeccionesIncompletas(studentId);
                ActualizarBadgeBoton(btnLecciones, leccionesIncompletas);

                // Mostrar alertas de tareas próximas a vencer (solo una vez al cargar)
                if (notificationTimer.Interval > 0)
                {
                    DataTable tareasProximas = notificationService.ObtenerTareasProximasAVencer(studentId);
                    if (tareasProximas.Rows.Count > 0)
                        MostrarAlertaTareasProximas(tareasProximas);
                }
            }
            catch { }
        }

        private void ActualizarNotificacionesMaestro()
        {
            try
            {
                // Obtener ID del maestro
                int teacherId = ObtenerTeacherId();

                // Actualizar badges
                int calificacionesPendientes = notificationService.ObtenerCalificacionesPendientesMaestro(teacherId);
                ActualizarBadgeBoton(btnCalificarTareas, calificacionesPendientes);

                int estudiantesSinCalificar = notificationService.ObtenerEstudiantesSinCalificar(teacherId);
                ActualizarBadgeBoton(btnMisEstudiantes, estudiantesSinCalificar > 0 ? estudiantesSinCalificar : 0);
            }
            catch { }
        }

        private void ActualizarBadgeBoton(Guna.UI2.WinForms.Guna2Button boton, int cantidad)
        {
            if (boton == null || cantidad <= 0)
            {
                boton.Text = boton.Text.Split('(')[0].Trim();
                return;
            }

            string textoBase = boton.Text.Contains("(") ? boton.Text.Split('(')[0].Trim() : boton.Text;
            boton.Text = $"{textoBase} ({cantidad})";

            // Cambiar color del texto si hay notificaciones
            if (cantidad > 0)
                boton.ForeColor = Color.FromArgb(197, 48, 48); // Rojo para alertar
            else
                boton.ForeColor = Color.FromArgb(51, 51, 51); // Normal
        }

        private void MostrarAlertaTareasProximas(DataTable tareas)
        {
            try
            {
                string mensaje = "⚠️ TAREAS PRÓXIMAS A VENCER:\n\n";
                foreach (DataRow row in tareas.Rows)
                {
                    string titulo = row["title"].ToString();
                    int dias = Convert.ToInt32(row["DiasRestantes"]);
                    mensaje += $"📌 {titulo} - {(dias == 0 ? "HOY!" : dias + " días")}\n";
                }

                // Mostrar solo la primera vez al cargar
                if (notificationTimer.Interval < 1000)
                {
                    MessageBox.Show(mensaje, "⏰ Recordatorio de Tareas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }
    }
}