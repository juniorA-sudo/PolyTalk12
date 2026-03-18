using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace Presentation
{
    partial class FrmNuevaLeccion
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private Guna2Panel guna2Panel1;
        private IconPictureBox iconPictureBox1;
        private Guna2Panel guna2Panel2;
        private Guna2HtmlLabel guna2HtmlLabel1;

        private Guna2Panel guna2Panel3;
        private Guna2HtmlLabel guna2HtmlLabel2; // Título de la lección
        private Guna2TextBox txtTitulo;
        private Guna2HtmlLabel guna2HtmlLabel3; // Nivel
        private Guna2ComboBox cmbNivel;
        private Guna2HtmlLabel guna2HtmlLabel5; // Unidad
        private Guna2DataGridView dgvUnidades;   // DataGridView para unidades
        private DataGridViewTextBoxColumn colUnitId;
        private DataGridViewTextBoxColumn colUnidad;

        private Guna2HtmlLabel guna2HtmlLabel7; // Duración
        private Guna2TextBox nudDuracion;
        private Guna2HtmlLabel guna2HtmlLabel8; // Tipo de lección
        private Guna2ComboBox cmbTipoLeccion;
        private Guna2HtmlLabel guna2HtmlLabel4; // Descripción
        private Guna2TextBox txtDescripcion;
        private Guna2HtmlLabel guna2HtmlLabel10; // Fecha
        private Guna2DateTimePicker dtpFechaPublicacion;

        private IconButton btnCancelar;
        private IconButton btnGuardar;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna2Panel();
            iconPictureBox1 = new IconPictureBox();
            guna2Panel2 = new Guna2Panel();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            guna2Panel3 = new Guna2Panel();
            guna2HtmlLabel2 = new Guna2HtmlLabel();
            txtTitulo = new Guna2TextBox();
            guna2HtmlLabel3 = new Guna2HtmlLabel();
            cmbNivel = new Guna2ComboBox();
            guna2HtmlLabel5 = new Guna2HtmlLabel();
            dgvUnidades = new Guna2DataGridView();
            colUnitId = new DataGridViewTextBoxColumn();
            colUnidad = new DataGridViewTextBoxColumn();
            guna2HtmlLabel7 = new Guna2HtmlLabel();
            nudDuracion = new Guna2TextBox();
            guna2HtmlLabel8 = new Guna2HtmlLabel();
            cmbTipoLeccion = new Guna2ComboBox();
            guna2HtmlLabel4 = new Guna2HtmlLabel();
            txtDescripcion = new Guna2TextBox();
            guna2HtmlLabel10 = new Guna2HtmlLabel();
            dtpFechaPublicacion = new Guna2DateTimePicker();
            btnCancelar = new IconButton();
            btnGuardar = new IconButton();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnidades).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(iconPictureBox1);
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(450, 60);
            guna2Panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconChar = IconChar.Book;
            iconPictureBox1.IconColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconFont = IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(12, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
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
            guna2Panel2.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(0, 82, 180);
            guna2HtmlLabel1.Location = new Point(60, 20);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(159, 23);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Crear Nueva Lección";
            // 
            // guna2Panel3
            // 
            guna2Panel3.AutoScroll = true;
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.Controls.Add(guna2HtmlLabel2);
            guna2Panel3.Controls.Add(txtTitulo);
            guna2Panel3.Controls.Add(guna2HtmlLabel3);
            guna2Panel3.Controls.Add(cmbNivel);
            guna2Panel3.Controls.Add(guna2HtmlLabel5);
            guna2Panel3.Controls.Add(dgvUnidades);
            guna2Panel3.Controls.Add(guna2HtmlLabel7);
            guna2Panel3.Controls.Add(nudDuracion);
            guna2Panel3.Controls.Add(guna2HtmlLabel8);
            guna2Panel3.Controls.Add(cmbTipoLeccion);
            guna2Panel3.Controls.Add(guna2HtmlLabel4);
            guna2Panel3.Controls.Add(txtDescripcion);
            guna2Panel3.Controls.Add(guna2HtmlLabel10);
            guna2Panel3.Controls.Add(dtpFechaPublicacion);
            guna2Panel3.Controls.Add(btnCancelar);
            guna2Panel3.Controls.Add(btnGuardar);
            guna2Panel3.CustomizableEdges = customizableEdges17;
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(0, 60);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Padding = new Padding(20);
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Panel3.Size = new Size(450, 529);
            guna2Panel3.TabIndex = 1;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel2.Location = new Point(20, 20);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(106, 17);
            guna2HtmlLabel2.TabIndex = 0;
            guna2HtmlLabel2.Text = "Título de la lección";
            // 
            // txtTitulo
            // 
            txtTitulo.BorderRadius = 5;
            txtTitulo.CustomizableEdges = customizableEdges5;
            txtTitulo.DefaultText = "Ej: Movie Vocabulary";
            txtTitulo.Font = new Font("Segoe UI", 10F);
            txtTitulo.ForeColor = Color.Gray;
            txtTitulo.Location = new Point(20, 40);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "";
            txtTitulo.SelectedText = "";
            txtTitulo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTitulo.Size = new Size(390, 36);
            txtTitulo.TabIndex = 0;
            txtTitulo.Enter += txtTitulo_Enter;
            txtTitulo.Leave += txtTitulo_Leave;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel3.Location = new Point(20, 85);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(32, 17);
            guna2HtmlLabel3.TabIndex = 1;
            guna2HtmlLabel3.Text = "Nivel";
            // 
            // cmbNivel
            // 
            cmbNivel.BackColor = Color.Transparent;
            cmbNivel.BorderRadius = 5;
            cmbNivel.CustomizableEdges = customizableEdges7;
            cmbNivel.DrawMode = DrawMode.OwnerDrawFixed;
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.FocusedColor = Color.Empty;
            cmbNivel.Font = new Font("Segoe UI", 10F);
            cmbNivel.ForeColor = Color.FromArgb(68, 88, 112);
            cmbNivel.ItemHeight = 30;
            cmbNivel.Location = new Point(20, 105);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbNivel.Size = new Size(180, 36);
            cmbNivel.TabIndex = 1;
            cmbNivel.SelectedIndexChanged += cmbNivel_SelectedIndexChanged;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel5.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel5.Location = new Point(20, 150);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(42, 17);
            guna2HtmlLabel5.TabIndex = 2;
            guna2HtmlLabel5.Text = "Unidad";
            // 
            // dgvUnidades
            // 
            dgvUnidades.AllowUserToAddRows = false;
            dgvUnidades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvUnidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 82, 180);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 82, 180);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUnidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUnidades.ColumnHeadersHeight = 30;
            dgvUnidades.Columns.AddRange(new DataGridViewColumn[] { colUnitId, colUnidad });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUnidades.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUnidades.GridColor = Color.FromArgb(220, 220, 220);
            dgvUnidades.Location = new Point(20, 170);
            dgvUnidades.Name = "dgvUnidades";
            dgvUnidades.ReadOnly = true;
            dgvUnidades.RowHeadersVisible = false;
            dgvUnidades.RowTemplate.Height = 28;
            dgvUnidades.Size = new Size(390, 100);
            dgvUnidades.TabIndex = 2;
            dgvUnidades.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUnidades.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUnidades.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUnidades.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUnidades.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUnidades.ThemeStyle.BackColor = Color.White;
            dgvUnidades.ThemeStyle.GridColor = Color.FromArgb(220, 220, 220);
            dgvUnidades.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvUnidades.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUnidades.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvUnidades.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUnidades.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUnidades.ThemeStyle.HeaderStyle.Height = 30;
            dgvUnidades.ThemeStyle.ReadOnly = true;
            dgvUnidades.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUnidades.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUnidades.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUnidades.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvUnidades.ThemeStyle.RowsStyle.Height = 28;
            dgvUnidades.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUnidades.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvUnidades.CellClick += dgvUnidades_CellClick;
            // 
            // colUnitId
            // 
            colUnitId.HeaderText = "ID";
            colUnitId.Name = "colUnitId";
            colUnitId.ReadOnly = true;
            colUnitId.Visible = false;
            // 
            // colUnidad
            // 
            colUnidad.HeaderText = "Unidades disponibles";
            colUnidad.Name = "colUnidad";
            colUnidad.ReadOnly = true;
            // 
            // guna2HtmlLabel7
            // 
            guna2HtmlLabel7.BackColor = Color.Transparent;
            guna2HtmlLabel7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel7.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel7.Location = new Point(20, 280);
            guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            guna2HtmlLabel7.Size = new Size(109, 17);
            guna2HtmlLabel7.TabIndex = 3;
            guna2HtmlLabel7.Text = "Duración (minutos)";
            // 
            // nudDuracion
            // 
            nudDuracion.BorderRadius = 5;
            nudDuracion.CustomizableEdges = customizableEdges9;
            nudDuracion.DefaultText = "Ej: 30";
            nudDuracion.Font = new Font("Segoe UI", 10F);
            nudDuracion.ForeColor = Color.Gray;
            nudDuracion.Location = new Point(20, 300);
            nudDuracion.Name = "nudDuracion";
            nudDuracion.PlaceholderText = "";
            nudDuracion.SelectedText = "";
            nudDuracion.ShadowDecoration.CustomizableEdges = customizableEdges10;
            nudDuracion.Size = new Size(180, 36);
            nudDuracion.TabIndex = 3;
            nudDuracion.Enter += nudDuracion_Enter;
            nudDuracion.Leave += nudDuracion_Leave;
            // 
            // guna2HtmlLabel8
            // 
            guna2HtmlLabel8.BackColor = Color.Transparent;
            guna2HtmlLabel8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel8.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel8.Location = new Point(220, 280);
            guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            guna2HtmlLabel8.Size = new Size(86, 17);
            guna2HtmlLabel8.TabIndex = 4;
            guna2HtmlLabel8.Text = "Tipo de lección";
            // 
            // cmbTipoLeccion
            // 
            cmbTipoLeccion.BackColor = Color.Transparent;
            cmbTipoLeccion.BorderRadius = 5;
            cmbTipoLeccion.CustomizableEdges = customizableEdges11;
            cmbTipoLeccion.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoLeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoLeccion.FocusedColor = Color.Empty;
            cmbTipoLeccion.Font = new Font("Segoe UI", 10F);
            cmbTipoLeccion.ForeColor = Color.FromArgb(68, 88, 112);
            cmbTipoLeccion.ItemHeight = 30;
            cmbTipoLeccion.Items.AddRange(new object[] { "🔤 Vocabulario", "📚 Gramática", "🗣️ Speaking", "🎧 Listening", "📖 Lectura", "✍️ Escritura", "✏️ Ejercicio", "📝 Quiz", "🎬 Video" });
            cmbTipoLeccion.Location = new Point(220, 300);
            cmbTipoLeccion.Name = "cmbTipoLeccion";
            cmbTipoLeccion.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cmbTipoLeccion.Size = new Size(190, 36);
            cmbTipoLeccion.TabIndex = 4;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel4.Location = new Point(20, 345);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(195, 17);
            guna2HtmlLabel4.TabIndex = 5;
            guna2HtmlLabel4.Text = "Describe el contenido de la lección";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderRadius = 5;
            txtDescripcion.CustomizableEdges = customizableEdges13;
            txtDescripcion.DefaultText = "Ej: Aprende vocabulario relacionado con películas y cine";
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = Color.Gray;
            txtDescripcion.Location = new Point(20, 365);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "";
            txtDescripcion.SelectedText = "";
            txtDescripcion.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtDescripcion.Size = new Size(390, 36);
            txtDescripcion.TabIndex = 5;
            txtDescripcion.Enter += txtDescripcion_Enter;
            txtDescripcion.Leave += txtDescripcion_Leave;
            // 
            // guna2HtmlLabel10
            // 
            guna2HtmlLabel10.BackColor = Color.Transparent;
            guna2HtmlLabel10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel10.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel10.Location = new Point(20, 410);
            guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            guna2HtmlLabel10.Size = new Size(117, 17);
            guna2HtmlLabel10.TabIndex = 6;
            guna2HtmlLabel10.Text = "Fecha de Publicación";
            // 
            // dtpFechaPublicacion
            // 
            dtpFechaPublicacion.BorderRadius = 5;
            dtpFechaPublicacion.Checked = true;
            dtpFechaPublicacion.CustomizableEdges = customizableEdges15;
            dtpFechaPublicacion.Font = new Font("Segoe UI", 10F);
            dtpFechaPublicacion.Format = DateTimePickerFormat.Long;
            dtpFechaPublicacion.Location = new Point(20, 430);
            dtpFechaPublicacion.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpFechaPublicacion.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            dtpFechaPublicacion.ShadowDecoration.CustomizableEdges = customizableEdges16;
            dtpFechaPublicacion.Size = new Size(250, 36);
            dtpFechaPublicacion.TabIndex = 6;
            dtpFechaPublicacion.Value = new DateTime(2026, 2, 26, 0, 0, 0, 0);
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
            btnCancelar.Location = new Point(130, 480);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 7;
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
            btnGuardar.IconSize = 20;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(240, 480);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "   Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmNuevaLeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 589);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevaLeccion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva Lección";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnidades).EndInit();
            ResumeLayout(false);
        }
    }
}