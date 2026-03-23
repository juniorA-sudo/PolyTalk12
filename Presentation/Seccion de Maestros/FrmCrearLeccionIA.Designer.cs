using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Maestros
{
    partial class FrmCrearLeccionIA
    {
        private System.ComponentModel.IContainer components = null;

        // ── Header ──
        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTitulo;
        private Guna2HtmlLabel lblSubtitulo;
        private Button btnCerrar;

        // ── Panel izquierdo (config) ──
        private Guna2Panel panelIzquierdo;
        private Guna2HtmlLabel lblConfigLabel;
        private Guna2HtmlLabel lblNivelLabel;
        private Guna2ComboBox cmbNivel;
        private Guna2HtmlLabel lblUnidadLabel;
        private Guna2ComboBox cmbUnidad;
        private Guna2HtmlLabel lblTemaLabel;
        private Guna2TextBox txtTema;
        private Guna2HtmlLabel lblTemaHint;
        private Guna2Button btnGenerar;
        private ProgressBar progressGenerando;
        private Guna2HtmlLabel lblEstadoIA;

        // ── Panel derecho (resultado) ──
        private Guna2Panel panelResultado;
        private Guna2Panel panelResultadoInner;

        private Guna2HtmlLabel lblTituloGenLabel;
        private Guna2TextBox txtTituloGenerado;
        private Guna2HtmlLabel lblDescGenLabel;
        private Guna2TextBox txtDescripcionGenerada;
        private Guna2HtmlLabel lblTipoGenerado;

        private TabControl tabResultado;
        private TabPage tabContenido;
        private TabPage tabActividades;
        private RichTextBox rtbContenidoGenerado;
        private RichTextBox rtbActividadesGeneradas;

        private Guna2Panel panelBotones;
        private Guna2Button btnGuardar;
        private Guna2Button btnNuevaLeccion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Guna2Panel();
            lblTitulo = new Guna2HtmlLabel();
            lblSubtitulo = new Guna2HtmlLabel();
            btnCerrar = new Button();
            panelIzquierdo = new Guna2Panel();
            lblConfigLabel = new Guna2HtmlLabel();
            lblNivelLabel = new Guna2HtmlLabel();
            cmbNivel = new Guna2ComboBox();
            lblUnidadLabel = new Guna2HtmlLabel();
            cmbUnidad = new Guna2ComboBox();
            lblTemaLabel = new Guna2HtmlLabel();
            txtTema = new Guna2TextBox();
            lblTemaHint = new Guna2HtmlLabel();
            btnGenerar = new Guna2Button();
            progressGenerando = new ProgressBar();
            lblEstadoIA = new Guna2HtmlLabel();
            panelResultado = new Guna2Panel();
            panelResultadoInner = new Guna2Panel();
            lblTituloGenLabel = new Guna2HtmlLabel();
            txtTituloGenerado = new Guna2TextBox();
            lblDescGenLabel = new Guna2HtmlLabel();
            txtDescripcionGenerada = new Guna2TextBox();
            lblTipoGenerado = new Guna2HtmlLabel();
            tabResultado = new TabControl();
            tabContenido = new TabPage();
            tabActividades = new TabPage();
            rtbContenidoGenerado = new RichTextBox();
            rtbActividadesGeneradas = new RichTextBox();
            panelBotones = new Guna2Panel();
            btnGuardar = new Guna2Button();
            btnNuevaLeccion = new Guna2Button();

            panelHeader.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            panelResultado.SuspendLayout();
            panelResultadoInner.SuspendLayout();
            tabResultado.SuspendLayout();
            tabContenido.SuspendLayout();
            tabActividades.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();

            // ════════════════════════════════════════════════
            // HEADER
            // ════════════════════════════════════════════════
            panelHeader.FillColor = Color.FromArgb(15, 23, 42);
            panelHeader.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader.Size = new Size(854, 64);
            panelHeader.TabIndex = 0;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(btnCerrar);

            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 26);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "✨ Crear lección con IA";

            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new Point(21, 38);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(350, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "La IA genera explicación, actividades y vocabulario";

            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.ForeColor = Color.FromArgb(148, 163, 184);
            btnCerrar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnCerrar.Location = new Point(812, 16);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "✕";
            btnCerrar.Click += new System.EventHandler(btnCerrar_Click);

            // ════════════════════════════════════════════════
            // PANEL IZQUIERDO — CONFIGURACIÓN (280px)
            // ════════════════════════════════════════════════
            panelIzquierdo.BackColor = Color.FromArgb(248, 250, 252);
            panelIzquierdo.FillColor = Color.FromArgb(248, 250, 252);
            panelIzquierdo.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelIzquierdo.Location = new Point(0, 64);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Padding = new Padding(20, 16, 20, 16);
            panelIzquierdo.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelIzquierdo.Size = new Size(280, 471);
            panelIzquierdo.TabIndex = 1;
            panelIzquierdo.Controls.Add(lblConfigLabel);
            panelIzquierdo.Controls.Add(lblNivelLabel);
            panelIzquierdo.Controls.Add(cmbNivel);
            panelIzquierdo.Controls.Add(lblUnidadLabel);
            panelIzquierdo.Controls.Add(cmbUnidad);
            panelIzquierdo.Controls.Add(lblTemaLabel);
            panelIzquierdo.Controls.Add(txtTema);
            panelIzquierdo.Controls.Add(lblTemaHint);
            panelIzquierdo.Controls.Add(btnGenerar);
            panelIzquierdo.Controls.Add(progressGenerando);
            panelIzquierdo.Controls.Add(lblEstadoIA);

            lblConfigLabel.BackColor = Color.Transparent;
            lblConfigLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConfigLabel.ForeColor = Color.FromArgb(30, 41, 59);
            lblConfigLabel.Location = new Point(20, 16);
            lblConfigLabel.Name = "lblConfigLabel";
            lblConfigLabel.Size = new Size(240, 24);
            lblConfigLabel.TabIndex = 0;
            lblConfigLabel.Text = "Configurar lección";

            // Nivel
            lblNivelLabel.BackColor = Color.Transparent;
            lblNivelLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNivelLabel.ForeColor = Color.FromArgb(71, 85, 105);
            lblNivelLabel.Location = new Point(20, 52);
            lblNivelLabel.Name = "lblNivelLabel";
            lblNivelLabel.Size = new Size(240, 17);
            lblNivelLabel.TabIndex = 1;
            lblNivelLabel.Text = "Nivel MCER *";

            cmbNivel.BackColor = Color.Transparent;
            cmbNivel.BorderRadius = 8;
            cmbNivel.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbNivel.DrawMode = DrawMode.OwnerDrawFixed;
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.FillColor = Color.White;
            cmbNivel.Font = new Font("Segoe UI", 10F);
            cmbNivel.ForeColor = Color.FromArgb(30, 41, 59);
            cmbNivel.ItemHeight = 28;
            cmbNivel.Location = new Point(20, 72);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbNivel.Size = new Size(240, 36);
            cmbNivel.TabIndex = 2;
            cmbNivel.SelectedIndexChanged += new System.EventHandler(cmbNivel_SelectedIndexChanged);

            // Unidad
            lblUnidadLabel.BackColor = Color.Transparent;
            lblUnidadLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUnidadLabel.ForeColor = Color.FromArgb(71, 85, 105);
            lblUnidadLabel.Location = new Point(20, 118);
            lblUnidadLabel.Name = "lblUnidadLabel";
            lblUnidadLabel.Size = new Size(240, 17);
            lblUnidadLabel.TabIndex = 3;
            lblUnidadLabel.Text = "Unidad *";

            cmbUnidad.BackColor = Color.Transparent;
            cmbUnidad.BorderRadius = 8;
            cmbUnidad.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbUnidad.DrawMode = DrawMode.OwnerDrawFixed;
            cmbUnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidad.FillColor = Color.White;
            cmbUnidad.Font = new Font("Segoe UI", 10F);
            cmbUnidad.ForeColor = Color.FromArgb(30, 41, 59);
            cmbUnidad.ItemHeight = 28;
            cmbUnidad.Location = new Point(20, 138);
            cmbUnidad.Name = "cmbUnidad";
            cmbUnidad.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbUnidad.Size = new Size(240, 36);
            cmbUnidad.TabIndex = 4;

            // Tema
            lblTemaLabel.BackColor = Color.Transparent;
            lblTemaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTemaLabel.ForeColor = Color.FromArgb(71, 85, 105);
            lblTemaLabel.Location = new Point(20, 186);
            lblTemaLabel.Name = "lblTemaLabel";
            lblTemaLabel.Size = new Size(240, 17);
            lblTemaLabel.TabIndex = 5;
            lblTemaLabel.Text = "Tema de la lección *";

            txtTema.BorderRadius = 8;
            txtTema.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtTema.FillColor = Color.White;
            txtTema.FocusedState.BorderColor = Color.FromArgb(99, 102, 241);
            txtTema.Font = new Font("Segoe UI", 10F);
            txtTema.ForeColor = Color.FromArgb(30, 41, 59);
            txtTema.HoverState.BorderColor = Color.FromArgb(99, 102, 241);
            txtTema.Location = new Point(20, 206);
            txtTema.Multiline = true;
            txtTema.Name = "txtTema";
            txtTema.PlaceholderText = "Ej: Greetings and introductions, Present Simple, Colors...";
            txtTema.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtTema.Size = new Size(240, 70);
            txtTema.TabIndex = 6;

            lblTemaHint.BackColor = Color.Transparent;
            lblTemaHint.Font = new Font("Segoe UI", 8F);
            lblTemaHint.ForeColor = Color.FromArgb(148, 163, 184);
            lblTemaHint.Location = new Point(20, 280);
            lblTemaHint.Name = "lblTemaHint";
            lblTemaHint.Size = new Size(240, 30);
            lblTemaHint.TabIndex = 7;
            lblTemaHint.Text = "💡 Sé específico: \"Daily routines vocabulary A1\" genera mejor resultado";

            btnGenerar.BorderRadius = 10;
            btnGenerar.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnGenerar.FillColor = Color.FromArgb(99, 102, 241);
            btnGenerar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(20, 322);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnGenerar.ShadowDecoration.Depth = 6;
            btnGenerar.ShadowDecoration.Enabled = true;
            btnGenerar.ShadowDecoration.Color = Color.FromArgb(40, 99, 102, 241);
            btnGenerar.Size = new Size(240, 44);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "✨ Generar con IA";
            btnGenerar.Click += new System.EventHandler(btnGenerar_Click);

            progressGenerando.Location = new Point(20, 374);
            progressGenerando.Name = "progressGenerando";
            progressGenerando.Size = new Size(240, 8);
            progressGenerando.Style = ProgressBarStyle.Marquee;
            progressGenerando.TabIndex = 9;
            progressGenerando.Visible = false;

            lblEstadoIA.BackColor = Color.Transparent;
            lblEstadoIA.Font = new Font("Segoe UI", 8.5F);
            lblEstadoIA.ForeColor = Color.FromArgb(99, 102, 241);
            lblEstadoIA.Location = new Point(20, 388);
            lblEstadoIA.Name = "lblEstadoIA";
            lblEstadoIA.Size = new Size(240, 50);
            lblEstadoIA.TabIndex = 10;
            lblEstadoIA.Text = "";

            // ════════════════════════════════════════════════
            // PANEL DERECHO — RESULTADO
            // ════════════════════════════════════════════════
            panelResultado.BackColor = Color.White;
            panelResultado.FillColor = Color.White;
            panelResultado.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelResultado.Location = new Point(280, 64);
            panelResultado.Name = "panelResultado";
            panelResultado.Padding = new Padding(16, 12, 16, 0);
            panelResultado.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelResultado.Size = new Size(574, 471);
            panelResultado.TabIndex = 2;
            panelResultado.Visible = false;
            panelResultado.Controls.Add(panelResultadoInner);
            panelResultado.Controls.Add(panelBotones);

            panelResultadoInner.BackColor = Color.Transparent;
            panelResultadoInner.FillColor = Color.Transparent;
            panelResultadoInner.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelResultadoInner.Location = new Point(0, 0);
            panelResultadoInner.Name = "panelResultadoInner";
            panelResultadoInner.Padding = new Padding(16, 12, 16, 0);
            panelResultadoInner.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelResultadoInner.Size = new Size(574, 415);
            panelResultadoInner.TabIndex = 0;
            panelResultadoInner.Controls.Add(lblTituloGenLabel);
            panelResultadoInner.Controls.Add(txtTituloGenerado);
            panelResultadoInner.Controls.Add(lblDescGenLabel);
            panelResultadoInner.Controls.Add(txtDescripcionGenerada);
            panelResultadoInner.Controls.Add(lblTipoGenerado);
            panelResultadoInner.Controls.Add(tabResultado);

            lblTituloGenLabel.BackColor = Color.Transparent;
            lblTituloGenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTituloGenLabel.ForeColor = Color.FromArgb(71, 85, 105);
            lblTituloGenLabel.Location = new Point(16, 12);
            lblTituloGenLabel.Name = "lblTituloGenLabel";
            lblTituloGenLabel.Size = new Size(200, 17);
            lblTituloGenLabel.TabIndex = 0;
            lblTituloGenLabel.Text = "Título generado (editable)";

            txtTituloGenerado.BorderRadius = 8;
            txtTituloGenerado.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtTituloGenerado.FillColor = Color.FromArgb(248, 250, 252);
            txtTituloGenerado.FocusedState.BorderColor = Color.FromArgb(99, 102, 241);
            txtTituloGenerado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTituloGenerado.ForeColor = Color.FromArgb(30, 41, 59);
            txtTituloGenerado.Location = new Point(16, 32);
            txtTituloGenerado.Name = "txtTituloGenerado";
            txtTituloGenerado.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtTituloGenerado.Size = new Size(380, 34);
            txtTituloGenerado.TabIndex = 1;

            lblTipoGenerado.BackColor = Color.Transparent;
            lblTipoGenerado.Font = new Font("Segoe UI", 9F);
            lblTipoGenerado.ForeColor = Color.FromArgb(99, 102, 241);
            lblTipoGenerado.Location = new Point(408, 42);
            lblTipoGenerado.Name = "lblTipoGenerado";
            lblTipoGenerado.Size = new Size(145, 17);
            lblTipoGenerado.TabIndex = 2;
            lblTipoGenerado.Text = "Tipo: grammar · 20 min";

            lblDescGenLabel.BackColor = Color.Transparent;
            lblDescGenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescGenLabel.ForeColor = Color.FromArgb(71, 85, 105);
            lblDescGenLabel.Location = new Point(16, 74);
            lblDescGenLabel.Name = "lblDescGenLabel";
            lblDescGenLabel.Size = new Size(200, 17);
            lblDescGenLabel.TabIndex = 3;
            lblDescGenLabel.Text = "Descripción (editable)";

            txtDescripcionGenerada.BorderRadius = 8;
            txtDescripcionGenerada.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtDescripcionGenerada.FillColor = Color.FromArgb(248, 250, 252);
            txtDescripcionGenerada.FocusedState.BorderColor = Color.FromArgb(99, 102, 241);
            txtDescripcionGenerada.Font = new Font("Segoe UI", 10F);
            txtDescripcionGenerada.ForeColor = Color.FromArgb(30, 41, 59);
            txtDescripcionGenerada.Location = new Point(16, 94);
            txtDescripcionGenerada.Name = "txtDescripcionGenerada";
            txtDescripcionGenerada.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtDescripcionGenerada.Size = new Size(540, 34);
            txtDescripcionGenerada.TabIndex = 4;

            // TabControl para contenido y actividades
            tabResultado.Font = new Font("Segoe UI", 9.5F);
            tabResultado.Location = new Point(16, 138);
            tabResultado.Name = "tabResultado";
            tabResultado.SelectedIndex = 0;
            tabResultado.Size = new Size(540, 265);
            tabResultado.TabIndex = 5;
            tabResultado.Controls.Add(tabContenido);
            tabResultado.Controls.Add(tabActividades);

            tabContenido.BackColor = Color.White;
            tabContenido.Font = new Font("Segoe UI", 9F);
            tabContenido.Location = new Point(4, 24);
            tabContenido.Name = "tabContenido";
            tabContenido.Padding = new Padding(4);
            tabContenido.Size = new Size(532, 237);
            tabContenido.TabIndex = 0;
            tabContenido.Text = "📖 Explicación";
            tabContenido.Controls.Add(rtbContenidoGenerado);

            tabActividades.BackColor = Color.White;
            tabActividades.Font = new Font("Segoe UI", 9F);
            tabActividades.Location = new Point(4, 24);
            tabActividades.Name = "tabActividades";
            tabActividades.Padding = new Padding(4);
            tabActividades.Size = new Size(532, 237);
            tabActividades.TabIndex = 1;
            tabActividades.Text = "✏️ Actividades (5)";
            tabActividades.Controls.Add(rtbActividadesGeneradas);

            rtbContenidoGenerado.BackColor = Color.White;
            rtbContenidoGenerado.BorderStyle = BorderStyle.None;
            rtbContenidoGenerado.Dock = DockStyle.Fill;
            rtbContenidoGenerado.Font = new Font("Segoe UI", 10F);
            rtbContenidoGenerado.ForeColor = Color.FromArgb(30, 41, 59);
            rtbContenidoGenerado.Name = "rtbContenidoGenerado";
            rtbContenidoGenerado.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbContenidoGenerado.TabIndex = 0;

            rtbActividadesGeneradas.BackColor = Color.White;
            rtbActividadesGeneradas.BorderStyle = BorderStyle.None;
            rtbActividadesGeneradas.Dock = DockStyle.Fill;
            rtbActividadesGeneradas.Font = new Font("Segoe UI", 10F);
            rtbActividadesGeneradas.ForeColor = Color.FromArgb(30, 41, 59);
            rtbActividadesGeneradas.Name = "rtbActividadesGeneradas";
            rtbActividadesGeneradas.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbActividadesGeneradas.TabIndex = 0;

            // ── Panel botones ──
            panelBotones.BackColor = Color.FromArgb(248, 250, 252);
            panelBotones.FillColor = Color.FromArgb(248, 250, 252);
            panelBotones.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 415);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(16, 10, 16, 10);
            panelBotones.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelBotones.Size = new Size(574, 56);
            panelBotones.TabIndex = 1;
            panelBotones.Controls.Add(btnGuardar);
            panelBotones.Controls.Add(btnNuevaLeccion);

            btnGuardar.BorderRadius = 8;
            btnGuardar.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnGuardar.FillColor = Color.FromArgb(22, 163, 74);
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(314, 8);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnGuardar.Size = new Size(220, 38);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "💾 Guardar lección en BD";
            btnGuardar.Click += new System.EventHandler(btnGuardar_Click);

            btnNuevaLeccion.BorderRadius = 8;
            btnNuevaLeccion.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnNuevaLeccion.FillColor = Color.FromArgb(243, 244, 246);
            btnNuevaLeccion.Font = new Font("Segoe UI", 10F);
            btnNuevaLeccion.ForeColor = Color.FromArgb(71, 85, 105);
            btnNuevaLeccion.Location = new Point(16, 8);
            btnNuevaLeccion.Name = "btnNuevaLeccion";
            btnNuevaLeccion.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnNuevaLeccion.Size = new Size(180, 38);
            btnNuevaLeccion.TabIndex = 1;
            btnNuevaLeccion.Text = "🔄 Crear otra lección";
            btnNuevaLeccion.Click += new System.EventHandler(btnNuevaLeccion_Click);

            // ════════════════════════════════════════════════
            // FORM
            // ════════════════════════════════════════════════
            BackColor = Color.White;
            ClientSize = new Size(854, 535);
            Controls.Add(panelIzquierdo);
            Controls.Add(panelResultado);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrearLeccionIA";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear lección con IA";
            Load += new System.EventHandler(FrmCrearLeccionIA_Load);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelResultado.ResumeLayout(false);
            panelResultadoInner.ResumeLayout(false);
            panelResultadoInner.PerformLayout();
            tabResultado.ResumeLayout(false);
            tabContenido.ResumeLayout(false);
            tabActividades.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}