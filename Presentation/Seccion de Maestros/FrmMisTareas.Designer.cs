using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Maestros
{
    partial class FrmMisTareas
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelHeader;
        private System.Windows.Forms.Label accentBar;
        private Guna2HtmlLabel lblTituloHeader;
        private Guna2HtmlLabel lblTotalTareas;
        private Guna2Button btnNuevaTarea;
        private Guna2Panel panelIzquierdo;
        private FlowLayoutPanel flpTareas;
        private Guna2Panel panelDerecho;
        private Guna2Panel cardDetalleInfo;
        private Guna2HtmlLabel lblDetalleTitulo;
        private Guna2HtmlLabel lblDetalleGrupo;
        private Guna2HtmlLabel lblDetalleFecha;
        private Guna2HtmlLabel lblTotalEntregas;
        private Guna2Panel panelListaEntregas;
        private FlowLayoutPanel flpEntregas;
        private Guna2Panel panelCalificar;
        private Guna2HtmlLabel lblCalNombre;
        private Guna2HtmlLabel lblCalArchivo;
        private Guna2HtmlLabel lblCalComentarioLbl;
        private Guna2TextBox txtCalComentario;
        private Guna2HtmlLabel lblCalNotaLbl;
        private Guna2TextBox txtCalificacion;
        private Guna2HtmlLabel lblCalFeedbackLbl;
        private Guna2TextBox txtFeedback;
        private Guna2Button btnCalificar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            accentBar = new Label();
            panelHeader = new Guna2Panel();
            lblTituloHeader = new Guna2HtmlLabel();
            lblTotalTareas = new Guna2HtmlLabel();
            btnNuevaTarea = new Guna2Button();
            panelIzquierdo = new Guna2Panel();
            flpTareas = new FlowLayoutPanel();
            panelDerecho = new Guna2Panel();
            cardDetalleInfo = new Guna2Panel();
            lblDetalleTitulo = new Guna2HtmlLabel();
            lblDetalleGrupo = new Guna2HtmlLabel();
            lblDetalleFecha = new Guna2HtmlLabel();
            lblTotalEntregas = new Guna2HtmlLabel();
            panelListaEntregas = new Guna2Panel();
            flpEntregas = new FlowLayoutPanel();
            panelCalificar = new Guna2Panel();
            lblCalNombre = new Guna2HtmlLabel();
            lblCalArchivo = new Guna2HtmlLabel();
            lblCalComentarioLbl = new Guna2HtmlLabel();
            txtCalComentario = new Guna2TextBox();
            lblCalNotaLbl = new Guna2HtmlLabel();
            txtCalificacion = new Guna2TextBox();
            lblCalFeedbackLbl = new Guna2HtmlLabel();
            txtFeedback = new Guna2TextBox();
            btnCalificar = new Guna2Button();
            panelHeader.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            panelDerecho.SuspendLayout();
            cardDetalleInfo.SuspendLayout();
            panelListaEntregas.SuspendLayout();
            panelCalificar.SuspendLayout();
            SuspendLayout();
            // 
            // accentBar
            // 
            accentBar.BackColor = Color.FromArgb(255, 183, 0);
            accentBar.Location = new Point(0, 0);
            accentBar.Name = "accentBar";
            accentBar.Size = new Size(5, 70);
            accentBar.TabIndex = 99;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(accentBar);
            panelHeader.Controls.Add(lblTituloHeader);
            panelHeader.Controls.Add(lblTotalTareas);
            panelHeader.Controls.Add(btnNuevaTarea);
            panelHeader.CustomizableEdges = customizableEdges3;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.FillColor = Color.White;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelHeader.ShadowDecoration.Depth = 4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.Size = new Size(854, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblTituloHeader
            // 
            lblTituloHeader.AutoSize = false;
            lblTituloHeader.BackColor = Color.Transparent;
            lblTituloHeader.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lblTituloHeader.ForeColor = Color.FromArgb(25, 25, 35);
            lblTituloHeader.Location = new Point(18, 18);
            lblTituloHeader.Name = "lblTituloHeader";
            lblTituloHeader.Size = new Size(280, 32);
            lblTituloHeader.TabIndex = 0;
            lblTituloHeader.Text = "Mis Tareas";
            // 
            // lblTotalTareas
            // 
            lblTotalTareas.AutoSize = false;
            lblTotalTareas.BackColor = Color.Transparent;
            lblTotalTareas.Font = new Font("Segoe UI", 9F);
            lblTotalTareas.ForeColor = Color.FromArgb(130, 120, 100);
            lblTotalTareas.Location = new Point(310, 26);
            lblTotalTareas.Name = "lblTotalTareas";
            lblTotalTareas.Size = new Size(80, 18);
            lblTotalTareas.TabIndex = 1;
            lblTotalTareas.Text = "0 tareas";
            // 
            // btnNuevaTarea
            // 
            btnNuevaTarea.BackColor = Color.Transparent;
            btnNuevaTarea.BorderRadius = 18;
            btnNuevaTarea.Cursor = Cursors.Hand;
            btnNuevaTarea.CustomizableEdges = customizableEdges1;
            btnNuevaTarea.FillColor = Color.FromArgb(255, 183, 0);
            btnNuevaTarea.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevaTarea.ForeColor = Color.White;
            btnNuevaTarea.HoverState.FillColor = Color.FromArgb(220, 155, 0);
            btnNuevaTarea.Location = new Point(646, 16);
            btnNuevaTarea.Name = "btnNuevaTarea";
            btnNuevaTarea.ShadowDecoration.Color = Color.FromArgb(40, 255, 183, 0);
            btnNuevaTarea.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnNuevaTarea.ShadowDecoration.Depth = 6;
            btnNuevaTarea.ShadowDecoration.Enabled = true;
            btnNuevaTarea.Size = new Size(148, 38);
            btnNuevaTarea.TabIndex = 2;
            btnNuevaTarea.Text = "Nueva Tarea";
            btnNuevaTarea.Click += btnNuevaTarea_Click;
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.Transparent;
            panelIzquierdo.BorderRadius = 16;
            panelIzquierdo.Controls.Add(flpTareas);
            panelIzquierdo.CustomizableEdges = customizableEdges5;
            panelIzquierdo.FillColor = Color.White;
            panelIzquierdo.Location = new Point(16, 86);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.ShadowDecoration.Color = Color.FromArgb(14, 0, 0, 0);
            panelIzquierdo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelIzquierdo.ShadowDecoration.Depth = 6;
            panelIzquierdo.ShadowDecoration.Enabled = true;
            panelIzquierdo.Size = new Size(408, 434);
            panelIzquierdo.TabIndex = 1;
            // 
            // flpTareas
            // 
            flpTareas.AutoScroll = true;
            flpTareas.BackColor = Color.Transparent;
            flpTareas.Dock = DockStyle.Fill;
            flpTareas.FlowDirection = FlowDirection.TopDown;
            flpTareas.Location = new Point(0, 0);
            flpTareas.Name = "flpTareas";
            flpTareas.Padding = new Padding(6);
            flpTareas.Size = new Size(408, 434);
            flpTareas.TabIndex = 0;
            flpTareas.WrapContents = false;
            // 
            // panelDerecho
            // 
            panelDerecho.AutoScroll = true;
            panelDerecho.Controls.Add(cardDetalleInfo);
            panelDerecho.Controls.Add(lblTotalEntregas);
            panelDerecho.Controls.Add(panelListaEntregas);
            panelDerecho.Controls.Add(panelCalificar);
            panelDerecho.CustomizableEdges = customizableEdges21;
            panelDerecho.FillColor = Color.Transparent;
            panelDerecho.Location = new Point(438, 86);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.ShadowDecoration.CustomizableEdges = customizableEdges22;
            panelDerecho.Size = new Size(400, 434);
            panelDerecho.TabIndex = 2;
            panelDerecho.Visible = false;
            // 
            // cardDetalleInfo
            // 
            cardDetalleInfo.BorderRadius = 14;
            cardDetalleInfo.Controls.Add(lblDetalleTitulo);
            cardDetalleInfo.Controls.Add(lblDetalleGrupo);
            cardDetalleInfo.Controls.Add(lblDetalleFecha);
            cardDetalleInfo.CustomizableEdges = customizableEdges7;
            cardDetalleInfo.FillColor = Color.FromArgb(255, 248, 235);
            cardDetalleInfo.Location = new Point(0, 0);
            cardDetalleInfo.Name = "cardDetalleInfo";
            cardDetalleInfo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cardDetalleInfo.Size = new Size(400, 80);
            cardDetalleInfo.TabIndex = 0;
            // 
            // lblDetalleTitulo
            // 
            lblDetalleTitulo.AutoSize = false;
            lblDetalleTitulo.BackColor = Color.Transparent;
            lblDetalleTitulo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblDetalleTitulo.ForeColor = Color.FromArgb(25, 25, 35);
            lblDetalleTitulo.Location = new Point(14, 12);
            lblDetalleTitulo.Name = "lblDetalleTitulo";
            lblDetalleTitulo.Size = new Size(372, 24);
            lblDetalleTitulo.TabIndex = 0;
            lblDetalleTitulo.Text = "Selecciona una tarea";
            // 
            // lblDetalleGrupo
            // 
            lblDetalleGrupo.AutoSize = false;
            lblDetalleGrupo.BackColor = Color.Transparent;
            lblDetalleGrupo.Font = new Font("Segoe UI", 9F);
            lblDetalleGrupo.ForeColor = Color.FromArgb(130, 120, 100);
            lblDetalleGrupo.Location = new Point(14, 40);
            lblDetalleGrupo.Name = "lblDetalleGrupo";
            lblDetalleGrupo.Size = new Size(190, 16);
            lblDetalleGrupo.TabIndex = 1;
            lblDetalleGrupo.Text = "Grupo: —";
            // 
            // lblDetalleFecha
            // 
            lblDetalleFecha.AutoSize = false;
            lblDetalleFecha.BackColor = Color.Transparent;
            lblDetalleFecha.Font = new Font("Segoe UI", 9F);
            lblDetalleFecha.ForeColor = Color.FromArgb(130, 120, 100);
            lblDetalleFecha.Location = new Point(210, 40);
            lblDetalleFecha.Name = "lblDetalleFecha";
            lblDetalleFecha.Size = new Size(176, 16);
            lblDetalleFecha.TabIndex = 2;
            lblDetalleFecha.Text = "Entrega: —";
            // 
            // lblTotalEntregas
            // 
            lblTotalEntregas.AutoSize = false;
            lblTotalEntregas.BackColor = Color.Transparent;
            lblTotalEntregas.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTotalEntregas.ForeColor = Color.FromArgb(255, 183, 0);
            lblTotalEntregas.Location = new Point(0, 88);
            lblTotalEntregas.Name = "lblTotalEntregas";
            lblTotalEntregas.Size = new Size(120, 18);
            lblTotalEntregas.TabIndex = 1;
            lblTotalEntregas.Text = "0 entregas";
            // 
            // panelListaEntregas
            // 
            panelListaEntregas.BackColor = Color.Transparent;
            panelListaEntregas.BorderRadius = 14;
            panelListaEntregas.Controls.Add(flpEntregas);
            panelListaEntregas.CustomizableEdges = customizableEdges9;
            panelListaEntregas.FillColor = Color.White;
            panelListaEntregas.Location = new Point(0, 110);
            panelListaEntregas.Name = "panelListaEntregas";
            panelListaEntregas.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            panelListaEntregas.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelListaEntregas.ShadowDecoration.Depth = 5;
            panelListaEntregas.ShadowDecoration.Enabled = true;
            panelListaEntregas.Size = new Size(400, 150);
            panelListaEntregas.TabIndex = 2;
            // 
            // flpEntregas
            // 
            flpEntregas.AutoScroll = true;
            flpEntregas.BackColor = Color.Transparent;
            flpEntregas.Dock = DockStyle.Fill;
            flpEntregas.FlowDirection = FlowDirection.TopDown;
            flpEntregas.Location = new Point(0, 0);
            flpEntregas.Name = "flpEntregas";
            flpEntregas.Padding = new Padding(4);
            flpEntregas.Size = new Size(400, 150);
            flpEntregas.TabIndex = 0;
            flpEntregas.WrapContents = false;
            // 
            // panelCalificar
            // 
            panelCalificar.AutoScroll = true;
            panelCalificar.BackColor = Color.Transparent;
            panelCalificar.BorderRadius = 14;
            panelCalificar.Controls.Add(lblCalNombre);
            panelCalificar.Controls.Add(lblCalArchivo);
            panelCalificar.Controls.Add(lblCalComentarioLbl);
            panelCalificar.Controls.Add(txtCalComentario);
            panelCalificar.Controls.Add(lblCalNotaLbl);
            panelCalificar.Controls.Add(txtCalificacion);
            panelCalificar.Controls.Add(lblCalFeedbackLbl);
            panelCalificar.Controls.Add(txtFeedback);
            panelCalificar.Controls.Add(btnCalificar);
            panelCalificar.CustomizableEdges = customizableEdges19;
            panelCalificar.FillColor = Color.White;
            panelCalificar.Location = new Point(0, 268);
            panelCalificar.Name = "panelCalificar";
            panelCalificar.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);
            panelCalificar.ShadowDecoration.CustomizableEdges = customizableEdges20;
            panelCalificar.ShadowDecoration.Depth = 5;
            panelCalificar.ShadowDecoration.Enabled = true;
            panelCalificar.Size = new Size(400, 300);
            panelCalificar.TabIndex = 3;
            panelCalificar.Visible = false;
            // 
            // lblCalNombre
            // 
            lblCalNombre.AutoSize = false;
            lblCalNombre.BackColor = Color.Transparent;
            lblCalNombre.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            lblCalNombre.ForeColor = Color.FromArgb(25, 25, 35);
            lblCalNombre.Location = new Point(14, 10);
            lblCalNombre.Name = "lblCalNombre";
            lblCalNombre.Size = new Size(372, 22);
            lblCalNombre.TabIndex = 0;
            lblCalNombre.Text = "Estudiante";
            // 
            // lblCalArchivo
            // 
            lblCalArchivo.AutoSize = false;
            lblCalArchivo.BackColor = Color.Transparent;
            lblCalArchivo.Font = new Font("Segoe UI", 9F);
            lblCalArchivo.ForeColor = Color.FromArgb(66, 153, 225);
            lblCalArchivo.Location = new Point(14, 34);
            lblCalArchivo.Name = "lblCalArchivo";
            lblCalArchivo.Size = new Size(372, 16);
            lblCalArchivo.TabIndex = 1;
            lblCalArchivo.Text = "Sin archivo";
            // 
            // lblCalComentarioLbl
            // 
            lblCalComentarioLbl.AutoSize = false;
            lblCalComentarioLbl.BackColor = Color.Transparent;
            lblCalComentarioLbl.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCalComentarioLbl.ForeColor = Color.FromArgb(130, 120, 100);
            lblCalComentarioLbl.Location = new Point(14, 54);
            lblCalComentarioLbl.Name = "lblCalComentarioLbl";
            lblCalComentarioLbl.Size = new Size(100, 14);
            lblCalComentarioLbl.TabIndex = 2;
            lblCalComentarioLbl.Text = "COMENTARIO";
            // 
            // txtCalComentario
            // 
            txtCalComentario.BorderRadius = 8;
            txtCalComentario.CustomizableEdges = customizableEdges11;
            txtCalComentario.DefaultText = "";
            txtCalComentario.FillColor = Color.FromArgb(245, 242, 235);
            txtCalComentario.Font = new Font("Segoe UI", 9F);
            txtCalComentario.Location = new Point(14, 70);
            txtCalComentario.Name = "txtCalComentario";
            txtCalComentario.PlaceholderText = "";
            txtCalComentario.ReadOnly = true;
            txtCalComentario.SelectedText = "";
            txtCalComentario.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtCalComentario.Size = new Size(372, 30);
            txtCalComentario.TabIndex = 3;
            // 
            // lblCalNotaLbl
            // 
            lblCalNotaLbl.AutoSize = false;
            lblCalNotaLbl.BackColor = Color.Transparent;
            lblCalNotaLbl.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCalNotaLbl.ForeColor = Color.FromArgb(130, 120, 100);
            lblCalNotaLbl.Location = new Point(14, 108);
            lblCalNotaLbl.Name = "lblCalNotaLbl";
            lblCalNotaLbl.Size = new Size(100, 14);
            lblCalNotaLbl.TabIndex = 4;
            lblCalNotaLbl.Text = "NOTA (0-100)";
            // 
            // txtCalificacion
            // 
            txtCalificacion.BorderRadius = 8;
            txtCalificacion.CustomizableEdges = customizableEdges13;
            txtCalificacion.DefaultText = "";
            txtCalificacion.FocusedState.BorderColor = Color.FromArgb(255, 183, 0);
            txtCalificacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtCalificacion.ForeColor = Color.FromArgb(20, 120, 60);
            txtCalificacion.Location = new Point(14, 124);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.PlaceholderText = "85";
            txtCalificacion.SelectedText = "";
            txtCalificacion.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtCalificacion.Size = new Size(100, 36);
            txtCalificacion.TabIndex = 5;
            // 
            // lblCalFeedbackLbl
            // 
            lblCalFeedbackLbl.AutoSize = false;
            lblCalFeedbackLbl.BackColor = Color.Transparent;
            lblCalFeedbackLbl.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCalFeedbackLbl.ForeColor = Color.FromArgb(130, 120, 100);
            lblCalFeedbackLbl.Location = new Point(14, 168);
            lblCalFeedbackLbl.Name = "lblCalFeedbackLbl";
            lblCalFeedbackLbl.Size = new Size(70, 14);
            lblCalFeedbackLbl.TabIndex = 6;
            lblCalFeedbackLbl.Text = "FEEDBACK";
            // 
            // txtFeedback
            // 
            txtFeedback.BorderRadius = 8;
            txtFeedback.CustomizableEdges = customizableEdges15;
            txtFeedback.DefaultText = "";
            txtFeedback.FocusedState.BorderColor = Color.FromArgb(255, 183, 0);
            txtFeedback.Font = new Font("Segoe UI", 9.5F);
            txtFeedback.Location = new Point(14, 184);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.PlaceholderText = "Comentario al estudiante...";
            txtFeedback.SelectedText = "";
            txtFeedback.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtFeedback.Size = new Size(372, 40);
            txtFeedback.TabIndex = 7;
            // 
            // btnCalificar
            // 
            btnCalificar.BackColor = Color.Transparent;
            btnCalificar.BorderRadius = 18;
            btnCalificar.Cursor = Cursors.Hand;
            btnCalificar.CustomizableEdges = customizableEdges17;
            btnCalificar.FillColor = Color.FromArgb(255, 183, 0);
            btnCalificar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnCalificar.ForeColor = Color.White;
            btnCalificar.HoverState.FillColor = Color.FromArgb(220, 155, 0);
            btnCalificar.Location = new Point(14, 232);
            btnCalificar.Name = "btnCalificar";
            btnCalificar.ShadowDecoration.Color = Color.FromArgb(40, 255, 183, 0);
            btnCalificar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnCalificar.ShadowDecoration.Depth = 5;
            btnCalificar.ShadowDecoration.Enabled = true;
            btnCalificar.Size = new Size(372, 38);
            btnCalificar.TabIndex = 8;
            btnCalificar.Text = "Guardar calificacion";
            btnCalificar.Click += btnCalificar_Click;
            // 
            // FrmMisTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 248, 240);
            ClientSize = new Size(854, 535);
            Controls.Add(panelHeader);
            Controls.Add(panelIzquierdo);
            Controls.Add(panelDerecho);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMisTareas";
            Text = "Mis Tareas";
            Load += FrmMisTareas_Load;
            panelHeader.ResumeLayout(false);
            panelIzquierdo.ResumeLayout(false);
            panelDerecho.ResumeLayout(false);
            cardDetalleInfo.ResumeLayout(false);
            panelListaEntregas.ResumeLayout(false);
            panelCalificar.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}