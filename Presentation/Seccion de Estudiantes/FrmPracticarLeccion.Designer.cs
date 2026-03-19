using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation
{
    partial class FrmPracticarLeccion
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblProgreso;
        private Guna2ProgressBar progressBar;
        private Button btnCerrar;

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
            panelHeader = new Guna2Panel();
            lblProgreso = new Guna2HtmlLabel();
            progressBar = new Guna2ProgressBar();
            btnCerrar = new Button();
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

            // ── HEADER ──────────────────────────────────
            panelHeader.FillColor = Color.White;
            panelHeader.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20, 12, 20, 8);
            panelHeader.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader.ShadowDecoration.Depth = 3;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(854, 65);
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(lblProgreso);
            panelHeader.Controls.Add(progressBar);
            panelHeader.Controls.Add(btnCerrar);

            lblProgreso.BackColor = Color.Transparent;
            lblProgreso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProgreso.ForeColor = Color.FromArgb(79, 70, 229);
            lblProgreso.Location = new Point(20, 10);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(200, 20);
            lblProgreso.TabIndex = 0;
            lblProgreso.Text = "Actividad 1 de 5";

            progressBar.BorderRadius = 4;
            progressBar.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            progressBar.FillColor = Color.FromArgb(79, 70, 229);
            progressBar.Location = new Point(20, 38);
            progressBar.Maximum = 100;
            progressBar.Name = "progressBar";
            progressBar.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            progressBar.Size = new Size(784, 8);
            progressBar.TabIndex = 1;
            progressBar.Value = 0;

            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.ForeColor = Color.FromArgb(113, 128, 150);
            btnCerrar.Font = new Font("Segoe UI", 12F);
            btnCerrar.Location = new Point(812, 8);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 28);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "✕";
            btnCerrar.Click += new System.EventHandler(btnCerrar_Click);

            // ── PANEL CONTENIDO ──────────────────────────
            panelContenido.BackColor = Color.FromArgb(249, 250, 251);
            panelContenido.FillColor = Color.FromArgb(249, 250, 251);
            panelContenido.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 65);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(30, 20, 30, 20);
            panelContenido.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelContenido.TabIndex = 1;
            panelContenido.Controls.Add(lblInstruccion);
            panelContenido.Controls.Add(picActividad);
            panelContenido.Controls.Add(panelActividad);
            panelContenido.Controls.Add(lblFeedback);
            panelContenido.Controls.Add(btnSiguiente);

            lblInstruccion.BackColor = Color.Transparent;
            lblInstruccion.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.FromArgb(45, 55, 72);
            lblInstruccion.Location = new Point(30, 20);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(640, 50);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "Instrucción de la actividad";

            picActividad.Location = new Point(30, 75);
            picActividad.Name = "picActividad";
            picActividad.Size = new Size(180, 140);
            picActividad.SizeMode = PictureBoxSizeMode.Zoom;
            picActividad.TabIndex = 1;
            picActividad.Visible = false;

            panelActividad.BackColor = Color.Transparent;
            panelActividad.Location = new Point(30, 75);
            panelActividad.Name = "panelActividad";
            panelActividad.Size = new Size(640, 220);
            panelActividad.TabIndex = 2;

            lblFeedback.BackColor = Color.FromArgb(220, 252, 231);
            lblFeedback.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFeedback.ForeColor = Color.FromArgb(22, 101, 52);
            lblFeedback.Location = new Point(30, 305);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Padding = new Padding(12, 6, 12, 6);
            lblFeedback.Size = new Size(640, 40);
            lblFeedback.TabIndex = 3;
            lblFeedback.Text = "✓  ¡Correcto!";
            lblFeedback.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            lblFeedback.Visible = false;

            btnSiguiente.BorderRadius = 8;
            btnSiguiente.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSiguiente.FillColor = Color.FromArgb(79, 70, 229);
            btnSiguiente.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(510, 358);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSiguiente.Size = new Size(160, 42);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = "Siguiente →";
            btnSiguiente.Visible = false;
            btnSiguiente.Click += new System.EventHandler(btnSiguiente_Click);

            // ── PANEL RESULTADOS ─────────────────────────
            panelResultados.BackColor = Color.White;
            panelResultados.FillColor = Color.White;
            panelResultados.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelResultados.Dock = DockStyle.Fill;
            panelResultados.Location = new Point(0, 65);
            panelResultados.Name = "panelResultados";
            panelResultados.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelResultados.TabIndex = 2;
            panelResultados.Visible = false;
            panelResultados.Controls.Add(lblMedalla);
            panelResultados.Controls.Add(lblPuntaje);
            panelResultados.Controls.Add(lblMensaje);
            panelResultados.Controls.Add(lblResumen);
            panelResultados.Controls.Add(btnVolverLecciones);

            lblMedalla.BackColor = Color.Transparent;
            lblMedalla.Font = new Font("Segoe UI", 52F);
            lblMedalla.ForeColor = Color.FromArgb(45, 55, 72);
            lblMedalla.Location = new Point(290, 40);
            lblMedalla.Name = "lblMedalla";
            lblMedalla.Size = new Size(80, 80);
            lblMedalla.TabIndex = 0;
            lblMedalla.Text = "🏆";
            lblMedalla.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            lblPuntaje.ForeColor = Color.FromArgb(79, 70, 229);
            lblPuntaje.Location = new Point(240, 130);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(220, 80);
            lblPuntaje.TabIndex = 1;
            lblPuntaje.Text = "80%";
            lblPuntaje.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMensaje.ForeColor = Color.FromArgb(45, 55, 72);
            lblMensaje.Location = new Point(150, 215);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(400, 35);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "¡Excelente trabajo!";
            lblMensaje.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            lblResumen.BackColor = Color.Transparent;
            lblResumen.Font = new Font("Segoe UI", 11F);
            lblResumen.ForeColor = Color.FromArgb(113, 128, 150);
            lblResumen.Location = new Point(150, 258);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(400, 25);
            lblResumen.TabIndex = 3;
            lblResumen.Text = "Respondiste correctamente 4 de 5";
            lblResumen.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            btnVolverLecciones.BorderRadius = 8;
            btnVolverLecciones.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnVolverLecciones.FillColor = Color.FromArgb(79, 70, 229);
            btnVolverLecciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVolverLecciones.ForeColor = Color.White;
            btnVolverLecciones.Location = new Point(250, 310);
            btnVolverLecciones.Name = "btnVolverLecciones";
            btnVolverLecciones.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnVolverLecciones.Size = new Size(200, 44);
            btnVolverLecciones.TabIndex = 4;
            btnVolverLecciones.Text = "Volver a lecciones";
            btnVolverLecciones.Click += new System.EventHandler(btnVolverLecciones_Click);

            // Form
            BackColor = Color.White;
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