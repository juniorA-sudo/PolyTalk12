using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Maestros
{
    partial class FrmCrearTarea
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelContenido;
        private Guna2HtmlLabel lblTitulo;
        private Guna2HtmlLabel lblTituloLabel;
        private Guna2TextBox txtTitulo;
        private Guna2HtmlLabel lblDescripcion;
        private Guna2TextBox txtDescripcion;
        private Guna2HtmlLabel lblGrupo;
        private Guna2ComboBox cmbGrupo;
        private Guna2HtmlLabel lblUnidad;
        private Guna2ComboBox cmbUnidad;
        private Guna2HtmlLabel lblTipoEntrega;
        private Guna2ComboBox cmbTipoEntrega;
        private Guna2HtmlLabel lblAsignacion;
        private DateTimePicker dtpAsignacion;
        private Guna2HtmlLabel lblFechaEntrega;
        private DateTimePicker dtpFechaEntrega;
        private Guna2HtmlLabel lblMaxScore;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges ce1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            panelContenido = new Guna2Panel();
            lblTitulo = new Guna2HtmlLabel();
            lblTituloLabel = new Guna2HtmlLabel();
            txtTitulo = new Guna2TextBox();
            lblDescripcion = new Guna2HtmlLabel();
            txtDescripcion = new Guna2TextBox();
            lblGrupo = new Guna2HtmlLabel();
            cmbGrupo = new Guna2ComboBox();
            lblUnidad = new Guna2HtmlLabel();
            cmbUnidad = new Guna2ComboBox();
            lblTipoEntrega = new Guna2HtmlLabel();
            cmbTipoEntrega = new Guna2ComboBox();
            lblAsignacion = new Guna2HtmlLabel();
            dtpAsignacion = new DateTimePicker();
            lblFechaEntrega = new Guna2HtmlLabel();
            dtpFechaEntrega = new DateTimePicker();
            lblMaxScore = new Guna2HtmlLabel();
            numMaxScore = new NumericUpDown();
            chkAllowLate = new CheckBox();
            chkShowGrade = new CheckBox();
            chkDraft = new CheckBox();
            btnCrear = new Guna2Button();
            btnCancelar = new Guna2Button();

            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxScore).BeginInit();
            SuspendLayout();

            // ✅ panelContenido — ocupa todo el form, sin padding exterior
            panelContenido.BackColor = Color.White;
            panelContenido.BorderRadius = 0;
            panelContenido.Controls.Add(lblTitulo);
            panelContenido.Controls.Add(lblTituloLabel);
            panelContenido.Controls.Add(txtTitulo);
            panelContenido.Controls.Add(lblDescripcion);
            panelContenido.Controls.Add(txtDescripcion);
            panelContenido.Controls.Add(lblGrupo);
            panelContenido.Controls.Add(cmbGrupo);
            panelContenido.Controls.Add(lblUnidad);
            panelContenido.Controls.Add(cmbUnidad);
            panelContenido.Controls.Add(lblTipoEntrega);
            panelContenido.Controls.Add(cmbTipoEntrega);
            panelContenido.Controls.Add(lblAsignacion);
            panelContenido.Controls.Add(dtpAsignacion);
            panelContenido.Controls.Add(lblFechaEntrega);
            panelContenido.Controls.Add(dtpFechaEntrega);
            panelContenido.Controls.Add(lblMaxScore);
            panelContenido.Controls.Add(numMaxScore);
            panelContenido.Controls.Add(chkAllowLate);
            panelContenido.Controls.Add(chkShowGrade);
            panelContenido.Controls.Add(chkDraft);
            panelContenido.Controls.Add(btnCrear);
            panelContenido.Controls.Add(btnCancelar);
            panelContenido.CustomizableEdges = ce1;
            panelContenido.Dock = DockStyle.Fill; // ✅ ocupa todo el form
            panelContenido.FillColor = Color.White;
            panelContenido.Location = new Point(0, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(20);
            panelContenido.ShadowDecoration.CustomizableEdges = ce2;
            panelContenido.Size = new Size(510, 570);
            panelContenido.TabIndex = 0;

            // lblTitulo
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(45, 55, 72);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "➕ Nueva Tarea";

            // lblTituloLabel
            lblTituloLabel.BackColor = Color.Transparent;
            lblTituloLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTituloLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblTituloLabel.Location = new Point(20, 55);
            lblTituloLabel.Name = "lblTituloLabel";
            lblTituloLabel.Size = new Size(50, 17);
            lblTituloLabel.TabIndex = 1;
            lblTituloLabel.Text = "Título *";

            // txtTitulo
            txtTitulo.BorderRadius = 8;
            txtTitulo.CustomizableEdges = ce3;
            txtTitulo.DefaultText = "";
            txtTitulo.FillColor = Color.FromArgb(247, 250, 252);
            txtTitulo.Font = new Font("Segoe UI", 11F);
            txtTitulo.ForeColor = Color.FromArgb(45, 55, 72);
            txtTitulo.Location = new Point(20, 74);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Ej: Tarea de vocabulario - Unit 3";
            txtTitulo.SelectedText = "";
            txtTitulo.ShadowDecoration.CustomizableEdges = ce4;
            txtTitulo.Size = new Size(468, 36);
            txtTitulo.TabIndex = 2;

            // lblDescripcion
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.FromArgb(113, 128, 150);
            lblDescripcion.Location = new Point(20, 118);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(70, 17);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";

            // txtDescripcion
            txtDescripcion.BorderRadius = 8;
            txtDescripcion.CustomizableEdges = ce5;
            txtDescripcion.DefaultText = "";
            txtDescripcion.FillColor = Color.FromArgb(247, 250, 252);
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = Color.FromArgb(45, 55, 72);
            txtDescripcion.Location = new Point(20, 138);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Instrucciones para los estudiantes...";
            txtDescripcion.SelectedText = "";
            txtDescripcion.ShadowDecoration.CustomizableEdges = ce6;
            txtDescripcion.Size = new Size(468, 55);
            txtDescripcion.TabIndex = 4;

            // lblGrupo
            lblGrupo.BackColor = Color.Transparent;
            lblGrupo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGrupo.ForeColor = Color.FromArgb(113, 128, 150);
            lblGrupo.Location = new Point(20, 202);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(50, 17);
            lblGrupo.TabIndex = 5;
            lblGrupo.Text = "Grupo *";

            // cmbGrupo
            cmbGrupo.BackColor = Color.Transparent;
            cmbGrupo.BorderRadius = 8;
            cmbGrupo.CustomizableEdges = ce7;
            cmbGrupo.DrawMode = DrawMode.OwnerDrawFixed;
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupo.FillColor = Color.FromArgb(247, 250, 252);
            cmbGrupo.FocusedColor = Color.FromArgb(102, 126, 234);
            cmbGrupo.FocusedState.BorderColor = Color.FromArgb(102, 126, 234);
            cmbGrupo.Font = new Font("Segoe UI", 10F);
            cmbGrupo.ForeColor = Color.FromArgb(45, 55, 72);
            cmbGrupo.ItemHeight = 30;
            cmbGrupo.Location = new Point(20, 222);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.ShadowDecoration.CustomizableEdges = ce8;
            cmbGrupo.Size = new Size(220, 36);
            cmbGrupo.TabIndex = 6;

            // lblUnidad
            lblUnidad.BackColor = Color.Transparent;
            lblUnidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUnidad.ForeColor = Color.FromArgb(113, 128, 150);
            lblUnidad.Location = new Point(255, 202);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(45, 17);
            lblUnidad.TabIndex = 7;
            lblUnidad.Text = "Unidad";

            // cmbUnidad
            cmbUnidad.BackColor = Color.Transparent;
            cmbUnidad.BorderRadius = 8;
            cmbUnidad.CustomizableEdges = ce9;
            cmbUnidad.DrawMode = DrawMode.OwnerDrawFixed;
            cmbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidad.FillColor = Color.FromArgb(247, 250, 252);
            cmbUnidad.FocusedColor = Color.FromArgb(102, 126, 234);
            cmbUnidad.FocusedState.BorderColor = Color.FromArgb(102, 126, 234);
            cmbUnidad.Font = new Font("Segoe UI", 10F);
            cmbUnidad.ForeColor = Color.FromArgb(45, 55, 72);
            cmbUnidad.ItemHeight = 30;
            cmbUnidad.Location = new Point(255, 222);
            cmbUnidad.Name = "cmbUnidad";
            cmbUnidad.ShadowDecoration.CustomizableEdges = ce10;
            cmbUnidad.Size = new Size(233, 36);
            cmbUnidad.TabIndex = 8;

            // lblTipoEntrega
            lblTipoEntrega.BackColor = Color.Transparent;
            lblTipoEntrega.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipoEntrega.ForeColor = Color.FromArgb(113, 128, 150);
            lblTipoEntrega.Location = new Point(20, 268);
            lblTipoEntrega.Name = "lblTipoEntrega";
            lblTipoEntrega.Size = new Size(95, 17);
            lblTipoEntrega.TabIndex = 9;
            lblTipoEntrega.Text = "Tipo de entrega";

            // cmbTipoEntrega
            cmbTipoEntrega.BackColor = Color.Transparent;
            cmbTipoEntrega.BorderRadius = 8;
            cmbTipoEntrega.CustomizableEdges = ce11;
            cmbTipoEntrega.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEntrega.FillColor = Color.FromArgb(247, 250, 252);
            cmbTipoEntrega.FocusedColor = Color.FromArgb(102, 126, 234);
            cmbTipoEntrega.FocusedState.BorderColor = Color.FromArgb(102, 126, 234);
            cmbTipoEntrega.Font = new Font("Segoe UI", 10F);
            cmbTipoEntrega.ForeColor = Color.FromArgb(45, 55, 72);
            cmbTipoEntrega.ItemHeight = 30;
            cmbTipoEntrega.Location = new Point(20, 288);
            cmbTipoEntrega.Name = "cmbTipoEntrega";
            cmbTipoEntrega.ShadowDecoration.CustomizableEdges = ce12;
            cmbTipoEntrega.Size = new Size(150, 36);
            cmbTipoEntrega.TabIndex = 10;

            // lblAsignacion
            lblAsignacion.BackColor = Color.Transparent;
            lblAsignacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAsignacion.ForeColor = Color.FromArgb(113, 128, 150);
            lblAsignacion.Location = new Point(20, 334);
            lblAsignacion.Name = "lblAsignacion";
            lblAsignacion.Size = new Size(100, 17);
            lblAsignacion.TabIndex = 11;
            lblAsignacion.Text = "Fecha asignación";

            // dtpAsignacion
            dtpAsignacion.Font = new Font("Segoe UI", 10F);
            dtpAsignacion.Format = DateTimePickerFormat.Short;
            dtpAsignacion.Location = new Point(20, 354);
            dtpAsignacion.Name = "dtpAsignacion";
            dtpAsignacion.Size = new Size(145, 25);
            dtpAsignacion.TabIndex = 12;

            // lblFechaEntrega
            lblFechaEntrega.BackColor = Color.Transparent;
            lblFechaEntrega.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaEntrega.ForeColor = Color.FromArgb(113, 128, 150);
            lblFechaEntrega.Location = new Point(185, 334);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(110, 17);
            lblFechaEntrega.TabIndex = 13;
            lblFechaEntrega.Text = "Fecha de entrega *";

            // dtpFechaEntrega
            dtpFechaEntrega.Font = new Font("Segoe UI", 10F);
            dtpFechaEntrega.Format = DateTimePickerFormat.Short;
            dtpFechaEntrega.Location = new Point(185, 354);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(145, 25);
            dtpFechaEntrega.TabIndex = 14;

            // lblMaxScore
            lblMaxScore.BackColor = Color.Transparent;
            lblMaxScore.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaxScore.ForeColor = Color.FromArgb(113, 128, 150);
            lblMaxScore.Location = new Point(350, 334);
            lblMaxScore.Name = "lblMaxScore";
            lblMaxScore.Size = new Size(100, 17);
            lblMaxScore.TabIndex = 15;
            lblMaxScore.Text = "Puntuación máx.";

            // numMaxScore
            numMaxScore.Font = new Font("Segoe UI", 11F);
            numMaxScore.Location = new Point(350, 354);
            numMaxScore.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMaxScore.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMaxScore.Name = "numMaxScore";
            numMaxScore.Size = new Size(100, 27);
            numMaxScore.TabIndex = 16;
            numMaxScore.Value = new decimal(new int[] { 100, 0, 0, 0 });

            // chkAllowLate
            chkAllowLate.AutoSize = true;
            chkAllowLate.Font = new Font("Segoe UI", 10F);
            chkAllowLate.ForeColor = Color.FromArgb(45, 55, 72);
            chkAllowLate.Location = new Point(20, 398);
            chkAllowLate.Name = "chkAllowLate";
            chkAllowLate.Size = new Size(165, 23);
            chkAllowLate.TabIndex = 17;
            chkAllowLate.Text = "Permitir entrega tardía";

            // chkShowGrade
            chkShowGrade.AutoSize = true;
            chkShowGrade.Checked = true;
            chkShowGrade.CheckState = CheckState.Checked;
            chkShowGrade.Font = new Font("Segoe UI", 10F);
            chkShowGrade.ForeColor = Color.FromArgb(45, 55, 72);
            chkShowGrade.Location = new Point(220, 398);
            chkShowGrade.Name = "chkShowGrade";
            chkShowGrade.Size = new Size(145, 23);
            chkShowGrade.TabIndex = 18;
            chkShowGrade.Text = "Mostrar calificación";

            // chkDraft
            chkDraft.AutoSize = true;
            chkDraft.Font = new Font("Segoe UI", 10F);
            chkDraft.ForeColor = Color.FromArgb(113, 128, 150);
            chkDraft.Location = new Point(20, 428);
            chkDraft.Name = "chkDraft";
            chkDraft.Size = new Size(174, 23);
            chkDraft.TabIndex = 19;
            chkDraft.Text = "Guardar como borrador";

            // btnCrear
            btnCrear.BorderRadius = 10;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCrear.FillColor = Color.FromArgb(102, 126, 234);
            btnCrear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.HoverState.FillColor = Color.FromArgb(92, 116, 224);
            btnCrear.Location = new Point(20, 465);
            btnCrear.Name = "btnCrear";
            btnCrear.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCrear.Size = new Size(220, 45);
            btnCrear.TabIndex = 20;
            btnCrear.Text = "✅ Crear Tarea";
            btnCrear.Click += btnCrear_Click;

            // btnCancelar
            btnCancelar.BorderRadius = 10;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCancelar.FillColor = Color.FromArgb(247, 250, 252);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(113, 128, 150);
            btnCancelar.HoverState.FillColor = Color.FromArgb(237, 242, 247);
            btnCancelar.Location = new Point(258, 465);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCancelar.Size = new Size(220, 45);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;

            // ✅ FrmCrearTarea — mismo tamaño que el panel, sin espacio extra
            BackColor = Color.White;
            ClientSize = new Size(510, 520);
            Controls.Add(panelContenido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrearTarea";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva Tarea";
            Load += FrmCrearTarea_Load;

            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxScore).EndInit();
            ResumeLayout(false);
        }
    }
}