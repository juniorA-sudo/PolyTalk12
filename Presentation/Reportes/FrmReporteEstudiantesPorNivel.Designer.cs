using Guna.UI2.WinForms;

namespace Presentation
{
    partial class FrmReporteEstudiantesPorNivel
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

        private Guna2Panel panelSelector;
        private Guna2HtmlLabel lblSeleccionarNivel;
        private Guna2ComboBox cmbNivel;

        private Guna2DataGridView dgvEstudiantes;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colNivel;
        private DataGridViewTextBoxColumn colProgreso;
        private DataGridViewTextBoxColumn colCalificacion;
        private DataGridViewTextBoxColumn colFechaIngreso;
        private DataGridViewTextBoxColumn colGrupo;
        private DataGridViewTextBoxColumn colMaestro;

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
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSub = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDireccion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTelefono = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRNC = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDirigido = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.panelSelector = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSeleccionarNivel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbNivel = new Guna.UI2.WinForms.Guna2ComboBox();

            this.dgvEstudiantes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNombre = new DataGridViewTextBoxColumn();
            this.colNivel = new DataGridViewTextBoxColumn();
            this.colProgreso = new DataGridViewTextBoxColumn();
            this.colCalificacion = new DataGridViewTextBoxColumn();
            this.colFechaIngreso = new DataGridViewTextBoxColumn();
            this.colGrupo = new DataGridViewTextBoxColumn();
            this.colMaestro = new DataGridViewTextBoxColumn();

            this.panelDescripcion = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDescripcion = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.panelFirma = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFirma = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFirmaEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.SuspendLayout();

            // 
            // Formulario principal
            // 
            this.ClientSize = new System.Drawing.Size(589, 467);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.Text = "Reporte: Estudiantes por Nivel";

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderRadius = 10;
            this.panelHeader.Location = new System.Drawing.Point(12, 12);
            this.panelHeader.Size = new System.Drawing.Size(565, 100);
            this.panelHeader.Padding = new System.Windows.Forms.Padding(15);
            this.panelHeader.FillColor = System.Drawing.Color.White;
            this.panelHeader.ShadowDecoration.Enabled = true;
            this.panelHeader.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.panelHeader.ShadowDecoration.Color = System.Drawing.Color.FromArgb(30, 0, 0, 0);

            // Título PolyTalk
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.lblTitulo.Location = new System.Drawing.Point(25, 18);
            this.lblTitulo.Size = new System.Drawing.Size(150, 30);
            this.lblTitulo.Text = "PolyTalk";
            this.panelHeader.Controls.Add(this.lblTitulo);

            // Subtítulo
            this.lblSub.AutoSize = false;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSub.ForeColor = System.Drawing.Color.Gray;
            this.lblSub.Location = new System.Drawing.Point(25, 48);
            this.lblSub.Size = new System.Drawing.Size(200, 20);
            this.lblSub.Text = "Learning Management System";
            this.panelHeader.Controls.Add(this.lblSub);

            // Usuario
            this.lblUsuario.AutoSize = false;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblUsuario.Location = new System.Drawing.Point(230, 18);
            this.lblUsuario.Size = new System.Drawing.Size(150, 20);
            this.lblUsuario.Text = "Junior Alexis";
            this.panelHeader.Controls.Add(this.lblUsuario);

            // Email
            this.lblEmail.AutoSize = false;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(230, 38);
            this.lblEmail.Size = new System.Drawing.Size(150, 16);
            this.lblEmail.Text = "JuniorAlexis@gmail.com";
            this.panelHeader.Controls.Add(this.lblEmail);

            // Dirección
            this.lblDireccion.AutoSize = false;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDireccion.ForeColor = System.Drawing.Color.Gray;
            this.lblDireccion.Location = new System.Drawing.Point(230, 56);
            this.lblDireccion.Size = new System.Drawing.Size(150, 16);
            this.lblDireccion.Text = "AV. Principal #123, RD";
            this.panelHeader.Controls.Add(this.lblDireccion);

            // Teléfono
            this.lblTelefono.AutoSize = false;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTelefono.ForeColor = System.Drawing.Color.Gray;
            this.lblTelefono.Location = new System.Drawing.Point(230, 74);
            this.lblTelefono.Size = new System.Drawing.Size(150, 16);
            this.lblTelefono.Text = "Tel: 829-888-9999";
            this.panelHeader.Controls.Add(this.lblTelefono);

            // Fecha
            this.lblFecha.AutoSize = false;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(400, 25);
            this.lblFecha.Size = new System.Drawing.Size(120, 16);
            this.lblFecha.Text = "24 de Abril, 2024";
            this.panelHeader.Controls.Add(this.lblFecha);

            // RNC
            this.lblRNC.AutoSize = false;
            this.lblRNC.BackColor = System.Drawing.Color.Transparent;
            this.lblRNC.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRNC.ForeColor = System.Drawing.Color.Gray;
            this.lblRNC.Location = new System.Drawing.Point(400, 45);
            this.lblRNC.Size = new System.Drawing.Size(120, 16);
            this.lblRNC.Text = "RNC: 101-543210-9";
            this.panelHeader.Controls.Add(this.lblRNC);

            // Dirigido a
            this.lblDirigido.AutoSize = false;
            this.lblDirigido.BackColor = System.Drawing.Color.Transparent;
            this.lblDirigido.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblDirigido.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.lblDirigido.Location = new System.Drawing.Point(400, 65);
            this.lblDirigido.Size = new System.Drawing.Size(150, 30);
            this.lblDirigido.Text = "Dirigido a: Administradores y supervisión";
            this.panelHeader.Controls.Add(this.lblDirigido);

