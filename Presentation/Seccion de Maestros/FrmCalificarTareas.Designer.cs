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
            System.Windows.Forms.DataGridView guna2DataGridViewStyled1 = new System.Windows.Forms.DataGridView();
            System.Windows.Forms.DataGridView guna2DataGridViewStyled2 = new System.Windows.Forms.DataGridView();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelTareas = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTareasTitle = new System.Windows.Forms.Label();
            this.dgvTareas = guna2DataGridViewStyled1;
            this.colTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntregas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPendientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEntregasYForm = new Guna.UI2.WinForms.Guna2Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelEntregas = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEntregasInfo = new System.Windows.Forms.Label();
            this.lblEntregasTitle = new System.Windows.Forms.Label();
            this.dgvEntregas = guna2DataGridViewStyled2;
            this.colSubmissionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHayFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCalificacion = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBotones = new Guna.UI2.WinForms.Guna2Panel();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCalificar = new Guna.UI2.WinForms.Guna2Button();
            this.panelFormControls = new Guna.UI2.WinForms.Guna2Panel();
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
            this.panelBotones.SuspendLayout();
            this.panelFormControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.panelHeader.Controls.Add(this.lblFecha);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.CustomizableEdges = customizableEdges1;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.panelHeader.Size = new System.Drawing.Size(1200, 70);
            this.panelHeader.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(25, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(350, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📝 Calificar Tareas de Estudiantes";

            // lblFecha
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblFecha.Location = new System.Drawing.Point(25, 45);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 19);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "26 de marzo, 2026";

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.CustomizableEdges = customizableEdges3;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(0, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(12);
            this.panelMain.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.panelMain.Size = new System.Drawing.Size(1200, 630);
            this.panelMain.TabIndex = 1;
            this.panelMain.Controls.Add(this.splitContainerMain);

            // splitContainerMain
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(12, 12);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.splitContainerMain.SplitterDistance = 160;
            this.splitContainerMain.SplitterWidth = 8;
            this.splitContainerMain.Panel1.Controls.Add(this.panelTareas);
            this.splitContainerMain.Panel2.Controls.Add(this.panelEntregasYForm);
            this.splitContainerMain.Size = new System.Drawing.Size(1176, 606);
            this.splitContainerMain.TabIndex = 0;

            // panelTareas
            this.panelTareas.BorderColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.panelTareas.BorderThickness = 1;
            this.panelTareas.CustomizableEdges = customizableEdges5;
            this.panelTareas.Controls.Add(this.lblTareasTitle);
            this.panelTareas.Controls.Add(this.dgvTareas);
            this.panelTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTareas.FillColor = System.Drawing.Color.FromArgb(250, 250, 252);
            this.panelTareas.Location = new System.Drawing.Point(0, 0);
            this.panelTareas.Name = "panelTareas";
            this.panelTareas.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.panelTareas.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.panelTareas.Size = new System.Drawing.Size(1176, 160);
            this.panelTareas.TabIndex = 0;

            // lblTareasTitle
            this.lblTareasTitle.AutoSize = true;
            this.lblTareasTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTareasTitle.ForeColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.lblTareasTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTareasTitle.Name = "lblTareasTitle";
            this.lblTareasTitle.Size = new System.Drawing.Size(130, 20);
            this.lblTareasTitle.TabIndex = 0;
            this.lblTareasTitle.Text = "📋 Mis Tareas";

            // dgvTareas
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToResizeRows = false;
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTareas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.dgvTareas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTareas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvTareas.ColumnHeadersHeight = 30;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaskId, this.colTitulo, this.colGrupo, this.colFechaVencimiento,
            this.colEntregas, this.colPendientes, this.colEstado});
            this.dgvTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTareas.EnableHeadersVisualStyles = false;
            this.dgvTareas.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvTareas.Location = new System.Drawing.Point(12, 32);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersVisible = false;
            this.dgvTareas.RowTemplate.Height = 28;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(1152, 118);
            this.dgvTareas.TabIndex = 1;
            this.dgvTareas.SelectionChanged += new System.EventHandler(this.dgvTareas_SelectionChanged);

            // Column headers for dgvTareas
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
            this.panelEntregasYForm.CustomizableEdges = customizableEdges7;
            this.panelEntregasYForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntregasYForm.FillColor = System.Drawing.Color.White;
            this.panelEntregasYForm.Location = new System.Drawing.Point(0, 0);
            this.panelEntregasYForm.Name = "panelEntregasYForm";
            this.panelEntregasYForm.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.panelEntregasYForm.Size = new System.Drawing.Size(1176, 438);
            this.panelEntregasYForm.TabIndex = 1;
            this.panelEntregasYForm.Controls.Add(this.splitContainer2);

            // splitContainer2
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.SplitterDistance = 420;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.Panel1.Controls.Add(this.panelEntregas);
            this.splitContainer2.Panel2.Controls.Add(this.panelCalificacion);
            this.splitContainer2.Size = new System.Drawing.Size(1176, 438);
            this.splitContainer2.TabIndex = 0;

            // panelEntregas
            this.panelEntregas.BorderColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.panelEntregas.BorderThickness = 1;
            this.panelEntregas.CustomizableEdges = customizableEdges5;
            this.panelEntregas.Controls.Add(this.lblEntregasInfo);
            this.panelEntregas.Controls.Add(this.lblEntregasTitle);
            this.panelEntregas.Controls.Add(this.dgvEntregas);
            this.panelEntregas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntregas.FillColor = System.Drawing.Color.FromArgb(250, 250, 252);
            this.panelEntregas.Location = new System.Drawing.Point(0, 0);
            this.panelEntregas.Name = "panelEntregas";
            this.panelEntregas.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.panelEntregas.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.panelEntregas.Size = new System.Drawing.Size(420, 438);
            this.panelEntregas.TabIndex = 0;

            // lblEntregasTitle
            this.lblEntregasTitle.AutoSize = true;
            this.lblEntregasTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEntregasTitle.ForeColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.lblEntregasTitle.Location = new System.Drawing.Point(12, 10);
            this.lblEntregasTitle.Name = "lblEntregasTitle";
            this.lblEntregasTitle.Size = new System.Drawing.Size(150, 20);
            this.lblEntregasTitle.TabIndex = 0;
            this.lblEntregasTitle.Text = "📤 Entregas";

            // lblEntregasInfo
            this.lblEntregasInfo.AutoSize = true;
            this.lblEntregasInfo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEntregasInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblEntregasInfo.Location = new System.Drawing.Point(165, 12);
            this.lblEntregasInfo.Name = "lblEntregasInfo";
            this.lblEntregasInfo.Size = new System.Drawing.Size(60, 15);
            this.lblEntregasInfo.TabIndex = 2;
            this.lblEntregasInfo.Text = "Entregas: 0";

            // dgvEntregas
            this.dgvEntregas.AllowUserToAddRows = false;
            this.dgvEntregas.AllowUserToDeleteRows = false;
            this.dgvEntregas.AllowUserToResizeRows = false;
            this.dgvEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntregas.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntregas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntregas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEntregas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEntregas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.dgvEntregas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEntregas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvEntregas.ColumnHeadersHeight = 30;
            this.dgvEntregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubmissionId, this.colEstudiante, this.colFechaEntrega, this.colAtrazo,
            this.colStatusEntrega, this.colNota, this.colHayFeedback});
            this.dgvEntregas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntregas.EnableHeadersVisualStyles = false;
            this.dgvEntregas.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvEntregas.Location = new System.Drawing.Point(12, 32);
            this.dgvEntregas.MultiSelect = false;
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.ReadOnly = true;
            this.dgvEntregas.RowHeadersVisible = false;
            this.dgvEntregas.RowTemplate.Height = 28;
            this.dgvEntregas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntregas.Size = new System.Drawing.Size(396, 396);
            this.dgvEntregas.TabIndex = 1;
            this.dgvEntregas.SelectionChanged += new System.EventHandler(this.dgvEntregas_SelectionChanged);

            // Column headers for dgvEntregas
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
            this.panelCalificacion.BorderColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.panelCalificacion.BorderThickness = 1;
            this.panelCalificacion.CustomizableEdges = customizableEdges5;
            this.panelCalificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCalificacion.FillColor = System.Drawing.Color.FromArgb(250, 250, 252);
            this.panelCalificacion.Location = new System.Drawing.Point(0, 0);
            this.panelCalificacion.Name = "panelCalificacion";
            this.panelCalificacion.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.panelCalificacion.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.panelCalificacion.Size = new System.Drawing.Size(748, 438);
            this.panelCalificacion.TabIndex = 2;
            this.panelCalificacion.Controls.Add(this.panelBotones);
            this.panelCalificacion.Controls.Add(this.panelFormControls);

            // panelFormControls
            this.panelFormControls.CustomizableEdges = customizableEdges5;
            this.panelFormControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormControls.FillColor = System.Drawing.Color.Transparent;
            this.panelFormControls.Location = new System.Drawing.Point(12, 10);
            this.panelFormControls.Name = "panelFormControls";
            this.panelFormControls.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.panelFormControls.Size = new System.Drawing.Size(724, 370);
            this.panelFormControls.TabIndex = 0;
            this.panelFormControls.Controls.Add(this.lblFeedbackLabel);
            this.panelFormControls.Controls.Add(this.txtFeedback);
            this.panelFormControls.Controls.Add(this.lblNotaLabel);
            this.panelFormControls.Controls.Add(this.nudNota);
            this.panelFormControls.Controls.Add(this.lblNombreArchivoLabel);
            this.panelFormControls.Controls.Add(this.lblNombreArchivo);
            this.panelFormControls.Controls.Add(this.lblComentarioTitle);
            this.panelFormControls.Controls.Add(this.txtComentarioEstudiante);
            this.panelFormControls.Controls.Add(this.lblFechaEntregaLabel);
            this.panelFormControls.Controls.Add(this.lblFechaEntrega);
            this.panelFormControls.Controls.Add(this.lblEstudianteLabel);
            this.panelFormControls.Controls.Add(this.lblEstudiante);

            // Labels y controles de calificación
            this.lblEstudianteLabel.AutoSize = true;
            this.lblEstudianteLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstudianteLabel.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblEstudianteLabel.Location = new System.Drawing.Point(10, 15);
            this.lblEstudianteLabel.Name = "lblEstudianteLabel";
            this.lblEstudianteLabel.Size = new System.Drawing.Size(70, 15);
            this.lblEstudianteLabel.TabIndex = 0;
            this.lblEstudianteLabel.Text = "Estudiante:";

            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstudiante.ForeColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.lblEstudiante.Location = new System.Drawing.Point(90, 15);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(20, 15);
            this.lblEstudiante.TabIndex = 1;
            this.lblEstudiante.Text = "—";

            this.lblFechaEntregaLabel.AutoSize = true;
            this.lblFechaEntregaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaEntregaLabel.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblFechaEntregaLabel.Location = new System.Drawing.Point(10, 40);
            this.lblFechaEntregaLabel.Name = "lblFechaEntregaLabel";
            this.lblFechaEntregaLabel.Size = new System.Drawing.Size(55, 15);
            this.lblFechaEntregaLabel.TabIndex = 2;
            this.lblFechaEntregaLabel.Text = "Entrega:";

            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaEntrega.ForeColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.lblFechaEntrega.Location = new System.Drawing.Point(90, 40);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(20, 15);
            this.lblFechaEntrega.TabIndex = 3;
            this.lblFechaEntrega.Text = "—";

            this.lblNombreArchivoLabel.AutoSize = true;
            this.lblNombreArchivoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreArchivoLabel.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblNombreArchivoLabel.Location = new System.Drawing.Point(10, 65);
            this.lblNombreArchivoLabel.Name = "lblNombreArchivoLabel";
            this.lblNombreArchivoLabel.Size = new System.Drawing.Size(55, 15);
            this.lblNombreArchivoLabel.TabIndex = 4;
            this.lblNombreArchivoLabel.Text = "Archivo:";

            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombreArchivo.ForeColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.lblNombreArchivo.Location = new System.Drawing.Point(90, 65);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(20, 15);
            this.lblNombreArchivo.TabIndex = 5;
            this.lblNombreArchivo.Text = "—";

            this.lblComentarioTitle.AutoSize = true;
            this.lblComentarioTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblComentarioTitle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblComentarioTitle.Location = new System.Drawing.Point(10, 95);
            this.lblComentarioTitle.Name = "lblComentarioTitle";
            this.lblComentarioTitle.Size = new System.Drawing.Size(130, 15);
            this.lblComentarioTitle.TabIndex = 6;
            this.lblComentarioTitle.Text = "Comentario Estudiante:";

            this.txtComentarioEstudiante.BackColor = System.Drawing.Color.FromArgb(245, 245, 247);
            this.txtComentarioEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentarioEstudiante.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtComentarioEstudiante.Location = new System.Drawing.Point(10, 115);
            this.txtComentarioEstudiante.Name = "txtComentarioEstudiante";
            this.txtComentarioEstudiante.ReadOnly = true;
            this.txtComentarioEstudiante.Size = new System.Drawing.Size(700, 60);
            this.txtComentarioEstudiante.TabIndex = 7;
            this.txtComentarioEstudiante.Text = "";

            this.lblNotaLabel.AutoSize = true;
            this.lblNotaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNotaLabel.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblNotaLabel.Location = new System.Drawing.Point(10, 185);
            this.lblNotaLabel.Name = "lblNotaLabel";
            this.lblNotaLabel.Size = new System.Drawing.Size(35, 15);
            this.lblNotaLabel.TabIndex = 8;
            this.lblNotaLabel.Text = "Nota:";

            this.nudNota.BackColor = System.Drawing.Color.White;
            this.nudNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNota.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.nudNota.Location = new System.Drawing.Point(10, 205);
            this.nudNota.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(120, 27);
            this.nudNota.TabIndex = 9;
            this.nudNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNota.ForeColor = System.Drawing.Color.FromArgb(30, 90, 160);

            this.lblFeedbackLabel.AutoSize = true;
            this.lblFeedbackLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFeedbackLabel.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblFeedbackLabel.Location = new System.Drawing.Point(10, 240);
            this.lblFeedbackLabel.Name = "lblFeedbackLabel";
            this.lblFeedbackLabel.Size = new System.Drawing.Size(60, 15);
            this.lblFeedbackLabel.TabIndex = 10;
            this.lblFeedbackLabel.Text = "Feedback:";

            this.txtFeedback.BackColor = System.Drawing.Color.White;
            this.txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeedback.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtFeedback.Location = new System.Drawing.Point(10, 260);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(700, 80);
            this.txtFeedback.TabIndex = 11;
            this.txtFeedback.Text = "";

            // panelBotones
            this.panelBotones.CustomizableEdges = customizableEdges5;
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.FillColor = System.Drawing.Color.Transparent;
            this.panelBotones.Location = new System.Drawing.Point(12, 380);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.panelBotones.Size = new System.Drawing.Size(724, 48);
            this.panelBotones.TabIndex = 1;
            this.panelBotones.Controls.Add(this.btnCalificar);
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnActualizar);

            // btnCalificar
            this.btnCalificar.CustomizableEdges = customizableEdges1;
            this.btnCalificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnCalificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnCalificar.Enabled = false;
            this.btnCalificar.FillColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.btnCalificar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCalificar.ForeColor = System.Drawing.Color.White;
            this.btnCalificar.Location = new System.Drawing.Point(10, 8);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnCalificar.Size = new System.Drawing.Size(130, 35);
            this.btnCalificar.TabIndex = 12;
            this.btnCalificar.Text = "✅ Calificar";
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);

            // btnLimpiar
            this.btnLimpiar.CustomizableEdges = customizableEdges1;
            this.btnLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(200, 150, 30);
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(150, 8);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnLimpiar.Size = new System.Drawing.Size(130, 35);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "🗑️ Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // btnActualizar
            this.btnActualizar.CustomizableEdges = customizableEdges1;
            this.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnActualizar.FillColor = System.Drawing.Color.FromArgb(100, 150, 100);
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(290, 8);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnActualizar.Size = new System.Drawing.Size(130, 35);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // FrmCalificarTareas
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 535);
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
            this.panelBotones.ResumeLayout(false);
            this.panelFormControls.ResumeLayout(false);
            this.panelFormControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private Guna.UI2.WinForms.Guna2Panel panelTareas;
        private System.Windows.Forms.Label lblTareasTitle;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntregas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private Guna.UI2.WinForms.Guna2Panel panelEntregasYForm;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Guna.UI2.WinForms.Guna2Panel panelEntregas;
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
        private Guna.UI2.WinForms.Guna2Panel panelCalificacion;
        private Guna.UI2.WinForms.Guna2Panel panelBotones;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnCalificar;
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
        private Guna.UI2.WinForms.Guna2Panel panelFormControls;
    }
}
