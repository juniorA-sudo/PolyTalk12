using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation
{
    partial class FrmVerLeccion
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label accentBarVer;
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTituloLeccion;
        private Guna2HtmlLabel lblSubtitulo;
        private Guna2HtmlLabel lblDuracion;
        private Guna2HtmlLabel lblTipo;
        private Guna2Button btnCerrar;

        private Guna2Panel panelCuerpo;
        private Guna2Panel panelContenidoCard;
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
            var ce1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            accentBarVer = new System.Windows.Forms.Label();
            panelHeader = new Guna2Panel();
            lblTituloLeccion = new Guna2HtmlLabel();
            lblSubtitulo = new Guna2HtmlLabel();
            lblDuracion = new Guna2HtmlLabel();
            lblTipo = new Guna2HtmlLabel();
            btnCerrar = new Guna2Button();
            panelCuerpo = new Guna2Panel();
            panelContenidoCard = new Guna2Panel();
            lblTituloContenido = new Guna2HtmlLabel();
            rtbExplicacion = new RichTextBox();
            picContenido = new PictureBox();
            panelFooter = new Guna2Panel();
            lblPagina = new Guna2HtmlLabel();
            btnAnteriorPagina = new Guna2Button();
            btnSiguientePagina = new Guna2Button();

            panelHeader.SuspendLayout();
            panelCuerpo.SuspendLayout();
            panelContenidoCard.SuspendLayout();
            panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picContenido).BeginInit();
            SuspendLayout();

            // ════════════════════════════════════════
            // HEADER — blanco con franja naranja izq.
            // ════════════════════════════════════════
            accentBarVer.BackColor = Color.FromArgb(255, 183, 0);
            accentBarVer.Location = new Point(0, 0);
            accentBarVer.Name = "accentBarVer";
            accentBarVer.Size = new Size(5, 80);
            accentBarVer.TabIndex = 99;
            accentBarVer.Text = "";

            lblTituloLeccion.BackColor = Color.Transparent;
            lblTituloLeccion.Font = new Font("Segoe UI Black", 17F, FontStyle.Bold);
            lblTituloLeccion.ForeColor = Color.FromArgb(25, 25, 35);
            lblTituloLeccion.Location = new Point(20, 10);
            lblTituloLeccion.Name = "lblTituloLeccion";
            lblTituloLeccion.Size = new Size(580, 30);
            lblTituloLeccion.TabIndex = 0;
            lblTituloLeccion.Text = "Título lección";

            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(150, 140, 120);
            lblSubtitulo.Location = new Point(22, 44);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(240, 16);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Nivel · Unidad";

            lblDuracion.BackColor = Color.FromArgb(255, 240, 200);
            lblDuracion.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDuracion.ForeColor = Color.FromArgb(160, 100, 0);
            lblDuracion.Location = new Point(22, 62);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(76, 16);
            lblDuracion.TabIndex = 2;
            lblDuracion.Text = "⏱ 15 min";

            lblTipo.BackColor = Color.FromArgb(220, 240, 255);
            lblTipo.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTipo.ForeColor = Color.FromArgb(30, 90, 180);
            lblTipo.Location = new Point(108, 62);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(110, 16);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "📖 Grammar";

            btnCerrar.BorderRadius = 18;
            btnCerrar.CustomizableEdges = ce1;
            btnCerrar.FillColor = Color.FromArgb(240, 235, 225);
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(120, 110, 90);
            btnCerrar.HoverState.FillColor = Color.FromArgb(255, 200, 200);
            btnCerrar.HoverState.ForeColor = Color.FromArgb(180, 30, 30);
            btnCerrar.Location = new Point(798, 21);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ShadowDecoration.CustomizableEdges = ce2;
            btnCerrar.Size = new Size(38, 38);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "✕";
            btnCerrar.Click += new System.EventHandler(btnCerrar_Click);

            panelHeader.FillColor = Color.White;
            panelHeader.CustomizableEdges = ce3;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = ce4;
            panelHeader.ShadowDecoration.Color = Color.FromArgb(14, 0, 0, 0);
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(854, 80);
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(accentBarVer);
            panelHeader.Controls.Add(lblTituloLeccion);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblDuracion);
            panelHeader.Controls.Add(lblTipo);
            panelHeader.Controls.Add(btnCerrar);

            // ════════════════════════════════════════
            // PANEL CUERPO — fondo crema con card
            // ════════════════════════════════════════
            lblTituloContenido.BackColor = Color.Transparent;
            lblTituloContenido.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            lblTituloContenido.ForeColor = Color.FromArgb(25, 25, 35);
            lblTituloContenido.Location = new Point(20, 16);
            lblTituloContenido.Name = "lblTituloContenido";
            lblTituloContenido.Size = new Size(570, 26);
            lblTituloContenido.TabIndex = 0;
            lblTituloContenido.Text = "Título del tema";

            rtbExplicacion.BackColor = Color.White;
            rtbExplicacion.BorderStyle = BorderStyle.None;
            rtbExplicacion.Font = new Font("Segoe UI", 11.5F);
            rtbExplicacion.ForeColor = Color.FromArgb(55, 65, 81);
            rtbExplicacion.Location = new Point(20, 50);
            rtbExplicacion.Name = "rtbExplicacion";
            rtbExplicacion.ReadOnly = true;
            rtbExplicacion.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbExplicacion.Size = new Size(578, 222);
            rtbExplicacion.TabIndex = 1;

            picContenido.Location = new Point(618, 50);
            picContenido.Name = "picContenido";
            picContenido.Size = new Size(160, 160);
            picContenido.SizeMode = PictureBoxSizeMode.Zoom;
            picContenido.TabIndex = 2;
            picContenido.Visible = false;

            panelContenidoCard.BackColor = Color.Transparent;
            panelContenidoCard.BorderColor = Color.FromArgb(235, 225, 205);
            panelContenidoCard.BorderRadius = 16;
            panelContenidoCard.FillColor = Color.White;
            panelContenidoCard.CustomizableEdges = ce5;
            panelContenidoCard.ShadowDecoration.CustomizableEdges = ce6;
            panelContenidoCard.ShadowDecoration.Color = Color.FromArgb(16, 0, 0, 0);
            panelContenidoCard.ShadowDecoration.Depth = 8;
            panelContenidoCard.ShadowDecoration.Enabled = true;
            panelContenidoCard.Location = new Point(20, 14);
            panelContenidoCard.Name = "panelContenidoCard";
            panelContenidoCard.Padding = new Padding(0);
            panelContenidoCard.Size = new Size(814, 288);
            panelContenidoCard.TabIndex = 0;
            panelContenidoCard.Controls.Add(lblTituloContenido);
            panelContenidoCard.Controls.Add(rtbExplicacion);
            panelContenidoCard.Controls.Add(picContenido);

            panelCuerpo.BackColor = Color.FromArgb(252, 248, 240);
            panelCuerpo.FillColor = Color.FromArgb(252, 248, 240);
            panelCuerpo.CustomizableEdges = ce7;
            panelCuerpo.Dock = DockStyle.Fill;
            panelCuerpo.Location = new Point(0, 80);
            panelCuerpo.Name = "panelCuerpo";
            panelCuerpo.Padding = new Padding(20, 14, 20, 10);
            panelCuerpo.ShadowDecoration.CustomizableEdges = ce8;
            panelCuerpo.TabIndex = 1;
            panelCuerpo.Controls.Add(panelContenidoCard);

            // ════════════════════════════════════════
            // FOOTER — blanco con pills de navegación
            // ════════════════════════════════════════
            lblPagina.BackColor = Color.Transparent;
            lblPagina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPagina.ForeColor = Color.FromArgb(160, 150, 130);
            lblPagina.Location = new Point(362, 18);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(80, 22);
            lblPagina.TabIndex = 0;
            lblPagina.Text = "1 / 1";
            lblPagina.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            btnAnteriorPagina.BorderRadius = 20;
            btnAnteriorPagina.CustomizableEdges = ce9;
            btnAnteriorPagina.DisabledState.FillColor = Color.FromArgb(235, 230, 220);
            btnAnteriorPagina.DisabledState.ForeColor = Color.FromArgb(190, 180, 160);
            btnAnteriorPagina.FillColor = Color.FromArgb(240, 235, 225);
            btnAnteriorPagina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAnteriorPagina.ForeColor = Color.FromArgb(120, 110, 90);
            btnAnteriorPagina.HoverState.FillColor = Color.FromArgb(225, 215, 200);
            btnAnteriorPagina.Location = new Point(20, 10);
            btnAnteriorPagina.Name = "btnAnteriorPagina";
            btnAnteriorPagina.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnAnteriorPagina.Size = new Size(130, 38);
            btnAnteriorPagina.TabIndex = 1;
            btnAnteriorPagina.Text = "← Anterior";
            btnAnteriorPagina.Enabled = false;
            btnAnteriorPagina.Click += new System.EventHandler(btnAnteriorPagina_Click);

            btnSiguientePagina.BorderRadius = 20;
            btnSiguientePagina.CustomizableEdges = ce10;
            btnSiguientePagina.FillColor = Color.FromArgb(255, 140, 0);
            btnSiguientePagina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSiguientePagina.ForeColor = Color.White;
            btnSiguientePagina.HoverState.FillColor = Color.FromArgb(220, 115, 0);
            btnSiguientePagina.Location = new Point(694, 10);
            btnSiguientePagina.Name = "btnSiguientePagina";
            btnSiguientePagina.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSiguientePagina.ShadowDecoration.Color = Color.FromArgb(35, 255, 140, 0);
            btnSiguientePagina.ShadowDecoration.Depth = 5;
            btnSiguientePagina.ShadowDecoration.Enabled = true;
            btnSiguientePagina.Size = new Size(140, 38);
            btnSiguientePagina.TabIndex = 2;
            btnSiguientePagina.Text = "Siguiente →";
            btnSiguientePagina.Click += new System.EventHandler(btnSiguientePagina_Click);

            panelFooter.FillColor = Color.White;
            panelFooter.BackColor = Color.White;
            panelFooter.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 477);
            panelFooter.Name = "panelFooter";
            panelFooter.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelFooter.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            panelFooter.ShadowDecoration.Depth = 3;
            panelFooter.ShadowDecoration.Enabled = true;
            panelFooter.Size = new Size(854, 58);
            panelFooter.TabIndex = 2;
            panelFooter.Controls.Add(lblPagina);
            panelFooter.Controls.Add(btnAnteriorPagina);
            panelFooter.Controls.Add(btnSiguientePagina);

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 240);
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
            panelContenidoCard.ResumeLayout(false);
            panelContenidoCard.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picContenido).EndInit();
            ResumeLayout(false);
        }
    }
}