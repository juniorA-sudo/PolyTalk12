namespace Presentation.Seccion_de_Maestros
{
    partial class FrmCalificarTareas
    {
        private System.ComponentModel.IContainer components = null;

        // Colores PolyTalk
        private readonly Color COLOR_PRIMARY = Color.FromArgb(249, 199, 79);
        private readonly Color COLOR_BACKGROUND = Color.FromArgb(255, 247, 237);
        private readonly Color COLOR_WHITE = Color.White;
        private readonly Color COLOR_DARK = Color.FromArgb(51, 51, 51);
        private readonly Color COLOR_GRAY = Color.FromArgb(130, 120, 100);
        private readonly Color COLOR_ACCENT = Color.FromArgb(253, 62, 128);

        private Panel panelHeader;
        private Panel accentBar;
        private Label lblTitulo;
        private Label lblFecha;

        private SplitContainer splitContainerMain;
        private FlowLayoutPanel flpTareas;

        private SplitContainer splitContainer2;
        private FlowLayoutPanel flpEntregas;

        private Panel panelFormControls;
        private Label lblEstudiante;
        private Label lblEstudianteVal;
        private Label lblComentario;
        private RichTextBox txtComentario;
        private Label lblNota;
        private NumericUpDown nudNota;
        private Label lblFeedback;
        private RichTextBox txtFeedback;
        private Button btnCalificar;
        private Button btnLimpiar;
        private Button btnActualizar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            accentBar = new Panel();
            lblTitulo = new Label();
            lblFecha = new Label();
            splitContainerMain = new SplitContainer();
            flpTareas = new FlowLayoutPanel();
            splitContainer2 = new SplitContainer();
            flpEntregas = new FlowLayoutPanel();
            panelFormControls = new Panel();
            lblEstudiante = new Label();
            lblEstudianteVal = new Label();
            lblComentario = new Label();
            txtComentario = new RichTextBox();
            lblNota = new Label();
            nudNota = new NumericUpDown();
            lblFeedback = new Label();
            txtFeedback = new RichTextBox();
            btnCalificar = new Button();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            flpTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            panelFormControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNota).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(accentBar);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblFecha);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(854, 55);
            panelHeader.TabIndex = 1;
            // 
            // accentBar
            // 
            accentBar.Dock = DockStyle.Left;
            accentBar.Location = new Point(0, 0);
            accentBar.Name = "accentBar";
            accentBar.Size = new Size(6, 55);
            accentBar.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "📝 Calificar Tareas";
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 8.5F);
            lblFecha.Location = new Point(20, 38);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(300, 16);
            lblFecha.TabIndex = 2;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 55);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(flpTareas);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(splitContainer2);
            splitContainerMain.Size = new Size(854, 480);
            splitContainerMain.SplitterDistance = 683;
            splitContainerMain.SplitterWidth = 3;
            splitContainerMain.TabIndex = 0;
            // 
            // flpTareas
            // 
            flpTareas.AutoScroll = true;
            flpTareas.BackColor = Color.Transparent;
            flpTareas.Controls.Add(panelFormControls);
            flpTareas.Dock = DockStyle.Fill;
            flpTareas.FlowDirection = FlowDirection.TopDown;
            flpTareas.Location = new Point(0, 0);
            flpTareas.Name = "flpTareas";
            flpTareas.Padding = new Padding(10);
            flpTareas.Size = new Size(683, 480);
            flpTareas.TabIndex = 0;
            flpTareas.WrapContents = false;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(flpEntregas);
            splitContainer2.Size = new Size(168, 480);
            splitContainer2.SplitterDistance = 340;
            splitContainer2.SplitterWidth = 3;
            splitContainer2.TabIndex = 0;
            // 
            // flpEntregas
            // 
            flpEntregas.AutoScroll = true;
            flpEntregas.BackColor = Color.Transparent;
            flpEntregas.Dock = DockStyle.Fill;
            flpEntregas.FlowDirection = FlowDirection.TopDown;
            flpEntregas.Location = new Point(0, 0);
            flpEntregas.Name = "flpEntregas";
            flpEntregas.Padding = new Padding(10);
            flpEntregas.Size = new Size(168, 340);
            flpEntregas.TabIndex = 0;
            flpEntregas.WrapContents = false;
            // 
            // panelFormControls
            // 
            panelFormControls.Controls.Add(lblEstudiante);
            panelFormControls.Controls.Add(lblEstudianteVal);
            panelFormControls.Controls.Add(lblComentario);
            panelFormControls.Controls.Add(txtComentario);
            panelFormControls.Controls.Add(lblNota);
            panelFormControls.Controls.Add(nudNota);
            panelFormControls.Controls.Add(lblFeedback);
            panelFormControls.Controls.Add(txtFeedback);
            panelFormControls.Controls.Add(btnCalificar);
            panelFormControls.Controls.Add(btnLimpiar);
            panelFormControls.Controls.Add(btnActualizar);
            panelFormControls.Location = new Point(13, 13);
            panelFormControls.Name = "panelFormControls";
            panelFormControls.Padding = new Padding(10);
            panelFormControls.Size = new Size(383, 283);
            panelFormControls.TabIndex = 0;
            // 
            // lblEstudiante
            // 
            lblEstudiante.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblEstudiante.Location = new Point(10, 5);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(350, 14);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "👨‍🎓 ESTUDIANTE";
            // 
            // lblEstudianteVal
            // 
            lblEstudianteVal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstudianteVal.Location = new Point(10, 20);
            lblEstudianteVal.Name = "lblEstudianteVal";
            lblEstudianteVal.Size = new Size(350, 18);
            lblEstudianteVal.TabIndex = 1;
            lblEstudianteVal.Text = "—";
            // 
            // lblComentario
            // 
            lblComentario.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblComentario.Location = new Point(10, 45);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(350, 14);
            lblComentario.TabIndex = 2;
            lblComentario.Text = "💬 COMENTARIO";
            // 
            // txtComentario
            // 
            txtComentario.BackColor = Color.FromArgb(250, 250, 250);
            txtComentario.BorderStyle = BorderStyle.FixedSingle;
            txtComentario.Font = new Font("Segoe UI", 7.5F);
            txtComentario.Location = new Point(10, 60);
            txtComentario.Name = "txtComentario";
            txtComentario.ReadOnly = true;
            txtComentario.Size = new Size(350, 35);
            txtComentario.TabIndex = 3;
            txtComentario.Text = "";
            // 
            // lblNota
            // 
            lblNota.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblNota.Location = new Point(10, 102);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(180, 14);
            lblNota.TabIndex = 4;
            lblNota.Text = "⭐ CALIFICACIÓN (0-100)";
            // 
            // nudNota
            // 
            nudNota.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            nudNota.Location = new Point(10, 118);
            nudNota.Name = "nudNota";
            nudNota.Size = new Size(75, 27);
            nudNota.TabIndex = 5;
            nudNota.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFeedback
            // 
            lblFeedback.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblFeedback.Location = new Point(10, 152);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(350, 14);
            lblFeedback.TabIndex = 6;
            lblFeedback.Text = "💬 FEEDBACK";
            // 
            // txtFeedback
            // 
            txtFeedback.BorderStyle = BorderStyle.FixedSingle;
            txtFeedback.Font = new Font("Segoe UI", 7.5F);
            txtFeedback.Location = new Point(10, 168);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.Size = new Size(350, 40);
            txtFeedback.TabIndex = 7;
            txtFeedback.Text = "";
            // 
            // btnCalificar
            // 
            btnCalificar.Cursor = Cursors.Hand;
            btnCalificar.Enabled = false;
            btnCalificar.FlatAppearance.BorderSize = 0;
            btnCalificar.FlatStyle = FlatStyle.Flat;
            btnCalificar.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnCalificar.Location = new Point(10, 215);
            btnCalificar.Name = "btnCalificar";
            btnCalificar.Size = new Size(90, 30);
            btnCalificar.TabIndex = 8;
            btnCalificar.Text = "✅ Calificar";
            btnCalificar.Click += btnCalificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(220, 220, 220);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Enabled = false;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnLimpiar.Location = new Point(105, 215);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 30);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "🗑️ Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnActualizar.Location = new Point(200, 215);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 30);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "🔄 Actualizar";
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FrmCalificarTareas
            // 
            ClientSize = new Size(854, 535);
            Controls.Add(splitContainerMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCalificarTareas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calificar Tareas";
            Load += FrmCalificarTareas_Load;
            panelHeader.ResumeLayout(false);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            flpTareas.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panelFormControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudNota).EndInit();
            ResumeLayout(false);
        }
    }
}