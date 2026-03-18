using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;

namespace Presentation.Seccion_de_Estudiantes
{
    partial class FrmPerfilEstudiante
    {
        private System.ComponentModel.IContainer components = null;

        // Panel principal
        private Guna2Panel panelPrincipal;
        private Guna2Panel panelIzquierdo;
        private Guna2Panel panelDerecho;

        // Avatar y nombre
        private Guna2Panel panelAvatar;
        private IconPictureBox iconAvatar;
        private Guna2HtmlLabel lblNombreEstudiante;
        private Guna2HtmlLabel lblRolEstudiante;

        // Info personal
        private Guna2Panel panelInfoPersonal;
        private Panel pnlEmail;
        private IconPictureBox iconEmail;
        private Guna2HtmlLabel lblEmailLabel;
        private Guna2HtmlLabel lblEmailValue;

        private Panel pnlTelefono;
        private IconPictureBox iconTelefono;
        private Guna2HtmlLabel lblTelefonoLabel;
        private Guna2HtmlLabel lblTelefonoValue;

        private Panel pnlUsuario;
        private IconPictureBox iconUsuario;
        private Guna2HtmlLabel lblUsuarioLabel;
        private Guna2HtmlLabel lblUsuarioValue;

        private Panel pnlFechaIngreso;
        private IconPictureBox iconFechaIngreso;
        private Guna2HtmlLabel lblFechaIngresoLabel;
        private Guna2HtmlLabel lblFechaIngresoValue;

        private Guna2Button btnEditarPerfil;

        // Panel nivel
        private Guna2Panel panelNivel;
        private Guna2HtmlLabel lblTituloNivel;
        private Guna2HtmlLabel lblNivelLabel;
        private Guna2HtmlLabel lblNivelValue;
        private Guna2Panel panelNivelBarra;
        private Guna2HtmlLabel lblNivelDescripcion;

        // Panel grupo
        private Guna2Panel panelGrupo;
        private Guna2HtmlLabel lblTituloGrupo;

        private Panel pnlGrupo;
        private IconPictureBox iconGrupo;
        private Guna2HtmlLabel lblGrupoLabel;
        private Guna2HtmlLabel lblGrupoValue;

        private Panel pnlHorario;
        private IconPictureBox iconHorario;
        private Guna2HtmlLabel lblHorarioLabel;
        private Guna2HtmlLabel lblHorarioValue;

