using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation.Seccion_de_Estudiantes
{
    public partial class FrmPerfilEstudiante : Form
    {
        private int estudianteId;
        private DatabaseHelper db = new DatabaseHelper();

        public FrmPerfilEstudiante(int idEstudiante)
        {
            InitializeComponent();
            this.estudianteId = idEstudiante;
            this.Text = "Perfil del Estudiante";
            CargarDatosEstudiante();
        }

        private void CargarDatosEstudiante()
        {
            try
            {
                string query = @"
                    SELECT 
                        u.first_name + ' ' + u.last_name AS NombreCompleto,
                        u.username,
                        u.email,
                        u.phone,
                        u.created_at,
                        s.current_english_level,
                        s.enrollment_date,
                        g.group_name,
                        g.schedule,
                        pu.first_name + ' ' + pu.last_name AS NombreMaestro
                    FROM students s
                    INNER JOIN users u ON s.user_id = u.user_id
                    LEFT JOIN enrollments e ON s.student_id = e.student_id 
                        AND e.status = 'activo'
                    LEFT JOIN groups g ON e.group_id = g.group_id
                    LEFT JOIN teachers t ON g.teacher_id = t.teacher_id
                    LEFT JOIN users pu ON t.user_id = pu.user_id
                    WHERE s.student_id = @studentId";

                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", estudianteId);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Datos personales
                            lblNombreEstudiante.Text = reader["NombreCompleto"]?.ToString() ?? "Estudiante";
                            lblUsuarioValue.Text = "@" + reader["username"].ToString();
                            lblEmailValue.Text = reader["email"].ToString();
                            lblTelefonoValue.Text = reader["phone"]?.ToString() ?? "N/A";

                            if (reader["enrollment_date"] != DBNull.Value)
                                lblFechaIngresoValue.Text = Convert.ToDateTime(reader["enrollment_date"])
                                                                   .ToString("dd MMM, yyyy");

                            // Nivel de inglés
                            string nivel = reader["current_english_level"]?.ToString() ?? "N/A";
                            lblNivelValue.Text = nivel;
                            ConfigurarColorNivel(nivel);

                            // Grupo y maestro
                            lblGrupoValue.Text = reader["group_name"]?.ToString() ?? "Sin grupo asignado";
                            lblHorarioValue.Text = reader["schedule"]?.ToString() ?? "N/A";
                            lblMaestroValue.Text = reader["NombreMaestro"] != DBNull.Value
                                ? "Prof. " + reader["NombreMaestro"].ToString()
                                : "Sin maestro asignado";
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el estudiante.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del estudiante: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cambia el color del label de nivel según el nivel de inglés
        /// </summary>
        private void ConfigurarColorNivel(string nivel)
        {
            switch (nivel.ToUpper())
            {
                case "A1":
                    lblNivelValue.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);   // Verde
                    break;
                case "A2":
                    lblNivelValue.ForeColor = System.Drawing.Color.FromArgb(139, 195, 74);  // Verde claro
                    break;
                case "B1":
                    lblNivelValue.ForeColor = System.Drawing.Color.FromArgb(255, 152, 0);   // Naranja
                    break;
                case "B2":
                    lblNivelValue.ForeColor = System.Drawing.Color.FromArgb(255, 87, 34);   // Naranja oscuro
                    break;
                case "C1":
                    lblNivelValue.ForeColor = System.Drawing.Color.FromArgb(102, 126, 234); // Azul
                    break;
                case "C2":
                    lblNivelValue.ForeColor = System.Drawing.Color.FromArgb(156, 39, 176);  // Morado
                    break;
                default:
                    lblNivelValue.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150); // Gris
                    break;
            }
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de edición de perfil", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}