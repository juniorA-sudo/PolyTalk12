using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Estudiantes
{
    partial class FrmTareasEstudiante
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelPrincipal;
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTituloHeader;
        private Guna2Panel panelContadores;
        private Guna2HtmlLabel lblPendientes;
        private Guna2HtmlLabel lblEntregadas;
        private Guna2HtmlLabel lblVencidas;
        private Guna2HtmlLabel lblCalificadas;
        private Guna2Panel panelIzquierdo;
        private Guna2DataGridView dgvTareas;
        private Guna2Panel panelDerecho;
        private Guna2Panel panelInfoTarea;
        private Guna2HtmlLabel lblTituloTarea;
        private Guna2HtmlLabel lblMaestroTarea;
        private Guna2HtmlLabel lblFechaEntrega;
        private Guna2HtmlLabel lblEstadoTarea;
        private Guna2Panel panelEntregar;
        private Guna2HtmlLabel lblArchivoLabel;
        private Guna2TextBox txtNombreArchivo;
        private Guna2HtmlLabel lblComentarioLabel;
        private Guna2TextBox txtComentario;
        private Guna2Button btnEntregar;
        private Guna2Panel panelEntregado;
        private Guna2HtmlLabel lblEntregadoTitulo;
        private Guna2HtmlLabel lblArchivoEntregado;
        private Guna2HtmlLabel lblComentarioEntregado;
        private Guna2Panel panelCalificacion;
        private Guna2HtmlLabel lblNotaTitulo;
        private Guna2HtmlLabel lblNota;
        private Guna2HtmlLabel lblFeedbackTitulo;
        private Guna2HtmlLabel lblFeedback;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelPrincipal = new Guna2Panel();
            panelHeader = new Guna2Panel();
            lblTituloHeader = new Guna2HtmlLabel();
            panelContadores = new Guna2Panel();
            lblPendientes = new Guna2HtmlLabel();
            lblEntregadas = new Guna2HtmlLabel();
            lblVencidas = new Guna2HtmlLabel();
            lblCalificadas = new Guna2HtmlLabel();
            panelIzquierdo = new Guna2Panel();
            dgvTareas = new Guna2DataGridView();
            panelDerecho = new Guna2Panel();
            panelInfoTarea = new Guna2Panel();
            lblTituloTarea = new Guna2HtmlLabel();
            lblMaestroTarea = new Guna2HtmlLabel();
            lblFechaEntrega = new Guna2HtmlLabel();
            lblEstadoTarea = new Guna2HtmlLabel();
            panelEntregar = new Guna2Panel();
            lblArchivoLabel = new Guna2HtmlLabel();
            txtNombreArchivo = new Guna2TextBox();
            lblComentarioLabel = new Guna2HtmlLabel();
            txtComentario = new Guna2TextBox();
            btnEntregar = new Guna2Button();
            panelEntregado = new Guna2Panel();
            lblEntregadoTitulo = new Guna2HtmlLabel();
            lblArchivoEntregado = new Guna2HtmlLabel();
            lblComentarioEntregado = new Guna2HtmlLabel();
            panelCalificacion = new Guna2Panel();
            lblNotaTitulo = new Guna2HtmlLabel();
            lblNota = new Guna2HtmlLabel();
            lblFeedbackTitulo = new Guna2HtmlLabel();
            lblFeedback = new Guna2HtmlLabel();
            panelPrincipal.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContadores.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            panelDerecho.SuspendLayout();
            panelInfoTarea.SuspendLayout();
            panelEntregar.SuspendLayout();
            panelEntregado.SuspendLayout();
            panelCalificacion.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 247, 237);
            panelPrincipal.Controls.Add(panelHeader);
            panelPrincipal.Controls.Add(panelContadores);
            panelPrincipal.Controls.Add(panelIzquierdo);
            panelPrincipal.Controls.Add(panelDerecho);
            panelPrincipal.CustomizableEdges = customizableEdges23;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.FillColor = Color.Transparent;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(15);
            panelPrincipal.ShadowDecoration.CustomizableEdges = customizableEdges24;
            panelPrincipal.Size = new Size(854, 535);
            panelPrincipal.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.BorderRadius = 12;
            panelHeader.Controls.Add(lblTituloHeader);
            panelHeader.CustomizableEdges = customizableEdges1;
            panelHeader.FillColor = Color.FromArgb(159, 122, 234);
            panelHeader.Location = new Point(15, 15);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(824, 45);
            panelHeader.TabIndex = 0;
            // 
            // lblTituloHeader
            // 
            lblTituloHeader.BackColor = Color.Transparent;
            lblTituloHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTituloHeader.ForeColor = Color.White;
            lblTituloHeader.Location = new Point(15, 8);
            lblTituloHeader.Name = "lblTituloHeader";
            lblTituloHeader.Size = new Size(137, 30);
            lblTituloHeader.TabIndex = 0;
            lblTituloHeader.Text = "📚 Mis Tareas";
            // 
            // panelContadores
            // 
            panelContadores.BackColor = Color.Transparent;
            panelContadores.Controls.Add(lblPendientes);
            panelContadores.Controls.Add(lblEntregadas);
            panelContadores.Controls.Add(lblVencidas);
            panelContadores.Controls.Add(lblCalificadas);
            panelContadores.CustomizableEdges = customizableEdges3;
            panelContadores.FillColor = Color.Transparent;
            panelContadores.Location = new Point(15, 68);
            panelContadores.Name = "panelContadores";
            panelContadores.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelContadores.Size = new Size(824, 28);
            panelContadores.TabIndex = 1;
            // 
            // lblPendientes
            // 
            lblPendientes.BackColor = Color.Transparent;
            lblPendientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPendientes.ForeColor = Color.FromArgb(237, 137, 54);
            lblPendientes.Location = new Point(0, 4);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(105, 19);
            lblPendientes.TabIndex = 0;
            lblPendientes.Text = "⏳ 0 pendientes";
            // 
            // lblEntregadas
            // 
            lblEntregadas.BackColor = Color.Transparent;
            lblEntregadas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEntregadas.ForeColor = Color.FromArgb(66, 153, 225);
            lblEntregadas.Location = new Point(200, 4);
            lblEntregadas.Name = "lblEntregadas";
            lblEntregadas.Size = new Size(105, 19);
            lblEntregadas.TabIndex = 1;
            lblEntregadas.Text = "✅ 0 entregadas";
            // 
            // lblVencidas
            // 
            lblVencidas.BackColor = Color.Transparent;
            lblVencidas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVencidas.ForeColor = Color.FromArgb(197, 48, 48);
            lblVencidas.Location = new Point(400, 4);
            lblVencidas.Name = "lblVencidas";
            lblVencidas.Size = new Size(90, 19);
            lblVencidas.TabIndex = 2;
            lblVencidas.Text = "❌ 0 vencidas";
            // 
            // lblCalificadas
            // 
            lblCalificadas.BackColor = Color.Transparent;
            lblCalificadas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCalificadas.ForeColor = Color.FromArgb(56, 161, 105);
            lblCalificadas.Location = new Point(600, 4);
            lblCalificadas.Name = "lblCalificadas";
            lblCalificadas.Size = new Size(98, 19);
            lblCalificadas.TabIndex = 3;
            lblCalificadas.Text = "🏆 0 calificadas";
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.Transparent;
            panelIzquierdo.BorderRadius = 12;
            panelIzquierdo.Controls.Add(dgvTareas);
            panelIzquierdo.CustomizableEdges = customizableEdges5;
            panelIzquierdo.FillColor = Color.White;
            panelIzquierdo.Location = new Point(15, 103);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Padding = new Padding(10);
            panelIzquierdo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelIzquierdo.ShadowDecoration.Depth = 4;
            panelIzquierdo.ShadowDecoration.Enabled = true;
            panelIzquierdo.Size = new Size(400, 417);
            panelIzquierdo.TabIndex = 2;
            // 
            // dgvTareas
            // 
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 248, 255);
            dgvTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(159, 122, 234);
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
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(245, 240, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTareas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTareas.GridColor = Color.FromArgb(226, 232, 240);
            dgvTareas.Location = new Point(10, 10);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.ReadOnly = true;
            dgvTareas.RowHeadersVisible = false;
            dgvTareas.RowTemplate.Height = 32;
            dgvTareas.Size = new Size(380, 397);
            dgvTareas.TabIndex = 0;
            dgvTareas.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(250, 248, 255);
            dgvTareas.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTareas.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTareas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTareas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTareas.ThemeStyle.BackColor = Color.White;
            dgvTareas.ThemeStyle.GridColor = Color.FromArgb(226, 232, 240);
            dgvTareas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(159, 122, 234);
            dgvTareas.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTareas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvTareas.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTareas.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTareas.ThemeStyle.HeaderStyle.Height = 32;
            dgvTareas.ThemeStyle.ReadOnly = true;
            dgvTareas.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTareas.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTareas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvTareas.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTareas.ThemeStyle.RowsStyle.Height = 32;
            dgvTareas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(245, 240, 255);
            dgvTareas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvTareas.CellFormatting += dgvTareas_CellFormatting;
            dgvTareas.SelectionChanged += dgvTareas_SelectionChanged;
            // 
            // panelDerecho
            // 
            panelDerecho.BackColor = Color.Transparent;
            panelDerecho.Controls.Add(panelInfoTarea);
            panelDerecho.Controls.Add(panelEntregar);
            panelDerecho.Controls.Add(panelEntregado);
            panelDerecho.Controls.Add(panelCalificacion);
            panelDerecho.CustomizableEdges = customizableEdges21;
            panelDerecho.FillColor = Color.Transparent;
            panelDerecho.Location = new Point(425, 103);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.ShadowDecoration.CustomizableEdges = customizableEdges22;
            panelDerecho.Size = new Size(414, 417);
            panelDerecho.TabIndex = 3;
            // 
            // panelInfoTarea
            // 
            panelInfoTarea.BackColor = Color.Transparent;
            panelInfoTarea.BorderRadius = 10;
            panelInfoTarea.Controls.Add(lblTituloTarea);
            panelInfoTarea.Controls.Add(lblMaestroTarea);
            panelInfoTarea.Controls.Add(lblFechaEntrega);
            panelInfoTarea.Controls.Add(lblEstadoTarea);
            panelInfoTarea.CustomizableEdges = customizableEdges7;
            panelInfoTarea.FillColor = Color.FromArgb(245, 240, 255);
            panelInfoTarea.Location = new Point(0, 0);
            panelInfoTarea.Name = "panelInfoTarea";
            panelInfoTarea.Padding = new Padding(12);
            panelInfoTarea.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelInfoTarea.Size = new Size(414, 80);
            panelInfoTarea.TabIndex = 0;
            // 
            // lblTituloTarea
            // 
            lblTituloTarea.BackColor = Color.Transparent;
            lblTituloTarea.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloTarea.ForeColor = Color.FromArgb(45, 55, 72);
            lblTituloTarea.Location = new Point(12, 8);
            lblTituloTarea.Name = "lblTituloTarea";
            lblTituloTarea.Size = new Size(161, 23);
            lblTituloTarea.TabIndex = 0;
            lblTituloTarea.Text = "Selecciona una tarea";
            // 
            // lblMaestroTarea
            // 
            lblMaestroTarea.BackColor = Color.Transparent;
            lblMaestroTarea.Font = new Font("Segoe UI", 9F);
            lblMaestroTarea.ForeColor = Color.FromArgb(113, 128, 150);
            lblMaestroTarea.Location = new Point(12, 36);
            lblMaestroTarea.Name = "lblMaestroTarea";
            lblMaestroTarea.Size = new Size(81, 17);
            lblMaestroTarea.TabIndex = 1;
            lblMaestroTarea.Text = "👨‍🏫 Maestro";
            // 
            // lblFechaEntrega
            // 
            lblFechaEntrega.BackColor = Color.Transparent;
            lblFechaEntrega.Font = new Font("Segoe UI", 9F);
            lblFechaEntrega.ForeColor = Color.FromArgb(113, 128, 150);
            lblFechaEntrega.Location = new Point(12, 56);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(73, 17);
            lblFechaEntrega.TabIndex = 2;
            lblFechaEntrega.Text = "📅 Entrega: -";
            // 
            // lblEstadoTarea
            // 
            lblEstadoTarea.BackColor = Color.Transparent;
            lblEstadoTarea.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoTarea.ForeColor = Color.FromArgb(237, 137, 54);
            lblEstadoTarea.Location = new Point(300, 36);
            lblEstadoTarea.Name = "lblEstadoTarea";
            lblEstadoTarea.Size = new Size(8, 19);
            lblEstadoTarea.TabIndex = 3;
            lblEstadoTarea.Text = "-";
            // 
            // panelEntregar
            // 
            panelEntregar.BackColor = Color.Transparent;
            panelEntregar.BorderRadius = 10;
            panelEntregar.Controls.Add(lblArchivoLabel);
            panelEntregar.Controls.Add(txtNombreArchivo);
            panelEntregar.Controls.Add(lblComentarioLabel);
            panelEntregar.Controls.Add(txtComentario);
            panelEntregar.Controls.Add(btnEntregar);
            panelEntregar.CustomizableEdges = customizableEdges15;
            panelEntregar.FillColor = Color.White;
            panelEntregar.Location = new Point(0, 90);
            panelEntregar.Name = "panelEntregar";
            panelEntregar.Padding = new Padding(12);
            panelEntregar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelEntregar.ShadowDecoration.Depth = 4;
            panelEntregar.ShadowDecoration.Enabled = true;
            panelEntregar.Size = new Size(414, 200);
            panelEntregar.TabIndex = 1;
            panelEntregar.Visible = false;
            // 
            // lblArchivoLabel
            // 
            lblArchivoLabel.BackColor = Color.Transparent;
            lblArchivoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblArchivoLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblArchivoLabel.Location = new Point(12, 10);
            lblArchivoLabel.Name = "lblArchivoLabel";
            lblArchivoLabel.Size = new Size(113, 17);
            lblArchivoLabel.TabIndex = 0;
            lblArchivoLabel.Text = "Nombre del archivo";
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.BorderRadius = 8;
            txtNombreArchivo.CustomizableEdges = customizableEdges9;
            txtNombreArchivo.DefaultText = "";
            txtNombreArchivo.FillColor = Color.FromArgb(247, 250, 252);
            txtNombreArchivo.Font = new Font("Segoe UI", 10F);
            txtNombreArchivo.ForeColor = Color.FromArgb(45, 55, 72);
            txtNombreArchivo.Location = new Point(12, 30);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.PlaceholderText = "Ej: tarea_unit3_juan.pdf";
            txtNombreArchivo.SelectedText = "";
            txtNombreArchivo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtNombreArchivo.Size = new Size(390, 34);
            txtNombreArchivo.TabIndex = 1;
            // 
            // lblComentarioLabel
            // 
            lblComentarioLabel.BackColor = Color.Transparent;
            lblComentarioLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblComentarioLabel.ForeColor = Color.FromArgb(113, 128, 150);
            lblComentarioLabel.Location = new Point(12, 72);
            lblComentarioLabel.Name = "lblComentarioLabel";
            lblComentarioLabel.Size = new Size(68, 17);
            lblComentarioLabel.TabIndex = 2;
            lblComentarioLabel.Text = "Comentario";
            // 
            // txtComentario
            // 
            txtComentario.BorderRadius = 8;
            txtComentario.CustomizableEdges = customizableEdges11;
            txtComentario.DefaultText = "";
            txtComentario.FillColor = Color.FromArgb(247, 250, 252);
            txtComentario.Font = new Font("Segoe UI", 10F);
            txtComentario.ForeColor = Color.FromArgb(45, 55, 72);
            txtComentario.Location = new Point(12, 92);
            txtComentario.Name = "txtComentario";
            txtComentario.PlaceholderText = "Mensaje opcional para el maestro...";
            txtComentario.SelectedText = "";
            txtComentario.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtComentario.Size = new Size(390, 55);
            txtComentario.TabIndex = 3;
            // 
            // btnEntregar
            // 
            btnEntregar.BorderRadius = 10;
            btnEntregar.Cursor = Cursors.Hand;
            btnEntregar.CustomizableEdges = customizableEdges13;
            btnEntregar.FillColor = Color.FromArgb(159, 122, 234);
            btnEntregar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEntregar.ForeColor = Color.White;
            btnEntregar.HoverState.FillColor = Color.FromArgb(128, 90, 213);
            btnEntregar.Location = new Point(12, 155);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnEntregar.Size = new Size(390, 38);
            btnEntregar.TabIndex = 4;
            btnEntregar.Text = "📤 Entregar Tarea";
            btnEntregar.Click += btnEntregar_Click;
            // 
            // panelEntregado
            // 
            panelEntregado.BackColor = Color.Transparent;
            panelEntregado.BorderRadius = 10;
            panelEntregado.Controls.Add(lblEntregadoTitulo);
            panelEntregado.Controls.Add(lblArchivoEntregado);
            panelEntregado.Controls.Add(lblComentarioEntregado);
            panelEntregado.CustomizableEdges = customizableEdges17;
            panelEntregado.FillColor = Color.FromArgb(240, 255, 244);
            panelEntregado.Location = new Point(0, 90);
            panelEntregado.Name = "panelEntregado";
            panelEntregado.Padding = new Padding(12);
            panelEntregado.ShadowDecoration.CustomizableEdges = customizableEdges18;
            panelEntregado.ShadowDecoration.Depth = 3;
            panelEntregado.ShadowDecoration.Enabled = true;
            panelEntregado.Size = new Size(414, 100);
            panelEntregado.TabIndex = 2;
            panelEntregado.Visible = false;
            // 
            // lblEntregadoTitulo
            // 
            lblEntregadoTitulo.BackColor = Color.Transparent;
            lblEntregadoTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEntregadoTitulo.ForeColor = Color.FromArgb(56, 161, 105);
            lblEntregadoTitulo.Location = new Point(12, 8);
            lblEntregadoTitulo.Name = "lblEntregadoTitulo";
            lblEntregadoTitulo.Size = new Size(143, 22);
            lblEntregadoTitulo.TabIndex = 0;
            lblEntregadoTitulo.Text = "✅ Tarea entregada";
            // 
            // lblArchivoEntregado
            // 
            lblArchivoEntregado.BackColor = Color.Transparent;
            lblArchivoEntregado.Font = new Font("Segoe UI", 9F);
            lblArchivoEntregado.ForeColor = Color.FromArgb(66, 153, 225);
            lblArchivoEntregado.Location = new Point(12, 35);
            lblArchivoEntregado.Name = "lblArchivoEntregado";
            lblArchivoEntregado.Size = new Size(61, 17);
            lblArchivoEntregado.TabIndex = 1;
            lblArchivoEntregado.Text = "Sin archivo";
            // 
            // lblComentarioEntregado
            // 
            lblComentarioEntregado.BackColor = Color.Transparent;
            lblComentarioEntregado.Font = new Font("Segoe UI", 9F);
            lblComentarioEntregado.ForeColor = Color.FromArgb(113, 128, 150);
            lblComentarioEntregado.Location = new Point(12, 58);
            lblComentarioEntregado.Name = "lblComentarioEntregado";
            lblComentarioEntregado.Size = new Size(83, 17);
            lblComentarioEntregado.TabIndex = 2;
            lblComentarioEntregado.Text = "Sin comentario";
            // 
            // panelCalificacion
            // 
            panelCalificacion.BackColor = Color.Transparent;
            panelCalificacion.BorderRadius = 10;
            panelCalificacion.Controls.Add(lblNotaTitulo);
            panelCalificacion.Controls.Add(lblNota);
            panelCalificacion.Controls.Add(lblFeedbackTitulo);
            panelCalificacion.Controls.Add(lblFeedback);
            panelCalificacion.CustomizableEdges = customizableEdges19;
            panelCalificacion.FillColor = Color.FromArgb(255, 252, 235);
            panelCalificacion.Location = new Point(0, 200);
            panelCalificacion.Name = "panelCalificacion";
            panelCalificacion.Padding = new Padding(12);
            panelCalificacion.ShadowDecoration.CustomizableEdges = customizableEdges20;
            panelCalificacion.ShadowDecoration.Depth = 3;
            panelCalificacion.ShadowDecoration.Enabled = true;
            panelCalificacion.Size = new Size(414, 110);
            panelCalificacion.TabIndex = 3;
            panelCalificacion.Visible = false;
            // 
            // lblNotaTitulo
            // 
            lblNotaTitulo.BackColor = Color.Transparent;
            lblNotaTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotaTitulo.ForeColor = Color.FromArgb(113, 128, 150);
            lblNotaTitulo.Location = new Point(12, 8);
            lblNotaTitulo.Name = "lblNotaTitulo";
            lblNotaTitulo.Size = new Size(65, 17);
            lblNotaTitulo.TabIndex = 0;
            lblNotaTitulo.Text = "Calificación";
            // 
            // lblNota
            // 
            lblNota.BackColor = Color.Transparent;
            lblNota.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNota.ForeColor = Color.FromArgb(56, 161, 105);
            lblNota.Location = new Point(12, 28);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(55, 39);
            lblNota.TabIndex = 1;
            lblNota.Text = "🏆 -";
            // 
            // lblFeedbackTitulo
            // 
            lblFeedbackTitulo.BackColor = Color.Transparent;
            lblFeedbackTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFeedbackTitulo.ForeColor = Color.FromArgb(113, 128, 150);
            lblFeedbackTitulo.Location = new Point(12, 72);
            lblFeedbackTitulo.Name = "lblFeedbackTitulo";
            lblFeedbackTitulo.Size = new Size(71, 17);
            lblFeedbackTitulo.TabIndex = 2;
            lblFeedbackTitulo.Text = "Comentario:";
            // 
            // lblFeedback
            // 
            lblFeedback.BackColor = Color.Transparent;
            lblFeedback.Font = new Font("Segoe UI", 10F);
            lblFeedback.ForeColor = Color.FromArgb(45, 55, 72);
            lblFeedback.Location = new Point(100, 70);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(8, 19);
            lblFeedback.TabIndex = 3;
            lblFeedback.Text = "-";
            // 
            // FrmTareasEstudiante
            // 
            BackColor = Color.FromArgb(242, 245, 250);
            ClientSize = new Size(854, 535);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTareasEstudiante";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mis Tareas";
            Load += FrmTareasEstudiante_Load;
            panelPrincipal.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContadores.ResumeLayout(false);
            panelContadores.PerformLayout();
            panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            panelDerecho.ResumeLayout(false);
            panelInfoTarea.ResumeLayout(false);
            panelInfoTarea.PerformLayout();
            panelEntregar.ResumeLayout(false);
            panelEntregar.PerformLayout();
            panelEntregado.ResumeLayout(false);
            panelEntregado.PerformLayout();
            panelCalificacion.ResumeLayout(false);
            panelCalificacion.PerformLayout();
            ResumeLayout(false);
        }
    }
}