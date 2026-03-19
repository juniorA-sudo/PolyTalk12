using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace Presentation
{
    partial class FrmNuevoEstudiante
    {
        private System.ComponentModel.IContainer components = null;

        // Controles existentes
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

        // Controles nuevos
        private Guna2HtmlLabel lblApellido;
        private Guna2TextBox txtApellido;
        private Guna2HtmlLabel lblContrasena;
        private Guna2TextBox txtContrasena;
        private Guna2HtmlLabel lblConfirmar;
        private Guna2TextBox txtConfirmar;
        private Guna2HtmlLabel lblGrupoLabel;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges ce5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            DataGridViewCellStyle dgvStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvStyle3 = new DataGridViewCellStyle();

            guna2Panel1 = new Guna2Panel();
            guna2Panel2 = new Guna2Panel();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            iconPictureBox1 = new IconPictureBox();
            guna2Panel3 = new Guna2Panel();
            guna2HtmlLabel2 = new Guna2HtmlLabel();
            txtNombre = new Guna2TextBox();
            lblApellido = new Guna2HtmlLabel();
            txtApellido = new Guna2TextBox();
            guna2HtmlLabel3 = new Guna2HtmlLabel();
            txtEmail = new Guna2TextBox();
            guna2HtmlLabel7 = new Guna2HtmlLabel();
            txtTelefono = new Guna2TextBox();
            guna2HtmlLabel4 = new Guna2HtmlLabel();
            cmbNivel = new Guna2ComboBox();
            lblContrasena = new Guna2HtmlLabel();
            txtContrasena = new Guna2TextBox();
            lblConfirmar = new Guna2HtmlLabel();
            txtConfirmar = new Guna2TextBox();
            lblGrupoLabel = new Guna2HtmlLabel();
            dgvGrupos = new Guna2DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colNivel = new DataGridViewTextBoxColumn();
            colCupo = new DataGridViewTextBoxColumn();
            btnGuardar = new IconButton();
            btnCancelar = new IconButton();

            guna2Panel1.SuspendLayout();
            guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();

            // ── HEADER ──────────────────────────────────────────
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconChar = IconChar.UserGraduate;
            iconPictureBox1.IconColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconFont = IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(12, 10);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;

            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(0, 82, 180);
            guna2HtmlLabel1.Location = new Point(60, 18);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(160, 23);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Nuevo Estudiante";

            guna2Panel2.BackColor = Color.FromArgb(230, 230, 230);
            guna2Panel2.CustomizableEdges = ce1;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.Location = new Point(0, 59);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = ce2;
            guna2Panel2.Size = new Size(450, 1);
            guna2Panel2.TabIndex = 0;

            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(iconPictureBox1);
            guna2Panel1.CustomizableEdges = ce3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = ce4;
            guna2Panel1.Size = new Size(450, 60);
            guna2Panel1.TabIndex = 0;

            // ── BODY ─────────────────────────────────────────────
            // Nombre
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel2.Location = new Point(15, 12);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(55, 17);
            guna2HtmlLabel2.TabIndex = 0;
            guna2HtmlLabel2.Text = "Nombre *";

            txtNombre.BorderRadius = 5;
            txtNombre.CustomizableEdges = ce5;
            txtNombre.DefaultText = "";
            txtNombre.FillColor = Color.FromArgb(247, 250, 252);
            txtNombre.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.Gray;
            txtNombre.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.Location = new Point(15, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "";
            txtNombre.SelectedText = "";
            txtNombre.ShadowDecoration.CustomizableEdges = ce6;
            txtNombre.Size = new Size(195, 36);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Ej: Juan";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;

            // Apellido
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.ForeColor = Color.FromArgb(64, 64, 64);
            lblApellido.Location = new Point(225, 12);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 17);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido *";

            txtApellido.BorderRadius = 5;
            txtApellido.CustomizableEdges = ce7;
            txtApellido.DefaultText = "";
            txtApellido.FillColor = Color.FromArgb(247, 250, 252);
            txtApellido.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.ForeColor = Color.Gray;
            txtApellido.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtApellido.Location = new Point(225, 32);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "";
            txtApellido.SelectedText = "";
            txtApellido.ShadowDecoration.CustomizableEdges = ce8;
            txtApellido.Size = new Size(195, 36);
            txtApellido.TabIndex = 3;
            txtApellido.Text = "Ej: Pérez";
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;

            // Email
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel3.Location = new Point(15, 76);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(40, 17);
            guna2HtmlLabel3.TabIndex = 4;
            guna2HtmlLabel3.Text = "Email *";

            txtEmail.BorderRadius = 5;
            txtEmail.CustomizableEdges = ce9;
            txtEmail.DefaultText = "";
            txtEmail.FillColor = Color.FromArgb(247, 250, 252);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(15, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = ce10;
            txtEmail.Size = new Size(405, 36);
            txtEmail.TabIndex = 5;
            txtEmail.Text = "estudiante@polytalk.com";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;

            // Teléfono
            guna2HtmlLabel7.BackColor = Color.Transparent;
            guna2HtmlLabel7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel7.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel7.Location = new Point(15, 140);
            guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            guna2HtmlLabel7.Size = new Size(55, 17);
            guna2HtmlLabel7.TabIndex = 6;
            guna2HtmlLabel7.Text = "Teléfono";

            txtTelefono.BorderRadius = 5;
            txtTelefono.CustomizableEdges = ce11;
            txtTelefono.DefaultText = "";
            txtTelefono.FillColor = Color.FromArgb(247, 250, 252);
            txtTelefono.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.ForeColor = Color.Gray;
            txtTelefono.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefono.Location = new Point(15, 160);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "";
            txtTelefono.SelectedText = "";
            txtTelefono.ShadowDecoration.CustomizableEdges = ce12;
            txtTelefono.Size = new Size(405, 36);
            txtTelefono.TabIndex = 7;
            txtTelefono.Text = "+1 809-123-4567";
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;

            // Nivel
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel4.Location = new Point(15, 204);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(75, 17);
            guna2HtmlLabel4.TabIndex = 8;
            guna2HtmlLabel4.Text = "Nivel MCER *";

            cmbNivel.BackColor = Color.Transparent;
            cmbNivel.BorderRadius = 5;
            cmbNivel.CustomizableEdges = ce13;
            cmbNivel.DrawMode = DrawMode.OwnerDrawFixed;
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.FocusedColor = Color.Empty;
            cmbNivel.Font = new Font("Segoe UI", 10F);
            cmbNivel.ForeColor = Color.FromArgb(68, 88, 112);
            cmbNivel.ItemHeight = 30;
            cmbNivel.Location = new Point(15, 224);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.ShadowDecoration.CustomizableEdges = ce14;
            cmbNivel.Size = new Size(180, 36);
            cmbNivel.TabIndex = 9;

            // Contraseña
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            lblContrasena.Location = new Point(15, 268);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(80, 17);
            lblContrasena.TabIndex = 10;
            lblContrasena.Text = "Contraseña *";

            txtContrasena.BorderRadius = 5;
            txtContrasena.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtContrasena.DefaultText = "";
            txtContrasena.FillColor = Color.FromArgb(247, 250, 252);
            txtContrasena.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContrasena.Font = new Font("Segoe UI", 10F);
            txtContrasena.ForeColor = Color.Gray;
            txtContrasena.Location = new Point(15, 288);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "";
            txtContrasena.SelectedText = "";
            txtContrasena.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtContrasena.Size = new Size(195, 36);
            txtContrasena.TabIndex = 11;
            txtContrasena.Text = "Mínimo 6 caracteres";
            txtContrasena.Enter += txtContrasena_Enter;
            txtContrasena.Leave += txtContrasena_Leave;

            // Confirmar
            lblConfirmar.BackColor = Color.Transparent;
            lblConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConfirmar.ForeColor = Color.FromArgb(64, 64, 64);
            lblConfirmar.Location = new Point(225, 268);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(115, 17);
            lblConfirmar.TabIndex = 12;
            lblConfirmar.Text = "Confirmar contraseña";

            txtConfirmar.BorderRadius = 5;
            txtConfirmar.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtConfirmar.DefaultText = "";
            txtConfirmar.FillColor = Color.FromArgb(247, 250, 252);
            txtConfirmar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmar.Font = new Font("Segoe UI", 10F);
            txtConfirmar.ForeColor = Color.Gray;
            txtConfirmar.Location = new Point(225, 288);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PlaceholderText = "";
            txtConfirmar.SelectedText = "";
            txtConfirmar.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtConfirmar.Size = new Size(195, 36);
            txtConfirmar.TabIndex = 13;
            txtConfirmar.Text = "Repetir contraseña";
            txtConfirmar.Enter += txtConfirmar_Enter;
            txtConfirmar.Leave += txtConfirmar_Leave;

            // Grupo label
            lblGrupoLabel.BackColor = Color.Transparent;
            lblGrupoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGrupoLabel.ForeColor = Color.FromArgb(64, 64, 64);
            lblGrupoLabel.Location = new Point(15, 333);
            lblGrupoLabel.Name = "lblGrupoLabel";
            lblGrupoLabel.Size = new Size(130, 17);
            lblGrupoLabel.TabIndex = 14;
            lblGrupoLabel.Text = "Seleccionar Grupo *";

            // DGV Grupos
            dgvStyle1.BackColor = Color.White;
            dgvGrupos.AlternatingRowsDefaultCellStyle = dgvStyle1;
            dgvStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStyle2.BackColor = Color.FromArgb(0, 82, 180);
            dgvStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvStyle2.ForeColor = Color.White;
            dgvStyle2.WrapMode = DataGridViewTriState.True;
            dgvGrupos.ColumnHeadersDefaultCellStyle = dgvStyle2;
            dgvGrupos.ColumnHeadersHeight = 30;
            dgvStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStyle3.BackColor = Color.White;
            dgvStyle3.Font = new Font("Segoe UI", 9F);
            dgvStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dgvStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvGrupos.DefaultCellStyle = dgvStyle3;
            dgvGrupos.AllowUserToAddRows = false;
            dgvGrupos.AllowUserToDeleteRows = false;
            dgvGrupos.GridColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.Location = new Point(15, 353);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.ReadOnly = true;
            dgvGrupos.RowHeadersVisible = false;
            dgvGrupos.Size = new Size(405, 130);
            dgvGrupos.TabIndex = 15;
            dgvGrupos.ThemeStyle.BackColor = Color.White;
            dgvGrupos.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 82, 180);
            dgvGrupos.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGrupos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvGrupos.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvGrupos.ThemeStyle.HeaderStyle.Height = 30;
            dgvGrupos.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvGrupos.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGrupos.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvGrupos.ThemeStyle.RowsStyle.Height = 25;
            dgvGrupos.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvGrupos.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colNivel, colCupo });
            dgvGrupos.SelectionChanged += dgvGrupos_SelectionChanged;

            colId.HeaderText = "ID"; colId.Name = "colId"; colId.Visible = false; colId.ReadOnly = true;
            colNombre.HeaderText = "Grupo"; colNombre.Name = "colNombre"; colNombre.Width = 160; colNombre.ReadOnly = true;
            colNivel.HeaderText = "Nivel"; colNivel.Name = "colNivel"; colNivel.Width = 70; colNivel.ReadOnly = true;
            colCupo.HeaderText = "Cupo"; colCupo.Name = "colCupo"; colCupo.Width = 60; colCupo.ReadOnly = true;

            // Botones
            btnGuardar.BackColor = Color.FromArgb(0, 82, 180);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = IconFont.Auto;
            btnGuardar.IconSize = 20;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(255, 500);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(165, 36);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "   Guardar Estudiante";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;

            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = IconFont.Auto;
            btnCancelar.Location = new Point(15, 500);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 36);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;

            // Panel body
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.Controls.Add(guna2HtmlLabel2);
            guna2Panel3.Controls.Add(txtNombre);
            guna2Panel3.Controls.Add(lblApellido);
            guna2Panel3.Controls.Add(txtApellido);
            guna2Panel3.Controls.Add(guna2HtmlLabel3);
            guna2Panel3.Controls.Add(txtEmail);
            guna2Panel3.Controls.Add(guna2HtmlLabel7);
            guna2Panel3.Controls.Add(txtTelefono);
            guna2Panel3.Controls.Add(guna2HtmlLabel4);
            guna2Panel3.Controls.Add(cmbNivel);
            guna2Panel3.Controls.Add(lblContrasena);
            guna2Panel3.Controls.Add(txtContrasena);
            guna2Panel3.Controls.Add(lblConfirmar);
            guna2Panel3.Controls.Add(txtConfirmar);
            guna2Panel3.Controls.Add(lblGrupoLabel);
            guna2Panel3.Controls.Add(dgvGrupos);
            guna2Panel3.Controls.Add(btnGuardar);
            guna2Panel3.Controls.Add(btnCancelar);
            guna2Panel3.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(0, 60);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Padding = new Padding(0, 5, 0, 10);
            guna2Panel3.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel3.Size = new Size(450, 550);
            guna2Panel3.TabIndex = 1;

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 610);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevoEstudiante";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Estudiante";

            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
        }
    }
}