using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmPerfilAdmin : Form
    {
        private int adminId;
        private DatabaseHelper db = new DatabaseHelper();

        public FrmPerfilAdmin(int idAdmin)
        {
            InitializeComponent();
            this.adminId = idAdmin;
            this.Text = "Perfil del Administrador";
            CargarDatosAdmin();
            CargarEstadisticas();
        }

        private void CargarDatosAdmin()
        {
            try
            {
                string nombreCompleto = ObtenerNombreCompleto();
                lblNombreAdmin.Text = nombreCompleto;

                string query = @"
                    SELECT u.username, u.email, u.phone, u.created_at
                    FROM users u
                    WHERE u.user_id = @userId AND u.user_role IN ('admin', 'administrador')";

                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", adminId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblUsuarioValue.Text = "@" + reader["username"].ToString();
                            lblEmailValue.Text = reader["email"].ToString();
                            lblTelefonoValue.Text = reader["phone"]?.ToString() ?? "N/A";
                            if (reader["created_at"] != DBNull.Value)
                                lblFechaIngresoValue.Text = Convert.ToDateTime(reader["created_at"])
                                                                   .ToString("dd MMM, yyyy");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del admin: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerNombreCompleto()
        {
            string nombre = "Administrador";
            string query = "SELECT username FROM users WHERE user_id = @userId";
            using (var conn = new SqlConnection(db.ConnectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", adminId);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    nombre = result.ToString();
            }
            return nombre;
        }

        private void CargarEstadisticas()
        {
            try
            {
                int totalMaestros = Contar("SELECT COUNT(*) FROM teachers");
                int totalEstudiantes = Contar("SELECT COUNT(*) FROM students");
                int totalGrupos = Contar("SELECT COUNT(*) FROM groups");
                int totalLecciones = Contar("SELECT COUNT(*) FROM lessons WHERE is_active = 1");
                int totalPersonas = totalMaestros + totalEstudiantes + totalGrupos + totalLecciones;

                lblTotalMaestrosValor.Text = totalMaestros.ToString();
                lblTotalEstudiantesValor.Text = totalEstudiantes.ToString();
                lblTotalGruposValor.Text = totalGrupos.ToString();
                lblTotalLeccionesValor.Text = totalLecciones.ToString();

                dgvResumen.Rows.Clear();
                if (totalPersonas > 0)
                {
                    dgvResumen.Rows.Add("Maestros", totalMaestros, $"{totalMaestros * 100 / totalPersonas}%");
                    dgvResumen.Rows.Add("Estudiantes", totalEstudiantes, $"{totalEstudiantes * 100 / totalPersonas}%");
                    dgvResumen.Rows.Add("Grupos", totalGrupos, $"{totalGrupos * 100 / totalPersonas}%");
                    dgvResumen.Rows.Add("Lecciones", totalLecciones, $"{totalLecciones * 100 / totalPersonas}%");
                }

                int maxVal = Math.Max(Math.Max(totalMaestros, totalEstudiantes), totalGrupos);
                int maxAncho = 220;
                if (maxVal > 0)
                {
                    barraMaestros.Width = Math.Max(60, totalMaestros * maxAncho / maxVal);
                    barraEstudiantes.Width = Math.Max(60, totalEstudiantes * maxAncho / maxVal);
                    barraGrupos.Width = Math.Max(60, totalGrupos * maxAncho / maxVal);
                }
                lblBarraMaestros.Text = $"Maestros {totalMaestros}";
                lblBarraEstudiantes.Text = $"Estudiantes {totalEstudiantes}";
                lblBarraGrupos.Text = $"Grupos {totalGrupos}";

                lblUltimoAccesoValue.Text = DateTime.Now.ToString("dd MMM yyyy, hh:mm tt");
                lblTotalUsuariosValue.Text = (totalMaestros + totalEstudiantes).ToString();
                lblSistemaValue.Text = "✅ En línea";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estadísticas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int Contar(string query)
        {
            using (var conn = new SqlConnection(db.ConnectionString))
            using (var cmd = new SqlCommand(query, conn))
            { conn.Open(); return (int)cmd.ExecuteScalar(); }
        }

        // ── Botón Editar Perfil ────────────────────────────────
        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = this.Parent?.FindForm() as FrmPrincipal
                                  ?? Application.OpenForms["FrmPrincipal"] as FrmPrincipal;
            if (principal != null)
                principal.AbrirFormEnPanel(new FrmEditarPerfil(adminId, "ADMIN", principal));
            else
            {
                using var frm = new FrmEditarPerfil(adminId, "ADMIN");
                frm.ShowDialog();
                CargarDatosAdmin();
            }
        }

        private void btnGestionMaestros_Click(object sender, EventArgs e) => AbrirForm(new FrmGestionMaestros());
        private void btnGestionEstudiantes_Click(object sender, EventArgs e) => AbrirForm(new FrmGestionEstudiantes());
        private void btnGestionGrupos_Click(object sender, EventArgs e) => AbrirForm(new FrmGestionGrupos());

        private void AbrirForm(Form form)
        {
            if (this.Parent?.FindForm() is FrmPrincipal p) p.AbrirFormEnPanel(form);
            else form.Show();
        }
    }
}