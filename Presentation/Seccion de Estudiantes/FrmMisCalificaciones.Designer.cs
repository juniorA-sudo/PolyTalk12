using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Estudiantes
{
    partial class FrmMisCalificaciones
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblFecha;
        private FlowLayoutPanel flpCalificaciones;
        private Label lblMensaje;
        private Panel panelEstadísticas;
        private Label lblEstadísticas;
        private Label lblTotalLabel;
        private Label lblTotal;
        private Label lblCalificadasLabel;
        private Label lblCalificadas;
        private Label lblPromedioLabel;
        private Label lblPromedio;
        private ProgressBar pbarProgreso;
        private Panel panelFiltros;
        private Label lblFiltros;
        private ComboBox cmbEstado;
        private ComboBox cmbRango;
        private Button btnLimpiarFiltros;
        private TextBox txtBuscar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblFecha = new Label();
            flpCalificaciones = new FlowLayoutPanel();
            lblMensaje = new Label();
            panelEstadísticas = new Panel();
            lblEstadísticas = new Label();
            lblTotalLabel = new Label();
            lblTotal = new Label();
            lblCalificadasLabel = new Label();
            lblCalificadas = new Label();
            lblPromedioLabel = new Label();
            lblPromedio = new Label();
            pbarProgreso = new ProgressBar();
            panelFiltros = new Panel();
            lblFiltros = new Label();
            cmbEstado = new ComboBox();
            cmbRango = new ComboBox();
            btnLimpiarFiltros = new Button();
            txtBuscar = new TextBox();

            panelHeader.SuspendLayout();
            flpCalificaciones.SuspendLayout();
            panelEstadísticas.SuspendLayout();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = Color.FromArgb(255, 247, 237);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblFecha);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 60;
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20, 10, 20, 10);

            // lblTitulo
            lblTitulo.AutoSize = false;
            lblTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(51, 51, 51);
            lblTitulo.Location = new Point(20, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 30);
            lblTitulo.Text = "📊 Mis Calificaciones";

            // lblFecha
            lblFecha.AutoSize = false;
            lblFecha.Font = new Font("Segoe UI", 8.5F);
            lblFecha.ForeColor = Color.FromArgb(130, 120, 100);
            lblFecha.Location = new Point(20, 38);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(400, 16);

            // panelEstadísticas
            panelEstadísticas.BackColor = Color.White;
            panelEstadísticas.BorderStyle = BorderStyle.FixedSingle;
            panelEstadísticas.Controls.Add(lblEstadísticas);
            panelEstadísticas.Controls.Add(lblTotalLabel);
            panelEstadísticas.Controls.Add(lblTotal);
            panelEstadísticas.Controls.Add(lblCalificadasLabel);
            panelEstadísticas.Controls.Add(lblCalificadas);
            panelEstadísticas.Controls.Add(lblPromedioLabel);
            panelEstadísticas.Controls.Add(lblPromedio);
            panelEstadísticas.Controls.Add(pbarProgreso);
            panelEstadísticas.Dock = DockStyle.Top;
            panelEstadísticas.Height = 120;
            panelEstadísticas.Margin = new Padding(15, 10, 15, 10);
            panelEstadísticas.Name = "panelEstadísticas";
            panelEstadísticas.Padding = new Padding(15);

            // lblEstadísticas
            lblEstadísticas.AutoSize = false;
            lblEstadísticas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstadísticas.ForeColor = Color.FromArgb(130, 120, 100);
            lblEstadísticas.Location = new Point(15, 8);
            lblEstadísticas.Size = new Size(300, 16);
            lblEstadísticas.Text = "📈 RESUMEN DE CALIFICACIONES";

            // lblTotalLabel
            lblTotalLabel.AutoSize = false;
            lblTotalLabel.Font = new Font("Segoe UI", 8F);
            lblTotalLabel.ForeColor = Color.FromArgb(130, 120, 100);
            lblTotalLabel.Location = new Point(15, 28);
            lblTotalLabel.Size = new Size(80, 16);
            lblTotalLabel.Text = "Total tareas:";

            // lblTotal
            lblTotal.AutoSize = false;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(249, 199, 79);
            lblTotal.Location = new Point(100, 24);
            lblTotal.Size = new Size(50, 24);
            lblTotal.Text = "0";

            // lblCalificadasLabel
            lblCalificadasLabel.AutoSize = false;
            lblCalificadasLabel.Font = new Font("Segoe UI", 8F);
            lblCalificadasLabel.ForeColor = Color.FromArgb(130, 120, 100);
            lblCalificadasLabel.Location = new Point(160, 28);
            lblCalificadasLabel.Size = new Size(100, 16);
            lblCalificadasLabel.Text = "Calificadas:";

            // lblCalificadas
            lblCalificadas.AutoSize = false;
            lblCalificadas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCalificadas.ForeColor = Color.FromArgb(34, 139, 34);
            lblCalificadas.Location = new Point(265, 24);
            lblCalificadas.Size = new Size(50, 24);
            lblCalificadas.Text = "0";

            // lblPromedioLabel
            lblPromedioLabel.AutoSize = false;
            lblPromedioLabel.Font = new Font("Segoe UI", 8F);
            lblPromedioLabel.ForeColor = Color.FromArgb(130, 120, 100);
            lblPromedioLabel.Location = new Point(325, 28);
            lblPromedioLabel.Size = new Size(80, 16);
            lblPromedioLabel.Text = "Promedio:";

            // lblPromedio
            lblPromedio.AutoSize = false;
            lblPromedio.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPromedio.ForeColor = Color.FromArgb(51, 51, 51);
            lblPromedio.Location = new Point(410, 24);
            lblPromedio.Size = new Size(60, 24);
            lblPromedio.Text = "0.0";

            // pbarProgreso
            pbarProgreso.Location = new Point(15, 58);
            pbarProgreso.Name = "pbarProgreso";
            pbarProgreso.Size = new Size(455, 40);
            pbarProgreso.Style = ProgressBarStyle.Continuous;
            pbarProgreso.ForeColor = Color.FromArgb(249, 199, 79);

            // flpCalificaciones
            flpCalificaciones.Dock = DockStyle.Fill;
            flpCalificaciones.Location = new Point(0, 180);
            flpCalificaciones.Name = "flpCalificaciones";
            flpCalificaciones.AutoScroll = true;
            flpCalificaciones.FlowDirection = FlowDirection.TopDown;
            flpCalificaciones.WrapContents = false;
            flpCalificaciones.Padding = new Padding(10);
            flpCalificaciones.BackColor = Color.FromArgb(255, 247, 237);

            // lblMensaje
            lblMensaje.AutoSize = false;
            lblMensaje.Font = new Font("Segoe UI", 12F);
            lblMensaje.ForeColor = Color.FromArgb(130, 120, 100);
            lblMensaje.Location = new Point(200, 250);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(500, 100);
            lblMensaje.Text = "";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Visible = false;

            // panelFiltros
            panelFiltros.BackColor = Color.White;
            panelFiltros.BorderStyle = BorderStyle.FixedSingle;
            panelFiltros.Controls.Add(lblFiltros);
            panelFiltros.Controls.Add(txtBuscar);
            panelFiltros.Controls.Add(cmbEstado);
            panelFiltros.Controls.Add(cmbRango);
            panelFiltros.Controls.Add(btnLimpiarFiltros);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Height = 60;
            panelFiltros.Margin = new Padding(15, 10, 15, 0);
            panelFiltros.Padding = new Padding(15);

            // lblFiltros
            lblFiltros.AutoSize = false;
            lblFiltros.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFiltros.ForeColor = Color.FromArgb(130, 120, 100);
            lblFiltros.Location = new Point(15, 12);
            lblFiltros.Size = new Size(60, 16);
            lblFiltros.Text = "🔍 Filtros:";

            // cmbEstado
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 8.5F);
            cmbEstado.Items.AddRange(new object[] { "Todas", "Calificada", "Pendiente" });
            cmbEstado.Location = new Point(80, 10);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(100, 23);
            cmbEstado.SelectedIndex = 0;
            cmbEstado.SelectedIndexChanged += (s, e) => { CargarCalificaciones(); };

            // cmbRango
            cmbRango.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRango.Font = new Font("Segoe UI", 8.5F);
            cmbRango.Items.AddRange(new object[] { "Todas", "90-100", "80-89", "70-79", "60-69", "<60" });
            cmbRango.Location = new Point(190, 10);
            cmbRango.Name = "cmbRango";
            cmbRango.Size = new Size(100, 23);
            cmbRango.SelectedIndex = 0;
            cmbRango.SelectedIndexChanged += (s, e) => { CargarCalificaciones(); };

            // btnLimpiarFiltros
            btnLimpiarFiltros.BackColor = Color.FromArgb(240, 235, 225);
            btnLimpiarFiltros.Cursor = Cursors.Hand;
            btnLimpiarFiltros.Font = new Font("Segoe UI", 8F);
            btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltros.ForeColor = Color.FromArgb(120, 110, 90);
            btnLimpiarFiltros.Location = new Point(300, 10);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(80, 23);
            btnLimpiarFiltros.Text = "Limpiar";
            btnLimpiarFiltros.Click += (s, e) =>
            {
                cmbEstado.SelectedIndex = 0;
                cmbRango.SelectedIndex = 0;
                txtBuscar.Clear();
                CargarCalificaciones();
            };

            // txtBuscar
            txtBuscar.BackColor = Color.White;
            txtBuscar.Font = new Font("Segoe UI", 8.5F);
            txtBuscar.ForeColor = Color.FromArgb(130, 120, 100);
            txtBuscar.Location = new Point(400, 10);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(150, 23);
            txtBuscar.PlaceholderText = "🔍 Buscar tarea...";
            txtBuscar.TextChanged += (s, e) => { CargarCalificaciones(); };

            // FrmMisCalificaciones
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 247, 237);
            ClientSize = new Size(900, 600);
            Controls.Add(flpCalificaciones);
            Controls.Add(lblMensaje);
            Controls.Add(panelFiltros);
            Controls.Add(panelEstadísticas);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMisCalificaciones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mis Calificaciones";
            Load += FrmMisCalificaciones_Load;

            panelHeader.ResumeLayout(false);
            flpCalificaciones.ResumeLayout(false);
            panelEstadísticas.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
