using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Estudiantes
{
    partial class FrmTareasEstudiante
    {
        private System.ComponentModel.IContainer components = null;

        // Colores constantes
        private static readonly Color CREAM = Color.FromArgb(252, 248, 240);
        private static readonly Color YELLOW = Color.FromArgb(255, 183, 0);
        private static readonly Color DARK = Color.FromArgb(25, 25, 35);
        private static readonly Color LABEL_COLOR = Color.FromArgb(130, 120, 100);
        private static readonly Color WHITE = Color.White;

        // Header
        private Label accentBar;
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTituloHeader;

        // Stats
        private Guna2Panel panelStats;
        private Guna2Panel cardPendientes;
        private Guna2HtmlLabel lblCntPendientes;
        private Guna2HtmlLabel lblLblPendientes;
        private Guna2Panel cardEntregadas;
        private Guna2HtmlLabel lblCntEntregadas;
        private Guna2HtmlLabel lblLblEntregadas;
        private Guna2Panel cardVencidas;
        private Guna2HtmlLabel lblCntVencidas;
        private Guna2HtmlLabel lblLblVencidas;
        private Guna2Panel cardCalificadas;
        private Guna2HtmlLabel lblCntCalificadas;
        private Guna2HtmlLabel lblLblCalificadas;

        // Filtros
        private Guna2Panel panelFiltros;
        private Guna2Button btnFiltroTodas;
        private Guna2Button btnFiltroPendientes;
        private Guna2Button btnFiltroEntregadas;
        private Guna2Button btnFiltroVencidas;
        private Guna2Button btnFiltroCalificadas;

        // Lista de tareas
        private Guna2Panel panelIzquierdo;
        private FlowLayoutPanel flpTareas;

        // Detalle
        private Guna2Panel panelDerecho;
        private Guna2Panel panelDerechoContainer;
        private Guna2Panel panelDetalleHeader;
        private Guna2HtmlLabel lblDetalleTitulo;
        private Guna2HtmlLabel lblDetalleEstado;
        private Guna2HtmlLabel lblDetalleMaestro;
        private Guna2HtmlLabel lblDetalleFecha;
        private Guna2HtmlLabel lblDetalleDesc;

        // Panel entregar
        private Guna2Panel panelEntregar;
        private Guna2HtmlLabel lblArchivoLabel;
        private Guna2Button btnSeleccionarArchivo;
        private Guna2HtmlLabel lblArchivoSize;
        private Guna2TextBox txtNombreArchivo;
        private Guna2HtmlLabel lblComentarioLabel;
        private Guna2TextBox txtComentario;
        private Guna2Button btnEntregar;

        // Panel entregado
        private Guna2Panel panelEntregado;
        private Guna2HtmlLabel lblEntregadoTitulo;
        private Guna2HtmlLabel lblArchivoEntregado;
        private Guna2HtmlLabel lblComentarioEntregado;

        // Panel calificación
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
            components = new System.ComponentModel.Container();

            // ════════════ HEADER ════════════
            panelHeader = new Guna2Panel();
            accentBar = new Label();
            lblTituloHeader = new Guna2HtmlLabel();

            // ════════════ STATS ════════════
            panelStats = new Guna2Panel();
            cardPendientes = new Guna2Panel();
            lblCntPendientes = new Guna2HtmlLabel();
            lblLblPendientes = new Guna2HtmlLabel();
            cardEntregadas = new Guna2Panel();
            lblCntEntregadas = new Guna2HtmlLabel();
            lblLblEntregadas = new Guna2HtmlLabel();
            cardVencidas = new Guna2Panel();
            lblCntVencidas = new Guna2HtmlLabel();
            lblLblVencidas = new Guna2HtmlLabel();
            cardCalificadas = new Guna2Panel();
            lblCntCalificadas = new Guna2HtmlLabel();
            lblLblCalificadas = new Guna2HtmlLabel();

            // ════════════ FILTROS ════════════
            panelFiltros = new Guna2Panel();
            btnFiltroTodas = new Guna2Button();
            btnFiltroPendientes = new Guna2Button();
            btnFiltroEntregadas = new Guna2Button();
            btnFiltroVencidas = new Guna2Button();
            btnFiltroCalificadas = new Guna2Button();

            // ════════════ TAREAS ════════════
            panelIzquierdo = new Guna2Panel();
            flpTareas = new FlowLayoutPanel();

            // ════════════ DETALLES ════════════
            panelDerecho = new Guna2Panel();
            panelDerechoContainer = new Guna2Panel();
            panelDetalleHeader = new Guna2Panel();
            lblDetalleTitulo = new Guna2HtmlLabel();
            lblDetalleEstado = new Guna2HtmlLabel();
            lblDetalleMaestro = new Guna2HtmlLabel();
            lblDetalleFecha = new Guna2HtmlLabel();
            lblDetalleDesc = new Guna2HtmlLabel();

            panelEntregar = new Guna2Panel();
            lblArchivoLabel = new Guna2HtmlLabel();
            btnSeleccionarArchivo = new Guna2Button();
            lblArchivoSize = new Guna2HtmlLabel();
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

            // ════════════ CONFIGURACIÓN ════════════
            ConfigurarHeader();
            ConfigurarStatCards();
            ConfigurarFiltros();
            ConfigurarListaTareas();
            ConfigurarPanelDetalle();

            // ════════════ FORM ════════════
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = CREAM;
            this.ClientSize = new Size(854, 535);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "FrmTareasEstudiante";
            this.Text = "Mis Tareas";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += new EventHandler(FrmTareasEstudiante_Load);

            this.Controls.Add(panelHeader);
            this.Controls.Add(panelStats);
            this.Controls.Add(panelFiltros);
            this.Controls.Add(panelIzquierdo);
            this.Controls.Add(panelDerecho);

            ResumeLayout(false);
        }

        private void ConfigurarHeader()
        {
            accentBar.BackColor = YELLOW;
            accentBar.Location = new Point(0, 0);
            accentBar.Size = new Size(6, 60);

            lblTituloHeader.AutoSize = false;
            lblTituloHeader.BackColor = Color.Transparent;
            lblTituloHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloHeader.ForeColor = DARK;
            lblTituloHeader.Location = new Point(20, 12);
            lblTituloHeader.Size = new Size(350, 36);
            lblTituloHeader.Text = "📚 Mis Tareas";

            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = WHITE;
            panelHeader.Size = new Size(854, 60);
            panelHeader.BorderRadius = 0;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.ShadowDecoration.Depth = 3;
            panelHeader.ShadowDecoration.Color = Color.FromArgb(15, 0, 0, 0);
            panelHeader.Controls.Add(accentBar);
            panelHeader.Controls.Add(lblTituloHeader);
        }

        private void ConfigurarStatCards()
        {
            CrearStatCard(cardPendientes, lblCntPendientes, lblLblPendientes,
                "0", "Pendientes", Color.FromArgb(255, 248, 225),
                Color.FromArgb(160, 90, 0), new Point(8, 8));

            CrearStatCard(cardEntregadas, lblCntEntregadas, lblLblEntregadas,
                "0", "Entregadas", Color.FromArgb(225, 240, 255),
                Color.FromArgb(30, 80, 180), new Point(120, 8));

            CrearStatCard(cardVencidas, lblCntVencidas, lblLblVencidas,
                "0", "Vencidas", Color.FromArgb(255, 235, 235),
                Color.FromArgb(180, 30, 30), new Point(232, 8));

            CrearStatCard(cardCalificadas, lblCntCalificadas, lblLblCalificadas,
                "0", "Calificadas", Color.FromArgb(225, 255, 235),
                Color.FromArgb(20, 120, 60), new Point(344, 8));

            panelStats.FillColor = Color.Transparent;
            panelStats.Dock = DockStyle.Top;
            panelStats.Size = new Size(854, 68);
            panelStats.Padding = new Padding(0, 8, 0, 0);
            panelStats.Controls.Add(cardPendientes);
            panelStats.Controls.Add(cardEntregadas);
            panelStats.Controls.Add(cardVencidas);
            panelStats.Controls.Add(cardCalificadas);
        }

        private void CrearStatCard(Guna2Panel card, Guna2HtmlLabel lblCount, Guna2HtmlLabel lblLabel,
            string countText, string labelText, Color bgColor, Color textColor, Point location)
        {
            lblCount.AutoSize = false;
            lblCount.BackColor = Color.Transparent;
            lblCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCount.ForeColor = textColor;
            lblCount.Location = new Point(8, 5);
            lblCount.Size = new Size(100, 30);
            lblCount.Text = countText;
            lblCount.TextAlignment = ContentAlignment.MiddleLeft;

            lblLabel.AutoSize = false;
            lblLabel.BackColor = Color.Transparent;
            lblLabel.Font = new Font("Segoe UI", 8F);
            lblLabel.ForeColor = LABEL_COLOR;
            lblLabel.Location = new Point(8, 37);
            lblLabel.Size = new Size(100, 16);
            lblLabel.Text = labelText;

            card.BorderRadius = 10;
            card.FillColor = bgColor;
            card.Location = location;
            card.Size = new Size(108, 60);
            card.ShadowDecoration.Enabled = true;
            card.ShadowDecoration.Depth = 3;
            card.ShadowDecoration.Color = Color.FromArgb(10, 0, 0, 0);
            card.Controls.Add(lblCount);
            card.Controls.Add(lblLabel);
        }

        private void ConfigurarFiltros()
        {
            CrearBotonFiltro(btnFiltroTodas, "Todas", YELLOW, 8, btnFiltroTodas_Click);
            CrearBotonFiltro(btnFiltroPendientes, "Pendiente", Color.FromArgb(240, 232, 215), 98, btnFiltroPendientes_Click);
            CrearBotonFiltro(btnFiltroEntregadas, "Entregada", Color.FromArgb(240, 232, 215), 188, btnFiltroEntregadas_Click);
            CrearBotonFiltro(btnFiltroVencidas, "Vencida", Color.FromArgb(240, 232, 215), 278, btnFiltroVencidas_Click);
            CrearBotonFiltro(btnFiltroCalificadas, "Calificada", Color.FromArgb(240, 232, 215), 368, btnFiltroCalificadas_Click);

            panelFiltros.FillColor = Color.Transparent;
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Size = new Size(854, 45);
            panelFiltros.Padding = new Padding(0, 5, 0, 0);
            panelFiltros.Controls.Add(btnFiltroTodas);
            panelFiltros.Controls.Add(btnFiltroPendientes);
            panelFiltros.Controls.Add(btnFiltroEntregadas);
            panelFiltros.Controls.Add(btnFiltroVencidas);
            panelFiltros.Controls.Add(btnFiltroCalificadas);
        }

        private void CrearBotonFiltro(Guna2Button btn, string text, Color bgColor, int xPos, EventHandler handler)
        {
            btn.AutoRoundedCorners = true;
            btn.BorderRadius = 14;
            btn.Cursor = Cursors.Hand;
            btn.FillColor = bgColor;
            btn.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btn.ForeColor = bgColor == YELLOW ? Color.White : Color.FromArgb(80, 70, 55);
            btn.HoverState.FillColor = YELLOW;
            btn.HoverState.ForeColor = Color.White;
            btn.Location = new Point(xPos, 5);
            btn.Size = new Size(85, 32);
            btn.Text = text;
            btn.Click += handler;
        }

        private void ConfigurarListaTareas()
        {
            flpTareas.AutoScroll = true;
            flpTareas.BackColor = Color.Transparent;
            flpTareas.Dock = DockStyle.Fill;
            flpTareas.FlowDirection = FlowDirection.TopDown;
            flpTareas.Padding = new Padding(6);
            flpTareas.WrapContents = false;

            panelIzquierdo.BorderRadius = 10;
            panelIzquierdo.FillColor = WHITE;
            panelIzquierdo.Location = new Point(10, 120);
            panelIzquierdo.Size = new Size(415, 405);
            panelIzquierdo.ShadowDecoration.Enabled = true;
            panelIzquierdo.ShadowDecoration.Depth = 4;
            panelIzquierdo.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            panelIzquierdo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            panelIzquierdo.Controls.Add(flpTareas);
        }

        private void ConfigurarPanelDetalle()
        {
            ConfigurarDetalleHeader();
            ConfigurarPanelEntregar();
            ConfigurarPanelEntregado();
            ConfigurarPanelCalificacion();

            panelDerechoContainer.AutoScroll = true;
            panelDerechoContainer.BackColor = Color.Transparent;
            panelDerechoContainer.Dock = DockStyle.Fill;
            panelDerechoContainer.Location = new Point(0, 0);
            panelDerechoContainer.Size = new Size(420, 405);
            panelDerechoContainer.Padding = new Padding(6);
            panelDerechoContainer.Controls.Add(panelDetalleHeader);
            panelDerechoContainer.Controls.Add(panelEntregar);
            panelDerechoContainer.Controls.Add(panelEntregado);
            panelDerechoContainer.Controls.Add(panelCalificacion);

            panelDerecho.BorderRadius = 10;
            panelDerecho.FillColor = WHITE;
            panelDerecho.Location = new Point(429, 120);
            panelDerecho.Size = new Size(415, 405);
            panelDerecho.ShadowDecoration.Enabled = true;
            panelDerecho.ShadowDecoration.Depth = 4;
            panelDerecho.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            panelDerecho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            panelDerecho.Controls.Add(panelDerechoContainer);
        }

        private void ConfigurarDetalleHeader()
        {
            lblDetalleTitulo.AutoSize = false;
            lblDetalleTitulo.BackColor = Color.Transparent;
            lblDetalleTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDetalleTitulo.ForeColor = DARK;
            lblDetalleTitulo.Location = new Point(8, 8);
            lblDetalleTitulo.Size = new Size(390, 22);
            lblDetalleTitulo.Text = "Selecciona una tarea";

            lblDetalleEstado.AutoSize = false;
            lblDetalleEstado.BackColor = Color.FromArgb(255, 235, 180);
            lblDetalleEstado.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblDetalleEstado.ForeColor = Color.FromArgb(160, 90, 0);
            lblDetalleEstado.Location = new Point(8, 32);
            lblDetalleEstado.Size = new Size(85, 20);
            lblDetalleEstado.TextAlignment = ContentAlignment.MiddleCenter;
            lblDetalleEstado.Text = "Pendiente";

            lblDetalleMaestro.AutoSize = false;
            lblDetalleMaestro.BackColor = Color.Transparent;
            lblDetalleMaestro.Font = new Font("Segoe UI", 8F);
            lblDetalleMaestro.ForeColor = LABEL_COLOR;
            lblDetalleMaestro.Location = new Point(8, 55);
            lblDetalleMaestro.Size = new Size(390, 14);
            lblDetalleMaestro.Text = "👨‍🏫 Maestro";

            lblDetalleFecha.AutoSize = false;
            lblDetalleFecha.BackColor = Color.Transparent;
            lblDetalleFecha.Font = new Font("Segoe UI", 8F);
            lblDetalleFecha.ForeColor = LABEL_COLOR;
            lblDetalleFecha.Location = new Point(8, 71);
            lblDetalleFecha.Size = new Size(390, 14);
            lblDetalleFecha.Text = "📅 Entrega: -";

            lblDetalleDesc.AutoSize = false;
            lblDetalleDesc.BackColor = Color.Transparent;
            lblDetalleDesc.Font = new Font("Segoe UI", 8F);
            lblDetalleDesc.ForeColor = Color.FromArgb(100, 90, 75);
            lblDetalleDesc.Location = new Point(8, 87);
            lblDetalleDesc.Size = new Size(390, 50);
            lblDetalleDesc.Text = "";

            panelDetalleHeader.BorderRadius = 10;
            panelDetalleHeader.FillColor = Color.FromArgb(255, 248, 235);
            panelDetalleHeader.Location = new Point(0, 0);
            panelDetalleHeader.Size = new Size(408, 145);
            panelDetalleHeader.Margin = new Padding(0, 0, 0, 6);
            panelDetalleHeader.ShadowDecoration.Enabled = true;
            panelDetalleHeader.ShadowDecoration.Depth = 2;
            panelDetalleHeader.Controls.Add(lblDetalleTitulo);
            panelDetalleHeader.Controls.Add(lblDetalleEstado);
            panelDetalleHeader.Controls.Add(lblDetalleMaestro);
            panelDetalleHeader.Controls.Add(lblDetalleFecha);
            panelDetalleHeader.Controls.Add(lblDetalleDesc);
        }

        private void ConfigurarPanelEntregar()
        {
            lblArchivoLabel.AutoSize = false;
            lblArchivoLabel.BackColor = Color.Transparent;
            lblArchivoLabel.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblArchivoLabel.ForeColor = LABEL_COLOR;
            lblArchivoLabel.Location = new Point(8, 8);
            lblArchivoLabel.Size = new Size(390, 12);
            lblArchivoLabel.Text = "📎 ARCHIVO";

            btnSeleccionarArchivo.AutoRoundedCorners = true;
            btnSeleccionarArchivo.BorderRadius = 12;
            btnSeleccionarArchivo.Cursor = Cursors.Hand;
            btnSeleccionarArchivo.FillColor = Color.FromArgb(240, 232, 215);
            btnSeleccionarArchivo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnSeleccionarArchivo.ForeColor = Color.FromArgb(80, 70, 55);
            btnSeleccionarArchivo.HoverState.FillColor = YELLOW;
            btnSeleccionarArchivo.HoverState.ForeColor = Color.White;
            btnSeleccionarArchivo.Location = new Point(8, 22);
            btnSeleccionarArchivo.Size = new Size(390, 28);
            btnSeleccionarArchivo.Text = "📁 Seleccionar archivo";
            btnSeleccionarArchivo.Click += new EventHandler(btnSeleccionarArchivo_Click);

            lblArchivoSize.AutoSize = false;
            lblArchivoSize.BackColor = Color.Transparent;
            lblArchivoSize.Font = new Font("Segoe UI", 7F);
            lblArchivoSize.ForeColor = Color.FromArgb(100, 100, 100);
            lblArchivoSize.Location = new Point(8, 52);
            lblArchivoSize.Size = new Size(390, 12);
            lblArchivoSize.Text = "";

            txtNombreArchivo.BorderRadius = 6;
            txtNombreArchivo.DefaultText = "";
            txtNombreArchivo.FillColor = WHITE;
            txtNombreArchivo.FocusedState.BorderColor = YELLOW;
            txtNombreArchivo.Font = new Font("Segoe UI", 8F);
            txtNombreArchivo.Location = new Point(8, 66);
            txtNombreArchivo.PlaceholderText = "Archivo...";
            txtNombreArchivo.ReadOnly = true;
            txtNombreArchivo.Size = new Size(390, 26);

            lblComentarioLabel.AutoSize = false;
            lblComentarioLabel.BackColor = Color.Transparent;
            lblComentarioLabel.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblComentarioLabel.ForeColor = LABEL_COLOR;
            lblComentarioLabel.Location = new Point(8, 94);
            lblComentarioLabel.Size = new Size(390, 12);
            lblComentarioLabel.Text = "💬 COMENTARIO";

            txtComentario.BorderRadius = 6;
            txtComentario.DefaultText = "";
            txtComentario.FillColor = WHITE;
            txtComentario.FocusedState.BorderColor = YELLOW;
            txtComentario.Font = new Font("Segoe UI", 8F);
            txtComentario.Location = new Point(8, 108);
            txtComentario.Multiline = true;
            txtComentario.PlaceholderText = "Comentario...";
            txtComentario.Size = new Size(390, 45);

            btnEntregar.AutoRoundedCorners = true;
            btnEntregar.BorderRadius = 12;
            btnEntregar.Cursor = Cursors.Hand;
            btnEntregar.FillColor = YELLOW;
            btnEntregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEntregar.ForeColor = Color.White;
            btnEntregar.HoverState.FillColor = Color.FromArgb(220, 155, 0);
            btnEntregar.Location = new Point(8, 155);
            btnEntregar.Size = new Size(390, 36);
            btnEntregar.Text = "✅ Entregar Tarea";
            btnEntregar.ShadowDecoration.Enabled = true;
            btnEntregar.ShadowDecoration.Color = Color.FromArgb(40, 255, 183, 0);
            btnEntregar.ShadowDecoration.Depth = 4;
            btnEntregar.Click += new EventHandler(btnEntregar_Click);

            panelEntregar.BorderRadius = 10;
            panelEntregar.FillColor = WHITE;
            panelEntregar.Location = new Point(0, 151);
            panelEntregar.Size = new Size(408, 200);
            panelEntregar.Margin = new Padding(0, 0, 0, 6);
            panelEntregar.ShadowDecoration.Enabled = true;
            panelEntregar.ShadowDecoration.Depth = 2;
            panelEntregar.Visible = true;
            panelEntregar.Controls.Add(lblArchivoLabel);
            panelEntregar.Controls.Add(btnSeleccionarArchivo);
            panelEntregar.Controls.Add(lblArchivoSize);
            panelEntregar.Controls.Add(txtNombreArchivo);
            panelEntregar.Controls.Add(lblComentarioLabel);
            panelEntregar.Controls.Add(txtComentario);
            panelEntregar.Controls.Add(btnEntregar);
        }

        private void ConfigurarPanelEntregado()
        {
            lblEntregadoTitulo.AutoSize = false;
            lblEntregadoTitulo.BackColor = Color.Transparent;
            lblEntregadoTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEntregadoTitulo.ForeColor = Color.FromArgb(20, 120, 60);
            lblEntregadoTitulo.Location = new Point(8, 8);
            lblEntregadoTitulo.Size = new Size(390, 16);
            lblEntregadoTitulo.Text = "✅ Tarea entregada";

            lblArchivoEntregado.AutoSize = false;
            lblArchivoEntregado.BackColor = Color.Transparent;
            lblArchivoEntregado.Font = new Font("Segoe UI", 8F);
            lblArchivoEntregado.ForeColor = Color.FromArgb(30, 80, 180);
            lblArchivoEntregado.Location = new Point(8, 26);
            lblArchivoEntregado.Size = new Size(390, 14);
            lblArchivoEntregado.Text = "📄 Sin archivo";

            lblComentarioEntregado.AutoSize = false;
            lblComentarioEntregado.BackColor = Color.Transparent;
            lblComentarioEntregado.Font = new Font("Segoe UI", 8F);
            lblComentarioEntregado.ForeColor = LABEL_COLOR;
            lblComentarioEntregado.Location = new Point(8, 42);
            lblComentarioEntregado.Size = new Size(390, 28);
            lblComentarioEntregado.Text = "Sin comentario";

            panelEntregado.BorderRadius = 10;
            panelEntregado.FillColor = Color.FromArgb(225, 255, 235);
            panelEntregado.Location = new Point(0, 151);
            panelEntregado.Size = new Size(408, 80);
            panelEntregado.Margin = new Padding(0, 0, 0, 6);
            panelEntregado.ShadowDecoration.Enabled = true;
            panelEntregado.ShadowDecoration.Depth = 2;
            panelEntregado.Visible = false;
            panelEntregado.Controls.Add(lblEntregadoTitulo);
            panelEntregado.Controls.Add(lblArchivoEntregado);
            panelEntregado.Controls.Add(lblComentarioEntregado);
        }

        private void ConfigurarPanelCalificacion()
        {
            lblNotaTitulo.AutoSize = false;
            lblNotaTitulo.BackColor = Color.Transparent;
            lblNotaTitulo.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblNotaTitulo.ForeColor = LABEL_COLOR;
            lblNotaTitulo.Location = new Point(8, 8);
            lblNotaTitulo.Size = new Size(390, 12);
            lblNotaTitulo.Text = "🏆 CALIFICACIÓN";

            lblNota.AutoSize = false;
            lblNota.BackColor = Color.Transparent;
            lblNota.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblNota.ForeColor = Color.FromArgb(20, 120, 60);
            lblNota.Location = new Point(8, 22);
            lblNota.Size = new Size(100, 35);
            lblNota.Text = "-";

            lblFeedbackTitulo.AutoSize = false;
            lblFeedbackTitulo.BackColor = Color.Transparent;
            lblFeedbackTitulo.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblFeedbackTitulo.ForeColor = LABEL_COLOR;
            lblFeedbackTitulo.Location = new Point(8, 60);
            lblFeedbackTitulo.Size = new Size(390, 12);
            lblFeedbackTitulo.Text = "💭 COMENTARIO";

            lblFeedback.AutoSize = false;
            lblFeedback.BackColor = Color.Transparent;
            lblFeedback.Font = new Font("Segoe UI", 8F);
            lblFeedback.ForeColor = Color.FromArgb(60, 50, 40);
            lblFeedback.Location = new Point(8, 74);
            lblFeedback.Size = new Size(390, 40);
            lblFeedback.Text = "-";

            panelCalificacion.BorderRadius = 10;
            panelCalificacion.FillColor = Color.FromArgb(255, 252, 225);
            panelCalificacion.Location = new Point(0, 237);
            panelCalificacion.Size = new Size(408, 120);
            panelCalificacion.Margin = new Padding(0, 0, 0, 6);
            panelCalificacion.ShadowDecoration.Enabled = true;
            panelCalificacion.ShadowDecoration.Depth = 2;
            panelCalificacion.Visible = false;
            panelCalificacion.Controls.Add(lblNotaTitulo);
            panelCalificacion.Controls.Add(lblNota);
            panelCalificacion.Controls.Add(lblFeedbackTitulo);
            panelCalificacion.Controls.Add(lblFeedback);
        }
    }
}