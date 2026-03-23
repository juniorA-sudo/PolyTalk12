using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Controls
{
    partial class UCLessonCard
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelCard;
        private Label lblIcono;
        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblEstado;
        private Label lblFlecha;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelCard = new Guna2Panel();
            lblIcono = new Label();
            lblTitulo = new Label();
            lblDescripcion = new Label();
            lblEstado = new Label();
            lblFlecha = new Label();

            panelCard.SuspendLayout();
            SuspendLayout();

            // ── panelCard ────────────────────────────────
            panelCard.BackColor = Color.Transparent;
            panelCard.BorderColor = Color.FromArgb(230, 220, 200);
            panelCard.BorderRadius = 12;
            panelCard.BorderThickness = 1;
            panelCard.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelCard.FillColor = Color.White;
            panelCard.Location = new Point(0, 0);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(12, 10, 12, 10);
            panelCard.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelCard.ShadowDecoration.Color = Color.FromArgb(18, 0, 0, 0);
            panelCard.ShadowDecoration.Depth = 4;
            panelCard.ShadowDecoration.Enabled = true;
            panelCard.Size = new Size(590, 72);
            panelCard.TabIndex = 0;
            panelCard.Cursor = Cursors.Hand;
            panelCard.Controls.Add(lblIcono);
            panelCard.Controls.Add(lblTitulo);
            panelCard.Controls.Add(lblDescripcion);
            panelCard.Controls.Add(lblEstado);
            panelCard.Controls.Add(lblFlecha);
            panelCard.Click += DispararClick;

            // ── Ícono ────────────────────────────────────
            lblIcono.AutoSize = false;
            lblIcono.BackColor = Color.FromArgb(255, 245, 225);
            lblIcono.Font = new Font("Segoe UI", 18F);
            lblIcono.ForeColor = Color.FromArgb(200, 140, 0);
            lblIcono.Location = new Point(10, 12);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(46, 46);
            lblIcono.TabIndex = 0;
            lblIcono.Text = "📖";
            lblIcono.TextAlign = ContentAlignment.MiddleCenter;
            lblIcono.Cursor = Cursors.Hand;
            lblIcono.Click += DispararClick;

            // ── Título ───────────────────────────────────
            lblTitulo.AutoSize = false;
            lblTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 55, 72);
            lblTitulo.Location = new Point(66, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(330, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Título de la lección";
            lblTitulo.Cursor = Cursors.Hand;
            lblTitulo.Click += DispararClick;

            // ── Descripción (tipo) ────────────────────────
            lblDescripcion.AutoSize = false;
            lblDescripcion.Font = new Font("Segoe UI", 8.5F);
            lblDescripcion.ForeColor = Color.FromArgb(160, 150, 130);
            lblDescripcion.Location = new Point(67, 36);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(240, 16);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "📚 Gramática";
            lblDescripcion.Cursor = Cursors.Hand;
            lblDescripcion.Click += DispararClick;

            // ── Badge de estado ───────────────────────────
            lblEstado.AutoSize = false;
            lblEstado.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEstado.ForeColor = Color.FromArgb(160, 100, 0);
            lblEstado.BackColor = Color.FromArgb(255, 240, 200);
            lblEstado.Location = new Point(420, 22);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(80, 22);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Pendiente";
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            lblEstado.Cursor = Cursors.Hand;
            lblEstado.Click += DispararClick;

            // ── Flecha ────────────────────────────────────
            lblFlecha.AutoSize = false;
            lblFlecha.Font = new Font("Segoe UI", 14F);
            lblFlecha.ForeColor = Color.FromArgb(200, 190, 170);
            lblFlecha.Location = new Point(555, 20);
            lblFlecha.Name = "lblFlecha";
            lblFlecha.Size = new Size(24, 30);
            lblFlecha.TabIndex = 4;
            lblFlecha.Text = "›";
            lblFlecha.TextAlign = ContentAlignment.MiddleCenter;
            lblFlecha.Cursor = Cursors.Hand;
            lblFlecha.Click += DispararClick;

            // ── UserControl ───────────────────────────────
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            Controls.Add(panelCard);
            Cursor = Cursors.Hand;
            Name = "UCLessonCard";
            Size = new Size(590, 74);
            Margin = new Padding(0, 0, 0, 8);
            Click += DispararClick;

            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}