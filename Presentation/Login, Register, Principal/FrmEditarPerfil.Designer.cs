using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation
{
    partial class FrmEditarPerfil
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label accentBar;
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTituloHeader;
        private Guna2Button btnVolver;
        private Guna2Panel cardInfo;
        private Guna2HtmlLabel lblAvatar;
        private Guna2HtmlLabel lblNombreCard;
        private Guna2HtmlLabel lblRolBadge;
        private Guna2HtmlLabel lblFechaCard;
        private Guna2Panel cardDatos;
        private Guna2HtmlLabel lblSecDatos;
        private Guna2HtmlLabel lblLUsuario;
        private Guna2TextBox txtUsuario;
        private Guna2HtmlLabel lblLEmail;
        private Guna2TextBox txtEmail;
        private Guna2HtmlLabel lblLTelefono;
        private Guna2TextBox txtTelefono;
        private Guna2Button btnGuardar;
        private Guna2Panel cardPass;
        private Guna2HtmlLabel lblSecPass;
        private Guna2HtmlLabel lblLPassActual;
        private Guna2TextBox txtPassActual;
        private Guna2HtmlLabel lblLPassNueva;
        private Guna2TextBox txtPassNueva;
        private Guna2HtmlLabel lblLPassConfirmar;
        private Guna2TextBox txtPassConfirmar;
        private Guna2Button btnCambiarPass;
        private Guna2HtmlLabel lblBanner;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var ce1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            accentBar = new System.Windows.Forms.Label();
            panelHeader = new Guna2Panel();
            lblTituloHeader = new Guna2HtmlLabel();
            btnVolver = new Guna2Button();
            cardInfo = new Guna2Panel();
            lblAvatar = new Guna2HtmlLabel();
            lblNombreCard = new Guna2HtmlLabel();
            lblRolBadge = new Guna2HtmlLabel();
            lblFechaCard = new Guna2HtmlLabel();
            cardDatos = new Guna2Panel();
            lblSecDatos = new Guna2HtmlLabel();
            lblLUsuario = new Guna2HtmlLabel();
            txtUsuario = new Guna2TextBox();
            lblLEmail = new Guna2HtmlLabel();
            txtEmail = new Guna2TextBox();
            lblLTelefono = new Guna2HtmlLabel();
            txtTelefono = new Guna2TextBox();
            btnGuardar = new Guna2Button();
            cardPass = new Guna2Panel();
            lblSecPass = new Guna2HtmlLabel();
            lblLPassActual = new Guna2HtmlLabel();
            txtPassActual = new Guna2TextBox();
            lblLPassNueva = new Guna2HtmlLabel();
            txtPassNueva = new Guna2TextBox();
            lblLPassConfirmar = new Guna2HtmlLabel();
            txtPassConfirmar = new Guna2TextBox();
            btnCambiarPass = new Guna2Button();
            lblBanner = new Guna2HtmlLabel();

            panelHeader.SuspendLayout();
            cardInfo.SuspendLayout();
            cardDatos.SuspendLayout();
            cardPass.SuspendLayout();
            SuspendLayout();

            // ════════════ ACCENT BAR ════════════
            accentBar.BackColor = Color.FromArgb(255, 60, 120);
            accentBar.Location = new Point(0, 0);
            accentBar.Name = "accentBar";
            accentBar.Size = new Size(5, 70);
            accentBar.Text = "";
            accentBar.TabIndex = 99;

            // ════════════ HEADER ════════════
            lblTituloHeader.AutoSize = false;
            lblTituloHeader.BackColor = Color.Transparent;
            lblTituloHeader.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lblTituloHeader.ForeColor = Color.FromArgb(25, 25, 35);
            lblTituloHeader.Location = new Point(18, 18);
            lblTituloHeader.Name = "lblTituloHeader";
            lblTituloHeader.Size = new Size(400, 30);
            lblTituloHeader.TabIndex = 0;
            lblTituloHeader.Text = "✏️ Editar Perfil";

            btnVolver.BorderRadius = 18;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.CustomizableEdges = ce1;
            btnVolver.FillColor = Color.FromArgb(240, 235, 225);
            btnVolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVolver.ForeColor = Color.FromArgb(120, 110, 90);
            btnVolver.HoverState.FillColor = Color.FromArgb(225, 215, 200);
            btnVolver.Location = new Point(678, 16);
            btnVolver.Name = "btnVolver";
            btnVolver.ShadowDecoration.CustomizableEdges = ce2;
            btnVolver.ShadowDecoration.Enabled = false;
            btnVolver.Size = new Size(158, 38);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "← Volver al perfil";
            btnVolver.Click += new System.EventHandler(btnVolver_Click);

            panelHeader.CustomizableEdges = ce3;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.White;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = ce4;
            panelHeader.ShadowDecoration.Color = Color.FromArgb(14, 0, 0, 0);
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(854, 70);
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(accentBar);
            panelHeader.Controls.Add(lblTituloHeader);
            panelHeader.Controls.Add(btnVolver);

            // ════════════ CARD INFO ════════════
            lblAvatar.AutoSize = false;
            lblAvatar.BackColor = Color.Transparent;
            lblAvatar.Font = new Font("Segoe UI Emoji", 44F);
            lblAvatar.ForeColor = Color.FromArgb(25, 25, 35);
            lblAvatar.Location = new Point(18, 12);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(72, 72);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "🎓";
            lblAvatar.TextAlignment = ContentAlignment.MiddleCenter;

            lblNombreCard.AutoSize = false;
            lblNombreCard.BackColor = Color.Transparent;
            lblNombreCard.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lblNombreCard.ForeColor = Color.FromArgb(25, 25, 35);
            lblNombreCard.Location = new Point(104, 14);
            lblNombreCard.Name = "lblNombreCard";
            lblNombreCard.Size = new Size(280, 26);
            lblNombreCard.TabIndex = 1;
            lblNombreCard.Text = "@usuario";

            lblRolBadge.AutoSize = false;
            lblRolBadge.BackColor = Color.Transparent;
            lblRolBadge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRolBadge.ForeColor = Color.FromArgb(255, 60, 120);
            lblRolBadge.Location = new Point(104, 44);
            lblRolBadge.Name = "lblRolBadge";
            lblRolBadge.Size = new Size(120, 18);
            lblRolBadge.TabIndex = 2;
            lblRolBadge.Text = "Estudiante";

            lblFechaCard.AutoSize = false;
            lblFechaCard.BackColor = Color.Transparent;
            lblFechaCard.Font = new Font("Segoe UI", 8.5F);
            lblFechaCard.ForeColor = Color.FromArgb(160, 150, 130);
            lblFechaCard.Location = new Point(104, 66);
            lblFechaCard.Name = "lblFechaCard";
            lblFechaCard.Size = new Size(220, 18);
            lblFechaCard.TabIndex = 3;
            lblFechaCard.Text = "📅 Desde 01/01/2025";

            cardInfo.BorderRadius = 16;
            cardInfo.CustomizableEdges = ce5;
            cardInfo.FillColor = Color.White;
            cardInfo.Location = new Point(20, 86);
            cardInfo.Name = "cardInfo";
            cardInfo.ShadowDecoration.CustomizableEdges = ce6;
            cardInfo.ShadowDecoration.Color = Color.FromArgb(16, 0, 0, 0);
            cardInfo.ShadowDecoration.Depth = 8;
            cardInfo.ShadowDecoration.Enabled = true;
            cardInfo.Size = new Size(820, 100);
            cardInfo.TabIndex = 1;
            cardInfo.Controls.Add(lblAvatar);
            cardInfo.Controls.Add(lblNombreCard);
            cardInfo.Controls.Add(lblRolBadge);
            cardInfo.Controls.Add(lblFechaCard);

            // ════════════ CARD DATOS ════════════
            lblSecDatos.AutoSize = false;
            lblSecDatos.BackColor = Color.Transparent;
            lblSecDatos.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            lblSecDatos.ForeColor = Color.FromArgb(25, 25, 35);
            lblSecDatos.Location = new Point(18, 14);
            lblSecDatos.Name = "lblSecDatos";
            lblSecDatos.Size = new Size(320, 24);
            lblSecDatos.TabIndex = 0;
            lblSecDatos.Text = "✏️ Datos personales";

            lblLUsuario.AutoSize = false;
            lblLUsuario.BackColor = Color.Transparent;
            lblLUsuario.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblLUsuario.ForeColor = Color.FromArgb(130, 120, 100);
            lblLUsuario.Location = new Point(18, 46);
            lblLUsuario.Name = "lblLUsuario";
            lblLUsuario.Size = new Size(220, 16);
            lblLUsuario.TabIndex = 1;
            lblLUsuario.Text = "USUARIO (no editable)";

            txtUsuario.BorderRadius = 10;
            txtUsuario.CustomizableEdges = ce7;
            txtUsuario.DefaultText = "";
            txtUsuario.FillColor = Color.FromArgb(245, 242, 235);
            txtUsuario.Font = new Font("Segoe UI", 10.5F);
            txtUsuario.Location = new Point(18, 64);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.SelectedText = "";
            txtUsuario.ShadowDecoration.CustomizableEdges = ce8;
            txtUsuario.Size = new Size(380, 38);
            txtUsuario.TabIndex = 2;

            lblLEmail.AutoSize = false;
            lblLEmail.BackColor = Color.Transparent;
            lblLEmail.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblLEmail.ForeColor = Color.FromArgb(130, 120, 100);
            lblLEmail.Location = new Point(18, 110);
            lblLEmail.Name = "lblLEmail";
            lblLEmail.Size = new Size(80, 16);
            lblLEmail.TabIndex = 3;
            lblLEmail.Text = "EMAIL *";

            txtEmail.BorderRadius = 10;
            txtEmail.CustomizableEdges = ce9;
            txtEmail.DefaultText = "";
            txtEmail.FillColor = Color.White;
            txtEmail.FocusedState.BorderColor = Color.FromArgb(255, 183, 0);
            txtEmail.Font = new Font("Segoe UI", 10.5F);
            txtEmail.Location = new Point(18, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = ce10;
            txtEmail.Size = new Size(784, 38);
            txtEmail.TabIndex = 4;

            lblLTelefono.AutoSize = false;
            lblLTelefono.BackColor = Color.Transparent;
            lblLTelefono.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblLTelefono.ForeColor = Color.FromArgb(130, 120, 100);
            lblLTelefono.Location = new Point(18, 174);
            lblLTelefono.Name = "lblLTelefono";
            lblLTelefono.Size = new Size(240, 16);
            lblLTelefono.TabIndex = 5;
            lblLTelefono.Text = "TELÉFONO  (809 / 829 / 849)";

            txtTelefono.BorderRadius = 10;
            txtTelefono.CustomizableEdges = ce11;
            txtTelefono.DefaultText = "";
            txtTelefono.FillColor = Color.White;
            txtTelefono.FocusedState.BorderColor = Color.FromArgb(255, 183, 0);
            txtTelefono.Font = new Font("Segoe UI", 10.5F);
            txtTelefono.Location = new Point(18, 192);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.SelectedText = "";
            txtTelefono.ShadowDecoration.CustomizableEdges = ce12;
            txtTelefono.Size = new Size(380, 38);
            txtTelefono.TabIndex = 6;

            btnGuardar.BorderRadius = 20;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.CustomizableEdges = ce13;
            btnGuardar.FillColor = Color.FromArgb(255, 183, 0);
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.HoverState.FillColor = Color.FromArgb(220, 155, 0);
            btnGuardar.Location = new Point(638, 192);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.ShadowDecoration.CustomizableEdges = ce14;
            btnGuardar.ShadowDecoration.Color = Color.FromArgb(35, 255, 183, 0);
            btnGuardar.ShadowDecoration.Depth = 5;
            btnGuardar.ShadowDecoration.Enabled = true;
            btnGuardar.Size = new Size(164, 38);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "💾 Guardar datos";
            btnGuardar.Click += new System.EventHandler(btnGuardar_Click);

            cardDatos.BorderRadius = 16;
            cardDatos.CustomizableEdges = ce15;
            cardDatos.FillColor = Color.White;
            cardDatos.Location = new Point(20, 200);
            cardDatos.Name = "cardDatos";
            cardDatos.ShadowDecoration.CustomizableEdges = ce16;
            cardDatos.ShadowDecoration.Color = Color.FromArgb(16, 0, 0, 0);
            cardDatos.ShadowDecoration.Depth = 8;
            cardDatos.ShadowDecoration.Enabled = true;
            cardDatos.Size = new Size(820, 246);
            cardDatos.TabIndex = 2;
            cardDatos.Controls.Add(lblSecDatos);
            cardDatos.Controls.Add(lblLUsuario);
            cardDatos.Controls.Add(txtUsuario);
            cardDatos.Controls.Add(lblLEmail);
            cardDatos.Controls.Add(txtEmail);
            cardDatos.Controls.Add(lblLTelefono);
            cardDatos.Controls.Add(txtTelefono);
            cardDatos.Controls.Add(btnGuardar);

            // ════════════ CARD CONTRASEÑA ════════════
            lblSecPass.AutoSize = false;
            lblSecPass.BackColor = Color.Transparent;
            lblSecPass.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            lblSecPass.ForeColor = Color.FromArgb(25, 25, 35);
            lblSecPass.Location = new Point(18, 14);
            lblSecPass.Name = "lblSecPass";
            lblSecPass.Size = new Size(320, 24);
            lblSecPass.TabIndex = 0;
            lblSecPass.Text = "🔒 Cambiar contraseña";

            lblLPassActual.AutoSize = false;
            lblLPassActual.BackColor = Color.Transparent;
            lblLPassActual.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblLPassActual.ForeColor = Color.FromArgb(130, 120, 100);
            lblLPassActual.Location = new Point(18, 46);
            lblLPassActual.Name = "lblLPassActual";
            lblLPassActual.Size = new Size(170, 16);
            lblLPassActual.TabIndex = 1;
            lblLPassActual.Text = "CONTRASEÑA ACTUAL";

            txtPassActual.BorderRadius = 10;
            txtPassActual.CustomizableEdges = ce17;
            txtPassActual.DefaultText = "";
            txtPassActual.FillColor = Color.White;
            txtPassActual.FocusedState.BorderColor = Color.FromArgb(255, 60, 120);
            txtPassActual.Font = new Font("Segoe UI", 10.5F);
            txtPassActual.Location = new Point(18, 64);
            txtPassActual.Name = "txtPassActual";
            txtPassActual.SelectedText = "";
            txtPassActual.ShadowDecoration.CustomizableEdges = ce18;
            txtPassActual.Size = new Size(260, 38);
            txtPassActual.TabIndex = 2;
            txtPassActual.UseSystemPasswordChar = true;

            lblLPassNueva.AutoSize = false;
            lblLPassNueva.BackColor = Color.Transparent;
            lblLPassNueva.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblLPassNueva.ForeColor = Color.FromArgb(130, 120, 100);
            lblLPassNueva.Location = new Point(18, 110);
            lblLPassNueva.Name = "lblLPassNueva";
            lblLPassNueva.Size = new Size(380, 16);
            lblLPassNueva.TabIndex = 3;
            lblLPassNueva.Text = "NUEVA CONTRASEÑA  (mín. 6 · letras+números)";

            txtPassNueva.BorderRadius = 10;
            txtPassNueva.CustomizableEdges = ce19;
            txtPassNueva.DefaultText = "";
            txtPassNueva.FillColor = Color.White;
            txtPassNueva.FocusedState.BorderColor = Color.FromArgb(255, 60, 120);
            txtPassNueva.Font = new Font("Segoe UI", 10.5F);
            txtPassNueva.Location = new Point(18, 128);
            txtPassNueva.Name = "txtPassNueva";
            txtPassNueva.SelectedText = "";
            txtPassNueva.ShadowDecoration.CustomizableEdges = ce20;
            txtPassNueva.Size = new Size(380, 38);
            txtPassNueva.TabIndex = 4;
            txtPassNueva.UseSystemPasswordChar = true;

            lblLPassConfirmar.AutoSize = false;
            lblLPassConfirmar.BackColor = Color.Transparent;
            lblLPassConfirmar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblLPassConfirmar.ForeColor = Color.FromArgb(130, 120, 100);
            lblLPassConfirmar.Location = new Point(18, 174);
            lblLPassConfirmar.Name = "lblLPassConfirmar";
            lblLPassConfirmar.Size = new Size(260, 16);
            lblLPassConfirmar.TabIndex = 5;
            lblLPassConfirmar.Text = "CONFIRMAR NUEVA CONTRASEÑA";

            txtPassConfirmar.BorderRadius = 10;
            txtPassConfirmar.CustomizableEdges = ce21;
            txtPassConfirmar.DefaultText = "";
            txtPassConfirmar.FillColor = Color.White;
            txtPassConfirmar.FocusedState.BorderColor = Color.FromArgb(255, 60, 120);
            txtPassConfirmar.Font = new Font("Segoe UI", 10.5F);
            txtPassConfirmar.Location = new Point(18, 192);
            txtPassConfirmar.Name = "txtPassConfirmar";
            txtPassConfirmar.SelectedText = "";
            txtPassConfirmar.ShadowDecoration.CustomizableEdges = ce22;
            txtPassConfirmar.Size = new Size(380, 38);
            txtPassConfirmar.TabIndex = 6;
            txtPassConfirmar.UseSystemPasswordChar = true;

            btnCambiarPass.BorderRadius = 20;
            btnCambiarPass.Cursor = Cursors.Hand;
            btnCambiarPass.CustomizableEdges = ce23;
            btnCambiarPass.FillColor = Color.FromArgb(255, 60, 120);
            btnCambiarPass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCambiarPass.ForeColor = Color.White;
            btnCambiarPass.HoverState.FillColor = Color.FromArgb(220, 40, 100);
            btnCambiarPass.Location = new Point(570, 192);
            btnCambiarPass.Name = "btnCambiarPass";
            btnCambiarPass.ShadowDecoration.CustomizableEdges = ce24;
            btnCambiarPass.ShadowDecoration.Color = Color.FromArgb(35, 255, 60, 120);
            btnCambiarPass.ShadowDecoration.Depth = 5;
            btnCambiarPass.ShadowDecoration.Enabled = true;
            btnCambiarPass.Size = new Size(232, 38);
            btnCambiarPass.TabIndex = 7;
            btnCambiarPass.Text = "🔑 Cambiar contraseña";
            btnCambiarPass.Click += new System.EventHandler(btnCambiarPass_Click);

            cardPass.BorderRadius = 16;
            cardPass.CustomizableEdges = ce25;
            cardPass.FillColor = Color.White;
            cardPass.Location = new Point(20, 460);
            cardPass.Name = "cardPass";
            cardPass.ShadowDecoration.CustomizableEdges = ce26;
            cardPass.ShadowDecoration.Color = Color.FromArgb(16, 0, 0, 0);
            cardPass.ShadowDecoration.Depth = 8;
            cardPass.ShadowDecoration.Enabled = true;
            cardPass.Size = new Size(820, 246);
            cardPass.TabIndex = 3;
            cardPass.Controls.Add(lblSecPass);
            cardPass.Controls.Add(lblLPassActual);
            cardPass.Controls.Add(txtPassActual);
            cardPass.Controls.Add(lblLPassNueva);
            cardPass.Controls.Add(txtPassNueva);
            cardPass.Controls.Add(lblLPassConfirmar);
            cardPass.Controls.Add(txtPassConfirmar);
            cardPass.Controls.Add(btnCambiarPass);

            // ════════════ BANNER ════════════
            lblBanner.AutoSize = false;
            lblBanner.BackColor = Color.FromArgb(200, 255, 220);
            lblBanner.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBanner.ForeColor = Color.FromArgb(20, 120, 60);
            lblBanner.Location = new Point(20, 720);
            lblBanner.Name = "lblBanner";
            lblBanner.Size = new Size(820, 38);
            lblBanner.TabIndex = 4;
            lblBanner.Text = "";
            lblBanner.TextAlignment = ContentAlignment.MiddleCenter;
            lblBanner.Visible = false;

            // ════════════ FORM ════════════
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(252, 248, 240);
            ClientSize = new Size(854, 772);
            Controls.Add(cardInfo);
            Controls.Add(cardDatos);
            Controls.Add(cardPass);
            Controls.Add(lblBanner);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarPerfil";
            Text = "Editar Perfil";
            Load += new System.EventHandler(FrmEditarPerfil_Load);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            cardInfo.ResumeLayout(false);
            cardInfo.PerformLayout();
            cardDatos.ResumeLayout(false);
            cardDatos.PerformLayout();
            cardPass.ResumeLayout(false);
            cardPass.PerformLayout();
            ResumeLayout(false);
        }
    }
}