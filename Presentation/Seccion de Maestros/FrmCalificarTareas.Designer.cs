namespace Presentation.Seccion_de_Maestros
{
    partial class FrmCalificarTareas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalificarTareas));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelTareas = new System.Windows.Forms.Panel();
            this.lblTareasTitle = new System.Windows.Forms.Label();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.colTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntregas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPendientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEntregasYForm = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelEntregas = new System.Windows.Forms.Panel();
            this.lblEntregasInfo = new System.Windows.Forms.Label();
            this.lblEntregasTitle = new System.Windows.Forms.Label();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.colSubmissionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHayFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCalificacion = new System.Windows.Forms.Panel();
            this.gbCalificacion = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.lblFeedbackLabel = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.RichTextBox();
            this.lblNotaLabel = new System.Windows.Forms.Label();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.lblNombreArchivoLabel = new System.Windows.Forms.Label();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.lblComentarioTitle = new System.Windows.Forms.Label();
            this.txtComentarioEstudiante = new System.Windows.Forms.RichTextBox();
            this.lblFechaEntregaLabel = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblEstudianteLabel = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.panelEntregasYForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            this.panelCalificacion.SuspendLayout();
            this.gbCalificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.panelHeader.Controls.Add(this.lblFecha);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 70);
            this.panelHeader.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📝 Calificar Tareas de Estudiantes";

            // lblFecha
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblFecha.Location = new System.Drawing.Point(20, 45);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 19);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "—";

            // panelMain
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(1200, 630);
            this.panelMain.TabIndex = 1;
            this.panelMain.Controls.Add(this.splitContainerMain);

            // splitContainerMain
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(10, 10);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.splitContainerMain.SplitterDistance = 150;

            // Panel 1: Tareas
            this.splitContainerMain.Panel1.Controls.Add(this.panelTareas);
            this.splitContainerMain.Panel2.Controls.Add(this.panelEntregasYForm);

            // panelTareas
            this.panelTareas.Controls.Add(this.lblTareasTitle);
            this.panelTareas.Controls.Add(this.dgvTareas);
            this.panelTareas.Dock = System.Windows.Forms.DockStyle.Fill;

            // lblTareasTitle
            this.lblTareasTitle.AutoSize = true;
            this.lblTareasTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTareasTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblTareasTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTareasTitle.Name = "lblTareasTitle";
            this.lblTareasTitle.Size = new System.Drawing.Size(80, 20);
            this.lblTareasTitle.TabIndex = 0;
            this.lblTareasTitle.Text = "📋 Tareas";

            // dgvTareas
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaskId,
            this.colTitulo,
            this.colGrupo,
            this.colFechaVencimiento,
            this.colEntregas,
            this.colPendientes,
            this.colEstado});
            this.dgvTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTareas.Location = new System.Drawing.Point(0, 30);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowTemplate.Height = 25;
            this.dgvTareas.Size = new System.Drawing.Size(1180, 120);
            this.dgvTareas.TabIndex = 1;
            this.dgvTareas.SelectionChanged += new System.EventHandler(this.dgvTareas_SelectionChanged);

            // Columnas dgvTareas
            this.colTaskId.HeaderText = "ID";
            this.colTaskId.Name = "colTaskId";
            this.colTitulo.HeaderText = "Título";
            this.colTitulo.Name = "colTitulo";
            this.colGrupo.HeaderText = "Grupo";
            this.colGrupo.Name = "colGrupo";
            this.colFechaVencimiento.HeaderText = "Vencimiento";
            this.colFechaVencimiento.Name = "colFechaVencimiento";
            this.colEntregas.HeaderText = "Entregas";
            this.colEntregas.Name = "colEntregas";
            this.colPendientes.HeaderText = "Pendientes";
            this.colPendientes.Name = "colPendientes";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";

            // panelEntregasYForm
            this.panelEntregasYForm.Controls.Add(this.splitContainer2);
            this.panelEntregasYForm.Dock = System.Windows.Forms.DockStyle.Fill;

            // splitContainer2
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.SplitterDistance = 400;

            // Panel 1: Entregas
            this.splitContainer2.Panel1.Controls.Add(this.panelEntregas);
            this.splitContainer2.Panel2.Controls.Add(this.panelCalificacion);

            // panelEntregas
            this.panelEntregas.Controls.Add(this.lblEntregasInfo);
            this.panelEntregas.Controls.Add(this.lblEntregasTitle);
            this.panelEntregas.Controls.Add(this.dgvEntregas);
            this.panelEntregas.Dock = System.Windows.Forms.DockStyle.Fill;

            // lblEntregasTitle
            this.lblEntregasTitle.AutoSize = true;
            this.lblEntregasTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEntregasTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lblEntregasTitle.Location = new System.Drawing.Point(10, 10);
            this.lblEntregasTitle.Name = "lblEntregasTitle";
            this.lblEntregasTitle.Size = new System.Drawing.Size(120, 20);
            this.lblEntregasTitle.TabIndex = 0;
            this.lblEntregasTitle.Text = "📤 Entregas";

            // lblEntregasInfo
            this.lblEntregasInfo.AutoSize = true;
            this.lblEntregasInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEntregasInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblEntregasInfo.Location = new System.Drawing.Point(130, 12);
            this.lblEntregasInfo.Name = "lblEntregasInfo";
            this.lblEntregasInfo.Size = new System.Drawing.Size(60, 15);
            this.lblEntregasInfo.TabIndex = 2;
            this.lblEntregasInfo.Text = "Entregas: 0";

            // dgvEntregas
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubmissionId,
            this.colEstudiante,
            this.colFechaEntrega,
            this.colAtrazo,
            this.colStatusEntrega,
            this.colNota,
            this.colHayFeedback});
            this.dgvEntregas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntregas.Location = new System.Drawing.Point(0, 30);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.RowTemplate.Height = 25;
            this.dgvEntregas.Size = new System.Drawing.Size(400, 420);
            this.dgvEntregas.TabIndex = 1;
            this.dgvEntregas.SelectionChanged += new System.EventHandler(this.dgvEntregas_SelectionChanged);

            // Columnas dgvEntregas
            this.colSubmissionId.HeaderText = "ID";
            this.colSubmissionId.Name = "colSubmissionId";
            this.colEstudiante.HeaderText = "Estudiante";
            this.colEstudiante.Name = "colEstudiante";
            this.colFechaEntrega.HeaderText = "Entrega";
            this.colFechaEntrega.Name = "colFechaEntrega";
            this.colAtrazo.HeaderText = "Atraso";
            this.colAtrazo.Name = "colAtrazo";
            this.colStatusEntrega.HeaderText = "Estado";
            this.colStatusEntrega.Name = "colStatusEntrega";
            this.colNota.HeaderText = "Nota";
            this.colNota.Name = "colNota";
            this.colHayFeedback.HeaderText = "Comentario";
            this.colHayFeedback.Name = "colHayFeedback";

            // panelCalificacion
            this.panelCalificacion.Controls.Add(this.gbCalificacion);
            this.panelCalificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCalificacion.Padding = new System.Windows.Forms.Padding(10);

            // gbCalificacion
            this.gbCalificacion.Controls.Add(this.btnActualizar);
            this.gbCalificacion.Controls.Add(this.btnLimpiar);
            this.gbCalificacion.Controls.Add(this.btnCalificar);
            this.gbCalificacion.Controls.Add(this.lblFeedbackLabel);
            this.gbCalificacion.Controls.Add(this.txtFeedback);
            this.gbCalificacion.Controls.Add(this.lblNotaLabel);
            this.gbCalificacion.Controls.Add(this.nudNota);
            this.gbCalificacion.Controls.Add(this.lblNombreArchivoLabel);
            this.gbCalificacion.Controls.Add(this.lblNombreArchivo);
            this.gbCalificacion.Controls.Add(this.lblComentarioTitle);
            this.gbCalificacion.Controls.Add(this.txtComentarioEstudiante);
            this.gbCalificacion.Controls.Add(this.lblFechaEntregaLabel);
            this.gbCalificacion.Controls.Add(this.lblFechaEntrega);
            this.gbCalificacion.Controls.Add(this.lblEstudianteLabel);
            this.gbCalificacion.Controls.Add(this.lblEstudiante);
            this.gbCalificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCalificacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gbCalificacion.Location = new System.Drawing.Point(10, 10);
            this.gbCalificacion.Name = "gbCalificacion";
            this.gbCalificacion.Size = new System.Drawing.Size(366, 420);
            this.gbCalificacion.TabIndex = 0;
            this.gbCalificacion.TabStop = false;
            this.gbCalificacion.Text = "✏️ Calificación";

            // lblEstudianteLabel
            this.lblEstudianteLabel.AutoSize = true;
            this.lblEstudianteLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstudianteLabel.Location = new System.Drawing.Point(10, 30);
            this.lblEstudianteLabel.Name = "lblEstudianteLabel";
            this.lblEstudianteLabel.Size = new System.Drawing.Size(70, 15);
            this.lblEstudianteLabel.TabIndex = 0;
            this.lblEstudianteLabel.Text = "Estudiante:";

            // lblEstudiante
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(90, 30);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(20, 19);
            this.lblEstudiante.TabIndex = 1;
            this.lblEstudiante.Text = "—";

            // lblFechaEntregaLabel
            this.lblFechaEntregaLabel.AutoSize = true;
            this.lblFechaEntregaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaEntregaLabel.Location = new System.Drawing.Point(10, 55);
            this.lblFechaEntregaLabel.Name = "lblFechaEntregaLabel";
            this.lblFechaEntregaLabel.Size = new System.Drawing.Size(55, 15);
            this.lblFechaEntregaLabel.TabIndex = 2;
            this.lblFechaEntregaLabel.Text = "Entrega:";

            // lblFechaEntrega
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(90, 55);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(20, 19);
            this.lblFechaEntrega.TabIndex = 3;
            this.lblFechaEntrega.Text = "—";

            // lblNombreArchivoLabel
            this.lblNombreArchivoLabel.AutoSize = true;
            this.lblNombreArchivoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreArchivoLabel.Location = new System.Drawing.Point(10, 80);
            this.lblNombreArchivoLabel.Name = "lblNombreArchivoLabel";
            this.lblNombreArchivoLabel.Size = new System.Drawing.Size(55, 15);
            this.lblNombreArchivoLabel.TabIndex = 4;
            this.lblNombreArchivoLabel.Text = "Archivo:";

            // lblNombreArchivo
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Location = new System.Drawing.Point(90, 80);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(20, 19);
            this.lblNombreArchivo.TabIndex = 5;
            this.lblNombreArchivo.Text = "—";

            // lblComentarioTitle
            this.lblComentarioTitle.AutoSize = true;
            this.lblComentarioTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblComentarioTitle.Location = new System.Drawing.Point(10, 110);
            this.lblComentarioTitle.Name = "lblComentarioTitle";
            this.lblComentarioTitle.Size = new System.Drawing.Size(130, 15);
            this.lblComentarioTitle.TabIndex = 6;
            this.lblComentarioTitle.Text = "Comentario Estudiante:";

            // txtComentarioEstudiante
            this.txtComentarioEstudiante.Location = new System.Drawing.Point(10, 130);
            this.txtComentarioEstudiante.Name = "txtComentarioEstudiante";
            this.txtComentarioEstudiante.ReadOnly = true;
            this.txtComentarioEstudiante.Size = new System.Drawing.Size(346, 50);
            this.txtComentarioEstudiante.TabIndex = 7;
            this.txtComentarioEstudiante.Text = "";

            // lblNotaLabel
            this.lblNotaLabel.AutoSize = true;
            this.lblNotaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNotaLabel.Location = new System.Drawing.Point(10, 190);
            this.lblNotaLabel.Name = "lblNotaLabel";
            this.lblNotaLabel.Size = new System.Drawing.Size(35, 15);
            this.lblNotaLabel.TabIndex = 8;
            this.lblNotaLabel.Text = "Nota:";

            // nudNota
            this.nudNota.Location = new System.Drawing.Point(10, 210);
            this.nudNota.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(100, 25);
            this.nudNota.TabIndex = 9;
            this.nudNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // lblFeedbackLabel
            this.lblFeedbackLabel.AutoSize = true;
            this.lblFeedbackLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFeedbackLabel.Location = new System.Drawing.Point(10, 240);
            this.lblFeedbackLabel.Name = "lblFeedbackLabel";
            this.lblFeedbackLabel.Size = new System.Drawing.Size(60, 15);
            this.lblFeedbackLabel.TabIndex = 10;
            this.lblFeedbackLabel.Text = "Feedback:";

            // txtFeedback
            this.txtFeedback.Location = new System.Drawing.Point(10, 260);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(346, 80);
            this.txtFeedback.TabIndex = 11;
            this.txtFeedback.Text = "";

            // btnCalificar
            this.btnCalificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnCalificar.Enabled = false;
            this.btnCalificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalificar.ForeColor = System.Drawing.Color.White;
            this.btnCalificar.Location = new System.Drawing.Point(10, 350);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(110, 35);
            this.btnCalificar.TabIndex = 12;
            this.btnCalificar.Text = "✅ Calificar";
            this.btnCalificar.UseVisualStyleBackColor = false;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);

            // btnLimpiar
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(130, 350);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 35);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "🗑️ Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // btnActualizar
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(250, 350);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(106, 35);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // FrmCalificarTareas
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmCalificarTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificar Tareas";
            this.Load += new System.EventHandler(this.FrmCalificarTareas_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelTareas.ResumeLayout(false);
            this.panelTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.panelEntregasYForm.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelEntregas.ResumeLayout(false);
            this.panelEntregas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            this.panelCalificacion.ResumeLayout(false);
            this.gbCalificacion.ResumeLayout(false);
            this.gbCalificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelTareas;
        private System.Windows.Forms.Label lblTareasTitle;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntregas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Panel panelEntregasYForm;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panelEntregas;
        private System.Windows.Forms.Label lblEntregasInfo;
        private System.Windows.Forms.Label lblEntregasTitle;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubmissionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHayFeedback;
        private System.Windows.Forms.Panel panelCalificacion;
        private System.Windows.Forms.GroupBox gbCalificacion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Label lblFeedbackLabel;
        private System.Windows.Forms.RichTextBox txtFeedback;
        private System.Windows.Forms.Label lblNotaLabel;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.Label lblNombreArchivoLabel;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.Label lblComentarioTitle;
        private System.Windows.Forms.RichTextBox txtComentarioEstudiante;
        private System.Windows.Forms.Label lblFechaEntregaLabel;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblEstudianteLabel;
        private System.Windows.Forms.Label lblEstudiante;
    }
}
