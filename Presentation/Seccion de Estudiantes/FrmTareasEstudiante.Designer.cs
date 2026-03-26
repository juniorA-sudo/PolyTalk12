namespace Presentation.Seccion_de_Estudiantes
{
    partial class FrmTareasEstudiante
    {
        private System.ComponentModel.IContainer components = null;

        // Controles principales
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label accentBar;
        private System.Windows.Forms.Label lblTituloHeader;

        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel cardPendientes;
        private System.Windows.Forms.Label lblCntPendientes;
        private System.Windows.Forms.Label lblLblPendientes;
        private System.Windows.Forms.Panel cardEntregadas;
        private System.Windows.Forms.Label lblCntEntregadas;
        private System.Windows.Forms.Label lblLblEntregadas;
        private System.Windows.Forms.Panel cardVencidas;
        private System.Windows.Forms.Label lblCntVencidas;
        private System.Windows.Forms.Label lblLblVencidas;
        private System.Windows.Forms.Panel cardCalificadas;
        private System.Windows.Forms.Label lblCntCalificadas;
        private System.Windows.Forms.Label lblLblCalificadas;

        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btnFiltroTodas;
        private System.Windows.Forms.Button btnFiltroPendientes;
        private System.Windows.Forms.Button btnFiltroEntregadas;
        private System.Windows.Forms.Button btnFiltroVencidas;
        private System.Windows.Forms.Button btnFiltroCalificadas;

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.FlowLayoutPanel flpTareas;

        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Panel panelDerechoContainer;
        private System.Windows.Forms.Panel panelDetalleHeader;
        private System.Windows.Forms.Label lblDetalleTitulo;
        private System.Windows.Forms.Label lblDetalleEstado;
        private System.Windows.Forms.Label lblDetalleMaestro;
        private System.Windows.Forms.Label lblDetalleFecha;
        private System.Windows.Forms.Label lblDetalleDesc;

        private System.Windows.Forms.Panel panelEntregar;
        private System.Windows.Forms.Label lblArchivoLabel;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.Label lblArchivoSize;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label lblComentarioLabel;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnEntregar;

        private System.Windows.Forms.Panel panelEntregado;
        private System.Windows.Forms.Label lblEntregadoTitulo;
        private System.Windows.Forms.Label lblArchivoEntregado;
        private System.Windows.Forms.Label lblComentarioEntregado;

        private System.Windows.Forms.Panel panelCalificacion;
        private System.Windows.Forms.Label lblNotaTitulo;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblFeedbackTitulo;
        private System.Windows.Forms.Label lblFeedback;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTituloHeader = new Label();
            accentBar = new Label();
            panelStats = new Panel();
            cardPendientes = new Panel();
            lblCntPendientes = new Label();
            lblLblPendientes = new Label();
            cardEntregadas = new Panel();
            lblCntEntregadas = new Label();
            lblLblEntregadas = new Label();
            cardVencidas = new Panel();
            lblCntVencidas = new Label();
            lblLblVencidas = new Label();
            cardCalificadas = new Panel();
            lblCntCalificadas = new Label();
            lblLblCalificadas = new Label();
            panelFiltros = new Panel();
            btnFiltroTodas = new Button();
            btnFiltroPendientes = new Button();
            btnFiltroEntregadas = new Button();
            btnFiltroVencidas = new Button();
            btnFiltroCalificadas = new Button();
            panelIzquierdo = new Panel();
            flpTareas = new FlowLayoutPanel();
            panelDerecho = new Panel();
            panelDerechoContainer = new Panel();
            panelDetalleHeader = new Panel();
            lblDetalleTitulo = new Label();
            lblDetalleEstado = new Label();
            lblDetalleMaestro = new Label();
            lblDetalleFecha = new Label();
            lblDetalleDesc = new Label();
            panelEntregar = new Panel();
            lblArchivoLabel = new Label();
            btnSeleccionarArchivo = new Button();
            lblArchivoSize = new Label();
            txtNombreArchivo = new TextBox();
            lblComentarioLabel = new Label();
            txtComentario = new TextBox();
            btnEntregar = new Button();
            panelEntregado = new Panel();
            lblEntregadoTitulo = new Label();
            lblArchivoEntregado = new Label();
            lblComentarioEntregado = new Label();
            lblFeedback = new Label();
            panelCalificacion = new Panel();
            lblNotaTitulo = new Label();
            lblNota = new Label();
            lblFeedbackTitulo = new Label();
            panelHeader.SuspendLayout();
            panelStats.SuspendLayout();
            cardPendientes.SuspendLayout();
            cardEntregadas.SuspendLayout();
            cardVencidas.SuspendLayout();
            cardCalificadas.SuspendLayout();
            panelFiltros.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            panelDerecho.SuspendLayout();
            panelDerechoContainer.SuspendLayout();
            panelDetalleHeader.SuspendLayout();
            panelEntregar.SuspendLayout();
            panelEntregado.SuspendLayout();
            panelCalificacion.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTituloHeader);
            panelHeader.Controls.Add(accentBar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(854, 55);
            panelHeader.TabIndex = 0;
            // 
            // lblTituloHeader
            // 
            lblTituloHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloHeader.ForeColor = Color.FromArgb(51, 51, 51);
            lblTituloHeader.Location = new Point(20, 12);
            lblTituloHeader.Name = "lblTituloHeader";
            lblTituloHeader.Size = new Size(250, 35);
            lblTituloHeader.TabIndex = 0;
            lblTituloHeader.Text = "📚 Mis Tareas";
            // 
            // accentBar
            // 
            accentBar.BackColor = Color.FromArgb(249, 199, 79);
            accentBar.Dock = DockStyle.Left;
            accentBar.Location = new Point(0, 0);
            accentBar.Name = "accentBar";
            accentBar.Size = new Size(6, 55);
            accentBar.TabIndex = 1;
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.Transparent;
            panelStats.Controls.Add(cardPendientes);
            panelStats.Controls.Add(cardEntregadas);
            panelStats.Controls.Add(cardVencidas);
            panelStats.Controls.Add(cardCalificadas);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(0, 55);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(10, 8, 10, 8);
            panelStats.Size = new Size(854, 75);
            panelStats.TabIndex = 3;
            // 
            // cardPendientes
            // 
            cardPendientes.BackColor = Color.FromArgb(255, 248, 225);
            cardPendientes.BorderStyle = BorderStyle.FixedSingle;
            cardPendientes.Controls.Add(lblCntPendientes);
            cardPendientes.Controls.Add(lblLblPendientes);
            cardPendientes.Location = new Point(10, 8);
            cardPendientes.Name = "cardPendientes";
            cardPendientes.Size = new Size(100, 60);
            cardPendientes.TabIndex = 0;
            // 
            // lblCntPendientes
            // 
            lblCntPendientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCntPendientes.ForeColor = Color.FromArgb(51, 51, 51);
            lblCntPendientes.Location = new Point(8, 5);
            lblCntPendientes.Name = "lblCntPendientes";
            lblCntPendientes.Size = new Size(84, 30);
            lblCntPendientes.TabIndex = 0;
            lblCntPendientes.Text = "0";
            lblCntPendientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLblPendientes
            // 
            lblLblPendientes.Font = new Font("Segoe UI", 8.5F);
            lblLblPendientes.ForeColor = Color.FromArgb(130, 120, 100);
            lblLblPendientes.Location = new Point(8, 38);
            lblLblPendientes.Name = "lblLblPendientes";
            lblLblPendientes.Size = new Size(84, 15);
            lblLblPendientes.TabIndex = 1;
            lblLblPendientes.Text = "Pendientes";
            lblLblPendientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardEntregadas
            // 
            cardEntregadas.BackColor = Color.FromArgb(225, 240, 255);
            cardEntregadas.BorderStyle = BorderStyle.FixedSingle;
            cardEntregadas.Controls.Add(lblCntEntregadas);
            cardEntregadas.Controls.Add(lblLblEntregadas);
            cardEntregadas.Location = new Point(120, 8);
            cardEntregadas.Name = "cardEntregadas";
            cardEntregadas.Size = new Size(100, 60);
            cardEntregadas.TabIndex = 1;
            // 
            // lblCntEntregadas
            // 
            lblCntEntregadas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCntEntregadas.ForeColor = Color.FromArgb(51, 51, 51);
            lblCntEntregadas.Location = new Point(8, 5);
            lblCntEntregadas.Name = "lblCntEntregadas";
            lblCntEntregadas.Size = new Size(84, 30);
            lblCntEntregadas.TabIndex = 0;
            lblCntEntregadas.Text = "0";
            lblCntEntregadas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLblEntregadas
            // 
            lblLblEntregadas.Font = new Font("Segoe UI", 8.5F);
            lblLblEntregadas.ForeColor = Color.FromArgb(130, 120, 100);
            lblLblEntregadas.Location = new Point(8, 38);
            lblLblEntregadas.Name = "lblLblEntregadas";
            lblLblEntregadas.Size = new Size(84, 15);
            lblLblEntregadas.TabIndex = 1;
            lblLblEntregadas.Text = "Entregadas";
            lblLblEntregadas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardVencidas
            // 
            cardVencidas.BackColor = Color.FromArgb(255, 235, 235);
            cardVencidas.BorderStyle = BorderStyle.FixedSingle;
            cardVencidas.Controls.Add(lblCntVencidas);
            cardVencidas.Controls.Add(lblLblVencidas);
            cardVencidas.Location = new Point(230, 8);
            cardVencidas.Name = "cardVencidas";
            cardVencidas.Size = new Size(100, 60);
            cardVencidas.TabIndex = 2;
            // 
            // lblCntVencidas
            // 
            lblCntVencidas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCntVencidas.ForeColor = Color.FromArgb(51, 51, 51);
            lblCntVencidas.Location = new Point(8, 5);
            lblCntVencidas.Name = "lblCntVencidas";
            lblCntVencidas.Size = new Size(84, 30);
            lblCntVencidas.TabIndex = 0;
            lblCntVencidas.Text = "0";
            lblCntVencidas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLblVencidas
            // 
            lblLblVencidas.Font = new Font("Segoe UI", 8.5F);
            lblLblVencidas.ForeColor = Color.FromArgb(130, 120, 100);
            lblLblVencidas.Location = new Point(8, 38);
            lblLblVencidas.Name = "lblLblVencidas";
            lblLblVencidas.Size = new Size(84, 15);
            lblLblVencidas.TabIndex = 1;
            lblLblVencidas.Text = "Vencidas";
            lblLblVencidas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardCalificadas
            // 
            cardCalificadas.BackColor = Color.FromArgb(225, 255, 235);
            cardCalificadas.BorderStyle = BorderStyle.FixedSingle;
            cardCalificadas.Controls.Add(lblCntCalificadas);
            cardCalificadas.Controls.Add(lblLblCalificadas);
            cardCalificadas.Location = new Point(340, 8);
            cardCalificadas.Name = "cardCalificadas";
            cardCalificadas.Size = new Size(100, 60);
            cardCalificadas.TabIndex = 3;
            // 
            // lblCntCalificadas
            // 
            lblCntCalificadas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCntCalificadas.ForeColor = Color.FromArgb(51, 51, 51);
            lblCntCalificadas.Location = new Point(8, 5);
            lblCntCalificadas.Name = "lblCntCalificadas";
            lblCntCalificadas.Size = new Size(84, 30);
            lblCntCalificadas.TabIndex = 0;
            lblCntCalificadas.Text = "0";
            lblCntCalificadas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLblCalificadas
            // 
            lblLblCalificadas.Font = new Font("Segoe UI", 8.5F);
            lblLblCalificadas.ForeColor = Color.FromArgb(130, 120, 100);
            lblLblCalificadas.Location = new Point(8, 38);
            lblLblCalificadas.Name = "lblLblCalificadas";
            lblLblCalificadas.Size = new Size(84, 15);
            lblLblCalificadas.TabIndex = 1;
            lblLblCalificadas.Text = "Calificadas";
            lblLblCalificadas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFiltros
            // 
            panelFiltros.BackColor = Color.White;
            panelFiltros.Controls.Add(btnFiltroTodas);
            panelFiltros.Controls.Add(btnFiltroPendientes);
            panelFiltros.Controls.Add(btnFiltroEntregadas);
            panelFiltros.Controls.Add(btnFiltroVencidas);
            panelFiltros.Controls.Add(btnFiltroCalificadas);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(0, 130);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Padding = new Padding(10, 6, 10, 6);
            panelFiltros.Size = new Size(854, 45);
            panelFiltros.TabIndex = 2;
            // 
            // btnFiltroTodas
            // 
            btnFiltroTodas.BackColor = Color.FromArgb(249, 199, 79);
            btnFiltroTodas.Cursor = Cursors.Hand;
            btnFiltroTodas.FlatAppearance.BorderSize = 0;
            btnFiltroTodas.FlatStyle = FlatStyle.Flat;
            btnFiltroTodas.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnFiltroTodas.ForeColor = Color.White;
            btnFiltroTodas.Location = new Point(10, 6);
            btnFiltroTodas.Name = "btnFiltroTodas";
            btnFiltroTodas.Size = new Size(75, 30);
            btnFiltroTodas.TabIndex = 0;
            btnFiltroTodas.Text = "Todas";
            btnFiltroTodas.UseVisualStyleBackColor = false;
            btnFiltroTodas.Click += btnFiltroTodas_Click;
            // 
            // btnFiltroPendientes
            // 
            btnFiltroPendientes.BackColor = Color.FromArgb(240, 232, 215);
            btnFiltroPendientes.Cursor = Cursors.Hand;
            btnFiltroPendientes.FlatAppearance.BorderSize = 0;
            btnFiltroPendientes.FlatStyle = FlatStyle.Flat;
            btnFiltroPendientes.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnFiltroPendientes.ForeColor = Color.FromArgb(80, 70, 55);
            btnFiltroPendientes.Location = new Point(95, 6);
            btnFiltroPendientes.Name = "btnFiltroPendientes";
            btnFiltroPendientes.Size = new Size(75, 30);
            btnFiltroPendientes.TabIndex = 1;
            btnFiltroPendientes.Text = "Pendientes";
            btnFiltroPendientes.UseVisualStyleBackColor = false;
            btnFiltroPendientes.Click += btnFiltroPendientes_Click;
            // 
            // btnFiltroEntregadas
            // 
            btnFiltroEntregadas.BackColor = Color.FromArgb(240, 232, 215);
            btnFiltroEntregadas.Cursor = Cursors.Hand;
            btnFiltroEntregadas.FlatAppearance.BorderSize = 0;
            btnFiltroEntregadas.FlatStyle = FlatStyle.Flat;
            btnFiltroEntregadas.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnFiltroEntregadas.ForeColor = Color.FromArgb(80, 70, 55);
            btnFiltroEntregadas.Location = new Point(180, 6);
            btnFiltroEntregadas.Name = "btnFiltroEntregadas";
            btnFiltroEntregadas.Size = new Size(75, 30);
            btnFiltroEntregadas.TabIndex = 2;
            btnFiltroEntregadas.Text = "Entregadas";
            btnFiltroEntregadas.UseVisualStyleBackColor = false;
            btnFiltroEntregadas.Click += btnFiltroEntregadas_Click;
            // 
            // btnFiltroVencidas
            // 
            btnFiltroVencidas.BackColor = Color.FromArgb(240, 232, 215);
            btnFiltroVencidas.Cursor = Cursors.Hand;
            btnFiltroVencidas.FlatAppearance.BorderSize = 0;
            btnFiltroVencidas.FlatStyle = FlatStyle.Flat;
            btnFiltroVencidas.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnFiltroVencidas.ForeColor = Color.FromArgb(80, 70, 55);
            btnFiltroVencidas.Location = new Point(265, 6);
            btnFiltroVencidas.Name = "btnFiltroVencidas";
            btnFiltroVencidas.Size = new Size(75, 30);
            btnFiltroVencidas.TabIndex = 3;
            btnFiltroVencidas.Text = "Vencidas";
            btnFiltroVencidas.UseVisualStyleBackColor = false;
            btnFiltroVencidas.Click += btnFiltroVencidas_Click;
            // 
            // btnFiltroCalificadas
            // 
            btnFiltroCalificadas.BackColor = Color.FromArgb(240, 232, 215);
            btnFiltroCalificadas.Cursor = Cursors.Hand;
            btnFiltroCalificadas.FlatAppearance.BorderSize = 0;
            btnFiltroCalificadas.FlatStyle = FlatStyle.Flat;
            btnFiltroCalificadas.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnFiltroCalificadas.ForeColor = Color.FromArgb(80, 70, 55);
            btnFiltroCalificadas.Location = new Point(350, 6);
            btnFiltroCalificadas.Name = "btnFiltroCalificadas";
            btnFiltroCalificadas.Size = new Size(75, 30);
            btnFiltroCalificadas.TabIndex = 4;
            btnFiltroCalificadas.Text = "Calificadas";
            btnFiltroCalificadas.UseVisualStyleBackColor = false;
            btnFiltroCalificadas.Click += btnFiltroCalificadas_Click;
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelIzquierdo.BackColor = Color.White;
            panelIzquierdo.BorderStyle = BorderStyle.FixedSingle;
            panelIzquierdo.Controls.Add(flpTareas);
            panelIzquierdo.Location = new Point(10, 175);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(410, 350);
            panelIzquierdo.TabIndex = 1;
            // 
            // flpTareas
            // 
            flpTareas.AutoScroll = true;
            flpTareas.BackColor = Color.White;
            flpTareas.Dock = DockStyle.Fill;
            flpTareas.FlowDirection = FlowDirection.TopDown;
            flpTareas.Location = new Point(0, 0);
            flpTareas.Name = "flpTareas";
            flpTareas.Padding = new Padding(8);
            flpTareas.Size = new Size(408, 348);
            flpTareas.TabIndex = 0;
            flpTareas.WrapContents = false;
            // 
            // panelDerecho
            // 
            panelDerecho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDerecho.BackColor = Color.White;
            panelDerecho.BorderStyle = BorderStyle.FixedSingle;
            panelDerecho.Controls.Add(panelDerechoContainer);
            panelDerecho.Location = new Point(430, 175);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(410, 350);
            panelDerecho.TabIndex = 0;
            // 
            // panelDerechoContainer
            // 
            panelDerechoContainer.AutoScroll = true;
            panelDerechoContainer.BackColor = Color.White;
            panelDerechoContainer.Controls.Add(panelDetalleHeader);
            panelDerechoContainer.Controls.Add(panelEntregar);
            panelDerechoContainer.Controls.Add(panelEntregado);
            panelDerechoContainer.Controls.Add(lblFeedback);
            panelDerechoContainer.Controls.Add(panelCalificacion);
            panelDerechoContainer.Dock = DockStyle.Fill;
            panelDerechoContainer.Location = new Point(0, 0);
            panelDerechoContainer.Name = "panelDerechoContainer";
            panelDerechoContainer.Size = new Size(408, 348);
            panelDerechoContainer.TabIndex = 0;
            // 
            // panelDetalleHeader
            // 
            panelDetalleHeader.BackColor = Color.FromArgb(255, 248, 235);
            panelDetalleHeader.BorderStyle = BorderStyle.FixedSingle;
            panelDetalleHeader.Controls.Add(lblDetalleTitulo);
            panelDetalleHeader.Controls.Add(lblDetalleEstado);
            panelDetalleHeader.Controls.Add(lblDetalleMaestro);
            panelDetalleHeader.Controls.Add(lblDetalleFecha);
            panelDetalleHeader.Controls.Add(lblDetalleDesc);
            panelDetalleHeader.Location = new Point(0, 0);
            panelDetalleHeader.Margin = new Padding(0);
            panelDetalleHeader.Name = "panelDetalleHeader";
            panelDetalleHeader.Padding = new Padding(10);
            panelDetalleHeader.Size = new Size(408, 91);
            panelDetalleHeader.TabIndex = 0;
            // 
            // lblDetalleTitulo
            // 
            lblDetalleTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDetalleTitulo.ForeColor = Color.FromArgb(51, 51, 51);
            lblDetalleTitulo.Location = new Point(10, 8);
            lblDetalleTitulo.Name = "lblDetalleTitulo";
            lblDetalleTitulo.Size = new Size(242, 22);
            lblDetalleTitulo.TabIndex = 0;
            lblDetalleTitulo.Text = "Selecciona una tarea";
            // 
            // lblDetalleEstado
            // 
            lblDetalleEstado.BackColor = Color.FromArgb(255, 235, 180);
            lblDetalleEstado.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblDetalleEstado.ForeColor = Color.FromArgb(160, 90, 0);
            lblDetalleEstado.Location = new Point(308, 6);
            lblDetalleEstado.Name = "lblDetalleEstado";
            lblDetalleEstado.Size = new Size(85, 20);
            lblDetalleEstado.TabIndex = 1;
            lblDetalleEstado.Text = "Pendiente";
            lblDetalleEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDetalleMaestro
            // 
            lblDetalleMaestro.Font = new Font("Segoe UI", 8F);
            lblDetalleMaestro.ForeColor = Color.FromArgb(130, 120, 100);
            lblDetalleMaestro.Location = new Point(10, 35);
            lblDetalleMaestro.Name = "lblDetalleMaestro";
            lblDetalleMaestro.Size = new Size(380, 16);
            lblDetalleMaestro.TabIndex = 2;
            lblDetalleMaestro.Text = "👨‍🏫 Maestro: -";
            // 
            // lblDetalleFecha
            // 
            lblDetalleFecha.Font = new Font("Segoe UI", 8F);
            lblDetalleFecha.ForeColor = Color.FromArgb(130, 120, 100);
            lblDetalleFecha.Location = new Point(10, 53);
            lblDetalleFecha.Name = "lblDetalleFecha";
            lblDetalleFecha.Size = new Size(380, 16);
            lblDetalleFecha.TabIndex = 3;
            lblDetalleFecha.Text = "📅 Entrega: -";
            // 
            // lblDetalleDesc
            // 
            lblDetalleDesc.Font = new Font("Segoe UI", 7.5F);
            lblDetalleDesc.ForeColor = Color.FromArgb(100, 90, 75);
            lblDetalleDesc.Location = new Point(10, 72);
            lblDetalleDesc.Name = "lblDetalleDesc";
            lblDetalleDesc.Size = new Size(380, 45);
            lblDetalleDesc.TabIndex = 4;
            // 
            // panelEntregar
            // 
            panelEntregar.BackColor = Color.White;
            panelEntregar.BorderStyle = BorderStyle.FixedSingle;
            panelEntregar.Controls.Add(lblArchivoLabel);
            panelEntregar.Controls.Add(btnSeleccionarArchivo);
            panelEntregar.Controls.Add(lblArchivoSize);
            panelEntregar.Controls.Add(txtNombreArchivo);
            panelEntregar.Controls.Add(lblComentarioLabel);
            panelEntregar.Controls.Add(txtComentario);
            panelEntregar.Controls.Add(btnEntregar);
            panelEntregar.Dock = DockStyle.Bottom;
            panelEntregar.Location = new Point(0, 138);
            panelEntregar.Margin = new Padding(0);
            panelEntregar.Name = "panelEntregar";
            panelEntregar.Padding = new Padding(10);
            panelEntregar.Size = new Size(408, 210);
            panelEntregar.TabIndex = 1;
            panelEntregar.Visible = false;
            // 
            // lblArchivoLabel
            // 
            lblArchivoLabel.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblArchivoLabel.ForeColor = Color.FromArgb(130, 120, 100);
            lblArchivoLabel.Location = new Point(10, 8);
            lblArchivoLabel.Name = "lblArchivoLabel";
            lblArchivoLabel.Size = new Size(380, 13);
            lblArchivoLabel.TabIndex = 0;
            lblArchivoLabel.Text = "📎 ARCHIVO";
            // 
            // btnSeleccionarArchivo
            // 
            btnSeleccionarArchivo.BackColor = Color.FromArgb(240, 232, 215);
            btnSeleccionarArchivo.Cursor = Cursors.Hand;
            btnSeleccionarArchivo.FlatAppearance.BorderSize = 0;
            btnSeleccionarArchivo.FlatStyle = FlatStyle.Flat;
            btnSeleccionarArchivo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnSeleccionarArchivo.ForeColor = Color.FromArgb(80, 70, 55);
            btnSeleccionarArchivo.Location = new Point(10, 25);
            btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            btnSeleccionarArchivo.Size = new Size(380, 28);
            btnSeleccionarArchivo.TabIndex = 1;
            btnSeleccionarArchivo.Text = "📁 Seleccionar archivo";
            btnSeleccionarArchivo.UseVisualStyleBackColor = false;
            btnSeleccionarArchivo.Click += btnSeleccionarArchivo_Click;
            // 
            // lblArchivoSize
            // 
            lblArchivoSize.Font = new Font("Segoe UI", 7F);
            lblArchivoSize.ForeColor = Color.FromArgb(100, 100, 100);
            lblArchivoSize.Location = new Point(10, 57);
            lblArchivoSize.Name = "lblArchivoSize";
            lblArchivoSize.Size = new Size(380, 12);
            lblArchivoSize.TabIndex = 2;
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.BackColor = Color.White;
            txtNombreArchivo.BorderStyle = BorderStyle.FixedSingle;
            txtNombreArchivo.Font = new Font("Segoe UI", 8F);
            txtNombreArchivo.Location = new Point(10, 72);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.PlaceholderText = "Archivo seleccionado...";
            txtNombreArchivo.ReadOnly = true;
            txtNombreArchivo.Size = new Size(380, 22);
            txtNombreArchivo.TabIndex = 3;
            // 
            // lblComentarioLabel
            // 
            lblComentarioLabel.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblComentarioLabel.ForeColor = Color.FromArgb(130, 120, 100);
            lblComentarioLabel.Location = new Point(10, 99);
            lblComentarioLabel.Name = "lblComentarioLabel";
            lblComentarioLabel.Size = new Size(380, 13);
            lblComentarioLabel.TabIndex = 4;
            lblComentarioLabel.Text = "💬 COMENTARIO";
            // 
            // txtComentario
            // 
            txtComentario.BorderStyle = BorderStyle.FixedSingle;
            txtComentario.Font = new Font("Segoe UI", 8F);
            txtComentario.Location = new Point(10, 115);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.PlaceholderText = "Escribe un comentario...";
            txtComentario.Size = new Size(380, 40);
            txtComentario.TabIndex = 5;
            // 
            // btnEntregar
            // 
            btnEntregar.BackColor = Color.FromArgb(249, 199, 79);
            btnEntregar.Cursor = Cursors.Hand;
            btnEntregar.FlatAppearance.BorderSize = 0;
            btnEntregar.FlatStyle = FlatStyle.Flat;
            btnEntregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEntregar.ForeColor = Color.White;
            btnEntregar.Location = new Point(10, 158);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(380, 35);
            btnEntregar.TabIndex = 6;
            btnEntregar.Text = "✅ Entregar Tarea";
            btnEntregar.UseVisualStyleBackColor = false;
            btnEntregar.Click += btnEntregar_Click;
            // 
            // panelEntregado
            // 
            panelEntregado.BackColor = Color.FromArgb(225, 255, 235);
            panelEntregado.BorderStyle = BorderStyle.FixedSingle;
            panelEntregado.Controls.Add(lblEntregadoTitulo);
            panelEntregado.Controls.Add(lblArchivoEntregado);
            panelEntregado.Controls.Add(lblComentarioEntregado);
            panelEntregado.Location = new Point(0, 0);
            panelEntregado.Margin = new Padding(0);
            panelEntregado.Name = "panelEntregado";
            panelEntregado.Padding = new Padding(10);
            panelEntregado.Size = new Size(400, 85);
            panelEntregado.TabIndex = 2;
            panelEntregado.Visible = false;
            // 
            // lblEntregadoTitulo
            // 
            lblEntregadoTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEntregadoTitulo.ForeColor = Color.FromArgb(20, 120, 60);
            lblEntregadoTitulo.Location = new Point(10, 8);
            lblEntregadoTitulo.Name = "lblEntregadoTitulo";
            lblEntregadoTitulo.Size = new Size(380, 18);
            lblEntregadoTitulo.TabIndex = 0;
            lblEntregadoTitulo.Text = "✅ Tarea entregada";
            // 
            // lblArchivoEntregado
            // 
            lblArchivoEntregado.Font = new Font("Segoe UI", 8F);
            lblArchivoEntregado.ForeColor = Color.FromArgb(30, 80, 180);
            lblArchivoEntregado.Location = new Point(10, 30);
            lblArchivoEntregado.Name = "lblArchivoEntregado";
            lblArchivoEntregado.Size = new Size(380, 16);
            lblArchivoEntregado.TabIndex = 1;
            lblArchivoEntregado.Text = "📄 Sin archivo";
            // 
            // lblComentarioEntregado
            // 
            lblComentarioEntregado.Font = new Font("Segoe UI", 7.5F);
            lblComentarioEntregado.ForeColor = Color.FromArgb(130, 120, 100);
            lblComentarioEntregado.Location = new Point(10, 50);
            lblComentarioEntregado.Name = "lblComentarioEntregado";
            lblComentarioEntregado.Size = new Size(380, 40);
            lblComentarioEntregado.TabIndex = 2;
            lblComentarioEntregado.Text = "Sin comentario";
            // 
            // lblFeedback
            // 
            lblFeedback.Font = new Font("Segoe UI", 7.5F);
            lblFeedback.ForeColor = Color.FromArgb(60, 50, 40);
            lblFeedback.Location = new Point(-1, 91);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(409, 47);
            lblFeedback.TabIndex = 3;
            lblFeedback.Text = "-";
            // 
            // panelCalificacion
            // 
            panelCalificacion.BackColor = Color.FromArgb(255, 252, 225);
            panelCalificacion.BorderStyle = BorderStyle.FixedSingle;
            panelCalificacion.Controls.Add(lblNotaTitulo);
            panelCalificacion.Controls.Add(lblNota);
            panelCalificacion.Controls.Add(lblFeedbackTitulo);
            panelCalificacion.Location = new Point(0, 0);
            panelCalificacion.Margin = new Padding(0);
            panelCalificacion.Name = "panelCalificacion";
            panelCalificacion.Padding = new Padding(10);
            panelCalificacion.Size = new Size(400, 115);
            panelCalificacion.TabIndex = 3;
            panelCalificacion.Visible = false;
            // 
            // lblNotaTitulo
            // 
            lblNotaTitulo.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblNotaTitulo.ForeColor = Color.FromArgb(130, 120, 100);
            lblNotaTitulo.Location = new Point(10, 8);
            lblNotaTitulo.Name = "lblNotaTitulo";
            lblNotaTitulo.Size = new Size(380, 12);
            lblNotaTitulo.TabIndex = 0;
            lblNotaTitulo.Text = "🏆 CALIFICACIÓN";
            // 
            // lblNota
            // 
            lblNota.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblNota.ForeColor = Color.FromArgb(20, 120, 60);
            lblNota.Location = new Point(10, 22);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(100, 40);
            lblNota.TabIndex = 1;
            lblNota.Text = "-";
            lblNota.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFeedbackTitulo
            // 
            lblFeedbackTitulo.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblFeedbackTitulo.ForeColor = Color.FromArgb(130, 120, 100);
            lblFeedbackTitulo.Location = new Point(10, 66);
            lblFeedbackTitulo.Name = "lblFeedbackTitulo";
            lblFeedbackTitulo.Size = new Size(380, 12);
            lblFeedbackTitulo.TabIndex = 2;
            lblFeedbackTitulo.Text = "💭 COMENTARIO";
            // 
            // FrmTareasEstudiante
            // 
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(854, 535);
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            Controls.Add(panelFiltros);
            Controls.Add(panelStats);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTareasEstudiante";
            StartPosition = FormStartPosition.CenterParent;
            Load += FrmTareasEstudiante_Load;
            panelHeader.ResumeLayout(false);
            panelStats.ResumeLayout(false);
            cardPendientes.ResumeLayout(false);
            cardEntregadas.ResumeLayout(false);
            cardVencidas.ResumeLayout(false);
            cardCalificadas.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelIzquierdo.ResumeLayout(false);
            panelDerecho.ResumeLayout(false);
            panelDerechoContainer.ResumeLayout(false);
            panelDetalleHeader.ResumeLayout(false);
            panelEntregar.ResumeLayout(false);
            panelEntregar.PerformLayout();
            panelEntregado.ResumeLayout(false);
            panelCalificacion.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}