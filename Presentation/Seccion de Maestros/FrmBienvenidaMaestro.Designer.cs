using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Maestros
{
    partial class FrmBienvenidaMaestro
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
        private Guna2Panel cardGrupos;
        private Guna2HtmlLabel lblTotalGrupos;
        private Guna2HtmlLabel lblLblGrupos;
        private Guna2Panel cardEntregas;
        private Guna2HtmlLabel lblEntregasPendientes;
        private Guna2HtmlLabel lblLblEntregas;
        private Guna2Panel cardLecciones;
        private Guna2HtmlLabel lblLeccionesCreadas;
        private Guna2HtmlLabel lblLblLecciones;
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
            cardGrupos = new Guna2Panel();
            lblTotalGrupos = new Guna2HtmlLabel();
            lblLblGrupos = new Guna2HtmlLabel();
            cardEntregas = new Guna2Panel();
            lblEntregasPendientes = new Guna2HtmlLabel();
            lblLblEntregas = new Guna2HtmlLabel();
            cardLecciones = new Guna2Panel();
            lblLeccionesCreadas = new Guna2HtmlLabel();
            lblLblLecciones = new Guna2HtmlLabel();
            btnEntrar = new Guna2Button();
            timerAutoCerrar = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            cardEstudiantes.SuspendLayout();
            cardGrupos.SuspendLayout();
            cardEntregas.SuspendLayout();
            cardLecciones.SuspendLayout();
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
            lblSaludo.Text = "¡Bienvenido, Profesor!";
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
            lblRol.Text = "Profesor";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(cardEstudiantes);
            panelContent.Controls.Add(cardGrupos);
            panelContent.Controls.Add(cardEntregas);
            panelContent.Controls.Add(cardLecciones);
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
            lblLblEstudiantes.Text = "MIS ESTUDIANTES";
            // 
            // cardGrupos
            // 
            cardGrupos.BackColor = Color.Transparent;
            cardGrupos.BorderRadius = 16;
            cardGrupos.Controls.Add(lblTotalGrupos);
            cardGrupos.Controls.Add(lblLblGrupos);
            cardGrupos.CustomizableEdges = customizableEdges5;
            cardGrupos.FillColor = Color.FromArgb(255, 243, 224);
            cardGrupos.Location = new Point(224, 20);
            cardGrupos.Name = "cardGrupos";
            cardGrupos.ShadowDecoration.Color = Color.FromArgb(12, 255, 152, 0);
            cardGrupos.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cardGrupos.ShadowDecoration.Depth = 5;
            cardGrupos.ShadowDecoration.Enabled = true;
            cardGrupos.Size = new Size(190, 100);
            cardGrupos.TabIndex = 1;
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
            lblLblGrupos.Text = "MIS GRUPOS";
            // 
            // cardEntregas
            // 
            cardEntregas.BackColor = Color.Transparent;
            cardEntregas.BorderRadius = 16;
            cardEntregas.Controls.Add(lblEntregasPendientes);
            cardEntregas.Controls.Add(lblLblEntregas);
            cardEntregas.CustomizableEdges = customizableEdges7;
            cardEntregas.FillColor = Color.FromArgb(255, 240, 245);
            cardEntregas.Location = new Point(424, 20);
            cardEntregas.Name = "cardEntregas";
            cardEntregas.ShadowDecoration.Color = Color.FromArgb(12, 229, 57, 53);
            cardEntregas.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cardEntregas.ShadowDecoration.Depth = 5;
            cardEntregas.ShadowDecoration.Enabled = true;
            cardEntregas.Size = new Size(190, 100);
            cardEntregas.TabIndex = 2;
            // 
            // lblEntregasPendientes
            // 
            lblEntregasPendientes.AutoSize = false;
            lblEntregasPendientes.BackColor = Color.Transparent;
            lblEntregasPendientes.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            lblEntregasPendientes.ForeColor = Color.FromArgb(229, 57, 53);
            lblEntregasPendientes.Location = new Point(12, 12);
            lblEntregasPendientes.Name = "lblEntregasPendientes";
            lblEntregasPendientes.Size = new Size(166, 45);
            lblEntregasPendientes.TabIndex = 0;
            lblEntregasPendientes.Text = "0";
            // 
            // lblLblEntregas
            // 
            lblLblEntregas.AutoSize = false;
            lblLblEntregas.BackColor = Color.Transparent;
            lblLblEntregas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLblEntregas.ForeColor = Color.FromArgb(229, 57, 53);
            lblLblEntregas.Location = new Point(12, 65);
            lblLblEntregas.Name = "lblLblEntregas";
            lblLblEntregas.Size = new Size(166, 22);
            lblLblEntregas.TabIndex = 1;
            lblLblEntregas.Text = "POR CALIFICAR";
            // 
            // cardLecciones
            // 
            cardLecciones.BackColor = Color.Transparent;
            cardLecciones.BorderRadius = 16;
            cardLecciones.Controls.Add(lblLeccionesCreadas);
            cardLecciones.Controls.Add(lblLblLecciones);
            cardLecciones.CustomizableEdges = customizableEdges9;
            cardLecciones.FillColor = Color.FromArgb(240, 250, 230);
            cardLecciones.Location = new Point(624, 20);
            cardLecciones.Name = "cardLecciones";
            cardLecciones.ShadowDecoration.Color = Color.FromArgb(12, 76, 175, 80);
            cardLecciones.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cardLecciones.ShadowDecoration.Depth = 5;
            cardLecciones.ShadowDecoration.Enabled = true;
            cardLecciones.Size = new Size(190, 100);
            cardLecciones.TabIndex = 3;
            // 
            // lblLeccionesCreadas
            // 
            lblLeccionesCreadas.AutoSize = false;
            lblLeccionesCreadas.BackColor = Color.Transparent;
            lblLeccionesCreadas.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold);
            lblLeccionesCreadas.ForeColor = Color.FromArgb(76, 175, 80);
            lblLeccionesCreadas.Location = new Point(12, 12);
            lblLeccionesCreadas.Name = "lblLeccionesCreadas";
            lblLeccionesCreadas.Size = new Size(166, 45);
            lblLeccionesCreadas.TabIndex = 0;
            lblLeccionesCreadas.Text = "0";
            // 
            // lblLblLecciones
            // 
            lblLblLecciones.AutoSize = false;
            lblLblLecciones.BackColor = Color.Transparent;
            lblLblLecciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLblLecciones.ForeColor = Color.FromArgb(76, 175, 80);
            lblLblLecciones.Location = new Point(12, 65);
            lblLblLecciones.Name = "lblLblLecciones";
            lblLblLecciones.Size = new Size(166, 22);
            lblLblLecciones.TabIndex = 1;
            lblLblLecciones.Text = "MIS LECCIONES";
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
            // FrmBienvenidaMaestro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 240);
            ClientSize = new Size(854, 535);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBienvenidaMaestro";
            Text = "Bienvenida Profesor";
            Load += FrmBienvenidaMaestro_Load;
            panelHeader.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            cardEstudiantes.ResumeLayout(false);
            cardGrupos.ResumeLayout(false);
            cardEntregas.ResumeLayout(false);
            cardLecciones.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}