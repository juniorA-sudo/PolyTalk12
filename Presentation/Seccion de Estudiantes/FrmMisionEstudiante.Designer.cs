using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    partial class FrmMisionEstudiante
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblNombreEstudiante = new Label();
            lblBienvenida = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnContinuarLeccion = new Guna.UI2.WinForms.Guna2GradientButton();
            lblUltimaLeccion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelRacha = new Guna.UI2.WinForms.Guna2Panel();
            lblRachaDias = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelXP = new Guna.UI2.WinForms.Guna2Panel();
            lblXP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelProgreso = new Guna.UI2.WinForms.Guna2Panel();
            lblTituloProgreso = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblLeccionesCompletadas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            progressBarLecciones = new Guna.UI2.WinForms.Guna2ProgressBar();
            lblPorcentajeLecciones = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelStats = new Guna.UI2.WinForms.Guna2Panel();
            lblRachaLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblRachaDiasStat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblVocabularioLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblVocabulario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelAccesosRapidos = new Guna.UI2.WinForms.Guna2Panel();
            lblAccesosRapidos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnLeccionesRapido = new Guna.UI2.WinForms.Guna2GradientButton();
            btnVocabularioRapido = new Guna.UI2.WinForms.Guna2GradientButton();
            btnTareasRapido = new Guna.UI2.WinForms.Guna2GradientButton();
            panelTareas = new Guna.UI2.WinForms.Guna2Panel();
            lblTareasPendientes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            flpTareasPendientes = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            panelRacha.SuspendLayout();
            panelXP.SuspendLayout();
            panelProgreso.SuspendLayout();
            panelStats.SuspendLayout();
            panelAccesosRapidos.SuspendLayout();
            panelTareas.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.BorderRadius = 20;
            panelHeader.Controls.Add(lblNombreEstudiante);
            panelHeader.Controls.Add(lblBienvenida);
            panelHeader.Controls.Add(btnContinuarLeccion);
            panelHeader.Controls.Add(lblUltimaLeccion);
            panelHeader.Controls.Add(panelRacha);
            panelHeader.Controls.Add(panelXP);
            panelHeader.CustomizableEdges = customizableEdges7;
            panelHeader.FillColor = Color.FromArgb(255, 183, 70);
            panelHeader.FillColor2 = Color.FromArgb(255, 130, 100);
            panelHeader.Location = new Point(16, 14);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.Color = Color.FromArgb(25, 255, 130, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelHeader.ShadowDecoration.Depth = 8;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(548, 196);
            panelHeader.TabIndex = 0;
            // 
            // lblNombreEstudiante
            // 
            lblNombreEstudiante.AutoSize = true;
            lblNombreEstudiante.BackColor = Color.Transparent;
            lblNombreEstudiante.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            lblNombreEstudiante.ForeColor = Color.White;
            lblNombreEstudiante.Location = new Point(22, 14);
            lblNombreEstudiante.Name = "lblNombreEstudiante";
            lblNombreEstudiante.Size = new Size(284, 41);
            lblNombreEstudiante.TabIndex = 0;
            lblNombreEstudiante.Text = "¡Hola, Estudiante!";
            // 
            // lblBienvenida
            // 
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Segoe UI", 9.5F);
            lblBienvenida.ForeColor = Color.FromArgb(255, 245, 225);
            lblBienvenida.Location = new Point(24, 60);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(211, 19);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Tu racha sigue brillando. ¡Sigue así!";
            // 
            // btnContinuarLeccion
            // 
            btnContinuarLeccion.BackColor = Color.Transparent;
            btnContinuarLeccion.BorderRadius = 22;
            btnContinuarLeccion.CustomizableEdges = customizableEdges1;
            btnContinuarLeccion.DisabledState.FillColor = Color.FromArgb(200, 200, 200);
            btnContinuarLeccion.DisabledState.FillColor2 = Color.FromArgb(200, 200, 200);
            btnContinuarLeccion.FillColor = Color.White;
            btnContinuarLeccion.FillColor2 = Color.FromArgb(255, 250, 235);
            btnContinuarLeccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnContinuarLeccion.ForeColor = Color.FromArgb(160, 80, 0);
            btnContinuarLeccion.Location = new Point(22, 128);
            btnContinuarLeccion.Name = "btnContinuarLeccion";
            btnContinuarLeccion.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnContinuarLeccion.ShadowDecoration.Depth = 4;
            btnContinuarLeccion.ShadowDecoration.Enabled = true;
            btnContinuarLeccion.Size = new Size(260, 42);
            btnContinuarLeccion.TabIndex = 2;
            btnContinuarLeccion.Text = "▶ Continuar Lección";
            btnContinuarLeccion.Click += btnContinuarLeccion_Click;
            // 
            // lblUltimaLeccion
            // 
            lblUltimaLeccion.BackColor = Color.Transparent;
            lblUltimaLeccion.Font = new Font("Segoe UI", 8.5F);
            lblUltimaLeccion.ForeColor = Color.FromArgb(255, 240, 210);
            lblUltimaLeccion.Location = new Point(24, 174);
            lblUltimaLeccion.Name = "lblUltimaLeccion";
            lblUltimaLeccion.Size = new Size(91, 15);
            lblUltimaLeccion.TabIndex = 3;
            lblUltimaLeccion.Text = "A1 · Introducción";
            // 
            // panelRacha
            // 
            panelRacha.BorderRadius = 14;
            panelRacha.Controls.Add(lblRachaDias);
            panelRacha.CustomizableEdges = customizableEdges3;
            panelRacha.FillColor = Color.FromArgb(200, 80, 0);
            panelRacha.Location = new Point(330, 130);
            panelRacha.Name = "panelRacha";
            panelRacha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelRacha.Size = new Size(96, 38);
            panelRacha.TabIndex = 4;
            // 
            // lblRachaDias
            // 
            lblRachaDias.BackColor = Color.Transparent;
            lblRachaDias.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRachaDias.ForeColor = Color.White;
            lblRachaDias.Location = new Point(8, 10);
            lblRachaDias.Name = "lblRachaDias";
            lblRachaDias.Size = new Size(39, 19);
            lblRachaDias.TabIndex = 0;
            lblRachaDias.Text = "0 días";
            // 
            // panelXP
            // 
            panelXP.BorderRadius = 14;
            panelXP.Controls.Add(lblXP);
            panelXP.CustomizableEdges = customizableEdges5;
            panelXP.FillColor = Color.FromArgb(200, 80, 0);
            panelXP.Location = new Point(432, 130);
            panelXP.Name = "panelXP";
            panelXP.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelXP.Size = new Size(96, 38);
            panelXP.TabIndex = 5;
            // 
            // lblXP
            // 
            lblXP.BackColor = Color.Transparent;
            lblXP.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblXP.ForeColor = Color.White;
            lblXP.Location = new Point(8, 10);
            lblXP.Name = "lblXP";
            lblXP.Size = new Size(47, 19);
            lblXP.TabIndex = 0;
            lblXP.Text = "⭐ 0 XP";
            // 
            // panelProgreso
            // 
            panelProgreso.BackColor = Color.Transparent;
            panelProgreso.BorderRadius = 20;
            panelProgreso.Controls.Add(lblTituloProgreso);
            panelProgreso.Controls.Add(lblLeccionesCompletadas);
            panelProgreso.Controls.Add(progressBarLecciones);
            panelProgreso.Controls.Add(lblPorcentajeLecciones);
            panelProgreso.CustomizableEdges = customizableEdges11;
            panelProgreso.FillColor = Color.White;
            panelProgreso.Location = new Point(578, 14);
            panelProgreso.Name = "panelProgreso";
            panelProgreso.ShadowDecoration.Color = Color.FromArgb(18, 0, 0, 0);
            panelProgreso.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelProgreso.ShadowDecoration.Depth = 5;
            panelProgreso.ShadowDecoration.Enabled = true;
            panelProgreso.Size = new Size(260, 196);
            panelProgreso.TabIndex = 1;
            // 
            // lblTituloProgreso
            // 
            lblTituloProgreso.BackColor = Color.Transparent;
            lblTituloProgreso.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloProgreso.ForeColor = Color.FromArgb(30, 30, 50);
            lblTituloProgreso.Location = new Point(18, 16);
            lblTituloProgreso.Name = "lblTituloProgreso";
            lblTituloProgreso.Size = new Size(82, 22);
            lblTituloProgreso.TabIndex = 0;
            lblTituloProgreso.Text = "Meta diaria";
            // 
            // lblLeccionesCompletadas
            // 
            lblLeccionesCompletadas.BackColor = Color.Transparent;
            lblLeccionesCompletadas.Font = new Font("Segoe UI", 8.5F);
            lblLeccionesCompletadas.ForeColor = Color.FromArgb(160, 150, 130);
            lblLeccionesCompletadas.Location = new Point(18, 44);
            lblLeccionesCompletadas.Name = "lblLeccionesCompletadas";
            lblLeccionesCompletadas.Size = new Size(84, 15);
            lblLeccionesCompletadas.TabIndex = 1;
            lblLeccionesCompletadas.Text = "0 de 0 lecciones";
            // 
            // progressBarLecciones
            // 
            progressBarLecciones.BorderRadius = 8;
            progressBarLecciones.CustomizableEdges = customizableEdges9;
            progressBarLecciones.FillColor = Color.FromArgb(235, 225, 205);
            progressBarLecciones.Location = new Point(18, 70);
            progressBarLecciones.Name = "progressBarLecciones";
            progressBarLecciones.ProgressColor = Color.FromArgb(255, 140, 0);
            progressBarLecciones.ShadowDecoration.CustomizableEdges = customizableEdges10;
            progressBarLecciones.Size = new Size(224, 12);
            progressBarLecciones.TabIndex = 2;
            progressBarLecciones.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblPorcentajeLecciones
            // 
            lblPorcentajeLecciones.BackColor = Color.Transparent;
            lblPorcentajeLecciones.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            lblPorcentajeLecciones.ForeColor = Color.FromArgb(255, 140, 0);
            lblPorcentajeLecciones.Location = new Point(18, 92);
            lblPorcentajeLecciones.Name = "lblPorcentajeLecciones";
            lblPorcentajeLecciones.Size = new Size(58, 52);
            lblPorcentajeLecciones.TabIndex = 3;
            lblPorcentajeLecciones.Text = "0%";
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.Transparent;
            panelStats.BorderRadius = 20;
            panelStats.Controls.Add(lblRachaLabel);
            panelStats.Controls.Add(lblRachaDiasStat);
            panelStats.Controls.Add(lblVocabularioLabel);
            panelStats.Controls.Add(lblVocabulario);
            panelStats.CustomizableEdges = customizableEdges13;
            panelStats.FillColor = Color.White;
            panelStats.Location = new Point(16, 226);
            panelStats.Name = "panelStats";
            panelStats.ShadowDecoration.Color = Color.FromArgb(18, 0, 0, 0);
            panelStats.ShadowDecoration.CustomizableEdges = customizableEdges14;
            panelStats.ShadowDecoration.Depth = 5;
            panelStats.ShadowDecoration.Enabled = true;
            panelStats.Size = new Size(260, 294);
            panelStats.TabIndex = 2;
            // 
            // lblRachaLabel
            // 
            lblRachaLabel.BackColor = Color.Transparent;
            lblRachaLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRachaLabel.ForeColor = Color.FromArgb(100, 90, 70);
            lblRachaLabel.Location = new Point(18, 18);
            lblRachaLabel.Name = "lblRachaLabel";
            lblRachaLabel.Size = new Size(39, 19);
            lblRachaLabel.TabIndex = 0;
            lblRachaLabel.Text = "Racha";
            // 
            // lblRachaDiasStat
            // 
            lblRachaDiasStat.BackColor = Color.Transparent;
            lblRachaDiasStat.Font = new Font("Segoe UI Black", 34F, FontStyle.Bold);
            lblRachaDiasStat.ForeColor = Color.FromArgb(255, 140, 0);
            lblRachaDiasStat.Location = new Point(18, 40);
            lblRachaDiasStat.Name = "lblRachaDiasStat";
            lblRachaDiasStat.Size = new Size(133, 63);
            lblRachaDiasStat.TabIndex = 1;
            lblRachaDiasStat.Text = "0 días";
            // 
            // lblVocabularioLabel
            // 
            lblVocabularioLabel.BackColor = Color.Transparent;
            lblVocabularioLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVocabularioLabel.ForeColor = Color.FromArgb(100, 90, 70);
            lblVocabularioLabel.Location = new Point(18, 110);
            lblVocabularioLabel.Name = "lblVocabularioLabel";
            lblVocabularioLabel.Size = new Size(77, 19);
            lblVocabularioLabel.TabIndex = 2;
            lblVocabularioLabel.Text = "Vocabulario";
            // 
            // lblVocabulario
            // 
            lblVocabulario.BackColor = Color.Transparent;
            lblVocabulario.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            lblVocabulario.ForeColor = Color.FromArgb(200, 120, 0);
            lblVocabulario.Location = new Point(18, 132);
            lblVocabulario.Name = "lblVocabulario";
            lblVocabulario.Size = new Size(150, 42);
            lblVocabulario.TabIndex = 3;
            lblVocabulario.Text = "0 palabras";
            // 
            // panelAccesosRapidos
            // 
            panelAccesosRapidos.BackColor = Color.Transparent;
            panelAccesosRapidos.BorderRadius = 20;
            panelAccesosRapidos.Controls.Add(lblAccesosRapidos);
            panelAccesosRapidos.Controls.Add(btnLeccionesRapido);
            panelAccesosRapidos.Controls.Add(btnVocabularioRapido);
            panelAccesosRapidos.Controls.Add(btnTareasRapido);
            panelAccesosRapidos.CustomizableEdges = customizableEdges21;
            panelAccesosRapidos.FillColor = Color.White;
            panelAccesosRapidos.Location = new Point(578, 226);
            panelAccesosRapidos.Name = "panelAccesosRapidos";
            panelAccesosRapidos.ShadowDecoration.Color = Color.FromArgb(18, 0, 0, 0);
            panelAccesosRapidos.ShadowDecoration.CustomizableEdges = customizableEdges22;
            panelAccesosRapidos.ShadowDecoration.Depth = 6;
            panelAccesosRapidos.ShadowDecoration.Enabled = true;
            panelAccesosRapidos.Size = new Size(260, 130);
            panelAccesosRapidos.TabIndex = 4;
            // 
            // lblAccesosRapidos
            // 
            lblAccesosRapidos.BackColor = Color.Transparent;
            lblAccesosRapidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAccesosRapidos.ForeColor = Color.FromArgb(30, 30, 50);
            lblAccesosRapidos.Location = new Point(16, 14);
            lblAccesosRapidos.Name = "lblAccesosRapidos";
            lblAccesosRapidos.Size = new Size(127, 19);
            lblAccesosRapidos.TabIndex = 0;
            lblAccesosRapidos.Text = "⚡ Accesos Rápidos";
            // 
            // btnLeccionesRapido
            // 
            btnLeccionesRapido.BorderRadius = 14;
            btnLeccionesRapido.CustomizableEdges = customizableEdges15;
            btnLeccionesRapido.FillColor = Color.FromArgb(220, 215, 255);
            btnLeccionesRapido.FillColor2 = Color.FromArgb(220, 215, 255);
            btnLeccionesRapido.Font = new Font("Segoe UI", 11F);
            btnLeccionesRapido.ForeColor = Color.FromArgb(80, 60, 180);
            btnLeccionesRapido.Location = new Point(16, 44);
            btnLeccionesRapido.Name = "btnLeccionesRapido";
            btnLeccionesRapido.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnLeccionesRapido.Size = new Size(68, 66);
            btnLeccionesRapido.TabIndex = 1;
            btnLeccionesRapido.Text = "📖";
            btnLeccionesRapido.Click += btnLeccionesRapido_Click;
            // 
            // btnVocabularioRapido
            // 
            btnVocabularioRapido.BorderRadius = 14;
            btnVocabularioRapido.CustomizableEdges = customizableEdges17;
            btnVocabularioRapido.FillColor = Color.FromArgb(200, 255, 220);
            btnVocabularioRapido.FillColor2 = Color.FromArgb(200, 255, 220);
            btnVocabularioRapido.Font = new Font("Segoe UI", 11F);
            btnVocabularioRapido.ForeColor = Color.FromArgb(20, 120, 60);
            btnVocabularioRapido.Location = new Point(96, 44);
            btnVocabularioRapido.Name = "btnVocabularioRapido";
            btnVocabularioRapido.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnVocabularioRapido.Size = new Size(68, 66);
            btnVocabularioRapido.TabIndex = 2;
            btnVocabularioRapido.Text = "📚";
            btnVocabularioRapido.Click += btnVocabularioRapido_Click;
            // 
            // btnTareasRapido
            // 
            btnTareasRapido.BorderRadius = 14;
            btnTareasRapido.CustomizableEdges = customizableEdges19;
            btnTareasRapido.FillColor = Color.FromArgb(255, 220, 180);
            btnTareasRapido.FillColor2 = Color.FromArgb(255, 220, 180);
            btnTareasRapido.Font = new Font("Segoe UI", 11F);
            btnTareasRapido.ForeColor = Color.FromArgb(160, 80, 0);
            btnTareasRapido.Location = new Point(176, 44);
            btnTareasRapido.Name = "btnTareasRapido";
            btnTareasRapido.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnTareasRapido.Size = new Size(68, 66);
            btnTareasRapido.TabIndex = 3;
            btnTareasRapido.Text = "📋";
            btnTareasRapido.Click += btnTareasRapido_Click;
            // 
            // panelTareas
            // 
            panelTareas.BackColor = Color.Transparent;
            panelTareas.BorderRadius = 20;
            panelTareas.Controls.Add(lblTareasPendientes);
            panelTareas.Controls.Add(flpTareasPendientes);
            panelTareas.CustomizableEdges = customizableEdges23;
            panelTareas.FillColor = Color.White;
            panelTareas.Location = new Point(290, 226);
            panelTareas.Name = "panelTareas";
            panelTareas.ShadowDecoration.Color = Color.FromArgb(18, 0, 0, 0);
            panelTareas.ShadowDecoration.CustomizableEdges = customizableEdges24;
            panelTareas.ShadowDecoration.Depth = 5;
            panelTareas.ShadowDecoration.Enabled = true;
            panelTareas.Size = new Size(548, 294);
            panelTareas.TabIndex = 3;
            // 
            // lblTareasPendientes
            // 
            lblTareasPendientes.BackColor = Color.Transparent;
            lblTareasPendientes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTareasPendientes.ForeColor = Color.FromArgb(30, 30, 50);
            lblTareasPendientes.Location = new Point(18, 16);
            lblTareasPendientes.Name = "lblTareasPendientes";
            lblTareasPendientes.Size = new Size(130, 22);
            lblTareasPendientes.TabIndex = 0;
            lblTareasPendientes.Text = "Tareas Pendientes";
            // 
            // flpTareasPendientes
            // 
            flpTareasPendientes.AutoScroll = true;
            flpTareasPendientes.BackColor = Color.Transparent;
            flpTareasPendientes.FlowDirection = FlowDirection.TopDown;
            flpTareasPendientes.Location = new Point(18, 46);
            flpTareasPendientes.Name = "flpTareasPendientes";
            flpTareasPendientes.Size = new Size(510, 232);
            flpTareasPendientes.TabIndex = 1;
            flpTareasPendientes.WrapContents = false;
            // 
            // FrmMisionEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 240);
            ClientSize = new Size(854, 535);
            Controls.Add(panelHeader);
            Controls.Add(panelProgreso);
            Controls.Add(panelStats);
            Controls.Add(panelTareas);
            Controls.Add(panelAccesosRapidos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMisionEstudiante";
            Text = "Misión Estudiante";
            Load += FrmMisionEstudiante_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelRacha.ResumeLayout(false);
            panelRacha.PerformLayout();
            panelXP.ResumeLayout(false);
            panelXP.PerformLayout();
            panelProgreso.ResumeLayout(false);
            panelProgreso.PerformLayout();
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            panelAccesosRapidos.ResumeLayout(false);
            panelAccesosRapidos.PerformLayout();
            panelTareas.ResumeLayout(false);
            panelTareas.PerformLayout();
            ResumeLayout(false);
        }

        // Declaraciones
        private Guna.UI2.WinForms.Guna2GradientPanel panelHeader;
        private Label lblNombreEstudiante;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBienvenida;
        private Guna.UI2.WinForms.Guna2GradientButton btnContinuarLeccion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUltimaLeccion;
        private Guna.UI2.WinForms.Guna2Panel panelRacha;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRachaDias;
        private Guna.UI2.WinForms.Guna2Panel panelXP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblXP;
        private Guna.UI2.WinForms.Guna2Panel panelProgreso;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTituloProgreso;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLeccionesCompletadas;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBarLecciones;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPorcentajeLecciones;
        private Guna.UI2.WinForms.Guna2Panel panelStats;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRachaDiasStat;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRachaLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVocabulario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVocabularioLabel;
        private Guna.UI2.WinForms.Guna2Panel panelAccesosRapidos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAccesosRapidos;
        private Guna.UI2.WinForms.Guna2GradientButton btnLeccionesRapido;
        private Guna.UI2.WinForms.Guna2GradientButton btnVocabularioRapido;
        private Guna.UI2.WinForms.Guna2GradientButton btnTareasRapido;
        private Guna.UI2.WinForms.Guna2Panel panelTareas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTareasPendientes;
        private FlowLayoutPanel flpTareasPendientes;
    }
}