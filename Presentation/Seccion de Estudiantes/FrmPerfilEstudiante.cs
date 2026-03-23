using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentation.Seccion_de_Estudiantes
{
    public partial class FrmPerfilEstudiante : Form
    {
        private int studentId;
        private int userId;
        private DatabaseHelper db = new DatabaseHelper();

        public FrmPerfilEstudiante(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.Text = "Perfil del Estudiante";
            CargarDatosEstudiante();
        }

        private void CargarDatosEstudiante()
        {
            try
            {
                string query = @"
                    SELECT u.user_id, u.username, u.email, ISNULL(u.phone,'') AS phone,
                           s.current_english_level, s.enrollment_date, s.student_code
                    FROM students s
                    INNER JOIN users u ON s.user_id = u.user_id
                    WHERE s.student_id = @studentId";

                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            userId = Convert.ToInt32(r["user_id"]);

                            // Panel izquierdo — info personal
                            lblNombreEstudiante.Text = r["username"].ToString();
                            lblUsuarioValue.Text = "@" + r["username"].ToString();
                            lblEmailValue.Text = r["email"].ToString();
                            lblTelefonoValue.Text = r["phone"]?.ToString() ?? "N/A";

                            if (r["enrollment_date"] != DBNull.Value)
                                lblFechaIngresoValue.Text = Convert.ToDateTime(r["enrollment_date"])
                                                                   .ToString("dd MMM, yyyy");

                            // Panel derecho — nivel
                            string nivel = r["current_english_level"].ToString();
                            lblNivelValue.Text = nivel;
                            ActualizarBarraNivel(nivel);

                            // Grupo y maestro
                            CargarInfoGrupo();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar perfil: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarBarraNivel(string nivel)
        {
            int[] anchos = { 30, 65, 105, 145, 185, 220 };
            string[] niveles = { "A1", "A2", "B1", "B2", "C1", "C2" };
            int idx = Array.IndexOf(niveles, nivel);
            if (idx >= 0) panelNivelBarra.Width = anchos[idx];

            lblNivelDescripcion.Text = nivel switch
            {
                "A1" => "Principiante — primeras palabras en inglés",
                "A2" => "Elemental — frases básicas del día a día",
                "B1" => "Intermedio — conversaciones cotidianas",
                "B2" => "Intermedio alto — fluidez en temas comunes",
                "C1" => "Avanzado — expresión clara y detallada",
                "C2" => "Maestría — dominio completo del idioma",
                _ => "A1 ─── A2 ─── B1 ─── B2 ─── C1 ─── C2"
            };
        }

        private void CargarInfoGrupo()
        {
            try
            {
                string query = @"
                    SELECT g.group_name, g.schedule,
                           u.username AS maestro
                    FROM enrollments e
                    INNER JOIN groups g   ON e.group_id  = g.group_id
                    LEFT JOIN  teachers t ON g.teacher_id = t.teacher_id
                    LEFT JOIN  users u    ON t.user_id    = u.user_id
                    WHERE e.student_id = @studentId AND e.status = 'activo'";

                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            lblGrupoValue.Text = r["group_name"].ToString();
                            lblHorarioValue.Text = r["schedule"]?.ToString() ?? "N/A";
                            lblMaestroValue.Text = r["maestro"]?.ToString() ?? "Sin asignar";
                        }
                    }
                }
            }
            catch { }
        }

        // ── Botón Editar Perfil ─────────────────────────────────
        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = this.Parent?.FindForm() as FrmPrincipal
                                  ?? Application.OpenForms["FrmPrincipal"] as FrmPrincipal;
            if (principal != null)
                principal.AbrirFormEnPanel(new FrmEditarPerfil(userId, "ESTUDIANTE", principal));
            else
            {
                using var frm = new FrmEditarPerfil(userId, "ESTUDIANTE");
                frm.ShowDialog();
                CargarDatosEstudiante();
            }
        }
    }
}