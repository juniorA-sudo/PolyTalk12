using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;

namespace Presentation.Seccion_de_Administrador
{
    partial class FrmPerfilAdmin
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelPrincipal;
        private Guna2Panel panelIzquierdo;
        private Guna2Panel panelDerecho;

        private Guna2Panel panelAvatar;
        private IconPictureBox iconAvatar;
        private Guna2HtmlLabel lblNombreAdmin;
        private Guna2HtmlLabel lblRolAdmin;

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

        private Guna2Panel panelEstadisticas;
        private Guna2Panel panelTotalMaestros;
        private Guna2HtmlLabel lblTotalMaestrosValor;
        private Guna2HtmlLabel lblTotalMaestrosTexto;

        private Guna2Panel panelTotalEstudiantes;
        private Guna2HtmlLabel lblTotalEstudiantesValor;
        private Guna2HtmlLabel lblTotalEstudiantesTexto;

        private Guna2Panel panelTotalGrupos;
        private Guna2HtmlLabel lblTotalGruposValor;
        private Guna2HtmlLabel lblTotalGruposTexto;

        private Guna2Panel panelTotalLecciones;
        private Guna2HtmlLabel lblTotalLeccionesValor;
        private Guna2HtmlLabel lblTotalLeccionesTexto;

        private Guna2Panel panelResumen;
        private Guna2HtmlLabel lblTituloResumen;
        private Guna2DataGridView dgvResumen;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPorcentaje;

        private Guna2Panel panelGrafico;
        private Guna2HtmlLabel lblTituloGrafico;
        private Guna2Panel barraMaestros;
        private Guna2HtmlLabel lblBarraMaestros;
        private Guna2Panel barraEstudiantes;
        private Guna2HtmlLabel lblBarraEstudiantes;
        private Guna2Panel barraGrupos;
        private Guna2HtmlLabel lblBarraGrupos;

        // ✅ Solo 3 botones ahora (sin btnReportesAdmin)
        private Guna2Panel panelAcciones;
        private Guna2Button btnGestionMaestros;
        private Guna2Button btnGestionEstudiantes;
        private Guna2Button btnGestionGrupos;

