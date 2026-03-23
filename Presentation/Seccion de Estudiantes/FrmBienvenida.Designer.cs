using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation
{
    partial class FrmBienvenida
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Guna2Panel panelHeader;
        private System.Windows.Forms.Label accentBar;
        private Guna2HtmlLabel lblSaludo;
        private Guna2HtmlLabel lblNivel;
        private Guna2Panel panelStreak;
        private Guna2HtmlLabel lblStreakLabel;
        private Guna2HtmlLabel lblStreakValor;

        // Panel izquierdo - palabra del dia
        private Guna2Panel panelIzq;
        private Guna2HtmlLabel lblTituloSeccion;
        private Guna2HtmlLabel lblPalabraLabel;
        private Guna2HtmlLabel lblPalabra;
        private Guna2HtmlLabel lblSignificadoLabel;
        private Guna2HtmlLabel lblSignificado;
        private Guna2Button btnEscuchar;
        private Guna2Button btnSiguiente;

        // Panel derecho - detalle
        private Guna2Panel panelDer;
        private Guna2HtmlLabel lblDetalleTitle;
        private Guna2Panel cardEjemplo;
        private Guna2HtmlLabel lblEjemploLabel;
        private Guna2HtmlLabel lblEjemplo;
        private Guna2Panel cardPron;
        private Guna2HtmlLabel lblPronLabel;
        private Guna2HtmlLabel lblPronunciacion;
        private Guna2Panel cardStreak2;
        private Guna2HtmlLabel lblStreakTitle;
        private Guna2HtmlLabel lblStreakDesc;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            timerAutoCerrar = new System.Windows.Forms.Timer(components);
            accentBar = new Label();
            panelHeader = new Guna2Panel();
            lblSaludo = new Guna2HtmlLabel();
            lblNivel = new Guna2HtmlLabel();
            panelIzq = new Guna2Panel();
            lblTituloSeccion = new Guna2HtmlLabel();
            lblPalabraLabel = new Guna2HtmlLabel();
            lblPalabra = new Guna2HtmlLabel();
            lblSignificadoLabel = new Guna2HtmlLabel();
            lblSignificado = new Guna2HtmlLabel();
            btnEscuchar = new Guna2Button();
            btnSiguiente = new Guna2Button();
            panelDer = new Guna2Panel();
            lblDetalleTitle = new Guna2HtmlLabel();
            cardEjemplo = new Guna2Panel();
            lblEjemploLabel = new Guna2HtmlLabel();
            lblEjemplo = new Guna2HtmlLabel();
            cardPron = new Guna2Panel();
            lblPronLabel = new Guna2HtmlLabel();
            lblPronunciacion = new Guna2HtmlLabel();
            cardStreak2 = new Guna2Panel();
            lblStreakTitle = new Guna2HtmlLabel();
            lblStreakDesc = new Guna2HtmlLabel();
            btnEntrar = new Guna2Button();
            panelHeader.SuspendLayout();
            panelIzq.SuspendLayout();
            panelDer.SuspendLayout();
            cardEjemplo.SuspendLayout();
            cardPron.SuspendLayout();
            cardStreak2.SuspendLayout();
            SuspendLayout();
            // 
            // timerAutoCerrar
            // 
            timerAutoCerrar.Interval = 15000;
            timerAutoCerrar.Tick += timerAutoCerrar_Tick;
            // 
            // accentBar
            // 
            accentBar.BackColor = Color.FromArgb(255, 183, 0);
            accentBar.Location = new Point(0, 0);
            accentBar.Name = "accentBar";
            accentBar.Size = new Size(5, 80);
            accentBar.TabIndex = 99;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(accentBar);
            panelHeader.Controls.Add(lblSaludo);
            panelHeader.Controls.Add(lblNivel);
            panelHeader.CustomizableEdges = customizableEdges1;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.White;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.Color = Color.FromArgb(14, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(851, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = false;
            lblSaludo.BackColor = Color.Transparent;
            lblSaludo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lblSaludo.ForeColor = Color.FromArgb(25, 25, 35);
            lblSaludo.Location = new Point(18, 10);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(500, 34);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "Hola!";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = false;
            lblNivel.BackColor = Color.Transparent;
            lblNivel.Font = new Font("Segoe UI", 9.5F);
            lblNivel.ForeColor = Color.FromArgb(150, 140, 120);
            lblNivel.Location = new Point(20, 46);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(380, 18);
            lblNivel.TabIndex = 1;
            lblNivel.Text = "Aprendiz de Ingles  |  Nivel A1";
            // 
            // panelIzq
            // 
            panelIzq.BackColor = Color.Transparent;
            panelIzq.BorderRadius = 20;
            panelIzq.Controls.Add(lblTituloSeccion);
            panelIzq.Controls.Add(lblPalabraLabel);
            panelIzq.Controls.Add(lblPalabra);
            panelIzq.Controls.Add(lblSignificadoLabel);
            panelIzq.Controls.Add(lblSignificado);
            panelIzq.Controls.Add(btnEscuchar);
            panelIzq.Controls.Add(btnSiguiente);
            panelIzq.CustomizableEdges = customizableEdges7;
            panelIzq.FillColor = Color.White;
            panelIzq.Location = new Point(12, 96);
            panelIzq.Name = "panelIzq";
            panelIzq.ShadowDecoration.Color = Color.FromArgb(18, 0, 0, 0);
            panelIzq.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelIzq.ShadowDecoration.Depth = 10;
            panelIzq.ShadowDecoration.Enabled = true;
            panelIzq.Size = new Size(378, 268);
            panelIzq.TabIndex = 1;
            // 
            // lblTituloSeccion
            // 
            lblTituloSeccion.AutoSize = false;
            lblTituloSeccion.BackColor = Color.Transparent;
            lblTituloSeccion.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTituloSeccion.ForeColor = Color.FromArgb(160, 130, 80);
            lblTituloSeccion.Location = new Point(20, 18);
            lblTituloSeccion.Name = "lblTituloSeccion";
            lblTituloSeccion.Size = new Size(160, 16);
            lblTituloSeccion.TabIndex = 0;
            lblTituloSeccion.Text = "PALABRA DEL DIA";
            // 
            // lblPalabraLabel
            // 
            lblPalabraLabel.AutoSize = false;
            lblPalabraLabel.BackColor = Color.Transparent;
            lblPalabraLabel.Font = new Font("Segoe UI", 8F);
            lblPalabraLabel.ForeColor = Color.FromArgb(160, 150, 130);
            lblPalabraLabel.Location = new Point(20, 42);
            lblPalabraLabel.Name = "lblPalabraLabel";
            lblPalabraLabel.Size = new Size(80, 14);
            lblPalabraLabel.TabIndex = 1;
            lblPalabraLabel.Text = "INGLES";
            // 
            // lblPalabra
            // 
            lblPalabra.AutoSize = false;
            lblPalabra.BackColor = Color.Transparent;
            lblPalabra.Font = new Font("Segoe UI Black", 42F, FontStyle.Bold);
            lblPalabra.ForeColor = Color.FromArgb(255, 140, 0);
            lblPalabra.Location = new Point(16, 56);
            lblPalabra.Name = "lblPalabra";
            lblPalabra.Size = new Size(340, 76);
            lblPalabra.TabIndex = 2;
            lblPalabra.Text = "Star";
            lblPalabra.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblSignificadoLabel
            // 
            lblSignificadoLabel.AutoSize = false;
            lblSignificadoLabel.BackColor = Color.Transparent;
            lblSignificadoLabel.Font = new Font("Segoe UI", 8F);
            lblSignificadoLabel.ForeColor = Color.FromArgb(160, 150, 130);
            lblSignificadoLabel.Location = new Point(20, 138);
            lblSignificadoLabel.Name = "lblSignificadoLabel";
            lblSignificadoLabel.Size = new Size(80, 14);
            lblSignificadoLabel.TabIndex = 3;
            lblSignificadoLabel.Text = "ESPANOL";
            // 
            // lblSignificado
            // 
            lblSignificado.AutoSize = false;
            lblSignificado.BackColor = Color.Transparent;
            lblSignificado.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSignificado.ForeColor = Color.FromArgb(80, 70, 50);
            lblSignificado.Location = new Point(18, 154);
            lblSignificado.Name = "lblSignificado";
            lblSignificado.Size = new Size(340, 40);
            lblSignificado.TabIndex = 4;
            lblSignificado.Text = "Estrella";
            // 
            // btnEscuchar
            // 
            btnEscuchar.BackColor = Color.Transparent;
            btnEscuchar.BorderRadius = 22;
            btnEscuchar.Cursor = Cursors.Hand;
            btnEscuchar.CustomizableEdges = customizableEdges3;
            btnEscuchar.FillColor = Color.FromArgb(255, 183, 0);
            btnEscuchar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEscuchar.ForeColor = Color.White;
            btnEscuchar.HoverState.FillColor = Color.FromArgb(220, 155, 0);
            btnEscuchar.Location = new Point(18, 210);
            btnEscuchar.Name = "btnEscuchar";
            btnEscuchar.ShadowDecoration.Color = Color.FromArgb(40, 255, 183, 0);
            btnEscuchar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEscuchar.ShadowDecoration.Depth = 6;
            btnEscuchar.ShadowDecoration.Enabled = true;
            btnEscuchar.Size = new Size(160, 40);
            btnEscuchar.TabIndex = 5;
            btnEscuchar.Text = "Escuchar";
            btnEscuchar.Click += btnEscuchar_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BorderRadius = 22;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.CustomizableEdges = customizableEdges5;
            btnSiguiente.FillColor = Color.FromArgb(240, 235, 225);
            btnSiguiente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSiguiente.ForeColor = Color.FromArgb(130, 120, 90);
            btnSiguiente.HoverState.FillColor = Color.FromArgb(225, 215, 195);
            btnSiguiente.Location = new Point(188, 210);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSiguiente.Size = new Size(160, 40);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // panelDer
            // 
            panelDer.BackColor = Color.Transparent;
            panelDer.BorderRadius = 20;
            panelDer.Controls.Add(lblDetalleTitle);
            panelDer.Controls.Add(cardEjemplo);
            panelDer.Controls.Add(cardPron);
            panelDer.Controls.Add(cardStreak2);
            panelDer.CustomizableEdges = customizableEdges15;
            panelDer.FillColor = Color.White;
            panelDer.Location = new Point(404, 96);
            panelDer.Name = "panelDer";
            panelDer.ShadowDecoration.Color = Color.FromArgb(18, 0, 0, 0);
            panelDer.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelDer.ShadowDecoration.Depth = 10;
            panelDer.ShadowDecoration.Enabled = true;
            panelDer.Size = new Size(435, 268);
            panelDer.TabIndex = 2;
            // 
            // lblDetalleTitle
            // 
            lblDetalleTitle.AutoSize = false;
            lblDetalleTitle.BackColor = Color.Transparent;
            lblDetalleTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDetalleTitle.ForeColor = Color.FromArgb(160, 130, 80);
            lblDetalleTitle.Location = new Point(16, 18);
            lblDetalleTitle.Name = "lblDetalleTitle";
            lblDetalleTitle.Size = new Size(150, 16);
            lblDetalleTitle.TabIndex = 0;
            lblDetalleTitle.Text = "COMO USARLA";
            // 
            // cardEjemplo
            // 
            cardEjemplo.BackColor = Color.Transparent;
            cardEjemplo.BorderRadius = 14;
            cardEjemplo.Controls.Add(lblEjemploLabel);
            cardEjemplo.Controls.Add(lblEjemplo);
            cardEjemplo.CustomizableEdges = customizableEdges9;
            cardEjemplo.FillColor = Color.FromArgb(255, 248, 230);
            cardEjemplo.Location = new Point(14, 44);
            cardEjemplo.Name = "cardEjemplo";
            cardEjemplo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cardEjemplo.Size = new Size(418, 62);
            cardEjemplo.TabIndex = 1;
            // 
            // lblEjemploLabel
            // 
            lblEjemploLabel.AutoSize = false;
            lblEjemploLabel.BackColor = Color.Transparent;
            lblEjemploLabel.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblEjemploLabel.ForeColor = Color.FromArgb(160, 130, 80);
            lblEjemploLabel.Location = new Point(14, 10);
            lblEjemploLabel.Name = "lblEjemploLabel";
            lblEjemploLabel.Size = new Size(80, 14);
            lblEjemploLabel.TabIndex = 0;
            lblEjemploLabel.Text = "EJEMPLO";
            // 
            // lblEjemplo
            // 
            lblEjemplo.AutoSize = false;
            lblEjemplo.BackColor = Color.Transparent;
            lblEjemplo.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblEjemplo.ForeColor = Color.FromArgb(50, 45, 35);
            lblEjemplo.Location = new Point(14, 26);
            lblEjemplo.Name = "lblEjemplo";
            lblEjemplo.Size = new Size(390, 26);
            lblEjemplo.TabIndex = 1;
            lblEjemplo.Text = "Look at the stars tonight.";
            // 
            // cardPron
            // 
            cardPron.BackColor = Color.Transparent;
            cardPron.BorderRadius = 14;
            cardPron.Controls.Add(lblPronLabel);
            cardPron.Controls.Add(lblPronunciacion);
            cardPron.CustomizableEdges = customizableEdges11;
            cardPron.FillColor = Color.FromArgb(220, 235, 255);
            cardPron.Location = new Point(14, 118);
            cardPron.Name = "cardPron";
            cardPron.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cardPron.Size = new Size(418, 66);
            cardPron.TabIndex = 2;
            // 
            // lblPronLabel
            // 
            lblPronLabel.AutoSize = false;
            lblPronLabel.BackColor = Color.Transparent;
            lblPronLabel.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblPronLabel.ForeColor = Color.FromArgb(30, 90, 180);
            lblPronLabel.Location = new Point(14, 10);
            lblPronLabel.Name = "lblPronLabel";
            lblPronLabel.Size = new Size(100, 14);
            lblPronLabel.TabIndex = 0;
            lblPronLabel.Text = "PRONUNCIACION";
            // 
            // lblPronunciacion
            // 
            lblPronunciacion.AutoSize = false;
            lblPronunciacion.BackColor = Color.Transparent;
            lblPronunciacion.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPronunciacion.ForeColor = Color.FromArgb(30, 90, 180);
            lblPronunciacion.Location = new Point(14, 26);
            lblPronunciacion.Name = "lblPronunciacion";
            lblPronunciacion.Size = new Size(390, 30);
            lblPronunciacion.TabIndex = 1;
            lblPronunciacion.Text = "/stAr/";
            // 
            // cardStreak2
            // 
            cardStreak2.BackColor = Color.Transparent;
            cardStreak2.BorderRadius = 14;
            cardStreak2.Controls.Add(lblStreakTitle);
            cardStreak2.Controls.Add(lblStreakDesc);
            cardStreak2.CustomizableEdges = customizableEdges13;
            cardStreak2.FillColor = Color.FromArgb(255, 240, 195);
            cardStreak2.Location = new Point(14, 196);
            cardStreak2.Name = "cardStreak2";
            cardStreak2.ShadowDecoration.CustomizableEdges = customizableEdges14;
            cardStreak2.Size = new Size(418, 56);
            cardStreak2.TabIndex = 3;
            // 
            // lblStreakTitle
            // 
            lblStreakTitle.AutoSize = false;
            lblStreakTitle.BackColor = Color.Transparent;
            lblStreakTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblStreakTitle.ForeColor = Color.FromArgb(180, 100, 0);
            lblStreakTitle.Location = new Point(14, 10);
            lblStreakTitle.Name = "lblStreakTitle";
            lblStreakTitle.Size = new Size(100, 14);
            lblStreakTitle.TabIndex = 0;
            lblStreakTitle.Text = "TU RACHA HOY";
            // 
            // lblStreakDesc
            // 
            lblStreakDesc.AutoSize = false;
            lblStreakDesc.BackColor = Color.Transparent;
            lblStreakDesc.Font = new Font("Segoe UI", 9F);
            lblStreakDesc.ForeColor = Color.FromArgb(120, 80, 0);
            lblStreakDesc.Location = new Point(14, 26);
            lblStreakDesc.Name = "lblStreakDesc";
            lblStreakDesc.Size = new Size(390, 22);
            lblStreakDesc.TabIndex = 1;
            lblStreakDesc.Text = "Sigue aprendiendo para mantener tu racha activa!";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Transparent;
            btnEntrar.BorderRadius = 24;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.CustomizableEdges = customizableEdges17;
            btnEntrar.FillColor = Color.FromArgb(255, 183, 0);
            btnEntrar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.HoverState.FillColor = Color.FromArgb(220, 155, 0);
            btnEntrar.Location = new Point(287, 384);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.ShadowDecoration.Color = Color.FromArgb(50, 255, 183, 0);
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnEntrar.ShadowDecoration.Depth = 8;
            btnEntrar.ShadowDecoration.Enabled = true;
            btnEntrar.Size = new Size(280, 50);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar a PolyTalk";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FrmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 240);
            ClientSize = new Size(851, 455);
            Controls.Add(panelIzq);
            Controls.Add(panelDer);
            Controls.Add(btnEntrar);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBienvenida";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bienvenida";
            Load += FrmBienvenida_Load;
            panelHeader.ResumeLayout(false);
            panelIzq.ResumeLayout(false);
            panelDer.ResumeLayout(false);
            cardEjemplo.ResumeLayout(false);
            cardPron.ResumeLayout(false);
            cardStreak2.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}