using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace Presentation
{
    partial class FrmNuevoGrupo
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private Guna2Panel guna2Panel1;
        private Guna2Panel guna2Panel2;
        private Guna2HtmlLabel guna2HtmlLabel1;
        private IconPictureBox iconPictureBox1;
        private Guna2Panel guna2Panel3;
        private IconButton btnCancelar;
        private IconButton btnCrear;
        private Guna2TextBox txtCapacidad;
        private Guna2HtmlLabel guna2HtmlLabel3;
        private Guna2TextBox txtNombre;
        private Guna2HtmlLabel guna2HtmlLabel2;
        private Guna2ComboBox cmbNivel;
        private Guna2HtmlLabel guna2HtmlLabel4;
        private Guna2TextBox txtBuscarMaestro;
        private Guna2HtmlLabel guna2HtmlLabel5;
        private Guna2DataGridView dgvMaestros;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colEmail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Panel1 = new Guna2Panel();
            guna2Panel2 = new Guna2Panel();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            iconPictureBox1 = new IconPictureBox();
            guna2Panel3 = new Guna2Panel();
            btnCancelar = new IconButton();
            btnCrear = new IconButton();
            txtCapacidad = new Guna2TextBox();
            guna2HtmlLabel3 = new Guna2HtmlLabel();
            txtNombre = new Guna2TextBox();
            guna2HtmlLabel2 = new Guna2HtmlLabel();
            cmbNivel = new Guna2ComboBox();
            guna2HtmlLabel4 = new Guna2HtmlLabel();
            txtBuscarMaestro = new Guna2TextBox();
            guna2HtmlLabel5 = new Guna2HtmlLabel();
            dgvMaestros = new Guna2DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaestros).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(iconPictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            guna2HtmlLabel1.Size = new Size(149, 23);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Crear Nuevo Grupo";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconChar = IconChar.Users;
            iconPictureBox1.IconColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconFont = IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(12, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 41);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.Controls.Add(btnCancelar);
            guna2Panel3.Controls.Add(btnCrear);
            guna2Panel3.Controls.Add(txtCapacidad);
            guna2Panel3.Controls.Add(guna2HtmlLabel3);
            guna2Panel3.Controls.Add(txtNombre);
            guna2Panel3.Controls.Add(guna2HtmlLabel2);
            guna2Panel3.Controls.Add(cmbNivel);
            guna2Panel3.Controls.Add(guna2HtmlLabel4);
            guna2Panel3.Controls.Add(txtBuscarMaestro);
            guna2Panel3.Controls.Add(guna2HtmlLabel5);
            guna2Panel3.Controls.Add(dgvMaestros);
            guna2Panel3.CustomizableEdges = customizableEdges13;
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(0, 60);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Padding = new Padding(20);
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel3.Size = new Size(450, 429);
            guna2Panel3.TabIndex = 1;
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
            btnCancelar.Location = new Point(171, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(0, 82, 180);
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.IconChar = IconChar.Users;
            btnCrear.IconColor = Color.White;
            btnCrear.IconFont = IconFont.Auto;
            btnCrear.IconSize = 20;
            btnCrear.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrear.Location = new Point(277, 382);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(150, 35);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "   Crear Grupo";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtCapacidad
            // 
            txtCapacidad.BorderRadius = 5;
            txtCapacidad.CustomizableEdges = customizableEdges5;
            txtCapacidad.DefaultText = "Ej: 20";
            txtCapacidad.Font = new Font("Segoe UI", 10F);
            txtCapacidad.ForeColor = Color.Gray;
            txtCapacidad.Location = new Point(220, 100);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.PlaceholderText = "";
            txtCapacidad.SelectedText = "";
            txtCapacidad.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtCapacidad.Size = new Size(200, 36);
            txtCapacidad.TabIndex = 2;
            txtCapacidad.Enter += txtCapacidad_Enter;
            txtCapacidad.Leave += txtCapacidad_Leave;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel3.Location = new Point(220, 80);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(105, 17);
            guna2HtmlLabel3.TabIndex = 7;
            guna2HtmlLabel3.Text = "Capacidad máxima";
            // 
            // txtNombre
            // 
            txtNombre.BorderRadius = 5;
            txtNombre.CustomizableEdges = customizableEdges7;
            txtNombre.DefaultText = "Ej: Grupo D";
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Location = new Point(20, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "";
            txtNombre.SelectedText = "";
            txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtNombre.Size = new Size(400, 36);
            txtNombre.TabIndex = 0;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel2.Location = new Point(20, 20);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(105, 17);
            guna2HtmlLabel2.TabIndex = 8;
            guna2HtmlLabel2.Text = "Nombre del grupo";
            // 
            // cmbNivel
            // 
            cmbNivel.BackColor = Color.Transparent;
            cmbNivel.BorderRadius = 5;
            cmbNivel.CustomizableEdges = customizableEdges9;
            cmbNivel.DrawMode = DrawMode.OwnerDrawFixed;
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.FocusedColor = Color.Empty;
            cmbNivel.Font = new Font("Segoe UI", 10F);
            cmbNivel.ForeColor = Color.FromArgb(68, 88, 112);
            cmbNivel.ItemHeight = 30;
            cmbNivel.Items.AddRange(new object[] { "A1", "A2", "B1", "B2", "C1", "C2" });
            cmbNivel.Location = new Point(20, 100);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cmbNivel.Size = new Size(180, 36);
            cmbNivel.TabIndex = 1;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel4.Location = new Point(20, 80);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(32, 17);
            guna2HtmlLabel4.TabIndex = 9;
            guna2HtmlLabel4.Text = "Nivel";
            // 
            // txtBuscarMaestro
            // 
            txtBuscarMaestro.BorderRadius = 5;
            txtBuscarMaestro.CustomizableEdges = customizableEdges11;
            txtBuscarMaestro.DefaultText = "";
            txtBuscarMaestro.Font = new Font("Segoe UI", 10F);
            txtBuscarMaestro.ForeColor = Color.Black;
            txtBuscarMaestro.Location = new Point(20, 170);
            txtBuscarMaestro.Name = "txtBuscarMaestro";
            txtBuscarMaestro.PlaceholderText = "Nombre del maestro...";
            txtBuscarMaestro.SelectedText = "";
            txtBuscarMaestro.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtBuscarMaestro.Size = new Size(400, 36);
            txtBuscarMaestro.TabIndex = 3;
            txtBuscarMaestro.TextChanged += txtBuscarMaestro_TextChanged;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel5.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel5.Location = new Point(20, 150);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(89, 17);
            guna2HtmlLabel5.TabIndex = 10;
            guna2HtmlLabel5.Text = "Buscar maestro";
            // 
            // dgvMaestros
            // 
            dgvMaestros.AllowUserToAddRows = false;
            dgvMaestros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvMaestros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 82, 180);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMaestros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMaestros.ColumnHeadersHeight = 30;
            dgvMaestros.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colEmail });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMaestros.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMaestros.GridColor = Color.FromArgb(231, 229, 255);
            dgvMaestros.Location = new Point(20, 220);
            dgvMaestros.Name = "dgvMaestros";
            dgvMaestros.ReadOnly = true;
            dgvMaestros.RowHeadersVisible = false;
            dgvMaestros.Size = new Size(400, 156);
            dgvMaestros.TabIndex = 4;
            dgvMaestros.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvMaestros.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvMaestros.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvMaestros.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvMaestros.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvMaestros.ThemeStyle.BackColor = Color.White;
            dgvMaestros.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvMaestros.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 82, 180);
            dgvMaestros.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMaestros.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvMaestros.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvMaestros.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMaestros.ThemeStyle.HeaderStyle.Height = 30;
            dgvMaestros.ThemeStyle.ReadOnly = true;
            dgvMaestros.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvMaestros.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMaestros.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvMaestros.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvMaestros.ThemeStyle.RowsStyle.Height = 25;
            dgvMaestros.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvMaestros.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvMaestros.CellClick += dgvMaestros_CellClick;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // FrmNuevoGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 489);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevoGrupo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Grupo";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaestros).EndInit();
            ResumeLayout(false);
        }
    }
}