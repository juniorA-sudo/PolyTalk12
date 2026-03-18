namespace Presentation.Controls
{
    partial class UCLeccion
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            lblNombreLeccion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(iconButton3);
            guna2Panel2.Controls.Add(iconButton2);
            guna2Panel2.Controls.Add(guna2Panel4);
            guna2Panel2.Controls.Add(lblNombreLeccion);
            guna2Panel2.Controls.Add(iconButton1);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Dock = DockStyle.Fill;
            guna2Panel2.Location = new Point(0, 0);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(301, 30);
            guna2Panel2.TabIndex = 1;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(216, 7);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(20, 17);
            iconButton3.TabIndex = 5;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(190, 7);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(20, 17);
            iconButton2.TabIndex = 4;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // guna2Panel4
            // 
            guna2Panel4.BackColor = Color.Gray;
            guna2Panel4.CustomizableEdges = customizableEdges1;
            guna2Panel4.Dock = DockStyle.Bottom;
            guna2Panel4.Location = new Point(0, 29);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel4.Size = new Size(301, 1);
            guna2Panel4.TabIndex = 3;
            // 
            // lblNombreLeccion
            // 
            lblNombreLeccion.BackColor = Color.Transparent;
            lblNombreLeccion.Location = new Point(37, 7);
            lblNombreLeccion.Name = "lblNombreLeccion";
            lblNombreLeccion.Size = new Size(116, 17);
            lblNombreLeccion.TabIndex = 2;
            lblNombreLeccion.Text = "Nombre de la leccion";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.RosyBrown;
            iconButton1.FlatStyle = FlatStyle.System;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(4, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(26, 23);
            iconButton1.TabIndex = 1;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // UCLeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel2);
            Name = "UCLeccion";
            Size = new Size(301, 30);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreLeccion;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
