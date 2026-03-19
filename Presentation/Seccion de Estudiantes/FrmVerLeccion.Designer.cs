using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation
{
    partial class FrmVerLeccion
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTituloLeccion;
        private Guna2HtmlLabel lblSubtitulo;
        private Guna2HtmlLabel lblDuracion;
        private Guna2HtmlLabel lblTipo;
        private Button btnCerrar;

        private Guna2Panel panelCuerpo;
        private Guna2HtmlLabel lblTituloContenido;
        private RichTextBox rtbExplicacion;
        private PictureBox picContenido;

        private Guna2Panel panelFooter;
        private Guna2HtmlLabel lblPagina;
        private Guna2Button btnAnteriorPagina;
        private Guna2Button btnSiguientePagina;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Guna2Panel();
            lblTituloLeccion = new Guna2HtmlLabel();
            lblSubtitulo = new Guna2HtmlLabel();
            lblDuracion = new Guna2HtmlLabel();
            lblTipo = new Guna2HtmlLabel();
            btnCerrar = new Button();
            panelCuerpo = new Guna2Panel();
            lblTituloContenido = new Guna2HtmlLabel();
            rtbExplicacion = new RichTextBox();
            picContenido = new PictureBox();
            panelFooter = new Guna2Panel();
            lblPagina = new Guna2HtmlLabel();
            btnAnteriorPagina = new Guna2Button();
            btnSiguientePagina = new Guna2Button();

            panelHeader.SuspendLayout();
            panelCuerpo.SuspendLayout();
            panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picContenido).BeginInit();
            SuspendLayout();

            // ── HEADER ──────────────────────────────────
            panelHeader.FillColor = Color.FromArgb(79, 70, 229);
            panelHeader.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20, 15, 20, 15);
            panelHeader.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader.Size = new Size(854, 90);
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(lblTituloLeccion);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblDuracion);
            panelHeader.Controls.Add(lblTipo);
            panelHeader.Controls.Add(btnCerrar);

            lblTituloLeccion.BackColor = Color.Transparent;
            lblTituloLeccion.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloLeccion.ForeColor = Color.White;
            lblTituloLeccion.Location = new Point(20, 12);
            lblTituloLeccion.Name = "lblTituloLeccion";
            lblTituloLeccion.Size = new Size(500, 30);
            lblTituloLeccion.TabIndex = 0;
            lblTituloLeccion.Text = "Título lección";

            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(196, 181, 253);
            lblSubtitulo.Location = new Point(20, 46);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(300, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Nivel · Unidad";

            lblDuracion.BackColor = Color.Transparent;
            lblDuracion.Font = new Font("Segoe UI", 9F);
            lblDuracion.ForeColor = Color.FromArgb(196, 181, 253);
            lblDuracion.Location = new Point(20, 66);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(100, 17);
            lblDuracion.TabIndex = 2;
            lblDuracion.Text = "⏱ 15 min";

            lblTipo.BackColor = Color.Transparent;
            lblTipo.Font = new Font("Segoe UI", 9F);
            lblTipo.ForeColor = Color.FromArgb(196, 181, 253);
            lblTipo.Location = new Point(130, 66);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(140, 17);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "📖 Vocabulario";

            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCerrar.Location = new Point(812, 8);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "✕";
            btnCerrar.Click += new System.EventHandler(btnCerrar_Click);

            // ── CUERPO ───────────────────────────────────
            panelCuerpo.BackColor = Color.White;
            panelCuerpo.FillColor = Color.White;
            panelCuerpo.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelCuerpo.Dock = DockStyle.Fill;
            panelCuerpo.Location = new Point(0, 90);
            panelCuerpo.Name = "panelCuerpo";
            panelCuerpo.Padding = new Padding(30, 20, 30, 10);
            panelCuerpo.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelCuerpo.TabIndex = 1;
            panelCuerpo.Controls.Add(lblTituloContenido);
            panelCuerpo.Controls.Add(rtbExplicacion);
            panelCuerpo.Controls.Add(picContenido);

            lblTituloContenido.BackColor = Color.Transparent;
            lblTituloContenido.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloContenido.ForeColor = Color.FromArgb(45, 55, 72);
            lblTituloContenido.Location = new Point(30, 20);
            lblTituloContenido.Name = "lblTituloContenido";
            lblTituloContenido.Size = new Size(500, 28);
            lblTituloContenido.TabIndex = 0;
            lblTituloContenido.Text = "Título del tema";

            rtbExplicacion.BackColor = Color.FromArgb(248, 250, 252);
            rtbExplicacion.BorderStyle = BorderStyle.None;
            rtbExplicacion.Font = new Font("Segoe UI", 11F);
            rtbExplicacion.ForeColor = Color.FromArgb(55, 65, 81);
            rtbExplicacion.Location = new Point(30, 58);
            rtbExplicacion.Name = "rtbExplicacion";
            rtbExplicacion.ReadOnly = true;
            rtbExplicacion.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbExplicacion.Size = new Size(390, 260);
            rtbExplicacion.TabIndex = 1;

            picContenido.Location = new Point(440, 58);
            picContenido.Name = "picContenido";
            picContenido.Size = new Size(220, 180);
            picContenido.SizeMode = PictureBoxSizeMode.Zoom;
            picContenido.TabIndex = 2;
            picContenido.Visible = false;

            // ── FOOTER ───────────────────────────────────
            panelFooter.BackColor = Color.White;
            panelFooter.FillColor = Color.White;
            panelFooter.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 450);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(20, 10, 20, 10);
            panelFooter.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelFooter.Size = new Size(700, 60);
            panelFooter.TabIndex = 2;
            panelFooter.Controls.Add(lblPagina);
            panelFooter.Controls.Add(btnAnteriorPagina);
            panelFooter.Controls.Add(btnSiguientePagina);

            lblPagina.BackColor = Color.Transparent;
            lblPagina.Font = new Font("Segoe UI", 10F);
            lblPagina.ForeColor = Color.FromArgb(113, 128, 150);
            lblPagina.Location = new Point(300, 20);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(60, 20);
            lblPagina.TabIndex = 0;
            lblPagina.Text = "1 / 1";
            lblPagina.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            btnAnteriorPagina.BorderRadius = 8;
            btnAnteriorPagina.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnAnteriorPagina.DisabledState.FillColor = Color.FromArgb(200, 200, 200);
            btnAnteriorPagina.FillColor = Color.FromArgb(243, 244, 246);
            btnAnteriorPagina.Font = new Font("Segoe UI", 10F);
            btnAnteriorPagina.ForeColor = Color.FromArgb(55, 65, 81);
            btnAnteriorPagina.Location = new Point(20, 12);
            btnAnteriorPagina.Name = "btnAnteriorPagina";
            btnAnteriorPagina.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnAnteriorPagina.Size = new Size(130, 36);
            btnAnteriorPagina.TabIndex = 1;
            btnAnteriorPagina.Text = "← Anterior";
            btnAnteriorPagina.Enabled = false;
            btnAnteriorPagina.Click += new System.EventHandler(btnAnteriorPagina_Click);

            btnSiguientePagina.BorderRadius = 8;
            btnSiguientePagina.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSiguientePagina.FillColor = Color.FromArgb(79, 70, 229);
            btnSiguientePagina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSiguientePagina.ForeColor = Color.White;
            btnSiguientePagina.Location = new Point(540, 12);
            btnSiguientePagina.Name = "btnSiguientePagina";
            btnSiguientePagina.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSiguientePagina.Size = new Size(140, 36);
            btnSiguientePagina.TabIndex = 2;
            btnSiguientePagina.Text = "Siguiente →";
            btnSiguientePagina.Click += new System.EventHandler(btnSiguientePagina_Click);

            // Form
            BackColor = Color.White;
            ClientSize = new Size(854, 535);
            Controls.Add(panelCuerpo);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVerLeccion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ver Lección";
            Load += new System.EventHandler(FrmVerLeccion_Load);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCuerpo.ResumeLayout(false);
            panelCuerpo.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picContenido).EndInit();
            ResumeLayout(false);
        }
    }
}