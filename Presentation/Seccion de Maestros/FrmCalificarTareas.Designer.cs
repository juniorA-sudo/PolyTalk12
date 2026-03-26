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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.flpTareas = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flpEntregas = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFormControls = new Guna.UI2.WinForms.Guna2Panel();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCalificar = new Guna.UI2.WinForms.Guna2Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.RichTextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.RichTextBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblEstudianteVal = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(854, 55);
            this.panelHeader.TabIndex = 0;

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📝 Calificar Tareas";

            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblFecha.Location = new System.Drawing.Point(12, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(80, 15);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "—";

            // splitContainerMain
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 55);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.splitContainerMain.SplitterDistance = 95;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.Panel1.Controls.Add(this.flpTareas);
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainerMain.Size = new System.Drawing.Size(854, 480);
            this.splitContainerMain.TabIndex = 1;

            // flpTareas
            this.flpTareas.AutoScroll = true;
            this.flpTareas.BackColor = System.Drawing.Color.White;
            this.flpTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTareas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTareas.Location = new System.Drawing.Point(0, 0);
            this.flpTareas.Name = "flpTareas";
            this.flpTareas.Padding = new System.Windows.Forms.Padding(8);
            this.flpTareas.Size = new System.Drawing.Size(854, 95);
            this.flpTareas.TabIndex = 0;
            this.flpTareas.WrapContents = false;

            // splitContainer2
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.SplitterDistance = 160;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.Panel1.Controls.Add(this.flpEntregas);
            this.splitContainer2.Panel2.Controls.Add(this.panelFormControls);
            this.splitContainer2.Size = new System.Drawing.Size(854, 382);
            this.splitContainer2.TabIndex = 0;

            // flpEntregas
            this.flpEntregas.AutoScroll = true;
            this.flpEntregas.BackColor = System.Drawing.Color.White;
            this.flpEntregas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEntregas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEntregas.Location = new System.Drawing.Point(0, 0);
            this.flpEntregas.Name = "flpEntregas";
            this.flpEntregas.Padding = new System.Windows.Forms.Padding(8);
            this.flpEntregas.Size = new System.Drawing.Size(854, 160);
            this.flpEntregas.TabIndex = 0;
            this.flpEntregas.WrapContents = false;

            // panelFormControls
            this.panelFormControls.CustomizableEdges = customizableEdges3;
            this.panelFormControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormControls.FillColor = System.Drawing.Color.FromArgb(249, 199, 79);
            this.panelFormControls.Name = "panelFormControls";
            this.panelFormControls.Padding = new System.Windows.Forms.Padding(8);
            this.panelFormControls.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.panelFormControls.Size = new System.Drawing.Size(854, 219);
            this.panelFormControls.TabIndex = 0;

            this.panelFormControls.Controls.Add(this.btnActualizar);
            this.panelFormControls.Controls.Add(this.btnLimpiar);
            this.panelFormControls.Controls.Add(this.btnCalificar);
            this.panelFormControls.Controls.Add(this.lblFeedback);
            this.panelFormControls.Controls.Add(this.txtFeedback);
            this.panelFormControls.Controls.Add(this.lblNota);
            this.panelFormControls.Controls.Add(this.nudNota);
            this.panelFormControls.Controls.Add(this.lblComentario);
            this.panelFormControls.Controls.Add(this.txtComentario);
            this.panelFormControls.Controls.Add(this.lblEstudiante);
            this.panelFormControls.Controls.Add(this.lblEstudianteVal);

            // lblEstudiante
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEstudiante.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblEstudiante.Location = new System.Drawing.Point(8, 8);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(65, 15);
            this.lblEstudiante.TabIndex = 0;
            this.lblEstudiante.Text = "Estudiante:";

            // lblEstudianteVal
            this.lblEstudianteVal.AutoSize = true;
            this.lblEstudianteVal.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEstudianteVal.ForeColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.lblEstudianteVal.Location = new System.Drawing.Point(8, 28);
            this.lblEstudianteVal.Name = "lblEstudianteVal";
            this.lblEstudianteVal.Size = new System.Drawing.Size(15, 15);
            this.lblEstudianteVal.TabIndex = 1;
            this.lblEstudianteVal.Text = "—";

            // lblComentario
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblComentario.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblComentario.Location = new System.Drawing.Point(8, 50);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(70, 15);
            this.lblComentario.TabIndex = 2;
            this.lblComentario.Text = "Comentario:";

            // txtComentario
            this.txtComentario.BackColor = System.Drawing.Color.FromArgb(245, 245, 247);
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtComentario.Location = new System.Drawing.Point(8, 68);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ReadOnly = true;
            this.txtComentario.Size = new System.Drawing.Size(590, 35);
            this.txtComentario.TabIndex = 3;
            this.txtComentario.Text = "";

            // lblNota
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblNota.Location = new System.Drawing.Point(8, 108);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(35, 15);
            this.lblNota.TabIndex = 4;
            this.lblNota.Text = "Nota:";

            // nudNota
            this.nudNota.BackColor = System.Drawing.Color.White;
            this.nudNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNota.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.nudNota.Location = new System.Drawing.Point(8, 126);
            this.nudNota.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(80, 24);
            this.nudNota.TabIndex = 5;
            this.nudNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNota.ForeColor = System.Drawing.Color.FromArgb(30, 90, 160);

            // lblFeedback
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFeedback.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblFeedback.Location = new System.Drawing.Point(8, 154);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(55, 15);
            this.lblFeedback.TabIndex = 6;
            this.lblFeedback.Text = "Feedback:";

            // txtFeedback
            this.txtFeedback.BackColor = System.Drawing.Color.White;
            this.txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeedback.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtFeedback.Location = new System.Drawing.Point(8, 172);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(590, 45);
            this.txtFeedback.TabIndex = 7;
            this.txtFeedback.Text = "";

            // btnCalificar
            this.btnCalificar.CustomizableEdges = customizableEdges1;
            this.btnCalificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnCalificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnCalificar.Enabled = false;
            this.btnCalificar.FillColor = System.Drawing.Color.FromArgb(30, 90, 160);
            this.btnCalificar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnCalificar.ForeColor = System.Drawing.Color.White;
            this.btnCalificar.Location = new System.Drawing.Point(8, 223);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnCalificar.Size = new System.Drawing.Size(100, 28);
            this.btnCalificar.TabIndex = 8;
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
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(115, 223);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "🗑️ Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // btnActualizar
            this.btnActualizar.CustomizableEdges = customizableEdges1;
            this.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            this.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            this.btnActualizar.FillColor = System.Drawing.Color.FromArgb(100, 150, 100);
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(222, 223);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // FrmCalificarTareas
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 535);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmCalificarTareas";
            this.Text = "Calificar Tareas";
            this.Load += new System.EventHandler(this.FrmCalificarTareas_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelFormControls.ResumeLayout(false);
            this.panelFormControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.FlowLayoutPanel flpTareas;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flpEntregas;
        private Guna.UI2.WinForms.Guna2Panel panelFormControls;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnCalificar;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.RichTextBox txtFeedback;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.RichTextBox txtComentario;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblEstudianteVal;
    }
}
