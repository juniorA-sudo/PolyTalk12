using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Administrador
{
    partial class FrmReporteUnidadesPorNivel
    {
        private System.ComponentModel.IContainer components = null;

        // Controles Guna
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTitulo;
        private Guna2HtmlLabel lblSub;
        private Guna2HtmlLabel lblUsuario;
        private Guna2HtmlLabel lblEmail;
        private Guna2HtmlLabel lblDireccion;
        private Guna2HtmlLabel lblTelefono;
        private Guna2HtmlLabel lblFecha;
        private Guna2HtmlLabel lblRNC;
        private Guna2HtmlLabel lblDirigido;

        private FontAwesome.Sharp.IconButton btnImprimir;
        private Guna2HtmlLabel lblNombreReporte;

        private Guna2Panel panelSelector;
        private Guna2HtmlLabel lblSeleccionarNivel;
        private Guna2ComboBox cmbNivel;

        private Guna2DataGridView dgvUnidades;
        private DataGridViewTextBoxColumn colUnidad;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colLecciones;
        private DataGridViewTextBoxColumn colDuracion;
        private DataGridViewTextBoxColumn colCupo;

        private Guna2Panel panelDescripcion;
        private Guna2HtmlLabel lblDescripcion;

        private Guna2Panel panelFirma;
        private Guna2HtmlLabel lblFirma;
        private Guna2HtmlLabel lblFirmaEmail;

        // Filter controls
        private DateTimePicker dtpFechaDesde;
        private DateTimePicker dtpFechaHasta;
        private Button btnFiltrar;
        private Button btnLimpiar;
        private Guna2Panel panelFiltro;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Guna2Panel();
            lblTitulo = new Guna2HtmlLabel();
            lblSub = new Guna2HtmlLabel();
            lblUsuario = new Guna2HtmlLabel();
            lblEmail = new Guna2HtmlLabel();
            lblDireccion = new Guna2HtmlLabel();
            lblTelefono = new Guna2HtmlLabel();
            lblFecha = new Guna2HtmlLabel();
            lblRNC = new Guna2HtmlLabel();
            lblDirigido = new Guna2HtmlLabel();
            panelSelector = new Guna2Panel();
            lblSeleccionarNivel = new Guna2HtmlLabel();
            cmbNivel = new Guna2ComboBox();
            dgvUnidades = new Guna2DataGridView();
            colUnidad = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colLecciones = new DataGridViewTextBoxColumn();
            colDuracion = new DataGridViewTextBoxColumn();
            colCupo = new DataGridViewTextBoxColumn();
            panelDescripcion = new Guna2Panel();
            lblDescripcion = new Guna2HtmlLabel();
            panelFirma = new Guna2Panel();
            lblFirma = new Guna2HtmlLabel();
            lblFirmaEmail = new Guna2HtmlLabel();
            btnImprimir = new FontAwesome.Sharp.IconButton();
            lblNombreReporte = new Guna2HtmlLabel();
            panelFiltro = new Guna2Panel();
            dtpFechaDesde = new DateTimePicker();
            lblDesde = new Guna2HtmlLabel();
            dtpFechaHasta = new DateTimePicker();
            lblHasta = new Guna2HtmlLabel();
            btnFiltrar = new Button();
            btnLimpiar = new Button();
            panelHeader.SuspendLayout();
            panelSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnidades).BeginInit();
            panelDescripcion.SuspendLayout();
            panelFirma.SuspendLayout();
            panelFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.BorderRadius = 10;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSub);
            panelHeader.Controls.Add(lblUsuario);
            panelHeader.Controls.Add(lblEmail);
            panelHeader.Controls.Add(lblDireccion);
            panelHeader.Controls.Add(lblTelefono);
            panelHeader.Controls.Add(lblFecha);
            panelHeader.Controls.Add(lblRNC);
            panelHeader.Controls.Add(lblDirigido);
            panelHeader.CustomizableEdges = customizableEdges1;
            panelHeader.FillColor = Color.White;
            panelHeader.Location = new Point(12, 12);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(15);
            panelHeader.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelHeader.Size = new Size(565, 100);
            panelHeader.TabIndex = 12;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 82, 180);
            lblTitulo.Location = new Point(25, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PolyTalk";
            // 
            // lblSub
            // 
            lblSub.AutoSize = false;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblSub.ForeColor = Color.Gray;
            lblSub.Location = new Point(25, 48);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(200, 20);
            lblSub.TabIndex = 1;
            lblSub.Text = "Learning Management System";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = false;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsuario.Location = new Point(230, 18);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(150, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Junior Alexis";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = false;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 8F);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(230, 38);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(150, 16);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "JuniorAlexis@gmail.com";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = false;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Segoe UI", 8F);
            lblDireccion.ForeColor = Color.Gray;
            lblDireccion.Location = new Point(230, 56);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(150, 16);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "AV. Principal #123, RD";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = false;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Segoe UI", 8F);
            lblTelefono.ForeColor = Color.Gray;
            lblTelefono.Location = new Point(230, 74);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(150, 16);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Tel: 829-888-9999";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = false;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 8F);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.Location = new Point(400, 25);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(120, 16);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "24 de Abril, 2024";
            // 
            // lblRNC
            // 
            lblRNC.AutoSize = false;
            lblRNC.BackColor = Color.Transparent;
            lblRNC.Font = new Font("Segoe UI", 8F);
            lblRNC.ForeColor = Color.Gray;
            lblRNC.Location = new Point(400, 45);
            lblRNC.Name = "lblRNC";
            lblRNC.Size = new Size(120, 16);
            lblRNC.TabIndex = 7;
            lblRNC.Text = "RNC: 101-543210-9";
            // 
            // lblDirigido
            // 
            lblDirigido.AutoSize = false;
            lblDirigido.BackColor = Color.Transparent;
            lblDirigido.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblDirigido.ForeColor = Color.FromArgb(0, 82, 180);
            lblDirigido.Location = new Point(400, 65);
            lblDirigido.Name = "lblDirigido";
            lblDirigido.Size = new Size(150, 30);
            lblDirigido.TabIndex = 8;
            lblDirigido.Text = "Dirigido a: Supervisión, docentes y admins";
            // 
            // panelSelector
            // 
            panelSelector.BackColor = Color.Transparent;
            panelSelector.BorderRadius = 8;
            panelSelector.Controls.Add(btnImprimir);
            panelSelector.Controls.Add(lblSeleccionarNivel);
            panelSelector.Controls.Add(cmbNivel);
            panelSelector.CustomizableEdges = customizableEdges5;
            panelSelector.FillColor = Color.White;
            panelSelector.Location = new Point(12, 177);
            panelSelector.Name = "panelSelector";
            panelSelector.Padding = new Padding(15, 10, 15, 10);
            panelSelector.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelSelector.ShadowDecoration.Enabled = true;
            panelSelector.ShadowDecoration.Shadow = new Padding(0, 0, 4, 4);
            panelSelector.Size = new Size(565, 50);
            panelSelector.TabIndex = 13;
            // 
            // lblSeleccionarNivel
            // 
            lblSeleccionarNivel.AutoSize = false;
            lblSeleccionarNivel.BackColor = Color.Transparent;
            lblSeleccionarNivel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSeleccionarNivel.ForeColor = Color.FromArgb(64, 64, 64);
            lblSeleccionarNivel.Location = new Point(277, 17);
            lblSeleccionarNivel.Name = "lblSeleccionarNivel";
            lblSeleccionarNivel.Size = new Size(120, 20);
            lblSeleccionarNivel.TabIndex = 0;
            lblSeleccionarNivel.Text = "Seleccionar Nivel:";
            // 
            // cmbNivel
            // 
            cmbNivel.BackColor = Color.Transparent;
            cmbNivel.BorderRadius = 5;
            cmbNivel.CustomizableEdges = customizableEdges3;
            cmbNivel.DrawMode = DrawMode.OwnerDrawFixed;
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.FocusedColor = Color.FromArgb(0, 82, 180);
            cmbNivel.FocusedState.BorderColor = Color.FromArgb(0, 82, 180);
            cmbNivel.Font = new Font("Segoe UI", 9F);
            cmbNivel.ForeColor = Color.FromArgb(68, 88, 112);
            cmbNivel.ItemHeight = 30;
            cmbNivel.Items.AddRange(new object[] { "A1 - Principiante", "A2 - Básico", "B1 - Intermedio", "B2 - Intermedio alto", "C1 - Avanzado", "C2 - Maestría" });
            cmbNivel.Location = new Point(403, 6);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbNivel.Size = new Size(150, 36);
            cmbNivel.TabIndex = 0;
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
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUnidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUnidades.ColumnHeadersHeight = 35;
            dgvUnidades.Columns.AddRange(new DataGridViewColumn[] { colUnidad, colDescripcion, colLecciones, colDuracion, colCupo });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUnidades.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUnidades.GridColor = Color.FromArgb(231, 229, 255);
            dgvUnidades.Location = new Point(12, 289);
            dgvUnidades.Name = "dgvUnidades";
            dgvUnidades.ReadOnly = true;
            dgvUnidades.RowHeadersVisible = false;
            dgvUnidades.Size = new Size(565, 140);
            dgvUnidades.TabIndex = 1;
            dgvUnidades.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUnidades.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUnidades.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUnidades.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUnidades.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUnidades.ThemeStyle.BackColor = Color.White;
            dgvUnidades.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvUnidades.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 82, 180);
            dgvUnidades.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUnidades.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvUnidades.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUnidades.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUnidades.ThemeStyle.HeaderStyle.Height = 35;
            dgvUnidades.ThemeStyle.ReadOnly = true;
            dgvUnidades.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUnidades.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUnidades.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUnidades.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvUnidades.ThemeStyle.RowsStyle.Height = 25;
            dgvUnidades.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUnidades.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // colUnidad
            // 
            colUnidad.HeaderText = "Unidad";
            colUnidad.Name = "colUnidad";
            colUnidad.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colLecciones
            // 
            colLecciones.HeaderText = "Lecciones";
            colLecciones.Name = "colLecciones";
            colLecciones.ReadOnly = true;
            // 
            // colDuracion
            // 
            colDuracion.HeaderText = "Duración";
            colDuracion.Name = "colDuracion";
            colDuracion.ReadOnly = true;
            // 
            // colCupo
            // 
            colCupo.HeaderText = "Cupo";
            colCupo.Name = "colCupo";
            colCupo.ReadOnly = true;
            // 
            // panelDescripcion
            // 
            panelDescripcion.BackColor = Color.FromArgb(240, 245, 255);
            panelDescripcion.BorderRadius = 8;
            panelDescripcion.Controls.Add(lblDescripcion);
            panelDescripcion.CustomizableEdges = customizableEdges7;
            panelDescripcion.FillColor = Color.FromArgb(240, 245, 255);
            panelDescripcion.Location = new Point(12, 437);
            panelDescripcion.Name = "panelDescripcion";
            panelDescripcion.Padding = new Padding(10);
            panelDescripcion.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelDescripcion.Size = new Size(565, 50);
            panelDescripcion.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = false;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            lblDescripcion.Location = new Point(20, 10);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(520, 30);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Este reporte muestra las unidades temáticas distribuidas en cada nivel de aprendizaje, detallando la cantidad de lecciones, objetivos pedagógicos y avance curricular.";
            // 
            // panelFirma
            // 
            panelFirma.BackColor = Color.White;
            panelFirma.BorderRadius = 8;
            panelFirma.Controls.Add(lblFirma);
            panelFirma.Controls.Add(lblFirmaEmail);
            panelFirma.CustomizableEdges = customizableEdges9;
            panelFirma.Location = new Point(12, 495);
            panelFirma.Name = "panelFirma";
            panelFirma.Padding = new Padding(10);
            panelFirma.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelFirma.Size = new Size(565, 40);
            panelFirma.TabIndex = 16;
            // 
            // lblFirma
            // 
            lblFirma.AutoSize = false;
            lblFirma.BackColor = Color.Transparent;
            lblFirma.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFirma.ForeColor = Color.FromArgb(64, 64, 64);
            lblFirma.Location = new Point(15, 10);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(250, 20);
            lblFirma.TabIndex = 0;
            lblFirma.Text = "Firma del Administrador: Junior Alexis";
            // 
            // lblFirmaEmail
            // 
            lblFirmaEmail.AutoSize = false;
            lblFirmaEmail.BackColor = Color.Transparent;
            lblFirmaEmail.Font = new Font("Segoe UI", 8F);
            lblFirmaEmail.ForeColor = Color.Gray;
            lblFirmaEmail.Location = new Point(350, 10);
            lblFirmaEmail.Name = "lblFirmaEmail";
            lblFirmaEmail.Size = new Size(150, 20);
            lblFirmaEmail.TabIndex = 1;
            lblFirmaEmail.Text = "JuniorAlexis@gmail.com";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(0, 122, 204);
            btnImprimir.Font = new Font("Segoe UI", 10F);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnImprimir.IconColor = Color.Black;
            btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImprimir.Location = new Point(8, 7);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(120, 35);
            btnImprimir.TabIndex = 10;
            btnImprimir.Text = "📄 Imprimir PDF";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblNombreReporte
            // 
            lblNombreReporte.AutoSize = false;
            lblNombreReporte.BackColor = Color.Transparent;
            lblNombreReporte.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNombreReporte.ForeColor = Color.Black;
            lblNombreReporte.Location = new Point(157, 136);
            lblNombreReporte.Name = "lblNombreReporte";
            lblNombreReporte.Size = new Size(300, 25);
            lblNombreReporte.TabIndex = 11;
            lblNombreReporte.Text = "Reporte de Unidades por Nivel";
            // 
            // panelFiltro
            // 
            panelFiltro.BackColor = Color.White;
            panelFiltro.BorderRadius = 8;
            panelFiltro.Controls.Add(dtpFechaDesde);
            panelFiltro.Controls.Add(lblDesde);
            panelFiltro.Controls.Add(dtpFechaHasta);
            panelFiltro.Controls.Add(lblHasta);
            panelFiltro.Controls.Add(btnFiltrar);
            panelFiltro.Controls.Add(btnLimpiar);
            panelFiltro.CustomizableEdges = customizableEdges11;
            panelFiltro.FillColor = Color.White;
            panelFiltro.Location = new Point(12, 233);
            panelFiltro.Name = "panelFiltro";
            panelFiltro.Padding = new Padding(8);
            panelFiltro.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelFiltro.Size = new Size(565, 50);
            panelFiltro.TabIndex = 14;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Font = new Font("Segoe UI", 9F);
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(75, 14);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(110, 23);
            dtpFechaDesde.TabIndex = 0;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = false;
            lblDesde.BackColor = Color.Transparent;
            lblDesde.Font = new Font("Segoe UI", 9F);
            lblDesde.Location = new Point(8, 18);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(38, 17);
            lblDesde.TabIndex = 1;
            lblDesde.Text = "Desde:";
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Font = new Font("Segoe UI", 9F);
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(245, 14);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(110, 23);
            dtpFechaHasta.TabIndex = 2;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = false;
            lblHasta.BackColor = Color.Transparent;
            lblHasta.Font = new Font("Segoe UI", 9F);
            lblHasta.Location = new Point(190, 18);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(36, 17);
            lblHasta.TabIndex = 3;
            lblHasta.Text = "Hasta:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(0, 122, 204);
            btnFiltrar.Font = new Font("Segoe UI", 9F);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(365, 14);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(80, 24);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(200, 200, 200);
            btnLimpiar.Font = new Font("Segoe UI", 9F);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(455, 14);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(80, 24);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmReporteUnidadesPorNivel
            // 
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(589, 467);
            Controls.Add(lblNombreReporte);
            Controls.Add(panelHeader);
            Controls.Add(panelSelector);
            Controls.Add(panelFiltro);
            Controls.Add(dgvUnidades);
            Controls.Add(panelDescripcion);
            Controls.Add(panelFirma);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReporteUnidadesPorNivel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reporte: Unidades por Nivel";
            Load += FrmReporteUnidadesPorNivel_Load;
            panelHeader.ResumeLayout(false);
            panelSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUnidades).EndInit();
            panelDescripcion.ResumeLayout(false);
            panelFirma.ResumeLayout(false);
            panelFiltro.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Guna2HtmlLabel lblDesde;
        private Guna2HtmlLabel lblHasta;
    }
}