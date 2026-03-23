using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Login__Register__Principal
{
    partial class FrmDetalleLista
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelPrincipal;
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTituloLista;
        private Guna2HtmlLabel lblTotalPalabras;
        private Guna2Button btnVolver;
        private Guna2Button btnAgregarPalabra;
        private Guna2Button btnPracticar;
        private Guna2Panel panelTabla;
        private Guna2DataGridView dgvPalabras;
        private Guna2HtmlLabel lblMinimo;
        private System.Windows.Forms.Label accentBar;

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
            var ce11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            var cs1 = new DataGridViewCellStyle();
            var cs2 = new DataGridViewCellStyle();
            var cs3 = new DataGridViewCellStyle();

            panelPrincipal = new Guna2Panel();
            accentBar = new System.Windows.Forms.Label();
            panelHeader = new Guna2Panel();
            lblTituloLista = new Guna2HtmlLabel();
            lblTotalPalabras = new Guna2HtmlLabel();
            btnVolver = new Guna2Button();
            btnAgregarPalabra = new Guna2Button();
            btnPracticar = new Guna2Button();
            panelTabla = new Guna2Panel();
            dgvPalabras = new Guna2DataGridView();
            lblMinimo = new Guna2HtmlLabel();

            panelPrincipal.SuspendLayout();
            panelHeader.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPalabras).BeginInit();
            SuspendLayout();

            // ── panelPrincipal ──────────────────────────────────
            panelPrincipal.BackColor = Color.FromArgb(252, 248, 240);
            panelPrincipal.FillColor = Color.Transparent;
            panelPrincipal.CustomizableEdges = ce11;
            panelPrincipal.ShadowDecoration.CustomizableEdges = ce12;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(20, 16, 20, 16);
            panelPrincipal.Size = new Size(854, 535);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Controls.Add(accentBar);
            panelPrincipal.Controls.Add(panelHeader);
            panelPrincipal.Controls.Add(panelTabla);

            // Barra lateral decorativa naranja
            accentBar.BackColor = Color.FromArgb(255, 183, 0);
            accentBar.Location = new Point(20, 16);
            accentBar.Name = "accentBar";
            accentBar.Size = new Size(5, 100);
            accentBar.TabIndex = 99;
            accentBar.Text = "";

            // ── panelHeader — card blanca redondeada ────────────
            panelHeader.BackColor = Color.Transparent;
            panelHeader.BorderRadius = 16;
            panelHeader.FillColor = Color.White;
            panelHeader.CustomizableEdges = ce7;
            panelHeader.ShadowDecoration.CustomizableEdges = ce8;
            panelHeader.ShadowDecoration.Color = Color.FromArgb(18, 0, 0, 0);
            panelHeader.ShadowDecoration.Depth = 8;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Location = new Point(36, 16);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20, 14, 20, 14);
            panelHeader.Size = new Size(798, 88);
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(lblTituloLista);
            panelHeader.Controls.Add(lblTotalPalabras);
            panelHeader.Controls.Add(btnVolver);
            panelHeader.Controls.Add(btnAgregarPalabra);
            panelHeader.Controls.Add(btnPracticar);

            lblTituloLista.BackColor = Color.Transparent;
            lblTituloLista.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lblTituloLista.ForeColor = Color.FromArgb(25, 25, 35);
            lblTituloLista.Location = new Point(20, 12);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(320, 32);
            lblTituloLista.Text = "📚 Mi Lista";

            lblTotalPalabras.BackColor = Color.Transparent;
            lblTotalPalabras.Font = new Font("Segoe UI", 9.5F);
            lblTotalPalabras.ForeColor = Color.FromArgb(160, 150, 130);
            lblTotalPalabras.Location = new Point(22, 48);
            lblTotalPalabras.Name = "lblTotalPalabras";
            lblTotalPalabras.Size = new Size(180, 18);
            lblTotalPalabras.Text = "0 palabras";

            // Botón Volver — pill gris
            btnVolver.BorderRadius = 20;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.CustomizableEdges = ce1;
            btnVolver.FillColor = Color.FromArgb(240, 235, 225);
            btnVolver.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnVolver.ForeColor = Color.FromArgb(120, 110, 90);
            btnVolver.HoverState.FillColor = Color.FromArgb(225, 215, 200);
            btnVolver.Location = new Point(566, 26);
            btnVolver.Name = "btnVolver";
            btnVolver.ShadowDecoration.CustomizableEdges = ce2;
            btnVolver.Size = new Size(90, 36);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "← Atrás";
            btnVolver.Click += btnVolver_Click;

            // Botón Agregar — pill verde
            btnAgregarPalabra.BorderRadius = 20;
            btnAgregarPalabra.Cursor = Cursors.Hand;
            btnAgregarPalabra.CustomizableEdges = ce3;
            btnAgregarPalabra.FillColor = Color.FromArgb(200, 255, 220);
            btnAgregarPalabra.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregarPalabra.ForeColor = Color.FromArgb(20, 120, 60);
            btnAgregarPalabra.HoverState.FillColor = Color.FromArgb(160, 240, 195);
            btnAgregarPalabra.Location = new Point(420, 26);
            btnAgregarPalabra.Name = "btnAgregarPalabra";
            btnAgregarPalabra.ShadowDecoration.CustomizableEdges = ce4;
            btnAgregarPalabra.Size = new Size(138, 36);
            btnAgregarPalabra.TabIndex = 3;
            btnAgregarPalabra.Text = "+ Agregar palabra";
            btnAgregarPalabra.Click += btnAgregarPalabra_Click;

            // Botón Practicar — pill naranja
            btnPracticar.BorderRadius = 20;
            btnPracticar.Cursor = Cursors.Hand;
            btnPracticar.CustomizableEdges = ce5;
            btnPracticar.FillColor = Color.FromArgb(255, 200, 150);
            btnPracticar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPracticar.ForeColor = Color.FromArgb(160, 80, 0);
            btnPracticar.HoverState.FillColor = Color.FromArgb(255, 175, 100);
            btnPracticar.Location = new Point(666, 26);
            btnPracticar.Name = "btnPracticar";
            btnPracticar.ShadowDecoration.CustomizableEdges = ce6;
            btnPracticar.Size = new Size(110, 36);
            btnPracticar.TabIndex = 4;
            btnPracticar.Text = "🎯 Practicar";
            btnPracticar.Click += btnPracticar_Click;

            // ── panelTabla — card blanca ────────────────────────
            panelTabla.BackColor = Color.Transparent;
            panelTabla.BorderRadius = 16;
            panelTabla.FillColor = Color.White;
            panelTabla.CustomizableEdges = ce9;
            panelTabla.ShadowDecoration.CustomizableEdges = ce10;
            panelTabla.ShadowDecoration.Color = Color.FromArgb(18, 0, 0, 0);
            panelTabla.ShadowDecoration.Depth = 8;
            panelTabla.ShadowDecoration.Enabled = true;
            panelTabla.Location = new Point(20, 120);
            panelTabla.Name = "panelTabla";
            panelTabla.Padding = new Padding(14);
            panelTabla.Size = new Size(814, 396);
            panelTabla.TabIndex = 1;
            panelTabla.Controls.Add(dgvPalabras);
            panelTabla.Controls.Add(lblMinimo);

            // DataGridView
            dgvPalabras.AllowUserToAddRows = false;
            dgvPalabras.AllowUserToDeleteRows = false;

            cs1.BackColor = Color.FromArgb(255, 250, 242);
            dgvPalabras.AlternatingRowsDefaultCellStyle = cs1;

            cs2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cs2.BackColor = Color.FromArgb(255, 140, 0);
            cs2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cs2.ForeColor = Color.White;
            cs2.WrapMode = DataGridViewTriState.True;
            dgvPalabras.ColumnHeadersDefaultCellStyle = cs2;
            dgvPalabras.ColumnHeadersHeight = 38;

            cs3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cs3.BackColor = Color.White;
            cs3.Font = new Font("Segoe UI", 10F);
            cs3.ForeColor = Color.FromArgb(45, 55, 72);
            cs3.SelectionBackColor = Color.FromArgb(255, 240, 210);
            cs3.SelectionForeColor = Color.FromArgb(45, 55, 72);
            dgvPalabras.DefaultCellStyle = cs3;

            dgvPalabras.GridColor = Color.FromArgb(240, 232, 215);
            dgvPalabras.Location = new Point(14, 14);
            dgvPalabras.Name = "dgvPalabras";
            dgvPalabras.RowHeadersVisible = false;
            dgvPalabras.RowTemplate.Height = 40;
            dgvPalabras.Size = new Size(786, 350);
            dgvPalabras.TabIndex = 0;
            dgvPalabras.ThemeStyle.BackColor = Color.White;
            dgvPalabras.ThemeStyle.GridColor = Color.FromArgb(240, 232, 215);
            dgvPalabras.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 140, 0);
            dgvPalabras.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPalabras.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvPalabras.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPalabras.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPalabras.ThemeStyle.HeaderStyle.Height = 38;
            dgvPalabras.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvPalabras.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPalabras.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F);
            dgvPalabras.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(45, 55, 72);
            dgvPalabras.ThemeStyle.RowsStyle.Height = 40;
            dgvPalabras.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(255, 240, 210);
            dgvPalabras.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(45, 55, 72);
            dgvPalabras.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(255, 250, 242);
            dgvPalabras.CellClick += dgvPalabras_CellClick;
            dgvPalabras.CellFormatting += dgvPalabras_CellFormatting;

            lblMinimo.BackColor = Color.Transparent;
            lblMinimo.Font = new Font("Segoe UI", 9.5F);
            lblMinimo.ForeColor = Color.FromArgb(200, 120, 0);
            lblMinimo.Location = new Point(14, 368);
            lblMinimo.Name = "lblMinimo";
            lblMinimo.Size = new Size(340, 18);
            lblMinimo.TabIndex = 1;
            lblMinimo.Text = "⚠️ Necesitas al menos 4 palabras para practicar";
            lblMinimo.Visible = false;

            // Form
            BackColor = Color.FromArgb(252, 248, 240);
            ClientSize = new Size(854, 535);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDetalleLista";
            Text = "Detalle de Lista";
            Load += FrmDetalleLista_Load;

            panelPrincipal.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPalabras).EndInit();
            ResumeLayout(false);
        }
    }
}