            // 
            // panelSelector
            // 
            this.panelSelector.BackColor = System.Drawing.Color.White;
            this.panelSelector.BorderRadius = 8;
            this.panelSelector.Location = new System.Drawing.Point(12, 120);
            this.panelSelector.Size = new System.Drawing.Size(565, 50);
            this.panelSelector.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelSelector.FillColor = System.Drawing.Color.White;
            this.panelSelector.ShadowDecoration.Enabled = true;
            this.panelSelector.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 4, 4);

            this.lblSeleccionarNivel.AutoSize = false;
            this.lblSeleccionarNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccionarNivel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSeleccionarNivel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblSeleccionarNivel.Location = new System.Drawing.Point(25, 13);
            this.lblSeleccionarNivel.Size = new System.Drawing.Size(120, 20);
            this.lblSeleccionarNivel.Text = "Seleccionar Nivel:";
            this.panelSelector.Controls.Add(this.lblSeleccionarNivel);

            this.cmbNivel.BackColor = System.Drawing.Color.Transparent;
            this.cmbNivel.BorderRadius = 5;
            this.cmbNivel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.FocusedColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.cmbNivel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbNivel.ForeColor = System.Drawing.Color.FromArgb(68, 88, 112);
            this.cmbNivel.Items.AddRange(new object[] { "Básico (A1-A2)", "Intermedio (B1-B2)", "Avanzado (C1-C2)" });
            this.cmbNivel.Location = new System.Drawing.Point(150, 11);
            this.cmbNivel.Size = new System.Drawing.Size(150, 28);
            this.cmbNivel.TabIndex = 0;
            this.panelSelector.Controls.Add(this.cmbNivel);

            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AllowUserToDeleteRows = false;
            this.dgvEstudiantes.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudiantes.ColumnHeadersHeight = 35;
            this.dgvEstudiantes.Location = new System.Drawing.Point(12, 178);
            this.dgvEstudiantes.Size = new System.Drawing.Size(565, 140);
            this.dgvEstudiantes.TabIndex = 1;
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.RowHeadersVisible = false;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Columnas
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNivel.HeaderText = "Nivel";
            this.colNivel.Name = "colNivel";
            this.colProgreso.HeaderText = "Progreso";
            this.colProgreso.Name = "colProgreso";
            this.colCalificacion.HeaderText = "Calificación";
            this.colCalificacion.Name = "colCalificacion";
            this.colFechaIngreso.HeaderText = "Fecha Ingreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colGrupo.HeaderText = "Grupo";
            this.colGrupo.Name = "colGrupo";
            this.colMaestro.HeaderText = "Maestro";
            this.colMaestro.Name = "colMaestro";

            this.dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] {
                this.colNombre,
                this.colNivel,
                this.colProgreso,
                this.colCalificacion,
                this.colFechaIngreso,
                this.colGrupo,
                this.colMaestro
            });

            // Estilo del DataGridView
            this.dgvEstudiantes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.dgvEstudiantes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstudiantes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvEstudiantes.EnableHeadersVisualStyles = false;

            // 
            // panelDescripcion
            // 
            this.panelDescripcion.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.panelDescripcion.BorderRadius = 8;
            this.panelDescripcion.Location = new System.Drawing.Point(12, 326);
            this.panelDescripcion.Size = new System.Drawing.Size(565, 50);
            this.panelDescripcion.Padding = new System.Windows.Forms.Padding(10);
            this.panelDescripcion.FillColor = System.Drawing.Color.FromArgb(240, 245, 255);

            this.lblDescripcion.AutoSize = false;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblDescripcion.Location = new System.Drawing.Point(20, 10);
            this.lblDescripcion.Size = new System.Drawing.Size(520, 30);
            this.lblDescripcion.Text = "Este reporte muestra la cantidad total de estudiantes clasificados por nivel de dominio del idioma, permitiendo visualizar la distribución académica.";
            this.panelDescripcion.Controls.Add(this.lblDescripcion);

            // 
            // panelFirma
            // 
            this.panelFirma.BackColor = System.Drawing.Color.White;
            this.panelFirma.BorderRadius = 8;
            this.panelFirma.Location = new System.Drawing.Point(12, 384);
            this.panelFirma.Size = new System.Drawing.Size(565, 40);
            this.panelFirma.Padding = new System.Windows.Forms.Padding(10);

            this.lblFirma.AutoSize = false;
            this.lblFirma.BackColor = System.Drawing.Color.Transparent;
            this.lblFirma.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFirma.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblFirma.Location = new System.Drawing.Point(15, 10);
            this.lblFirma.Size = new System.Drawing.Size(250, 20);
            this.lblFirma.Text = "Firma del Administrador: Junior Alexis";
            this.panelFirma.Controls.Add(this.lblFirma);

            this.lblFirmaEmail.AutoSize = false;
            this.lblFirmaEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblFirmaEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFirmaEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblFirmaEmail.Location = new System.Drawing.Point(350, 10);
            this.lblFirmaEmail.Size = new System.Drawing.Size(150, 20);
            this.lblFirmaEmail.Text = "JuniorAlexis@gmail.com";
            this.panelFirma.Controls.Add(this.lblFirmaEmail);

            // Agregar todos los paneles al formulario
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSelector);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.panelDescripcion);
            this.Controls.Add(this.panelFirma);

            this.ResumeLayout(false);
        }
    }
}