        private Panel pnlMaestro;
        private IconPictureBox iconMaestro;
        private Guna2HtmlLabel lblMaestroLabel;
        private Guna2HtmlLabel lblMaestroValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            CustomizableEdges customizableEdges15 = new CustomizableEdges();
            CustomizableEdges customizableEdges16 = new CustomizableEdges();
            CustomizableEdges customizableEdges7 = new CustomizableEdges();
            CustomizableEdges customizableEdges8 = new CustomizableEdges();
            CustomizableEdges customizableEdges1 = new CustomizableEdges();
            CustomizableEdges customizableEdges2 = new CustomizableEdges();
            CustomizableEdges customizableEdges3 = new CustomizableEdges();
            CustomizableEdges customizableEdges4 = new CustomizableEdges();
            CustomizableEdges customizableEdges5 = new CustomizableEdges();
            CustomizableEdges customizableEdges6 = new CustomizableEdges();
            CustomizableEdges customizableEdges13 = new CustomizableEdges();
            CustomizableEdges customizableEdges14 = new CustomizableEdges();
            CustomizableEdges customizableEdges11 = new CustomizableEdges();
            CustomizableEdges customizableEdges12 = new CustomizableEdges();
            CustomizableEdges customizableEdges9 = new CustomizableEdges();
            CustomizableEdges customizableEdges10 = new CustomizableEdges();
            panelPrincipal = new Guna2Panel();
            panelIzquierdo = new Guna2Panel();
            panelAvatar = new Guna2Panel();
            iconAvatar = new IconPictureBox();
            lblNombreEstudiante = new Guna2HtmlLabel();
            lblRolEstudiante = new Guna2HtmlLabel();
            panelInfoPersonal = new Guna2Panel();
            pnlEmail = new Panel();
            iconEmail = new IconPictureBox();
            lblEmailLabel = new Guna2HtmlLabel();
            lblEmailValue = new Guna2HtmlLabel();
            pnlTelefono = new Panel();
            iconTelefono = new IconPictureBox();
            lblTelefonoLabel = new Guna2HtmlLabel();
            lblTelefonoValue = new Guna2HtmlLabel();
            pnlUsuario = new Panel();
            iconUsuario = new IconPictureBox();
            lblUsuarioLabel = new Guna2HtmlLabel();
            lblUsuarioValue = new Guna2HtmlLabel();
            pnlFechaIngreso = new Panel();
            iconFechaIngreso = new IconPictureBox();
            lblFechaIngresoLabel = new Guna2HtmlLabel();
            lblFechaIngresoValue = new Guna2HtmlLabel();
            btnEditarPerfil = new Guna2Button();
            panelDerecho = new Guna2Panel();
            panelNivel = new Guna2Panel();
            lblTituloNivel = new Guna2HtmlLabel();
            lblNivelLabel = new Guna2HtmlLabel();
            lblNivelValue = new Guna2HtmlLabel();
            panelNivelBarra = new Guna2Panel();
            lblNivelDescripcion = new Guna2HtmlLabel();
            panelGrupo = new Guna2Panel();
            lblTituloGrupo = new Guna2HtmlLabel();
            pnlGrupo = new Panel();
            iconGrupo = new IconPictureBox();
            lblGrupoLabel = new Guna2HtmlLabel();
            lblGrupoValue = new Guna2HtmlLabel();
            pnlHorario = new Panel();
            iconHorario = new IconPictureBox();
            lblHorarioLabel = new Guna2HtmlLabel();
            lblHorarioValue = new Guna2HtmlLabel();
            pnlMaestro = new Panel();
            iconMaestro = new IconPictureBox();
            lblMaestroLabel = new Guna2HtmlLabel();
            lblMaestroValue = new Guna2HtmlLabel();
            panelPrincipal.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAvatar).BeginInit();
            panelInfoPersonal.SuspendLayout();
            pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconEmail).BeginInit();
            pnlTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTelefono).BeginInit();
            pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsuario).BeginInit();
            pnlFechaIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconFechaIngreso).BeginInit();
            panelDerecho.SuspendLayout();
            panelNivel.SuspendLayout();
            panelGrupo.SuspendLayout();
            pnlGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconGrupo).BeginInit();
            pnlHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconHorario).BeginInit();
            pnlMaestro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMaestro).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 247, 237);
            panelPrincipal.Controls.Add(panelIzquierdo);
            panelPrincipal.Controls.Add(panelDerecho);
            panelPrincipal.CustomizableEdges = customizableEdges15;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.FillColor = Color.Transparent;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(20);
            panelPrincipal.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelPrincipal.Size = new Size(854, 535);
            panelPrincipal.TabIndex = 0;
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.Transparent;
            panelIzquierdo.BorderRadius = 20;
            panelIzquierdo.Controls.Add(panelAvatar);
            panelIzquierdo.Controls.Add(lblNombreEstudiante);
            panelIzquierdo.Controls.Add(lblRolEstudiante);
            panelIzquierdo.Controls.Add(panelInfoPersonal);
            panelIzquierdo.Controls.Add(btnEditarPerfil);
            panelIzquierdo.CustomizableEdges = customizableEdges7;
            panelIzquierdo.FillColor = Color.White;
            panelIzquierdo.Location = new Point(20, 20);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.ShadowDecoration.BorderRadius = 15;
            panelIzquierdo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelIzquierdo.ShadowDecoration.Depth = 5;
            panelIzquierdo.ShadowDecoration.Enabled = true;
            panelIzquierdo.Size = new Size(280, 495);
            panelIzquierdo.TabIndex = 0;
            // 
            // panelAvatar
            // 
            panelAvatar.BorderRadius = 60;
            panelAvatar.Controls.Add(iconAvatar);
            panelAvatar.CustomizableEdges = customizableEdges1;
            panelAvatar.FillColor = Color.FromArgb(76, 175, 80);
            panelAvatar.Location = new Point(70, 20);
            panelAvatar.Name = "panelAvatar";
            panelAvatar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelAvatar.Size = new Size(120, 120);
            panelAvatar.TabIndex = 0;
            // 
            // iconAvatar
            // 
            iconAvatar.BackColor = Color.Transparent;
            iconAvatar.IconChar = IconChar.UserGraduate;
            iconAvatar.IconColor = Color.White;
            iconAvatar.IconFont = IconFont.Auto;
            iconAvatar.IconSize = 80;
            iconAvatar.Location = new Point(18, 20);
            iconAvatar.Name = "iconAvatar";
            iconAvatar.Size = new Size(80, 80);
            iconAvatar.TabIndex = 0;
            iconAvatar.TabStop = false;
            // 
            // lblNombreEstudiante
            // 
            lblNombreEstudiante.BackColor = Color.Transparent;
            lblNombreEstudiante.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNombreEstudiante.ForeColor = Color.FromArgb(45, 55, 72);
            lblNombreEstudiante.Location = new Point(20, 150);
            lblNombreEstudiante.Name = "lblNombreEstudiante";
            lblNombreEstudiante.Size = new Size(96, 27);
            lblNombreEstudiante.TabIndex = 1;
            lblNombreEstudiante.Text = "Estudiante";
            lblNombreEstudiante.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblRolEstudiante
            // 
            lblRolEstudiante.BackColor = Color.Transparent;
            lblRolEstudiante.Font = new Font("Segoe UI", 10F);
            lblRolEstudiante.ForeColor = Color.FromArgb(76, 175, 80);
            lblRolEstudiante.Location = new Point(100, 183);
            lblRolEstudiante.Name = "lblRolEstudiante";
            lblRolEstudiante.Size = new Size(63, 19);
            lblRolEstudiante.TabIndex = 2;
            lblRolEstudiante.Text = "Estudiante";
            // 
            // panelInfoPersonal
            // 
            panelInfoPersonal.Controls.Add(pnlEmail);
            panelInfoPersonal.Controls.Add(pnlTelefono);
            panelInfoPersonal.Controls.Add(pnlUsuario);
            panelInfoPersonal.Controls.Add(pnlFechaIngreso);
            panelInfoPersonal.CustomizableEdges = customizableEdges3;
            panelInfoPersonal.FillColor = Color.Transparent;
            panelInfoPersonal.Location = new Point(0, 215);
            panelInfoPersonal.Name = "panelInfoPersonal";
            panelInfoPersonal.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelInfoPersonal.Size = new Size(280, 205);
            panelInfoPersonal.TabIndex = 3;
            // 
            // pnlEmail
            // 
            pnlEmail.Controls.Add(iconEmail);
            pnlEmail.Controls.Add(lblEmailLabel);
            pnlEmail.Controls.Add(lblEmailValue);
            pnlEmail.Location = new Point(20, 5);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(240, 45);
            pnlEmail.TabIndex = 0;
            // 
            // iconEmail
            // 
            iconEmail.BackColor = Color.Transparent;
            iconEmail.ForeColor = Color.FromArgb(76, 175, 80);
            iconEmail.IconChar = IconChar.Envelope;
            iconEmail.IconColor = Color.FromArgb(76, 175, 80);
            iconEmail.IconFont = IconFont.Auto;
            iconEmail.IconSize = 30;
            iconEmail.Location = new Point(0, 7);
            iconEmail.Name = "iconEmail";
            iconEmail.Size = new Size(30, 30);
            iconEmail.TabIndex = 0;
            iconEmail.TabStop = false;
            // 
            // lblEmailLabel
            // 
            lblEmailLabel.BackColor = Color.Transparent;
            lblEmailLabel.Font = new Font("Segoe UI", 9F);
            lblEmailLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblEmailLabel.Location = new Point(38, 5);
            lblEmailLabel.Name = "lblEmailLabel";
            lblEmailLabel.Size = new Size(32, 17);
            lblEmailLabel.TabIndex = 1;
            lblEmailLabel.Text = "Email";
            // 
            // lblEmailValue
            // 
            lblEmailValue.BackColor = Color.Transparent;
            lblEmailValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmailValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblEmailValue.Location = new Point(38, 22);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(122, 17);
            lblEmailValue.TabIndex = 2;
            lblEmailValue.Text = "correo@polytalk.com";
            // 
            // pnlTelefono
            // 
            pnlTelefono.Controls.Add(iconTelefono);
            pnlTelefono.Controls.Add(lblTelefonoLabel);
            pnlTelefono.Controls.Add(lblTelefonoValue);
            pnlTelefono.Location = new Point(20, 55);
            pnlTelefono.Name = "pnlTelefono";
            pnlTelefono.Size = new Size(240, 45);
            pnlTelefono.TabIndex = 1;
            // 
            // iconTelefono
            // 
            iconTelefono.BackColor = Color.Transparent;
            iconTelefono.ForeColor = Color.FromArgb(76, 175, 80);
            iconTelefono.IconChar = IconChar.Phone;
            iconTelefono.IconColor = Color.FromArgb(76, 175, 80);
            iconTelefono.IconFont = IconFont.Auto;
            iconTelefono.IconSize = 30;
            iconTelefono.Location = new Point(0, 7);
            iconTelefono.Name = "iconTelefono";
            iconTelefono.Size = new Size(30, 30);
            iconTelefono.TabIndex = 0;
            iconTelefono.TabStop = false;
            // 
            // lblTelefonoLabel
            // 
            lblTelefonoLabel.BackColor = Color.Transparent;
            lblTelefonoLabel.Font = new Font("Segoe UI", 9F);
            lblTelefonoLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblTelefonoLabel.Location = new Point(38, 5);
            lblTelefonoLabel.Name = "lblTelefonoLabel";
            lblTelefonoLabel.Size = new Size(50, 17);
            lblTelefonoLabel.TabIndex = 1;
            lblTelefonoLabel.Text = "Teléfono";
            // 
            // lblTelefonoValue
            // 
            lblTelefonoValue.BackColor = Color.Transparent;
            lblTelefonoValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefonoValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblTelefonoValue.Location = new Point(38, 22);
            lblTelefonoValue.Name = "lblTelefonoValue";
            lblTelefonoValue.Size = new Size(25, 17);
            lblTelefonoValue.TabIndex = 2;
            lblTelefonoValue.Text = "N/A";
            // 
            // pnlUsuario
            // 
            pnlUsuario.Controls.Add(iconUsuario);
            pnlUsuario.Controls.Add(lblUsuarioLabel);
            pnlUsuario.Controls.Add(lblUsuarioValue);
            pnlUsuario.Location = new Point(20, 105);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(240, 45);
            pnlUsuario.TabIndex = 2;
            // 
            // iconUsuario
            // 
            iconUsuario.BackColor = Color.Transparent;
            iconUsuario.ForeColor = Color.FromArgb(76, 175, 80);
            iconUsuario.IconChar = IconChar.User;
            iconUsuario.IconColor = Color.FromArgb(76, 175, 80);
            iconUsuario.IconFont = IconFont.Auto;
            iconUsuario.IconSize = 30;
            iconUsuario.Location = new Point(0, 7);
            iconUsuario.Name = "iconUsuario";
            iconUsuario.Size = new Size(30, 30);
            iconUsuario.TabIndex = 0;
            iconUsuario.TabStop = false;
            // 
            // lblUsuarioLabel
            // 
            lblUsuarioLabel.BackColor = Color.Transparent;
            lblUsuarioLabel.Font = new Font("Segoe UI", 9F);
            lblUsuarioLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblUsuarioLabel.Location = new Point(38, 5);
            lblUsuarioLabel.Name = "lblUsuarioLabel";
            lblUsuarioLabel.Size = new Size(43, 17);
            lblUsuarioLabel.TabIndex = 1;
            lblUsuarioLabel.Text = "Usuario";
            // 
            // lblUsuarioValue
            // 
            lblUsuarioValue.BackColor = Color.Transparent;
            lblUsuarioValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblUsuarioValue.Location = new Point(38, 22);
            lblUsuarioValue.Name = "lblUsuarioValue";
            lblUsuarioValue.Size = new Size(73, 17);
            lblUsuarioValue.TabIndex = 2;
            lblUsuarioValue.Text = "@estudiante";
            // 
            // pnlFechaIngreso
            // 
            pnlFechaIngreso.Controls.Add(iconFechaIngreso);
            pnlFechaIngreso.Controls.Add(lblFechaIngresoLabel);
            pnlFechaIngreso.Controls.Add(lblFechaIngresoValue);
            pnlFechaIngreso.Location = new Point(20, 155);
            pnlFechaIngreso.Name = "pnlFechaIngreso";
            pnlFechaIngreso.Size = new Size(240, 45);
            pnlFechaIngreso.TabIndex = 3;
            // 
            // iconFechaIngreso
            // 
            iconFechaIngreso.BackColor = Color.Transparent;
            iconFechaIngreso.ForeColor = Color.FromArgb(76, 175, 80);
            iconFechaIngreso.IconChar = IconChar.CalendarDays;
            iconFechaIngreso.IconColor = Color.FromArgb(76, 175, 80);
            iconFechaIngreso.IconFont = IconFont.Auto;
            iconFechaIngreso.IconSize = 30;
            iconFechaIngreso.Location = new Point(0, 7);
            iconFechaIngreso.Name = "iconFechaIngreso";
            iconFechaIngreso.Size = new Size(30, 30);
            iconFechaIngreso.TabIndex = 0;
            iconFechaIngreso.TabStop = false;
            // 
            // lblFechaIngresoLabel
            // 
            lblFechaIngresoLabel.BackColor = Color.Transparent;
            lblFechaIngresoLabel.Font = new Font("Segoe UI", 9F);
            lblFechaIngresoLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblFechaIngresoLabel.Location = new Point(38, 5);
            lblFechaIngresoLabel.Name = "lblFechaIngresoLabel";
            lblFechaIngresoLabel.Size = new Size(76, 17);
            lblFechaIngresoLabel.TabIndex = 1;
            lblFechaIngresoLabel.Text = "Fecha Ingreso";
            // 
            // lblFechaIngresoValue
            // 
            lblFechaIngresoValue.BackColor = Color.Transparent;
            lblFechaIngresoValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaIngresoValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblFechaIngresoValue.Location = new Point(38, 22);
            lblFechaIngresoValue.Name = "lblFechaIngresoValue";
            lblFechaIngresoValue.Size = new Size(25, 17);
            lblFechaIngresoValue.TabIndex = 2;
            lblFechaIngresoValue.Text = "N/A";
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.BorderRadius = 10;
            btnEditarPerfil.Cursor = Cursors.Hand;
            btnEditarPerfil.CustomizableEdges = customizableEdges5;
            btnEditarPerfil.FillColor = Color.FromArgb(76, 175, 80);
            btnEditarPerfil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditarPerfil.ForeColor = Color.White;
            btnEditarPerfil.HoverState.FillColor = Color.FromArgb(56, 142, 60);
            btnEditarPerfil.Location = new Point(20, 440);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditarPerfil.Size = new Size(240, 40);
            btnEditarPerfil.TabIndex = 4;
            btnEditarPerfil.Text = "✏️ Editar Perfil";
            // 
            // panelDerecho
            // 
            panelDerecho.Controls.Add(panelNivel);
            panelDerecho.Controls.Add(panelGrupo);
            panelDerecho.CustomizableEdges = customizableEdges13;
            panelDerecho.FillColor = Color.Transparent;
            panelDerecho.Location = new Point(320, 20);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.ShadowDecoration.CustomizableEdges = customizableEdges14;
            panelDerecho.Size = new Size(514, 495);
            panelDerecho.TabIndex = 1;
            // 
            // panelNivel
            // 
            panelNivel.BackColor = Color.Transparent;
            panelNivel.BorderRadius = 15;
            panelNivel.Controls.Add(lblTituloNivel);
            panelNivel.Controls.Add(lblNivelLabel);
            panelNivel.Controls.Add(lblNivelValue);
            panelNivel.Controls.Add(panelNivelBarra);
            panelNivel.Controls.Add(lblNivelDescripcion);
            panelNivel.CustomizableEdges = customizableEdges11;
            panelNivel.FillColor = Color.White;
            panelNivel.Location = new Point(3, 0);
            panelNivel.Name = "panelNivel";
            panelNivel.ShadowDecoration.BorderRadius = 15;
            panelNivel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelNivel.ShadowDecoration.Depth = 5;
            panelNivel.ShadowDecoration.Enabled = true;
            panelNivel.Size = new Size(508, 140);
            panelNivel.TabIndex = 0;
            // 
            // lblTituloNivel
            // 
            lblTituloNivel.BackColor = Color.Transparent;
            lblTituloNivel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloNivel.ForeColor = Color.FromArgb(45, 55, 72);
            lblTituloNivel.Location = new Point(15, 12);
            lblTituloNivel.Name = "lblTituloNivel";
            lblTituloNivel.Size = new Size(130, 22);
            lblTituloNivel.TabIndex = 0;
            lblTituloNivel.Text = "🎓 Nivel de Inglés";
            // 
            // lblNivelLabel
            // 
            lblNivelLabel.BackColor = Color.Transparent;
            lblNivelLabel.Font = new Font("Segoe UI", 9F);
            lblNivelLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblNivelLabel.Location = new Point(15, 45);
            lblNivelLabel.Name = "lblNivelLabel";
            lblNivelLabel.Size = new Size(68, 17);
            lblNivelLabel.TabIndex = 1;
            lblNivelLabel.Text = "Nivel actual:";
            // 
            // lblNivelValue
            // 
            lblNivelValue.BackColor = Color.Transparent;
            lblNivelValue.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblNivelValue.ForeColor = Color.FromArgb(76, 175, 80);
            lblNivelValue.Location = new Point(380, 30);
            lblNivelValue.Name = "lblNivelValue";
            lblNivelValue.Size = new Size(56, 61);
            lblNivelValue.TabIndex = 2;
            lblNivelValue.Text = "B1";
            lblNivelValue.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // panelNivelBarra
            // 
            panelNivelBarra.BackColor = Color.Transparent;
            panelNivelBarra.BorderRadius = 8;
            panelNivelBarra.CustomizableEdges = customizableEdges9;
            panelNivelBarra.FillColor = Color.FromArgb(76, 175, 80);
            panelNivelBarra.Location = new Point(15, 70);
            panelNivelBarra.Name = "panelNivelBarra";
            panelNivelBarra.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelNivelBarra.Size = new Size(250, 20);
            panelNivelBarra.TabIndex = 3;
            // 
            // lblNivelDescripcion
            // 
            lblNivelDescripcion.BackColor = Color.Transparent;
            lblNivelDescripcion.Font = new Font("Segoe UI", 8F);
            lblNivelDescripcion.ForeColor = Color.FromArgb(113, 128, 150);
            lblNivelDescripcion.Location = new Point(15, 100);
            lblNivelDescripcion.Name = "lblNivelDescripcion";
            lblNivelDescripcion.Size = new Size(231, 15);
            lblNivelDescripcion.TabIndex = 4;
            lblNivelDescripcion.Text = "A1 ──── A2 ──── B1 ──── B2 ──── C1 ──── C2";
            // 
            // panelGrupo
            // 
            panelGrupo.BackColor = Color.Transparent;
            panelGrupo.BorderRadius = 15;
            panelGrupo.Controls.Add(lblTituloGrupo);
            panelGrupo.Controls.Add(pnlGrupo);
            panelGrupo.Controls.Add(pnlHorario);
            panelGrupo.Controls.Add(pnlMaestro);
            panelGrupo.CustomizableEdges = customizableEdges11;
            panelGrupo.FillColor = Color.White;
            panelGrupo.Location = new Point(3, 155);
            panelGrupo.Name = "panelGrupo";
            panelGrupo.ShadowDecoration.BorderRadius = 15;
            panelGrupo.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelGrupo.ShadowDecoration.Depth = 5;
            panelGrupo.ShadowDecoration.Enabled = true;
            panelGrupo.Size = new Size(508, 200);
            panelGrupo.TabIndex = 1;
            // 
            // lblTituloGrupo
            // 
            lblTituloGrupo.BackColor = Color.Transparent;
            lblTituloGrupo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloGrupo.ForeColor = Color.FromArgb(45, 55, 72);
            lblTituloGrupo.Location = new Point(15, 12);
            lblTituloGrupo.Name = "lblTituloGrupo";
            lblTituloGrupo.Size = new Size(143, 22);
            lblTituloGrupo.TabIndex = 0;
            lblTituloGrupo.Text = "Mi Grupo y Maestro";
            // 
            // pnlGrupo
            // 
            pnlGrupo.Controls.Add(iconGrupo);
            pnlGrupo.Controls.Add(lblGrupoLabel);
            pnlGrupo.Controls.Add(lblGrupoValue);
            pnlGrupo.Location = new Point(15, 45);
            pnlGrupo.Name = "pnlGrupo";
            pnlGrupo.Size = new Size(480, 40);
            pnlGrupo.TabIndex = 1;
            // 
            // iconGrupo
            // 
            iconGrupo.BackColor = Color.Transparent;
            iconGrupo.ForeColor = Color.FromArgb(102, 126, 234);
            iconGrupo.IconChar = IconChar.Users;
            iconGrupo.IconColor = Color.FromArgb(102, 126, 234);
            iconGrupo.IconFont = IconFont.Auto;
            iconGrupo.IconSize = 28;
            iconGrupo.Location = new Point(0, 6);
            iconGrupo.Name = "iconGrupo";
            iconGrupo.Size = new Size(28, 28);
            iconGrupo.TabIndex = 0;
            iconGrupo.TabStop = false;
            // 
            // lblGrupoLabel
            // 
            lblGrupoLabel.BackColor = Color.Transparent;
            lblGrupoLabel.Font = new Font("Segoe UI", 9F);
            lblGrupoLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblGrupoLabel.Location = new Point(36, 4);
            lblGrupoLabel.Name = "lblGrupoLabel";
            lblGrupoLabel.Size = new Size(39, 17);
            lblGrupoLabel.TabIndex = 1;
            lblGrupoLabel.Text = "Grupo:";
            // 
            // lblGrupoValue
            // 
            lblGrupoValue.BackColor = Color.Transparent;
            lblGrupoValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGrupoValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblGrupoValue.Location = new Point(90, 3);
            lblGrupoValue.Name = "lblGrupoValue";
            lblGrupoValue.Size = new Size(123, 19);
            lblGrupoValue.TabIndex = 2;
            lblGrupoValue.Text = "Sin grupo asignado";
            // 
            // pnlHorario
            // 
            pnlHorario.Controls.Add(iconHorario);
            pnlHorario.Controls.Add(lblHorarioLabel);
            pnlHorario.Controls.Add(lblHorarioValue);
            pnlHorario.Location = new Point(15, 95);
            pnlHorario.Name = "pnlHorario";
            pnlHorario.Size = new Size(480, 40);
            pnlHorario.TabIndex = 2;
            // 
            // iconHorario
            // 
            iconHorario.BackColor = Color.Transparent;
            iconHorario.ForeColor = Color.FromArgb(255, 152, 0);
            iconHorario.IconChar = IconChar.ClockFour;
            iconHorario.IconColor = Color.FromArgb(255, 152, 0);
            iconHorario.IconFont = IconFont.Auto;
            iconHorario.IconSize = 28;
            iconHorario.Location = new Point(0, 6);
            iconHorario.Name = "iconHorario";
            iconHorario.Size = new Size(28, 28);
            iconHorario.TabIndex = 0;
            iconHorario.TabStop = false;
            // 
            // lblHorarioLabel
            // 
            lblHorarioLabel.BackColor = Color.Transparent;
            lblHorarioLabel.Font = new Font("Segoe UI", 9F);
            lblHorarioLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblHorarioLabel.Location = new Point(36, 4);
            lblHorarioLabel.Name = "lblHorarioLabel";
            lblHorarioLabel.Size = new Size(46, 17);
            lblHorarioLabel.TabIndex = 1;
            lblHorarioLabel.Text = "Horario:";
            // 
            // lblHorarioValue
            // 
            lblHorarioValue.BackColor = Color.Transparent;
            lblHorarioValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHorarioValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblHorarioValue.Location = new Point(90, 3);
            lblHorarioValue.Name = "lblHorarioValue";
            lblHorarioValue.Size = new Size(28, 19);
            lblHorarioValue.TabIndex = 2;
            lblHorarioValue.Text = "N/A";
            // 
            // pnlMaestro
            // 
            pnlMaestro.Controls.Add(iconMaestro);
            pnlMaestro.Controls.Add(lblMaestroLabel);
            pnlMaestro.Controls.Add(lblMaestroValue);
            pnlMaestro.Location = new Point(15, 145);
            pnlMaestro.Name = "pnlMaestro";
            pnlMaestro.Size = new Size(480, 40);
            pnlMaestro.TabIndex = 3;
            // 
            // iconMaestro
            // 
            iconMaestro.BackColor = Color.Transparent;
            iconMaestro.ForeColor = Color.FromArgb(156, 39, 176);
            iconMaestro.IconChar = IconChar.ChalkboardTeacher;
            iconMaestro.IconColor = Color.FromArgb(156, 39, 176);
            iconMaestro.IconFont = IconFont.Auto;
            iconMaestro.IconSize = 28;
            iconMaestro.Location = new Point(0, 6);
            iconMaestro.Name = "iconMaestro";
            iconMaestro.Size = new Size(28, 28);
            iconMaestro.TabIndex = 0;
            iconMaestro.TabStop = false;
            // 
            // lblMaestroLabel
            // 
            lblMaestroLabel.BackColor = Color.Transparent;
            lblMaestroLabel.Font = new Font("Segoe UI", 9F);
            lblMaestroLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblMaestroLabel.Location = new Point(36, 4);
            lblMaestroLabel.Name = "lblMaestroLabel";
            lblMaestroLabel.Size = new Size(49, 17);
            lblMaestroLabel.TabIndex = 1;
            lblMaestroLabel.Text = "Maestro:";
            // 
            // lblMaestroValue
            // 
            lblMaestroValue.BackColor = Color.Transparent;
            lblMaestroValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaestroValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblMaestroValue.Location = new Point(90, 3);
            lblMaestroValue.Name = "lblMaestroValue";
            lblMaestroValue.Size = new Size(136, 19);
            lblMaestroValue.TabIndex = 2;
            lblMaestroValue.Text = "Sin maestro asignado";
            // 
            // FrmPerfilEstudiante
            // 
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(854, 535);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPerfilEstudiante";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Perfil del Estudiante";
            panelPrincipal.ResumeLayout(false);
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconAvatar).EndInit();
            panelInfoPersonal.ResumeLayout(false);
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconEmail).EndInit();
            pnlTelefono.ResumeLayout(false);
            pnlTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconTelefono).EndInit();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUsuario).EndInit();
            pnlFechaIngreso.ResumeLayout(false);
            pnlFechaIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconFechaIngreso).EndInit();
            panelDerecho.ResumeLayout(false);
            panelNivel.ResumeLayout(false);
            panelNivel.PerformLayout();
            panelGrupo.ResumeLayout(false);
            panelGrupo.PerformLayout();
            pnlGrupo.ResumeLayout(false);
            pnlGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconGrupo).EndInit();
            pnlHorario.ResumeLayout(false);
            pnlHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconHorario).EndInit();
            pnlMaestro.ResumeLayout(false);
            pnlMaestro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconMaestro).EndInit();
            ResumeLayout(false);
        }
    }
}w