using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Administrador
{
    partial class FrmReporteEstudiantes
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

        private Guna2DataGridView dgvEstudiantes;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colNivel;
        private DataGridViewTextBoxColumn colFechaIngreso;
        private DataGridViewTextBoxColumn colGrupo;
        private DataGridViewTextBoxColumn colMaestro;
        private DataGridViewTextBoxColumn colEstado;

        private Guna2Panel panelDescripcion;
        private Guna2HtmlLabel lblDescripcion;

        private Guna2Panel panelFirma;
        private Guna2HtmlLabel lblFirma;
        private Guna2HtmlLabel lblFirmaEmail;

        private FontAwesome.Sharp.IconButton btnImprimir;
        private Guna2HtmlLabel lblNombreReporte;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            dgvEstudiantes = new Guna2DataGridView();
            colUsuario = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colNivel = new DataGridViewTextBoxColumn();
            colFechaIngreso = new DataGridViewTextBoxColumn();
            colGrupo = new DataGridViewTextBoxColumn();
            colMaestro = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            panelDescripcion = new Guna2Panel();
            lblDescripcion = new Guna2HtmlLabel();
            panelFirma = new Guna2Panel();
            lblFirma = new Guna2HtmlLabel();
            lblFirmaEmail = new Guna2HtmlLabel();
            btnImprimir = new FontAwesome.Sharp.IconButton();
            lblNombreReporte = new Guna2HtmlLabel();
            panelFiltro = new Guna2Panel();
            dtpFechaDesde = new DateTimePicker();
            dtpFechaHasta = new DateTimePicker();
            btnFiltrar = new Button();
            btnLimpiar = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
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
            panelHeader.Padding = new Padding(10);
            panelHeader.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelHeader.Size = new Size(565, 65);
            panelHeader.TabIndex = 11;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 82, 180);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PolyTalk";
            // 
            // lblSub
            // 
            lblSub.AutoSize = false;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblSub.ForeColor = Color.Gray;
            lblSub.Location = new Point(20, 40);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(150, 15);
            lblSub.TabIndex = 1;
            lblSub.Text = "Learning Management System";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = false;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsuario.Location = new Point(200, 15);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(120, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Junior Alexis";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = false;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 7F);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(200, 32);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(120, 14);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "JuniorAlexis@gmail.com";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = false;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Segoe UI", 7F);
            lblDireccion.ForeColor = Color.Gray;
            lblDireccion.Location = new Point(200, 48);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(120, 14);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "AV. Principal #123, RD";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = false;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Segoe UI", 7F);
            lblTelefono.ForeColor = Color.Gray;
            lblTelefono.Location = new Point(200, 48);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(120, 14);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Tel: 829-888-9999";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = false;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 7F);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.Location = new Point(350, 20);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(100, 14);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "24 de Abril, 2024";
            // 
            // lblRNC
            // 
            lblRNC.AutoSize = false;
            lblRNC.BackColor = Color.Transparent;
            lblRNC.Font = new Font("Segoe UI", 7F);
            lblRNC.ForeColor = Color.Gray;
            lblRNC.Location = new Point(350, 32);
            lblRNC.Name = "lblRNC";
            lblRNC.Size = new Size(100, 14);
            lblRNC.TabIndex = 7;
            lblRNC.Text = "RNC: 101-543210-9";
            // 
            // lblDirigido
            // 
            lblDirigido.AutoSize = false;
            lblDirigido.BackColor = Color.Transparent;
            lblDirigido.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            lblDirigido.ForeColor = Color.FromArgb(0, 82, 180);
            lblDirigido.Location = new Point(350, 48);
            lblDirigido.Name = "lblDirigido";
            lblDirigido.Size = new Size(140, 25);
            lblDirigido.TabIndex = 8;
            lblDirigido.Text = "Administración y supervisión";
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvEstudiantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 82, 180);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEstudiantes.ColumnHeadersHeight = 30;
            dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] { colUsuario, colEmail, colTelefono, colNivel, colFechaIngreso, colGrupo, colMaestro, colEstado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEstudiantes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEstudiantes.GridColor = Color.FromArgb(231, 229, 255);
            dgvEstudiantes.Location = new Point(12, 193);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowHeadersVisible = false;
            dgvEstudiantes.Size = new Size(565, 191);
            dgvEstudiantes.TabIndex = 1;
            dgvEstudiantes.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvEstudiantes.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvEstudiantes.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvEstudiantes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvEstudiantes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvEstudiantes.ThemeStyle.BackColor = Color.White;
            dgvEstudiantes.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvEstudiantes.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 82, 180);
            dgvEstudiantes.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEstudiantes.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvEstudiantes.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvEstudiantes.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEstudiantes.ThemeStyle.HeaderStyle.Height = 30;
            dgvEstudiantes.ThemeStyle.ReadOnly = true;
            dgvEstudiantes.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvEstudiantes.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEstudiantes.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvEstudiantes.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvEstudiantes.ThemeStyle.RowsStyle.Height = 25;
            dgvEstudiantes.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEstudiantes.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // colUsuario
            // 
            colUsuario.HeaderText = "Usuario";
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // colNivel
            // 
            colNivel.HeaderText = "Nivel";
            colNivel.Name = "colNivel";
            colNivel.ReadOnly = true;
            // 
            // colFechaIngreso
            // 
            colFechaIngreso.HeaderText = "F. Ingreso";
            colFechaIngreso.Name = "colFechaIngreso";
            colFechaIngreso.ReadOnly = true;
            // 
            // colGrupo
            // 
            colGrupo.HeaderText = "Grupo";
            colGrupo.Name = "colGrupo";
            colGrupo.ReadOnly = true;
            // 
            // colMaestro
            // 
            colMaestro.HeaderText = "Maestro";
            colMaestro.Name = "colMaestro";
            colMaestro.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // panelDescripcion
            // 
            panelDescripcion.BackColor = Color.FromArgb(240, 245, 255);
            panelDescripcion.BorderRadius = 8;
            panelDescripcion.Controls.Add(lblDescripcion);
            panelDescripcion.CustomizableEdges = customizableEdges3;
            panelDescripcion.FillColor = Color.FromArgb(240, 245, 255);
            panelDescripcion.Location = new Point(12, 402);
            panelDescripcion.Name = "panelDescripcion";
            panelDescripcion.Padding = new Padding(8);
            panelDescripcion.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelDescripcion.Size = new Size(565, 45);
            panelDescripcion.TabIndex = 12;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = false;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            lblDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            lblDescripcion.Location = new Point(15, 8);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(530, 30);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Listado completo de estudiantes: información personal, nivel, grupo asignado, maestro a cargo y estado en la plataforma.";
            // 
            // panelFirma
            // 
            panelFirma.BackColor = Color.White;
            panelFirma.BorderRadius = 8;
            panelFirma.Controls.Add(lblFirma);
            panelFirma.Controls.Add(lblFirmaEmail);
            panelFirma.CustomizableEdges = customizableEdges5;
            panelFirma.Location = new Point(12, 458);
            panelFirma.Name = "panelFirma";
            panelFirma.Padding = new Padding(8);
            panelFirma.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelFirma.Size = new Size(565, 35);
            panelFirma.TabIndex = 13;
            // 
            // lblFirma
            // 
            lblFirma.AutoSize = false;
            lblFirma.BackColor = Color.Transparent;
            lblFirma.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblFirma.ForeColor = Color.FromArgb(64, 64, 64);
            lblFirma.Location = new Point(12, 8);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(200, 18);
            lblFirma.TabIndex = 0;
            lblFirma.Text = "Firma del Administrador: Junior Alexis";
            // 
            // lblFirmaEmail
            // 
            lblFirmaEmail.AutoSize = false;
            lblFirmaEmail.BackColor = Color.Transparent;
            lblFirmaEmail.Font = new Font("Segoe UI", 7F);
            lblFirmaEmail.ForeColor = Color.Gray;
            lblFirmaEmail.Location = new Point(300, 8);
            lblFirmaEmail.Name = "lblFirmaEmail";
            lblFirmaEmail.Size = new Size(120, 18);
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
            btnImprimir.Location = new Point(15, 8);
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
            lblNombreReporte.Location = new Point(171, 96);
            lblNombreReporte.Name = "lblNombreReporte";
            lblNombreReporte.Size = new Size(213, 30);
            lblNombreReporte.TabIndex = 0;
            lblNombreReporte.Text = "Reporte de Estudiantes";
            // 
            // panelFiltro
            // 
            panelFiltro.BackColor = Color.White;
            panelFiltro.BorderRadius = 8;
            panelFiltro.Controls.Add(dtpFechaDesde);
            panelFiltro.Controls.Add(btnImprimir);
            panelFiltro.Controls.Add(dtpFechaHasta);
            panelFiltro.Controls.Add(btnFiltrar);
            panelFiltro.Controls.Add(btnLimpiar);
            panelFiltro.CustomizableEdges = customizableEdges7;
            panelFiltro.FillColor = Color.White;
            panelFiltro.Location = new Point(12, 132);
            panelFiltro.Name = "panelFiltro";
            panelFiltro.Padding = new Padding(10);
            panelFiltro.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelFiltro.Size = new Size(565, 55);
            panelFiltro.TabIndex = 14;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Font = new Font("Segoe UI", 9F);
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(142, 13);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(110, 23);
            dtpFechaDesde.TabIndex = 0;
            dtpFechaDesde.Value = new DateTime(2026, 3, 23, 0, 0, 0, 0);
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Font = new Font("Segoe UI", 9F);
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(262, 13);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(110, 23);
            dtpFechaHasta.TabIndex = 1;
            dtpFechaHasta.Value = new DateTime(2026, 3, 23, 0, 0, 0, 0);
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(0, 122, 204);
            btnFiltrar.Font = new Font("Segoe UI", 9F);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(382, 13);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(80, 23);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(0, 122, 204);
            btnLimpiar.Font = new Font("Segoe UI", 9F);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(472, 13);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(80, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmReporteEstudiantes
            // 
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(589, 467);
            Controls.Add(lblNombreReporte);
            Controls.Add(panelHeader);
            Controls.Add(panelFiltro);
            Controls.Add(dgvEstudiantes);
            Controls.Add(panelDescripcion);
            Controls.Add(panelFirma);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReporteEstudiantes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reporte: Estudiantes";
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            panelDescripcion.ResumeLayout(false);
            panelFirma.ResumeLayout(false);
            panelFiltro.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}