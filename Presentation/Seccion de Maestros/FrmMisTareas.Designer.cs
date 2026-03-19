using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Maestros
{
    partial class FrmMisTareas
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelPrincipal;
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTitulo;
        private Guna2HtmlLabel lblTotalTareas;
        private Guna2Button btnNuevaTarea;
        private Guna2Panel panelIzquierdo;
        private Guna2DataGridView dgvTareas;
        private Guna2Panel panelDerecho;
        private Guna2Panel panelInfoTarea;
        private Guna2HtmlLabel lblTituloTarea;
        private Guna2HtmlLabel lblGrupoTarea;
        private Guna2HtmlLabel lblFechaTarea;
        private Guna2HtmlLabel lblTotalEntregas;
        private Guna2DataGridView dgvEntregas;
        private Guna2Panel panelCalificar;
        private Guna2HtmlLabel lblEstudianteNombre;
        private Guna2HtmlLabel lblArchivoEntregado;
        private Guna2HtmlLabel lblComentarioLabel;
        private Guna2TextBox txtComentarioEstudiante;
        private Guna2HtmlLabel lblNota;
        private Guna2TextBox txtCalificacion;
        private Guna2HtmlLabel lblFeedbackLabel;
        private Guna2TextBox txtFeedback;
        private Guna2Button btnCalificar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelPrincipal = new Guna2Panel();
            panelHeader = new Guna2Panel();
            lblTitulo = new Guna2HtmlLabel();
            lblTotalTareas = new Guna2HtmlLabel();
            btnNuevaTarea = new Guna2Button();
            panelIzquierdo = new Guna2Panel();
            dgvTareas = new Guna2DataGridView();
            panelDerecho = new Guna2Panel();
            panelInfoTarea = new Guna2Panel();
            lblTituloTarea = new Guna2HtmlLabel();
            lblGrupoTarea = new Guna2HtmlLabel();
            lblFechaTarea = new Guna2HtmlLabel();
            lblTotalEntregas = new Guna2HtmlLabel();
            dgvEntregas = new Guna2DataGridView();
            panelCalificar = new Guna2Panel();
            lblEstudianteNombre = new Guna2HtmlLabel();
            lblArchivoEntregado = new Guna2HtmlLabel();
            lblComentarioLabel = new Guna2HtmlLabel();
            txtComentarioEstudiante = new Guna2TextBox();
            lblNota = new Guna2HtmlLabel();
            txtCalificacion = new Guna2TextBox();
            lblFeedbackLabel = new Guna2HtmlLabel();
            txtFeedback = new Guna2TextBox();
            btnCalificar = new Guna2Button();
            panelPrincipal.SuspendLayout();
            panelHeader.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            panelDerecho.SuspendLayout();
            panelInfoTarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).BeginInit();
            panelCalificar.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 247, 237);
            panelPrincipal.Controls.Add(panelHeader);
            panelPrincipal.Controls.Add(panelIzquierdo);
            panelPrincipal.Controls.Add(panelDerecho);
            panelPrincipal.CustomizableEdges = customizableEdges21;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.FillColor = Color.Transparent;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(15);
            panelPrincipal.ShadowDecoration.CustomizableEdges = customizableEdges22;
            panelPrincipal.Size = new Size(854, 535);
            panelPrincipal.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.BorderRadius = 12;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblTotalTareas);
            panelHeader.Controls.Add(btnNuevaTarea);
            panelHeader.CustomizableEdges = customizableEdges3;
            panelHeader.FillColor = Color.FromArgb(102, 126, 234);
            panelHeader.Location = new Point(15, 15);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(824, 55);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(15, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(140, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "📋 Mis Tareas";
            // 
            // lblTotalTareas
            // 
            lblTotalTareas.BackColor = Color.Transparent;
            lblTotalTareas.Font = new Font("Segoe UI", 10F);
            lblTotalTareas.ForeColor = Color.FromArgb(220, 230, 255);
            lblTotalTareas.Location = new Point(220, 17);
            lblTotalTareas.Name = "lblTotalTareas";
            lblTotalTareas.Size = new Size(50, 19);
            lblTotalTareas.TabIndex = 1;
            lblTotalTareas.Text = "0 tareas";
            // 
            // btnNuevaTarea
            // 
            btnNuevaTarea.BorderRadius = 8;
            btnNuevaTarea.Cursor = Cursors.Hand;
            btnNuevaTarea.CustomizableEdges = customizableEdges1;
            btnNuevaTarea.FillColor = Color.FromArgb(72, 187, 120);
            btnNuevaTarea.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevaTarea.ForeColor = Color.White;
            btnNuevaTarea.HoverState.FillColor = Color.FromArgb(56, 161, 105);
            btnNuevaTarea.Location = new Point(660, 10);
            btnNuevaTarea.Name = "btnNuevaTarea";
            btnNuevaTarea.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnNuevaTarea.Size = new Size(150, 35);
            btnNuevaTarea.TabIndex = 2;
            btnNuevaTarea.Text = "➕ Nueva Tarea";
            btnNuevaTarea.Click += btnNuevaTarea_Click;
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.Transparent;
            panelIzquierdo.BorderRadius = 12;
            panelIzquierdo.Controls.Add(dgvTareas);
            panelIzquierdo.CustomizableEdges = customizableEdges5;
            panelIzquierdo.FillColor = Color.White;
            panelIzquierdo.Location = new Point(15, 80);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Padding = new Padding(10);
            panelIzquierdo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelIzquierdo.ShadowDecoration.Depth = 4;
            panelIzquierdo.ShadowDecoration.Enabled = true;
            panelIzquierdo.Size = new Size(380, 440);
            panelIzquierdo.TabIndex = 1;
            // 
            // dgvTareas
            // 
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 250, 252);
            dgvTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(102, 126, 234);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTareas.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 240, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTareas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTareas.GridColor = Color.FromArgb(226, 232, 240);
            dgvTareas.Location = new Point(10, 10);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.ReadOnly = true;
            dgvTareas.RowHeadersVisible = false;
            dgvTareas.RowTemplate.Height = 32;
            dgvTareas.Size = new Size(360, 420);
            dgvTareas.TabIndex = 0;
            dgvTareas.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(247, 250, 252);
            dgvTareas.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTareas.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTareas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTareas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTareas.ThemeStyle.BackColor = Color.White;
            dgvTareas.ThemeStyle.GridColor = Color.FromArgb(226, 232, 240);
            dgvTareas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(102, 126, 234);
            dgvTareas.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTareas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvTareas.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTareas.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTareas.ThemeStyle.HeaderStyle.Height = 32;
            dgvTareas.ThemeStyle.ReadOnly = true;
            dgvTareas.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTareas.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTareas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvTareas.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(45, 55, 72);
            dgvTareas.ThemeStyle.RowsStyle.Height = 32;
            dgvTareas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(235, 240, 255);
            dgvTareas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvTareas.CellFormatting += dgvTareas_CellFormatting;
            dgvTareas.SelectionChanged += dgvTareas_SelectionChanged;
            // 
            // panelDerecho
            // 
            panelDerecho.BackColor = Color.Transparent;
            panelDerecho.Controls.Add(panelInfoTarea);
            panelDerecho.Controls.Add(lblTotalEntregas);
            panelDerecho.Controls.Add(dgvEntregas);
            panelDerecho.Controls.Add(panelCalificar);
            panelDerecho.CustomizableEdges = customizableEdges19;
            panelDerecho.FillColor = Color.Transparent;
            panelDerecho.Location = new Point(405, 80);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.ShadowDecoration.CustomizableEdges = customizableEdges20;
            panelDerecho.Size = new Size(434, 440);
            panelDerecho.TabIndex = 2;
            // 
            // panelInfoTarea
            // 
            panelInfoTarea.BackColor = Color.Transparent;
            panelInfoTarea.BorderRadius = 10;
            panelInfoTarea.Controls.Add(lblTituloTarea);
            panelInfoTarea.Controls.Add(lblGrupoTarea);
            panelInfoTarea.Controls.Add(lblFechaTarea);
            panelInfoTarea.CustomizableEdges = customizableEdges7;
            panelInfoTarea.FillColor = Color.FromArgb(235, 240, 255);
            panelInfoTarea.Location = new Point(0, 0);
            panelInfoTarea.Name = "panelInfoTarea";
            panelInfoTarea.Padding = new Padding(10);
            panelInfoTarea.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelInfoTarea.Size = new Size(434, 60);
            panelInfoTarea.TabIndex = 0;
            // 
            // lblTituloTarea
            // 
            lblTituloTarea.BackColor = Color.Transparent;
            lblTituloTarea.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloTarea.ForeColor = Color.FromArgb(45, 55, 72);
            lblTituloTarea.Location = new Point(10, 5);
            lblTituloTarea.Name = "lblTituloTarea";
            lblTituloTarea.Size = new Size(145, 22);
            lblTituloTarea.TabIndex = 0;
            lblTituloTarea.Text = "Selecciona una tarea";
            // 
            // lblGrupoTarea
            // 
            lblGrupoTarea.BackColor = Color.Transparent;
            lblGrupoTarea.Font = new Font("Segoe UI", 9F);
            lblGrupoTarea.ForeColor = Color.FromArgb(113, 128, 150);
            lblGrupoTarea.Location = new Point(10, 30);
            lblGrupoTarea.Name = "lblGrupoTarea";
            lblGrupoTarea.Size = new Size(47, 17);
            lblGrupoTarea.TabIndex = 1;
            lblGrupoTarea.Text = "Grupo: -";
            // 
            // lblFechaTarea
            // 
            lblFechaTarea.BackColor = Color.Transparent;
            lblFechaTarea.Font = new Font("Segoe UI", 9F);
            lblFechaTarea.ForeColor = Color.FromArgb(113, 128, 150);
            lblFechaTarea.Location = new Point(200, 30);
            lblFechaTarea.Name = "lblFechaTarea";
            lblFechaTarea.Size = new Size(54, 17);
            lblFechaTarea.TabIndex = 2;
            lblFechaTarea.Text = "Entrega: -";
            // 
            // lblTotalEntregas
            // 
            lblTotalEntregas.BackColor = Color.Transparent;
            lblTotalEntregas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalEntregas.ForeColor = Color.FromArgb(102, 126, 234);
            lblTotalEntregas.Location = new Point(0, 68);
            lblTotalEntregas.Name = "lblTotalEntregas";
            lblTotalEntregas.Size = new Size(56, 19);
            lblTotalEntregas.TabIndex = 1;
            lblTotalEntregas.Text = "Entregas";
            // 
            // dgvEntregas
            // 
            dgvEntregas.AllowUserToAddRows = false;
            dgvEntregas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(247, 255, 250);
            dgvEntregas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(72, 187, 120);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEntregas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvEntregas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(235, 255, 245);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvEntregas.DefaultCellStyle = dataGridViewCellStyle6;
            dgvEntregas.GridColor = Color.FromArgb(226, 232, 240);
            dgvEntregas.Location = new Point(0, 92);
            dgvEntregas.Name = "dgvEntregas";
            dgvEntregas.ReadOnly = true;
            dgvEntregas.RowHeadersVisible = false;
            dgvEntregas.RowTemplate.Height = 30;
            dgvEntregas.Size = new Size(434, 170);
            dgvEntregas.TabIndex = 2;
            dgvEntregas.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(247, 255, 250);
            dgvEntregas.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvEntregas.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvEntregas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvEntregas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvEntregas.ThemeStyle.BackColor = Color.White;
            dgvEntregas.ThemeStyle.GridColor = Color.FromArgb(226, 232, 240);
            dgvEntregas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(72, 187, 120);
            dgvEntregas.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEntregas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvEntregas.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvEntregas.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEntregas.ThemeStyle.HeaderStyle.Height = 30;
            dgvEntregas.ThemeStyle.ReadOnly = true;
            dgvEntregas.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvEntregas.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEntregas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvEntregas.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvEntregas.ThemeStyle.RowsStyle.Height = 30;
            dgvEntregas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(235, 255, 245);
            dgvEntregas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvEntregas.SelectionChanged += dgvEntregas_SelectionChanged;
            // 
            // panelCalificar
            // 
            panelCalificar.BackColor = Color.Transparent;
            panelCalificar.BorderRadius = 10;
            panelCalificar.Controls.Add(lblEstudianteNombre);
            panelCalificar.Controls.Add(lblArchivoEntregado);
            panelCalificar.Controls.Add(lblComentarioLabel);
            panelCalificar.Controls.Add(txtComentarioEstudiante);
            panelCalificar.Controls.Add(lblNota);
            panelCalificar.Controls.Add(txtCalificacion);
            panelCalificar.Controls.Add(lblFeedbackLabel);
            panelCalificar.Controls.Add(txtFeedback);
            panelCalificar.Controls.Add(btnCalificar);
            panelCalificar.CustomizableEdges = customizableEdges17;
            panelCalificar.FillColor = Color.White;
            panelCalificar.Location = new Point(0, 270);
            panelCalificar.Name = "panelCalificar";
            panelCalificar.Padding = new Padding(10);
            panelCalificar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            panelCalificar.ShadowDecoration.Depth = 4;
            panelCalificar.ShadowDecoration.Enabled = true;
            panelCalificar.Size = new Size(434, 168);
            panelCalificar.TabIndex = 3;
            // 
            // lblEstudianteNombre
            // 
            lblEstudianteNombre.BackColor = Color.Transparent;
            lblEstudianteNombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEstudianteNombre.ForeColor = Color.FromArgb(45, 55, 72);
            lblEstudianteNombre.Location = new Point(10, 8);
            lblEstudianteNombre.Name = "lblEstudianteNombre";
            lblEstudianteNombre.Size = new Size(163, 22);
            lblEstudianteNombre.TabIndex = 0;
            lblEstudianteNombre.Text = "Selecciona una entrega";
            // 
            // lblArchivoEntregado
            // 
            lblArchivoEntregado.BackColor = Color.Transparent;
            lblArchivoEntregado.Font = new Font("Segoe UI", 9F);
            lblArchivoEntregado.ForeColor = Color.FromArgb(66, 153, 225);
            lblArchivoEntregado.Location = new Point(10, 30);
            lblArchivoEntregado.Name = "lblArchivoEntregado";
            lblArchivoEntregado.Size = new Size(61, 17);
            lblArchivoEntregado.TabIndex = 1;
            lblArchivoEntregado.Text = "Sin archivo";
            // 
            // lblComentarioLabel
            // 
            lblComentarioLabel.BackColor = Color.Transparent;
            lblComentarioLabel.Font = new Font("Segoe UI", 9F);
            lblComentarioLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblComentarioLabel.Location = new Point(10, 50);
            lblComentarioLabel.Name = "lblComentarioLabel";
            lblComentarioLabel.Size = new Size(69, 17);
            lblComentarioLabel.TabIndex = 2;
            lblComentarioLabel.Text = "Comentario:";
            // 
            // txtComentarioEstudiante
            // 
            txtComentarioEstudiante.BorderRadius = 6;
            txtComentarioEstudiante.CustomizableEdges = customizableEdges9;
            txtComentarioEstudiante.DefaultText = "";
            txtComentarioEstudiante.FillColor = Color.FromArgb(247, 250, 252);
            txtComentarioEstudiante.Font = new Font("Segoe UI", 9F);
            txtComentarioEstudiante.ForeColor = Color.FromArgb(113, 128, 150);
            txtComentarioEstudiante.Location = new Point(110, 47);
            txtComentarioEstudiante.Name = "txtComentarioEstudiante";
            txtComentarioEstudiante.PlaceholderText = "Comentario del estudiante";
            txtComentarioEstudiante.ReadOnly = true;
            txtComentarioEstudiante.SelectedText = "";
            txtComentarioEstudiante.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtComentarioEstudiante.Size = new Size(310, 30);
            txtComentarioEstudiante.TabIndex = 3;
            // 
            // lblNota
            // 
            lblNota.BackColor = Color.Transparent;
            lblNota.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNota.ForeColor = Color.FromArgb(45, 55, 72);
            lblNota.Location = new Point(10, 88);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(33, 17);
            lblNota.TabIndex = 4;
            lblNota.Text = "Nota:";
            // 
            // txtCalificacion
            // 
            txtCalificacion.BorderRadius = 6;
            txtCalificacion.CustomizableEdges = customizableEdges11;
            txtCalificacion.DefaultText = "";
            txtCalificacion.FillColor = Color.FromArgb(247, 250, 252);
            txtCalificacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtCalificacion.ForeColor = Color.FromArgb(102, 126, 234);
            txtCalificacion.Location = new Point(70, 85);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.PlaceholderText = "0 - 100";
            txtCalificacion.SelectedText = "";
            txtCalificacion.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtCalificacion.Size = new Size(80, 30);
            txtCalificacion.TabIndex = 5;
            // 
            // lblFeedbackLabel
            // 
            lblFeedbackLabel.BackColor = Color.Transparent;
            lblFeedbackLabel.Font = new Font("Segoe UI", 9F);
            lblFeedbackLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblFeedbackLabel.Location = new Point(10, 122);
            lblFeedbackLabel.Name = "lblFeedbackLabel";
            lblFeedbackLabel.Size = new Size(56, 17);
            lblFeedbackLabel.TabIndex = 6;
            lblFeedbackLabel.Text = "Feedback:";
            // 
            // txtFeedback
            // 
            txtFeedback.BorderRadius = 6;
            txtFeedback.CustomizableEdges = customizableEdges13;
            txtFeedback.DefaultText = "";
            txtFeedback.FillColor = Color.FromArgb(247, 250, 252);
            txtFeedback.Font = new Font("Segoe UI", 9F);
            txtFeedback.ForeColor = Color.FromArgb(45, 55, 72);
            txtFeedback.Location = new Point(75, 119);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.PlaceholderText = "Comentario al estudiante...";
            txtFeedback.SelectedText = "";
            txtFeedback.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtFeedback.Size = new Size(220, 30);
            txtFeedback.TabIndex = 7;
            // 
            // btnCalificar
            // 
            btnCalificar.BorderRadius = 8;
            btnCalificar.Cursor = Cursors.Hand;
            btnCalificar.CustomizableEdges = customizableEdges15;
            btnCalificar.FillColor = Color.FromArgb(102, 126, 234);
            btnCalificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalificar.ForeColor = Color.White;
            btnCalificar.HoverState.FillColor = Color.FromArgb(92, 116, 224);
            btnCalificar.Location = new Point(305, 115);
            btnCalificar.Name = "btnCalificar";
            btnCalificar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnCalificar.Size = new Size(115, 35);
            btnCalificar.TabIndex = 8;
            btnCalificar.Text = "✅ Calificar";
            btnCalificar.Click += btnCalificar_Click;
            // 
            // FrmMisTareas
            // 
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(854, 535);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMisTareas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mis Tareas";
            Load += FrmMisTareas_Load;
            panelPrincipal.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            panelDerecho.ResumeLayout(false);
            panelDerecho.PerformLayout();
            panelInfoTarea.ResumeLayout(false);
            panelInfoTarea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).EndInit();
            panelCalificar.ResumeLayout(false);
            panelCalificar.PerformLayout();
            ResumeLayout(false);
        }
    }
}