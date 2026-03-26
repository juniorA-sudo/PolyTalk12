namespace Presentation.Seccion_de_Administrador
{
    partial class FrmReporteProgresoGrupo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFiltros = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProgreso = new System.Windows.Forms.DataGridView();
            this.panelResumen = new Guna.UI2.WinForms.Guna2Panel();
            this.lblResumen = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgreso)).BeginInit();
            this.panelResumen.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 60);
            this.panelHeader.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(250, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📊 Progreso del Grupo";

            // panelFiltros
            this.panelFiltros.BackColor = System.Drawing.Color.White;
            this.panelFiltros.BorderColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.panelFiltros.BorderThickness = 1;
            this.panelFiltros.Controls.Add(this.label1);
            this.panelFiltros.Controls.Add(this.cmbGrupo);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.FillColor = System.Drawing.Color.White;
            this.panelFiltros.Location = new System.Drawing.Point(0, 60);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Padding = new System.Windows.Forms.Padding(20);
            this.panelFiltros.Size = new System.Drawing.Size(900, 70);
            this.panelFiltros.TabIndex = 1;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona Grupo:";

            // cmbGrupo
            this.cmbGrupo.BackColor = System.Drawing.Color.White;
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGrupo.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.cmbGrupo.Location = new System.Drawing.Point(20, 35);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(300, 25);
            this.cmbGrupo.TabIndex = 1;

            // dgvProgreso
            this.dgvProgreso.AllowUserToAddRows = false;
            this.dgvProgreso.AllowUserToDeleteRows = false;
            this.dgvProgreso.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.dgvProgreso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProgreso.BackgroundColor = System.Drawing.Color.White;
            this.dgvProgreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.dgvProgreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProgreso.ColumnHeadersHeight = 35;
            this.dgvProgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProgreso.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProgreso.Location = new System.Drawing.Point(0, 130);
            this.dgvProgreso.Name = "dgvProgreso";
            this.dgvProgreso.ReadOnly = true;
            this.dgvProgreso.RowHeadersVisible = false;
            this.dgvProgreso.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvProgreso.RowTemplate.Height = 35;
            this.dgvProgreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgreso.Size = new System.Drawing.Size(900, 370);
            this.dgvProgreso.TabIndex = 2;

            // panelResumen
            this.panelResumen.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelResumen.BorderColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.panelResumen.BorderThickness = 1;
            this.panelResumen.Controls.Add(this.lblResumen);
            this.panelResumen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResumen.FillColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelResumen.Location = new System.Drawing.Point(0, 500);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Padding = new System.Windows.Forms.Padding(20);
            this.panelResumen.Size = new System.Drawing.Size(900, 0);
            this.panelResumen.TabIndex = 3;

            // lblResumen
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblResumen.Location = new System.Drawing.Point(20, 15);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(0, 19);
            this.lblResumen.TabIndex = 0;

            // FrmReporteProgresoGrupo
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dgvProgreso);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelResumen);
            this.Name = "FrmReporteProgresoGrupo";
            this.Text = "Progreso del Grupo";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgreso)).EndInit();
            this.panelResumen.ResumeLayout(false);
            this.panelResumen.PerformLayout();
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel panelFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.DataGridView dgvProgreso;
        private Guna.UI2.WinForms.Guna2Panel panelResumen;
        private System.Windows.Forms.Label lblResumen;
    }
}
