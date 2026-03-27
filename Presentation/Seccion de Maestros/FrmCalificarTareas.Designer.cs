namespace Presentation.Seccion_de_Maestros
{
    partial class FrmCalificarTareas
    {
        private System.ComponentModel.IContainer components = null;

        // Colores PolyTalk
        private readonly System.Drawing.Color COLOR_PRIMARY = System.Drawing.Color.FromArgb(249, 199, 79);
        private readonly System.Drawing.Color COLOR_BACKGROUND = System.Drawing.Color.FromArgb(255, 247, 237);
        private readonly System.Drawing.Color COLOR_WHITE = System.Drawing.Color.White;
        private readonly System.Drawing.Color COLOR_DARK = System.Drawing.Color.FromArgb(51, 51, 51);
        private readonly System.Drawing.Color COLOR_GRAY = System.Drawing.Color.FromArgb(130, 120, 100);
        private readonly System.Drawing.Color COLOR_ACCENT = System.Drawing.Color.FromArgb(253, 62, 128);

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel accentBar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.FlowLayoutPanel flpTareas;

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flpEntregas;

        private System.Windows.Forms.Panel panelFormControls;
        private System.Windows.Forms.Panel panelEstudiante;
        private System.Windows.Forms.Panel panelSeparador1;
        private System.Windows.Forms.Panel panelComentario;
        private System.Windows.Forms.Panel panelSeparador2;
        private System.Windows.Forms.Panel panelCalificacion;
        private System.Windows.Forms.Panel panelSeparador3;
        private System.Windows.Forms.Panel panelFeedback;
        private System.Windows.Forms.Panel panelBotones;

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblEstudianteVal;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.RichTextBox txtComentario;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.Label lblEstadoCalif;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.RichTextBox txtFeedback;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;

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
            panelBotones = new Panel();
            btnCalificar = new Button();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            panelFeedback = new Panel();
            lblFeedback = new Label();
            txtFeedback = new RichTextBox();
            panelSeparador3 = new Panel();
            panelCalificacion = new Panel();
            lblNota = new Label();
            nudNota = new NumericUpDown();
            lblEstadoCalif = new Label();
            panelSeparador2 = new Panel();
            panelComentario = new Panel();
            lblComentario = new Label();
            txtComentario = new RichTextBox();
            panelSeparador1 = new Panel();
            panelEstudiante = new Panel();
            lblEstudiante = new Label();
            lblEstudianteVal = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panelFormControls.SuspendLayout();
            panelBotones.SuspendLayout();
            panelFeedback.SuspendLayout();
            panelCalificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNota).BeginInit();
            panelComentario.SuspendLayout();
            panelEstudiante.SuspendLayout();
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
            splitContainerMain.SplitterDistance = 520;
            splitContainerMain.SplitterWidth = 2;
            splitContainerMain.TabIndex = 0;
            // 
            // flpTareas
            // 
            flpTareas.AutoScroll = true;
            flpTareas.Dock = DockStyle.Fill;
            flpTareas.FlowDirection = FlowDirection.TopDown;
            flpTareas.Location = new Point(0, 0);
            flpTareas.Name = "flpTareas";
            flpTareas.Padding = new Padding(10);
            flpTareas.Size = new Size(520, 480);
            flpTareas.TabIndex = 0;
            flpTareas.WrapContents = false;
            flpTareas.Paint += flpTareas_Paint;
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
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(panelFormControls);
            splitContainer2.Size = new Size(332, 480);
            splitContainer2.SplitterDistance = 240;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 0;
            // 
            // flpEntregas
            // 
            flpEntregas.AutoScroll = true;
            flpEntregas.Dock = DockStyle.Fill;
            flpEntregas.FlowDirection = FlowDirection.TopDown;
            flpEntregas.Location = new Point(0, 0);
            flpEntregas.Name = "flpEntregas";
            flpEntregas.Padding = new Padding(10);
            flpEntregas.Size = new Size(332, 240);
            flpEntregas.TabIndex = 0;
            flpEntregas.WrapContents = false;
            // 
            // panelFormControls
            // 
            panelFormControls.AutoScroll = true;
            panelFormControls.Controls.Add(panelBotones);
            panelFormControls.Controls.Add(panelFeedback);
            panelFormControls.Controls.Add(panelSeparador3);
            panelFormControls.Controls.Add(panelCalificacion);
            panelFormControls.Controls.Add(panelSeparador2);
            panelFormControls.Controls.Add(panelComentario);
            panelFormControls.Controls.Add(panelSeparador1);
            panelFormControls.Controls.Add(panelEstudiante);
            panelFormControls.Dock = DockStyle.Fill;
            panelFormControls.Location = new Point(0, 0);
            panelFormControls.Name = "panelFormControls";
            panelFormControls.Padding = new Padding(5);
            panelFormControls.Size = new Size(332, 238);
            panelFormControls.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.Transparent;
            panelBotones.Controls.Add(btnCalificar);
            panelBotones.Controls.Add(btnLimpiar);
            panelBotones.Controls.Add(btnActualizar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(5, 201);
            panelBotones.Margin = new Padding(0, 3, 0, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new Padding(8, 4, 8, 4);
            panelBotones.Size = new Size(305, 38);
            panelBotones.TabIndex = 7;
            // 
            // btnCalificar
            // 
            btnCalificar.Cursor = Cursors.Hand;
            btnCalificar.Enabled = false;
            btnCalificar.FlatAppearance.BorderSize = 0;
            btnCalificar.FlatStyle = FlatStyle.Flat;
            btnCalificar.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnCalificar.Location = new Point(8, 4);
            btnCalificar.Name = "btnCalificar";
            btnCalificar.Size = new Size(85, 28);
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
            btnLimpiar.Location = new Point(98, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 28);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "🗑️ Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(220, 220, 220);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnActualizar.Location = new Point(188, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 28);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "🔄 Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // panelFeedback
            // 
            panelFeedback.BorderStyle = BorderStyle.FixedSingle;
            panelFeedback.Controls.Add(lblFeedback);
            panelFeedback.Controls.Add(txtFeedback);
            panelFeedback.Dock = DockStyle.Fill;
            panelFeedback.Location = new Point(5, 206);
            panelFeedback.Margin = new Padding(0, 0, 0, 3);
            panelFeedback.Name = "panelFeedback";
            panelFeedback.Padding = new Padding(10, 5, 10, 5);
            panelFeedback.Size = new Size(305, 33);
            panelFeedback.TabIndex = 6;
            // 
            // lblFeedback
            // 
            lblFeedback.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblFeedback.Location = new Point(10, 3);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(300, 12);
            lblFeedback.TabIndex = 6;
            lblFeedback.Text = "💬 FEEDBACK";
            // 
            // txtFeedback
            // 
            txtFeedback.BorderStyle = BorderStyle.FixedSingle;
            txtFeedback.Font = new Font("Segoe UI", 7F);
            txtFeedback.Location = new Point(10, 16);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.Size = new Size(300, 100);
            txtFeedback.TabIndex = 7;
            txtFeedback.Text = "";
            // 
            // panelSeparador3
            // 
            panelSeparador3.Dock = DockStyle.Top;
            panelSeparador3.Location = new Point(5, 204);
            panelSeparador3.Margin = new Padding(0);
            panelSeparador3.Name = "panelSeparador3";
            panelSeparador3.Size = new Size(305, 2);
            panelSeparador3.TabIndex = 5;
            // 
            // panelCalificacion
            // 
            panelCalificacion.BorderStyle = BorderStyle.FixedSingle;
            panelCalificacion.Controls.Add(lblNota);
            panelCalificacion.Controls.Add(nudNota);
            panelCalificacion.Controls.Add(lblEstadoCalif);
            panelCalificacion.Dock = DockStyle.Top;
            panelCalificacion.Location = new Point(5, 139);
            panelCalificacion.Margin = new Padding(0, 0, 0, 3);
            panelCalificacion.Name = "panelCalificacion";
            panelCalificacion.Padding = new Padding(10, 5, 10, 5);
            panelCalificacion.Size = new Size(305, 65);
            panelCalificacion.TabIndex = 4;
            // 
            // lblNota
            // 
            lblNota.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblNota.Location = new Point(10, 3);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(300, 12);
            lblNota.TabIndex = 4;
            lblNota.Text = "⭐ CALIFICACIÓN (0-100)";
            // 
            // nudNota
            // 
            nudNota.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            nudNota.Location = new Point(10, 18);
            nudNota.Name = "nudNota";
            nudNota.Size = new Size(70, 29);
            nudNota.TabIndex = 5;
            nudNota.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEstadoCalif
            // 
            lblEstadoCalif.Font = new Font("Segoe UI", 7F);
            lblEstadoCalif.Location = new Point(85, 22);
            lblEstadoCalif.Name = "lblEstadoCalif";
            lblEstadoCalif.Size = new Size(225, 16);
            lblEstadoCalif.TabIndex = 11;
            lblEstadoCalif.Text = "Puntos";
            // 
            // panelSeparador2
            // 
            panelSeparador2.Dock = DockStyle.Top;
            panelSeparador2.Location = new Point(5, 137);
            panelSeparador2.Margin = new Padding(0);
            panelSeparador2.Name = "panelSeparador2";
            panelSeparador2.Size = new Size(305, 2);
            panelSeparador2.TabIndex = 3;
            // 
            // panelComentario
            // 
            panelComentario.BorderStyle = BorderStyle.FixedSingle;
            panelComentario.Controls.Add(lblComentario);
            panelComentario.Controls.Add(txtComentario);
            panelComentario.Dock = DockStyle.Top;
            panelComentario.Location = new Point(5, 67);
            panelComentario.Margin = new Padding(0, 0, 0, 3);
            panelComentario.Name = "panelComentario";
            panelComentario.Padding = new Padding(10, 5, 10, 5);
            panelComentario.Size = new Size(305, 70);
            panelComentario.TabIndex = 2;
            // 
            // lblComentario
            // 
            lblComentario.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblComentario.Location = new Point(10, 3);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(300, 12);
            lblComentario.TabIndex = 2;
            lblComentario.Text = "💬 COMENTARIO";
            // 
            // txtComentario
            // 
            txtComentario.BackColor = Color.FromArgb(250, 250, 250);
            txtComentario.BorderStyle = BorderStyle.FixedSingle;
            txtComentario.Font = new Font("Segoe UI", 7F);
            txtComentario.Location = new Point(10, 16);
            txtComentario.Name = "txtComentario";
            txtComentario.ReadOnly = true;
            txtComentario.Size = new Size(291, 44);
            txtComentario.TabIndex = 3;
            txtComentario.Text = "";
            // 
            // panelSeparador1
            // 
            panelSeparador1.Dock = DockStyle.Top;
            panelSeparador1.Location = new Point(5, 65);
            panelSeparador1.Margin = new Padding(0);
            panelSeparador1.Name = "panelSeparador1";
            panelSeparador1.Size = new Size(305, 2);
            panelSeparador1.TabIndex = 1;
            // 
            // panelEstudiante
            // 
            panelEstudiante.BorderStyle = BorderStyle.FixedSingle;
            panelEstudiante.Controls.Add(lblEstudiante);
            panelEstudiante.Controls.Add(lblEstudianteVal);
            panelEstudiante.Dock = DockStyle.Top;
            panelEstudiante.Location = new Point(5, 5);
            panelEstudiante.Margin = new Padding(0, 0, 0, 3);
            panelEstudiante.Name = "panelEstudiante";
            panelEstudiante.Padding = new Padding(10, 5, 10, 5);
            panelEstudiante.Size = new Size(305, 60);
            panelEstudiante.TabIndex = 0;
            // 
            // lblEstudiante
            // 
            lblEstudiante.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblEstudiante.Location = new Point(10, 3);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(300, 13);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "👨‍🎓 ESTUDIANTE";
            // 
            // lblEstudianteVal
            // 
            lblEstudianteVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstudianteVal.Location = new Point(10, 17);
            lblEstudianteVal.Name = "lblEstudianteVal";
            lblEstudianteVal.Size = new Size(300, 35);
            lblEstudianteVal.TabIndex = 1;
            lblEstudianteVal.Text = "—";
            // 
            // FrmCalificarTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 240);
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
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panelFormControls.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            panelFeedback.ResumeLayout(false);
            panelCalificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudNota).EndInit();
            panelComentario.ResumeLayout(false);
            panelEstudiante.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
