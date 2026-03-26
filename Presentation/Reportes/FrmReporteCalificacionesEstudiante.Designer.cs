namespace Presentation.Reportes
{
    partial class FrmReporteCalificacionesEstudiante
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
            this.lblFecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSubtitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombreEstudiante = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.panelContenido = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvCalificaciones = new Guna.UI2.WinForms.Guna2DataGridView();

            this.panelEstadisticas = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalTareasVal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalificadasVal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPromedioVal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaximaVal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMinimaVal = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.lblTotalTareas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalificadas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPromedio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaxima = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMinima = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.prgCalificadas = new System.Windows.Forms.ProgressBar();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.panelHeader.Controls.Add(this.lblFecha);
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.lblNombreEstudiante);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(854, 100);
            this.panelHeader.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📚 Mis Calificaciones";

            // lblNombreEstudiante
            this.lblNombreEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEstudiante.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblNombreEstudiante.ForeColor = System.Drawing.Color.White;
            this.lblNombreEstudiante.Location = new System.Drawing.Point(20, 40);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(300, 22);
            this.lblNombreEstudiante.TabIndex = 1;
            this.lblNombreEstudiante.Text = "Estudiante";

            // lblSubtitulo
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 65);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(350, 18);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Reporte detallado de todas tus calificaciones en tareas";

            // lblFecha
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblFecha.Location = new System.Drawing.Point(700, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(130, 17);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "01 de enero, 2026";
            this.lblFecha.TextAlignment = System.Drawing.ContentAlignment.TopRight;

            // panelContenido
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.panelContenido.Controls.Add(this.dgvCalificaciones);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 100);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(15);
            this.panelContenido.Size = new System.Drawing.Size(854, 350);
            this.panelContenido.TabIndex = 1;

            // dgvCalificaciones
            this.dgvCalificaciones.AllowUserToAddRows = false;
            this.dgvCalificaciones.AllowUserToDeleteRows = false;
            this.dgvCalificaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 255);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCalificaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalificaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvCalificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(0, 82, 180);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(0, 82, 180);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalificaciones.ColumnHeadersHeight = 35;
            this.dgvCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalificaciones.EnableHeadersVisualStyles = false;
            this.dgvCalificaciones.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvCalificaciones.Location = new System.Drawing.Point(15, 15);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.ReadOnly = true;
            this.dgvCalificaciones.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCalificaciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCalificaciones.RowTemplate.Height = 28;
            this.dgvCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalificaciones.Size = new System.Drawing.Size(824, 320);
            this.dgvCalificaciones.TabIndex = 0;
            this.dgvCalificaciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCalificaciones.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCalificaciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCalificaciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 255);
            this.dgvCalificaciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCalificaciones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCalificaciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvCalificaciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.dgvCalificaciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvCalificaciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCalificaciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCalificaciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCalificaciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCalificaciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCalificaciones.ThemeStyle.RowsStyle.Height = 28;
            this.dgvCalificaciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 255);
            this.dgvCalificaciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;

            // panelEstadisticas
            this.panelEstadisticas.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.panelEstadisticas.Controls.Add(this.lblTotalTareasVal);
            this.panelEstadisticas.Controls.Add(this.lblCalificadasVal);
            this.panelEstadisticas.Controls.Add(this.lblPromedioVal);
            this.panelEstadisticas.Controls.Add(this.lblMaximaVal);
            this.panelEstadisticas.Controls.Add(this.lblMinimaVal);
            this.panelEstadisticas.Controls.Add(this.lblTotalTareas);
            this.panelEstadisticas.Controls.Add(this.lblCalificadas);
            this.panelEstadisticas.Controls.Add(this.lblPromedio);
            this.panelEstadisticas.Controls.Add(this.lblMaxima);
            this.panelEstadisticas.Controls.Add(this.lblMinima);
            this.panelEstadisticas.Controls.Add(this.prgCalificadas);
            this.panelEstadisticas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEstadisticas.FillColor = System.Drawing.Color.FromArgb(240, 242, 248);
            this.panelEstadisticas.Location = new System.Drawing.Point(0, 450);
            this.panelEstadisticas.Name = "panelEstadisticas";
            this.panelEstadisticas.Padding = new System.Windows.Forms.Padding(20);
            this.panelEstadisticas.Size = new System.Drawing.Size(854, 85);
            this.panelEstadisticas.TabIndex = 2;

            // Estadísticas Labels
            this.lblTotalTareasVal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTareasVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalTareasVal.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.lblTotalTareasVal.Location = new System.Drawing.Point(30, 25);
            this.lblTotalTareasVal.Name = "lblTotalTareasVal";
            this.lblTotalTareasVal.Size = new System.Drawing.Size(30, 18);
            this.lblTotalTareasVal.TabIndex = 0;
            this.lblTotalTareasVal.Text = "0";

            this.lblTotalTareas.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTareas.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalTareas.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblTotalTareas.Location = new System.Drawing.Point(30, 45);
            this.lblTotalTareas.Name = "lblTotalTareas";
            this.lblTotalTareas.Size = new System.Drawing.Size(80, 16);
            this.lblTotalTareas.TabIndex = 1;
            this.lblTotalTareas.Text = "Total Tareas";

            this.lblCalificadasVal.BackColor = System.Drawing.Color.Transparent;
            this.lblCalificadasVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalificadasVal.ForeColor = System.Drawing.Color.FromArgb(56, 161, 105);
            this.lblCalificadasVal.Location = new System.Drawing.Point(140, 25);
            this.lblCalificadasVal.Name = "lblCalificadasVal";
            this.lblCalificadasVal.Size = new System.Drawing.Size(30, 18);
            this.lblCalificadasVal.TabIndex = 2;
            this.lblCalificadasVal.Text = "0";

            this.lblCalificadas.BackColor = System.Drawing.Color.Transparent;
            this.lblCalificadas.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCalificadas.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblCalificadas.Location = new System.Drawing.Point(120, 45);
            this.lblCalificadas.Name = "lblCalificadas";
            this.lblCalificadas.Size = new System.Drawing.Size(80, 16);
            this.lblCalificadas.TabIndex = 3;
            this.lblCalificadas.Text = "Calificadas";

            this.lblPromedioVal.BackColor = System.Drawing.Color.Transparent;
            this.lblPromedioVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPromedioVal.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            this.lblPromedioVal.Location = new System.Drawing.Point(250, 25);
            this.lblPromedioVal.Name = "lblPromedioVal";
            this.lblPromedioVal.Size = new System.Drawing.Size(50, 18);
            this.lblPromedioVal.TabIndex = 4;
            this.lblPromedioVal.Text = "N/A";

            this.lblPromedio.BackColor = System.Drawing.Color.Transparent;
            this.lblPromedio.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPromedio.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblPromedio.Location = new System.Drawing.Point(250, 45);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(80, 16);
            this.lblPromedio.TabIndex = 5;
            this.lblPromedio.Text = "⭐ Promedio";

            this.lblMaximaVal.BackColor = System.Drawing.Color.Transparent;
            this.lblMaximaVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaximaVal.ForeColor = System.Drawing.Color.FromArgb(56, 161, 105);
            this.lblMaximaVal.Location = new System.Drawing.Point(360, 25);
            this.lblMaximaVal.Name = "lblMaximaVal";
            this.lblMaximaVal.Size = new System.Drawing.Size(50, 18);
            this.lblMaximaVal.TabIndex = 6;
            this.lblMaximaVal.Text = "N/A";

            this.lblMaxima.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxima.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMaxima.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblMaxima.Location = new System.Drawing.Point(360, 45);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(80, 16);
            this.lblMaxima.TabIndex = 7;
            this.lblMaxima.Text = "Máxima";

            this.lblMinimaVal.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimaVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMinimaVal.ForeColor = System.Drawing.Color.FromArgb(197, 48, 48);
            this.lblMinimaVal.Location = new System.Drawing.Point(470, 25);
            this.lblMinimaVal.Name = "lblMinimaVal";
            this.lblMinimaVal.Size = new System.Drawing.Size(50, 18);
            this.lblMinimaVal.TabIndex = 8;
            this.lblMinimaVal.Text = "N/A";

            this.lblMinima.BackColor = System.Drawing.Color.Transparent;
            this.lblMinima.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMinima.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblMinima.Location = new System.Drawing.Point(470, 45);
            this.lblMinima.Name = "lblMinima";
            this.lblMinima.Size = new System.Drawing.Size(80, 16);
            this.lblMinima.TabIndex = 9;
            this.lblMinima.Text = "Mínima";

            // prgCalificadas
            this.prgCalificadas.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.prgCalificadas.ForeColor = System.Drawing.Color.FromArgb(56, 161, 105);
            this.prgCalificadas.Location = new System.Drawing.Point(600, 25);
            this.prgCalificadas.Name = "prgCalificadas";
            this.prgCalificadas.Size = new System.Drawing.Size(210, 18);
            this.prgCalificadas.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgCalificadas.TabIndex = 10;
            this.prgCalificadas.Value = 0;

            // FrmReporteCalificacionesEstudiante
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.ClientSize = new System.Drawing.Size(854, 535);
            this.Controls.Add(this.panelEstadisticas);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteCalificacionesEstudiante";
            this.Text = "Mis Calificaciones";
            this.panelHeader.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelEstadisticas.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreEstudiante;

        private Guna.UI2.WinForms.Guna2Panel panelContenido;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCalificaciones;

        private Guna.UI2.WinForms.Guna2Panel panelEstadisticas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalTareasVal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalificadasVal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPromedioVal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaximaVal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMinimaVal;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalTareas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalificadas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPromedio;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaxima;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMinima;

        private System.Windows.Forms.ProgressBar prgCalificadas;
    }
}
