using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentation
{
    public partial class FrmEditarPerfil : Form
    {
        private readonly DatabaseHelper db = new DatabaseHelper();
        private readonly int userId;
        private readonly string rol;
        private readonly FrmPrincipal frmPrincipal;

        public FrmEditarPerfil(int userId, string rol, FrmPrincipal frmPrincipal = null)
        {
            InitializeComponent();
            this.userId = userId;
            this.rol = rol?.ToUpper().Trim() ?? "";
            this.frmPrincipal = frmPrincipal;
        }

        private void FrmEditarPerfil_Load(object sender, EventArgs e)
        {
            ConfigurarRol();
            CargarDatos();
        }

        private void ConfigurarRol()
        {
            Color color = rol switch
            {
                "MAESTRO" or "TEACHER" => Color.FromArgb(255, 183, 0),
                "ADMIN" or "ADMINISTRADOR" => Color.FromArgb(102, 126, 234),
                _ => Color.FromArgb(255, 60, 120)
            };
            string emoji = rol switch
            {
                "MAESTRO" or "TEACHER" => "👩‍🏫",
                "ADMIN" or "ADMINISTRADOR" => "🛡️",
                _ => "🎓"
            };
            accentBar.BackColor = color;
            btnGuardar.FillColor = color;
            btnGuardar.HoverState.FillColor = Oscurecer(color, 30);
            lblAvatar.Text = emoji;
            lblRolBadge.ForeColor = color;
            lblRolBadge.Text = RolTexto();
        }

        private Color Oscurecer(Color c, int d) =>
            Color.FromArgb(Math.Max(c.R - d, 0), Math.Max(c.G - d, 0), Math.Max(c.B - d, 0));

        private string RolTexto() => rol switch
        {
            "MAESTRO" or "TEACHER" => "Maestro",
            "ADMIN" or "ADMINISTRADOR" => "Administrador",
            _ => "Estudiante"
        };

        private void CargarDatos()
        {
            try
            {
                using var conn = new SqlConnection(db.ConnectionString);
                using var cmd = new SqlCommand(
                    "SELECT username, email, ISNULL(phone,''), created_at FROM users WHERE user_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", userId);
                conn.Open();
                using var r = cmd.ExecuteReader();
                if (!r.Read()) return;

                txtUsuario.Text = r.GetString(0);
                txtEmail.Text = r.GetString(1);
                txtTelefono.Text = r.GetString(2);
                lblNombreCard.Text = "@" + r.GetString(0);
                lblFechaCard.Text = "📅 Desde " + Convert.ToDateTime(r[3]).ToString("dd/MM/yyyy");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;
            try
            {
                using var conn = new SqlConnection(db.ConnectionString);
                using var cmd = new SqlCommand(
                    "UPDATE users SET email=@e, phone=@p WHERE user_id=@id", conn);
                cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtTelefono.Text.Trim());
                cmd.Parameters.AddWithValue("@id", userId);
                conn.Open(); cmd.ExecuteNonQuery();
                Banner("✅ Datos actualizados correctamente.", true);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            if (!ValidarPass()) return;
            try
            {
                using var conn = new SqlConnection(db.ConnectionString);
                conn.Open();
                using var chk = new SqlCommand(
                    "SELECT COUNT(1) FROM users WHERE user_id=@id AND password=@p", conn);
                chk.Parameters.AddWithValue("@id", userId);
                chk.Parameters.AddWithValue("@p", txtPassActual.Text);
                if ((int)chk.ExecuteScalar() == 0)
                { Banner("❌ La contraseña actual es incorrecta.", false); return; }

                using var upd = new SqlCommand(
                    "UPDATE users SET password=@p WHERE user_id=@id", conn);
                upd.Parameters.AddWithValue("@p", txtPassNueva.Text);
                upd.Parameters.AddWithValue("@id", userId);
                upd.ExecuteNonQuery();
                txtPassActual.Text = txtPassNueva.Text = txtPassConfirmar.Text = "";
                Banner("✅ Contraseña cambiada correctamente.", true);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (frmPrincipal == null) { Close(); return; }
            // Volver al perfil del rol correspondiente
            frmPrincipal.AbrirFormEnPanel(CrearFormPerfil());
        }

        private Form CrearFormPerfil()
        {
            try
            {
                using var conn = new SqlConnection(db.ConnectionString);
                conn.Open();
                if (rol is "MAESTRO" or "TEACHER")
                {
                    using var cmd = new SqlCommand(
                        "SELECT teacher_id FROM teachers WHERE user_id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    var r = cmd.ExecuteScalar();
                    if (r != null)
                        return new Seccion_de_Maestros.FrmPerfilMaestro(Convert.ToInt32(r));
                }
                else if (rol is "ESTUDIANTE" or "STUDENT")
                {
                    using var cmd = new SqlCommand(
                        "SELECT student_id FROM students WHERE user_id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    var r = cmd.ExecuteScalar();
                    if (r != null)
                        return new Seccion_de_Estudiantes.FrmPerfilEstudiante(Convert.ToInt32(r));
                }
                else // ADMIN
                {
                    return new Seccion_de_Administrador.FrmPerfilAdmin(userId);
                }
            }
            catch { }
            return new Seccion_de_Administrador.FrmPerfilAdmin(userId);
        }

        private bool ValidarDatos()
        {
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            { Banner("❌ Email inválido.", false); txtEmail.Focus(); return false; }
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                !Regex.IsMatch(txtTelefono.Text.Trim(),
                    @"^(\+?1[\s\-]?)?(809|829|849)[\s\-]?\d{3}[\s\-]?\d{4}$"))
            { Banner("❌ Teléfono inválido (809/829/849-XXX-XXXX).", false); txtTelefono.Focus(); return false; }
            return true;
        }

        private bool ValidarPass()
        {
            if (string.IsNullOrWhiteSpace(txtPassActual.Text))
            { Banner("❌ Ingresa tu contraseña actual.", false); return false; }
            if (txtPassNueva.Text.Length < 6)
            { Banner("❌ Mínimo 6 caracteres.", false); return false; }
            if (!Regex.IsMatch(txtPassNueva.Text, @"^(?=.*[a-zA-Z])(?=.*\d).+$"))
            { Banner("❌ Debe tener letras y números.", false); return false; }
            if (txtPassNueva.Text != txtPassConfirmar.Text)
            { Banner("❌ Las contraseñas no coinciden.", false); return false; }
            return true;
        }

        private void Banner(string msg, bool ok)
        {
            lblBanner.Text = msg;
            lblBanner.BackColor = ok ? Color.FromArgb(200, 255, 220) : Color.FromArgb(255, 215, 215);
            lblBanner.ForeColor = ok ? Color.FromArgb(20, 120, 60) : Color.FromArgb(160, 30, 30);
            lblBanner.Visible = true;
            var t = new System.Windows.Forms.Timer { Interval = 3500 };
            t.Tick += (s, e) => { lblBanner.Visible = false; t.Stop(); t.Dispose(); };
            t.Start();
        }
    }
}