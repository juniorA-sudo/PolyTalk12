namespace Presentation.Seccion_de_Administrador
{
    partial class FrmReporteDesempenioTareas
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
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDesempenio = new System.Windows.Forms.DataGridView();
            this.panelEstadisticas = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEstadisticas = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesempenio)).BeginInit();
            this.panelEstadisticas.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(280, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📋 Desempeño de Tareas";

            // panelFiltros
            this.panelFiltros.BackColor = System.Drawing.Color.White;
            this.panelFiltros.BorderColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.panelFiltros.BorderThickness = 1;
            this.panelFiltros.Controls.Add(this.label1);
            this.panelFiltros.Controls.Add(this.cmbTarea);
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
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona Tarea:";

            // cmbTarea
            this.cmbTarea.BackColor = System.Drawing.Color.White;
            this.cmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTarea.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.cmbTarea.Location = new System.Drawing.Point(20, 35);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(400, 25);
            this.cmbTarea.TabIndex = 1;
            this.cmbTarea.SelectedIndexChanged += new System.EventHandler(this.CmbTarea_SelectedIndexChanged);

            // dgvDesempenio
            this.dgvDesempenio.AllowUserToAddRows = false;
            this.dgvDesempenio.AllowUserToDeleteRows = false;
            this.dgvDesempenio.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.dgvDesempenio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDesempenio.BackgroundColor = System.Drawing.Color.White;
            this.dgvDesempenio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.dgvDesempenio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDesempenio.ColumnHeadersHeight = 35;
            this.dgvDesempenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDesempenio.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDesempenio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDesempenio.Location = new System.Drawing.Point(0, 130);
            this.dgvDesempenio.Name = "dgvDesempenio";
            this.dgvDesempenio.ReadOnly = true;
            this.dgvDesempenio.RowHeadersVisible = false;
            this.dgvDesempenio.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvDesempenio.RowTemplate.Height = 40;
            this.dgvDesempenio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDesempenio.Size = new System.Drawing.Size(900, 340);
            this.dgvDesempenio.TabIndex = 2;

            // panelEstadisticas
            this.panelEstadisticas.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelEstadisticas.BorderColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.panelEstadisticas.BorderThickness = 1;
            this.panelEstadisticas.Controls.Add(this.lblEstadisticas);
            this.panelEstadisticas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEstadisticas.FillColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelEstadisticas.Location = new System.Drawing.Point(0, 470);
            this.panelEstadisticas.Name = "panelEstadisticas";
            this.panelEstadisticas.Padding = new System.Windows.Forms.Padding(20);
            this.panelEstadisticas.Size = new System.Drawing.Size(900, 30);
            this.panelEstadisticas.TabIndex = 3;

            // lblEstadisticas
            this.lblEstadisticas.AutoSize = true;
            this.lblEstadisticas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstadisticas.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblEstadisticas.Location = new System.Drawing.Point(20, 5);
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(0, 15);
            this.lblEstadisticas.TabIndex = 0;

            // FrmReporteDesempenioTareas
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dgvDesempenio);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelEstadisticas);
            this.Name = "FrmReporteDesempenioTareas";
            this.Text = "Desempeño de Tareas";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesempenio)).EndInit();
            this.panelEstadisticas.ResumeLayout(false);
            this.panelEstadisticas.PerformLayout();
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel panelFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.DataGridView dgvDesempenio;
        private Guna.UI2.WinForms.Guna2Panel panelEstadisticas;
        private System.Windows.Forms.Label lblEstadisticas;
    }
}