        // ✅ Panel de actividad reciente (reemplaza el espacio vacío)
        private Guna2Panel panelActividadReciente;
        private Guna2HtmlLabel lblTituloActividad;
        private Guna2HtmlLabel lblUltimoAcceso;
        private Guna2HtmlLabel lblUltimoAccesoValue;
        private Guna2HtmlLabel lblTotalUsuarios;
        private Guna2HtmlLabel lblTotalUsuariosValue;
        private Guna2HtmlLabel lblSistema;
        private Guna2HtmlLabel lblSistemaValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            CustomizableEdges customizableEdges39 = new CustomizableEdges();
            CustomizableEdges customizableEdges40 = new CustomizableEdges();
            CustomizableEdges customizableEdges7 = new CustomizableEdges();
            CustomizableEdges customizableEdges8 = new CustomizableEdges();
            CustomizableEdges customizableEdges1 = new CustomizableEdges();
            CustomizableEdges customizableEdges2 = new CustomizableEdges();
            CustomizableEdges customizableEdges3 = new CustomizableEdges();
            CustomizableEdges customizableEdges4 = new CustomizableEdges();
            CustomizableEdges customizableEdges5 = new CustomizableEdges();
            CustomizableEdges customizableEdges6 = new CustomizableEdges();
            CustomizableEdges customizableEdges37 = new CustomizableEdges();
            CustomizableEdges customizableEdges38 = new CustomizableEdges();
            CustomizableEdges customizableEdges17 = new CustomizableEdges();
            CustomizableEdges customizableEdges18 = new CustomizableEdges();
            CustomizableEdges customizableEdges9 = new CustomizableEdges();
            CustomizableEdges customizableEdges10 = new CustomizableEdges();
            CustomizableEdges customizableEdges11 = new CustomizableEdges();
            CustomizableEdges customizableEdges12 = new CustomizableEdges();
            CustomizableEdges customizableEdges13 = new CustomizableEdges();
            CustomizableEdges customizableEdges14 = new CustomizableEdges();
            CustomizableEdges customizableEdges15 = new CustomizableEdges();
            CustomizableEdges customizableEdges16 = new CustomizableEdges();
            CustomizableEdges customizableEdges19 = new CustomizableEdges();
            CustomizableEdges customizableEdges20 = new CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            CustomizableEdges customizableEdges27 = new CustomizableEdges();
            CustomizableEdges customizableEdges28 = new CustomizableEdges();
            CustomizableEdges customizableEdges21 = new CustomizableEdges();
            CustomizableEdges customizableEdges22 = new CustomizableEdges();
            CustomizableEdges customizableEdges23 = new CustomizableEdges();
            CustomizableEdges customizableEdges24 = new CustomizableEdges();
            CustomizableEdges customizableEdges25 = new CustomizableEdges();
            CustomizableEdges customizableEdges26 = new CustomizableEdges();
            CustomizableEdges customizableEdges35 = new CustomizableEdges();
            CustomizableEdges customizableEdges36 = new CustomizableEdges();
            CustomizableEdges customizableEdges29 = new CustomizableEdges();
            CustomizableEdges customizableEdges30 = new CustomizableEdges();
            CustomizableEdges customizableEdges31 = new CustomizableEdges();
            CustomizableEdges customizableEdges32 = new CustomizableEdges();
            CustomizableEdges customizableEdges33 = new CustomizableEdges();
            CustomizableEdges customizableEdges34 = new CustomizableEdges();
            panelPrincipal = new Guna2Panel();
            panelIzquierdo = new Guna2Panel();
            panelAvatar = new Guna2Panel();
            iconAvatar = new IconPictureBox();
            lblNombreAdmin = new Guna2HtmlLabel();
            lblRolAdmin = new Guna2HtmlLabel();
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
            panelEstadisticas = new Guna2Panel();
            panelTotalMaestros = new Guna2Panel();
            lblTotalMaestrosValor = new Guna2HtmlLabel();
            lblTotalMaestrosTexto = new Guna2HtmlLabel();
            panelTotalEstudiantes = new Guna2Panel();
            lblTotalEstudiantesValor = new Guna2HtmlLabel();
            lblTotalEstudiantesTexto = new Guna2HtmlLabel();
            panelTotalGrupos = new Guna2Panel();
            lblTotalGruposValor = new Guna2HtmlLabel();
            lblTotalGruposTexto = new Guna2HtmlLabel();
            panelTotalLecciones = new Guna2Panel();
            lblTotalLeccionesValor = new Guna2HtmlLabel();
            lblTotalLeccionesTexto = new Guna2HtmlLabel();
            panelResumen = new Guna2Panel();
            lblTituloResumen = new Guna2HtmlLabel();
            dgvResumen = new Guna2DataGridView();
            colTipo = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPorcentaje = new DataGridViewTextBoxColumn();
            panelGrafico = new Guna2Panel();
            lblTituloGrafico = new Guna2HtmlLabel();
            barraMaestros = new Guna2Panel();
            lblBarraMaestros = new Guna2HtmlLabel();
            barraEstudiantes = new Guna2Panel();
            lblBarraEstudiantes = new Guna2HtmlLabel();
            barraGrupos = new Guna2Panel();
            lblBarraGrupos = new Guna2HtmlLabel();
            panelAcciones = new Guna2Panel();
            btnGestionMaestros = new Guna2Button();
            btnGestionEstudiantes = new Guna2Button();
            btnGestionGrupos = new Guna2Button();
            panelActividadReciente = new Guna2Panel();
            lblTituloActividad = new Guna2HtmlLabel();
            lblUltimoAcceso = new Guna2HtmlLabel();
            lblUltimoAccesoValue = new Guna2HtmlLabel();
            lblTotalUsuarios = new Guna2HtmlLabel();
            lblTotalUsuariosValue = new Guna2HtmlLabel();
            lblSistema = new Guna2HtmlLabel();
            lblSistemaValue = new Guna2HtmlLabel();
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
            panelEstadisticas.SuspendLayout();
            panelTotalMaestros.SuspendLayout();
            panelTotalEstudiantes.SuspendLayout();
            panelTotalGrupos.SuspendLayout();
            panelTotalLecciones.SuspendLayout();
            panelResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            panelGrafico.SuspendLayout();
            barraMaestros.SuspendLayout();
            barraEstudiantes.SuspendLayout();
            barraGrupos.SuspendLayout();
            panelAcciones.SuspendLayout();
            panelActividadReciente.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 247, 237);
            panelPrincipal.Controls.Add(panelIzquierdo);
            panelPrincipal.Controls.Add(panelDerecho);
            panelPrincipal.CustomizableEdges = customizableEdges39;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.FillColor = Color.Transparent;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(20);
            panelPrincipal.ShadowDecoration.CustomizableEdges = customizableEdges40;
            panelPrincipal.Size = new Size(854, 535);
            panelPrincipal.TabIndex = 0;
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.Transparent;
            panelIzquierdo.BorderRadius = 20;
            panelIzquierdo.Controls.Add(panelAvatar);
            panelIzquierdo.Controls.Add(lblNombreAdmin);
            panelIzquierdo.Controls.Add(lblRolAdmin);
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
            iconAvatar.IconChar = IconChar.UserGear;
            iconAvatar.IconColor = Color.White;
            iconAvatar.IconFont = IconFont.Auto;
            iconAvatar.IconSize = 80;
            iconAvatar.Location = new Point(18, 23);
            iconAvatar.Name = "iconAvatar";
            iconAvatar.Size = new Size(80, 80);
            iconAvatar.TabIndex = 0;
            iconAvatar.TabStop = false;
            // 
            // lblNombreAdmin
            // 
            lblNombreAdmin.BackColor = Color.Transparent;
            lblNombreAdmin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNombreAdmin.ForeColor = Color.FromArgb(45, 55, 72);
            lblNombreAdmin.Location = new Point(53, 150);
            lblNombreAdmin.Name = "lblNombreAdmin";
            lblNombreAdmin.Size = new Size(145, 32);
            lblNombreAdmin.TabIndex = 1;
            lblNombreAdmin.Text = "Administrador";
            lblNombreAdmin.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblRolAdmin
            // 
            lblRolAdmin.BackColor = Color.Transparent;
            lblRolAdmin.Font = new Font("Segoe UI", 10F);
            lblRolAdmin.ForeColor = Color.FromArgb(102, 126, 234);
            lblRolAdmin.Location = new Point(90, 185);
            lblRolAdmin.Name = "lblRolAdmin";
            lblRolAdmin.Size = new Size(86, 19);
            lblRolAdmin.TabIndex = 2;
            lblRolAdmin.Text = "Administrador";
            // 
            // panelInfoPersonal
            // 
            panelInfoPersonal.Controls.Add(pnlEmail);
            panelInfoPersonal.Controls.Add(pnlTelefono);
            panelInfoPersonal.Controls.Add(pnlUsuario);
            panelInfoPersonal.Controls.Add(pnlFechaIngreso);
            panelInfoPersonal.CustomizableEdges = customizableEdges3;
            panelInfoPersonal.FillColor = Color.Transparent;
            panelInfoPersonal.Location = new Point(0, 220);
            panelInfoPersonal.Name = "panelInfoPersonal";
            panelInfoPersonal.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelInfoPersonal.Size = new Size(280, 200);
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
            lblEmailValue.Size = new Size(134, 19);
            lblEmailValue.TabIndex = 2;
            lblEmailValue.Text = "admin@polytalk.com";
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
            lblTelefonoValue.Size = new Size(28, 19);
            lblTelefonoValue.TabIndex = 2;
            lblTelefonoValue.Text = "N/A";
            // 
            // pnlUsuario
            // 
            pnlUsuario.Controls.Add(iconUsuario);
            pnlUsuario.Controls.Add(lblUsuarioLabel);
            pnlUsuario.Controls.Add(lblUsuarioValue);
            pnlUsuario.Location = new Point(20, 110);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(240, 45);
            pnlUsuario.TabIndex = 2;
            // 
            // iconUsuario
            // 
            iconUsuario.BackColor = Color.Transparent;
            iconUsuario.ForeColor = Color.FromArgb(102, 126, 234);
            iconUsuario.IconChar = IconChar.User;
            iconUsuario.IconColor = Color.FromArgb(102, 126, 234);
            iconUsuario.IconFont = IconFont.Auto;
            iconUsuario.IconSize = 35;
            iconUsuario.Location = new Point(0, 5);
            iconUsuario.Name = "iconUsuario";
            iconUsuario.Size = new Size(35, 35);
            iconUsuario.TabIndex = 0;
            iconUsuario.TabStop = false;
            // 
            // lblUsuarioLabel
            // 
            lblUsuarioLabel.BackColor = Color.Transparent;
            lblUsuarioLabel.Font = new Font("Segoe UI", 9F);
            lblUsuarioLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblUsuarioLabel.Location = new Point(45, 5);
            lblUsuarioLabel.Name = "lblUsuarioLabel";
            lblUsuarioLabel.Size = new Size(43, 17);
            lblUsuarioLabel.TabIndex = 1;
            lblUsuarioLabel.Text = "Usuario";
            // 
            // lblUsuarioValue
            // 
            lblUsuarioValue.BackColor = Color.Transparent;
            lblUsuarioValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuarioValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblUsuarioValue.Location = new Point(45, 22);
            lblUsuarioValue.Name = "lblUsuarioValue";
            lblUsuarioValue.Size = new Size(54, 19);
            lblUsuarioValue.TabIndex = 2;
            lblUsuarioValue.Text = "@admin";
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
            lblFechaIngresoValue.Size = new Size(28, 19);
            lblFechaIngresoValue.TabIndex = 2;
            lblFechaIngresoValue.Text = "N/A";
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
            btnEditarPerfil.Location = new Point(20, 440);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditarPerfil.Size = new Size(240, 40);
            btnEditarPerfil.TabIndex = 4;
            btnEditarPerfil.Text = "✏️ Editar Perfil";
            // 
            // panelDerecho
            // 
            panelDerecho.Controls.Add(panelEstadisticas);
            panelDerecho.Controls.Add(panelResumen);
            panelDerecho.Controls.Add(panelGrafico);
            panelDerecho.Controls.Add(panelAcciones);
            panelDerecho.Controls.Add(panelActividadReciente);
            panelDerecho.CustomizableEdges = customizableEdges37;
            panelDerecho.FillColor = Color.Transparent;
            panelDerecho.Location = new Point(320, 20);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.ShadowDecoration.CustomizableEdges = customizableEdges38;
            panelDerecho.Size = new Size(514, 495);
            panelDerecho.TabIndex = 1;
            // 
            // panelEstadisticas
            // 
            panelEstadisticas.Controls.Add(panelTotalMaestros);
            panelEstadisticas.Controls.Add(panelTotalEstudiantes);
            panelEstadisticas.Controls.Add(panelTotalGrupos);
            panelEstadisticas.Controls.Add(panelTotalLecciones);
            panelEstadisticas.CustomizableEdges = customizableEdges17;
            panelEstadisticas.FillColor = Color.Transparent;
            panelEstadisticas.Location = new Point(0, 0);
            panelEstadisticas.Name = "panelEstadisticas";
            panelEstadisticas.ShadowDecoration.CustomizableEdges = customizableEdges18;
            panelEstadisticas.Size = new Size(514, 100);
            panelEstadisticas.TabIndex = 0;
            // 
            // panelTotalMaestros
            // 
            panelTotalMaestros.BackColor = Color.Transparent;
            panelTotalMaestros.BorderRadius = 12;
            panelTotalMaestros.Controls.Add(lblTotalMaestrosValor);
            panelTotalMaestros.Controls.Add(lblTotalMaestrosTexto);
            panelTotalMaestros.CustomizableEdges = customizableEdges9;
            panelTotalMaestros.FillColor = Color.White;
            panelTotalMaestros.Location = new Point(10, 3);
            panelTotalMaestros.Name = "panelTotalMaestros";
            panelTotalMaestros.ShadowDecoration.BorderRadius = 15;
            panelTotalMaestros.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelTotalMaestros.ShadowDecoration.Depth = 5;
            panelTotalMaestros.ShadowDecoration.Enabled = true;
            panelTotalMaestros.Size = new Size(110, 77);
            panelTotalMaestros.TabIndex = 0;
            // 
            // lblTotalMaestrosValor
            // 
            lblTotalMaestrosValor.BackColor = Color.Transparent;
            lblTotalMaestrosValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalMaestrosValor.ForeColor = Color.FromArgb(102, 126, 234);
            lblTotalMaestrosValor.Location = new Point(10, 10);
            lblTotalMaestrosValor.Name = "lblTotalMaestrosValor";
            lblTotalMaestrosValor.Size = new Size(19, 39);
            lblTotalMaestrosValor.TabIndex = 0;
            lblTotalMaestrosValor.Text = "0";
            // 
            // lblTotalMaestrosTexto
            // 
            lblTotalMaestrosTexto.BackColor = Color.Transparent;
            lblTotalMaestrosTexto.Font = new Font("Segoe UI", 8F);
            lblTotalMaestrosTexto.ForeColor = Color.FromArgb(113, 128, 150);
            lblTotalMaestrosTexto.Location = new Point(10, 55);
            lblTotalMaestrosTexto.Name = "lblTotalMaestrosTexto";
            lblTotalMaestrosTexto.Size = new Size(50, 15);
            lblTotalMaestrosTexto.TabIndex = 1;
            lblTotalMaestrosTexto.Text = "Maestros";
            // 
            // panelTotalEstudiantes
            // 
            panelTotalEstudiantes.BackColor = Color.Transparent;
            panelTotalEstudiantes.BorderRadius = 12;
            panelTotalEstudiantes.Controls.Add(lblTotalEstudiantesValor);
            panelTotalEstudiantes.Controls.Add(lblTotalEstudiantesTexto);
            panelTotalEstudiantes.CustomizableEdges = customizableEdges11;
            panelTotalEstudiantes.FillColor = Color.White;
            panelTotalEstudiantes.Location = new Point(130, 3);
            panelTotalEstudiantes.Name = "panelTotalEstudiantes";
            panelTotalEstudiantes.ShadowDecoration.BorderRadius = 15;
            panelTotalEstudiantes.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelTotalEstudiantes.ShadowDecoration.Depth = 5;
            panelTotalEstudiantes.ShadowDecoration.Enabled = true;
            panelTotalEstudiantes.Size = new Size(120, 77);
            panelTotalEstudiantes.TabIndex = 1;
            // 
            // lblTotalEstudiantesValor
            // 
            lblTotalEstudiantesValor.BackColor = Color.Transparent;
            lblTotalEstudiantesValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalEstudiantesValor.ForeColor = Color.FromArgb(76, 175, 80);
            lblTotalEstudiantesValor.Location = new Point(10, 10);
            lblTotalEstudiantesValor.Name = "lblTotalEstudiantesValor";
            lblTotalEstudiantesValor.Size = new Size(19, 39);
            lblTotalEstudiantesValor.TabIndex = 0;
            lblTotalEstudiantesValor.Text = "0";
            // 
            // lblTotalEstudiantesTexto
            // 
            lblTotalEstudiantesTexto.BackColor = Color.Transparent;
            lblTotalEstudiantesTexto.Font = new Font("Segoe UI", 8F);
            lblTotalEstudiantesTexto.ForeColor = Color.FromArgb(113, 128, 150);
            lblTotalEstudiantesTexto.Location = new Point(10, 55);
            lblTotalEstudiantesTexto.Name = "lblTotalEstudiantesTexto";
            lblTotalEstudiantesTexto.Size = new Size(63, 15);
            lblTotalEstudiantesTexto.TabIndex = 1;
            lblTotalEstudiantesTexto.Text = "Estudiantes";
            // 
            // panelTotalGrupos
            // 
            panelTotalGrupos.BackColor = Color.Transparent;
            panelTotalGrupos.BorderRadius = 12;
            panelTotalGrupos.Controls.Add(lblTotalGruposValor);
            panelTotalGrupos.Controls.Add(lblTotalGruposTexto);
            panelTotalGrupos.CustomizableEdges = customizableEdges13;
            panelTotalGrupos.FillColor = Color.White;
            panelTotalGrupos.Location = new Point(260, 3);
            panelTotalGrupos.Name = "panelTotalGrupos";
            panelTotalGrupos.ShadowDecoration.BorderRadius = 15;
            panelTotalGrupos.ShadowDecoration.CustomizableEdges = customizableEdges14;
            panelTotalGrupos.ShadowDecoration.Depth = 5;
            panelTotalGrupos.ShadowDecoration.Enabled = true;
            panelTotalGrupos.Size = new Size(120, 77);
            panelTotalGrupos.TabIndex = 2;
            // 
            // lblTotalGruposValor
            // 
            lblTotalGruposValor.BackColor = Color.Transparent;
            lblTotalGruposValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalGruposValor.ForeColor = Color.FromArgb(255, 152, 0);
            lblTotalGruposValor.Location = new Point(10, 10);
            lblTotalGruposValor.Name = "lblTotalGruposValor";
            lblTotalGruposValor.Size = new Size(19, 39);
            lblTotalGruposValor.TabIndex = 0;
            lblTotalGruposValor.Text = "0";
            // 
            // lblTotalGruposTexto
            // 
            lblTotalGruposTexto.BackColor = Color.Transparent;
            lblTotalGruposTexto.Font = new Font("Segoe UI", 8F);
            lblTotalGruposTexto.ForeColor = Color.FromArgb(113, 128, 150);
            lblTotalGruposTexto.Location = new Point(10, 55);
            lblTotalGruposTexto.Name = "lblTotalGruposTexto";
            lblTotalGruposTexto.Size = new Size(41, 15);
            lblTotalGruposTexto.TabIndex = 1;
            lblTotalGruposTexto.Text = "Grupos";
            // 
            // panelTotalLecciones
            // 
            panelTotalLecciones.BackColor = Color.Transparent;
            panelTotalLecciones.BorderRadius = 12;
            panelTotalLecciones.Controls.Add(lblTotalLeccionesValor);
            panelTotalLecciones.Controls.Add(lblTotalLeccionesTexto);
            panelTotalLecciones.CustomizableEdges = customizableEdges15;
            panelTotalLecciones.FillColor = Color.White;
            panelTotalLecciones.Location = new Point(390, 3);
            panelTotalLecciones.Name = "panelTotalLecciones";
            panelTotalLecciones.ShadowDecoration.BorderRadius = 15;
            panelTotalLecciones.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelTotalLecciones.ShadowDecoration.Depth = 5;
            panelTotalLecciones.ShadowDecoration.Enabled = true;
            panelTotalLecciones.Size = new Size(119, 77);
            panelTotalLecciones.TabIndex = 3;
            // 
            // lblTotalLeccionesValor
            // 
            lblTotalLeccionesValor.BackColor = Color.Transparent;
            lblTotalLeccionesValor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalLeccionesValor.ForeColor = Color.FromArgb(156, 39, 176);
            lblTotalLeccionesValor.Location = new Point(10, 10);
            lblTotalLeccionesValor.Name = "lblTotalLeccionesValor";
            lblTotalLeccionesValor.Size = new Size(19, 39);
            lblTotalLeccionesValor.TabIndex = 0;
            lblTotalLeccionesValor.Text = "0";
            // 
            // lblTotalLeccionesTexto
            // 
            lblTotalLeccionesTexto.BackColor = Color.Transparent;
            lblTotalLeccionesTexto.Font = new Font("Segoe UI", 8F);
            lblTotalLeccionesTexto.ForeColor = Color.FromArgb(113, 128, 150);
            lblTotalLeccionesTexto.Location = new Point(10, 55);
            lblTotalLeccionesTexto.Name = "lblTotalLeccionesTexto";
            lblTotalLeccionesTexto.Size = new Size(52, 15);
            lblTotalLeccionesTexto.TabIndex = 1;
            lblTotalLeccionesTexto.Text = "Lecciones";
            // 
            // panelResumen
            // 
            panelResumen.BackColor = Color.Transparent;
            panelResumen.BorderRadius = 15;
            panelResumen.Controls.Add(lblTituloResumen);
            panelResumen.Controls.Add(dgvResumen);
            panelResumen.CustomizableEdges = customizableEdges19;
            panelResumen.FillColor = Color.White;
            panelResumen.Location = new Point(10, 110);
            panelResumen.Name = "panelResumen";
            panelResumen.ShadowDecoration.BorderRadius = 15;
            panelResumen.ShadowDecoration.CustomizableEdges = customizableEdges20;
            panelResumen.ShadowDecoration.Depth = 5;
            panelResumen.ShadowDecoration.Enabled = true;
            panelResumen.Size = new Size(240, 190);
            panelResumen.TabIndex = 1;
            // 
            // lblTituloResumen
            // 
            lblTituloResumen.BackColor = Color.Transparent;
            lblTituloResumen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloResumen.ForeColor = Color.FromArgb(45, 55, 72);
            lblTituloResumen.Location = new Point(10, 10);
            lblTituloResumen.Name = "lblTituloResumen";
            lblTituloResumen.Size = new Size(110, 19);
            lblTituloResumen.TabIndex = 0;
            lblTituloResumen.Text = "Resumen General";
            // 
            // dgvResumen
            // 
            dgvResumen.AllowUserToAddRows = false;
            dgvResumen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvResumen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 245, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(102, 126, 234);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvResumen.ColumnHeadersHeight = 30;
            dgvResumen.Columns.AddRange(new DataGridViewColumn[] { colTipo, colCantidad, colPorcentaje });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvResumen.DefaultCellStyle = dataGridViewCellStyle3;
            dgvResumen.GridColor = Color.FromArgb(231, 235, 240);
            dgvResumen.Location = new Point(10, 35);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.ReadOnly = true;
            dgvResumen.RowHeadersVisible = false;
            dgvResumen.Size = new Size(230, 140);
            dgvResumen.TabIndex = 1;
            dgvResumen.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvResumen.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvResumen.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvResumen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvResumen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvResumen.ThemeStyle.BackColor = Color.White;
            dgvResumen.ThemeStyle.GridColor = Color.FromArgb(231, 235, 240);
            dgvResumen.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvResumen.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvResumen.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvResumen.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvResumen.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvResumen.ThemeStyle.HeaderStyle.Height = 30;
            dgvResumen.ThemeStyle.ReadOnly = true;
            dgvResumen.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvResumen.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvResumen.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvResumen.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvResumen.ThemeStyle.RowsStyle.Height = 25;
            dgvResumen.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvResumen.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cant";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPorcentaje
            // 
            colPorcentaje.HeaderText = "%";
            colPorcentaje.Name = "colPorcentaje";
            colPorcentaje.ReadOnly = true;
            // 
            // panelGrafico
            // 
            panelGrafico.BackColor = Color.Transparent;
            panelGrafico.BorderRadius = 15;
            panelGrafico.Controls.Add(lblTituloGrafico);
            panelGrafico.Controls.Add(barraMaestros);
            panelGrafico.Controls.Add(barraEstudiantes);
            panelGrafico.Controls.Add(barraGrupos);
            panelGrafico.CustomizableEdges = customizableEdges27;
            panelGrafico.FillColor = Color.White;
            panelGrafico.Location = new Point(260, 110);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.ShadowDecoration.BorderRadius = 15;
            panelGrafico.ShadowDecoration.CustomizableEdges = customizableEdges28;
            panelGrafico.ShadowDecoration.Depth = 5;
            panelGrafico.ShadowDecoration.Enabled = true;
            panelGrafico.Size = new Size(249, 190);
            panelGrafico.TabIndex = 2;
            // 
            // lblTituloGrafico
            // 
            lblTituloGrafico.BackColor = Color.Transparent;
            lblTituloGrafico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloGrafico.ForeColor = Color.FromArgb(45, 55, 72);
            lblTituloGrafico.Location = new Point(10, 10);
            lblTituloGrafico.Name = "lblTituloGrafico";
            lblTituloGrafico.Size = new Size(79, 19);
            lblTituloGrafico.TabIndex = 0;
            lblTituloGrafico.Text = "Distribución";
            // 
            // barraMaestros
            // 
            barraMaestros.BackColor = Color.Transparent;
            barraMaestros.BorderRadius = 10;
            barraMaestros.Controls.Add(lblBarraMaestros);
            barraMaestros.CustomizableEdges = customizableEdges21;
            barraMaestros.FillColor = Color.FromArgb(102, 126, 234);
            barraMaestros.Location = new Point(10, 45);
            barraMaestros.Name = "barraMaestros";
            barraMaestros.ShadowDecoration.CustomizableEdges = customizableEdges22;
            barraMaestros.Size = new Size(80, 30);
            barraMaestros.TabIndex = 1;
            // 
            // lblBarraMaestros
            // 
            lblBarraMaestros.BackColor = Color.Transparent;
            lblBarraMaestros.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBarraMaestros.ForeColor = Color.White;
            lblBarraMaestros.Location = new Point(10, 8);
            lblBarraMaestros.Name = "lblBarraMaestros";
            lblBarraMaestros.Size = new Size(51, 15);
            lblBarraMaestros.TabIndex = 0;
            lblBarraMaestros.Text = "Maestros";
            // 
            // barraEstudiantes
            // 
            barraEstudiantes.BackColor = Color.Transparent;
            barraEstudiantes.BorderRadius = 10;
            barraEstudiantes.Controls.Add(lblBarraEstudiantes);
            barraEstudiantes.CustomizableEdges = customizableEdges23;
            barraEstudiantes.FillColor = Color.FromArgb(76, 175, 80);
            barraEstudiantes.Location = new Point(10, 85);
            barraEstudiantes.Name = "barraEstudiantes";
            barraEstudiantes.ShadowDecoration.CustomizableEdges = customizableEdges24;
            barraEstudiantes.Size = new Size(200, 30);
            barraEstudiantes.TabIndex = 2;
            // 
            // lblBarraEstudiantes
            // 
            lblBarraEstudiantes.BackColor = Color.Transparent;
            lblBarraEstudiantes.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBarraEstudiantes.ForeColor = Color.White;
            lblBarraEstudiantes.Location = new Point(10, 8);
            lblBarraEstudiantes.Name = "lblBarraEstudiantes";
            lblBarraEstudiantes.Size = new Size(63, 15);
            lblBarraEstudiantes.TabIndex = 0;
            lblBarraEstudiantes.Text = "Estudiantes";
            // 
            // barraGrupos
            // 
            barraGrupos.BackColor = Color.Transparent;
            barraGrupos.BorderRadius = 10;
            barraGrupos.Controls.Add(lblBarraGrupos);
            barraGrupos.CustomizableEdges = customizableEdges25;
            barraGrupos.FillColor = Color.FromArgb(255, 152, 0);
            barraGrupos.Location = new Point(10, 125);
            barraGrupos.Name = "barraGrupos";
            barraGrupos.ShadowDecoration.CustomizableEdges = customizableEdges26;
            barraGrupos.Size = new Size(120, 30);
            barraGrupos.TabIndex = 3;
            // 
            // lblBarraGrupos
            // 
            lblBarraGrupos.BackColor = Color.Transparent;
            lblBarraGrupos.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBarraGrupos.ForeColor = Color.White;
            lblBarraGrupos.Location = new Point(10, 8);
            lblBarraGrupos.Name = "lblBarraGrupos";
            lblBarraGrupos.Size = new Size(41, 15);
            lblBarraGrupos.TabIndex = 0;
            lblBarraGrupos.Text = "Grupos";
            // 
            // panelAcciones
            // 
            panelAcciones.BackColor = Color.Transparent;
            panelAcciones.Controls.Add(btnGestionMaestros);
            panelAcciones.Controls.Add(btnGestionEstudiantes);
            panelAcciones.Controls.Add(btnGestionGrupos);
            panelAcciones.CustomizableEdges = customizableEdges35;
            panelAcciones.FillColor = Color.Transparent;
            panelAcciones.Location = new Point(0, 310);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.ShadowDecoration.CustomizableEdges = customizableEdges36;
            panelAcciones.Size = new Size(514, 50);
            panelAcciones.TabIndex = 3;
            // 
            // btnGestionMaestros
            // 
            btnGestionMaestros.BorderRadius = 8;
            btnGestionMaestros.Cursor = Cursors.Hand;
            btnGestionMaestros.CustomizableEdges = customizableEdges29;
            btnGestionMaestros.FillColor = Color.FromArgb(102, 126, 234);
            btnGestionMaestros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGestionMaestros.ForeColor = Color.White;
            btnGestionMaestros.HoverState.FillColor = Color.FromArgb(92, 116, 224);
            btnGestionMaestros.Location = new Point(4, 7);
            btnGestionMaestros.Name = "btnGestionMaestros";
            btnGestionMaestros.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btnGestionMaestros.Size = new Size(160, 35);
            btnGestionMaestros.TabIndex = 0;
            btnGestionMaestros.Text = "👥 Gestión Maestros";
            // 
            // btnGestionEstudiantes
            // 
            btnGestionEstudiantes.BorderRadius = 8;
            btnGestionEstudiantes.Cursor = Cursors.Hand;
            btnGestionEstudiantes.CustomizableEdges = customizableEdges31;
            btnGestionEstudiantes.FillColor = Color.FromArgb(76, 175, 80);
            btnGestionEstudiantes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGestionEstudiantes.ForeColor = Color.White;
            btnGestionEstudiantes.HoverState.FillColor = Color.FromArgb(56, 142, 60);
            btnGestionEstudiantes.Location = new Point(174, 7);
            btnGestionEstudiantes.Name = "btnGestionEstudiantes";
            btnGestionEstudiantes.ShadowDecoration.CustomizableEdges = customizableEdges32;
            btnGestionEstudiantes.Size = new Size(165, 35);
            btnGestionEstudiantes.TabIndex = 1;
            btnGestionEstudiantes.Text = "🎓 Gestión Estudiantes";
            // 
            // btnGestionGrupos
            // 
            btnGestionGrupos.BorderRadius = 8;
            btnGestionGrupos.Cursor = Cursors.Hand;
            btnGestionGrupos.CustomizableEdges = customizableEdges33;
            btnGestionGrupos.FillColor = Color.FromArgb(255, 152, 0);
            btnGestionGrupos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGestionGrupos.ForeColor = Color.White;
            btnGestionGrupos.HoverState.FillColor = Color.FromArgb(245, 124, 0);
            btnGestionGrupos.Location = new Point(349, 7);
            btnGestionGrupos.Name = "btnGestionGrupos";
            btnGestionGrupos.ShadowDecoration.CustomizableEdges = customizableEdges34;
            btnGestionGrupos.Size = new Size(160, 35);
            btnGestionGrupos.TabIndex = 2;
            btnGestionGrupos.Text = "📚 Gestión Grupos";
            // 
            // panelActividadReciente
            // 
            panelActividadReciente.BackColor = Color.Transparent;
            panelActividadReciente.BorderRadius = 15;
            panelActividadReciente.Controls.Add(lblTituloActividad);
            panelActividadReciente.Controls.Add(lblUltimoAcceso);
            panelActividadReciente.Controls.Add(lblUltimoAccesoValue);
            panelActividadReciente.Controls.Add(lblTotalUsuarios);
            panelActividadReciente.Controls.Add(lblTotalUsuariosValue);
            panelActividadReciente.Controls.Add(lblSistema);
            panelActividadReciente.Controls.Add(lblSistemaValue);
            panelActividadReciente.CustomizableEdges = customizableEdges35;
            panelActividadReciente.FillColor = Color.White;
            panelActividadReciente.Location = new Point(10, 370);
            panelActividadReciente.Name = "panelActividadReciente";
            panelActividadReciente.ShadowDecoration.BorderRadius = 15;
            panelActividadReciente.ShadowDecoration.CustomizableEdges = customizableEdges36;
            panelActividadReciente.ShadowDecoration.Depth = 5;
            panelActividadReciente.ShadowDecoration.Enabled = true;
            panelActividadReciente.Size = new Size(499, 115);
            panelActividadReciente.TabIndex = 4;
            // 
            // lblTituloActividad
            // 
            lblTituloActividad.BackColor = Color.Transparent;
            lblTituloActividad.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloActividad.ForeColor = Color.FromArgb(45, 55, 72);
            lblTituloActividad.Location = new Point(15, 10);
            lblTituloActividad.Name = "lblTituloActividad";
            lblTituloActividad.Size = new Size(166, 19);
            lblTituloActividad.TabIndex = 0;
            lblTituloActividad.Text = "Información del Sistema";
            // 
            // lblUltimoAcceso
            // 
            lblUltimoAcceso.BackColor = Color.Transparent;
            lblUltimoAcceso.Font = new Font("Segoe UI", 9F);
            lblUltimoAcceso.ForeColor = Color.FromArgb(113, 128, 150);
            lblUltimoAcceso.Location = new Point(15, 40);
            lblUltimoAcceso.Name = "lblUltimoAcceso";
            lblUltimoAcceso.Size = new Size(81, 17);
            lblUltimoAcceso.TabIndex = 1;
            lblUltimoAcceso.Text = "Último acceso:";
            // 
            // lblUltimoAccesoValue
            // 
            lblUltimoAccesoValue.BackColor = Color.Transparent;
            lblUltimoAccesoValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUltimoAccesoValue.ForeColor = Color.FromArgb(45, 55, 72);
            lblUltimoAccesoValue.Location = new Point(115, 40);
            lblUltimoAccesoValue.Name = "lblUltimoAccesoValue";
            lblUltimoAccesoValue.Size = new Size(25, 17);
            lblUltimoAccesoValue.TabIndex = 2;
            lblUltimoAccesoValue.Text = "Hoy";
            // 
            // lblTotalUsuarios
            // 
            lblTotalUsuarios.BackColor = Color.Transparent;
            lblTotalUsuarios.Font = new Font("Segoe UI", 9F);
            lblTotalUsuarios.ForeColor = Color.FromArgb(113, 128, 150);
            lblTotalUsuarios.Location = new Point(15, 65);
            lblTotalUsuarios.Name = "lblTotalUsuarios";
            lblTotalUsuarios.Size = new Size(80, 17);
            lblTotalUsuarios.TabIndex = 3;
            lblTotalUsuarios.Text = "Total usuarios:";
            // 
            // lblTotalUsuariosValue
            // 
            lblTotalUsuariosValue.BackColor = Color.Transparent;
            lblTotalUsuariosValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalUsuariosValue.ForeColor = Color.FromArgb(102, 126, 234);
            lblTotalUsuariosValue.Location = new Point(115, 65);
            lblTotalUsuariosValue.Name = "lblTotalUsuariosValue";
            lblTotalUsuariosValue.Size = new Size(10, 17);
            lblTotalUsuariosValue.TabIndex = 4;
            lblTotalUsuariosValue.Text = "0";
            // 
            // lblSistema
            // 
            lblSistema.BackColor = Color.Transparent;
            lblSistema.Font = new Font("Segoe UI", 9F);
            lblSistema.ForeColor = Color.FromArgb(113, 128, 150);
            lblSistema.Location = new Point(15, 90);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(47, 17);
            lblSistema.TabIndex = 5;
            lblSistema.Text = "Sistema:";
            // 
            // lblSistemaValue
            // 
            lblSistemaValue.BackColor = Color.Transparent;
            lblSistemaValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSistemaValue.ForeColor = Color.FromArgb(76, 175, 80);
            lblSistemaValue.Location = new Point(115, 90);
            lblSistemaValue.Name = "lblSistemaValue";
            lblSistemaValue.Size = new Size(61, 17);
            lblSistemaValue.TabIndex = 6;
            lblSistemaValue.Text = "✅ En línea";
            // 
            // FrmPerfilAdmin
            // 
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(854, 535);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPerfilAdmin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Perfil del Administrador";
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
            panelEstadisticas.ResumeLayout(false);
            panelTotalMaestros.ResumeLayout(false);
            panelTotalMaestros.PerformLayout();
            panelTotalEstudiantes.ResumeLayout(false);
            panelTotalEstudiantes.PerformLayout();
            panelTotalGrupos.ResumeLayout(false);
            panelTotalGrupos.PerformLayout();
            panelTotalLecciones.ResumeLayout(false);
            panelTotalLecciones.PerformLayout();
            panelResumen.ResumeLayout(false);
            panelResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            panelGrafico.ResumeLayout(false);
            panelGrafico.PerformLayout();
            barraMaestros.ResumeLayout(false);
            barraMaestros.PerformLayout();
            barraEstudiantes.ResumeLayout(false);
            barraEstudiantes.PerformLayout();
            barraGrupos.ResumeLayout(false);
            barraGrupos.PerformLayout();
            panelAcciones.ResumeLayout(false);
            panelActividadReciente.ResumeLayout(false);
            panelActividadReciente.PerformLayout();
            ResumeLayout(false);
        }
    }
}