namespace Presentation
{
    partial class UCUnidadesEstudiante
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            lblNumero = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblProgreso = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.Control;
            guna2Panel1.BorderColor = Color.Gray;
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblProgreso);
            guna2Panel1.Controls.Add(lblTitulo);
            guna2Panel1.Controls.Add(lblNumero);
            guna2Panel1.Controls.Add(progressBar);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(148, 72);
            guna2Panel1.TabIndex = 0;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // progressBar
            // 
            progressBar.BorderRadius = 2;
            progressBar.CustomizableEdges = customizableEdges5;
            progressBar.Location = new Point(10, 44);
            progressBar.Name = "progressBar";
            progressBar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            progressBar.Size = new Size(129, 5);
            progressBar.TabIndex = 2;
            progressBar.Text = "guna2ProgressBar1";
            progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblNumero
            // 
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.ForeColor = Color.Gray;
            lblNumero.Location = new Point(10, 12);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(50, 15);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Unidad 1";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(10, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(84, 17);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Entertainment";
            // 
            // lblProgreso
            // 
            lblProgreso.BackColor = Color.Transparent;
            lblProgreso.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgreso.ForeColor = Color.FromArgb(128, 128, 255);
            lblProgreso.Location = new Point(23, 49);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(93, 15);
            lblProgreso.TabIndex = 5;
            lblProgreso.Text = "guna2HtmlLabel3";
            // 
            // UCUnidadesEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Name = "UCUnidadesEstudiante";
            Size = new Size(148, 72);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumero;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProgreso;
    }
}
