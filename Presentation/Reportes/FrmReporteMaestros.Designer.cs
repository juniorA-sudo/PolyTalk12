using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Administrador
{
    partial class FrmReporteMaestros
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

        private Guna2DataGridView dgvMaestros;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colNivel;
        private DataGridViewTextBoxColumn colFechaIngreso;
        private DataGridViewTextBoxColumn colGrupos;
        private DataGridViewTextBoxColumn colEstudiantes;
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

            this.dgvMaestros = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colUsuario = new DataGridViewTextBoxColumn();
            this.colEmail = new DataGridViewTextBoxColumn();
            this.colTelefono = new DataGridViewTextBoxColumn();
            this.colNivel = new DataGridViewTextBoxColumn();
            this.colFechaIngreso = new DataGridViewTextBoxColumn();
            this.colGrupos = new DataGridViewTextBoxColumn();
            this.colEstudiantes = new DataGridViewTextBoxColumn();
            this.colEstado = new DataGridViewTextBoxColumn();

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
            this.Text = "Reporte: Maestros";

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderRadius = 10;
            this.panelHeader.Location = new System.Drawing.Point(12, 12);
            this.panelHeader.Size = new System.Drawing.Size(565, 90);
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10);
            this.panelHeader.FillColor = System.Drawing.Color.White;
            this.panelHeader.ShadowDecoration.Enabled = true;
            this.panelHeader.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.panelHeader.ShadowDecoration.Color = System.Drawing.Color.FromArgb(30, 0, 0, 0);

            // Título PolyTalk
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Size = new System.Drawing.Size(120, 25);
            this.lblTitulo.Text = "PolyTalk";
            this.panelHeader.Controls.Add(this.lblTitulo);

            // Subtítulo
            this.lblSub.AutoSize = false;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblSub.ForeColor = System.Drawing.Color.Gray;
            this.lblSub.Location = new System.Drawing.Point(20, 40);
            this.lblSub.Size = new System.Drawing.Size(150, 15);
            this.lblSub.Text = "Learning Management System";
            this.panelHeader.Controls.Add(this.lblSub);

            // Usuario
            this.lblUsuario.AutoSize = false;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblUsuario.Location = new System.Drawing.Point(200, 15);
            this.lblUsuario.Size = new System.Drawing.Size(120, 15);
            this.lblUsuario.Text = "Junior Alexis";
            this.panelHeader.Controls.Add(this.lblUsuario);

            // Email
            this.lblEmail.AutoSize = false;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(200, 32);
            this.lblEmail.Size = new System.Drawing.Size(120, 14);
            this.lblEmail.Text = "JuniorAlexis@gmail.com";
            this.panelHeader.Controls.Add(this.lblEmail);

            // Dirección
            this.lblDireccion.AutoSize = false;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblDireccion.ForeColor = System.Drawing.Color.Gray;
            this.lblDireccion.Location = new System.Drawing.Point(200, 48);
            this.lblDireccion.Size = new System.Drawing.Size(120, 14);
            this.lblDireccion.Text = "AV. Principal #123, RD";
            this.panelHeader.Controls.Add(this.lblDireccion);

            // Teléfono
            this.lblTelefono.AutoSize = false;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblTelefono.ForeColor = System.Drawing.Color.Gray;
            this.lblTelefono.Location = new System.Drawing.Point(200, 64);
            this.lblTelefono.Size = new System.Drawing.Size(120, 14);
            this.lblTelefono.Text = "Tel: 829-888-9999";
            this.panelHeader.Controls.Add(this.lblTelefono);

            // Fecha
            this.lblFecha.AutoSize = false;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(350, 20);
            this.lblFecha.Size = new System.Drawing.Size(100, 14);
            this.lblFecha.Text = "24 de Abril, 2024";
            this.panelHeader.Controls.Add(this.lblFecha);

            // RNC
            this.lblRNC.AutoSize = false;
            this.lblRNC.BackColor = System.Drawing.Color.Transparent;
            this.lblRNC.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblRNC.ForeColor = System.Drawing.Color.Gray;
            this.lblRNC.Location = new System.Drawing.Point(350, 38);
            this.lblRNC.Size = new System.Drawing.Size(100, 14);
            this.lblRNC.Text = "RNC: 101-543210-9";
            this.panelHeader.Controls.Add(this.lblRNC);

            // Dirigido a
            this.lblDirigido.AutoSize = false;
            this.lblDirigido.BackColor = System.Drawing.Color.Transparent;
            this.lblDirigido.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic);
            this.lblDirigido.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.lblDirigido.Location = new System.Drawing.Point(350, 56);
            this.lblDirigido.Size = new System.Drawing.Size(140, 25);
            this.lblDirigido.Text = "Administración y supervisión";
            this.panelHeader.Controls.Add(this.lblDirigido);

            // 
            // dgvMaestros - OCUPA MÁS ESPACIO SIN EL FILTRO
            // 
            this.dgvMaestros.AllowUserToAddRows = false;
            this.dgvMaestros.AllowUserToDeleteRows = false;
            this.dgvMaestros.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaestros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaestros.ColumnHeadersHeight = 30;
            this.dgvMaestros.Location = new System.Drawing.Point(12, 115); // Subió porque no hay filtro
            this.dgvMaestros.Size = new System.Drawing.Size(565, 230); // Más grande
            this.dgvMaestros.TabIndex = 1;
            this.dgvMaestros.ReadOnly = true;
            this.dgvMaestros.RowHeadersVisible = false;
            this.dgvMaestros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Columnas
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Width = 80;

            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 100;

            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Width = 70;

            this.colNivel.HeaderText = "Nivel";
            this.colNivel.Name = "colNivel";
            this.colNivel.Width = 40;

            this.colFechaIngreso.HeaderText = "F. Ingreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.Width = 65;

            this.colGrupos.HeaderText = "Grp";
            this.colGrupos.Name = "colGrupos";
            this.colGrupos.Width = 35;

            this.colEstudiantes.HeaderText = "Est";
            this.colEstudiantes.Name = "colEstudiantes";
            this.colEstudiantes.Width = 35;

            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 50;

            this.dgvMaestros.Columns.AddRange(new DataGridViewColumn[] {
                this.colUsuario,
                this.colEmail,
                this.colTelefono,
                this.colNivel,
                this.colFechaIngreso,
                this.colGrupos,
                this.colEstudiantes,
                this.colEstado
            });

            // Estilo del DataGridView
            this.dgvMaestros.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.dgvMaestros.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMaestros.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dgvMaestros.EnableHeadersVisualStyles = false;

            // 
            // panelDescripcion
            // 
            this.panelDescripcion.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.panelDescripcion.BorderRadius = 8;
            this.panelDescripcion.Location = new System.Drawing.Point(12, 353);
            this.panelDescripcion.Size = new System.Drawing.Size(565, 45);
            this.panelDescripcion.Padding = new System.Windows.Forms.Padding(8);
            this.panelDescripcion.FillColor = System.Drawing.Color.FromArgb(240, 245, 255);

            this.lblDescripcion.AutoSize = false;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblDescripcion.Location = new System.Drawing.Point(15, 8);
            this.lblDescripcion.Size = new System.Drawing.Size(530, 30);
            this.lblDescripcion.Text = "Listado completo de maestros: información de contacto, nivel, grupos, estudiantes y estado.";
            this.panelDescripcion.Controls.Add(this.lblDescripcion);

            // 
            // panelFirma
            // 
            this.panelFirma.BackColor = System.Drawing.Color.White;
            this.panelFirma.BorderRadius = 8;
            this.panelFirma.Location = new System.Drawing.Point(12, 406);
            this.panelFirma.Size = new System.Drawing.Size(565, 35);
            this.panelFirma.Padding = new System.Windows.Forms.Padding(8);

            this.lblFirma.AutoSize = false;
            this.lblFirma.BackColor = System.Drawing.Color.Transparent;
            this.lblFirma.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblFirma.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblFirma.Location = new System.Drawing.Point(12, 8);
            this.lblFirma.Size = new System.Drawing.Size(200, 18);
            this.lblFirma.Text = "Firma del Administrador: Junior Alexis";
            this.panelFirma.Controls.Add(this.lblFirma);

            this.lblFirmaEmail.AutoSize = false;
            this.lblFirmaEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblFirmaEmail.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblFirmaEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblFirmaEmail.Location = new System.Drawing.Point(300, 8);
            this.lblFirmaEmail.Size = new System.Drawing.Size(120, 18);
            this.lblFirmaEmail.Text = "JuniorAlexis@gmail.com";
            this.panelFirma.Controls.Add(this.lblFirmaEmail);

            // Agregar todos los paneles al formulario
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvMaestros);
            this.Controls.Add(this.panelDescripcion);
            this.Controls.Add(this.panelFirma);

            this.ResumeLayout(false);
        }
    }
}