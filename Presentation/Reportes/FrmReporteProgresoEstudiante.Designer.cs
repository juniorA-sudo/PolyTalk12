using Guna.UI2.WinForms;

namespace Presentation.Reportes
{
    partial class FrmReporteProgresoEstudiante
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelHeader;
        private Guna2HtmlLabel lblTitulo;
        private Guna2HtmlLabel lblSub;
        private Guna2HtmlLabel lblNombreEstudiante;
        private Guna2HtmlLabel lblFecha;
        private Guna2HtmlLabel lblNombreReporte;
        private Guna2Panel panelProgreso;
        private Guna2HtmlLabel lblGeneralLabel;
        private ProgressBar prgGeneral;
        private Guna2HtmlLabel lblGeneralVal;
        private Guna2HtmlLabel lblLeccionesLabel;
        private ProgressBar prgLecciones;
        private Guna2HtmlLabel lblLeccionesVal;
        private Guna2HtmlLabel lblVocabularioLabel;
        private ProgressBar prgVocabulario;
        private Guna2HtmlLabel lblVocabularioVal;
        private Guna2HtmlLabel lblTareasLabel;
        private ProgressBar prgTareas;
        private Guna2HtmlLabel lblTareasVal;
        private Guna2Panel panelMetricas;
        private Guna2HtmlLabel lblPromedioLabel;
        private Guna2HtmlLabel lblPromedioVal;
        private Guna2HtmlLabel lblNivelLabel;
        private Guna2HtmlLabel lblNivelVal;
        private Guna2Panel panelFirma;
        private Guna2HtmlLabel lblFirma;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            panelHeader = new Guna2Panel();
            lblTitulo = new Guna2HtmlLabel();
            lblSub = new Guna2HtmlLabel();
            lblNombreEstudiante = new Guna2HtmlLabel();
            lblFecha = new Guna2HtmlLabel();
            lblNombreReporte = new Guna2HtmlLabel();
            panelProgreso = new Guna2Panel();
            lblGeneralLabel = new Guna2HtmlLabel();
            prgGeneral = new ProgressBar();
            lblGeneralVal = new Guna2HtmlLabel();
            lblLeccionesLabel = new Guna2HtmlLabel();
            prgLecciones = new ProgressBar();
            lblLeccionesVal = new Guna2HtmlLabel();
            lblVocabularioLabel = new Guna2HtmlLabel();
            prgVocabulario = new ProgressBar();
            lblVocabularioVal = new Guna2HtmlLabel();
            lblTareasLabel = new Guna2HtmlLabel();
            prgTareas = new ProgressBar();
            lblTareasVal = new Guna2HtmlLabel();
            panelMetricas = new Guna2Panel();
            lblPromedioLabel = new Guna2HtmlLabel();
            lblPromedioVal = new Guna2HtmlLabel();
            lblNivelLabel = new Guna2HtmlLabel();
            lblNivelVal = new Guna2HtmlLabel();
            panelFirma = new Guna2Panel();
            lblFirma = new Guna2HtmlLabel();

