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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
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

            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle3 = new DataGridViewCellStyle();

            panelPrincipal = new Guna2Panel();
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
            panelPrincipal.BackColor = Color.FromArgb(255, 247, 237);
            panelPrincipal.Controls.Add(panelHeader);
            panelPrincipal.Controls.Add(panelTabla);
            panelPrincipal.CustomizableEdges = ce11;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.FillColor = Color.Transparent;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(20);
            panelPrincipal.ShadowDecoration.CustomizableEdges = ce12;
            panelPrincipal.Size = new Size(854, 535);
            panelPrincipal.TabIndex = 0;

            // ── panelHeader ─────────────────────────────────────
            panelHeader.BackColor = Color.Transparent;
            panelHeader.BorderRadius = 15;
            panelHeader.Controls.Add(lblTituloLista);
            panelHeader.Controls.Add(lblTotalPalabras);
            panelHeader.Controls.Add(btnVolver);
            panelHeader.Controls.Add(btnAgregarPalabra);
            panelHeader.Controls.Add(btnPracticar);
            panelHeader.CustomizableEdges = ce7;
            panelHeader.FillColor = Color.FromArgb(102, 126, 234);
            panelHeader.Location = new Point(20, 20);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20);
            panelHeader.ShadowDecoration.BorderRadius = 15;
            panelHeader.ShadowDecoration.CustomizableEdges = ce8;
            panelHeader.ShadowDecoration.Depth = 5;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(814, 90);
            panelHeader.TabIndex = 0;

            // ── lblTituloLista ──────────────────────────────────
            lblTituloLista.BackColor = Color.Transparent;
            lblTituloLista.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTituloLista.ForeColor = Color.White;
            lblTituloLista.Location = new Point(20, 15);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(145, 39);
            lblTituloLista.Text = "📚 Mi Lista";

            // ── lblTotalPalabras ────────────────────────────────
            lblTotalPalabras.BackColor = Color.Transparent;
            lblTotalPalabras.Font = new Font("Segoe UI", 11F);
            lblTotalPalabras.ForeColor = Color.FromArgb(220, 230, 255);
            lblTotalPalabras.Location = new Point(20, 58);
            lblTotalPalabras.Name = "lblTotalPalabras";
            lblTotalPalabras.Size = new Size(72, 22);
            lblTotalPalabras.Text = "0 palabras";

            // ── btnVolver ← Atrás ───────────────────────────────
            btnVolver.BorderRadius = 10;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.CustomizableEdges = ce1;
            btnVolver.FillColor = Color.FromArgb(80, 255, 255, 255);
            btnVolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.HoverState.FillColor = Color.FromArgb(130, 255, 255, 255);
            btnVolver.Location = new Point(730, 26);
            btnVolver.Name = "btnVolver";
            btnVolver.ShadowDecoration.CustomizableEdges = ce2;
            btnVolver.Size = new Size(65, 38);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "← Atrás";
            btnVolver.Click += btnVolver_Click;

            // ── btnAgregarPalabra ───────────────────────────────
            btnAgregarPalabra.BorderRadius = 10;
            btnAgregarPalabra.Cursor = Cursors.Hand;
            btnAgregarPalabra.CustomizableEdges = ce3;
            btnAgregarPalabra.FillColor = Color.FromArgb(72, 187, 120);
            btnAgregarPalabra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarPalabra.ForeColor = Color.White;
            btnAgregarPalabra.HoverState.FillColor = Color.FromArgb(56, 161, 105);
            btnAgregarPalabra.Location = new Point(490, 26);
            btnAgregarPalabra.Name = "btnAgregarPalabra";
            btnAgregarPalabra.ShadowDecoration.CustomizableEdges = ce4;
            btnAgregarPalabra.Size = new Size(150, 38);
            btnAgregarPalabra.TabIndex = 3;
            btnAgregarPalabra.Text = "+ Agregar palabra";
            btnAgregarPalabra.Click += btnAgregarPalabra_Click;

            // ── btnPracticar ────────────────────────────────────
            btnPracticar.BorderRadius = 10;
            btnPracticar.Cursor = Cursors.Hand;
            btnPracticar.CustomizableEdges = ce5;
            btnPracticar.FillColor = Color.FromArgb(237, 137, 54);
            btnPracticar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPracticar.ForeColor = Color.White;
            btnPracticar.HoverState.FillColor = Color.FromArgb(221, 107, 32);
            btnPracticar.Location = new Point(650, 26);
            btnPracticar.Name = "btnPracticar";
            btnPracticar.ShadowDecoration.CustomizableEdges = ce6;
            btnPracticar.Size = new Size(70, 38);
            btnPracticar.TabIndex = 4;
            btnPracticar.Text = "🎯";
            btnPracticar.Click += btnPracticar_Click;

            // ── panelTabla ──────────────────────────────────────
            panelTabla.BackColor = Color.Transparent;
            panelTabla.BorderRadius = 15;
            panelTabla.Controls.Add(dgvPalabras);
            panelTabla.Controls.Add(lblMinimo);
            panelTabla.CustomizableEdges = ce9;
            panelTabla.FillColor = Color.White;
            panelTabla.Location = new Point(20, 125);
            panelTabla.Name = "panelTabla";
            panelTabla.Padding = new Padding(15);
            panelTabla.ShadowDecoration.BorderRadius = 15;
            panelTabla.ShadowDecoration.CustomizableEdges = ce10;
            panelTabla.ShadowDecoration.Depth = 5;
            panelTabla.ShadowDecoration.Enabled = true;
            panelTabla.Size = new Size(814, 390);
            panelTabla.TabIndex = 1;

            // ── dgvPalabras ─────────────────────────────────────
            dgvPalabras.AllowUserToAddRows = false;
            dgvPalabras.AllowUserToDeleteRows = false;

            cellStyle1.BackColor = Color.FromArgb(247, 250, 252);
            dgvPalabras.AlternatingRowsDefaultCellStyle = cellStyle1;

            cellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle2.BackColor = Color.FromArgb(102, 126, 234);
            cellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cellStyle2.ForeColor = Color.White;
            cellStyle2.SelectionBackColor = SystemColors.Highlight;
            cellStyle2.SelectionForeColor = SystemColors.HighlightText;
            cellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPalabras.ColumnHeadersDefaultCellStyle = cellStyle2;
            dgvPalabras.ColumnHeadersHeight = 35;

            cellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle3.BackColor = Color.White;
            cellStyle3.Font = new Font("Segoe UI", 10F);
            cellStyle3.ForeColor = Color.FromArgb(45, 55, 72);
            cellStyle3.SelectionBackColor = Color.FromArgb(235, 240, 255);
            cellStyle3.SelectionForeColor = Color.FromArgb(45, 55, 72);
            cellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPalabras.DefaultCellStyle = cellStyle3;

            dgvPalabras.GridColor = Color.FromArgb(226, 232, 240);
            dgvPalabras.Location = new Point(15, 15);
            dgvPalabras.Name = "dgvPalabras";
            dgvPalabras.RowHeadersVisible = false;
            dgvPalabras.RowTemplate.Height = 38;
            dgvPalabras.Size = new Size(784, 340);
            dgvPalabras.TabIndex = 0;

            dgvPalabras.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(247, 250, 252);
            dgvPalabras.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvPalabras.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvPalabras.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvPalabras.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvPalabras.ThemeStyle.BackColor = Color.White;
            dgvPalabras.ThemeStyle.GridColor = Color.FromArgb(226, 232, 240);
            dgvPalabras.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(102, 126, 234);
            dgvPalabras.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPalabras.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvPalabras.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPalabras.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPalabras.ThemeStyle.HeaderStyle.Height = 35;
            dgvPalabras.ThemeStyle.ReadOnly = false;
            dgvPalabras.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvPalabras.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPalabras.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F);
            dgvPalabras.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(45, 55, 72);
            dgvPalabras.ThemeStyle.RowsStyle.Height = 38;
            dgvPalabras.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(235, 240, 255);
            dgvPalabras.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(45, 55, 72);

            dgvPalabras.CellClick += dgvPalabras_CellClick;
            dgvPalabras.CellFormatting += dgvPalabras_CellFormatting;

            // ── lblMinimo ───────────────────────────────────────
            lblMinimo.BackColor = Color.Transparent;
            lblMinimo.Font = new Font("Segoe UI", 10F);
            lblMinimo.ForeColor = Color.FromArgb(237, 137, 54);
            lblMinimo.Location = new Point(15, 360);
            lblMinimo.Name = "lblMinimo";
            lblMinimo.Size = new Size(290, 19);
            lblMinimo.TabIndex = 1;
            lblMinimo.Text = "⚠️ Necesitas al menos 4 palabras para practicar";
            lblMinimo.Visible = false;

            // ── Form ────────────────────────────────────────────
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(854, 535);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDetalleLista";
            StartPosition = FormStartPosition.CenterParent;
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