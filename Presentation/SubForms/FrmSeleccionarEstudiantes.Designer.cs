namespace Presentation
{
    partial class FrmSeleccionarEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            dgvStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            lblContador = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new Label();
            cmbFiltroNivel = new ComboBox();
            txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel3
            // 
            guna2Panel3.AutoScroll = true;
            guna2Panel3.Controls.Add(dgvStudents);
            guna2Panel3.Controls.Add(lblContador);
            guna2Panel3.Controls.Add(label1);
            guna2Panel3.Controls.Add(cmbFiltroNivel);
            guna2Panel3.Controls.Add(txtBuscar);
            guna2Panel3.Controls.Add(btnAgregar);
            guna2Panel3.Controls.Add(guna2TextBox3);
            guna2Panel3.CustomizableEdges = customizableEdges5;
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(0, 60);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel3.Size = new Size(450, 340);
            guna2Panel3.TabIndex = 24;
            // 
            // dgvStudents
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvStudents.ColumnHeadersHeight = 4;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvStudents.DefaultCellStyle = dataGridViewCellStyle3;
            dgvStudents.GridColor = Color.FromArgb(231, 229, 255);
            dgvStudents.Location = new Point(21, 106);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.Size = new Size(389, 127);
            dgvStudents.TabIndex = 43;
            dgvStudents.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvStudents.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvStudents.ThemeStyle.BackColor = Color.White;
            dgvStudents.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvStudents.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvStudents.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStudents.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvStudents.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvStudents.ThemeStyle.HeaderStyle.Height = 4;
            dgvStudents.ThemeStyle.ReadOnly = false;
            dgvStudents.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvStudents.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStudents.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvStudents.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvStudents.ThemeStyle.RowsStyle.Height = 25;
            dgvStudents.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvStudents.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblContador
            // 
            lblContador.BackColor = Color.Transparent;
            lblContador.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContador.Location = new Point(160, 17);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(28, 22);
            lblContador.TabIndex = 42;
            lblContador.Text = "0/0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 41;
            label1.Text = "Estudiantes disponibles:";
            // 
            // cmbFiltroNivel
            // 
            cmbFiltroNivel.FormattingEnabled = true;
            cmbFiltroNivel.Location = new Point(302, 61);
            cmbFiltroNivel.Name = "cmbFiltroNivel";
            cmbFiltroNivel.Size = new Size(115, 23);
            cmbFiltroNivel.TabIndex = 39;
            cmbFiltroNivel.SelectedIndexChanged += cmbFiltroNivel_SelectedIndexChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Transparent;
            txtBuscar.BorderRadius = 5;
            txtBuscar.CustomizableEdges = customizableEdges1;
            txtBuscar.DefaultText = "Buscar estudiante por nombre, email o nivel...";
            txtBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscar.Font = new Font("Segoe UI", 9F);
            txtBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscar.Location = new Point(21, 56);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "";
            txtBuscar.SelectedText = "";
            txtBuscar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscar.ShadowDecoration.Depth = 5;
            txtBuscar.ShadowDecoration.Enabled = true;
            txtBuscar.Size = new Size(270, 28);
            txtBuscar.TabIndex = 38;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 82, 180);
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 30;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(21, 257);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(396, 35);
            btnAgregar.TabIndex = 37;
            btnAgregar.Text = "Agregar Estudiantes";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // guna2TextBox3
            // 
            guna2TextBox3.BorderRadius = 5;
            guna2TextBox3.CustomizableEdges = customizableEdges3;
            guna2TextBox3.DefaultText = "+1 809-123-456";
            guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Font = new Font("Segoe UI", 9F);
            guna2TextBox3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Location = new Point(21, 440);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PlaceholderText = "";
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox3.Size = new Size(402, 32);
            guna2TextBox3.TabIndex = 30;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.Black;
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(iconPictureBox1);
            customizableEdges9.TopRight = false;
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(450, 60);
            guna2Panel1.TabIndex = 23;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = SystemColors.ActiveBorder;
            guna2Panel2.CustomizableEdges = customizableEdges7;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.Location = new Point(0, 59);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel2.Size = new Size(450, 1);
            guna2Panel2.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(51, 51, 51);
            guna2HtmlLabel1.Location = new Point(62, 20);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(174, 23);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Seleccionar Estudiantes";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            iconPictureBox1.IconColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 38;
            iconPictureBox1.Location = new Point(12, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(38, 41);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // FrmSeleccionarEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 400);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSeleccionarEstudiantes";
            Text = "FrmSeleccionarEstudiantes";
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private ComboBox cmbFiltroNivel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContador;
        private Label label1;
        private DataGridView dgvEstudiantes;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStudents;
    }
}