            panelHeader.SuspendLayout();
            panelProgreso.SuspendLayout();
            panelMetricas.SuspendLayout();
            panelFirma.SuspendLayout();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = System.Drawing.Color.Transparent;
            panelHeader.BorderRadius = 10;
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSub);
            panelHeader.Controls.Add(lblNombreEstudiante);
            panelHeader.Controls.Add(lblFecha);
            panelHeader.CustomizableEdges = customizableEdges1;
            panelHeader.FillColor = System.Drawing.Color.White;
            panelHeader.Location = new System.Drawing.Point(12, 12);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new System.Windows.Forms.Padding(15);
            panelHeader.ShadowDecoration.Color = System.Drawing.Color.FromArgb(30, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            panelHeader.Size = new System.Drawing.Size(565, 80);
            panelHeader.TabIndex = 0;

            // lblTitulo
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = System.Drawing.Color.Transparent;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            lblTitulo.Location = new System.Drawing.Point(25, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(150, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PolyTalk";

            // lblSub
            lblSub.AutoSize = false;
            lblSub.BackColor = System.Drawing.Color.Transparent;
            lblSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblSub.ForeColor = System.Drawing.Color.Gray;
            lblSub.Location = new System.Drawing.Point(25, 40);
            lblSub.Name = "lblSub";
            lblSub.Size = new System.Drawing.Size(200, 20);
            lblSub.TabIndex = 1;
            lblSub.Text = "Learning Management System";

            // lblNombreEstudiante
            lblNombreEstudiante.AutoSize = false;
            lblNombreEstudiante.BackColor = System.Drawing.Color.Transparent;
            lblNombreEstudiante.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblNombreEstudiante.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblNombreEstudiante.Location = new System.Drawing.Point(300, 20);
            lblNombreEstudiante.Name = "lblNombreEstudiante";
            lblNombreEstudiante.Size = new System.Drawing.Size(250, 25);
            lblNombreEstudiante.TabIndex = 2;
            lblNombreEstudiante.Text = "Estudiante";

            // lblFecha
            lblFecha.AutoSize = false;
            lblFecha.BackColor = System.Drawing.Color.Transparent;
            lblFecha.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblFecha.ForeColor = System.Drawing.Color.Gray;
            lblFecha.Location = new System.Drawing.Point(300, 50);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(250, 16);
            lblFecha.TabIndex = 3;
            lblFecha.Text = System.DateTime.Now.ToString("dd 'de' MMMM, yyyy");

            // lblNombreReporte
            lblNombreReporte.AutoSize = false;
            lblNombreReporte.BackColor = System.Drawing.Color.Transparent;
            lblNombreReporte.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblNombreReporte.ForeColor = System.Drawing.Color.Black;
            lblNombreReporte.Location = new System.Drawing.Point(144, 105);
            lblNombreReporte.Name = "lblNombreReporte";
            lblNombreReporte.Size = new System.Drawing.Size(300, 25);
            lblNombreReporte.TabIndex = 1;
            lblNombreReporte.Text = "📈 Mi Progreso General";

            // panelProgreso
            panelProgreso.BackColor = System.Drawing.Color.Transparent;
            panelProgreso.BorderRadius = 8;
            panelProgreso.Controls.Add(lblGeneralLabel);
            panelProgreso.Controls.Add(prgGeneral);
            panelProgreso.Controls.Add(lblGeneralVal);
            panelProgreso.Controls.Add(lblLeccionesLabel);
            panelProgreso.Controls.Add(prgLecciones);
            panelProgreso.Controls.Add(lblLeccionesVal);
            panelProgreso.Controls.Add(lblVocabularioLabel);
            panelProgreso.Controls.Add(prgVocabulario);
            panelProgreso.Controls.Add(lblVocabularioVal);
            panelProgreso.Controls.Add(lblTareasLabel);
            panelProgreso.Controls.Add(prgTareas);
            panelProgreso.Controls.Add(lblTareasVal);
            panelProgreso.CustomizableEdges = customizableEdges3;
            panelProgreso.FillColor = System.Drawing.Color.White;
            panelProgreso.Location = new System.Drawing.Point(12, 138);
            panelProgreso.Name = "panelProgreso";
            panelProgreso.Padding = new System.Windows.Forms.Padding(20);
            panelProgreso.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelProgreso.ShadowDecoration.Enabled = true;
            panelProgreso.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 4, 4);
            panelProgreso.Size = new System.Drawing.Size(565, 280);
            panelProgreso.TabIndex = 2;

            // lblGeneralLabel
            lblGeneralLabel.AutoSize = false;
            lblGeneralLabel.BackColor = System.Drawing.Color.Transparent;
            lblGeneralLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblGeneralLabel.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            lblGeneralLabel.Location = new System.Drawing.Point(20, 15);
            lblGeneralLabel.Name = "lblGeneralLabel";
            lblGeneralLabel.Size = new System.Drawing.Size(200, 22);
            lblGeneralLabel.TabIndex = 0;
            lblGeneralLabel.Text = "📊 Progreso General";

            // prgGeneral
            prgGeneral.Location = new System.Drawing.Point(20, 40);
            prgGeneral.Name = "prgGeneral";
            prgGeneral.Size = new System.Drawing.Size(380, 20);
            prgGeneral.TabIndex = 1;
            prgGeneral.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);

            // lblGeneralVal
            lblGeneralVal.AutoSize = false;
            lblGeneralVal.BackColor = System.Drawing.Color.Transparent;
            lblGeneralVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblGeneralVal.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            lblGeneralVal.Location = new System.Drawing.Point(405, 40);
            lblGeneralVal.Name = "lblGeneralVal";
            lblGeneralVal.Size = new System.Drawing.Size(120, 20);
            lblGeneralVal.TabIndex = 2;
            lblGeneralVal.Text = "0%";

            // lblLeccionesLabel
            lblLeccionesLabel.AutoSize = false;
            lblLeccionesLabel.BackColor = System.Drawing.Color.Transparent;
            lblLeccionesLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblLeccionesLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblLeccionesLabel.Location = new System.Drawing.Point(20, 75);
            lblLeccionesLabel.Name = "lblLeccionesLabel";
            lblLeccionesLabel.Size = new System.Drawing.Size(200, 20);
            lblLeccionesLabel.TabIndex = 3;
            lblLeccionesLabel.Text = "📚 Lecciones Completadas";

            // prgLecciones
            prgLecciones.Location = new System.Drawing.Point(20, 100);
            prgLecciones.Name = "prgLecciones";
            prgLecciones.Size = new System.Drawing.Size(380, 18);
            prgLecciones.TabIndex = 4;

            // lblLeccionesVal
            lblLeccionesVal.AutoSize = false;
            lblLeccionesVal.BackColor = System.Drawing.Color.Transparent;
            lblLeccionesVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblLeccionesVal.ForeColor = System.Drawing.Color.Gray;
            lblLeccionesVal.Location = new System.Drawing.Point(405, 100);
            lblLeccionesVal.Name = "lblLeccionesVal";
            lblLeccionesVal.Size = new System.Drawing.Size(120, 18);
            lblLeccionesVal.TabIndex = 5;
            lblLeccionesVal.Text = "0/0 (0%)";

            // lblVocabularioLabel
            lblVocabularioLabel.AutoSize = false;
            lblVocabularioLabel.BackColor = System.Drawing.Color.Transparent;
            lblVocabularioLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblVocabularioLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblVocabularioLabel.Location = new System.Drawing.Point(20, 135);
            lblVocabularioLabel.Name = "lblVocabularioLabel";
            lblVocabularioLabel.Size = new System.Drawing.Size(200, 20);
            lblVocabularioLabel.TabIndex = 6;
            lblVocabularioLabel.Text = "📖 Vocabulario Aprendido";

            // prgVocabulario
            prgVocabulario.Location = new System.Drawing.Point(20, 160);
            prgVocabulario.Name = "prgVocabulario";
            prgVocabulario.Size = new System.Drawing.Size(380, 18);
            prgVocabulario.TabIndex = 7;

            // lblVocabularioVal
            lblVocabularioVal.AutoSize = false;
            lblVocabularioVal.BackColor = System.Drawing.Color.Transparent;
            lblVocabularioVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblVocabularioVal.ForeColor = System.Drawing.Color.Gray;
            lblVocabularioVal.Location = new System.Drawing.Point(405, 160);
            lblVocabularioVal.Name = "lblVocabularioVal";
            lblVocabularioVal.Size = new System.Drawing.Size(120, 18);
            lblVocabularioVal.TabIndex = 8;
            lblVocabularioVal.Text = "0/0 (0%)";

            // lblTareasLabel
            lblTareasLabel.AutoSize = false;
            lblTareasLabel.BackColor = System.Drawing.Color.Transparent;
            lblTareasLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTareasLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblTareasLabel.Location = new System.Drawing.Point(20, 195);
            lblTareasLabel.Name = "lblTareasLabel";
            lblTareasLabel.Size = new System.Drawing.Size(200, 20);
            lblTareasLabel.TabIndex = 9;
            lblTareasLabel.Text = "✅ Tareas Entregadas";

            // prgTareas
            prgTareas.Location = new System.Drawing.Point(20, 220);
            prgTareas.Name = "prgTareas";
            prgTareas.Size = new System.Drawing.Size(380, 18);
            prgTareas.TabIndex = 10;

            // lblTareasVal
            lblTareasVal.AutoSize = false;
            lblTareasVal.BackColor = System.Drawing.Color.Transparent;
            lblTareasVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblTareasVal.ForeColor = System.Drawing.Color.Gray;
            lblTareasVal.Location = new System.Drawing.Point(405, 220);
            lblTareasVal.Name = "lblTareasVal";
            lblTareasVal.Size = new System.Drawing.Size(120, 18);
            lblTareasVal.TabIndex = 11;
            lblTareasVal.Text = "0/0 (0%)";

            // panelMetricas
            panelMetricas.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            panelMetricas.BorderRadius = 8;
            panelMetricas.Controls.Add(lblPromedioLabel);
            panelMetricas.Controls.Add(lblPromedioVal);
            panelMetricas.Controls.Add(lblNivelLabel);
            panelMetricas.Controls.Add(lblNivelVal);
            panelMetricas.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMetricas.FillColor = System.Drawing.Color.FromArgb(240, 245, 255);
            panelMetricas.Location = new System.Drawing.Point(12, 426);
            panelMetricas.Name = "panelMetricas";
            panelMetricas.Padding = new System.Windows.Forms.Padding(20);
            panelMetricas.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelMetricas.Size = new System.Drawing.Size(565, 70);
            panelMetricas.TabIndex = 3;

            // lblPromedioLabel
            lblPromedioLabel.AutoSize = false;
            lblPromedioLabel.BackColor = System.Drawing.Color.Transparent;
            lblPromedioLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPromedioLabel.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            lblPromedioLabel.Location = new System.Drawing.Point(20, 10);
            lblPromedioLabel.Name = "lblPromedioLabel";
            lblPromedioLabel.Size = new System.Drawing.Size(120, 18);
            lblPromedioLabel.TabIndex = 0;
            lblPromedioLabel.Text = "⭐ Promedio:";

            // lblPromedioVal
            lblPromedioVal.AutoSize = false;
            lblPromedioVal.BackColor = System.Drawing.Color.Transparent;
            lblPromedioVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblPromedioVal.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            lblPromedioVal.Location = new System.Drawing.Point(140, 10);
            lblPromedioVal.Name = "lblPromedioVal";
            lblPromedioVal.Size = new System.Drawing.Size(100, 20);
            lblPromedioVal.TabIndex = 1;
            lblPromedioVal.Text = "N/A";

            // lblNivelLabel
            lblNivelLabel.AutoSize = false;
            lblNivelLabel.BackColor = System.Drawing.Color.Transparent;
            lblNivelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblNivelLabel.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            lblNivelLabel.Location = new System.Drawing.Point(350, 10);
            lblNivelLabel.Name = "lblNivelLabel";
            lblNivelLabel.Size = new System.Drawing.Size(100, 18);
            lblNivelLabel.TabIndex = 2;
            lblNivelLabel.Text = "🎯 Nivel:";

            // lblNivelVal
            lblNivelVal.AutoSize = false;
            lblNivelVal.BackColor = System.Drawing.Color.Transparent;
            lblNivelVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblNivelVal.ForeColor = System.Drawing.Color.FromArgb(0, 82, 180);
            lblNivelVal.Location = new System.Drawing.Point(450, 10);
            lblNivelVal.Name = "lblNivelVal";
            lblNivelVal.Size = new System.Drawing.Size(85, 20);
            lblNivelVal.TabIndex = 3;
            lblNivelVal.Text = "Elemental";

            // panelFirma
            panelFirma.BackColor = System.Drawing.Color.White;
            panelFirma.BorderRadius = 8;
            panelFirma.Controls.Add(lblFirma);
            panelFirma.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelFirma.Location = new System.Drawing.Point(12, 504);
            panelFirma.Name = "panelFirma";
            panelFirma.Padding = new System.Windows.Forms.Padding(10);
            panelFirma.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelFirma.Size = new System.Drawing.Size(565, 30);
            panelFirma.TabIndex = 4;

            // lblFirma
            lblFirma.AutoSize = false;
            lblFirma.BackColor = System.Drawing.Color.Transparent;
            lblFirma.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblFirma.ForeColor = System.Drawing.Color.Gray;
            lblFirma.Location = new System.Drawing.Point(15, 5);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new System.Drawing.Size(530, 20);
            lblFirma.TabIndex = 0;
            lblFirma.Text = "Reporte generado automáticamente. PolyTalk Learning Management System";

            // FrmReporteProgresoEstudiante
            AutoScroll = true;
            BackColor = System.Drawing.Color.FromArgb(242, 245, 250);
            ClientSize = new System.Drawing.Size(589, 546);
            Controls.Add(lblNombreReporte);
            Controls.Add(panelHeader);
            Controls.Add(panelProgreso);
            Controls.Add(panelMetricas);
            Controls.Add(panelFirma);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmReporteProgresoEstudiante";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Reporte: Mi Progreso General";

            panelHeader.ResumeLayout(false);
            panelProgreso.ResumeLayout(false);
            panelMetricas.ResumeLayout(false);
            panelFirma.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
