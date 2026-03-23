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

            this.dgvUnidades = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colUnidad = new DataGridViewTextBoxColumn();
            this.colDescripcion = new DataGridViewTextBoxColumn();
            this.colLecciones = new DataGridViewTextBoxColumn();
            this.colDuracion = new DataGridViewTextBoxColumn();
            this.colCupo = new DataGridViewTextBoxColumn();

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
            this.Text = "Reporte: Unidades por Nivel";

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
            this.lblDirigido.Text = "Dirigido a: Supervisión, docentes y admins";
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
            this.cmbNivel.Items.AddRange(new object[] { "A1 - Principiante", "A2 - Básico", "B1 - Intermedio", "B2 - Intermedio alto", "C1 - Avanzado", "C2 - Maestría" });
            this.cmbNivel.Location = new System.Drawing.Point(150, 11);
            this.cmbNivel.Size = new System.Drawing.Size(150, 28);
            this.cmbNivel.TabIndex = 0;
            this.panelSelector.Controls.Add(this.cmbNivel);

            // 
            // dgvUnidades
            // 
            this.dgvUnidades.AllowUserToAddRows = false;
            this.dgvUnidades.AllowUserToDeleteRows = false;
            this.dgvUnidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnidades.ColumnHeadersHeight = 35;
            this.dgvUnidades.Location = new System.Drawing.Point(12, 178);
            this.dgvUnidades.Size = new System.Drawing.Size(565, 140);
            this.dgvUnidades.TabIndex = 1;
            this.dgvUnidades.ReadOnly = true;
            this.dgvUnidades.RowHeadersVisible = false;
            this.dgvUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Columnas
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Width = 100;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Width = 180;
            this.colLecciones.HeaderText = "Lecciones";
            this.colLecciones.Name = "colLecciones";
            this.colLecciones.Width = 70;
            this.colDuracion.HeaderText = "Duración";
            this.colDuracion.Name = "colDuracion";
            this.colDuracion.Width = 70;
            this.colCupo.HeaderText = "Cupo";
            this.colCupo.Name = "colCupo";
            this.colCupo.Width = 50;

            this.dgvUnidades.Columns.AddRange(new DataGridViewColumn[] {
                this.colUnidad,
                this.colDescripcion,
                this.colLecciones,
                this.colDuracion,
                this.colCupo
            });

            // Estilo del DataGridView
            this.dgvUnidades.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.dgvUnidades.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUnidades.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvUnidades.EnableHeadersVisualStyles = false;

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
            this.lblDescripcion.Text = "Este reporte muestra las unidades temáticas distribuidas en cada nivel de aprendizaje, detallando la cantidad de lecciones, objetivos pedagógicos y avance curricular.";
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

            //
            // btnImprimir
            //
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(12, 125);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 35);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "📄 Imprimir PDF";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);

            //
            // lblNombreReporte
            //
            this.lblNombreReporte = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombreReporte.AutoSize = false;
            this.lblNombreReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreReporte.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNombreReporte.ForeColor = System.Drawing.Color.Black;
            this.lblNombreReporte.Location = new System.Drawing.Point(150, 130);
            this.lblNombreReporte.Name = "lblNombreReporte";
            this.lblNombreReporte.Size = new System.Drawing.Size(300, 25);
            this.lblNombreReporte.Text = "Reporte de Unidades por Nivel";

            // Agregar todos los paneles al formulario
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblNombreReporte);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSelector);
            this.Controls.Add(this.dgvUnidades);
            this.Controls.Add(this.panelDescripcion);
            this.Controls.Add(this.panelFirma);

            this.ResumeLayout(false);
        }
    }
}