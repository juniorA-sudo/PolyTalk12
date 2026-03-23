namespace Presentation
{
    partial class UCUnidadesEstudiante
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges ce1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblNumero = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblProgreso = new Guna.UI2.WinForms.Guna2HtmlLabel();
            progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            accentBar = new Guna.UI2.WinForms.Guna2Panel();

            guna2Panel1.SuspendLayout();
            SuspendLayout();

            // ── Barra de acento izquierda (naranja) ──────────
            accentBar.FillColor = Color.FromArgb(255, 140, 0);
            accentBar.BorderRadius = 0;
            accentBar.CustomizableEdges = ce1;
            accentBar.Location = new Point(0, 0);
            accentBar.Name = "accentBar";
            accentBar.ShadowDecoration.CustomizableEdges = ce2;
            accentBar.Size = new Size(4, 68);
            accentBar.TabIndex = 0;

            // ── Label "Unidad N" ──────────────────────────────
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular);
            lblNumero.ForeColor = Color.FromArgb(180, 165, 140);
            lblNumero.Location = new Point(14, 8);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(155, 14);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "UNIDAD 1";

            // ── Título de la unidad ───────────────────────────
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 25, 20);
            lblTitulo.Location = new Point(14, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(160, 18);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Saludos y presentaciones";

            // ── Barra de progreso ─────────────────────────────
            progressBar.BorderRadius = 4;
            progressBar.CustomizableEdges = ce3;
            progressBar.FillColor = Color.FromArgb(235, 225, 205);
            progressBar.ProgressColor = Color.FromArgb(255, 140, 0);
            progressBar.Location = new Point(14, 44);
            progressBar.Name = "progressBar";
            progressBar.ShadowDecoration.CustomizableEdges = ce4;
            progressBar.Size = new Size(130, 7);
            progressBar.TabIndex = 3;
            progressBar.Value = 0;

            // ── Label porcentaje ──────────────────────────────
            lblProgreso.BackColor = Color.Transparent;
            lblProgreso.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblProgreso.ForeColor = Color.FromArgb(255, 140, 0);
            lblProgreso.Location = new Point(14, 54);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(155, 12);
            lblProgreso.TabIndex = 4;
            lblProgreso.Text = "0% completado";

            // ── Panel contenedor ──────────────────────────────
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.BorderColor = Color.FromArgb(238, 228, 210);
            guna2Panel1.BorderRadius = 12;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(accentBar);
            guna2Panel1.Controls.Add(lblNumero);
            guna2Panel1.Controls.Add(lblTitulo);
            guna2Panel1.Controls.Add(progressBar);
            guna2Panel1.Controls.Add(lblProgreso);
            guna2Panel1.CustomizableEdges = ce1;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = ce2;
            guna2Panel1.ShadowDecoration.Color = Color.FromArgb(20, 0, 0, 0);
            guna2Panel1.ShadowDecoration.Depth = 6;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.Size = new Size(178, 68);
            guna2Panel1.TabIndex = 0;
            guna2Panel1.Paint += guna2Panel1_Paint;

            // ── UserControl ───────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Cursor = Cursors.Hand;
            Name = "UCUnidadesEstudiante";
            Size = new Size(178, 68);

            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel accentBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumero;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProgreso;
    }
}