using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Administrador
{
    partial class FrmReporteGrupos
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

        private Guna2DataGridView dgvGrupos;
        private DataGridViewTextBoxColumn colGrupo;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNivel;
        private DataGridViewTextBoxColumn colMaestro;
        private DataGridViewTextBoxColumn colCupo;
        private DataGridViewTextBoxColumn colInscritos;
        private DataGridViewTextBoxColumn colDisponible;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            dgvGrupos = new Guna2DataGridView();
            colGrupo = new DataGridViewTextBoxColumn();
            colCodigo = new DataGridViewTextBoxColumn();
            colNivel = new DataGridViewTextBoxColumn();
            colMaestro = new DataGridViewTextBoxColumn();
            colCupo = new DataGridViewTextBoxColumn();
            colInscritos = new DataGridViewTextBoxColumn();
            colDisponible = new DataGridViewTextBoxColumn();
            panelDescripcion = new Guna2Panel();
            lblDescripcion = new Guna2HtmlLabel();
            panelFirma = new Guna2Panel();
            lblFirma = new Guna2HtmlLabel();
            lblFirmaEmail = new Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            btnImprimir = new FontAwesome.Sharp.IconButton();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
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
            panelHeader.Padding = new Padding(10);
            panelHeader.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            panelHeader.Size = new Size(565, 65);
            panelHeader.TabIndex = 0;
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
            lblDirigido.Location = new Point(350, 40);
            lblDirigido.Name = "lblDirigido";
            lblDirigido.Size = new Size(140, 25);
            lblDirigido.TabIndex = 8;
            lblDirigido.Text = "Administración y supervisión";
            // 
            // dgvGrupos
            // 
            dgvGrupos.AllowUserToAddRows = false;
            dgvGrupos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 82, 180);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGrupos.ColumnHeadersHeight = 30;
            dgvGrupos.Columns.AddRange(new DataGridViewColumn[] { colGrupo, colCodigo, colNivel, colMaestro, colCupo, colInscritos, colDisponible });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGrupos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGrupos.GridColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.Location = new Point(12, 87);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.ReadOnly = true;
            dgvGrupos.RowHeadersVisible = false;
            dgvGrupos.Size = new Size(565, 254);
            dgvGrupos.TabIndex = 1;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvGrupos.ThemeStyle.BackColor = Color.White;
            dgvGrupos.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 82, 180);
            dgvGrupos.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGrupos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
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
            // 
            // colGrupo
            // 
            colGrupo.HeaderText = "Grupo";
            colGrupo.Name = "colGrupo";
            colGrupo.ReadOnly = true;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colNivel
            // 
            colNivel.HeaderText = "Nivel";
            colNivel.Name = "colNivel";
            colNivel.ReadOnly = true;
            // 
            // colMaestro
            // 
            colMaestro.HeaderText = "Maestro";
            colMaestro.Name = "colMaestro";
            colMaestro.ReadOnly = true;
            // 
            // colCupo
            // 
            colCupo.HeaderText = "Cupo";
            colCupo.Name = "colCupo";
            colCupo.ReadOnly = true;
            // 
            // colInscritos
            // 
            colInscritos.HeaderText = "Insc";
            colInscritos.Name = "colInscritos";
            colInscritos.ReadOnly = true;
            // 
            // colDisponible
            // 
            colDisponible.HeaderText = " Disp";
            colDisponible.Name = "colDisponible";
            colDisponible.ReadOnly = true;
            // 
            // panelDescripcion
            // 
            panelDescripcion.BackColor = Color.FromArgb(240, 245, 255);
            panelDescripcion.BorderRadius = 8;
            panelDescripcion.Controls.Add(lblDescripcion);
            panelDescripcion.CustomizableEdges = customizableEdges3;
            panelDescripcion.FillColor = Color.FromArgb(240, 245, 255);
            panelDescripcion.Location = new Point(12, 348);
            panelDescripcion.Name = "panelDescripcion";
            panelDescripcion.Padding = new Padding(8);
            panelDescripcion.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelDescripcion.Size = new Size(565, 45);
            panelDescripcion.TabIndex = 2;
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
            lblDescripcion.Text = "Listado completo de grupos: información del grupo, nivel, maestro asignado, cupo total, inscritos y lugares disponibles.";
            // 
            // panelFirma
            // 
            panelFirma.BackColor = Color.White;
            panelFirma.BorderRadius = 8;
            panelFirma.Controls.Add(lblFirma);
            panelFirma.Controls.Add(lblFirmaEmail);
            panelFirma.CustomizableEdges = customizableEdges5;
            panelFirma.Location = new Point(12, 401);
            panelFirma.Name = "panelFirma";
            panelFirma.Padding = new Padding(8);
            panelFirma.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelFirma.Size = new Size(565, 35);
            panelFirma.TabIndex = 3;
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
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(182, 115);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(195, 32);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Reporte de Grupos";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(0, 122, 204);
            btnImprimir.Font = new Font("Segoe UI", 10F);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnImprimir.IconColor = Color.Black;
            btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImprimir.Location = new Point(12, 0);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(120, 35);
            btnImprimir.TabIndex = 11;
            btnImprimir.Text = "📄 Imprimir PDF";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // FrmReporteGrupos
            // 
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(589, 467);
            Controls.Add(btnImprimir);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(panelHeader);
            Controls.Add(dgvGrupos);
            Controls.Add(panelDescripcion);
            Controls.Add(panelFirma);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReporteGrupos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reporte: Grupos";
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            panelDescripcion.ResumeLayout(false);
            panelFirma.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        private Guna2HtmlLabel guna2HtmlLabel1;
        private FontAwesome.Sharp.IconButton btnImprimir;
    }
}