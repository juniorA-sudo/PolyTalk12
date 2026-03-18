using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace Presentation
{
    partial class FrmNuevoEstudiante
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private Guna2Panel guna2Panel1;
        private Guna2Panel guna2Panel2;
        private Guna2HtmlLabel guna2HtmlLabel1;
        private IconPictureBox iconPictureBox1;

        private Guna2Panel guna2Panel3;
        private Guna2TextBox txtNombre;
        private Guna2HtmlLabel guna2HtmlLabel2;
        private Guna2TextBox txtEmail;
        private Guna2HtmlLabel guna2HtmlLabel3;
        private Guna2TextBox txtTelefono;
        private Guna2HtmlLabel guna2HtmlLabel7;
        private Guna2ComboBox cmbNivel;
        private Guna2HtmlLabel guna2HtmlLabel4;
        private Guna2DataGridView dgvGrupos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colNivel;
        private DataGridViewTextBoxColumn colCupo;
        private IconButton btnGuardar;
        private IconButton btnCancelar;

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
            txtNombre = new Guna2TextBox();
            guna2HtmlLabel2 = new Guna2HtmlLabel();
            txtEmail = new Guna2TextBox();
            guna2HtmlLabel3 = new Guna2HtmlLabel();
            txtTelefono = new Guna2TextBox();
            guna2HtmlLabel7 = new Guna2HtmlLabel();
            cmbNivel = new Guna2ComboBox();
            guna2HtmlLabel4 = new Guna2HtmlLabel();
            dgvGrupos = new Guna2DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colNivel = new DataGridViewTextBoxColumn();
            colCupo = new DataGridViewTextBoxColumn();
            btnGuardar = new IconButton();
            btnCancelar = new IconButton();
            guna2Panel1.SuspendLayout();
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
            guna2HtmlLabel1.Size = new Size(139, 23);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Nuevo Estudiante";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconChar = IconChar.User;
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
            guna2Panel3.Controls.Add(txtNombre);
            guna2Panel3.Controls.Add(guna2HtmlLabel2);
            guna2Panel3.Controls.Add(txtEmail);
            guna2Panel3.Controls.Add(guna2HtmlLabel3);
            guna2Panel3.Controls.Add(txtTelefono);
            guna2Panel3.Controls.Add(guna2HtmlLabel7);
            guna2Panel3.Controls.Add(cmbNivel);
            guna2Panel3.Controls.Add(guna2HtmlLabel4);
            guna2Panel3.Controls.Add(dgvGrupos);
            guna2Panel3.Controls.Add(btnGuardar);
            guna2Panel3.Controls.Add(btnCancelar);
            guna2Panel3.CustomizableEdges = customizableEdges13;
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(0, 60);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Padding = new Padding(20);
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel3.Size = new Size(450, 498);
            guna2Panel3.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BorderRadius = 5;
            txtNombre.CustomizableEdges = customizableEdges5;
            txtNombre.DefaultText = "Ej: Juan Perez";
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Location = new Point(20, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "";
            txtNombre.SelectedText = "";
            txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            guna2HtmlLabel2.Size = new Size(106, 17);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "Nombre Completo";
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 5;
            txtEmail.CustomizableEdges = customizableEdges7;
            txtEmail.DefaultText = "maestro@polytalk.com";
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(20, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtEmail.Size = new Size(400, 36);
            txtEmail.TabIndex = 1;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel3.Location = new Point(20, 80);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(32, 17);
            guna2HtmlLabel3.TabIndex = 2;
            guna2HtmlLabel3.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderRadius = 5;
            txtTelefono.CustomizableEdges = customizableEdges9;
            txtTelefono.DefaultText = "+1 809-123-456";
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.ForeColor = Color.Gray;
            txtTelefono.Location = new Point(20, 160);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "";
            txtTelefono.SelectedText = "";
            txtTelefono.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtTelefono.Size = new Size(400, 36);
            txtTelefono.TabIndex = 2;
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // guna2HtmlLabel7
            // 
            guna2HtmlLabel7.BackColor = Color.Transparent;
            guna2HtmlLabel7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel7.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel7.Location = new Point(20, 140);
            guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            guna2HtmlLabel7.Size = new Size(53, 17);
            guna2HtmlLabel7.TabIndex = 3;
            guna2HtmlLabel7.Text = "Teléfono";
            // 
            // cmbNivel
            // 
            cmbNivel.BackColor = Color.Transparent;
            cmbNivel.BorderRadius = 5;
            cmbNivel.CustomizableEdges = customizableEdges11;
            cmbNivel.DrawMode = DrawMode.OwnerDrawFixed;
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.FocusedColor = Color.Empty;
            cmbNivel.Font = new Font("Segoe UI", 10F);
            cmbNivel.ForeColor = Color.FromArgb(68, 88, 112);
            cmbNivel.ItemHeight = 30;
            cmbNivel.Items.AddRange(new object[] { "A1", "A2", "B1", "B2", "C1", "C2" });
            cmbNivel.Location = new Point(20, 220);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cmbNivel.Size = new Size(180, 36);
            cmbNivel.TabIndex = 3;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel4.Location = new Point(20, 200);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(67, 17);
            guna2HtmlLabel4.TabIndex = 4;
            guna2HtmlLabel4.Text = "Nivel MCER";
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
            dgvGrupos.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colNivel, colCupo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGrupos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGrupos.GridColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.Location = new Point(20, 280);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.ReadOnly = true;
            dgvGrupos.RowHeadersVisible = false;
            dgvGrupos.Size = new Size(400, 156);
            dgvGrupos.TabIndex = 4;
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
            dgvGrupos.SelectionChanged += dgvGrupos_SelectionChanged;
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
            colNombre.HeaderText = "Grupo";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colNivel
            // 
            colNivel.HeaderText = "Nivel";
            colNivel.Name = "colNivel";
            colNivel.ReadOnly = true;
            // 
            // colCupo
            // 
            colCupo.HeaderText = "Cupo";
            colCupo.Name = "colCupo";
            colCupo.ReadOnly = true;
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
            btnGuardar.IconSize = 20;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(270, 451);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 35);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "   Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            btnCancelar.Location = new Point(150, 451);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmNuevoEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 558);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevoEstudiante";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Estudiante";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
        }
    }
}