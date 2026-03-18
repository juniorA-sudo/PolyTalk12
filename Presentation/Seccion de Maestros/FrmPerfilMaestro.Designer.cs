using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace Presentation.Seccion_de_Maestros
{
    partial class FrmPerfilMaestro
    {
        private System.ComponentModel.IContainer components = null;

        // Controles principales
        private Guna2Panel panelPrincipal;
        private Guna2Panel panelIzquierdo;
        private Guna2Panel panelDerecho;

        // Avatar y datos personales
        private Guna2Panel panelAvatar;
        private IconPictureBox iconAvatar;
        private Guna2HtmlLabel lblNombreMaestro;
        private Guna2HtmlLabel lblRolMaestro;

        // Información personal
        private Guna2Panel panelInfoPersonal;
        private Panel pnlEmail;
        private IconPictureBox iconEmail;
        private Guna2HtmlLabel lblEmailLabel;
        private Guna2HtmlLabel lblEmailValue;

        private Panel pnlTelefono;
        private IconPictureBox iconTelefono;
        private Guna2HtmlLabel lblTelefonoLabel;
        private Guna2HtmlLabel lblTelefonoValue;

        private Panel pnlFechaIngreso;
        private IconPictureBox iconFechaIngreso;
        private Guna2HtmlLabel lblFechaIngresoLabel;
        private Guna2HtmlLabel lblFechaIngresoValue;

        private Panel pnlExperiencia;
        private IconPictureBox iconExperiencia;
        private Guna2HtmlLabel lblExperienciaLabel;
        private Guna2HtmlLabel lblNombreUsuario;

        private Guna2Button btnEditarPerfil;

        // Estadísticas
        private Guna2Panel panelEstadisticas;
        private Guna2Panel panelGrupos;
        private Guna2HtmlLabel lblGruposValor;
        private Guna2HtmlLabel lblGruposTexto;

        private Guna2Panel panelEstudiantes;
        private Guna2HtmlLabel lblEstudiantesValor;
        private Guna2HtmlLabel lblEstudiantesTexto;

        private Guna2Panel panelAsistencia;
        private Guna2HtmlLabel lblAsistenciaValor;
        private Guna2HtmlLabel lblAsistenciaTexto;

        // Grupos
        private Guna2Panel panelGruposLista;
        private Guna2HtmlLabel lblTituloGrupos;
        private Guna2Button btnAgregarGrupo;
        private FlowLayoutPanel flpGrupos;

        // Horario
        private Guna2Panel panelHorario;
        private Guna2HtmlLabel lblTituloHorario;
        private Guna2Button btnEditarHorario;
        private Guna2DataGridView dgvHorario;
        private DataGridViewTextBoxColumn colDia;
        private DataGridViewTextBoxColumn colHora;
        private DataGridViewTextBoxColumn colGrupo;
        private DataGridViewTextBoxColumn colAula;
        private DataGridViewTextBoxColumn colEstado;
        private Guna2Button btnReportes;
        private Guna2Button btnAsistencia;
        private Guna2Button btnMaterial;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelPrincipal = new Guna2Panel();
            panelIzquierdo = new Guna2Panel();
            panelAvatar = new Guna2Panel();
            iconAvatar = new IconPictureBox();
            lblNombreMaestro = new Guna2HtmlLabel();
            panelInfoPersonal = new Guna2Panel();
            pnlEmail = new Panel();
            iconEmail = new IconPictureBox();
            lblEmailLabel = new Guna2HtmlLabel();
            lblEmailValue = new Guna2HtmlLabel();
            pnlTelefono = new Panel();
            iconTelefono = new IconPictureBox();
            lblTelefonoLabel = new Guna2HtmlLabel();
            lblTelefonoValue = new Guna2HtmlLabel();
            pnlFechaIngreso = new Panel();
            iconFechaIngreso = new IconPictureBox();
            lblFechaIngresoLabel = new Guna2HtmlLabel();
            lblFechaIngresoValue = new Guna2HtmlLabel();
            pnlExperiencia = new Panel();
            iconExperiencia = new IconPictureBox();
            lblExperienciaLabel = new Guna2HtmlLabel();
            lblNombreUsuario = new Guna2HtmlLabel();
            btnEditarPerfil = new Guna2Button();
            panelDerecho = new Guna2Panel();
            panelEstadisticas = new Guna2Panel();
            panelGrupos = new Guna2Panel();
            lblGruposValor = new Guna2HtmlLabel();
            lblGruposTexto = new Guna2HtmlLabel();
            panelEstudiantes = new Guna2Panel();
            lblEstudiantesValor = new Guna2HtmlLabel();
            lblEstudiantesTexto = new Guna2HtmlLabel();
            panelAsistencia = new Guna2Panel();
            lblAsistenciaValor = new Guna2HtmlLabel();
            lblAsistenciaTexto = new Guna2HtmlLabel();
            panelGruposLista = new Guna2Panel();
            lblTituloGrupos = new Guna2HtmlLabel();
            flpGrupos = new FlowLayoutPanel();
            panelHorario = new Guna2Panel();
            lblTituloHorario = new Guna2HtmlLabel();
            btnEditarHorario = new Guna2Button();
            dgvHorario = new Guna2DataGridView();
            colDia = new DataGridViewTextBoxColumn();
            colHora = new DataGridViewTextBoxColumn();
            colGrupo = new DataGridViewTextBoxColumn();
            colAula = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            panelPrincipal.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAvatar).BeginInit();
            panelInfoPersonal.SuspendLayout();
            pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconEmail).BeginInit();
            pnlTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTelefono).BeginInit();
            pnlFechaIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconFechaIngreso).BeginInit();
            pnlExperiencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconExperiencia).BeginInit();
            panelDerecho.SuspendLayout();
            panelEstadisticas.SuspendLayout();
            panelGrupos.SuspendLayout();
            panelEstudiantes.SuspendLayout();
            panelAsistencia.SuspendLayout();
            panelGruposLista.SuspendLayout();
            panelHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorario).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 247, 237);
            panelPrincipal.Controls.Add(panelIzquierdo);
            panelPrincipal.Controls.Add(panelDerecho);
            panelPrincipal.CustomizableEdges = customizableEdges25;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.FillColor = Color.Transparent;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(20);
            panelPrincipal.ShadowDecoration.CustomizableEdges = customizableEdges26;
            panelPrincipal.Size = new Size(854, 535);
            panelPrincipal.TabIndex = 0;
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.Transparent;
            panelIzquierdo.BorderRadius = 20;
            panelIzquierdo.Controls.Add(panelAvatar);
            panelIzquierdo.Controls.Add(lblNombreMaestro);
            panelIzquierdo.Controls.Add(panelInfoPersonal);
            panelIzquierdo.Controls.Add(btnEditarPerfil);
            panelIzquierdo.CustomizableEdges = customizableEdges7;
            panelIzquierdo.FillColor = Color.White;
            panelIzquierdo.Location = new Point(20, 20);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Padding = new Padding(20);
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
            panelAvatar.FillColor = Color.FromArgb(102, 126, 234);
            panelAvatar.Location = new Point(70, 20);
            panelAvatar.Name = "panelAvatar";
            panelAvatar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelAvatar.Size = new Size(120, 120);
            panelAvatar.TabIndex = 0;
            // 
            // iconAvatar
            // 
            iconAvatar.BackColor = Color.Transparent;
            iconAvatar.IconChar = IconChar.ChalkboardTeacher;
            iconAvatar.IconColor = Color.White;
            iconAvatar.IconFont = IconFont.Auto;
            iconAvatar.IconSize = 80;
            iconAvatar.Location = new Point(18, 23);
            iconAvatar.Name = "iconAvatar";
            iconAvatar.Size = new Size(80, 80);
            iconAvatar.TabIndex = 0;
            iconAvatar.TabStop = false;
            // 
            // lblNombreMaestro
            // 
            lblNombreMaestro.BackColor = Color.Transparent;
            lblNombreMaestro.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNombreMaestro.ForeColor = Color.FromArgb(45, 55, 72);
            lblNombreMaestro.Location = new Point(53, 150);
            lblNombreMaestro.Name = "lblNombreMaestro";
            lblNombreMaestro.Size = new Size(162, 32);
            lblNombreMaestro.TabIndex = 1;
            lblNombreMaestro.Text = "Prof. Juan Pérez";
            lblNombreMaestro.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // panelInfoPersonal
            // 
            panelInfoPersonal.Controls.Add(pnlEmail);
            panelInfoPersonal.Controls.Add(pnlTelefono);
            panelInfoPersonal.Controls.Add(pnlFechaIngreso);
            panelInfoPersonal.Controls.Add(pnlExperiencia);
            panelInfoPersonal.CustomizableEdges = customizableEdges3;
            panelInfoPersonal.FillColor = Color.Transparent;
            panelInfoPersonal.Location = new Point(0, 220);
            panelInfoPersonal.Name = "panelInfoPersonal";
            panelInfoPersonal.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelInfoPersonal.Size = new Size(280, 250);
            panelInfoPersonal.TabIndex = 3;
            // 
            // pnlEmail
            // 
            pnlEmail.Controls.Add(iconEmail);
            pnlEmail.Controls.Add(lblEmailLabel);
            pnlEmail.Controls.Add(lblEmailValue);
            pnlEmail.Location = new Point(20, 10);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(240, 45);
            pnlEmail.TabIndex = 0;
            // 
            // iconEmail
            // 
            iconEmail.BackColor = Color.Transparent;
            iconEmail.ForeColor = Color.FromArgb(102, 126, 234);
            iconEmail.IconChar = IconChar.Envelope;
            iconEmail.IconColor = Color.FromArgb(102, 126, 234);
            iconEmail.IconFont = IconFont.Auto;
            iconEmail.IconSize = 35;
            iconEmail.Location = new Point(0, 5);
            iconEmail.Name = "iconEmail";
            iconEmail.Size = new Size(35, 35);
            iconEmail.TabIndex = 0;
            iconEmail.TabStop = false;
            // 
            // lblEmailLabel
            // 
            lblEmailLabel.BackColor = Color.Transparent;
            lblEmailLabel.Font = new Font("Segoe UI", 9F);
            lblEmailLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblEmailLabel.Location = new Point(45, 5);
            lblEmailLabel.Name = "lblEmailLabel";
            lblEmailLabel.Size = new Size(32, 17);
            lblEmailLabel.TabIndex = 1;
            lblEmailLabel.Text = "Email";
            // 
            // lblEmailValue
            // 
            lblEmailValue.BackColor = Color.Transparent;
            lblEmailValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmailValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblEmailValue.Location = new Point(45, 22);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(159, 19);
            lblEmailValue.TabIndex = 2;
            lblEmailValue.Text = "juan.perez@polytalk.com";
            // 
            // pnlTelefono
            // 
            pnlTelefono.Controls.Add(iconTelefono);
            pnlTelefono.Controls.Add(lblTelefonoLabel);
            pnlTelefono.Controls.Add(lblTelefonoValue);
            pnlTelefono.Location = new Point(20, 60);
            pnlTelefono.Name = "pnlTelefono";
            pnlTelefono.Size = new Size(240, 45);
            pnlTelefono.TabIndex = 1;
            // 
            // iconTelefono
            // 
            iconTelefono.BackColor = Color.Transparent;
            iconTelefono.ForeColor = Color.FromArgb(102, 126, 234);
            iconTelefono.IconChar = IconChar.Phone;
            iconTelefono.IconColor = Color.FromArgb(102, 126, 234);
            iconTelefono.IconFont = IconFont.Auto;
            iconTelefono.IconSize = 35;
            iconTelefono.Location = new Point(0, 5);
            iconTelefono.Name = "iconTelefono";
            iconTelefono.Size = new Size(35, 35);
            iconTelefono.TabIndex = 0;
            iconTelefono.TabStop = false;
            // 
            // lblTelefonoLabel
            // 
            lblTelefonoLabel.BackColor = Color.Transparent;
            lblTelefonoLabel.Font = new Font("Segoe UI", 9F);
            lblTelefonoLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblTelefonoLabel.Location = new Point(45, 5);
            lblTelefonoLabel.Name = "lblTelefonoLabel";
            lblTelefonoLabel.Size = new Size(50, 17);
            lblTelefonoLabel.TabIndex = 1;
            lblTelefonoLabel.Text = "Teléfono";
            // 
            // lblTelefonoValue
            // 
            lblTelefonoValue.BackColor = Color.Transparent;
            lblTelefonoValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefonoValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblTelefonoValue.Location = new Point(45, 22);
            lblTelefonoValue.Name = "lblTelefonoValue";
            lblTelefonoValue.Size = new Size(103, 19);
            lblTelefonoValue.TabIndex = 2;
            lblTelefonoValue.Text = "+1 809-555-1234";
            // 
            // pnlFechaIngreso
            // 
            pnlFechaIngreso.Controls.Add(iconFechaIngreso);
            pnlFechaIngreso.Controls.Add(lblFechaIngresoLabel);
            pnlFechaIngreso.Controls.Add(lblFechaIngresoValue);
            pnlFechaIngreso.Location = new Point(20, 160);
            pnlFechaIngreso.Name = "pnlFechaIngreso";
            pnlFechaIngreso.Size = new Size(240, 45);
            pnlFechaIngreso.TabIndex = 3;
            // 
            // iconFechaIngreso
            // 
            iconFechaIngreso.BackColor = Color.Transparent;
            iconFechaIngreso.ForeColor = Color.FromArgb(102, 126, 234);
            iconFechaIngreso.IconChar = IconChar.CalendarDays;
            iconFechaIngreso.IconColor = Color.FromArgb(102, 126, 234);
            iconFechaIngreso.IconFont = IconFont.Auto;
            iconFechaIngreso.IconSize = 35;
            iconFechaIngreso.Location = new Point(0, 5);
            iconFechaIngreso.Name = "iconFechaIngreso";
            iconFechaIngreso.Size = new Size(35, 35);
            iconFechaIngreso.TabIndex = 0;
            iconFechaIngreso.TabStop = false;
            // 
            // lblFechaIngresoLabel
            // 
            lblFechaIngresoLabel.BackColor = Color.Transparent;
            lblFechaIngresoLabel.Font = new Font("Segoe UI", 9F);
            lblFechaIngresoLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblFechaIngresoLabel.Location = new Point(45, 5);
            lblFechaIngresoLabel.Name = "lblFechaIngresoLabel";
            lblFechaIngresoLabel.Size = new Size(76, 17);
            lblFechaIngresoLabel.TabIndex = 1;
            lblFechaIngresoLabel.Text = "Fecha Ingreso";
            // 
            // lblFechaIngresoValue
            // 
            lblFechaIngresoValue.BackColor = Color.Transparent;
            lblFechaIngresoValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaIngresoValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblFechaIngresoValue.Location = new Point(45, 22);
            lblFechaIngresoValue.Name = "lblFechaIngresoValue";
            lblFechaIngresoValue.Size = new Size(92, 19);
            lblFechaIngresoValue.TabIndex = 2;
            lblFechaIngresoValue.Text = "15 Enero, 2022";
            // 
            // pnlExperiencia
            // 
            pnlExperiencia.Controls.Add(iconExperiencia);
            pnlExperiencia.Controls.Add(lblExperienciaLabel);
            pnlExperiencia.Controls.Add(lblNombreUsuario);
            pnlExperiencia.Location = new Point(20, 109);
            pnlExperiencia.Name = "pnlExperiencia";
            pnlExperiencia.Size = new Size(240, 45);
            pnlExperiencia.TabIndex = 4;
            // 
            // iconExperiencia
            // 
            iconExperiencia.BackColor = Color.Transparent;
            iconExperiencia.ForeColor = Color.FromArgb(102, 126, 234);
            iconExperiencia.IconChar = IconChar.User;
            iconExperiencia.IconColor = Color.FromArgb(102, 126, 234);
            iconExperiencia.IconFont = IconFont.Auto;
            iconExperiencia.IconSize = 35;
            iconExperiencia.Location = new Point(0, 5);
            iconExperiencia.Name = "iconExperiencia";
            iconExperiencia.Size = new Size(35, 35);
            iconExperiencia.TabIndex = 0;
            iconExperiencia.TabStop = false;
            // 
            // lblExperienciaLabel
            // 
            lblExperienciaLabel.BackColor = Color.Transparent;
            lblExperienciaLabel.Font = new Font("Segoe UI", 9F);
            lblExperienciaLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblExperienciaLabel.Location = new Point(45, 5);
            lblExperienciaLabel.Name = "lblExperienciaLabel";
            lblExperienciaLabel.Size = new Size(56, 17);
            lblExperienciaLabel.TabIndex = 1;
            lblExperienciaLabel.Text = "Username";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreUsuario.ForeColor = Color.FromArgb(45, 55, 72);
            lblNombreUsuario.Location = new Point(45, 22);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(43, 19);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.Text = "5 años";
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.BorderRadius = 10;
            btnEditarPerfil.Cursor = Cursors.Hand;
            btnEditarPerfil.CustomizableEdges = customizableEdges5;
            btnEditarPerfil.FillColor = Color.FromArgb(102, 126, 234);
            btnEditarPerfil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditarPerfil.ForeColor = Color.White;
            btnEditarPerfil.HoverState.FillColor = Color.FromArgb(92, 116, 224);
            btnEditarPerfil.Location = new Point(20, 420);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditarPerfil.Size = new Size(240, 40);
            btnEditarPerfil.TabIndex = 4;
            btnEditarPerfil.Text = "✏️ Editar Perfil";
            // 
            // panelDerecho
            // 
            panelDerecho.Controls.Add(panelEstadisticas);
            panelDerecho.Controls.Add(panelGruposLista);
            panelDerecho.Controls.Add(panelHorario);
            panelDerecho.CustomizableEdges = customizableEdges23;
            panelDerecho.FillColor = Color.Transparent;
            panelDerecho.Location = new Point(320, 20);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.ShadowDecoration.CustomizableEdges = customizableEdges24;
            panelDerecho.Size = new Size(514, 495);
            panelDerecho.TabIndex = 1;
            // 
            // panelEstadisticas
            // 
            panelEstadisticas.Controls.Add(panelGrupos);
            panelEstadisticas.Controls.Add(panelEstudiantes);
            panelEstadisticas.Controls.Add(panelAsistencia);
            panelEstadisticas.CustomizableEdges = customizableEdges15;
            panelEstadisticas.FillColor = Color.Transparent;
            panelEstadisticas.Location = new Point(0, 0);
            panelEstadisticas.Name = "panelEstadisticas";
            panelEstadisticas.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelEstadisticas.Size = new Size(514, 90);
            panelEstadisticas.TabIndex = 0;
            // 
            // panelGrupos
            // 
            panelGrupos.BackColor = Color.Transparent;
            panelGrupos.BorderRadius = 12;
            panelGrupos.Controls.Add(lblGruposValor);
            panelGrupos.Controls.Add(lblGruposTexto);
            panelGrupos.CustomizableEdges = customizableEdges9;
            panelGrupos.FillColor = Color.White;
            panelGrupos.Location = new Point(3, 4);
            panelGrupos.Name = "panelGrupos";
            panelGrupos.ShadowDecoration.BorderRadius = 15;
            panelGrupos.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelGrupos.ShadowDecoration.Depth = 5;
            panelGrupos.ShadowDecoration.Enabled = true;
            panelGrupos.Size = new Size(157, 80);
            panelGrupos.TabIndex = 0;
            panelGrupos.Paint += panelGrupos_Paint;
            // 
            // lblGruposValor
            // 
            lblGruposValor.BackColor = Color.Transparent;
            lblGruposValor.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblGruposValor.ForeColor = Color.FromArgb(102, 126, 234);
            lblGruposValor.Location = new Point(20, 3);
            lblGruposValor.Name = "lblGruposValor";
            lblGruposValor.Size = new Size(21, 47);
            lblGruposValor.TabIndex = 0;
            lblGruposValor.Text = "4";
            // 
            // lblGruposTexto
            // 
            lblGruposTexto.BackColor = Color.Transparent;
            lblGruposTexto.Font = new Font("Segoe UI", 10F);
            lblGruposTexto.ForeColor = Color.FromArgb(113, 128, 150);
            lblGruposTexto.Location = new Point(20, 47);
            lblGruposTexto.Name = "lblGruposTexto";
            lblGruposTexto.Size = new Size(90, 19);
            lblGruposTexto.TabIndex = 1;
            lblGruposTexto.Text = "Grupos activos";
            // 
            // panelEstudiantes
            // 
            panelEstudiantes.BackColor = Color.Transparent;
            panelEstudiantes.BorderRadius = 12;
            panelEstudiantes.Controls.Add(lblEstudiantesValor);
            panelEstudiantes.Controls.Add(lblEstudiantesTexto);
            panelEstudiantes.CustomizableEdges = customizableEdges11;
            panelEstudiantes.FillColor = Color.White;
            panelEstudiantes.Location = new Point(175, 4);
            panelEstudiantes.Name = "panelEstudiantes";
            panelEstudiantes.ShadowDecoration.BorderRadius = 15;
            panelEstudiantes.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelEstudiantes.ShadowDecoration.Depth = 5;
            panelEstudiantes.ShadowDecoration.Enabled = true;
            panelEstudiantes.Size = new Size(160, 80);
            panelEstudiantes.TabIndex = 1;
            // 
            // lblEstudiantesValor
            // 
            lblEstudiantesValor.BackColor = Color.Transparent;
            lblEstudiantesValor.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblEstudiantesValor.ForeColor = Color.FromArgb(76, 175, 80);
            lblEstudiantesValor.Location = new Point(20, 3);
            lblEstudiantesValor.Name = "lblEstudiantesValor";
            lblEstudiantesValor.Size = new Size(39, 47);
            lblEstudiantesValor.TabIndex = 0;
            lblEstudiantesValor.Text = "87";
            // 
            // lblEstudiantesTexto
            // 
            lblEstudiantesTexto.BackColor = Color.Transparent;
            lblEstudiantesTexto.Font = new Font("Segoe UI", 10F);
            lblEstudiantesTexto.ForeColor = Color.FromArgb(113, 128, 150);
            lblEstudiantesTexto.Location = new Point(20, 47);
            lblEstudiantesTexto.Name = "lblEstudiantesTexto";
            lblEstudiantesTexto.Size = new Size(69, 19);
            lblEstudiantesTexto.TabIndex = 1;
            lblEstudiantesTexto.Text = "Estudiantes";
            // 
            // panelAsistencia
            // 
            panelAsistencia.BackColor = Color.Transparent;
            panelAsistencia.BorderRadius = 12;
            panelAsistencia.Controls.Add(lblAsistenciaValor);
            panelAsistencia.Controls.Add(lblAsistenciaTexto);
            panelAsistencia.CustomizableEdges = customizableEdges13;
            panelAsistencia.FillColor = Color.White;
            panelAsistencia.Location = new Point(350, 4);
            panelAsistencia.Name = "panelAsistencia";
            panelAsistencia.ShadowDecoration.BorderRadius = 15;
            panelAsistencia.ShadowDecoration.CustomizableEdges = customizableEdges14;
            panelAsistencia.ShadowDecoration.Depth = 5;
            panelAsistencia.ShadowDecoration.Enabled = true;
            panelAsistencia.Size = new Size(160, 80);
            panelAsistencia.TabIndex = 2;
            // 
            // lblAsistenciaValor
            // 
            lblAsistenciaValor.BackColor = Color.Transparent;
            lblAsistenciaValor.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblAsistenciaValor.ForeColor = Color.FromArgb(255, 152, 0);
            lblAsistenciaValor.Location = new Point(13, 3);
            lblAsistenciaValor.Name = "lblAsistenciaValor";
            lblAsistenciaValor.Size = new Size(67, 47);
            lblAsistenciaValor.TabIndex = 0;
            lblAsistenciaValor.Text = "92%";
            // 
            // lblAsistenciaTexto
            // 
            lblAsistenciaTexto.BackColor = Color.Transparent;
            lblAsistenciaTexto.Font = new Font("Segoe UI", 10F);
            lblAsistenciaTexto.ForeColor = Color.FromArgb(113, 128, 150);
            lblAsistenciaTexto.Location = new Point(20, 47);
            lblAsistenciaTexto.Name = "lblAsistenciaTexto";
            lblAsistenciaTexto.Size = new Size(60, 19);
            lblAsistenciaTexto.TabIndex = 1;
            lblAsistenciaTexto.Text = "Asistencia";
            // 
            // panelGruposLista
            // 
            panelGruposLista.BackColor = Color.Transparent;
            panelGruposLista.BorderRadius = 15;
            panelGruposLista.Controls.Add(lblTituloGrupos);
            panelGruposLista.Controls.Add(flpGrupos);
            panelGruposLista.CustomizableEdges = customizableEdges17;
            panelGruposLista.FillColor = Color.White;
            panelGruposLista.Location = new Point(3, 100);
            panelGruposLista.Name = "panelGruposLista";
            panelGruposLista.Padding = new Padding(15);
            panelGruposLista.ShadowDecoration.BorderRadius = 15;
            panelGruposLista.ShadowDecoration.CustomizableEdges = customizableEdges18;
            panelGruposLista.ShadowDecoration.Depth = 5;
            panelGruposLista.ShadowDecoration.Enabled = true;
            panelGruposLista.Size = new Size(507, 220);
            panelGruposLista.TabIndex = 1;
            // 
            // lblTituloGrupos
            // 
            lblTituloGrupos.BackColor = Color.Transparent;
            lblTituloGrupos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloGrupos.ForeColor = Color.FromArgb(45, 55, 72);
            lblTituloGrupos.Location = new Point(15, 15);
            lblTituloGrupos.Name = "lblTituloGrupos";
            lblTituloGrupos.Size = new Size(105, 27);
            lblTituloGrupos.TabIndex = 0;
            lblTituloGrupos.Text = "Mis Grupos";
            // 
            // flpGrupos
            // 
            flpGrupos.AutoScroll = true;
            flpGrupos.Location = new Point(15, 50);
            flpGrupos.Name = "flpGrupos";
            flpGrupos.Size = new Size(480, 152);
            flpGrupos.TabIndex = 2;
            // 
            // panelHorario
            // 
            panelHorario.BackColor = Color.Transparent;
            panelHorario.BorderRadius = 15;
            panelHorario.Controls.Add(lblTituloHorario);
            panelHorario.Controls.Add(btnEditarHorario);
            panelHorario.Controls.Add(dgvHorario);
            panelHorario.CustomizableEdges = customizableEdges21;
            panelHorario.FillColor = Color.White;
            panelHorario.Location = new Point(3, 332);
            panelHorario.Name = "panelHorario";
            panelHorario.Padding = new Padding(15);
            panelHorario.ShadowDecoration.BorderRadius = 15;
            panelHorario.ShadowDecoration.CustomizableEdges = customizableEdges22;
            panelHorario.ShadowDecoration.Depth = 5;
            panelHorario.ShadowDecoration.Enabled = true;
            panelHorario.Size = new Size(507, 160);
            panelHorario.TabIndex = 2;
            // 
            // lblTituloHorario
            // 
            lblTituloHorario.BackColor = Color.Transparent;
            lblTituloHorario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloHorario.ForeColor = Color.FromArgb(45, 55, 72);
            lblTituloHorario.Location = new Point(15, 15);
            lblTituloHorario.Name = "lblTituloHorario";
            lblTituloHorario.Size = new Size(185, 27);
            lblTituloHorario.TabIndex = 0;
            lblTituloHorario.Text = "⏰ Horario de Clases";
            // 
            // btnEditarHorario
            // 
            btnEditarHorario.BorderRadius = 8;
            btnEditarHorario.CustomizableEdges = customizableEdges19;
            btnEditarHorario.FillColor = Color.FromArgb(240, 245, 255);
            btnEditarHorario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarHorario.ForeColor = Color.FromArgb(102, 126, 234);
            btnEditarHorario.HoverState.FillColor = Color.FromArgb(102, 126, 234);
            btnEditarHorario.HoverState.ForeColor = Color.White;
            btnEditarHorario.Location = new Point(410, 10);
            btnEditarHorario.Name = "btnEditarHorario";
            btnEditarHorario.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnEditarHorario.Size = new Size(80, 30);
            btnEditarHorario.TabIndex = 1;
            btnEditarHorario.Text = "✏️ Editar";
            // 
            // dgvHorario
            // 
            dgvHorario.AllowUserToAddRows = false;
            dgvHorario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvHorario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHorario.ColumnHeadersHeight = 30;
            dgvHorario.Columns.AddRange(new DataGridViewColumn[] { colDia, colHora, colGrupo, colAula, colEstado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHorario.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHorario.GridColor = Color.FromArgb(231, 229, 255);
            dgvHorario.Location = new Point(15, 50);
            dgvHorario.Name = "dgvHorario";
            dgvHorario.ReadOnly = true;
            dgvHorario.RowHeadersVisible = false;
            dgvHorario.Size = new Size(480, 95);
            dgvHorario.TabIndex = 2;
            dgvHorario.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvHorario.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvHorario.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvHorario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvHorario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvHorario.ThemeStyle.BackColor = Color.White;
            dgvHorario.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvHorario.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvHorario.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHorario.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvHorario.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvHorario.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHorario.ThemeStyle.HeaderStyle.Height = 30;
            dgvHorario.ThemeStyle.ReadOnly = true;
            dgvHorario.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvHorario.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHorario.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvHorario.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvHorario.ThemeStyle.RowsStyle.Height = 25;
            dgvHorario.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvHorario.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // colDia
            // 
            colDia.HeaderText = "Día";
            colDia.Name = "colDia";
            colDia.ReadOnly = true;
            // 
            // colHora
            // 
            colHora.HeaderText = "Hora";
            colHora.Name = "colHora";
            colHora.ReadOnly = true;
            // 
            // colGrupo
            // 
            colGrupo.HeaderText = "Grupo";
            colGrupo.Name = "colGrupo";
            colGrupo.ReadOnly = true;
            // 
            // colAula
            // 
            colAula.HeaderText = "Aula";
            colAula.Name = "colAula";
            colAula.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // FrmPerfilMaestro
            // 
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(854, 535);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPerfilMaestro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Perfil del Maestro";
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
            pnlFechaIngreso.ResumeLayout(false);
            pnlFechaIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconFechaIngreso).EndInit();
            pnlExperiencia.ResumeLayout(false);
            pnlExperiencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconExperiencia).EndInit();
            panelDerecho.ResumeLayout(false);
            panelEstadisticas.ResumeLayout(false);
            panelGrupos.ResumeLayout(false);
            panelGrupos.PerformLayout();
            panelEstudiantes.ResumeLayout(false);
            panelEstudiantes.PerformLayout();
            panelAsistencia.ResumeLayout(false);
            panelAsistencia.PerformLayout();
            panelGruposLista.ResumeLayout(false);
            panelGruposLista.PerformLayout();
            panelHorario.ResumeLayout(false);
            panelHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorario).EndInit();
            ResumeLayout(false);
        }

        private void AgregarGrupoEjemplo(string nombre, string estudiantes, string horario, string materias)
        {
            Guna2Panel grupo = new Guna2Panel();
            grupo.Size = new System.Drawing.Size(150, 70);
            grupo.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            grupo.FillColor = System.Drawing.Color.FromArgb(248, 250, 252);
            grupo.BorderRadius = 10;
            grupo.Padding = new System.Windows.Forms.Padding(8);

            Guna2HtmlLabel lblNombre = new Guna2HtmlLabel();
            lblNombre.Text = nombre;
            lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblNombre.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            lblNombre.Location = new System.Drawing.Point(8, 5);

            Guna2HtmlLabel lblEstudiantes = new Guna2HtmlLabel();
            lblEstudiantes.Text = estudiantes;
            lblEstudiantes.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblEstudiantes.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            lblEstudiantes.Location = new System.Drawing.Point(8, 25);

            Guna2HtmlLabel lblHorario = new Guna2HtmlLabel();
            lblHorario.Text = horario;
            lblHorario.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblHorario.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            lblHorario.Location = new System.Drawing.Point(8, 40);

            grupo.Controls.Add(lblNombre);
            grupo.Controls.Add(lblEstudiantes);
            grupo.Controls.Add(lblHorario);

            this.flpGrupos.Controls.Add(grupo);
        }
    }
}