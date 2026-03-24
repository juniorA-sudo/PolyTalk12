using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Administrador
{
    partial class FrmReporteEstudiantesPorGrupo
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
        private Guna2HtmlLabel lblSeleccionarGrupo;
        private Guna2ComboBox cmbGrupo;

        private Guna2DataGridView dgvEstudiantes;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colNivel;
        private DataGridViewTextBoxColumn colProgreso;
        private DataGridViewTextBoxColumn colAsistencia;
        private DataGridViewTextBoxColumn colCalificacion;
        private DataGridViewTextBoxColumn colFechaIngreso;

        private Guna2Panel panelDescripcion;
        private Guna2HtmlLabel lblDescripcion;

        private Guna2Panel panelFirma;
        private Guna2HtmlLabel lblFirma;
        private Guna2HtmlLabel lblFirmaEmail;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteEstudiantesPorGrupo));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            btnImprimir = new FontAwesome.Sharp.IconButton();
            lblSeleccionarGrupo = new Guna2HtmlLabel();
            lblNombreReporte = new Guna2HtmlLabel();
            cmbGrupo = new Guna2ComboBox();
            dgvEstudiantes = new Guna2DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colNivel = new DataGridViewTextBoxColumn();
            colProgreso = new DataGridViewTextBoxColumn();
            colAsistencia = new DataGridViewTextBoxColumn();
            colCalificacion = new DataGridViewTextBoxColumn();
            colFechaIngreso = new DataGridViewTextBoxColumn();
            panelDescripcion = new Guna2Panel();
            lblDescripcion = new Guna2HtmlLabel();
            panelFirma = new Guna2Panel();
            lblFirma = new Guna2HtmlLabel();
            lblFirmaEmail = new Guna2HtmlLabel();
            panelHeader.SuspendLayout();
            panelSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            panelDescripcion.SuspendLayout();
            panelFirma.SuspendLayout();
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
            lblDirigido.Text = "Dirigido a: Administradores y supervisión académica";
            // 
            // panelSelector
            // 
            panelSelector.BackColor = Color.Transparent;
            panelSelector.BorderRadius = 8;
            panelSelector.Controls.Add(btnImprimir);
            panelSelector.Controls.Add(lblSeleccionarGrupo);
            panelSelector.Controls.Add(cmbGrupo);
            panelSelector.CustomizableEdges = customizableEdges5;
            panelSelector.FillColor = Color.White;
            panelSelector.Location = new Point(12, 173);
            panelSelector.Name = "panelSelector";
            panelSelector.Padding = new Padding(15, 10, 15, 10);
            panelSelector.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelSelector.ShadowDecoration.Enabled = true;
            panelSelector.ShadowDecoration.Shadow = new Padding(0, 0, 4, 4);
            panelSelector.Size = new Size(565, 60);
            panelSelector.TabIndex = 13;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(0, 122, 204);
            btnImprimir.Font = new Font("Segoe UI", 10F);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnImprimir.IconColor = Color.Black;
            btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImprimir.Location = new Point(15, 11);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(120, 35);
            btnImprimir.TabIndex = 10;
            btnImprimir.Text = "📄 Imprimir PDF";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblSeleccionarGrupo
            // 
            lblSeleccionarGrupo.AutoSize = false;
            lblSeleccionarGrupo.BackColor = Color.Transparent;
            lblSeleccionarGrupo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSeleccionarGrupo.ForeColor = Color.FromArgb(64, 64, 64);
            lblSeleccionarGrupo.Location = new Point(342, 20);
            lblSeleccionarGrupo.Name = "lblSeleccionarGrupo";
            lblSeleccionarGrupo.Size = new Size(120, 20);
            lblSeleccionarGrupo.TabIndex = 0;
            lblSeleccionarGrupo.Text = "Seleccionar Grupo:";
            // 
            // lblNombreReporte
            // 
            lblNombreReporte.AutoSize = false;
            lblNombreReporte.BackColor = Color.Transparent;
            lblNombreReporte.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNombreReporte.ForeColor = Color.Black;
            lblNombreReporte.Location = new Point(185, 131);
            lblNombreReporte.Name = "lblNombreReporte";
            lblNombreReporte.Size = new Size(207, 25);
            lblNombreReporte.TabIndex = 11;
            lblNombreReporte.Text = "Estudiantes por grupo";
            // 
            // cmbGrupo
            // 
            cmbGrupo.BackColor = Color.Transparent;
            cmbGrupo.BorderRadius = 5;
            cmbGrupo.CustomizableEdges = customizableEdges3;
            cmbGrupo.DrawMode = DrawMode.OwnerDrawFixed;
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupo.FocusedColor = Color.FromArgb(0, 82, 180);
            cmbGrupo.FocusedState.BorderColor = Color.FromArgb(0, 82, 180);
            cmbGrupo.Font = new Font("Segoe UI", 9F);
            cmbGrupo.ForeColor = Color.FromArgb(68, 88, 112);
            cmbGrupo.ItemHeight = 30;
            cmbGrupo.Items.AddRange(new object[] { "Grupo A1-01", "Grupo A2-02", "Grupo B1-01", "Grupo B2-02", "Grupo C1-01" });
            cmbGrupo.Location = new Point(468, 11);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbGrupo.Size = new Size(79, 36);
            cmbGrupo.TabIndex = 0;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvEstudiantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 82, 180);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEstudiantes.ColumnHeadersHeight = 35;
            dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] { colNombre, colNivel, colProgreso, colAsistencia, colCalificacion, colFechaIngreso });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEstudiantes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEstudiantes.GridColor = Color.FromArgb(231, 229, 255);
            dgvEstudiantes.Location = new Point(12, 239);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowHeadersVisible = false;
            dgvEstudiantes.Size = new Size(565, 167);
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
            dgvEstudiantes.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvEstudiantes.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvEstudiantes.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEstudiantes.ThemeStyle.HeaderStyle.Height = 35;
            dgvEstudiantes.ThemeStyle.ReadOnly = true;
            dgvEstudiantes.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvEstudiantes.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEstudiantes.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvEstudiantes.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvEstudiantes.ThemeStyle.RowsStyle.Height = 25;
            dgvEstudiantes.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEstudiantes.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colNivel
            // 
            colNivel.HeaderText = "Nivel";
            colNivel.Name = "colNivel";
            colNivel.ReadOnly = true;
            // 
            // colProgreso
            // 
            colProgreso.HeaderText = "Progreso";
            colProgreso.Name = "colProgreso";
            colProgreso.ReadOnly = true;
            // 
            // colAsistencia
            // 
            colAsistencia.HeaderText = "Asistencia";
            colAsistencia.Name = "colAsistencia";
            colAsistencia.ReadOnly = true;
            // 
            // colCalificacion
            // 
            colCalificacion.HeaderText = "Calificación";
            colCalificacion.Name = "colCalificacion";
            colCalificacion.ReadOnly = true;
            // 
            // colFechaIngreso
            // 
            colFechaIngreso.HeaderText = "Fecha Ingreso";
            colFechaIngreso.Name = "colFechaIngreso";
            colFechaIngreso.ReadOnly = true;
            // 
            // panelDescripcion
            // 
            panelDescripcion.BackColor = Color.FromArgb(240, 245, 255);
            panelDescripcion.BorderRadius = 8;
            panelDescripcion.Controls.Add(lblDescripcion);
            panelDescripcion.CustomizableEdges = customizableEdges7;
            panelDescripcion.FillColor = Color.FromArgb(240, 245, 255);
            panelDescripcion.Location = new Point(12, 412);
            panelDescripcion.Name = "panelDescripcion";
            panelDescripcion.Padding = new Padding(10);
            panelDescripcion.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelDescripcion.Size = new Size(565, 50);
            panelDescripcion.TabIndex = 14;
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
            lblDescripcion.Text = resources.GetString("lblDescripcion.Text");
            // 
            // panelFirma
            // 
            panelFirma.BackColor = Color.White;
            panelFirma.BorderRadius = 8;
            panelFirma.Controls.Add(lblFirma);
            panelFirma.Controls.Add(lblFirmaEmail);
            panelFirma.CustomizableEdges = customizableEdges9;
            panelFirma.Location = new Point(12, 468);
            panelFirma.Name = "panelFirma";
            panelFirma.Padding = new Padding(10);
            panelFirma.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelFirma.Size = new Size(565, 40);
            panelFirma.TabIndex = 15;
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
            // FrmReporteEstudiantesPorGrupo
            // 
            AutoScroll = true;
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(589, 467);
            Controls.Add(panelHeader);
            Controls.Add(panelSelector);
            Controls.Add(lblNombreReporte);
            Controls.Add(dgvEstudiantes);
            Controls.Add(panelDescripcion);
            Controls.Add(panelFirma);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReporteEstudiantesPorGrupo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reporte: Estudiantes por Grupo";
            panelHeader.ResumeLayout(false);
            panelSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            panelDescripcion.ResumeLayout(false);
            panelFirma.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}