using System.Drawing;
using System.Windows.Forms;

using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Estudiantes
{
    partial class FrmPracticar
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelPrincipal;
        private Guna2Panel panelTop;
        private Guna2HtmlLabel lblProgreso;
        private Guna2HtmlLabel lblCorrectas;
        private Guna2HtmlLabel lblIncorrectas;
        private Guna2Button btnSalir;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna2Panel panelCentro;
        private Guna2HtmlLabel lblInstruccion;
        private Guna2Panel panelEjercicio;
        private Guna2HtmlLabel lblFeedback;
        private Guna2Panel panelBotonesAnki;
        private Guna2Button btnDificil;
        private Guna2Button btnBien;
        private Guna2Button btnFacil;
        private Guna2Button btnVerificar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            panelPrincipal = new Guna2Panel();
            panelTop = new Guna2Panel();
            lblProgreso = new Guna2HtmlLabel();
            lblCorrectas = new Guna2HtmlLabel();
            lblIncorrectas = new Guna2HtmlLabel();
            btnSalir = new Guna2Button();
            progressBar = new Guna2ProgressBar();
            panelCentro = new Guna2Panel();
            lblInstruccion = new Guna2HtmlLabel();
            panelEjercicio = new Guna2Panel();
            lblFeedback = new Guna2HtmlLabel();
            panelBotonesAnki = new Guna2Panel();
            btnDificil = new Guna2Button();
            btnBien = new Guna2Button();
            btnFacil = new Guna2Button();
            btnVerificar = new Guna2Button();
            panelPrincipal.SuspendLayout();
            panelTop.SuspendLayout();
            panelCentro.SuspendLayout();
            panelBotonesAnki.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(252, 248, 240);
            panelPrincipal.Controls.Add(panelTop);
            panelPrincipal.Controls.Add(progressBar);
            panelPrincipal.Controls.Add(panelCentro);
            panelPrincipal.CustomizableEdges = customizableEdges21;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.FillColor = Color.Transparent;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(20);
            panelPrincipal.ShadowDecoration.CustomizableEdges = customizableEdges22;
            panelPrincipal.Size = new Size(854, 535);
            panelPrincipal.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Transparent;
            panelTop.BorderRadius = 15;
            panelTop.Controls.Add(lblProgreso);
            panelTop.Controls.Add(lblCorrectas);
            panelTop.Controls.Add(lblIncorrectas);
            panelTop.Controls.Add(btnSalir);
            panelTop.CustomizableEdges = customizableEdges3;
            panelTop.FillColor = Color.White;
            panelTop.Location = new Point(20, 20);
            panelTop.Name = "panelTop";
            panelTop.ShadowDecoration.BorderRadius = 15;
            panelTop.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelTop.ShadowDecoration.Depth = 5;
            panelTop.ShadowDecoration.Enabled = true;
            panelTop.Size = new Size(814, 60);
            panelTop.TabIndex = 0;
            // 
            // lblProgreso
            // 
            lblProgreso.BackColor = Color.Transparent;
            lblProgreso.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblProgreso.ForeColor = Color.FromArgb(102, 126, 234);
            lblProgreso.Location = new Point(20, 15);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(54, 27);
            lblProgreso.TabIndex = 0;
            lblProgreso.Text = "1 / 10";
            // 
            // lblCorrectas
            // 
            lblCorrectas.BackColor = Color.Transparent;
            lblCorrectas.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCorrectas.ForeColor = Color.FromArgb(72, 187, 120);
            lblCorrectas.Location = new Point(320, 15);
            lblCorrectas.Name = "lblCorrectas";
            lblCorrectas.Size = new Size(42, 25);
            lblCorrectas.TabIndex = 1;
            lblCorrectas.Text = "✅ 0";
            // 
            // lblIncorrectas
            // 
            lblIncorrectas.BackColor = Color.Transparent;
            lblIncorrectas.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblIncorrectas.ForeColor = Color.FromArgb(245, 101, 101);
            lblIncorrectas.Location = new Point(420, 15);
            lblIncorrectas.Name = "lblIncorrectas";
            lblIncorrectas.Size = new Size(42, 25);
            lblIncorrectas.TabIndex = 2;
            lblIncorrectas.Text = "❌ 0";
            // 
            // btnSalir
            // 
            btnSalir.BorderRadius = 8;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.CustomizableEdges = customizableEdges1;
            btnSalir.FillColor = Color.FromArgb(247, 250, 252);
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(113, 128, 150);
            btnSalir.HoverState.FillColor = Color.FromArgb(254, 178, 178);
            btnSalir.HoverState.ForeColor = Color.FromArgb(197, 48, 48);
            btnSalir.Location = new Point(745, 13);
            btnSalir.Name = "btnSalir";
            btnSalir.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSalir.Size = new Size(55, 34);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "✕ Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.Transparent;
            progressBar.CustomizableEdges = customizableEdges5;
            progressBar.FillColor = Color.FromArgb(102, 126, 234);
            progressBar.Location = new Point(20, 88);
            progressBar.Name = "progressBar";
            progressBar.ProgressColor = Color.FromArgb(102, 126, 234);
            progressBar.ProgressColor2 = Color.FromArgb(159, 122, 234);
            progressBar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            progressBar.Size = new Size(814, 8);
            progressBar.TabIndex = 1;
            progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panelCentro
            // 
            panelCentro.BackColor = Color.Transparent;
            panelCentro.BorderRadius = 20;
            panelCentro.Controls.Add(lblInstruccion);
            panelCentro.Controls.Add(panelEjercicio);
            panelCentro.Controls.Add(lblFeedback);
            panelCentro.Controls.Add(panelBotonesAnki);
            panelCentro.Controls.Add(btnVerificar);
            panelCentro.CustomizableEdges = customizableEdges19;
            panelCentro.FillColor = Color.White;
            panelCentro.Location = new Point(20, 105);
            panelCentro.Name = "panelCentro";
            panelCentro.Padding = new Padding(25);
            panelCentro.ShadowDecoration.BorderRadius = 15;
            panelCentro.ShadowDecoration.CustomizableEdges = customizableEdges20;
            panelCentro.ShadowDecoration.Depth = 5;
            panelCentro.ShadowDecoration.Enabled = true;
            panelCentro.Size = new Size(814, 410);
            panelCentro.TabIndex = 2;
            // 
            // lblInstruccion
            // 
            lblInstruccion.BackColor = Color.Transparent;
            lblInstruccion.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.FromArgb(45, 55, 72);
            lblInstruccion.Location = new Point(25, 20);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(213, 27);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "Instrucción del ejercicio";
            lblInstruccion.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // panelEjercicio
            // 
            panelEjercicio.AutoScroll = true;
            panelEjercicio.BackColor = Color.Transparent;
            panelEjercicio.CustomizableEdges = customizableEdges7;
            panelEjercicio.FillColor = Color.Transparent;
            panelEjercicio.Location = new Point(200, 60);
            panelEjercicio.Name = "panelEjercicio";
            panelEjercicio.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelEjercicio.Size = new Size(410, 270);
            panelEjercicio.TabIndex = 1;
            // 
            // lblFeedback
            // 
            lblFeedback.BackColor = Color.Transparent;
            lblFeedback.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFeedback.ForeColor = Color.Green;
            lblFeedback.Location = new Point(25, 340);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(3, 2);
            lblFeedback.TabIndex = 2;
            lblFeedback.TextAlignment = ContentAlignment.MiddleCenter;
            lblFeedback.Visible = false;
            // 
            // panelBotonesAnki
            // 
            panelBotonesAnki.BackColor = Color.Transparent;
            panelBotonesAnki.Controls.Add(btnDificil);
            panelBotonesAnki.Controls.Add(btnBien);
            panelBotonesAnki.Controls.Add(btnFacil);
            panelBotonesAnki.CustomizableEdges = customizableEdges15;
            panelBotonesAnki.FillColor = Color.Transparent;
            panelBotonesAnki.Location = new Point(200, 368);
            panelBotonesAnki.Name = "panelBotonesAnki";
            panelBotonesAnki.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelBotonesAnki.Size = new Size(410, 55);
            panelBotonesAnki.TabIndex = 3;
            panelBotonesAnki.Visible = false;
            // 
            // btnDificil
            // 
            btnDificil.BorderRadius = 10;
            btnDificil.Cursor = Cursors.Hand;
            btnDificil.CustomizableEdges = customizableEdges9;
            btnDificil.FillColor = Color.FromArgb(254, 178, 178);
            btnDificil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDificil.ForeColor = Color.FromArgb(197, 48, 48);
            btnDificil.HoverState.FillColor = Color.FromArgb(245, 101, 101);
            btnDificil.HoverState.ForeColor = Color.White;
            btnDificil.Location = new Point(0, 5);
            btnDificil.Name = "btnDificil";
            btnDificil.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnDificil.Size = new Size(120, 44);
            btnDificil.TabIndex = 0;
            btnDificil.Text = "😓 Difícil";
            btnDificil.Click += btnDificil_Click;
            // 
            // btnBien
            // 
            btnBien.BorderRadius = 10;
            btnBien.Cursor = Cursors.Hand;
            btnBien.CustomizableEdges = customizableEdges11;
            btnBien.FillColor = Color.FromArgb(154, 230, 180);
            btnBien.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBien.ForeColor = Color.FromArgb(34, 84, 61);
            btnBien.HoverState.FillColor = Color.FromArgb(72, 187, 120);
            btnBien.HoverState.ForeColor = Color.White;
            btnBien.Location = new Point(145, 5);
            btnBien.Name = "btnBien";
            btnBien.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnBien.Size = new Size(120, 44);
            btnBien.TabIndex = 1;
            btnBien.Text = "👍 Bien";
            btnBien.Click += btnBien_Click;
            // 
            // btnFacil
            // 
            btnFacil.BorderRadius = 10;
            btnFacil.Cursor = Cursors.Hand;
            btnFacil.CustomizableEdges = customizableEdges13;
            btnFacil.FillColor = Color.FromArgb(144, 205, 244);
            btnFacil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFacil.ForeColor = Color.FromArgb(44, 82, 130);
            btnFacil.HoverState.FillColor = Color.FromArgb(66, 153, 225);
            btnFacil.HoverState.ForeColor = Color.White;
            btnFacil.Location = new Point(290, 5);
            btnFacil.Name = "btnFacil";
            btnFacil.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnFacil.Size = new Size(120, 44);
            btnFacil.TabIndex = 2;
            btnFacil.Text = "😎 Fácil";
            btnFacil.Click += btnFacil_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.BorderRadius = 10;
            btnVerificar.Cursor = Cursors.Hand;
            btnVerificar.CustomizableEdges = customizableEdges17;
            btnVerificar.FillColor = Color.FromArgb(102, 126, 234);
            btnVerificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVerificar.ForeColor = Color.White;
            btnVerificar.HoverState.FillColor = Color.FromArgb(92, 116, 224);
            btnVerificar.Location = new Point(307, 368);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnVerificar.Size = new Size(200, 44);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "✔ Verificar";
            btnVerificar.Visible = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // FrmPracticar
            // 
            BackColor = Color.FromArgb(252, 248, 240);
            ClientSize = new Size(854, 535);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPracticar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Practicar";
            Load += FrmPracticar_Load;
            panelPrincipal.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelCentro.ResumeLayout(false);
            panelCentro.PerformLayout();
            panelBotonesAnki.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}