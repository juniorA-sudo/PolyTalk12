using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation.Seccion_de_Maestros
{
    public partial class FrmPerfilMaestro : Form
    {
        private int maestroId;
        private DatabaseHelper db = new DatabaseHelper();

        public FrmPerfilMaestro(int idMaestro)
        {
            InitializeComponent();
            this.maestroId = idMaestro;
            this.Text = "Perfil del Maestro";

            CargarDatosMaestro();
            CargarTarjetasGrupos();
        }

        private void CargarDatosMaestro()
        {
            try
            {
                DataTable dtTodos = db.ObtenerMaestros();
                DataRow[] filas = dtTodos.Select($"ID = {maestroId}");

                if (filas.Length > 0)
                {
                    DataRow row = filas[0];

                    // 👇 Nombre completo desde first_name + last_name
                    string nombreCompleto = ObtenerNombreCompleto(maestroId);
                    lblNombreMaestro.Text = "Prof. " + nombreCompleto;

                    // 👇 Username para lblNombreUsuario
                    lblNombreUsuario.Text = "@" + row["Usuario"].ToString();

                    lblEmailValue.Text = row["Email"].ToString();
                    lblTelefonoValue.Text = row["Teléfono"]?.ToString() ?? "N/A";

                    if (row["Fecha Ingreso"] != DBNull.Value)
                        lblFechaIngresoValue.Text = Convert.ToDateTime(row["Fecha Ingreso"])
                                                           .ToString("dd MMMM, yyyy");

                    lblGruposValor.Text = row["Grupos"].ToString();
                    lblEstudiantesValor.Text = row["Estudiantes"].ToString();
                    lblAsistenciaValor.Text = "N/A";
                }
                else
                {
                    MessageBox.Show("No se encontró el maestro con ID: " + maestroId,
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del maestro: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obtiene el nombre completo del maestro usando first_name + last_name
        /// </summary>
        private string ObtenerNombreCompleto(int teacherId)
        {
            string nombre = "";

            string query = @"
                SELECT u.first_name + ' ' + u.last_name AS NombreCompleto
                FROM teachers t
                INNER JOIN users u ON t.user_id = u.user_id
                WHERE t.teacher_id = @teacherId";

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    nombre = result.ToString();
            }

            return nombre;
        }

        private void CargarTarjetasGrupos()
        {
            flpGrupos.Controls.Clear();

            try
            {
                DataTable dt = ObtenerGruposPorMaestro(maestroId);

                if (dt.Rows.Count == 0)
                {
                    Label lblSinGrupos = new Label
                    {
                        Text = "No hay grupos asignados.",
                        AutoSize = true,
                        ForeColor = System.Drawing.Color.Gray
                    };
                    flpGrupos.Controls.Add(lblSinGrupos);
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    int groupId = Convert.ToInt32(row["group_id"]);
                    string nombre = row["group_name"].ToString();
                    int estudiantes = Convert.ToInt32(row["Inscritos"]);
                    string horario = row["schedule"]?.ToString() ?? "Sin horario";
                    string nivel = row["english_level"].ToString();

                    AgregarTarjetaGrupo(groupId, nombre, estudiantes, horario, new[] { nivel });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar grupos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObtenerGruposPorMaestro(int teacherId)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    g.group_id,
                    g.group_name,
                    g.english_level,
                    g.schedule,
                    g.classroom,
                    g.max_capacity,
                    (SELECT COUNT(*) FROM enrollments e 
                     WHERE e.group_id = g.group_id AND e.status = 'activo') AS Inscritos
                FROM groups g
                WHERE g.teacher_id = @teacherId
                ORDER BY g.group_name";

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString))
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                conn.Open();
                new Microsoft.Data.SqlClient.SqlDataAdapter(cmd).Fill(dt);
            }

            return dt;
        }

        private void AgregarTarjetaGrupo(int id, string nombre, int estudiantes,
                                          string horario, string[] materias)
        {
            var tarjeta = new UCTarjetaMisGrupos(id, nombre, estudiantes, horario, materias);

            tarjeta.ClickTarjeta += (s, grupoId) =>
            {
                MessageBox.Show($"Abriendo grupo ID: {grupoId}", "Grupo Seleccionado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            tarjeta.ClickVerEstudiantes += (s, grupoId) =>
            {
                DataTable estudiantes_dt = db.ObtenerEstudiantesPorGrupo(grupoId);
                MessageBox.Show($"Estudiantes en el grupo: {estudiantes_dt.Rows.Count}",
                    "Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            flpGrupos.Controls.Add(tarjeta);
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de edición de perfil", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agregar nuevo grupo", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarHorario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Editar horario de clases", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            DataTable dt = db.ObtenerEstudiantesPorMaestro(maestroId);
            MessageBox.Show($"Total de estudiantes: {dt.Rows.Count}",
                "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tomar asistencia", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Subir material didáctico", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panelGrupos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}