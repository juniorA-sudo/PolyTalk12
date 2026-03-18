using Guna.UI2.WinForms;

namespace Presentation
{
    partial class FrmGestionarVocabulario
    {
        private System.ComponentModel.IContainer components = null;

        // Controles Guna UI
        private Guna2Panel panelHeader;
        private Guna2PictureBox iconoLibro;
        private Guna2HtmlLabel lblTitulo;
        private Guna2HtmlLabel lblEstadisticas;
        private Guna2Button btnAgregar;
        private Guna2Button btnEditar;
        private Guna2Button btnEliminar;
        private Guna2Button btnVolver;
        private Guna2Button btnCerrar;
        private Guna2Panel panelBusqueda;
        private Guna2TextBox txtBuscar;
        private Guna2ComboBox cmbFiltro;
        private Guna2Button btnBuscar;
        private Guna2DataGridView dgvPalabras;
        private Guna2Panel panelFooter;
        private Guna2HtmlLabel lblInfoFooter;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarVocabulario));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Guna2Panel();
            btnVolver = new Guna2Button();
            iconoLibro = new Guna2PictureBox();
            lblTitulo = new Guna2HtmlLabel();
            lblEstadisticas = new Guna2HtmlLabel();
            btnAgregar = new Guna2Button();
            btnEditar = new Guna2Button();
            btnEliminar = new Guna2Button();
            panelBusqueda = new Guna2Panel();
            txtBuscar = new Guna2TextBox();
            cmbFiltro = new Guna2ComboBox();
            btnBuscar = new Guna2Button();
            dgvPalabras = new Guna2DataGridView();
            panelFooter = new Guna2Panel();
            lblInfoFooter = new Guna2HtmlLabel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconoLibro).BeginInit();
            panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPalabras).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Controls.Add(btnVolver);
            panelHeader.Controls.Add(iconoLibro);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblEstadisticas);
            panelHeader.Controls.Add(btnAgregar);
            panelHeader.Controls.Add(btnEditar);
            panelHeader.Controls.Add(btnEliminar);
            panelHeader.CustomizableEdges = customizableEdges11;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelHeader.Size = new Size(854, 85);
            panelHeader.TabIndex = 0;
            panelHeader.UseTransparentBackground = true;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(100, 100, 100);
            btnVolver.BorderRadius = 5;
            btnVolver.CustomizableEdges = customizableEdges1;
            btnVolver.DisabledState.BorderColor = Color.DarkGray;
            btnVolver.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVolver.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVolver.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVolver.FillColor = Color.FromArgb(100, 100, 100);
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(399, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnVolver.Size = new Size(80, 30);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "← Volver";
            // 
            // iconoLibro
            // 
            iconoLibro.BackColor = Color.Transparent;
            iconoLibro.CustomizableEdges = customizableEdges3;
            iconoLibro.Image = (Image)resources.GetObject("iconoLibro.Image");
            iconoLibro.ImageRotate = 0F;
            iconoLibro.Location = new Point(20, 20);
            iconoLibro.Name = "iconoLibro";
            iconoLibro.ShadowDecoration.CustomizableEdges = customizableEdges4;
            iconoLibro.Size = new Size(40, 40);
            iconoLibro.SizeMode = PictureBoxSizeMode.StretchImage;
            iconoLibro.TabIndex = 6;
            iconoLibro.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 82, 180);
            lblTitulo.Location = new Point(70, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Vocabulario: Movie Vocabulary";
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = false;
            lblEstadisticas.BackColor = Color.Transparent;
            lblEstadisticas.Font = new Font("Segoe UI", 9F);
            lblEstadisticas.ForeColor = Color.Gray;
            lblEstadisticas.Location = new Point(70, 50);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(250, 20);
            lblEstadisticas.TabIndex = 1;
            lblEstadisticas.Text = "0 palabras • 0 con imagen • 0 con audio";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 82, 180);
            btnAgregar.BorderRadius = 5;
            btnAgregar.CustomizableEdges = customizableEdges5;
            btnAgregar.DisabledState.BorderColor = Color.DarkGray;
            btnAgregar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregar.FillColor = Color.FromArgb(0, 82, 180);
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(504, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "➕ Agregar";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(52, 152, 219);
            btnEditar.BorderRadius = 5;
            btnEditar.CustomizableEdges = customizableEdges7;
            btnEditar.DisabledState.BorderColor = Color.DarkGray;
            btnEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditar.FillColor = Color.FromArgb(52, 152, 219);
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(742, 25);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "✏️ Editar";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.BorderRadius = 5;
            btnEliminar.CustomizableEdges = customizableEdges9;
            btnEliminar.DisabledState.BorderColor = Color.DarkGray;
            btnEliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEliminar.FillColor = Color.FromArgb(231, 76, 60);
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(627, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "🗑️ Eliminar";
            // 
            // panelBusqueda
            // 
            panelBusqueda.BackColor = Color.FromArgb(240, 242, 245);
            panelBusqueda.Controls.Add(txtBuscar);
            panelBusqueda.Controls.Add(cmbFiltro);
            panelBusqueda.Controls.Add(btnBuscar);
            panelBusqueda.CustomizableEdges = customizableEdges19;
            panelBusqueda.Dock = DockStyle.Top;
            panelBusqueda.Location = new Point(0, 85);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.ShadowDecoration.CustomizableEdges = customizableEdges20;
            panelBusqueda.Size = new Size(854, 50);
            panelBusqueda.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderRadius = 5;
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.CustomizableEdges = customizableEdges13;
            txtBuscar.DefaultText = "";
            txtBuscar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscar.Font = new Font("Segoe UI", 9F);
            txtBuscar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscar.Location = new Point(12, 12);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar palabra...";
            txtBuscar.SelectedText = "";
            txtBuscar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtBuscar.Size = new Size(200, 30);
            txtBuscar.TabIndex = 0;
            // 
            // cmbFiltro
            // 
            cmbFiltro.BackColor = Color.Transparent;
            cmbFiltro.BorderRadius = 5;
            cmbFiltro.CustomizableEdges = customizableEdges15;
            cmbFiltro.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbFiltro.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbFiltro.Font = new Font("Segoe UI", 10F);
            cmbFiltro.ForeColor = Color.FromArgb(68, 88, 112);
            cmbFiltro.ItemHeight = 30;
            cmbFiltro.Items.AddRange(new object[] { "Todas", "Con imagen", "Sin imagen", "Con audio", "Sin audio" });
            cmbFiltro.Location = new Point(227, 6);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.ShadowDecoration.CustomizableEdges = customizableEdges16;
            cmbFiltro.Size = new Size(120, 36);
            cmbFiltro.StartIndex = 0;
            cmbFiltro.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 82, 180);
            btnBuscar.BorderRadius = 5;
            btnBuscar.CustomizableEdges = customizableEdges17;
            btnBuscar.DisabledState.BorderColor = Color.DarkGray;
            btnBuscar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuscar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuscar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuscar.FillColor = Color.FromArgb(0, 82, 180);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(358, 9);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnBuscar.Size = new Size(90, 30);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "🔍 Buscar";
            // 
            // dgvPalabras
            // 
            dgvPalabras.AllowUserToAddRows = false;
            dgvPalabras.AllowUserToDeleteRows = false;
            dgvPalabras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvPalabras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 82, 180);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPalabras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPalabras.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPalabras.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPalabras.Dock = DockStyle.Fill;
            dgvPalabras.GridColor = Color.FromArgb(231, 229, 255);
            dgvPalabras.Location = new Point(0, 135);
            dgvPalabras.MultiSelect = false;
            dgvPalabras.Name = "dgvPalabras";
            dgvPalabras.ReadOnly = true;
            dgvPalabras.RowHeadersVisible = false;
            dgvPalabras.RowHeadersWidth = 51;
            dgvPalabras.RowTemplate.Height = 30;
            dgvPalabras.Size = new Size(854, 360);
            dgvPalabras.TabIndex = 2;
            dgvPalabras.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPalabras.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvPalabras.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvPalabras.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvPalabras.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvPalabras.ThemeStyle.BackColor = Color.White;
            dgvPalabras.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvPalabras.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 82, 180);
            dgvPalabras.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPalabras.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvPalabras.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPalabras.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPalabras.ThemeStyle.HeaderStyle.Height = 35;
            dgvPalabras.ThemeStyle.ReadOnly = true;
            dgvPalabras.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvPalabras.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPalabras.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPalabras.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvPalabras.ThemeStyle.RowsStyle.Height = 30;
            dgvPalabras.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvPalabras.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.White;
            panelFooter.Controls.Add(lblInfoFooter);
            panelFooter.CustomizableEdges = customizableEdges21;
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 495);
            panelFooter.Name = "panelFooter";
            panelFooter.ShadowDecoration.CustomizableEdges = customizableEdges22;
            panelFooter.Size = new Size(854, 40);
            panelFooter.TabIndex = 3;
            // 
            // lblInfoFooter
            // 
            lblInfoFooter.AutoSize = false;
            lblInfoFooter.BackColor = Color.Transparent;
            lblInfoFooter.Font = new Font("Segoe UI", 9F);
            lblInfoFooter.ForeColor = Color.Gray;
            lblInfoFooter.Location = new Point(70, 12);
            lblInfoFooter.Name = "lblInfoFooter";
            lblInfoFooter.Size = new Size(300, 20);
            lblInfoFooter.TabIndex = 0;
            lblInfoFooter.Text = "Haz doble clic en una palabra para editarla";
            // 
            // FrmGestionarVocabulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(854, 535);
            Controls.Add(dgvPalabras);
            Controls.Add(panelBusqueda);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionarVocabulario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestionar Vocabulario";
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconoLibro).EndInit();
            panelBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPalabras).EndInit();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}