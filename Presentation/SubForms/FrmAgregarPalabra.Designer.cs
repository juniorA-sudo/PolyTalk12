using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Login__Register__Principal
{
    partial class FrmAgregarPalabra
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2Panel panelPrincipal;
        private Guna2Panel panelContenido;
        private Guna2HtmlLabel lblTitulo;

        // Español (input principal)
        private Guna2HtmlLabel lblEspanol;
        private Guna2TextBox txtEspanol;
        private Guna2Button btnTraducir;

        // Inglés (resultado traducción)
        private Guna2HtmlLabel lblIngles;
        private Guna2TextBox txtIngles;
        private Guna2Button btnEscuchar;

        // Imagen
        private Guna2HtmlLabel lblImagenTitulo;
        private PictureBox picImagen;
        private Guna2Button btnBuscarImagen;
        private Guna2HtmlLabel lblEstadoImagen;

        // Acciones
        private Guna2Button btnGuardar;
        private Guna2Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelPrincipal = new Guna2Panel();
            panelContenido = new Guna2Panel();
            lblTitulo = new Guna2HtmlLabel();
            lblEspanol = new Guna2HtmlLabel();
            txtEspanol = new Guna2TextBox();
            btnTraducir = new Guna2Button();
            lblIngles = new Guna2HtmlLabel();
            txtIngles = new Guna2TextBox();
            btnEscuchar = new Guna2Button();
            lblImagenTitulo = new Guna2HtmlLabel();
            picImagen = new PictureBox();
            btnBuscarImagen = new Guna2Button();
            lblEstadoImagen = new Guna2HtmlLabel();
            btnGuardar = new Guna2Button();
            btnCancelar = new Guna2Button();
            panelPrincipal.SuspendLayout();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(242, 245, 250);
            panelPrincipal.Controls.Add(panelContenido);
            panelPrincipal.CustomizableEdges = customizableEdges17;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.FillColor = Color.Transparent;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(30);
            panelPrincipal.ShadowDecoration.CustomizableEdges = customizableEdges18;
            panelPrincipal.Size = new Size(480, 600);
            panelPrincipal.TabIndex = 0;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.Transparent;
            panelContenido.BorderRadius = 20;
            panelContenido.Controls.Add(lblTitulo);
            panelContenido.Controls.Add(lblEspanol);
            panelContenido.Controls.Add(txtEspanol);
            panelContenido.Controls.Add(btnTraducir);
            panelContenido.Controls.Add(lblIngles);
            panelContenido.Controls.Add(txtIngles);
            panelContenido.Controls.Add(btnEscuchar);
            panelContenido.Controls.Add(lblImagenTitulo);
            panelContenido.Controls.Add(picImagen);
            panelContenido.Controls.Add(btnBuscarImagen);
            panelContenido.Controls.Add(lblEstadoImagen);
            panelContenido.Controls.Add(btnGuardar);
            panelContenido.Controls.Add(btnCancelar);
            panelContenido.CustomizableEdges = customizableEdges15;
            panelContenido.FillColor = Color.White;
            panelContenido.Location = new Point(30, 30);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(25);
            panelContenido.ShadowDecoration.BorderRadius = 15;
            panelContenido.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelContenido.ShadowDecoration.Depth = 5;
            panelContenido.ShadowDecoration.Enabled = true;
            panelContenido.Size = new Size(420, 540);
            panelContenido.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 55, 72);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "➕ Agregar Palabra";
            // 
            // lblEspanol
            // 
            lblEspanol.BackColor = Color.Transparent;
            lblEspanol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEspanol.ForeColor = Color.FromArgb(113, 128, 150);
            lblEspanol.Location = new Point(25, 68);
            lblEspanol.Name = "lblEspanol";
            lblEspanol.Size = new Size(120, 19);
            lblEspanol.TabIndex = 1;
            lblEspanol.Text = "Palabra en español";
            // 
            // txtEspanol
            // 
            txtEspanol.BorderRadius = 10;
            txtEspanol.CustomizableEdges = customizableEdges1;
            txtEspanol.DefaultText = "Ej: Perro";
            txtEspanol.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEspanol.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEspanol.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEspanol.FillColor = Color.FromArgb(247, 250, 252);
            txtEspanol.Font = new Font("Segoe UI", 12F);
            txtEspanol.ForeColor = Color.Gray;
            txtEspanol.Location = new Point(25, 92);
            txtEspanol.Name = "txtEspanol";
            txtEspanol.PlaceholderText = "Ej: Perro";
            txtEspanol.SelectedText = "";
            txtEspanol.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEspanol.Size = new Size(280, 40);
            txtEspanol.TabIndex = 0;
            txtEspanol.Enter += txtEspanol_Enter;
            txtEspanol.Leave += txtEspanol_Leave;
            // 
            // btnTraducir
            // 
            btnTraducir.BorderRadius = 10;
            btnTraducir.Cursor = Cursors.Hand;
            btnTraducir.CustomizableEdges = customizableEdges3;
            btnTraducir.FillColor = Color.FromArgb(66, 153, 225);
            btnTraducir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTraducir.ForeColor = Color.White;
            btnTraducir.HoverState.FillColor = Color.FromArgb(49, 130, 206);
            btnTraducir.Location = new Point(315, 92);
            btnTraducir.Name = "btnTraducir";
            btnTraducir.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnTraducir.Size = new Size(80, 40);
            btnTraducir.TabIndex = 1;
            btnTraducir.Text = "🔄 Traducir";
            btnTraducir.Click += btnTraducir_Click;
            // 
            // lblIngles
            // 
            lblIngles.BackColor = Color.Transparent;
            lblIngles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIngles.ForeColor = Color.FromArgb(113, 128, 150);
            lblIngles.Location = new Point(25, 145);
            lblIngles.Name = "lblIngles";
            lblIngles.Size = new Size(131, 19);
            lblIngles.TabIndex = 2;
            lblIngles.Text = "Traducción en inglés";
            // 
            // txtIngles
            // 
            txtIngles.BorderRadius = 10;
            txtIngles.CustomizableEdges = customizableEdges5;
            txtIngles.DefaultText = "Ej: Dog";
            txtIngles.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtIngles.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtIngles.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtIngles.FillColor = Color.FromArgb(240, 248, 255);
            txtIngles.Font = new Font("Segoe UI", 12F);
            txtIngles.ForeColor = Color.FromArgb(45, 55, 72);
            txtIngles.Location = new Point(25, 169);
            txtIngles.Name = "txtIngles";
            txtIngles.PlaceholderText = "Se completará al traducir...";
            txtIngles.SelectedText = "";
            txtIngles.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtIngles.Size = new Size(280, 40);
            txtIngles.TabIndex = 2;
            txtIngles.Enter += txtIngles_Enter;
            txtIngles.Leave += txtIngles_Leave;
            // 
            // btnEscuchar
            // 
            btnEscuchar.BorderRadius = 10;
            btnEscuchar.Cursor = Cursors.Hand;
            btnEscuchar.CustomizableEdges = customizableEdges7;
            btnEscuchar.FillColor = Color.FromArgb(72, 187, 120);
            btnEscuchar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEscuchar.ForeColor = Color.White;
            btnEscuchar.HoverState.FillColor = Color.FromArgb(56, 161, 105);
            btnEscuchar.Location = new Point(315, 169);
            btnEscuchar.Name = "btnEscuchar";
            btnEscuchar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnEscuchar.Size = new Size(80, 40);
            btnEscuchar.TabIndex = 3;
            btnEscuchar.Text = "🔊 Oír";
            btnEscuchar.Click += btnEscuchar_Click;
            // 
            // lblImagenTitulo
            // 
            lblImagenTitulo.BackColor = Color.Transparent;
            lblImagenTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblImagenTitulo.ForeColor = Color.FromArgb(113, 128, 150);
            lblImagenTitulo.Location = new Point(25, 225);
            lblImagenTitulo.Name = "lblImagenTitulo";
            lblImagenTitulo.Size = new Size(49, 19);
            lblImagenTitulo.TabIndex = 4;
            lblImagenTitulo.Text = "Imagen";
            // 
            // picImagen
            // 
            picImagen.BackColor = Color.FromArgb(247, 250, 252);
            picImagen.BorderStyle = BorderStyle.FixedSingle;
            picImagen.Location = new Point(25, 249);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(180, 155);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 5;
            picImagen.TabStop = false;
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.BorderRadius = 10;
            btnBuscarImagen.Cursor = Cursors.Hand;
            btnBuscarImagen.CustomizableEdges = customizableEdges9;
            btnBuscarImagen.FillColor = Color.FromArgb(159, 122, 234);
            btnBuscarImagen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarImagen.ForeColor = Color.White;
            btnBuscarImagen.HoverState.FillColor = Color.FromArgb(128, 90, 213);
            btnBuscarImagen.Location = new Point(215, 249);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnBuscarImagen.Size = new Size(180, 40);
            btnBuscarImagen.TabIndex = 4;
            btnBuscarImagen.Text = "🖼 Buscar imagen (IA)";
            btnBuscarImagen.Click += btnBuscarImagen_Click;
            // 
            // lblEstadoImagen
            // 
            lblEstadoImagen.BackColor = Color.Transparent;
            lblEstadoImagen.Font = new Font("Segoe UI", 10F);
            lblEstadoImagen.ForeColor = Color.Gray;
            lblEstadoImagen.Location = new Point(215, 298);
            lblEstadoImagen.Name = "lblEstadoImagen";
            lblEstadoImagen.Size = new Size(3, 2);
            lblEstadoImagen.TabIndex = 6;
            lblEstadoImagen.Text = null;
            // 
            // btnGuardar
            // 
            btnGuardar.BorderRadius = 12;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.CustomizableEdges = customizableEdges11;
            btnGuardar.FillColor = Color.FromArgb(72, 187, 120);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.HoverState.FillColor = Color.FromArgb(56, 161, 105);
            btnGuardar.Location = new Point(25, 460);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnGuardar.Size = new Size(180, 45);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "💾 Guardar palabra";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BorderRadius = 12;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.CustomizableEdges = customizableEdges13;
            btnCancelar.FillColor = Color.FromArgb(247, 250, 252);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(113, 128, 150);
            btnCancelar.HoverState.FillColor = Color.FromArgb(237, 242, 247);
            btnCancelar.Location = new Point(215, 460);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnCancelar.Size = new Size(180, 45);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregarPalabra
            // 
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(480, 600);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAgregarPalabra";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Palabra";
            Load += FrmAgregarPalabra_Load;
            panelPrincipal.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
        }
    }
}