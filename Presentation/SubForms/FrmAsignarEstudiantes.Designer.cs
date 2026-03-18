using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace Presentation
{
    partial class FrmAsignarEstudiantes
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private Guna2Panel guna2Panel1;
        private Guna2Panel guna2Panel2;
        private Guna2HtmlLabel guna2HtmlLabel1;
        private IconPictureBox iconPictureBox1;
        private Guna2Panel guna2Panel3;
        private IconButton btnCancelar;
        private IconButton btnGuardar;
        private Guna2HtmlLabel guna2HtmlLabel2;
        private IconButton btnSeleccionarEstudiantes;
        private Guna2Panel guna2Panel4;
        private Label label2;
        private Label lblCupoDisponible;
        private IconPictureBox iconPictureBox2;
        private ListBox lstEstudiantes;
        private Guna2DataGridView dgvGrupos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colGrupo;
        private DataGridViewTextBoxColumn colCupo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Panel1 = new Guna2Panel();
            guna2Panel2 = new Guna2Panel();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            guna2Panel4 = new Guna2Panel();
            label2 = new Label();
            lblCupoDisponible = new Label();
            iconPictureBox2 = new IconPictureBox();
            iconPictureBox1 = new IconPictureBox();
            guna2Panel3 = new Guna2Panel();
            dgvGrupos = new Guna2DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colGrupo = new DataGridViewTextBoxColumn();
            colCupo = new DataGridViewTextBoxColumn();
            lstEstudiantes = new ListBox();
            btnSeleccionarEstudiantes = new IconButton();
            btnCancelar = new IconButton();
            btnGuardar = new IconButton();
            guna2HtmlLabel2 = new Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna2HtmlLabel();
            guna2Panel1.SuspendLayout();
            guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(guna2Panel4);
            guna2Panel1.Controls.Add(iconPictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(450, 60);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(230, 230, 230);
            guna2Panel2.CustomizableEdges = customizableEdges1;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.Location = new Point(0, 59);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(450, 1);
            guna2Panel2.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(0, 82, 180);
            guna2HtmlLabel1.Location = new Point(60, 20);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(153, 23);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Asignar Estudiantes";
            // 
            // guna2Panel4
            // 
            guna2Panel4.BackColor = Color.Transparent;
            guna2Panel4.BorderColor = Color.FromArgb(0, 82, 180);
            guna2Panel4.BorderRadius = 5;
            guna2Panel4.BorderThickness = 2;
            guna2Panel4.Controls.Add(label2);
            guna2Panel4.Controls.Add(lblCupoDisponible);
            guna2Panel4.Controls.Add(iconPictureBox2);
            guna2Panel4.CustomizableEdges = customizableEdges3;
            guna2Panel4.Location = new Point(252, 12);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel4.Size = new Size(186, 36);
            guna2Panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(66, 11);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 0;
            label2.Text = "cupos disponibles";
            // 
            // lblCupoDisponible
            // 
            lblCupoDisponible.AutoSize = true;
            lblCupoDisponible.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblCupoDisponible.Location = new Point(42, 8);
            lblCupoDisponible.Name = "lblCupoDisponible";
            lblCupoDisponible.Size = new Size(18, 20);
            lblCupoDisponible.TabIndex = 1;
            lblCupoDisponible.Text = "0";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = Color.FromArgb(0, 82, 180);
            iconPictureBox2.IconChar = IconChar.Chair;
            iconPictureBox2.IconColor = Color.FromArgb(0, 82, 180);
            iconPictureBox2.IconFont = IconFont.Auto;
            iconPictureBox2.IconSize = 27;
            iconPictureBox2.Location = new Point(9, 6);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(27, 28);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconChar = IconChar.UserPlus;
            iconPictureBox1.IconColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconFont = IconFont.Auto;
            iconPictureBox1.IconSize = 38;
            iconPictureBox1.Location = new Point(12, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(38, 41);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.Controls.Add(guna2HtmlLabel4);
            guna2Panel3.Controls.Add(dgvGrupos);
            guna2Panel3.Controls.Add(lstEstudiantes);
            guna2Panel3.Controls.Add(btnSeleccionarEstudiantes);
            guna2Panel3.Controls.Add(btnCancelar);
            guna2Panel3.Controls.Add(btnGuardar);
            guna2Panel3.Controls.Add(guna2HtmlLabel2);
            guna2Panel3.CustomizableEdges = customizableEdges7;
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(0, 60);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Padding = new Padding(20);
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel3.Size = new Size(450, 439);
            guna2Panel3.TabIndex = 1;
            // 
            // dgvGrupos
            // 
            dgvGrupos.AllowUserToAddRows = false;
            dgvGrupos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 82, 180);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGrupos.ColumnHeadersHeight = 30;
            dgvGrupos.Columns.AddRange(new DataGridViewColumn[] { colId, colGrupo, colCupo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGrupos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGrupos.GridColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.Location = new Point(20, 40);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.ReadOnly = true;
            dgvGrupos.RowHeadersVisible = false;
            dgvGrupos.Size = new Size(400, 156);
            dgvGrupos.TabIndex = 0;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvGrupos.ThemeStyle.BackColor = Color.White;
            dgvGrupos.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 82, 180);
            dgvGrupos.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGrupos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvGrupos.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvGrupos.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGrupos.ThemeStyle.HeaderStyle.Height = 30;
            dgvGrupos.ThemeStyle.ReadOnly = true;
            dgvGrupos.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvGrupos.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGrupos.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvGrupos.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvGrupos.ThemeStyle.RowsStyle.Height = 25;
            dgvGrupos.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvGrupos.CellClick += dgvGrupos_CellClick;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colGrupo
            // 
            colGrupo.HeaderText = "Grupo";
            colGrupo.Name = "colGrupo";
            colGrupo.ReadOnly = true;
            // 
            // colCupo
            // 
            colCupo.HeaderText = "Cupo disponible";
            colCupo.Name = "colCupo";
            colCupo.ReadOnly = true;
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.ItemHeight = 15;
            lstEstudiantes.Location = new Point(20, 248);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new Size(400, 79);
            lstEstudiantes.TabIndex = 2;
            // 
            // btnSeleccionarEstudiantes
            // 
            btnSeleccionarEstudiantes.BackColor = Color.FromArgb(0, 82, 180);
            btnSeleccionarEstudiantes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSeleccionarEstudiantes.ForeColor = Color.White;
            btnSeleccionarEstudiantes.IconChar = IconChar.UserCheck;
            btnSeleccionarEstudiantes.IconColor = Color.White;
            btnSeleccionarEstudiantes.IconFont = IconFont.Auto;
            btnSeleccionarEstudiantes.IconSize = 30;
            btnSeleccionarEstudiantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeleccionarEstudiantes.Location = new Point(20, 333);
            btnSeleccionarEstudiantes.Name = "btnSeleccionarEstudiantes";
            btnSeleccionarEstudiantes.Size = new Size(418, 35);
            btnSeleccionarEstudiantes.TabIndex = 3;
            btnSeleccionarEstudiantes.Text = "Seleccionar Estudiantes";
            btnSeleccionarEstudiantes.UseVisualStyleBackColor = false;
            btnSeleccionarEstudiantes.Click += btnSeleccionarEstudiantes_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = IconFont.Auto;
            btnCancelar.Location = new Point(131, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 82, 180);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = IconFont.Auto;
            btnGuardar.IconSize = 30;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(237, 383);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(201, 35);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar Asignación";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel2.Location = new Point(20, 20);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(105, 17);
            guna2HtmlLabel2.TabIndex = 7;
            guna2HtmlLabel2.Text = "Seleccionar Grupo";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel4.Location = new Point(20, 225);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(148, 17);
            guna2HtmlLabel4.TabIndex = 7;
            guna2HtmlLabel4.Text = "Estudiantes seleccionados:";
            // 
            // FrmAsignarEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 499);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAsignarEstudiantes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Asignar Estudiantes";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel4.ResumeLayout(false);
            guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
        }
        private Guna2HtmlLabel guna2HtmlLabel4;
    }
}