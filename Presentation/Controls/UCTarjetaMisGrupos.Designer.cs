using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Maestros
{
    partial class UCTarjetaMisGrupos
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private Guna2Panel panelFondo;
        private Guna2Button btnVerEstudiantes;
        private Guna2HtmlLabel lblNombre;
        private Guna2HtmlLabel lblEstudiantes;
        private Guna2HtmlLabel lblHorario;
        private FlowLayoutPanel flpMaterias;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelFondo = new Guna2Panel();
            btnVer = new FontAwesome.Sharp.IconButton();
            lblNombre = new Guna2HtmlLabel();
            lblEstudiantes = new Guna2HtmlLabel();
            lblHorario = new Guna2HtmlLabel();
            flpMaterias = new FlowLayoutPanel();
            panelFondo.SuspendLayout();
            SuspendLayout();
            // 
            // panelFondo
            // 
            panelFondo.BackColor = Color.Transparent;
            panelFondo.BorderColor = Color.FromArgb(230, 230, 230);
            panelFondo.BorderRadius = 20;
            panelFondo.BorderThickness = 1;
            panelFondo.Controls.Add(btnVer);
            panelFondo.Controls.Add(lblNombre);
            panelFondo.Controls.Add(lblEstudiantes);
            panelFondo.Controls.Add(lblHorario);
            panelFondo.Controls.Add(flpMaterias);
            panelFondo.CustomizableEdges = customizableEdges1;
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.FillColor = Color.White;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Margin = new Padding(10);
            panelFondo.Name = "panelFondo";
            panelFondo.Padding = new Padding(10);
            panelFondo.ShadowDecoration.BorderRadius = 20;
            panelFondo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelFondo.ShadowDecoration.Depth = 5;
            panelFondo.ShadowDecoration.Enabled = true;
            panelFondo.Size = new Size(180, 140);
            panelFondo.TabIndex = 0;
            panelFondo.Paint += panelFondo_Paint;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.CornflowerBlue;
            btnVer.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnVer.IconColor = Color.White;
            btnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVer.IconSize = 25;
            btnVer.Location = new Point(134, 13);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(33, 32);
            btnVer.TabIndex = 6;
            btnVer.UseVisualStyleBackColor = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = false;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(45, 55, 72);
            lblNombre.Location = new Point(10, 10);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Grupo B1-01";
            // 
            // lblEstudiantes
            // 
            lblEstudiantes.AutoSize = false;
            lblEstudiantes.BackColor = Color.Transparent;
            lblEstudiantes.Font = new Font("Segoe UI", 9F);
            lblEstudiantes.ForeColor = Color.FromArgb(113, 128, 150);
            lblEstudiantes.Location = new Point(10, 40);
            lblEstudiantes.Name = "lblEstudiantes";
            lblEstudiantes.Size = new Size(100, 15);
            lblEstudiantes.TabIndex = 3;
            lblEstudiantes.Text = "24 estudiantes";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = false;
            lblHorario.BackColor = Color.Transparent;
            lblHorario.Font = new Font("Segoe UI", 9F);
            lblHorario.ForeColor = Color.FromArgb(113, 128, 150);
            lblHorario.Location = new Point(10, 60);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(120, 15);
            lblHorario.TabIndex = 4;
            lblHorario.Text = "Lun/Mié 10am";
            // 
            // flpMaterias
            // 
            flpMaterias.BackColor = Color.Transparent;
            flpMaterias.Location = new Point(10, 85);
            flpMaterias.Name = "flpMaterias";
            flpMaterias.Size = new Size(160, 40);
            flpMaterias.TabIndex = 5;
            // 
            // UCTarjetaMisGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelFondo);
            Margin = new Padding(0, 0, 15, 10);
            Name = "UCTarjetaMisGrupos";
            Size = new Size(180, 140);
            panelFondo.ResumeLayout(false);
            ResumeLayout(false);
        }
        private FontAwesome.Sharp.IconButton btnVer;
    }
}