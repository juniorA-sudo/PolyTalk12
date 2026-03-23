using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentation.Seccion_de_Maestros
{
    public partial class FrmPerfilMaestro : Form
    {
        private int maestroId;
        private int userId;
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
                string query = @"
                    SELECT u.user_id, u.username, u.email,
                           ISNULL(u.phone,'') AS phone, t.hire_date,
                           (SELECT COUNT(*) FROM groups WHERE teacher_id = t.teacher_id) AS Grupos,
                           (SELECT COUNT(*) FROM enrollments e
                            INNER JOIN groups g ON e.group_id = g.group_id
                            WHERE g.teacher_id = t.teacher_id) AS Estudiantes
                    FROM teachers t
                    INNER JOIN users u ON t.user_id = u.user_id
                    WHERE t.teacher_id = @teacherId";

                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherId", maestroId);
                    conn.Open();
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            userId = Convert.ToInt32(r["user_id"]);

                            lblNombreMaestro.Text = "Prof. " + r["username"].ToString();
                            lblNombreUsuario.Text = "@" + r["username"].ToString();
                            lblEmailValue.Text = r["email"].ToString();
                            lblTelefonoValue.Text = r["phone"]?.ToString() ?? "N/A";

                            if (r["hire_date"] != DBNull.Value)
                                lblFechaIngresoValue.Text = Convert.ToDateTime(r["hire_date"])
                                                                   .ToString("dd MMMM, yyyy");

                            lblGruposValor.Text = r["Grupos"].ToString();
                            lblEstudiantesValor.Text = r["Estudiantes"].ToString();
                            lblAsistenciaValor.Text = "N/A";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del maestro: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTarjetasGrupos()
        {
            flpGrupos.Controls.Clear();
            try
            {
                string query = @"
                    SELECT g.group_id, g.group_name, g.english_level, g.schedule,
                           (SELECT COUNT(*) FROM enrollments e
                            WHERE e.group_id = g.group_id AND e.status = 'activo') AS Inscritos
                    FROM groups g
                    WHERE g.teacher_id = @teacherId
                    ORDER BY g.group_name";

                DataTable dt = new DataTable();
                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherId", maestroId);
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }

                if (dt.Rows.Count == 0)
                {
                    flpGrupos.Controls.Add(new Label
                    {
                        Text = "No hay grupos asignados.",
                        AutoSize = true,
                        ForeColor = Color.Gray
                    });
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    var tarjeta = new UCTarjetaMisGrupos(
                        Convert.ToInt32(row["group_id"]),
                        row["group_name"].ToString(),
                        Convert.ToInt32(row["Inscritos"]),
                        row["schedule"]?.ToString() ?? "Sin horario",
                        new[] { row["english_level"].ToString() });

                    tarjeta.ClickTarjeta += (s, id) =>
                        MessageBox.Show($"Grupo ID: {id}", "Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tarjeta.ClickVerEstudiantes += (s, id) =>
                    {
                        DataTable est = db.ObtenerEstudiantesPorGrupo(id);
                        MessageBox.Show($"Estudiantes en el grupo: {est.Rows.Count}",
                            "Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    };

                    flpGrupos.Controls.Add(tarjeta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar grupos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Botón Editar Perfil ─────────────────────────────────
        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = this.Parent?.FindForm() as FrmPrincipal
                                  ?? Application.OpenForms["FrmPrincipal"] as FrmPrincipal;
            if (principal != null)
                principal.AbrirFormEnPanel(new FrmEditarPerfil(userId, "MAESTRO", principal));
            else
            {
                using var frm = new FrmEditarPerfil(userId, "MAESTRO");
                frm.ShowDialog();
                CargarDatosMaestro();
            }
        }

        // Otros botones del Designer existente
        private void btnAgregarGrupo_Click(object sender, EventArgs e) =>
            MessageBox.Show("Agregar nuevo grupo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void btnEditarHorario_Click(object sender, EventArgs e) =>
            MessageBox.Show("Editar horario", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void btnReportes_Click(object sender, EventArgs e) =>
            MessageBox.Show($"Total estudiantes: {db.ObtenerEstudiantesPorMaestro(maestroId).Rows.Count}",
                "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void btnAsistencia_Click(object sender, EventArgs e) =>
            MessageBox.Show("Tomar asistencia", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void btnMaterial_Click(object sender, EventArgs e) =>
            MessageBox.Show("Subir material", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void panelGrupos_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
    }
}