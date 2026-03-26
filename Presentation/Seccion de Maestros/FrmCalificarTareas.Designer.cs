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
            panelHeader = new System.Windows.Forms.Panel();
            accentBar = new System.Windows.Forms.Panel();
            lblTitulo = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            splitContainerMain = new System.Windows.Forms.SplitContainer();
            flpTareas = new System.Windows.Forms.FlowLayoutPanel();
            panelFormControls = new System.Windows.Forms.Panel();
            panelEstudiante = new System.Windows.Forms.Panel();
            panelSeparador1 = new System.Windows.Forms.Panel();
            panelComentario = new System.Windows.Forms.Panel();
            panelSeparador2 = new System.Windows.Forms.Panel();
            panelCalificacion = new System.Windows.Forms.Panel();
            panelSeparador3 = new System.Windows.Forms.Panel();
            panelFeedback = new System.Windows.Forms.Panel();
            panelBotones = new System.Windows.Forms.Panel();
            lblEstudiante = new System.Windows.Forms.Label();
            lblEstudianteVal = new System.Windows.Forms.Label();
            lblComentario = new System.Windows.Forms.Label();
            txtComentario = new System.Windows.Forms.RichTextBox();
            lblNota = new System.Windows.Forms.Label();
            nudNota = new System.Windows.Forms.NumericUpDown();
            lblEstadoCalif = new System.Windows.Forms.Label();
            lblFeedback = new System.Windows.Forms.Label();
            txtFeedback = new System.Windows.Forms.RichTextBox();
            btnCalificar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            flpEntregas = new System.Windows.Forms.FlowLayoutPanel();

            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            panelFormControls.SuspendLayout();
            panelEstudiante.SuspendLayout();
            panelComentario.SuspendLayout();
            panelCalificacion.SuspendLayout();
            panelFeedback.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();

            // panelHeader
            panelHeader.Controls.Add(accentBar);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblFecha);
            panelHeader.BackColor = COLOR_BACKGROUND;
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(854, 55);
            panelHeader.TabIndex = 1;

            // accentBar
            accentBar.BackColor = COLOR_PRIMARY;
            accentBar.Dock = System.Windows.Forms.DockStyle.Left;
            accentBar.Location = new System.Drawing.Point(0, 0);
            accentBar.Name = "accentBar";
            accentBar.Size = new System.Drawing.Size(6, 55);
            accentBar.TabIndex = 0;

            // lblTitulo
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitulo.Location = new System.Drawing.Point(20, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(300, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "📝 Calificar Tareas";

            // lblFecha
            lblFecha.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblFecha.Location = new System.Drawing.Point(20, 38);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(300, 16);
            lblFecha.TabIndex = 2;

            // splitContainerMain
            splitContainerMain.BackColor = COLOR_BACKGROUND;
            splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerMain.Location = new System.Drawing.Point(0, 55);
            splitContainerMain.Name = "splitContainerMain";
            splitContainerMain.Panel1.BackColor = COLOR_BACKGROUND;
            splitContainerMain.Panel1.Controls.Add(flpTareas);
            splitContainerMain.Panel2.BackColor = COLOR_BACKGROUND;
            splitContainerMain.Panel2.Controls.Add(splitContainer2);
            splitContainerMain.Size = new System.Drawing.Size(854, 480);
            splitContainerMain.SplitterDistance = 683;
            splitContainerMain.SplitterWidth = 3;
            splitContainerMain.TabIndex = 0;

            // flpTareas
            flpTareas.AutoScroll = true;
            flpTareas.BackColor = COLOR_BACKGROUND;
            flpTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            flpTareas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpTareas.Location = new System.Drawing.Point(0, 0);
            flpTareas.Name = "flpTareas";
            flpTareas.Padding = new System.Windows.Forms.Padding(10);
            flpTareas.Size = new System.Drawing.Size(683, 480);
            flpTareas.TabIndex = 0;
            flpTareas.WrapContents = false;
            flpTareas.Paint += flpTareas_Paint;

            // panelFormControls (MAIN CONTAINER)
            panelFormControls.BackColor = COLOR_BACKGROUND;
            panelFormControls.Controls.Add(panelBotones);
            panelFormControls.Controls.Add(panelFeedback);
            panelFormControls.Controls.Add(panelSeparador3);
            panelFormControls.Controls.Add(panelCalificacion);
            panelFormControls.Controls.Add(panelSeparador2);
            panelFormControls.Controls.Add(panelComentario);
            panelFormControls.Controls.Add(panelSeparador1);
            panelFormControls.Controls.Add(panelEstudiante);
            panelFormControls.AutoScroll = true;
            panelFormControls.Dock = System.Windows.Forms.DockStyle.Fill;
            panelFormControls.Name = "panelFormControls";
            panelFormControls.Padding = new System.Windows.Forms.Padding(8);
            panelFormControls.TabIndex = 0;

            // panelEstudiante
            panelEstudiante.BackColor = COLOR_WHITE;
            panelEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelEstudiante.Controls.Add(lblEstudiante);
            panelEstudiante.Controls.Add(lblEstudianteVal);
            panelEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            panelEstudiante.Height = 70;
            panelEstudiante.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            panelEstudiante.Name = "panelEstudiante";
            panelEstudiante.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            panelEstudiante.TabIndex = 0;

            // lblEstudiante
            lblEstudiante.AutoSize = false;
            lblEstudiante.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            lblEstudiante.ForeColor = COLOR_GRAY;
            lblEstudiante.Location = new System.Drawing.Point(12, 8);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new System.Drawing.Size(320, 15);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "👨‍🎓 ESTUDIANTE";

            // lblEstudianteVal
            lblEstudianteVal.AutoSize = false;
            lblEstudianteVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblEstudianteVal.ForeColor = COLOR_DARK;
            lblEstudianteVal.Location = new System.Drawing.Point(12, 25);
            lblEstudianteVal.Name = "lblEstudianteVal";
            lblEstudianteVal.Size = new System.Drawing.Size(320, 25);
            lblEstudianteVal.TabIndex = 1;
            lblEstudianteVal.Text = "—";

            // panelSeparador1
            panelSeparador1.Dock = System.Windows.Forms.DockStyle.Top;
            panelSeparador1.Height = 5;
            panelSeparador1.Margin = new System.Windows.Forms.Padding(0);
            panelSeparador1.Name = "panelSeparador1";
            panelSeparador1.TabIndex = 1;

            // panelComentario
            panelComentario.BackColor = COLOR_WHITE;
            panelComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelComentario.Controls.Add(lblComentario);
            panelComentario.Controls.Add(txtComentario);
            panelComentario.Dock = System.Windows.Forms.DockStyle.Top;
            panelComentario.Height = 100;
            panelComentario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            panelComentario.Name = "panelComentario";
            panelComentario.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            panelComentario.TabIndex = 2;

            // lblComentario
            lblComentario.AutoSize = false;
            lblComentario.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            lblComentario.ForeColor = COLOR_GRAY;
            lblComentario.Location = new System.Drawing.Point(12, 5);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new System.Drawing.Size(320, 15);
            lblComentario.TabIndex = 2;
            lblComentario.Text = "💬 COMENTARIO DE LA TAREA";

            // txtComentario
            txtComentario.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtComentario.Font = new System.Drawing.Font("Segoe UI", 8F);
            txtComentario.Location = new System.Drawing.Point(12, 23);
            txtComentario.Name = "txtComentario";
            txtComentario.ReadOnly = true;
            txtComentario.Size = new System.Drawing.Size(320, 60);
            txtComentario.TabIndex = 3;
            txtComentario.Text = "";

            // panelSeparador2
            panelSeparador2.Dock = System.Windows.Forms.DockStyle.Top;
            panelSeparador2.Height = 5;
            panelSeparador2.Margin = new System.Windows.Forms.Padding(0);
            panelSeparador2.Name = "panelSeparador2";
            panelSeparador2.TabIndex = 3;

            // panelCalificacion
            panelCalificacion.BackColor = COLOR_WHITE;
            panelCalificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelCalificacion.Controls.Add(lblNota);
            panelCalificacion.Controls.Add(nudNota);
            panelCalificacion.Controls.Add(lblEstadoCalif);
            panelCalificacion.Dock = System.Windows.Forms.DockStyle.Top;
            panelCalificacion.Height = 90;
            panelCalificacion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            panelCalificacion.Name = "panelCalificacion";
            panelCalificacion.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            panelCalificacion.TabIndex = 4;

            // lblNota
            lblNota.AutoSize = false;
            lblNota.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            lblNota.ForeColor = COLOR_GRAY;
            lblNota.Location = new System.Drawing.Point(12, 5);
            lblNota.Name = "lblNota";
            lblNota.Size = new System.Drawing.Size(320, 15);
            lblNota.TabIndex = 4;
            lblNota.Text = "⭐ CALIFICACIÓN (0-100)";

            // nudNota
            nudNota.BackColor = COLOR_WHITE;
            nudNota.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            nudNota.ForeColor = COLOR_PRIMARY;
            nudNota.Location = new System.Drawing.Point(12, 25);
            nudNota.Maximum = 100;
            nudNota.Minimum = 0;
            nudNota.Name = "nudNota";
            nudNota.Size = new System.Drawing.Size(80, 30);
            nudNota.TabIndex = 5;
            nudNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nudNota.Value = 0;

            // lblEstadoCalif
            lblEstadoCalif.AutoSize = false;
            lblEstadoCalif.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblEstadoCalif.ForeColor = COLOR_GRAY;
            lblEstadoCalif.Location = new System.Drawing.Point(100, 30);
            lblEstadoCalif.Name = "lblEstadoCalif";
            lblEstadoCalif.Size = new System.Drawing.Size(220, 20);
            lblEstadoCalif.TabIndex = 11;
            lblEstadoCalif.Text = "Puntos";

            // panelSeparador3
            panelSeparador3.Dock = System.Windows.Forms.DockStyle.Top;
            panelSeparador3.Height = 5;
            panelSeparador3.Margin = new System.Windows.Forms.Padding(0);
            panelSeparador3.Name = "panelSeparador3";
            panelSeparador3.TabIndex = 5;

            // panelFeedback
            panelFeedback.BackColor = COLOR_WHITE;
            panelFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelFeedback.Controls.Add(lblFeedback);
            panelFeedback.Controls.Add(txtFeedback);
            panelFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            panelFeedback.Height = 130;
            panelFeedback.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            panelFeedback.Name = "panelFeedback";
            panelFeedback.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            panelFeedback.TabIndex = 6;

            // lblFeedback
            lblFeedback.AutoSize = false;
            lblFeedback.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            lblFeedback.ForeColor = COLOR_GRAY;
            lblFeedback.Location = new System.Drawing.Point(12, 5);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new System.Drawing.Size(320, 15);
            lblFeedback.TabIndex = 6;
            lblFeedback.Text = "💬 RETROALIMENTACIÓN PARA EL ESTUDIANTE";

            // txtFeedback
            txtFeedback.BackColor = COLOR_WHITE;
            txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtFeedback.Font = new System.Drawing.Font("Segoe UI", 8F);
            txtFeedback.Location = new System.Drawing.Point(12, 23);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.Size = new System.Drawing.Size(320, 90);
            txtFeedback.TabIndex = 7;
            txtFeedback.Text = "";

            // panelBotones
            panelBotones.BackColor = System.Drawing.Color.Transparent;
            panelBotones.Controls.Add(btnCalificar);
            panelBotones.Controls.Add(btnLimpiar);
            panelBotones.Controls.Add(btnActualizar);
            panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            panelBotones.Height = 45;
            panelBotones.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            panelBotones.TabIndex = 7;

            // btnCalificar
            btnCalificar.BackColor = COLOR_PRIMARY;
            btnCalificar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCalificar.Enabled = false;
            btnCalificar.FlatAppearance.BorderSize = 0;
            btnCalificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnCalificar.ForeColor = COLOR_DARK;
            btnCalificar.Location = new System.Drawing.Point(12, 8);
            btnCalificar.Name = "btnCalificar";
            btnCalificar.Size = new System.Drawing.Size(100, 32);
            btnCalificar.TabIndex = 8;
            btnCalificar.Text = "✅ Calificar";
            btnCalificar.Click += btnCalificar_Click;

            // btnLimpiar
            btnLimpiar.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiar.Enabled = false;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnLimpiar.ForeColor = COLOR_DARK;
            btnLimpiar.Location = new System.Drawing.Point(117, 8);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(100, 32);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "🗑️ Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;

            // btnActualizar
            btnActualizar.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnActualizar.ForeColor = COLOR_DARK;
            btnActualizar.Location = new System.Drawing.Point(222, 8);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(110, 32);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "🔄 Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;

            // splitContainer2
            splitContainer2.BackColor = COLOR_BACKGROUND;
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            splitContainer2.Panel1.BackColor = COLOR_BACKGROUND;
            splitContainer2.Panel1.Controls.Add(flpEntregas);
            splitContainer2.Panel2.BackColor = COLOR_BACKGROUND;
            splitContainer2.Panel2.Controls.Add(panelFormControls);
            splitContainer2.Size = new System.Drawing.Size(168, 480);
            splitContainer2.SplitterDistance = 340;
            splitContainer2.SplitterWidth = 3;
            splitContainer2.TabIndex = 0;

            // flpEntregas
            flpEntregas.AutoScroll = true;
            flpEntregas.BackColor = COLOR_BACKGROUND;
            flpEntregas.Dock = System.Windows.Forms.DockStyle.Fill;
            flpEntregas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpEntregas.Location = new System.Drawing.Point(0, 0);
            flpEntregas.Name = "flpEntregas";
            flpEntregas.Padding = new System.Windows.Forms.Padding(10);
            flpEntregas.Size = new System.Drawing.Size(168, 340);
            flpEntregas.TabIndex = 0;
            flpEntregas.WrapContents = false;

            // FrmCalificarTareas
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = COLOR_BACKGROUND;
            ClientSize = new System.Drawing.Size(854, 535);
            Controls.Add(splitContainerMain);
            Controls.Add(panelHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmCalificarTareas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Calificar Tareas";
            Load += FrmCalificarTareas_Load;

            panelHeader.ResumeLayout(false);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            panelEstudiante.ResumeLayout(false);
            panelComentario.ResumeLayout(false);
            panelCalificacion.ResumeLayout(false);
            panelFeedback.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            panelFormControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudNota).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
