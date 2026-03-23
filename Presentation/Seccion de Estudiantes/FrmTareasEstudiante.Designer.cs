using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Estudiantes
{
    partial class FrmTareasEstudiante
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Guna2Panel panelHeader;
        private System.Windows.Forms.Label accentBar;
        private Guna2HtmlLabel lblTituloHeader;

        // Stat cards
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

        // Lista
        private Guna2Panel panelIzquierdo;
        private FlowLayoutPanel flpTareas;

        // Detalle
        private Guna2Panel panelDerecho;
        private Guna2Panel panelDetalle;
        private Guna2Panel panelDetalleHeader;
        private Guna2HtmlLabel lblDetalleTitulo;
        private Guna2HtmlLabel lblDetalleEstado;
        private Guna2HtmlLabel lblDetalleMaestro;
        private Guna2HtmlLabel lblDetalleFecha;
        private Guna2HtmlLabel lblDetalleDesc;

        // Entregar
        private Guna2Panel panelEntregar;
        private Guna2HtmlLabel lblArchivoLabel;
        private Guna2TextBox txtNombreArchivo;
        private Guna2HtmlLabel lblComentarioLabel;
        private Guna2TextBox txtComentario;
        private Guna2Button btnEntregar;

        // Entregado
        private Guna2Panel panelEntregado;
        private Guna2HtmlLabel lblEntregadoTitulo;
        private Guna2HtmlLabel lblArchivoEntregado;
        private Guna2HtmlLabel lblComentarioEntregado;

        // Calificacion
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
            var ce15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            var ce36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            accentBar = new System.Windows.Forms.Label();
            panelHeader = new Guna2Panel();
            lblTituloHeader = new Guna2HtmlLabel();
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
            panelFiltros = new Guna2Panel();
            btnFiltroTodas = new Guna2Button();
            btnFiltroPendientes = new Guna2Button();
            btnFiltroEntregadas = new Guna2Button();
            btnFiltroVencidas = new Guna2Button();
            btnFiltroCalificadas = new Guna2Button();
            panelIzquierdo = new Guna2Panel();
            flpTareas = new FlowLayoutPanel();
            panelDerecho = new Guna2Panel();
            panelDetalle = new Guna2Panel();
            panelDetalleHeader = new Guna2Panel();
            lblDetalleTitulo = new Guna2HtmlLabel();
            lblDetalleEstado = new Guna2HtmlLabel();
            lblDetalleMaestro = new Guna2HtmlLabel();
            lblDetalleFecha = new Guna2HtmlLabel();
            lblDetalleDesc = new Guna2HtmlLabel();
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

            panelHeader.SuspendLayout();
            panelStats.SuspendLayout();
            cardPendientes.SuspendLayout();
            cardEntregadas.SuspendLayout();
            cardVencidas.SuspendLayout();
            cardCalificadas.SuspendLayout();
            panelFiltros.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            panelDetalleHeader.SuspendLayout();
            panelEntregar.SuspendLayout();
            panelEntregado.SuspendLayout();
            panelCalificacion.SuspendLayout();
            panelDetalle.SuspendLayout();
            panelDerecho.SuspendLayout();
            SuspendLayout();

            Color cream = Color.FromArgb(252, 248, 240);
            Color yellow = Color.FromArgb(255, 183, 0);
            Color dark = Color.FromArgb(25, 25, 35);
            Color cLbl = Color.FromArgb(130, 120, 100);
            Font fBold = new Font("Segoe UI", 8.5F, FontStyle.Bold);

            // ════════ ACCENT BAR + HEADER ════════
            accentBar.BackColor = yellow;
            accentBar.Location = new Point(0, 0);
            accentBar.Name = "accentBar";
            accentBar.Size = new Size(5, 70);
            accentBar.TabIndex = 99;
            accentBar.Text = "";

            lblTituloHeader.AutoSize = false;
            lblTituloHeader.BackColor = Color.Transparent;
            lblTituloHeader.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lblTituloHeader.ForeColor = dark;
            lblTituloHeader.Location = new Point(18, 18);
            lblTituloHeader.Name = "lblTituloHeader";
            lblTituloHeader.Size = new Size(300, 32);
            lblTituloHeader.TabIndex = 0;
            lblTituloHeader.Text = "Mis Tareas";

            panelHeader.CustomizableEdges = ce1;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.White;
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(854, 70);
            panelHeader.ShadowDecoration.CustomizableEdges = ce2;
            panelHeader.ShadowDecoration.Color = Color.FromArgb(14, 0, 0, 0);
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(accentBar);
            panelHeader.Controls.Add(lblTituloHeader);

            // ════════ STAT CARD — PENDIENTES ════════
            lblCntPendientes.AutoSize = false;
            lblCntPendientes.BackColor = Color.Transparent;
            lblCntPendientes.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblCntPendientes.ForeColor = Color.FromArgb(160, 90, 0);
            lblCntPendientes.Location = new Point(10, 8);
            lblCntPendientes.Name = "lblCntPendientes";
            lblCntPendientes.Size = new Size(80, 32);
            lblCntPendientes.TabIndex = 0;
            lblCntPendientes.Text = "0";
            lblCntPendientes.TextAlignment = ContentAlignment.MiddleLeft;

            lblLblPendientes.AutoSize = false;
            lblLblPendientes.BackColor = Color.Transparent;
            lblLblPendientes.Font = new Font("Segoe UI", 8.5F);
            lblLblPendientes.ForeColor = cLbl;
            lblLblPendientes.Location = new Point(10, 40);
            lblLblPendientes.Name = "lblLblPendientes";
            lblLblPendientes.Size = new Size(100, 16);
            lblLblPendientes.TabIndex = 1;
            lblLblPendientes.Text = "Pendientes";

            cardPendientes.BorderRadius = 14;
            cardPendientes.CustomizableEdges = ce3;
            cardPendientes.FillColor = Color.FromArgb(255, 248, 225);
            cardPendientes.Location = new Point(0, 8);
            cardPendientes.Name = "cardPendientes";
            cardPendientes.ShadowDecoration.CustomizableEdges = ce4;
            cardPendientes.ShadowDecoration.Depth = 4;
            cardPendientes.ShadowDecoration.Enabled = true;
            cardPendientes.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            cardPendientes.Size = new Size(120, 64);
            cardPendientes.TabIndex = 0;
            cardPendientes.Controls.Add(lblCntPendientes);
            cardPendientes.Controls.Add(lblLblPendientes);

            // ════════ STAT CARD — ENTREGADAS ════════
            lblCntEntregadas.AutoSize = false;
            lblCntEntregadas.BackColor = Color.Transparent;
            lblCntEntregadas.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblCntEntregadas.ForeColor = Color.FromArgb(30, 80, 180);
            lblCntEntregadas.Location = new Point(10, 8);
            lblCntEntregadas.Name = "lblCntEntregadas";
            lblCntEntregadas.Size = new Size(80, 32);
            lblCntEntregadas.TabIndex = 0;
            lblCntEntregadas.Text = "0";
            lblCntEntregadas.TextAlignment = ContentAlignment.MiddleLeft;

            lblLblEntregadas.AutoSize = false;
            lblLblEntregadas.BackColor = Color.Transparent;
            lblLblEntregadas.Font = new Font("Segoe UI", 8.5F);
            lblLblEntregadas.ForeColor = cLbl;
            lblLblEntregadas.Location = new Point(10, 40);
            lblLblEntregadas.Name = "lblLblEntregadas";
            lblLblEntregadas.Size = new Size(100, 16);
            lblLblEntregadas.TabIndex = 1;
            lblLblEntregadas.Text = "Entregadas";

            cardEntregadas.BorderRadius = 14;
            cardEntregadas.CustomizableEdges = ce5;
            cardEntregadas.FillColor = Color.FromArgb(225, 240, 255);
            cardEntregadas.Location = new Point(128, 8);
            cardEntregadas.Name = "cardEntregadas";
            cardEntregadas.ShadowDecoration.CustomizableEdges = ce6;
            cardEntregadas.ShadowDecoration.Depth = 4;
            cardEntregadas.ShadowDecoration.Enabled = true;
            cardEntregadas.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            cardEntregadas.Size = new Size(120, 64);
            cardEntregadas.TabIndex = 1;
            cardEntregadas.Controls.Add(lblCntEntregadas);
            cardEntregadas.Controls.Add(lblLblEntregadas);

            // ════════ STAT CARD — VENCIDAS ════════
            lblCntVencidas.AutoSize = false;
            lblCntVencidas.BackColor = Color.Transparent;
            lblCntVencidas.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblCntVencidas.ForeColor = Color.FromArgb(180, 30, 30);
            lblCntVencidas.Location = new Point(10, 8);
            lblCntVencidas.Name = "lblCntVencidas";
            lblCntVencidas.Size = new Size(80, 32);
            lblCntVencidas.TabIndex = 0;
            lblCntVencidas.Text = "0";
            lblCntVencidas.TextAlignment = ContentAlignment.MiddleLeft;

            lblLblVencidas.AutoSize = false;
            lblLblVencidas.BackColor = Color.Transparent;
            lblLblVencidas.Font = new Font("Segoe UI", 8.5F);
            lblLblVencidas.ForeColor = cLbl;
            lblLblVencidas.Location = new Point(10, 40);
            lblLblVencidas.Name = "lblLblVencidas";
            lblLblVencidas.Size = new Size(100, 16);
            lblLblVencidas.TabIndex = 1;
            lblLblVencidas.Text = "Vencidas";

            cardVencidas.BorderRadius = 14;
            cardVencidas.CustomizableEdges = ce7;
            cardVencidas.FillColor = Color.FromArgb(255, 235, 235);
            cardVencidas.Location = new Point(256, 8);
            cardVencidas.Name = "cardVencidas";
            cardVencidas.ShadowDecoration.CustomizableEdges = ce8;
            cardVencidas.ShadowDecoration.Depth = 4;
            cardVencidas.ShadowDecoration.Enabled = true;
            cardVencidas.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            cardVencidas.Size = new Size(120, 64);
            cardVencidas.TabIndex = 2;
            cardVencidas.Controls.Add(lblCntVencidas);
            cardVencidas.Controls.Add(lblLblVencidas);

            // ════════ STAT CARD — CALIFICADAS ════════
            lblCntCalificadas.AutoSize = false;
            lblCntCalificadas.BackColor = Color.Transparent;
            lblCntCalificadas.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblCntCalificadas.ForeColor = Color.FromArgb(20, 120, 60);
            lblCntCalificadas.Location = new Point(10, 8);
            lblCntCalificadas.Name = "lblCntCalificadas";
            lblCntCalificadas.Size = new Size(80, 32);
            lblCntCalificadas.TabIndex = 0;
            lblCntCalificadas.Text = "0";
            lblCntCalificadas.TextAlignment = ContentAlignment.MiddleLeft;

            lblLblCalificadas.AutoSize = false;
            lblLblCalificadas.BackColor = Color.Transparent;
            lblLblCalificadas.Font = new Font("Segoe UI", 8.5F);
            lblLblCalificadas.ForeColor = cLbl;
            lblLblCalificadas.Location = new Point(10, 40);
            lblLblCalificadas.Name = "lblLblCalificadas";
            lblLblCalificadas.Size = new Size(100, 16);
            lblLblCalificadas.TabIndex = 1;
            lblLblCalificadas.Text = "Calificadas";

            cardCalificadas.BorderRadius = 14;
            cardCalificadas.CustomizableEdges = ce9;
            cardCalificadas.FillColor = Color.FromArgb(225, 255, 235);
            cardCalificadas.Location = new Point(384, 8);
            cardCalificadas.Name = "cardCalificadas";
            cardCalificadas.ShadowDecoration.CustomizableEdges = ce10;
            cardCalificadas.ShadowDecoration.Depth = 4;
            cardCalificadas.ShadowDecoration.Enabled = true;
            cardCalificadas.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            cardCalificadas.Size = new Size(120, 64);
            cardCalificadas.TabIndex = 3;
            cardCalificadas.Controls.Add(lblCntCalificadas);
            cardCalificadas.Controls.Add(lblLblCalificadas);

            panelStats.CustomizableEdges = ce11;
            panelStats.FillColor = Color.Transparent;
            panelStats.Location = new Point(16, 76);
            panelStats.Name = "panelStats";
            panelStats.ShadowDecoration.CustomizableEdges = ce12;
            panelStats.Size = new Size(520, 80);
            panelStats.TabIndex = 1;
            panelStats.Controls.Add(cardPendientes);
            panelStats.Controls.Add(cardEntregadas);
            panelStats.Controls.Add(cardVencidas);
            panelStats.Controls.Add(cardCalificadas);

            // ════════ FILTROS ════════
            btnFiltroTodas.BorderRadius = 16;
            btnFiltroTodas.Cursor = Cursors.Hand;
            btnFiltroTodas.CustomizableEdges = ce13;
            btnFiltroTodas.FillColor = yellow;
            btnFiltroTodas.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnFiltroTodas.ForeColor = Color.White;
            btnFiltroTodas.HoverState.FillColor = Color.FromArgb(220, 155, 0);
            btnFiltroTodas.Location = new Point(0, 8);
            btnFiltroTodas.Name = "btnFiltroTodas";
            btnFiltroTodas.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnFiltroTodas.Size = new Size(90, 28);
            btnFiltroTodas.TabIndex = 0;
            btnFiltroTodas.Text = "Todas";
            btnFiltroTodas.Click += new System.EventHandler(btnFiltroTodas_Click);

            btnFiltroPendientes.BorderRadius = 16;
            btnFiltroPendientes.Cursor = Cursors.Hand;
            btnFiltroPendientes.CustomizableEdges = ce14;
            btnFiltroPendientes.FillColor = Color.FromArgb(240, 232, 215);
            btnFiltroPendientes.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnFiltroPendientes.ForeColor = Color.FromArgb(80, 70, 55);
            btnFiltroPendientes.HoverState.FillColor = yellow;
            btnFiltroPendientes.HoverState.ForeColor = Color.White;
            btnFiltroPendientes.Location = new Point(98, 8);
            btnFiltroPendientes.Name = "btnFiltroPendientes";
            btnFiltroPendientes.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnFiltroPendientes.Size = new Size(90, 28);
            btnFiltroPendientes.TabIndex = 1;
            btnFiltroPendientes.Text = "Pendiente";
            btnFiltroPendientes.Click += new System.EventHandler(btnFiltroPendientes_Click);

            btnFiltroEntregadas.BorderRadius = 16;
            btnFiltroEntregadas.Cursor = Cursors.Hand;
            btnFiltroEntregadas.CustomizableEdges = ce15;
            btnFiltroEntregadas.FillColor = Color.FromArgb(240, 232, 215);
            btnFiltroEntregadas.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnFiltroEntregadas.ForeColor = Color.FromArgb(80, 70, 55);
            btnFiltroEntregadas.HoverState.FillColor = yellow;
            btnFiltroEntregadas.HoverState.ForeColor = Color.White;
            btnFiltroEntregadas.Location = new Point(196, 8);
            btnFiltroEntregadas.Name = "btnFiltroEntregadas";
            btnFiltroEntregadas.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnFiltroEntregadas.Size = new Size(90, 28);
            btnFiltroEntregadas.TabIndex = 2;
            btnFiltroEntregadas.Text = "Entregada";
            btnFiltroEntregadas.Click += new System.EventHandler(btnFiltroEntregadas_Click);

            btnFiltroVencidas.BorderRadius = 16;
            btnFiltroVencidas.Cursor = Cursors.Hand;
            btnFiltroVencidas.CustomizableEdges = ce16;
            btnFiltroVencidas.FillColor = Color.FromArgb(240, 232, 215);
            btnFiltroVencidas.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnFiltroVencidas.ForeColor = Color.FromArgb(80, 70, 55);
            btnFiltroVencidas.HoverState.FillColor = yellow;
            btnFiltroVencidas.HoverState.ForeColor = Color.White;
            btnFiltroVencidas.Location = new Point(294, 8);
            btnFiltroVencidas.Name = "btnFiltroVencidas";
            btnFiltroVencidas.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnFiltroVencidas.Size = new Size(90, 28);
            btnFiltroVencidas.TabIndex = 3;
            btnFiltroVencidas.Text = "Vencida";
            btnFiltroVencidas.Click += new System.EventHandler(btnFiltroVencidas_Click);

            btnFiltroCalificadas.BorderRadius = 16;
            btnFiltroCalificadas.Cursor = Cursors.Hand;
            btnFiltroCalificadas.CustomizableEdges = ce17;
            btnFiltroCalificadas.FillColor = Color.FromArgb(240, 232, 215);
            btnFiltroCalificadas.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnFiltroCalificadas.ForeColor = Color.FromArgb(80, 70, 55);
            btnFiltroCalificadas.HoverState.FillColor = yellow;
            btnFiltroCalificadas.HoverState.ForeColor = Color.White;
            btnFiltroCalificadas.Location = new Point(392, 8);
            btnFiltroCalificadas.Name = "btnFiltroCalificadas";
            btnFiltroCalificadas.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnFiltroCalificadas.Size = new Size(90, 28);
            btnFiltroCalificadas.TabIndex = 4;
            btnFiltroCalificadas.Text = "Calificada";
            btnFiltroCalificadas.Click += new System.EventHandler(btnFiltroCalificadas_Click);

            panelFiltros.CustomizableEdges = ce18;
            panelFiltros.FillColor = Color.Transparent;
            panelFiltros.Location = new Point(16, 162);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.ShadowDecoration.CustomizableEdges = ce19;
            panelFiltros.Size = new Size(490, 44);
            panelFiltros.TabIndex = 2;
            panelFiltros.Controls.Add(btnFiltroTodas);
            panelFiltros.Controls.Add(btnFiltroPendientes);
            panelFiltros.Controls.Add(btnFiltroEntregadas);
            panelFiltros.Controls.Add(btnFiltroVencidas);
            panelFiltros.Controls.Add(btnFiltroCalificadas);

            // ════════ LISTA TAREAS ════════
            flpTareas.AutoScroll = true;
            flpTareas.BackColor = Color.Transparent;
            flpTareas.Dock = DockStyle.Fill;
            flpTareas.FlowDirection = FlowDirection.TopDown;
            flpTareas.Name = "flpTareas";
            flpTareas.Padding = new Padding(4, 4, 4, 4);
            flpTareas.TabIndex = 0;
            flpTareas.WrapContents = false;

            panelIzquierdo.BorderRadius = 16;
            panelIzquierdo.CustomizableEdges = ce20;
            panelIzquierdo.FillColor = Color.White;
            panelIzquierdo.Location = new Point(16, 212);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.ShadowDecoration.CustomizableEdges = ce21;
            panelIzquierdo.ShadowDecoration.Color = Color.FromArgb(14, 0, 0, 0);
            panelIzquierdo.ShadowDecoration.Depth = 6;
            panelIzquierdo.ShadowDecoration.Enabled = true;
            panelIzquierdo.Size = new Size(440, 308);
            panelIzquierdo.TabIndex = 3;
            panelIzquierdo.Controls.Add(flpTareas);

            // ════════ DETALLE HEADER ════════
            lblDetalleTitulo.AutoSize = false;
            lblDetalleTitulo.BackColor = Color.Transparent;
            lblDetalleTitulo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblDetalleTitulo.ForeColor = dark;
            lblDetalleTitulo.Location = new Point(14, 12);
            lblDetalleTitulo.Name = "lblDetalleTitulo";
            lblDetalleTitulo.Size = new Size(340, 24);
            lblDetalleTitulo.TabIndex = 0;
            lblDetalleTitulo.Text = "Selecciona una tarea";

            lblDetalleEstado.AutoSize = false;
            lblDetalleEstado.BackColor = Color.FromArgb(255, 235, 180);
            lblDetalleEstado.Font = fBold;
            lblDetalleEstado.ForeColor = Color.FromArgb(160, 90, 0);
            lblDetalleEstado.Location = new Point(14, 40);
            lblDetalleEstado.Name = "lblDetalleEstado";
            lblDetalleEstado.Size = new Size(110, 22);
            lblDetalleEstado.TabIndex = 1;
            lblDetalleEstado.Text = "Pendiente";
            lblDetalleEstado.TextAlignment = ContentAlignment.MiddleCenter;

            lblDetalleMaestro.AutoSize = false;
            lblDetalleMaestro.BackColor = Color.Transparent;
            lblDetalleMaestro.Font = new Font("Segoe UI", 9F);
            lblDetalleMaestro.ForeColor = cLbl;
            lblDetalleMaestro.Location = new Point(14, 68);
            lblDetalleMaestro.Name = "lblDetalleMaestro";
            lblDetalleMaestro.Size = new Size(350, 18);
            lblDetalleMaestro.TabIndex = 2;
            lblDetalleMaestro.Text = "Maestro";

            lblDetalleFecha.AutoSize = false;
            lblDetalleFecha.BackColor = Color.Transparent;
            lblDetalleFecha.Font = new Font("Segoe UI", 9F);
            lblDetalleFecha.ForeColor = cLbl;
            lblDetalleFecha.Location = new Point(14, 88);
            lblDetalleFecha.Name = "lblDetalleFecha";
            lblDetalleFecha.Size = new Size(350, 18);
            lblDetalleFecha.TabIndex = 3;
            lblDetalleFecha.Text = "Entrega: -";

            lblDetalleDesc.AutoSize = false;
            lblDetalleDesc.BackColor = Color.Transparent;
            lblDetalleDesc.Font = new Font("Segoe UI", 9F);
            lblDetalleDesc.ForeColor = Color.FromArgb(100, 90, 75);
            lblDetalleDesc.Location = new Point(14, 110);
            lblDetalleDesc.Name = "lblDetalleDesc";
            lblDetalleDesc.Size = new Size(350, 36);
            lblDetalleDesc.TabIndex = 4;
            lblDetalleDesc.Text = "";

            panelDetalleHeader.BorderRadius = 14;
            panelDetalleHeader.CustomizableEdges = ce22;
            panelDetalleHeader.FillColor = Color.FromArgb(255, 248, 235);
            panelDetalleHeader.Location = new Point(0, 0);
            panelDetalleHeader.Name = "panelDetalleHeader";
            panelDetalleHeader.ShadowDecoration.CustomizableEdges = ce23;
            panelDetalleHeader.Size = new Size(374, 155);
            panelDetalleHeader.TabIndex = 0;
            panelDetalleHeader.Controls.Add(lblDetalleTitulo);
            panelDetalleHeader.Controls.Add(lblDetalleEstado);
            panelDetalleHeader.Controls.Add(lblDetalleMaestro);
            panelDetalleHeader.Controls.Add(lblDetalleFecha);
            panelDetalleHeader.Controls.Add(lblDetalleDesc);

            // ════════ PANEL ENTREGAR ════════
            lblArchivoLabel.AutoSize = false;
            lblArchivoLabel.BackColor = Color.Transparent;
            lblArchivoLabel.Font = fBold;
            lblArchivoLabel.ForeColor = cLbl;
            lblArchivoLabel.Location = new Point(14, 12);
            lblArchivoLabel.Name = "lblArchivoLabel";
            lblArchivoLabel.Size = new Size(140, 16);
            lblArchivoLabel.TabIndex = 0;
            lblArchivoLabel.Text = "NOMBRE DEL ARCHIVO";

            txtNombreArchivo.BorderRadius = 10;
            txtNombreArchivo.CustomizableEdges = ce24;
            txtNombreArchivo.DefaultText = "";
            txtNombreArchivo.FillColor = Color.White;
            txtNombreArchivo.FocusedState.BorderColor = yellow;
            txtNombreArchivo.Font = new Font("Segoe UI", 10F);
            txtNombreArchivo.Location = new Point(14, 30);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.PlaceholderText = "tarea_unit3_juan.pdf";
            txtNombreArchivo.SelectedText = "";
            txtNombreArchivo.ShadowDecoration.CustomizableEdges = ce25;
            txtNombreArchivo.Size = new Size(346, 36);
            txtNombreArchivo.TabIndex = 1;

            lblComentarioLabel.AutoSize = false;
            lblComentarioLabel.BackColor = Color.Transparent;
            lblComentarioLabel.Font = fBold;
            lblComentarioLabel.ForeColor = cLbl;
            lblComentarioLabel.Location = new Point(14, 74);
            lblComentarioLabel.Name = "lblComentarioLabel";
            lblComentarioLabel.Size = new Size(100, 16);
            lblComentarioLabel.TabIndex = 2;
            lblComentarioLabel.Text = "COMENTARIO";

            txtComentario.BorderRadius = 10;
            txtComentario.CustomizableEdges = ce26;
            txtComentario.DefaultText = "";
            txtComentario.FillColor = Color.White;
            txtComentario.FocusedState.BorderColor = yellow;
            txtComentario.Font = new Font("Segoe UI", 10F);
            txtComentario.Location = new Point(14, 92);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.PlaceholderText = "Mensaje opcional para el maestro...";
            txtComentario.SelectedText = "";
            txtComentario.ShadowDecoration.CustomizableEdges = ce27;
            txtComentario.Size = new Size(346, 54);
            txtComentario.TabIndex = 3;

            btnEntregar.BorderRadius = 18;
            btnEntregar.Cursor = Cursors.Hand;
            btnEntregar.CustomizableEdges = ce28;
            btnEntregar.FillColor = yellow;
            btnEntregar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnEntregar.ForeColor = Color.White;
            btnEntregar.HoverState.FillColor = Color.FromArgb(220, 155, 0);
            btnEntregar.Location = new Point(14, 154);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.ShadowDecoration.CustomizableEdges = ce29;
            btnEntregar.ShadowDecoration.Color = Color.FromArgb(40, 255, 183, 0);
            btnEntregar.ShadowDecoration.Depth = 6;
            btnEntregar.ShadowDecoration.Enabled = true;
            btnEntregar.Size = new Size(346, 40);
            btnEntregar.TabIndex = 4;
            btnEntregar.Text = "Entregar Tarea";
            btnEntregar.Click += new System.EventHandler(btnEntregar_Click);

            panelEntregar.BorderRadius = 14;
            panelEntregar.CustomizableEdges = ce30;
            panelEntregar.FillColor = Color.White;
            panelEntregar.Location = new Point(0, 163);
            panelEntregar.Name = "panelEntregar";
            panelEntregar.ShadowDecoration.CustomizableEdges = ce31;
            panelEntregar.ShadowDecoration.Depth = 5;
            panelEntregar.ShadowDecoration.Enabled = true;
            panelEntregar.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            panelEntregar.Size = new Size(374, 202);
            panelEntregar.TabIndex = 1;
            panelEntregar.Visible = false;
            panelEntregar.Controls.Add(lblArchivoLabel);
            panelEntregar.Controls.Add(txtNombreArchivo);
            panelEntregar.Controls.Add(lblComentarioLabel);
            panelEntregar.Controls.Add(txtComentario);
            panelEntregar.Controls.Add(btnEntregar);

            // ════════ PANEL ENTREGADO ════════
            lblEntregadoTitulo.AutoSize = false;
            lblEntregadoTitulo.BackColor = Color.Transparent;
            lblEntregadoTitulo.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            lblEntregadoTitulo.ForeColor = Color.FromArgb(20, 120, 60);
            lblEntregadoTitulo.Location = new Point(14, 10);
            lblEntregadoTitulo.Name = "lblEntregadoTitulo";
            lblEntregadoTitulo.Size = new Size(200, 22);
            lblEntregadoTitulo.TabIndex = 0;
            lblEntregadoTitulo.Text = "Tarea entregada";

            lblArchivoEntregado.AutoSize = false;
            lblArchivoEntregado.BackColor = Color.Transparent;
            lblArchivoEntregado.Font = new Font("Segoe UI", 9F);
            lblArchivoEntregado.ForeColor = Color.FromArgb(30, 80, 180);
            lblArchivoEntregado.Location = new Point(14, 36);
            lblArchivoEntregado.Name = "lblArchivoEntregado";
            lblArchivoEntregado.Size = new Size(346, 18);
            lblArchivoEntregado.TabIndex = 1;
            lblArchivoEntregado.Text = "Sin archivo";

            lblComentarioEntregado.AutoSize = false;
            lblComentarioEntregado.BackColor = Color.Transparent;
            lblComentarioEntregado.Font = new Font("Segoe UI", 9F);
            lblComentarioEntregado.ForeColor = cLbl;
            lblComentarioEntregado.Location = new Point(14, 56);
            lblComentarioEntregado.Name = "lblComentarioEntregado";
            lblComentarioEntregado.Size = new Size(346, 18);
            lblComentarioEntregado.TabIndex = 2;
            lblComentarioEntregado.Text = "Sin comentario";

            panelEntregado.BorderRadius = 14;
            panelEntregado.CustomizableEdges = ce32;
            panelEntregado.FillColor = Color.FromArgb(225, 255, 235);
            panelEntregado.Location = new Point(0, 163);
            panelEntregado.Name = "panelEntregado";
            panelEntregado.ShadowDecoration.CustomizableEdges = ce33;
            panelEntregado.ShadowDecoration.Depth = 4;
            panelEntregado.ShadowDecoration.Enabled = true;
            panelEntregado.ShadowDecoration.Color = Color.FromArgb(10, 0, 0, 0);
            panelEntregado.Size = new Size(374, 86);
            panelEntregado.TabIndex = 2;
            panelEntregado.Visible = false;
            panelEntregado.Controls.Add(lblEntregadoTitulo);
            panelEntregado.Controls.Add(lblArchivoEntregado);
            panelEntregado.Controls.Add(lblComentarioEntregado);

            // ════════ PANEL CALIFICACION ════════
            lblNotaTitulo.AutoSize = false;
            lblNotaTitulo.BackColor = Color.Transparent;
            lblNotaTitulo.Font = fBold;
            lblNotaTitulo.ForeColor = cLbl;
            lblNotaTitulo.Location = new Point(14, 10);
            lblNotaTitulo.Name = "lblNotaTitulo";
            lblNotaTitulo.Size = new Size(100, 16);
            lblNotaTitulo.TabIndex = 0;
            lblNotaTitulo.Text = "CALIFICACION";

            lblNota.AutoSize = false;
            lblNota.BackColor = Color.Transparent;
            lblNota.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            lblNota.ForeColor = Color.FromArgb(20, 120, 60);
            lblNota.Location = new Point(14, 28);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(200, 40);
            lblNota.TabIndex = 1;
            lblNota.Text = "-";

            lblFeedbackTitulo.AutoSize = false;
            lblFeedbackTitulo.BackColor = Color.Transparent;
            lblFeedbackTitulo.Font = fBold;
            lblFeedbackTitulo.ForeColor = cLbl;
            lblFeedbackTitulo.Location = new Point(14, 72);
            lblFeedbackTitulo.Name = "lblFeedbackTitulo";
            lblFeedbackTitulo.Size = new Size(100, 16);
            lblFeedbackTitulo.TabIndex = 2;
            lblFeedbackTitulo.Text = "COMENTARIO";

            lblFeedback.AutoSize = false;
            lblFeedback.BackColor = Color.Transparent;
            lblFeedback.Font = new Font("Segoe UI", 9.5F);
            lblFeedback.ForeColor = Color.FromArgb(60, 50, 40);
            lblFeedback.Location = new Point(14, 90);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(346, 36);
            lblFeedback.TabIndex = 3;
            lblFeedback.Text = "-";

            panelCalificacion.BorderRadius = 14;
            panelCalificacion.CustomizableEdges = ce34;
            panelCalificacion.FillColor = Color.FromArgb(255, 252, 225);
            panelCalificacion.Location = new Point(0, 257);
            panelCalificacion.Name = "panelCalificacion";
            panelCalificacion.ShadowDecoration.CustomizableEdges = ce35;
            panelCalificacion.ShadowDecoration.Depth = 4;
            panelCalificacion.ShadowDecoration.Enabled = true;
            panelCalificacion.ShadowDecoration.Color = Color.FromArgb(10, 0, 0, 0);
            panelCalificacion.Size = new Size(374, 134);
            panelCalificacion.TabIndex = 3;
            panelCalificacion.Visible = false;
            panelCalificacion.Controls.Add(lblNotaTitulo);
            panelCalificacion.Controls.Add(lblNota);
            panelCalificacion.Controls.Add(lblFeedbackTitulo);
            panelCalificacion.Controls.Add(lblFeedback);

            // ════════ PANEL DETALLE WRAPPER ════════
            panelDetalle.CustomizableEdges = ce36;
            panelDetalle.FillColor = Color.Transparent;
            panelDetalle.Location = new Point(0, 0);
            panelDetalle.Name = "panelDetalle";
            panelDetalle.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelDetalle.Size = new Size(374, 420);
            panelDetalle.TabIndex = 0;
            panelDetalle.Visible = false;
            panelDetalle.Controls.Add(panelDetalleHeader);
            panelDetalle.Controls.Add(panelEntregar);
            panelDetalle.Controls.Add(panelEntregado);
            panelDetalle.Controls.Add(panelCalificacion);

            panelDerecho.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelDerecho.FillColor = Color.Transparent;
            panelDerecho.Location = new Point(470, 212);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelDerecho.Size = new Size(374, 310);
            panelDerecho.TabIndex = 4;
            panelDerecho.Controls.Add(panelDetalle);

            // ════════ FORM ════════
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = cream;
            ClientSize = new Size(854, 535);
            Controls.Add(panelHeader);
            Controls.Add(panelStats);
            Controls.Add(panelFiltros);
            Controls.Add(panelIzquierdo);
            Controls.Add(panelDerecho);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTareasEstudiante";
            Text = "Mis Tareas";
            Load += new System.EventHandler(FrmTareasEstudiante_Load);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStats.ResumeLayout(false);
            cardPendientes.ResumeLayout(false);
            cardEntregadas.ResumeLayout(false);
            cardVencidas.ResumeLayout(false);
            cardCalificadas.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelIzquierdo.ResumeLayout(false);
            panelDetalleHeader.ResumeLayout(false);
            panelDetalleHeader.PerformLayout();
            panelEntregar.ResumeLayout(false);
            panelEntregar.PerformLayout();
            panelEntregado.ResumeLayout(false);
            panelEntregado.PerformLayout();
            panelCalificacion.ResumeLayout(false);
            panelCalificacion.PerformLayout();
            panelDetalle.ResumeLayout(false);
            panelDerecho.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}