using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Administrador
{
    partial class FrmBienvenidaAdmin
    {
        private System.ComponentModel.IContainer components = null;

        private Label accentBar;
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblSaludo;
        private Guna2HtmlLabel lblRol;
        private Guna2Panel panelContent;
        private Guna2Panel cardEstudiantes;
        private Guna2HtmlLabel lblTotalEstudiantes;
        private Guna2HtmlLabel lblLblEstudiantes;
        private Guna2Panel cardMaestros;
        private Guna2HtmlLabel lblTotalMaestros;
        private Guna2HtmlLabel lblLblMaestros;
        private Guna2Panel cardGrupos;
        private Guna2HtmlLabel lblTotalGrupos;
        private Guna2HtmlLabel lblLblGrupos;
        private Guna2Panel cardTareas;
        private Guna2HtmlLabel lblTareasPendientes;
        private Guna2HtmlLabel lblLblTareas;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            accentBar = new Label();
            panelHeader = new Guna2Panel();
            lblSaludo = new Guna2HtmlLabel();
            lblRol = new Guna2HtmlLabel();
            panelContent = new Guna2Panel();
            cardEstudiantes = new Guna2Panel();
            lblTotalEstudiantes = new Guna2HtmlLabel();
            lblLblEstudiantes = new Guna2HtmlLabel();
            cardMaestros = new Guna2Panel();
            lblTotalMaestros = new Guna2HtmlLabel();
            lblLblMaestros = new Guna2HtmlLabel();
            cardGrupos = new Guna2Panel();
            lblTotalGrupos = new Guna2HtmlLabel();
            lblLblGrupos = new Guna2HtmlLabel();
            cardTareas = new Guna2Panel();
            lblTareasPendientes = new Guna2HtmlLabel();
            lblLblTareas = new Guna2HtmlLabel();
            btnEntrar = new Guna2Button();
            timerAutoCerrar = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            cardEstudiantes.SuspendLayout();
            cardMaestros.SuspendLayout();
            cardGrupos.SuspendLayout();
            cardTareas.SuspendLayout();
            SuspendLayout();
            // 
            // accentBar
            // 
            accentBar.BackColor = Color.FromArgb(255, 183, 0);
            accentBar.Location = new Point(0, 0);
            accentBar.Name = "accentBar";
            accentBar.Size = new Size(5, 95);
            accentBar.TabIndex = 99;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(accentBar);
            panelHeader.Controls.Add(lblSaludo);
            panelHeader.Controls.Add(lblRol);
            panelHeader.CustomizableEdges = customizableEdges1;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.White;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(854, 95);
            panelHeader.TabIndex = 0;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = false;
            lblSaludo.BackColor = Color.Transparent;
            lblSaludo.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblSaludo.ForeColor = Color.FromArgb(25, 25, 35);
            lblSaludo.Location = new Point(30, 15);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(500, 35);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "¡Bienvenido, Admin!";
            // 
            // lblRol
            // 
            lblRol.AutoSize = false;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Segoe UI", 11F);
            lblRol.ForeColor = Color.FromArgb(130, 120, 100);
            lblRol.Location = new Point(30, 52);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(300, 25);
            lblRol.TabIndex = 1;
            lblRol.Text = "Administrador";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(cardEstudiantes);
            panelContent.Controls.Add(cardMaestros);
            panelContent.Controls.Add(cardGrupos);
            panelContent.Controls.Add(cardTareas);
            panelContent.Controls.Add(btnEntrar);
            panelContent.CustomizableEdges = customizableEdges13;
            panelContent.Dock = DockStyle.Fill;
            panelContent.FillColor = Color.FromArgb(252, 248, 240);
            panelContent.Location = new Point(0, 95);
            panelContent.Name = "panelContent";
            panelContent.ShadowDecoration.CustomizableEdges = customizableEdges14;
            panelContent.Size = new Size(854, 440);
            panelContent.TabIndex = 1;
            // 
            // cardEstudiantes
            // 
            cardEstudiantes.BackColor = Color.Transparent;
            cardEstudiantes.BorderRadius = 16;
            cardEstudiantes.Controls.Add(lblTotalEstudiantes);
            cardEstudiantes.Controls.Add(lblLblEstudiantes);
            cardEstudiantes.CustomizableEdges = customizableEdges3;
            cardEstudiantes.FillColor = Color.FromArgb(230, 240, 255);
            cardEstudiantes.Location = new Point(24, 20);
            cardEstudiantes.Name = "cardEstudiantes";
            cardEstudiantes.ShadowDecoration.Color = Color.FromArgb(12, 66, 153, 225);
            cardEstudiantes.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cardEstudiantes.ShadowDecoration.Depth = 5;
            cardEstudiantes.ShadowDecoration.Enabled = true;
            cardEstudiantes.Size = new Size(190, 100);
            cardEstudiantes.TabIndex = 0;
            // 
            // lblTotalEstudiantes
            // 
            lblTotalEstudiantes.AutoSize = false;
            lblTotalEstudiantes.BackColor = Color.Transparent;
            lblTotalEstudiantes.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            lblTotalEstudiantes.ForeColor = Color.FromArgb(30, 80, 180);
            lblTotalEstudiantes.Location = new Point(12, 12);
            lblTotalEstudiantes.Name = "lblTotalEstudiantes";
            lblTotalEstudiantes.Size = new Size(166, 45);
            lblTotalEstudiantes.TabIndex = 0;
            lblTotalEstudiantes.Text = "0";
            // 
            // lblLblEstudiantes
            // 
            lblLblEstudiantes.AutoSize = false;
            lblLblEstudiantes.BackColor = Color.Transparent;
            lblLblEstudiantes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLblEstudiantes.ForeColor = Color.FromArgb(30, 80, 180);
            lblLblEstudiantes.Location = new Point(12, 65);
            lblLblEstudiantes.Name = "lblLblEstudiantes";
            lblLblEstudiantes.Size = new Size(166, 22);
            lblLblEstudiantes.TabIndex = 1;
            lblLblEstudiantes.Text = "ESTUDIANTES";
            // 
            // cardMaestros
            // 
            cardMaestros.BackColor = Color.Transparent;
            cardMaestros.BorderRadius = 16;
            cardMaestros.Controls.Add(lblTotalMaestros);
            cardMaestros.Controls.Add(lblLblMaestros);
            cardMaestros.CustomizableEdges = customizableEdges5;
            cardMaestros.FillColor = Color.FromArgb(240, 250, 230);
            cardMaestros.Location = new Point(224, 20);
            cardMaestros.Name = "cardMaestros";
            cardMaestros.ShadowDecoration.Color = Color.FromArgb(12, 76, 175, 80);
            cardMaestros.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cardMaestros.ShadowDecoration.Depth = 5;
            cardMaestros.ShadowDecoration.Enabled = true;
            cardMaestros.Size = new Size(190, 100);
            cardMaestros.TabIndex = 1;
            // 
            // lblTotalMaestros
            // 
            lblTotalMaestros.AutoSize = false;
            lblTotalMaestros.BackColor = Color.Transparent;
            lblTotalMaestros.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            lblTotalMaestros.ForeColor = Color.FromArgb(76, 175, 80);
            lblTotalMaestros.Location = new Point(12, 12);
            lblTotalMaestros.Name = "lblTotalMaestros";
            lblTotalMaestros.Size = new Size(166, 45);
            lblTotalMaestros.TabIndex = 0;
            lblTotalMaestros.Text = "0";
            // 
            // lblLblMaestros
            // 
            lblLblMaestros.AutoSize = false;
            lblLblMaestros.BackColor = Color.Transparent;
            lblLblMaestros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLblMaestros.ForeColor = Color.FromArgb(76, 175, 80);
            lblLblMaestros.Location = new Point(12, 65);
            lblLblMaestros.Name = "lblLblMaestros";
            lblLblMaestros.Size = new Size(166, 22);
            lblLblMaestros.TabIndex = 1;
            lblLblMaestros.Text = "MAESTROS";
            // 
            // cardGrupos
            // 
            cardGrupos.BackColor = Color.Transparent;
            cardGrupos.BorderRadius = 16;
            cardGrupos.Controls.Add(lblTotalGrupos);
            cardGrupos.Controls.Add(lblLblGrupos);
            cardGrupos.CustomizableEdges = customizableEdges7;
            cardGrupos.FillColor = Color.FromArgb(255, 243, 224);
            cardGrupos.Location = new Point(424, 20);
            cardGrupos.Name = "cardGrupos";
            cardGrupos.ShadowDecoration.Color = Color.FromArgb(12, 255, 152, 0);
            cardGrupos.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cardGrupos.ShadowDecoration.Depth = 5;
            cardGrupos.ShadowDecoration.Enabled = true;
            cardGrupos.Size = new Size(190, 100);
            cardGrupos.TabIndex = 2;
            // 
            // lblTotalGrupos
            // 
            lblTotalGrupos.AutoSize = false;
            lblTotalGrupos.BackColor = Color.Transparent;
            lblTotalGrupos.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            lblTotalGrupos.ForeColor = Color.FromArgb(255, 152, 0);
            lblTotalGrupos.Location = new Point(12, 12);
            lblTotalGrupos.Name = "lblTotalGrupos";
            lblTotalGrupos.Size = new Size(166, 45);
            lblTotalGrupos.TabIndex = 0;
            lblTotalGrupos.Text = "0";
            // 
            // lblLblGrupos
            // 
            lblLblGrupos.AutoSize = false;
            lblLblGrupos.BackColor = Color.Transparent;
            lblLblGrupos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLblGrupos.ForeColor = Color.FromArgb(255, 152, 0);
            lblLblGrupos.Location = new Point(12, 65);
            lblLblGrupos.Name = "lblLblGrupos";
            lblLblGrupos.Size = new Size(166, 22);
            lblLblGrupos.TabIndex = 1;
            lblLblGrupos.Text = "GRUPOS";
            // 
            // cardTareas
            // 
            cardTareas.BackColor = Color.Transparent;
            cardTareas.BorderRadius = 16;
            cardTareas.Controls.Add(lblTareasPendientes);
            cardTareas.Controls.Add(lblLblTareas);
            cardTareas.CustomizableEdges = customizableEdges9;
            cardTareas.FillColor = Color.FromArgb(255, 240, 245);
            cardTareas.Location = new Point(624, 20);
            cardTareas.Name = "cardTareas";
            cardTareas.ShadowDecoration.Color = Color.FromArgb(12, 229, 57, 53);
            cardTareas.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cardTareas.ShadowDecoration.Depth = 5;
            cardTareas.ShadowDecoration.Enabled = true;
            cardTareas.Size = new Size(190, 100);
            cardTareas.TabIndex = 3;
            // 
            // lblTareasPendientes
            // 
            lblTareasPendientes.AutoSize = false;
            lblTareasPendientes.BackColor = Color.Transparent;
            lblTareasPendientes.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            lblTareasPendientes.ForeColor = Color.FromArgb(229, 57, 53);
            lblTareasPendientes.Location = new Point(12, 12);
            lblTareasPendientes.Name = "lblTareasPendientes";
            lblTareasPendientes.Size = new Size(166, 45);
            lblTareasPendientes.TabIndex = 0;
            lblTareasPendientes.Text = "0";
            // 
            // lblLblTareas
            // 
            lblLblTareas.AutoSize = false;
            lblLblTareas.BackColor = Color.Transparent;
            lblLblTareas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLblTareas.ForeColor = Color.FromArgb(229, 57, 53);
            lblLblTareas.Location = new Point(12, 65);
            lblLblTareas.Name = "lblLblTareas";
            lblLblTareas.Size = new Size(166, 22);
            lblLblTareas.TabIndex = 1;
            lblLblTareas.Text = "TAREAS DRAFT";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Transparent;
            btnEntrar.BorderRadius = 20;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.CustomizableEdges = customizableEdges11;
            btnEntrar.FillColor = Color.FromArgb(255, 183, 0);
            btnEntrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.HoverState.FillColor = Color.FromArgb(220, 155, 0);
            btnEntrar.Location = new Point(327, 360);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.ShadowDecoration.Color = Color.FromArgb(40, 255, 183, 0);
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnEntrar.ShadowDecoration.Depth = 6;
            btnEntrar.ShadowDecoration.Enabled = true;
            btnEntrar.Size = new Size(200, 50);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "➜ ENTRAR AL SISTEMA";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // timerAutoCerrar
            // 
            timerAutoCerrar.Interval = 4000;
            timerAutoCerrar.Tick += timerAutoCerrar_Tick;
            // 
            // FrmBienvenidaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 240);
            ClientSize = new Size(854, 535);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBienvenidaAdmin";
            Text = "Bienvenida Admin";
            Load += FrmBienvenidaAdmin_Load;
            panelHeader.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            cardEstudiantes.ResumeLayout(false);
            cardMaestros.ResumeLayout(false);
            cardGrupos.ResumeLayout(false);
            cardTareas.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}