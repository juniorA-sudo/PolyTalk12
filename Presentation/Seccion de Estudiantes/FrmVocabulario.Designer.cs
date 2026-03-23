using Guna.UI2.WinForms;
using FontAwesome.Sharp;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Seccion_de_Estudiantes
{
    partial class FrmVocabulario
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelHeader;
        private IconPictureBox iconPictureBox1;
        private Guna2HtmlLabel lblTitulo;
        private Guna2HtmlLabel lblSubtitulo;
        private Guna2Panel separadorHeader;
        private Guna2Panel panelBusqueda;
        private Guna2TextBox txtBuscar;
        private IconPictureBox iconLupa;
        private Guna2Button btnCrearLista;
        private FlowLayoutPanel flpCategorias;
        // dummy
        private Guna2Panel guna2Panel2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Guna2Panel();
            separadorHeader = new Guna2Panel();
            iconPictureBox1 = new IconPictureBox();
            lblTitulo = new Guna2HtmlLabel();
            lblSubtitulo = new Guna2HtmlLabel();
            guna2Panel2 = new Guna2Panel();
            panelBusqueda = new Guna2Panel();
            iconLupa = new IconPictureBox();
            txtBuscar = new Guna2TextBox();
            btnCrearLista = new Guna2Button();
            flpCategorias = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconLupa).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(separadorHeader);
            panelHeader.Controls.Add(iconPictureBox1);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(guna2Panel2);
            panelHeader.CustomizableEdges = customizableEdges5;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.White;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.Color = Color.FromArgb(15, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(854, 72);
            panelHeader.TabIndex = 0;
            // 
            // separadorHeader
            // 
            separadorHeader.CustomizableEdges = customizableEdges1;
            separadorHeader.FillColor = Color.FromArgb(255, 183, 0);
            separadorHeader.Location = new Point(0, 0);
            separadorHeader.Name = "separadorHeader";
            separadorHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            separadorHeader.Size = new Size(5, 72);
            separadorHeader.TabIndex = 10;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(255, 240, 210);
            iconPictureBox1.ForeColor = Color.FromArgb(255, 140, 0);
            iconPictureBox1.IconChar = IconChar.BookOpen;
            iconPictureBox1.IconColor = Color.FromArgb(255, 140, 0);
            iconPictureBox1.IconFont = IconFont.Auto;
            iconPictureBox1.IconSize = 42;
            iconPictureBox1.Location = new Point(20, 16);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(42, 42);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(25, 25, 35);
            lblTitulo.Location = new Point(72, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(142, 34);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Vocabulario";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(130, 130, 150);
            lblSubtitulo.Location = new Point(74, 44);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(230, 17);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Amplía tu vocabulario de forma creativa ✨";
            // 
            // guna2Panel2
            // 
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.FillColor = Color.FromArgb(235, 228, 215);
            guna2Panel2.Location = new Point(0, 71);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(854, 1);
            guna2Panel2.TabIndex = 9;
            // 
            // panelBusqueda
            // 
            panelBusqueda.BackColor = Color.FromArgb(252, 248, 240);
            panelBusqueda.Controls.Add(iconLupa);
            panelBusqueda.Controls.Add(txtBuscar);
            panelBusqueda.Controls.Add(btnCrearLista);
            panelBusqueda.CustomizableEdges = customizableEdges11;
            panelBusqueda.Dock = DockStyle.Top;
            panelBusqueda.FillColor = Color.FromArgb(252, 248, 240);
            panelBusqueda.Location = new Point(0, 72);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Padding = new Padding(20, 14, 20, 14);
            panelBusqueda.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelBusqueda.Size = new Size(854, 70);
            panelBusqueda.TabIndex = 1;
            // 
            // iconLupa
            // 
            iconLupa.BackColor = Color.Transparent;
            iconLupa.ForeColor = Color.FromArgb(180, 165, 140);
            iconLupa.IconChar = IconChar.Search;
            iconLupa.IconColor = Color.FromArgb(180, 165, 140);
            iconLupa.IconFont = IconFont.Auto;
            iconLupa.IconSize = 18;
            iconLupa.Location = new Point(12, 26);
            iconLupa.Name = "iconLupa";
            iconLupa.Size = new Size(18, 18);
            iconLupa.TabIndex = 1;
            iconLupa.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Transparent;
            txtBuscar.BorderColor = Color.FromArgb(225, 215, 195);
            txtBuscar.BorderRadius = 22;
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.CustomizableEdges = customizableEdges7;
            txtBuscar.DefaultText = "";
            txtBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.FocusedState.BorderColor = Color.FromArgb(255, 140, 0);
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.ForeColor = Color.FromArgb(64, 64, 64);
            txtBuscar.HoverState.BorderColor = Color.FromArgb(255, 183, 0);
            txtBuscar.Location = new Point(45, 14);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(42, 0, 14, 0);
            txtBuscar.PlaceholderText = "Buscar lista...";
            txtBuscar.SelectedText = "";
            txtBuscar.ShadowDecoration.BorderRadius = 22;
            txtBuscar.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            txtBuscar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtBuscar.ShadowDecoration.Depth = 4;
            txtBuscar.ShadowDecoration.Enabled = true;
            txtBuscar.Size = new Size(380, 42);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnCrearLista
            // 
            btnCrearLista.BackColor = Color.Transparent;
            btnCrearLista.BorderRadius = 22;
            btnCrearLista.CustomizableEdges = customizableEdges9;
            btnCrearLista.FillColor = Color.FromArgb(255, 140, 0);
            btnCrearLista.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrearLista.ForeColor = Color.White;
            btnCrearLista.HoverState.FillColor = Color.FromArgb(230, 120, 0);
            btnCrearLista.Location = new Point(620, 14);
            btnCrearLista.Name = "btnCrearLista";
            btnCrearLista.ShadowDecoration.Color = Color.FromArgb(40, 255, 140, 0);
            btnCrearLista.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCrearLista.ShadowDecoration.Depth = 5;
            btnCrearLista.ShadowDecoration.Enabled = true;
            btnCrearLista.Size = new Size(180, 42);
            btnCrearLista.TabIndex = 2;
            btnCrearLista.Text = "+ Nueva lista";
            btnCrearLista.Click += btnCrearLista_Click;
            // 
            // flpCategorias
            // 
            flpCategorias.AutoScroll = true;
            flpCategorias.BackColor = Color.FromArgb(252, 248, 240);
            flpCategorias.Dock = DockStyle.Fill;
            flpCategorias.Location = new Point(0, 142);
            flpCategorias.Name = "flpCategorias";
            flpCategorias.Padding = new Padding(20, 16, 20, 16);
            flpCategorias.Size = new Size(854, 393);
            flpCategorias.TabIndex = 2;
            // 
            // FrmVocabulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 240);
            ClientSize = new Size(854, 535);
            Controls.Add(flpCategorias);
            Controls.Add(panelBusqueda);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVocabulario";
            Text = "Vocabulario";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconLupa).EndInit();
            ResumeLayout(false);
        }
    }
}