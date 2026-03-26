using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Administrador
{
    partial class FrmReporteProgresoGrupo
    {
        private System.ComponentModel.IContainer components = null;

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
        private Guna2HtmlLabel lblNombreReporte;
        private Guna2Panel panelSelector;
        private Guna2HtmlLabel lblSeleccionarGrupo;
        private Guna2ComboBox cmbGrupo;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private Guna2DataGridView dgvProgreso;
        private DataGridViewTextBoxColumn colEstudiante;
        private DataGridViewTextBoxColumn colLecciones;
        private DataGridViewTextBoxColumn colVocabulario;
        private DataGridViewTextBoxColumn colCalificacion;
        private DataGridViewTextBoxColumn colTareas;
        private DataGridViewTextBoxColumn colEstado;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            lblNombreReporte = new Guna2HtmlLabel();
            panelSelector = new Guna2Panel();
            lblSeleccionarGrupo = new Guna2HtmlLabel();
            cmbGrupo = new Guna2ComboBox();
            btnImprimir = new FontAwesome.Sharp.IconButton();
            dgvProgreso = new Guna2DataGridView();
            colEstudiante = new DataGridViewTextBoxColumn();
            colLecciones = new DataGridViewTextBoxColumn();
            colVocabulario = new DataGridViewTextBoxColumn();
            colCalificacion = new DataGridViewTextBoxColumn();
            colTareas = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            panelDescripcion = new Guna2Panel();
            lblDescripcion = new Guna2HtmlLabel();
            panelFirma = new Guna2Panel();
            lblFirma = new Guna2HtmlLabel();
            lblFirmaEmail = new Guna2HtmlLabel();

            panelHeader.SuspendLayout();
            panelSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProgreso).BeginInit();
            panelDescripcion.SuspendLayout();
            panelFirma.SuspendLayout();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = System.Drawing.Color.Transparent;
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
            panelHeader.FillColor = System.Drawing.Color.White;
            panelHeader.Location = new System.Drawing.Point(12, 12);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new System.Windows.Forms.Padding(15);
            panelHeader.ShadowDecoration.Color = System.Drawing.Color.FromArgb(30, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            panelHeader.Size = new System.Drawing.Size(565, 100);
            panelHeader.TabIndex = 0;

            // lblTitulo
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = System.Drawing.Color.Transparent;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            lblTitulo.Location = new System.Drawing.Point(25, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(150, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PolyTalk";

            // lblSub
            lblSub.AutoSize = false;
            lblSub.BackColor = System.Drawing.Color.Transparent;
            lblSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblSub.ForeColor = System.Drawing.Color.Gray;
            lblSub.Location = new System.Drawing.Point(25, 48);
            lblSub.Name = "lblSub";
            lblSub.Size = new System.Drawing.Size(200, 20);
            lblSub.TabIndex = 1;
            lblSub.Text = "Learning Management System";

            // lblUsuario
            lblUsuario.AutoSize = false;
            lblUsuario.BackColor = System.Drawing.Color.Transparent;
            lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblUsuario.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblUsuario.Location = new System.Drawing.Point(230, 18);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(150, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Junior Alexis";

            // lblEmail
            lblEmail.AutoSize = false;
            lblEmail.BackColor = System.Drawing.Color.Transparent;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblEmail.ForeColor = System.Drawing.Color.Gray;
            lblEmail.Location = new System.Drawing.Point(230, 38);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(150, 16);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "JuniorAlexis@gmail.com";

            // lblDireccion
            lblDireccion.AutoSize = false;
            lblDireccion.BackColor = System.Drawing.Color.Transparent;
            lblDireccion.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblDireccion.ForeColor = System.Drawing.Color.Gray;
            lblDireccion.Location = new System.Drawing.Point(230, 56);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new System.Drawing.Size(150, 16);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "AV. Principal #123, RD";

            // lblTelefono
            lblTelefono.AutoSize = false;
            lblTelefono.BackColor = System.Drawing.Color.Transparent;
            lblTelefono.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblTelefono.ForeColor = System.Drawing.Color.Gray;
            lblTelefono.Location = new System.Drawing.Point(230, 74);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(150, 16);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Tel: 829-888-9999";

            // lblFecha
            lblFecha.AutoSize = false;
            lblFecha.BackColor = System.Drawing.Color.Transparent;
            lblFecha.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblFecha.ForeColor = System.Drawing.Color.Gray;
            lblFecha.Location = new System.Drawing.Point(400, 25);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(120, 16);
            lblFecha.TabIndex = 6;
            lblFecha.Text = System.DateTime.Now.ToString("dd 'de' MMMM, yyyy");

            // lblRNC
            lblRNC.AutoSize = false;
            lblRNC.BackColor = System.Drawing.Color.Transparent;
            lblRNC.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblRNC.ForeColor = System.Drawing.Color.Gray;
            lblRNC.Location = new System.Drawing.Point(400, 45);
            lblRNC.Name = "lblRNC";
            lblRNC.Size = new System.Drawing.Size(120, 16);
            lblRNC.TabIndex = 7;
            lblRNC.Text = "RNC: 101-543210-9";

            // lblDirigido
            lblDirigido.AutoSize = false;
            lblDirigido.BackColor = System.Drawing.Color.Transparent;
            lblDirigido.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            lblDirigido.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            lblDirigido.Location = new System.Drawing.Point(400, 65);
            lblDirigido.Name = "lblDirigido";
            lblDirigido.Size = new System.Drawing.Size(150, 30);
            lblDirigido.TabIndex = 8;
            lblDirigido.Text = "Análisis de progreso y desempeño académico";

            // lblNombreReporte
            lblNombreReporte.AutoSize = false;
            lblNombreReporte.BackColor = System.Drawing.Color.Transparent;
            lblNombreReporte.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblNombreReporte.ForeColor = System.Drawing.Color.Black;
            lblNombreReporte.Location = new System.Drawing.Point(144, 119);
            lblNombreReporte.Name = "lblNombreReporte";
            lblNombreReporte.Size = new System.Drawing.Size(300, 25);
            lblNombreReporte.TabIndex = 9;
            lblNombreReporte.Text = "📊 Progreso del Grupo";

            // panelSelector
            panelSelector.BackColor = System.Drawing.Color.Transparent;
            panelSelector.BorderRadius = 8;
            panelSelector.Controls.Add(btnImprimir);
            panelSelector.Controls.Add(lblSeleccionarGrupo);
            panelSelector.Controls.Add(cmbGrupo);
            panelSelector.CustomizableEdges = customizableEdges3;
            panelSelector.FillColor = System.Drawing.Color.White;
            panelSelector.Location = new System.Drawing.Point(12, 152);
            panelSelector.Name = "panelSelector";
            panelSelector.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            panelSelector.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelSelector.ShadowDecoration.Enabled = true;
            panelSelector.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 4, 4);
            panelSelector.Size = new System.Drawing.Size(565, 50);
            panelSelector.TabIndex = 1;

            // lblSeleccionarGrupo
            lblSeleccionarGrupo.AutoSize = false;
            lblSeleccionarGrupo.BackColor = System.Drawing.Color.Transparent;
            lblSeleccionarGrupo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblSeleccionarGrupo.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblSeleccionarGrupo.Location = new System.Drawing.Point(282, 17);
            lblSeleccionarGrupo.Name = "lblSeleccionarGrupo";
            lblSeleccionarGrupo.Size = new System.Drawing.Size(120, 20);
            lblSeleccionarGrupo.TabIndex = 0;
            lblSeleccionarGrupo.Text = "Seleccionar Grupo:";

            // cmbGrupo
            cmbGrupo.BackColor = System.Drawing.Color.Transparent;
            cmbGrupo.BorderRadius = 5;
            cmbGrupo.CustomizableEdges = customizableEdges5;
            cmbGrupo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbGrupo.FocusedColor = System.Drawing.Color.FromArgb(0, 82, 180);
            cmbGrupo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(0, 82, 180);
            cmbGrupo.Font = new System.Drawing.Font("Segoe UI", 9F);
            cmbGrupo.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            cmbGrupo.ItemHeight = 30;
            cmbGrupo.Location = new System.Drawing.Point(408, 8);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cmbGrupo.Size = new System.Drawing.Size(150, 36);
            cmbGrupo.TabIndex = 1;
            cmbGrupo.SelectedIndexChanged += CmbGrupo_SelectedIndexChanged;

            // btnImprimir
            btnImprimir.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            btnImprimir.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnImprimir.ForeColor = System.Drawing.Color.White;
            btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnImprimir.IconColor = System.Drawing.Color.Black;
            btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImprimir.Location = new System.Drawing.Point(8, 8);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(120, 35);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "📄 Imprimir PDF";
            btnImprimir.UseVisualStyleBackColor = false;

            // dgvProgreso
            dgvProgreso.AllowUserToAddRows = false;
            dgvProgreso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dgvProgreso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(0, 82, 180);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvProgreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProgreso.ColumnHeadersHeight = 35;
            dgvProgreso.Columns.AddRange(new DataGridViewColumn[] { colEstudiante, colLecciones, colVocabulario, colCalificacion, colTareas, colEstado });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvProgreso.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProgreso.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dgvProgreso.Location = new System.Drawing.Point(12, 210);
            dgvProgreso.Name = "dgvProgreso";
            dgvProgreso.ReadOnly = true;
            dgvProgreso.RowHeadersVisible = false;
            dgvProgreso.Size = new System.Drawing.Size(565, 200);
            dgvProgreso.TabIndex = 2;
            dgvProgreso.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            dgvProgreso.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvProgreso.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            dgvProgreso.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            dgvProgreso.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            dgvProgreso.ThemeStyle.BackColor = System.Drawing.Color.White;
            dgvProgreso.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dgvProgreso.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(0, 82, 180);
            dgvProgreso.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvProgreso.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvProgreso.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            dgvProgreso.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProgreso.ThemeStyle.HeaderStyle.Height = 35;
            dgvProgreso.ThemeStyle.ReadOnly = true;
            dgvProgreso.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            dgvProgreso.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProgreso.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvProgreso.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dgvProgreso.ThemeStyle.RowsStyle.Height = 25;
            dgvProgreso.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dgvProgreso.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);

            // colEstudiante
            colEstudiante.HeaderText = "👤 Estudiante";
            colEstudiante.Name = "colEstudiante";
            colEstudiante.ReadOnly = true;

            // colLecciones
            colLecciones.HeaderText = "📚 Lecciones %";
            colLecciones.Name = "colLecciones";
            colLecciones.ReadOnly = true;

            // colVocabulario
            colVocabulario.HeaderText = "📖 Vocabulario %";
            colVocabulario.Name = "colVocabulario";
            colVocabulario.ReadOnly = true;

            // colCalificacion
            colCalificacion.HeaderText = "⭐ Calificación";
            colCalificacion.Name = "colCalificacion";
            colCalificacion.ReadOnly = true;

            // colTareas
            colTareas.HeaderText = "✅ Tareas";
            colTareas.Name = "colTareas";
            colTareas.ReadOnly = true;

            // colEstado
            colEstado.HeaderText = "🎯 Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;

            // panelDescripcion
            panelDescripcion.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            panelDescripcion.BorderRadius = 8;
            panelDescripcion.Controls.Add(lblDescripcion);
            panelDescripcion.CustomizableEdges = customizableEdges7;
            panelDescripcion.FillColor = System.Drawing.Color.FromArgb(240, 245, 255);
            panelDescripcion.Location = new System.Drawing.Point(12, 418);
            panelDescripcion.Name = "panelDescripcion";
            panelDescripcion.Padding = new System.Windows.Forms.Padding(10);
            panelDescripcion.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelDescripcion.Size = new System.Drawing.Size(565, 50);
            panelDescripcion.TabIndex = 3;

            // lblDescripcion
            lblDescripcion.AutoSize = false;
            lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblDescripcion.Location = new System.Drawing.Point(20, 10);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(520, 30);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Reporte que muestra el progreso académico de los estudiantes en lecciones, vocabulario y calificaciones promedio.";

            // panelFirma
            panelFirma.BackColor = System.Drawing.Color.White;
            panelFirma.BorderRadius = 8;
            panelFirma.Controls.Add(lblFirma);
            panelFirma.Controls.Add(lblFirmaEmail);
            panelFirma.CustomizableEdges = customizableEdges9;
            panelFirma.Location = new System.Drawing.Point(12, 476);
            panelFirma.Name = "panelFirma";
            panelFirma.Padding = new System.Windows.Forms.Padding(10);
            panelFirma.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelFirma.Size = new System.Drawing.Size(565, 40);
            panelFirma.TabIndex = 4;

            // lblFirma
            lblFirma.AutoSize = false;
            lblFirma.BackColor = System.Drawing.Color.Transparent;
            lblFirma.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblFirma.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblFirma.Location = new System.Drawing.Point(15, 10);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new System.Drawing.Size(250, 20);
            lblFirma.TabIndex = 0;
            lblFirma.Text = "Firma del Administrador: Junior Alexis";

            // lblFirmaEmail
            lblFirmaEmail.AutoSize = false;
            lblFirmaEmail.BackColor = System.Drawing.Color.Transparent;
            lblFirmaEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblFirmaEmail.ForeColor = System.Drawing.Color.Gray;
            lblFirmaEmail.Location = new System.Drawing.Point(350, 10);
            lblFirmaEmail.Name = "lblFirmaEmail";
            lblFirmaEmail.Size = new System.Drawing.Size(150, 20);
            lblFirmaEmail.TabIndex = 1;
            lblFirmaEmail.Text = "JuniorAlexis@gmail.com";

            // FrmReporteProgresoGrupo
            AutoScroll = true;
            BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            ClientSize = new System.Drawing.Size(589, 528);
            Controls.Add(lblNombreReporte);
            Controls.Add(panelHeader);
            Controls.Add(panelSelector);
            Controls.Add(dgvProgreso);
            Controls.Add(panelDescripcion);
            Controls.Add(panelFirma);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmReporteProgresoGrupo";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Reporte: Progreso del Grupo";

            panelHeader.ResumeLayout(false);
            panelSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProgreso).EndInit();
            panelDescripcion.ResumeLayout(false);
            panelFirma.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
