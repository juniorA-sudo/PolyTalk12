using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Maestros
{
    partial class FrmBienvenidaMaestro
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Guna2Panel panelHeader;
        private System.Windows.Forms.Label accentBar;
        private Guna2HtmlLabel lblSaludo;
        private Guna2HtmlLabel lblRol;

        // Stat Cards
        private Guna2Panel cardEstudiantes;
        private Guna2HtmlLabel lblEstudiantesTitle;
        private Guna2HtmlLabel lblTotalEstudiantes;

        private Guna2Panel cardGrupos;
        private Guna2HtmlLabel lblGruposTitle;
        private Guna2HtmlLabel lblTotalGrupos;

        private Guna2Panel cardEntregas;
        private Guna2HtmlLabel lblEntregasTitle;
        private Guna2HtmlLabel lblEntregasPendientes;

        private Guna2Panel cardLecciones;
        private Guna2HtmlLabel lblLeccionesTitle;
        private Guna2HtmlLabel lblLeccionesCreadas;

        // Footer
        private Guna2Button btnEntrar;

        private System.Windows.Forms.Timer timerAutoCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            timerAutoCerrar = new System.Windows.Forms.Timer(components);
            accentBar = new Label();
            panelHeader = new Guna2Panel();
            lblSaludo = new Guna2HtmlLabel();
            lblRol = new Guna2HtmlLabel();

            cardEstudiantes = new Guna2Panel();
            lblEstudiantesTitle = new Guna2HtmlLabel();
            lblTotalEstudiantes = new Guna2HtmlLabel();

            cardGrupos = new Guna2Panel();
            lblGruposTitle = new Guna2HtmlLabel();
            lblTotalGrupos = new Guna2HtmlLabel();

            cardEntregas = new Guna2Panel();
            lblEntregasTitle = new Guna2HtmlLabel();
            lblEntregasPendientes = new Guna2HtmlLabel();

            cardLecciones = new Guna2Panel();
            lblLeccionesTitle = new Guna2HtmlLabel();
            lblLeccionesCreadas = new Guna2HtmlLabel();

            btnEntrar = new Guna2Button();

            panelHeader.SuspendLayout();
            cardEstudiantes.SuspendLayout();
            cardGrupos.SuspendLayout();
            cardEntregas.SuspendLayout();
            cardLecciones.SuspendLayout();
            SuspendLayout();

            // Timer
            timerAutoCerrar.Interval = 15000;
            timerAutoCerrar.Tick += timerAutoCerrar_Tick;

            // Accent Bar
            accentBar.BackColor = Color.FromArgb(255, 183, 0);
            accentBar.Location = new Point(0, 0);
            accentBar.Name = "accentBar";
            accentBar.Size = new Size(5, 80);
            accentBar.TabIndex = 99;

            // Panel Header
            panelHeader.Controls.Add(accentBar);
            panelHeader.Controls.Add(lblSaludo);
            panelHeader.Controls.Add(lblRol);
            panelHeader.CustomizableEdges = customizableEdges1;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.White;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.Color = Color.FromArgb(14, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(900, 80);
            panelHeader.TabIndex = 0;

            // lblSaludo
            lblSaludo.AutoSize = false;
            lblSaludo.BackColor = Color.Transparent;
            lblSaludo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lblSaludo.ForeColor = Color.FromArgb(25, 25, 35);
            lblSaludo.Location = new Point(18, 10);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(500, 34);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "¡Bienvenido!";

            // lblRol
            lblRol.AutoSize = false;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Segoe UI", 9.5F);
            lblRol.ForeColor = Color.FromArgb(150, 140, 120);
            lblRol.Location = new Point(20, 46);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(380, 18);
            lblRol.TabIndex = 1;
            lblRol.Text = "Profesor";

            // Card Estudiantes
            cardEstudiantes.BackColor = Color.Transparent;
            cardEstudiantes.BorderRadius = 14;
            cardEstudiantes.Controls.Add(lblEstudiantesTitle);
            cardEstudiantes.Controls.Add(lblTotalEstudiantes);
            cardEstudiantes.CustomizableEdges = customizableEdges3;
            cardEstudiantes.FillColor = Color.FromArgb(220, 240, 255);
            cardEstudiantes.Location = new Point(20, 96);
            cardEstudiantes.Name = "cardEstudiantes";
            cardEstudiantes.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cardEstudiantes.Size = new Size(200, 100);
            cardEstudiantes.TabIndex = 1;

            lblEstudiantesTitle.AutoSize = false;
            lblEstudiantesTitle.BackColor = Color.Transparent;
            lblEstudiantesTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstudiantesTitle.ForeColor = Color.FromArgb(30, 90, 180);
            lblEstudiantesTitle.Location = new Point(12, 12);
            lblEstudiantesTitle.Name = "lblEstudiantesTitle";
            lblEstudiantesTitle.Size = new Size(160, 18);
            lblEstudiantesTitle.TabIndex = 0;
            lblEstudiantesTitle.Text = "MIS ESTUDIANTES";

            lblTotalEstudiantes.AutoSize = false;
            lblTotalEstudiantes.BackColor = Color.Transparent;
            lblTotalEstudiantes.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            lblTotalEstudiantes.ForeColor = Color.FromArgb(30, 90, 180);
            lblTotalEstudiantes.Location = new Point(12, 36);
            lblTotalEstudiantes.Name = "lblTotalEstudiantes";
            lblTotalEstudiantes.Size = new Size(176, 56);
            lblTotalEstudiantes.TabIndex = 1;
            lblTotalEstudiantes.Text = "0";

            // Card Grupos
            cardGrupos.BackColor = Color.Transparent;
            cardGrupos.BorderRadius = 14;
            cardGrupos.Controls.Add(lblGruposTitle);
            cardGrupos.Controls.Add(lblTotalGrupos);
            cardGrupos.CustomizableEdges = customizableEdges5;
            cardGrupos.FillColor = Color.FromArgb(255, 240, 195);
            cardGrupos.Location = new Point(240, 96);
            cardGrupos.Name = "cardGrupos";
            cardGrupos.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cardGrupos.Size = new Size(200, 100);
            cardGrupos.TabIndex = 2;

            lblGruposTitle.AutoSize = false;
            lblGruposTitle.BackColor = Color.Transparent;
            lblGruposTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGruposTitle.ForeColor = Color.FromArgb(180, 100, 0);
            lblGruposTitle.Location = new Point(12, 12);
            lblGruposTitle.Name = "lblGruposTitle";
            lblGruposTitle.Size = new Size(160, 18);
            lblGruposTitle.TabIndex = 0;
            lblGruposTitle.Text = "MIS GRUPOS";

            lblTotalGrupos.AutoSize = false;
            lblTotalGrupos.BackColor = Color.Transparent;
            lblTotalGrupos.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            lblTotalGrupos.ForeColor = Color.FromArgb(180, 100, 0);
            lblTotalGrupos.Location = new Point(12, 36);
            lblTotalGrupos.Name = "lblTotalGrupos";
            lblTotalGrupos.Size = new Size(176, 56);
            lblTotalGrupos.TabIndex = 1;
            lblTotalGrupos.Text = "0";

            // Card Entregas Pendientes
            cardEntregas.BackColor = Color.Transparent;
            cardEntregas.BorderRadius = 14;
            cardEntregas.Controls.Add(lblEntregasTitle);
            cardEntregas.Controls.Add(lblEntregasPendientes);
            cardEntregas.CustomizableEdges = customizableEdges7;
            cardEntregas.FillColor = Color.FromArgb(255, 220, 220);
            cardEntregas.Location = new Point(460, 96);
            cardEntregas.Name = "cardEntregas";
            cardEntregas.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cardEntregas.Size = new Size(200, 100);
            cardEntregas.TabIndex = 3;

            lblEntregasTitle.AutoSize = false;
            lblEntregasTitle.BackColor = Color.Transparent;
            lblEntregasTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEntregasTitle.ForeColor = Color.FromArgb(200, 40, 40);
            lblEntregasTitle.Location = new Point(12, 12);
            lblEntregasTitle.Name = "lblEntregasTitle";
            lblEntregasTitle.Size = new Size(160, 18);
            lblEntregasTitle.TabIndex = 0;
            lblEntregasTitle.Text = "POR CALIFICAR";

            lblEntregasPendientes.AutoSize = false;
            lblEntregasPendientes.BackColor = Color.Transparent;
            lblEntregasPendientes.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            lblEntregasPendientes.ForeColor = Color.FromArgb(200, 40, 40);
            lblEntregasPendientes.Location = new Point(12, 36);
            lblEntregasPendientes.Name = "lblEntregasPendientes";
            lblEntregasPendientes.Size = new Size(176, 56);
            lblEntregasPendientes.TabIndex = 1;
            lblEntregasPendientes.Text = "0";

            // Card Lecciones Creadas
            cardLecciones.BackColor = Color.Transparent;
            cardLecciones.BorderRadius = 14;
            cardLecciones.Controls.Add(lblLeccionesTitle);
            cardLecciones.Controls.Add(lblLeccionesCreadas);
            cardLecciones.CustomizableEdges = customizableEdges9;
            cardLecciones.FillColor = Color.FromArgb(240, 220, 255);
            cardLecciones.Location = new Point(680, 96);
            cardLecciones.Name = "cardLecciones";
            cardLecciones.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cardLecciones.Size = new Size(200, 100);
            cardLecciones.TabIndex = 4;

            lblLeccionesTitle.AutoSize = false;
            lblLeccionesTitle.BackColor = Color.Transparent;
            lblLeccionesTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLeccionesTitle.ForeColor = Color.FromArgb(120, 40, 180);
            lblLeccionesTitle.Location = new Point(12, 12);
            lblLeccionesTitle.Name = "lblLeccionesTitle";
            lblLeccionesTitle.Size = new Size(160, 18);
            lblLeccionesTitle.TabIndex = 0;
            lblLeccionesTitle.Text = "MIS LECCIONES";

            lblLeccionesCreadas.AutoSize = false;
            lblLeccionesCreadas.BackColor = Color.Transparent;
            lblLeccionesCreadas.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            lblLeccionesCreadas.ForeColor = Color.FromArgb(120, 40, 180);
            lblLeccionesCreadas.Location = new Point(12, 36);
            lblLeccionesCreadas.Name = "lblLeccionesCreadas";
            lblLeccionesCreadas.Size = new Size(176, 56);
            lblLeccionesCreadas.TabIndex = 1;
            lblLeccionesCreadas.Text = "0";

            // Button Entrar
            btnEntrar.BackColor = Color.Transparent;
            btnEntrar.BorderRadius = 24;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.CustomizableEdges = customizableEdges15;
            btnEntrar.FillColor = Color.FromArgb(255, 183, 0);
            btnEntrar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.HoverState.FillColor = Color.FromArgb(220, 155, 0);
            btnEntrar.Location = new Point(320, 220);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.ShadowDecoration.Color = Color.FromArgb(50, 255, 183, 0);
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnEntrar.ShadowDecoration.Depth = 8;
            btnEntrar.ShadowDecoration.Enabled = true;
            btnEntrar.Size = new Size(280, 50);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Continuar";
            btnEntrar.Click += btnEntrar_Click;

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 240);
            ClientSize = new Size(900, 290);
            Controls.Add(cardEstudiantes);
            Controls.Add(cardGrupos);
            Controls.Add(cardEntregas);
            Controls.Add(cardLecciones);
            Controls.Add(btnEntrar);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBienvenidaMaestro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bienvenida Profesor";
            Load += FrmBienvenidaMaestro_Load;
            panelHeader.ResumeLayout(false);
            cardEstudiantes.ResumeLayout(false);
            cardGrupos.ResumeLayout(false);
            cardEntregas.ResumeLayout(false);
            cardLecciones.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
