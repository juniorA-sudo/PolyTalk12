using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Administrador
{
    partial class FrmBienvenidaAdmin
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

        private Guna2Panel cardMaestros;
        private Guna2HtmlLabel lblMaestrosTitle;
        private Guna2HtmlLabel lblTotalMaestros;

        private Guna2Panel cardGrupos;
        private Guna2HtmlLabel lblGruposTitle;
        private Guna2HtmlLabel lblTotalGrupos;

        private Guna2Panel cardTareas;
        private Guna2HtmlLabel lblTareasTitle;
        private Guna2HtmlLabel lblTareasPendientes;

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

            cardMaestros = new Guna2Panel();
            lblMaestrosTitle = new Guna2HtmlLabel();
            lblTotalMaestros = new Guna2HtmlLabel();

            cardGrupos = new Guna2Panel();
            lblGruposTitle = new Guna2HtmlLabel();
            lblTotalGrupos = new Guna2HtmlLabel();

            cardTareas = new Guna2Panel();
            lblTareasTitle = new Guna2HtmlLabel();
            lblTareasPendientes = new Guna2HtmlLabel();

            btnEntrar = new Guna2Button();

            panelHeader.SuspendLayout();
            cardEstudiantes.SuspendLayout();
            cardMaestros.SuspendLayout();
            cardGrupos.SuspendLayout();
            cardTareas.SuspendLayout();
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
            lblRol.Text = "Administrador";

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
            lblEstudiantesTitle.Text = "TOTAL ESTUDIANTES";

            lblTotalEstudiantes.AutoSize = false;
            lblTotalEstudiantes.BackColor = Color.Transparent;
            lblTotalEstudiantes.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            lblTotalEstudiantes.ForeColor = Color.FromArgb(30, 90, 180);
            lblTotalEstudiantes.Location = new Point(12, 36);
            lblTotalEstudiantes.Name = "lblTotalEstudiantes";
            lblTotalEstudiantes.Size = new Size(176, 56);
            lblTotalEstudiantes.TabIndex = 1;
            lblTotalEstudiantes.Text = "0";

            // Card Maestros
            cardMaestros.BackColor = Color.Transparent;
            cardMaestros.BorderRadius = 14;
            cardMaestros.Controls.Add(lblMaestrosTitle);
            cardMaestros.Controls.Add(lblTotalMaestros);
            cardMaestros.CustomizableEdges = customizableEdges5;
            cardMaestros.FillColor = Color.FromArgb(240, 220, 255);
            cardMaestros.Location = new Point(240, 96);
            cardMaestros.Name = "cardMaestros";
            cardMaestros.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cardMaestros.Size = new Size(200, 100);
            cardMaestros.TabIndex = 2;

            lblMaestrosTitle.AutoSize = false;
            lblMaestrosTitle.BackColor = Color.Transparent;
            lblMaestrosTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaestrosTitle.ForeColor = Color.FromArgb(120, 40, 180);
            lblMaestrosTitle.Location = new Point(12, 12);
            lblMaestrosTitle.Name = "lblMaestrosTitle";
            lblMaestrosTitle.Size = new Size(160, 18);
            lblMaestrosTitle.TabIndex = 0;
            lblMaestrosTitle.Text = "TOTAL MAESTROS";

            lblTotalMaestros.AutoSize = false;
            lblTotalMaestros.BackColor = Color.Transparent;
            lblTotalMaestros.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            lblTotalMaestros.ForeColor = Color.FromArgb(120, 40, 180);
            lblTotalMaestros.Location = new Point(12, 36);
            lblTotalMaestros.Name = "lblTotalMaestros";
            lblTotalMaestros.Size = new Size(176, 56);
            lblTotalMaestros.TabIndex = 1;
            lblTotalMaestros.Text = "0";

            // Card Grupos
            cardGrupos.BackColor = Color.Transparent;
            cardGrupos.BorderRadius = 14;
            cardGrupos.Controls.Add(lblGruposTitle);
            cardGrupos.Controls.Add(lblTotalGrupos);
            cardGrupos.CustomizableEdges = customizableEdges7;
            cardGrupos.FillColor = Color.FromArgb(255, 240, 195);
            cardGrupos.Location = new Point(460, 96);
            cardGrupos.Name = "cardGrupos";
            cardGrupos.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cardGrupos.Size = new Size(200, 100);
            cardGrupos.TabIndex = 3;

            lblGruposTitle.AutoSize = false;
            lblGruposTitle.BackColor = Color.Transparent;
            lblGruposTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGruposTitle.ForeColor = Color.FromArgb(180, 100, 0);
            lblGruposTitle.Location = new Point(12, 12);
            lblGruposTitle.Name = "lblGruposTitle";
            lblGruposTitle.Size = new Size(160, 18);
            lblGruposTitle.TabIndex = 0;
            lblGruposTitle.Text = "TOTAL GRUPOS";

            lblTotalGrupos.AutoSize = false;
            lblTotalGrupos.BackColor = Color.Transparent;
            lblTotalGrupos.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            lblTotalGrupos.ForeColor = Color.FromArgb(180, 100, 0);
            lblTotalGrupos.Location = new Point(12, 36);
            lblTotalGrupos.Name = "lblTotalGrupos";
            lblTotalGrupos.Size = new Size(176, 56);
            lblTotalGrupos.TabIndex = 1;
            lblTotalGrupos.Text = "0";

            // Card Tareas Pendientes
            cardTareas.BackColor = Color.Transparent;
            cardTareas.BorderRadius = 14;
            cardTareas.Controls.Add(lblTareasTitle);
            cardTareas.Controls.Add(lblTareasPendientes);
            cardTareas.CustomizableEdges = customizableEdges9;
            cardTareas.FillColor = Color.FromArgb(255, 220, 220);
            cardTareas.Location = new Point(680, 96);
            cardTareas.Name = "cardTareas";
            cardTareas.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cardTareas.Size = new Size(200, 100);
            cardTareas.TabIndex = 4;

            lblTareasTitle.AutoSize = false;
            lblTareasTitle.BackColor = Color.Transparent;
            lblTareasTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTareasTitle.ForeColor = Color.FromArgb(200, 40, 40);
            lblTareasTitle.Location = new Point(12, 12);
            lblTareasTitle.Name = "lblTareasTitle";
            lblTareasTitle.Size = new Size(160, 18);
            lblTareasTitle.TabIndex = 0;
            lblTareasTitle.Text = "TAREAS PENDIENTES";

            lblTareasPendientes.AutoSize = false;
            lblTareasPendientes.BackColor = Color.Transparent;
            lblTareasPendientes.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
            lblTareasPendientes.ForeColor = Color.FromArgb(200, 40, 40);
            lblTareasPendientes.Location = new Point(12, 36);
            lblTareasPendientes.Name = "lblTareasPendientes";
            lblTareasPendientes.Size = new Size(176, 56);
            lblTareasPendientes.TabIndex = 1;
            lblTareasPendientes.Text = "0";

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
            Controls.Add(cardMaestros);
            Controls.Add(cardGrupos);
            Controls.Add(cardTareas);
            Controls.Add(btnEntrar);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBienvenidaAdmin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bienvenida Administrador";
            Load += FrmBienvenidaAdmin_Load;
            panelHeader.ResumeLayout(false);
            cardEstudiantes.ResumeLayout(false);
            cardMaestros.ResumeLayout(false);
            cardGrupos.ResumeLayout(false);
            cardTareas.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
