namespace Presentation
{
    partial class ReporteEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvEstudiantes = new DataGridView();
            btnImprimir = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // dgvEstudiantes
            //
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEstudiantes.BackgroundColor = Color.White;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Dock = DockStyle.Fill;
            dgvEstudiantes.Location = new Point(0, 60);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowTemplate.Height = 25;
            dgvEstudiantes.Size = new Size(900, 540);
            dgvEstudiantes.TabIndex = 0;
            //
            // btnImprimir
            //
            btnImprimir.CustomizableEdges = customizableEdges1;
            btnImprimir.DisabledState.BorderColor = Color.DarkGray;
            btnImprimir.DisabledState.CustomizableEdges = customizableEdges2;
            btnImprimir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnImprimir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnImprimir.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(10, 20);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(150, 35);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "📄 Imprimir PDF";
            btnImprimir.Click += new System.EventHandler(btnImprimir_Click);
            //
            // guna2HtmlLabel1
            //
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.Black;
            guna2HtmlLabel1.Location = new Point(170, 20);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(204, 30);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Reporte de Estudiantes";
            //
            // ReporteEstudiantes
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(dgvEstudiantes);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btnImprimir);
            Name = "ReporteEstudiantes";
            Text = "Reporte de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstudiantes;
        private Guna.UI2.WinForms.Guna2Button btnImprimir;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}