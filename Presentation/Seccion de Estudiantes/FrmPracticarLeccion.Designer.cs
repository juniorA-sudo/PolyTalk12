using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation
{
    partial class FrmPracticarLeccion
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label accentBarPrac;
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblProgreso;
        private Guna2ProgressBar progressBar;
        private Guna2Button btnCerrar;

        private Guna2Panel panelContenido;
        private Guna2HtmlLabel lblInstruccion;
        private PictureBox picActividad;
        private Panel panelActividad;
        private Guna2HtmlLabel lblFeedback;
        private Guna2Button btnSiguiente;

        private Guna2Panel panelResultados;
        private Guna2HtmlLabel lblMedalla;
        private Guna2HtmlLabel lblPuntaje;
        private Guna2HtmlLabel lblMensaje;
        private Guna2HtmlLabel lblResumen;
        private Guna2Button btnVolverLecciones;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var ce1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            accentBarPrac = new System.Windows.Forms.Label();
            panelHeader = new Guna2Panel();
            lblProgreso = new Guna2HtmlLabel();
            progressBar = new Guna2ProgressBar();
            btnCerrar = new Guna2Button();
            panelContenido = new Guna2Panel();
            lblInstruccion = new Guna2HtmlLabel();
            picActividad = new PictureBox();
            panelActividad = new Panel();
            lblFeedback = new Guna2HtmlLabel();
            btnSiguiente = new Guna2Button();
            panelResultados = new Guna2Panel();
            lblMedalla = new Guna2HtmlLabel();
            lblPuntaje = new Guna2HtmlLabel();
            lblMensaje = new Guna2HtmlLabel();
            lblResumen = new Guna2HtmlLabel();
            btnVolverLecciones = new Guna2Button();

            panelHeader.SuspendLayout();
            panelContenido.SuspendLayout();
            panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picActividad).BeginInit();
            SuspendLayout();

            // ════════════════════════════════════════
            // HEADER — blanco, franja fucsia izquierda
            // ════════════════════════════════════════
            accentBarPrac.BackColor = Color.FromArgb(255, 60, 120);
            accentBarPrac.Location = new Point(0, 0);
            accentBarPrac.Name = "accentBarPrac";
            accentBarPrac.Size = new Size(5, 62);
            accentBarPrac.TabIndex = 99;
            accentBarPrac.Text = "";

            lblProgreso.BackColor = Color.Transparent;
            lblProgreso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProgreso.ForeColor = Color.FromArgb(255, 60, 120);
            lblProgreso.Location = new Point(18, 10);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(220, 20);
            lblProgreso.TabIndex = 0;
            lblProgreso.Text = "Actividad 1 de 5";

            progressBar.BorderRadius = 6;
            progressBar.CustomizableEdges = ce1;
            progressBar.FillColor = Color.FromArgb(235, 225, 205);
            progressBar.ProgressColor = Color.FromArgb(255, 60, 120);
            progressBar.Location = new Point(18, 36);
            progressBar.Maximum = 100;
            progressBar.Name = "progressBar";
            progressBar.ShadowDecoration.CustomizableEdges = ce2;
            progressBar.Size = new Size(780, 10);
            progressBar.TabIndex = 1;
            progressBar.Value = 0;

            btnCerrar.BorderRadius = 18;
            btnCerrar.CustomizableEdges = ce3;
            btnCerrar.FillColor = Color.FromArgb(240, 235, 225);
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(120, 110, 90);
            btnCerrar.HoverState.FillColor = Color.FromArgb(255, 200, 200);
            btnCerrar.HoverState.ForeColor = Color.FromArgb(180, 30, 30);
            btnCerrar.Location = new Point(800, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ShadowDecoration.CustomizableEdges = ce4;
            btnCerrar.Size = new Size(36, 36);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "✕";
            btnCerrar.Click += new System.EventHandler(btnCerrar_Click);

            panelHeader.FillColor = Color.White;
            panelHeader.CustomizableEdges = ce5;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = ce6;
            panelHeader.ShadowDecoration.Color = Color.FromArgb(14, 0, 0, 0);
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(854, 62);
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(accentBarPrac);
            panelHeader.Controls.Add(lblProgreso);
            panelHeader.Controls.Add(progressBar);
            panelHeader.Controls.Add(btnCerrar);

            // ════════════════════════════════════════
            // PANEL CONTENIDO — crema, card blanca
            // ════════════════════════════════════════
            lblInstruccion.BackColor = Color.Transparent;
            lblInstruccion.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.FromArgb(25, 25, 35);
            lblInstruccion.Location = new Point(30, 16);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(794, 30);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "Instrucción de la actividad";
            lblInstruccion.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            picActividad.Location = new Point(30, 55);
            picActividad.Name = "picActividad";
            picActividad.Size = new Size(160, 130);
            picActividad.SizeMode = PictureBoxSizeMode.Zoom;
            picActividad.TabIndex = 1;
            picActividad.Visible = false;

            // ✅ panelActividad — panel neutro donde se renderizan los ejercicios
            panelActividad.BackColor = Color.Transparent;
            panelActividad.Location = new Point(30, 54);
            panelActividad.Name = "panelActividad";
            panelActividad.Size = new Size(794, 248);
            panelActividad.TabIndex = 2;

            // Feedback — fondo dinámico con color
            lblFeedback.BackColor = Color.FromArgb(210, 255, 225);
            lblFeedback.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFeedback.ForeColor = Color.FromArgb(20, 120, 60);
            lblFeedback.Location = new Point(30, 308);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Padding = new Padding(14, 6, 14, 6);
            lblFeedback.Size = new Size(794, 40);
            lblFeedback.TabIndex = 3;
            lblFeedback.Text = "✓  ¡Correcto!";
            lblFeedback.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            lblFeedback.Visible = false;

            // Botón Siguiente — pill naranja, alineado derecha
            btnSiguiente.BorderRadius = 20;
            btnSiguiente.CustomizableEdges = ce7;
            btnSiguiente.FillColor = Color.FromArgb(255, 140, 0);
            btnSiguiente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.HoverState.FillColor = Color.FromArgb(220, 115, 0);
            btnSiguiente.Location = new Point(648, 358);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.ShadowDecoration.CustomizableEdges = ce8;
            btnSiguiente.ShadowDecoration.Color = Color.FromArgb(35, 255, 140, 0);
            btnSiguiente.ShadowDecoration.Depth = 5;
            btnSiguiente.ShadowDecoration.Enabled = true;
            btnSiguiente.Size = new Size(176, 40);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = "Siguiente →";
            btnSiguiente.Visible = false;
            btnSiguiente.Click += new System.EventHandler(btnSiguiente_Click);

            panelContenido.BackColor = Color.FromArgb(252, 248, 240);
            panelContenido.FillColor = Color.FromArgb(252, 248, 240);
            panelContenido.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 62);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(0, 10, 0, 10);
            panelContenido.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelContenido.TabIndex = 1;
            panelContenido.Controls.Add(lblInstruccion);
            panelContenido.Controls.Add(picActividad);
            panelContenido.Controls.Add(panelActividad);
            panelContenido.Controls.Add(lblFeedback);
            panelContenido.Controls.Add(btnSiguiente);

            // ════════════════════════════════════════
            // PANEL RESULTADOS — crema, centrado kawaii
            // ════════════════════════════════════════
            lblMedalla.BackColor = Color.Transparent;
            lblMedalla.Font = new Font("Segoe UI", 56F);
            lblMedalla.Location = new Point(377, 28);
            lblMedalla.Name = "lblMedalla";
            lblMedalla.Size = new Size(100, 88);
            lblMedalla.TabIndex = 0;
            lblMedalla.Text = "🏆";
            lblMedalla.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.Font = new Font("Segoe UI Black", 54F, FontStyle.Bold);
            lblPuntaje.ForeColor = Color.FromArgb(255, 60, 120);
            lblPuntaje.Location = new Point(250, 120);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(354, 90);
            lblPuntaje.TabIndex = 1;
            lblPuntaje.Text = "80%";
            lblPuntaje.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            lblMensaje.ForeColor = Color.FromArgb(25, 25, 35);
            lblMensaje.Location = new Point(177, 216);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(500, 32);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "¡Excelente trabajo!";
            lblMensaje.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            lblResumen.BackColor = Color.Transparent;
            lblResumen.Font = new Font("Segoe UI", 10.5F);
            lblResumen.ForeColor = Color.FromArgb(160, 150, 130);
            lblResumen.Location = new Point(177, 252);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(500, 22);
            lblResumen.TabIndex = 3;
            lblResumen.Text = "Respondiste correctamente 4 de 5";
            lblResumen.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            btnVolverLecciones.BorderRadius = 22;
            btnVolverLecciones.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnVolverLecciones.FillColor = Color.FromArgb(255, 60, 120);
            btnVolverLecciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVolverLecciones.ForeColor = Color.White;
            btnVolverLecciones.HoverState.FillColor = Color.FromArgb(220, 40, 100);
            btnVolverLecciones.Location = new Point(307, 290);
            btnVolverLecciones.Name = "btnVolverLecciones";
            btnVolverLecciones.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnVolverLecciones.ShadowDecoration.Color = Color.FromArgb(35, 255, 60, 120);
            btnVolverLecciones.ShadowDecoration.Depth = 6;
            btnVolverLecciones.ShadowDecoration.Enabled = true;
            btnVolverLecciones.Size = new Size(240, 46);
            btnVolverLecciones.TabIndex = 4;
            btnVolverLecciones.Text = "← Volver a lecciones";
            btnVolverLecciones.Click += new System.EventHandler(btnVolverLecciones_Click);

            panelResultados.BackColor = Color.FromArgb(252, 248, 240);
            panelResultados.FillColor = Color.FromArgb(252, 248, 240);
            panelResultados.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelResultados.Dock = DockStyle.Fill;
            panelResultados.Location = new Point(0, 62);
            panelResultados.Name = "panelResultados";
            panelResultados.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelResultados.TabIndex = 2;
            panelResultados.Visible = false;
            panelResultados.Controls.Add(lblMedalla);
            panelResultados.Controls.Add(lblPuntaje);
            panelResultados.Controls.Add(lblMensaje);
            panelResultados.Controls.Add(lblResumen);
            panelResultados.Controls.Add(btnVolverLecciones);

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 240);
            ClientSize = new Size(854, 535);
            Controls.Add(panelContenido);
            Controls.Add(panelResultados);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPracticarLeccion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Practicar Lección";
            Load += new System.EventHandler(FrmPracticarLeccion_Load);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picActividad).EndInit();
            ResumeLayout(false);
        }
    }
}