using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace Presentation.Seccion_de_Estudiantes
{
    partial class FrmVocabulario
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private Guna2Panel panelHeader;
        private IconPictureBox iconPictureBox1;
        private Guna2HtmlLabel lblTitulo;
        private Guna2HtmlLabel lblSubtitulo;
        private Button btnCerrar;
        private Guna2Panel guna2Panel2;

        private Guna2Panel panelBusqueda;
        private Guna2TextBox txtBuscar;
        private IconPictureBox iconLupa;
        private Guna2Button btnCrearLista;

        private FlowLayoutPanel flpCategorias;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Guna2Panel();
            iconPictureBox1 = new IconPictureBox();
            lblTitulo = new Guna2HtmlLabel();
            lblSubtitulo = new Guna2HtmlLabel();
            guna2Panel2 = new Guna2Panel();
            panelBusqueda = new Guna2Panel();
            txtBuscar = new Guna2TextBox();
            iconLupa = new IconPictureBox();
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
            panelHeader.BackColor = Color.FromArgb(255, 247, 237);
            panelHeader.Controls.Add(iconPictureBox1);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(guna2Panel2);
            panelHeader.CustomizableEdges = customizableEdges3;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.FromArgb(255, 247, 237);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.ShadowDecoration.Shadow = new Padding(0, 0, 0, 4);
            panelHeader.Size = new Size(854, 80);
            panelHeader.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.FromArgb(94, 114, 228);
            iconPictureBox1.IconChar = IconChar.BookOpen;
            iconPictureBox1.IconColor = Color.FromArgb(94, 114, 228);
            iconPictureBox1.IconFont = IconFont.Auto;
            iconPictureBox1.IconSize = 45;
            iconPictureBox1.Location = new Point(25, 17);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(45, 45);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(34, 47, 62);
            lblTitulo.Location = new Point(85, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 35);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Vocabulario";
            lblTitulo.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = false;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(120, 130, 150);
            lblSubtitulo.Location = new Point(85, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(300, 20);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Amplía tu vocabulario de forma creativa ✨";
            lblSubtitulo.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(230, 230, 230);
            guna2Panel2.CustomizableEdges = customizableEdges1;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.Location = new Point(0, 79);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(854, 1);
            guna2Panel2.TabIndex = 2;
            // 
            // panelBusqueda
            // 
            panelBusqueda.BackColor = Color.FromArgb(255, 247, 237);
            panelBusqueda.Controls.Add(txtBuscar);
            panelBusqueda.Controls.Add(iconLupa);
            panelBusqueda.Controls.Add(btnCrearLista);
            panelBusqueda.CustomizableEdges = customizableEdges9;
            panelBusqueda.Dock = DockStyle.Top;
            panelBusqueda.Location = new Point(0, 80);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Padding = new Padding(25, 15, 25, 15);
            panelBusqueda.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelBusqueda.Size = new Size(854, 80);
            panelBusqueda.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Transparent;
            txtBuscar.BorderColor = Color.FromArgb(220, 225, 235);
            txtBuscar.BorderRadius = 20;
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.CustomizableEdges = customizableEdges5;
            txtBuscar.DefaultText = "";
            txtBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.FocusedState.BorderColor = Color.FromArgb(94, 114, 228);
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.ForeColor = Color.FromArgb(64, 64, 64);
            txtBuscar.HoverState.BorderColor = Color.FromArgb(94, 114, 228);
            txtBuscar.Location = new Point(25, 15);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(45, 0, 15, 0);
            txtBuscar.PlaceholderText = "Buscar categoría...";
            txtBuscar.SelectedText = "";
            txtBuscar.ShadowDecoration.BorderRadius = 20;
            txtBuscar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtBuscar.ShadowDecoration.Depth = 5;
            txtBuscar.ShadowDecoration.Enabled = true;
            txtBuscar.Size = new Size(400, 45);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextOffset = new Point(5, 0);
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // iconLupa
            // 
            iconLupa.BackColor = Color.Transparent;
            iconLupa.ForeColor = Color.FromArgb(160, 170, 190);
            iconLupa.IconChar = IconChar.Search;
            iconLupa.IconColor = Color.FromArgb(160, 170, 190);
            iconLupa.IconFont = IconFont.Auto;
            iconLupa.IconSize = 20;
            iconLupa.Location = new Point(40, 27);
            iconLupa.Name = "iconLupa";
            iconLupa.Size = new Size(20, 22);
            iconLupa.TabIndex = 1;
            iconLupa.TabStop = false;
            // 
            // btnCrearLista
            // 
            btnCrearLista.BackColor = Color.Transparent;
            btnCrearLista.BorderRadius = 20;
            btnCrearLista.CustomizableEdges = customizableEdges7;
            btnCrearLista.DisabledState.BorderColor = Color.DarkGray;
            btnCrearLista.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCrearLista.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCrearLista.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCrearLista.FillColor = Color.FromArgb(94, 114, 228);
            btnCrearLista.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrearLista.ForeColor = Color.White;
            btnCrearLista.HoverState.FillColor = Color.FromArgb(114, 134, 248);
            btnCrearLista.Location = new Point(620, 15);
            btnCrearLista.Name = "btnCrearLista";
            btnCrearLista.ShadowDecoration.BorderRadius = 20;
            btnCrearLista.ShadowDecoration.Color = Color.FromArgb(40, 94, 114, 228);
            btnCrearLista.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCrearLista.ShadowDecoration.Enabled = true;
            btnCrearLista.ShadowDecoration.Shadow = new Padding(2, 2, 6, 6);
            btnCrearLista.Size = new Size(150, 45);
            btnCrearLista.TabIndex = 1;
            btnCrearLista.Text = "+ Crear lista";
            btnCrearLista.Click += btnCrearLista_Click;
            // 
            // flpCategorias
            // 
            flpCategorias.AutoScroll = true;
            flpCategorias.BackColor = Color.FromArgb(255, 247, 237);
            flpCategorias.Dock = DockStyle.Fill;
            flpCategorias.Location = new Point(0, 160);
            flpCategorias.Name = "flpCategorias";
            flpCategorias.Padding = new Padding(25, 15, 25, 15);
            flpCategorias.Size = new Size(854, 375);
            flpCategorias.TabIndex = 2;
            // 
            // FrmVocabulario
            // 
            BackColor = Color.FromArgb(255, 247, 237);
            ClientSize = new Size(854, 535);
            Controls.Add(flpCategorias);
            Controls.Add(panelBusqueda);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVocabulario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vocabulario";
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconLupa).EndInit();
            ResumeLayout(false);
        }
    }
}