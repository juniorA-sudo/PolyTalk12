using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Maestros
{
    partial class FrmMisEstudiantes
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Guna2Panel panelPrincipal;
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTitulo;
        private Guna2HtmlLabel lblSubtitulo;

        // Stats
        private Guna2Panel panelStats;
        private Guna2Panel cardTotal;
        private Guna2HtmlLabel lblTotalLabel;
        private Guna2HtmlLabel lblTotalEstudiantes;
        private Guna2Panel cardNiveles;
        private Guna2HtmlLabel lblNivelesLabel;
        private Guna2Panel panelNivelBadges;
        private Guna2HtmlLabel lblA1;
        private Guna2HtmlLabel lblA2;
        private Guna2HtmlLabel lblB1;
        private Guna2HtmlLabel lblB2;
        private Guna2HtmlLabel lblC1;
        private Guna2HtmlLabel lblC2;

        // Toolbar
        private Guna2Panel panelToolbar;
        private Guna2TextBox txtBuscar;
        private Guna2ComboBox cmbNivel;

        // Table
        private Guna2Panel panelTabla;
        private Guna2DataGridView dgvEstudiantes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelPrincipal = new Guna2Panel();
            panelHeader = new Guna2Panel();
            lblTitulo = new Guna2HtmlLabel();
            lblSubtitulo = new Guna2HtmlLabel();
            panelStats = new Guna2Panel();
            cardTotal = new Guna2Panel();
            lblTotalLabel = new Guna2HtmlLabel();
            lblTotalEstudiantes = new Guna2HtmlLabel();
            cardNiveles = new Guna2Panel();
            lblNivelesLabel = new Guna2HtmlLabel();
            panelNivelBadges = new Guna2Panel();
            panelToolbar = new Guna2Panel();
            txtBuscar = new Guna2TextBox();
            cmbNivel = new Guna2ComboBox();
            panelTabla = new Guna2Panel();
            dgvEstudiantes = new Guna2DataGridView();
            lblA1 = new Guna2HtmlLabel();
            lblA2 = new Guna2HtmlLabel();
            lblB1 = new Guna2HtmlLabel();
            lblB2 = new Guna2HtmlLabel();
            lblC1 = new Guna2HtmlLabel();
            lblC2 = new Guna2HtmlLabel();
            panelPrincipal.SuspendLayout();
            panelHeader.SuspendLayout();
            panelStats.SuspendLayout();
            cardTotal.SuspendLayout();
            cardNiveles.SuspendLayout();
            panelToolbar.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 247, 237);
            panelPrincipal.Controls.Add(panelHeader);
            panelPrincipal.Controls.Add(panelStats);
            panelPrincipal.Controls.Add(panelToolbar);
            panelPrincipal.Controls.Add(panelTabla);
            panelPrincipal.CustomizableEdges = customizableEdges19;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.FillColor = Color.Transparent;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(18);
            panelPrincipal.ShadowDecoration.CustomizableEdges = customizableEdges20;
            panelPrincipal.Size = new Size(854, 535);
            panelPrincipal.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.CustomizableEdges = customizableEdges1;
            panelHeader.FillColor = Color.Transparent;
            panelHeader.Location = new Point(18, 12);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.Size = new Size(818, 51);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 55, 72);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(182, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mis Estudiantes";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(113, 128, 150);
            lblSubtitulo.Location = new Point(3, 29);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(211, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Estudiantes asignados a tus grupos";
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.Transparent;
            panelStats.Controls.Add(cardTotal);
            panelStats.Controls.Add(cardNiveles);
            panelStats.CustomizableEdges = customizableEdges9;
            panelStats.FillColor = Color.Transparent;
            panelStats.Location = new Point(18, 70);
            panelStats.Name = "panelStats";
            panelStats.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelStats.Size = new Size(818, 80);
            panelStats.TabIndex = 1;
            // 
            // cardTotal
            // 
            cardTotal.BackColor = Color.Transparent;
            cardTotal.BorderRadius = 10;
            cardTotal.Controls.Add(lblTotalLabel);
            cardTotal.Controls.Add(lblTotalEstudiantes);
            cardTotal.CustomizableEdges = customizableEdges3;
            cardTotal.FillColor = Color.White;
            cardTotal.Location = new Point(0, 0);
            cardTotal.Name = "cardTotal";
            cardTotal.Padding = new Padding(14);
            cardTotal.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cardTotal.ShadowDecoration.Depth = 3;
            cardTotal.ShadowDecoration.Enabled = true;
            cardTotal.Size = new Size(150, 75);
            cardTotal.TabIndex = 0;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.BackColor = Color.Transparent;
            lblTotalLabel.Font = new Font("Segoe UI", 9F);
            lblTotalLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblTotalLabel.Location = new Point(14, 10);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(93, 17);
            lblTotalLabel.TabIndex = 0;
            lblTotalLabel.Text = "Total estudiantes";
            // 
            // lblTotalEstudiantes
            // 
            lblTotalEstudiantes.BackColor = Color.Transparent;
            lblTotalEstudiantes.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalEstudiantes.ForeColor = Color.FromArgb(24, 95, 165);
            lblTotalEstudiantes.Location = new Point(14, 30);
            lblTotalEstudiantes.Name = "lblTotalEstudiantes";
            lblTotalEstudiantes.Size = new Size(20, 42);
            lblTotalEstudiantes.TabIndex = 1;
            lblTotalEstudiantes.Text = "0";
            // 
            // cardNiveles
            // 
            cardNiveles.BackColor = Color.Transparent;
            cardNiveles.BorderRadius = 10;
            cardNiveles.Controls.Add(lblNivelesLabel);
            cardNiveles.Controls.Add(panelNivelBadges);
            cardNiveles.CustomizableEdges = customizableEdges7;
            cardNiveles.FillColor = Color.White;
            cardNiveles.Location = new Point(162, 0);
            cardNiveles.Name = "cardNiveles";
            cardNiveles.Padding = new Padding(14);
            cardNiveles.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cardNiveles.ShadowDecoration.Depth = 3;
            cardNiveles.ShadowDecoration.Enabled = true;
            cardNiveles.Size = new Size(400, 75);
            cardNiveles.TabIndex = 1;
            // 
            // lblNivelesLabel
            // 
            lblNivelesLabel.BackColor = Color.Transparent;
            lblNivelesLabel.Font = new Font("Segoe UI", 9F);
            lblNivelesLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblNivelesLabel.Location = new Point(14, 10);
            lblNivelesLabel.Name = "lblNivelesLabel";
            lblNivelesLabel.Size = new Size(116, 17);
            lblNivelesLabel.TabIndex = 0;
            lblNivelesLabel.Text = "Distribución por nivel";
            // 
            // panelNivelBadges
            // 
            panelNivelBadges.BackColor = Color.Transparent;
            panelNivelBadges.CustomizableEdges = customizableEdges5;
            panelNivelBadges.FillColor = Color.Transparent;
            panelNivelBadges.Location = new Point(14, 30);
            panelNivelBadges.Name = "panelNivelBadges";
            panelNivelBadges.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelNivelBadges.Size = new Size(370, 35);
            panelNivelBadges.TabIndex = 1;
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.Transparent;
            panelToolbar.Controls.Add(txtBuscar);
            panelToolbar.Controls.Add(cmbNivel);
            panelToolbar.CustomizableEdges = customizableEdges15;
            panelToolbar.FillColor = Color.Transparent;
            panelToolbar.Location = new Point(18, 160);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelToolbar.Size = new Size(818, 40);
            panelToolbar.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderRadius = 8;
            txtBuscar.CustomizableEdges = customizableEdges11;
            txtBuscar.DefaultText = "";
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.ForeColor = Color.FromArgb(45, 55, 72);
            txtBuscar.Location = new Point(0, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "🔍 Buscar por nombre, email o nivel...";
            txtBuscar.SelectedText = "";
            txtBuscar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtBuscar.Size = new Size(530, 36);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cmbNivel
            // 
            cmbNivel.BackColor = Color.Transparent;
            cmbNivel.BorderRadius = 8;
            cmbNivel.CustomizableEdges = customizableEdges13;
            cmbNivel.DrawMode = DrawMode.OwnerDrawFixed;
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.FocusedColor = Color.Empty;
            cmbNivel.Font = new Font("Segoe UI", 10F);
            cmbNivel.ForeColor = Color.FromArgb(45, 55, 72);
            cmbNivel.ItemHeight = 28;
            cmbNivel.Items.AddRange(new object[] { "Todos", "A1", "A2", "B1", "B2", "C1", "C2" });
            cmbNivel.Location = new Point(544, 2);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.ShadowDecoration.CustomizableEdges = customizableEdges14;
            cmbNivel.Size = new Size(140, 34);
            cmbNivel.TabIndex = 1;
            cmbNivel.SelectedIndexChanged += cmbNivel_SelectedIndexChanged;
            // 
            // panelTabla
            // 
            panelTabla.BackColor = Color.Transparent;
            panelTabla.BorderRadius = 12;
            panelTabla.Controls.Add(dgvEstudiantes);
            panelTabla.CustomizableEdges = customizableEdges17;
            panelTabla.FillColor = Color.White;
            panelTabla.Location = new Point(18, 208);
            panelTabla.Name = "panelTabla";
            panelTabla.Padding = new Padding(8);
            panelTabla.ShadowDecoration.CustomizableEdges = customizableEdges18;
            panelTabla.ShadowDecoration.Depth = 4;
            panelTabla.ShadowDecoration.Enabled = true;
            panelTabla.Size = new Size(818, 310);
            panelTabla.TabIndex = 3;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 251, 253);
            dgvEstudiantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEstudiantes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(247, 250, 252);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(113, 128, 150);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEstudiantes.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 240, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEstudiantes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEstudiantes.Dock = DockStyle.Fill;
            dgvEstudiantes.GridColor = Color.FromArgb(226, 232, 240);
            dgvEstudiantes.Location = new Point(8, 8);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowHeadersVisible = false;
            dgvEstudiantes.RowTemplate.Height = 32;
            dgvEstudiantes.Size = new Size(802, 294);
            dgvEstudiantes.TabIndex = 0;
            dgvEstudiantes.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvEstudiantes.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvEstudiantes.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvEstudiantes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvEstudiantes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvEstudiantes.ThemeStyle.BackColor = Color.White;
            dgvEstudiantes.ThemeStyle.GridColor = Color.FromArgb(226, 232, 240);
            dgvEstudiantes.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvEstudiantes.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEstudiantes.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvEstudiantes.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvEstudiantes.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEstudiantes.ThemeStyle.HeaderStyle.Height = 34;
            dgvEstudiantes.ThemeStyle.ReadOnly = true;
            dgvEstudiantes.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvEstudiantes.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEstudiantes.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvEstudiantes.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvEstudiantes.ThemeStyle.RowsStyle.Height = 32;
            dgvEstudiantes.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEstudiantes.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvEstudiantes.CellFormatting += dgvEstudiantes_CellFormatting;
            // 
            // lblA1
            // 
            lblA1.BackColor = Color.Transparent;
            lblA1.Location = new Point(0, 0);
            lblA1.Name = "lblA1";
            lblA1.Size = new Size(17, 17);
            lblA1.TabIndex = 0;
            lblA1.Text = "A1";
            // 
            // lblA2
            // 
            lblA2.BackColor = Color.Transparent;
            lblA2.Location = new Point(60, 0);
            lblA2.Name = "lblA2";
            lblA2.Size = new Size(17, 17);
            lblA2.TabIndex = 1;
            lblA2.Text = "A2";
            // 
            // lblB1
            // 
            lblB1.BackColor = Color.Transparent;
            lblB1.Location = new Point(120, 0);
            lblB1.Name = "lblB1";
            lblB1.Size = new Size(16, 17);
            lblB1.TabIndex = 2;
            lblB1.Text = "B1";
            // 
            // lblB2
            // 
            lblB2.BackColor = Color.Transparent;
            lblB2.Location = new Point(180, 0);
            lblB2.Name = "lblB2";
            lblB2.Size = new Size(16, 17);
            lblB2.TabIndex = 3;
            lblB2.Text = "B2";
            // 
            // lblC1
            // 
            lblC1.BackColor = Color.Transparent;
            lblC1.Location = new Point(240, 0);
            lblC1.Name = "lblC1";
            lblC1.Size = new Size(17, 17);
            lblC1.TabIndex = 4;
            lblC1.Text = "C1";
            // 
            // lblC2
            // 
            lblC2.BackColor = Color.Transparent;
            lblC2.Location = new Point(300, 0);
            lblC2.Name = "lblC2";
            lblC2.Size = new Size(17, 17);
            lblC2.TabIndex = 5;
            lblC2.Text = "C2";
            // 
            // FrmMisEstudiantes
            // 
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(854, 535);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMisEstudiantes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mis Estudiantes";
            Load += FrmMisEstudiantes_Load;
            panelPrincipal.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStats.ResumeLayout(false);
            cardTotal.ResumeLayout(false);
            cardTotal.PerformLayout();
            cardNiveles.ResumeLayout(false);
            cardNiveles.PerformLayout();
            panelToolbar.ResumeLayout(false);
            panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
        }
    }
}