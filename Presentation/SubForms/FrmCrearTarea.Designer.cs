using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Maestros
{
    partial class FrmCrearTarea
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelHeader;
        private System.Windows.Forms.Label accentBar;
        private Guna2HtmlLabel lblTituloHeader;
        private Guna2Panel panelContenido;
        private Guna2HtmlLabel lblTituloLbl;
        private Guna2TextBox txtTitulo;
        private Guna2HtmlLabel lblDescLbl;
        private Guna2TextBox txtDescripcion;
        private Guna2HtmlLabel lblGrupoLbl;
        private Guna2ComboBox cmbGrupo;
        private Guna2HtmlLabel lblUnidadLbl;
        private Guna2ComboBox cmbUnidad;
        private Guna2HtmlLabel lblTipoLbl;
        private Guna2ComboBox cmbTipoEntrega;
        private Guna2HtmlLabel lblAsigLbl;
        private DateTimePicker dtpAsignacion;
        private Guna2HtmlLabel lblEntregaLbl;
        private DateTimePicker dtpFechaEntrega;
        private Guna2HtmlLabel lblMaxLbl;
        private NumericUpDown numMaxScore;
        private CheckBox chkAllowLate;
        private CheckBox chkShowGrade;
        private CheckBox chkDraft;
        private Guna2Button btnCrear;
        private Guna2Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var ce1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            accentBar = new System.Windows.Forms.Label();
            panelHeader = new Guna2Panel();
            lblTituloHeader = new Guna2HtmlLabel();
            panelContenido = new Guna2Panel();
            lblTituloLbl = new Guna2HtmlLabel();
            txtTitulo = new Guna2TextBox();
            lblDescLbl = new Guna2HtmlLabel();
            txtDescripcion = new Guna2TextBox();
            lblGrupoLbl = new Guna2HtmlLabel();
            cmbGrupo = new Guna2ComboBox();
            lblUnidadLbl = new Guna2HtmlLabel();
            cmbUnidad = new Guna2ComboBox();
            lblTipoLbl = new Guna2HtmlLabel();
            cmbTipoEntrega = new Guna2ComboBox();
            lblAsigLbl = new Guna2HtmlLabel();
            dtpAsignacion = new DateTimePicker();
            lblEntregaLbl = new Guna2HtmlLabel();
            dtpFechaEntrega = new DateTimePicker();
            lblMaxLbl = new Guna2HtmlLabel();
            numMaxScore = new NumericUpDown();
            chkAllowLate = new CheckBox();
            chkShowGrade = new CheckBox();
            chkDraft = new CheckBox();
            btnCrear = new Guna2Button();
            btnCancelar = new Guna2Button();

            panelHeader.SuspendLayout();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxScore).BeginInit();
            SuspendLayout();

            Color cream = Color.FromArgb(252, 248, 240);
            Color yellow = Color.FromArgb(255, 183, 0);
            Color dark = Color.FromArgb(25, 25, 35);
            Color cLbl = Color.FromArgb(130, 120, 100);
            Font fLbl = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            Font fTxt = new Font("Segoe UI", 10.5F);

            // ════════ ACCENT BAR ════════
            accentBar.BackColor = yellow;
            accentBar.Location = new Point(0, 0);
            accentBar.Name = "accentBar";
            accentBar.Size = new Size(5, 62);
            accentBar.TabIndex = 99;
            accentBar.Text = "";

            // ════════ HEADER ════════
            lblTituloHeader.AutoSize = false;
            lblTituloHeader.BackColor = Color.Transparent;
            lblTituloHeader.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lblTituloHeader.ForeColor = dark;
            lblTituloHeader.Location = new Point(18, 16);
            lblTituloHeader.Name = "lblTituloHeader";
            lblTituloHeader.Size = new Size(300, 28);
            lblTituloHeader.TabIndex = 0;
            lblTituloHeader.Text = "Nueva Tarea";

            panelHeader.CustomizableEdges = ce1;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.White;
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(500, 62);
            panelHeader.ShadowDecoration.CustomizableEdges = ce2;
            panelHeader.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(accentBar);
            panelHeader.Controls.Add(lblTituloHeader);

            // ════════ CONTENIDO ════════
            // Título
            lblTituloLbl.AutoSize = false;
            lblTituloLbl.BackColor = Color.Transparent;
            lblTituloLbl.Font = fLbl;
            lblTituloLbl.ForeColor = cLbl;
            lblTituloLbl.Location = new Point(20, 10);
            lblTituloLbl.Name = "lblTituloLbl";
            lblTituloLbl.Size = new Size(80, 15);
            lblTituloLbl.TabIndex = 0;
            lblTituloLbl.Text = "TITULO *";

            txtTitulo.BorderRadius = 10;
            txtTitulo.CustomizableEdges = ce3;
            txtTitulo.DefaultText = "";
            txtTitulo.FillColor = Color.White;
            txtTitulo.FocusedState.BorderColor = yellow;
            txtTitulo.Font = fTxt;
            txtTitulo.Location = new Point(20, 26);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Ej: Tarea de vocabulario Unit 3";
            txtTitulo.SelectedText = "";
            txtTitulo.ShadowDecoration.CustomizableEdges = ce4;
            txtTitulo.Size = new Size(456, 36);
            txtTitulo.TabIndex = 1;

            // Descripción
            lblDescLbl.AutoSize = false;
            lblDescLbl.BackColor = Color.Transparent;
            lblDescLbl.Font = fLbl;
            lblDescLbl.ForeColor = cLbl;
            lblDescLbl.Location = new Point(20, 72);
            lblDescLbl.Name = "lblDescLbl";
            lblDescLbl.Size = new Size(100, 15);
            lblDescLbl.TabIndex = 2;
            lblDescLbl.Text = "DESCRIPCION";

            txtDescripcion.BorderRadius = 10;
            txtDescripcion.CustomizableEdges = ce5;
            txtDescripcion.DefaultText = "";
            txtDescripcion.FillColor = Color.White;
            txtDescripcion.FocusedState.BorderColor = yellow;
            txtDescripcion.Font = fTxt;
            txtDescripcion.Location = new Point(20, 88);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Instrucciones para el estudiante...";
            txtDescripcion.SelectedText = "";
            txtDescripcion.ShadowDecoration.CustomizableEdges = ce6;
            txtDescripcion.Size = new Size(456, 55);
            txtDescripcion.TabIndex = 3;

            // Grupo
            lblGrupoLbl.AutoSize = false;
            lblGrupoLbl.BackColor = Color.Transparent;
            lblGrupoLbl.Font = fLbl;
            lblGrupoLbl.ForeColor = cLbl;
            lblGrupoLbl.Location = new Point(20, 152);
            lblGrupoLbl.Name = "lblGrupoLbl";
            lblGrupoLbl.Size = new Size(60, 15);
            lblGrupoLbl.TabIndex = 4;
            lblGrupoLbl.Text = "GRUPO *";

            cmbGrupo.BackColor = Color.Transparent;
            cmbGrupo.BorderRadius = 8;
            cmbGrupo.CustomizableEdges = ce7;
            cmbGrupo.DrawMode = DrawMode.OwnerDrawFixed;
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupo.FillColor = Color.White;
            cmbGrupo.FocusedColor = yellow;
            cmbGrupo.FocusedState.BorderColor = yellow;
            cmbGrupo.Font = fTxt;
            cmbGrupo.ItemHeight = 30;
            cmbGrupo.Location = new Point(20, 168);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.ShadowDecoration.CustomizableEdges = ce8;
            cmbGrupo.Size = new Size(220, 36);
            cmbGrupo.TabIndex = 5;

            // Unidad
            lblUnidadLbl.AutoSize = false;
            lblUnidadLbl.BackColor = Color.Transparent;
            lblUnidadLbl.Font = fLbl;
            lblUnidadLbl.ForeColor = cLbl;
            lblUnidadLbl.Location = new Point(250, 152);
            lblUnidadLbl.Name = "lblUnidadLbl";
            lblUnidadLbl.Size = new Size(60, 15);
            lblUnidadLbl.TabIndex = 6;
            lblUnidadLbl.Text = "UNIDAD";

            cmbUnidad.BackColor = Color.Transparent;
            cmbUnidad.BorderRadius = 8;
            cmbUnidad.CustomizableEdges = ce9;
            cmbUnidad.DrawMode = DrawMode.OwnerDrawFixed;
            cmbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidad.FillColor = Color.White;
            cmbUnidad.FocusedColor = yellow;
            cmbUnidad.FocusedState.BorderColor = yellow;
            cmbUnidad.Font = fTxt;
            cmbUnidad.ItemHeight = 30;
            cmbUnidad.Location = new Point(250, 168);
            cmbUnidad.Name = "cmbUnidad";
            cmbUnidad.ShadowDecoration.CustomizableEdges = ce10;
            cmbUnidad.Size = new Size(226, 36);
            cmbUnidad.TabIndex = 7;

            // Tipo
            lblTipoLbl.AutoSize = false;
            lblTipoLbl.BackColor = Color.Transparent;
            lblTipoLbl.Font = fLbl;
            lblTipoLbl.ForeColor = cLbl;
            lblTipoLbl.Location = new Point(20, 214);
            lblTipoLbl.Name = "lblTipoLbl";
            lblTipoLbl.Size = new Size(120, 15);
            lblTipoLbl.TabIndex = 8;
            lblTipoLbl.Text = "TIPO DE ENTREGA";

            cmbTipoEntrega.BackColor = Color.Transparent;
            cmbTipoEntrega.BorderRadius = 8;
            cmbTipoEntrega.CustomizableEdges = ce11;
            cmbTipoEntrega.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEntrega.FillColor = Color.White;
            cmbTipoEntrega.FocusedColor = yellow;
            cmbTipoEntrega.FocusedState.BorderColor = yellow;
            cmbTipoEntrega.Font = fTxt;
            cmbTipoEntrega.ItemHeight = 30;
            cmbTipoEntrega.Location = new Point(20, 230);
            cmbTipoEntrega.Name = "cmbTipoEntrega";
            cmbTipoEntrega.ShadowDecoration.CustomizableEdges = ce12;
            cmbTipoEntrega.Size = new Size(150, 36);
            cmbTipoEntrega.TabIndex = 9;

            // Fechas
            lblAsigLbl.AutoSize = false;
            lblAsigLbl.BackColor = Color.Transparent;
            lblAsigLbl.Font = fLbl;
            lblAsigLbl.ForeColor = cLbl;
            lblAsigLbl.Location = new Point(20, 278);
            lblAsigLbl.Name = "lblAsigLbl";
            lblAsigLbl.Size = new Size(130, 15);
            lblAsigLbl.TabIndex = 10;
            lblAsigLbl.Text = "FECHA ASIGNACION";

            dtpAsignacion.Font = fTxt;
            dtpAsignacion.Format = DateTimePickerFormat.Short;
            dtpAsignacion.Location = new Point(20, 294);
            dtpAsignacion.Name = "dtpAsignacion";
            dtpAsignacion.Size = new Size(138, 28);
            dtpAsignacion.TabIndex = 11;

            lblEntregaLbl.AutoSize = false;
            lblEntregaLbl.BackColor = Color.Transparent;
            lblEntregaLbl.Font = fLbl;
            lblEntregaLbl.ForeColor = cLbl;
            lblEntregaLbl.Location = new Point(180, 278);
            lblEntregaLbl.Name = "lblEntregaLbl";
            lblEntregaLbl.Size = new Size(140, 15);
            lblEntregaLbl.TabIndex = 12;
            lblEntregaLbl.Text = "FECHA DE ENTREGA *";

            dtpFechaEntrega.Font = fTxt;
            dtpFechaEntrega.Format = DateTimePickerFormat.Short;
            dtpFechaEntrega.Location = new Point(180, 294);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(138, 28);
            dtpFechaEntrega.TabIndex = 13;

            lblMaxLbl.AutoSize = false;
            lblMaxLbl.BackColor = Color.Transparent;
            lblMaxLbl.Font = fLbl;
            lblMaxLbl.ForeColor = cLbl;
            lblMaxLbl.Location = new Point(340, 278);
            lblMaxLbl.Name = "lblMaxLbl";
            lblMaxLbl.Size = new Size(120, 15);
            lblMaxLbl.TabIndex = 14;
            lblMaxLbl.Text = "PUNTUACION MAX.";

            numMaxScore.Font = fTxt;
            numMaxScore.Location = new Point(340, 294);
            numMaxScore.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMaxScore.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMaxScore.Name = "numMaxScore";
            numMaxScore.Size = new Size(100, 28);
            numMaxScore.TabIndex = 15;
            numMaxScore.Value = new decimal(new int[] { 100, 0, 0, 0 });

            // Checks
            chkAllowLate.AutoSize = true;
            chkAllowLate.Font = fTxt;
            chkAllowLate.ForeColor = dark;
            chkAllowLate.Location = new Point(20, 336);
            chkAllowLate.Name = "chkAllowLate";
            chkAllowLate.Size = new Size(165, 23);
            chkAllowLate.TabIndex = 16;
            chkAllowLate.Text = "Permitir entrega tardia";

            chkShowGrade.AutoSize = true;
            chkShowGrade.Checked = true;
            chkShowGrade.CheckState = CheckState.Checked;
            chkShowGrade.Font = fTxt;
            chkShowGrade.ForeColor = dark;
            chkShowGrade.Location = new Point(220, 336);
            chkShowGrade.Name = "chkShowGrade";
            chkShowGrade.Size = new Size(145, 23);
            chkShowGrade.TabIndex = 17;
            chkShowGrade.Text = "Mostrar calificacion";

            chkDraft.AutoSize = true;
            chkDraft.Font = fTxt;
            chkDraft.ForeColor = cLbl;
            chkDraft.Location = new Point(20, 364);
            chkDraft.Name = "chkDraft";
            chkDraft.Size = new Size(174, 23);
            chkDraft.TabIndex = 18;
            chkDraft.Text = "Guardar como borrador";

            // Botones
            btnCrear.BorderRadius = 18;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.CustomizableEdges = ce13;
            btnCrear.FillColor = yellow;
            btnCrear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.HoverState.FillColor = Color.FromArgb(220, 155, 0);
            btnCrear.Location = new Point(20, 398);
            btnCrear.Name = "btnCrear";
            btnCrear.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCrear.ShadowDecoration.Color = Color.FromArgb(40, 255, 183, 0);
            btnCrear.ShadowDecoration.Depth = 6;
            btnCrear.ShadowDecoration.Enabled = true;
            btnCrear.Size = new Size(215, 42);
            btnCrear.TabIndex = 19;
            btnCrear.Text = "Crear Tarea";
            btnCrear.Click += new System.EventHandler(btnCrear_Click);

            btnCancelar.BorderRadius = 18;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.CustomizableEdges = ce14;
            btnCancelar.FillColor = Color.FromArgb(240, 232, 215);
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(120, 100, 70);
            btnCancelar.HoverState.FillColor = Color.FromArgb(225, 215, 195);
            btnCancelar.Location = new Point(250, 398);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCancelar.Size = new Size(215, 42);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += new System.EventHandler(btnCancelar_Click);

            // Panel contenido
            panelContenido.AutoScroll = true;
            panelContenido.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelContenido.FillColor = cream;
            panelContenido.Location = new Point(0, 62);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(500, 396);
            panelContenido.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelContenido.TabIndex = 1;

            panelContenido.Controls.Add(lblTituloLbl);
            panelContenido.Controls.Add(txtTitulo);
            panelContenido.Controls.Add(lblDescLbl);
            panelContenido.Controls.Add(txtDescripcion);
            panelContenido.Controls.Add(lblGrupoLbl);
            panelContenido.Controls.Add(cmbGrupo);
            panelContenido.Controls.Add(lblUnidadLbl);
            panelContenido.Controls.Add(cmbUnidad);
            panelContenido.Controls.Add(lblTipoLbl);
            panelContenido.Controls.Add(cmbTipoEntrega);
            panelContenido.Controls.Add(lblAsigLbl);
            panelContenido.Controls.Add(dtpAsignacion);
            panelContenido.Controls.Add(lblEntregaLbl);
            panelContenido.Controls.Add(dtpFechaEntrega);
            panelContenido.Controls.Add(lblMaxLbl);
            panelContenido.Controls.Add(numMaxScore);
            panelContenido.Controls.Add(chkAllowLate);
            panelContenido.Controls.Add(chkShowGrade);
            panelContenido.Controls.Add(chkDraft);
            panelContenido.Controls.Add(btnCrear);
            panelContenido.Controls.Add(btnCancelar);

            // ════════ FORM ════════
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = cream;
            ClientSize = new Size(500, 458);
            Controls.Add(panelHeader);
            Controls.Add(panelContenido);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCrearTarea";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva Tarea";
            Load += new System.EventHandler(FrmCrearTarea_Load);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxScore).EndInit();
            ResumeLayout(false);
        }
    }
}