using Guna.UI2.WinForms;
using FontAwesome.Sharp;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Seccion_de_Estudiantes
{
    partial class FrmNuevaListaVocabulario
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private Guna2Panel panelHeader;
        private IconPictureBox iconHeader;
        private Guna2HtmlLabel lblTituloHeader;
        private Guna2HtmlLabel lblSubtituloHeader;
        private Guna2Panel panelSeparador;

        private Guna2Panel panelBody;

        private Guna2HtmlLabel lblNombre;
        private Guna2TextBox txtNombre;
        private Guna2HtmlLabel lblDescripcion;
        private Guna2TextBox txtDescripcion;
        private Guna2HtmlLabel lblColor;
        private FlowLayoutPanel flowLayoutPanelColores;
        private Guna2HtmlLabel lblIcono;
        private FlowLayoutPanel flowLayoutPanelIconos;
        private Guna2HtmlLabel lblVistaPrevia;
        private Guna2Panel panelPreview;

        // CAMBIO: Se renombra y cambia el tipo de Label a Button
        private Guna2Button btnPreviewIcon;

        private Guna2HtmlLabel lblPreviewTitle;
        private Guna2HtmlLabel lblPreviewCount;
        private FlowLayoutPanel panelPreviewTags;
        private Guna2Panel tagFavoritas;
        private Guna2HtmlLabel lblTagFavoritas;
        private Guna2Panel tagPendientes;
        private Guna2HtmlLabel lblTagPendientes;
        private Guna2Button btnCancelar;
        private Guna2Button btnCrear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelHeader = new Guna2Panel();
            iconHeader = new IconPictureBox();
            lblTituloHeader = new Guna2HtmlLabel();
            lblSubtituloHeader = new Guna2HtmlLabel();
            panelSeparador = new Guna2Panel();
            panelBody = new Guna2Panel();
            lblNombre = new Guna2HtmlLabel();
            txtNombre = new Guna2TextBox();
            lblDescripcion = new Guna2HtmlLabel();
            txtDescripcion = new Guna2TextBox();
            lblColor = new Guna2HtmlLabel();
            flowLayoutPanelColores = new FlowLayoutPanel();
            lblIcono = new Guna2HtmlLabel();
            flowLayoutPanelIconos = new FlowLayoutPanel();
            lblVistaPrevia = new Guna2HtmlLabel();
            panelPreview = new Guna2Panel();
            btnPreviewIcon = new Guna2Button();
            lblPreviewTitle = new Guna2HtmlLabel();
            lblPreviewCount = new Guna2HtmlLabel();
            panelPreviewTags = new FlowLayoutPanel();
            tagFavoritas = new Guna2Panel();
            lblTagFavoritas = new Guna2HtmlLabel();
            tagPendientes = new Guna2Panel();
            lblTagPendientes = new Guna2HtmlLabel();
            btnCancelar = new Guna2Button();
            btnCrear = new Guna2Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconHeader).BeginInit();
            panelBody.SuspendLayout();
            panelPreview.SuspendLayout();
            panelPreviewTags.SuspendLayout();
            tagFavoritas.SuspendLayout();
            tagPendientes.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(iconHeader);
            panelHeader.Controls.Add(lblTituloHeader);
            panelHeader.Controls.Add(lblSubtituloHeader);
            panelHeader.Controls.Add(panelSeparador);
            panelHeader.CustomizableEdges = customizableEdges3;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            panelHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelHeader.ShadowDecoration.Enabled = true;
            panelHeader.ShadowDecoration.Shadow = new Padding(0, 0, 0, 4);
            panelHeader.Size = new Size(480, 70);
            panelHeader.TabIndex = 0;
            // 
            // iconHeader
            // 
            iconHeader.BackColor = Color.Transparent;
            iconHeader.ForeColor = Color.FromArgb(102, 126, 234);
            iconHeader.IconChar = IconChar.CirclePlus;
            iconHeader.IconColor = Color.FromArgb(102, 126, 234);
            iconHeader.IconFont = IconFont.Auto;
            iconHeader.IconSize = 35;
            iconHeader.Location = new Point(20, 18);
            iconHeader.Name = "iconHeader";
            iconHeader.Size = new Size(35, 35);
            iconHeader.TabIndex = 0;
            iconHeader.TabStop = false;
            // 
            // lblTituloHeader
            // 
            lblTituloHeader.AutoSize = false;
            lblTituloHeader.BackColor = Color.Transparent;
            lblTituloHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloHeader.ForeColor = Color.FromArgb(45, 55, 72);
            lblTituloHeader.Location = new Point(65, 15);
            lblTituloHeader.Name = "lblTituloHeader";
            lblTituloHeader.Size = new Size(300, 25);
            lblTituloHeader.TabIndex = 1;
            lblTituloHeader.Text = "Crear Lista de Vocabulario";
            // 
            // lblSubtituloHeader
            // 
            lblSubtituloHeader.AutoSize = false;
            lblSubtituloHeader.BackColor = Color.Transparent;
            lblSubtituloHeader.Font = new Font("Segoe UI", 9F);
            lblSubtituloHeader.ForeColor = Color.FromArgb(113, 128, 150);
            lblSubtituloHeader.Location = new Point(65, 40);
            lblSubtituloHeader.Name = "lblSubtituloHeader";
            lblSubtituloHeader.Size = new Size(250, 20);
            lblSubtituloHeader.TabIndex = 2;
            lblSubtituloHeader.Text = "Organiza tus palabras por categorías";
            // 
            // panelSeparador
            // 
            panelSeparador.BackColor = Color.FromArgb(226, 232, 240);
            panelSeparador.CustomizableEdges = customizableEdges1;
            panelSeparador.Dock = DockStyle.Bottom;
            panelSeparador.Location = new Point(0, 69);
            panelSeparador.Name = "panelSeparador";
            panelSeparador.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelSeparador.Size = new Size(480, 1);
            panelSeparador.TabIndex = 3;
            // 
            // panelBody
            // 
            panelBody.AutoScroll = true;
            panelBody.BackColor = Color.White;
            panelBody.Controls.Add(lblNombre);
            panelBody.Controls.Add(txtNombre);
            panelBody.Controls.Add(lblDescripcion);
            panelBody.Controls.Add(txtDescripcion);
            panelBody.Controls.Add(lblColor);
            panelBody.Controls.Add(flowLayoutPanelColores);
            panelBody.Controls.Add(lblIcono);
            panelBody.Controls.Add(flowLayoutPanelIconos);
            panelBody.Controls.Add(lblVistaPrevia);
            panelBody.Controls.Add(panelPreview);
            panelBody.Controls.Add(btnCancelar);
            panelBody.Controls.Add(btnCrear);
            panelBody.CustomizableEdges = customizableEdges21;
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 70);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(20);
            panelBody.ShadowDecoration.CustomizableEdges = customizableEdges22;
            panelBody.Size = new Size(480, 610);
            panelBody.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = false;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(45, 55, 72);
            lblNombre.Location = new Point(20, 10);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(200, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "📝 Nombre de la lista";
            // 
            // txtNombre
            // 
            txtNombre.BorderRadius = 8;
            txtNombre.CustomizableEdges = customizableEdges5;
            txtNombre.DefaultText = "Ej: Animales";
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Location = new Point(20, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "";
            txtNombre.SelectedText = "";
            txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtNombre.Size = new Size(420, 40);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = false;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.FromArgb(45, 55, 72);
            lblDescripcion.Location = new Point(20, 85);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(200, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "📋 Descripción (opcional)";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderRadius = 8;
            txtDescripcion.CustomizableEdges = customizableEdges7;
            txtDescripcion.DefaultText = "Ej: Vocabulario básico de animales";
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = Color.Gray;
            txtDescripcion.Location = new Point(20, 110);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "";
            txtDescripcion.SelectedText = "";
            txtDescripcion.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtDescripcion.Size = new Size(420, 70);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.Enter += txtDescripcion_Enter;
            txtDescripcion.Leave += txtDescripcion_Leave;
            // 
            // lblColor
            // 
            lblColor.AutoSize = false;
            lblColor.BackColor = Color.Transparent;
            lblColor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblColor.ForeColor = Color.FromArgb(45, 55, 72);
            lblColor.Location = new Point(20, 190);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(200, 20);
            lblColor.TabIndex = 3;
            lblColor.Text = "🎨 Color de la lista";
            // 
            // flowLayoutPanelColores
            // 
            flowLayoutPanelColores.AutoScroll = true;
            flowLayoutPanelColores.Location = new Point(20, 215);
            flowLayoutPanelColores.Name = "flowLayoutPanelColores";
            flowLayoutPanelColores.Padding = new Padding(5);
            flowLayoutPanelColores.Size = new Size(420, 80);
            flowLayoutPanelColores.TabIndex = 3;
            // 
            // lblIcono
            // 
            lblIcono.AutoSize = false;
            lblIcono.BackColor = Color.Transparent;
            lblIcono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIcono.ForeColor = Color.FromArgb(45, 55, 72);
            lblIcono.Location = new Point(20, 305);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(200, 20);
            lblIcono.TabIndex = 4;
            lblIcono.Text = "✨ Icono de la lista";
            // 
            // flowLayoutPanelIconos
            // 
            flowLayoutPanelIconos.AutoScroll = true;
            flowLayoutPanelIconos.BackColor = Color.FromArgb(248, 250, 252);
            flowLayoutPanelIconos.Location = new Point(20, 330);
            flowLayoutPanelIconos.Name = "flowLayoutPanelIconos";
            flowLayoutPanelIconos.Padding = new Padding(5);
            flowLayoutPanelIconos.Size = new Size(420, 200);
            flowLayoutPanelIconos.TabIndex = 4;
            // 
            // lblVistaPrevia
            // 
            lblVistaPrevia.AutoSize = false;
            lblVistaPrevia.BackColor = Color.Transparent;
            lblVistaPrevia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVistaPrevia.ForeColor = Color.FromArgb(45, 55, 72);
            lblVistaPrevia.Location = new Point(20, 540);
            lblVistaPrevia.Name = "lblVistaPrevia";
            lblVistaPrevia.Size = new Size(200, 20);
            lblVistaPrevia.TabIndex = 5;
            lblVistaPrevia.Text = "👀 Vista previa";
            // 
            // panelPreview
            // 
            panelPreview.BackColor = Color.Transparent;
            panelPreview.BorderRadius = 15;
            panelPreview.Controls.Add(btnPreviewIcon);
            panelPreview.Controls.Add(lblPreviewTitle);
            panelPreview.Controls.Add(lblPreviewCount);
            panelPreview.Controls.Add(panelPreviewTags);
            panelPreview.CustomizableEdges = customizableEdges15;
            panelPreview.FillColor = Color.FromArgb(102, 126, 234);
            panelPreview.Location = new Point(20, 565);
            panelPreview.Name = "panelPreview";
            panelPreview.ShadowDecoration.CustomizableEdges = customizableEdges16;
            panelPreview.Size = new Size(420, 130);
            panelPreview.TabIndex = 5;
            // 
            // btnPreviewIcon
            // 
            btnPreviewIcon.BackColor = Color.Transparent;
            btnPreviewIcon.CustomizableEdges = customizableEdges9;
            btnPreviewIcon.FillColor = Color.Transparent;
            btnPreviewIcon.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPreviewIcon.ForeColor = Color.White;
            btnPreviewIcon.Location = new Point(9, 10);
            btnPreviewIcon.Name = "btnPreviewIcon";
            btnPreviewIcon.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnPreviewIcon.Size = new Size(64, 50);
            btnPreviewIcon.TabIndex = 0;
            btnPreviewIcon.Text = "🐕";
            // 
            // lblPreviewTitle
            // 
            lblPreviewTitle.AutoSize = false;
            lblPreviewTitle.BackColor = Color.Transparent;
            lblPreviewTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPreviewTitle.ForeColor = Color.White;
            lblPreviewTitle.Location = new Point(75, 15);
            lblPreviewTitle.Name = "lblPreviewTitle";
            lblPreviewTitle.Size = new Size(150, 25);
            lblPreviewTitle.TabIndex = 1;
            lblPreviewTitle.Text = "Animales";
            // 
            // lblPreviewCount
            // 
            lblPreviewCount.AutoSize = false;
            lblPreviewCount.BackColor = Color.Transparent;
            lblPreviewCount.Font = new Font("Segoe UI", 9F);
            lblPreviewCount.ForeColor = Color.FromArgb(240, 240, 255);
            lblPreviewCount.Location = new Point(75, 40);
            lblPreviewCount.Name = "lblPreviewCount";
            lblPreviewCount.Size = new Size(150, 20);
            lblPreviewCount.TabIndex = 2;
            lblPreviewCount.Text = "0 palabras · 0 aprendidas";
            // 
            // panelPreviewTags
            // 
            panelPreviewTags.Controls.Add(tagFavoritas);
            panelPreviewTags.Controls.Add(tagPendientes);
            panelPreviewTags.Location = new Point(15, 80);
            panelPreviewTags.Name = "panelPreviewTags";
            panelPreviewTags.Size = new Size(390, 35);
            panelPreviewTags.TabIndex = 6;
            // 
            // tagFavoritas
            // 
            tagFavoritas.BackColor = Color.Transparent;
            tagFavoritas.BorderRadius = 15;
            tagFavoritas.Controls.Add(lblTagFavoritas);
            tagFavoritas.CustomizableEdges = customizableEdges11;
            tagFavoritas.FillColor = Color.FromArgb(40, 40, 40);
            tagFavoritas.Location = new Point(0, 0);
            tagFavoritas.Margin = new Padding(0, 0, 10, 0);
            tagFavoritas.Name = "tagFavoritas";
            tagFavoritas.ShadowDecoration.CustomizableEdges = customizableEdges12;
            tagFavoritas.Size = new Size(100, 30);
            tagFavoritas.TabIndex = 0;
            // 
            // lblTagFavoritas
            // 
            lblTagFavoritas.AutoSize = false;
            lblTagFavoritas.BackColor = Color.Transparent;
            lblTagFavoritas.Font = new Font("Segoe UI", 9F);
            lblTagFavoritas.ForeColor = Color.White;
            lblTagFavoritas.Location = new Point(0, 0);
            lblTagFavoritas.Name = "lblTagFavoritas";
            lblTagFavoritas.Size = new Size(100, 30);
            lblTagFavoritas.TabIndex = 0;
            lblTagFavoritas.Text = "⭐ 0 favoritas";
            lblTagFavoritas.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tagPendientes
            // 
            tagPendientes.BackColor = Color.Transparent;
            tagPendientes.BorderRadius = 15;
            tagPendientes.Controls.Add(lblTagPendientes);
            tagPendientes.CustomizableEdges = customizableEdges13;
            tagPendientes.FillColor = Color.FromArgb(40, 40, 40);
            tagPendientes.Location = new Point(113, 3);
            tagPendientes.Name = "tagPendientes";
            tagPendientes.ShadowDecoration.CustomizableEdges = customizableEdges14;
            tagPendientes.Size = new Size(120, 30);
            tagPendientes.TabIndex = 1;
            // 
            // lblTagPendientes
            // 
            lblTagPendientes.AutoSize = false;
            lblTagPendientes.BackColor = Color.Transparent;
            lblTagPendientes.Font = new Font("Segoe UI", 9F);
            lblTagPendientes.ForeColor = Color.White;
            lblTagPendientes.Location = new Point(0, 0);
            lblTagPendientes.Name = "lblTagPendientes";
            lblTagPendientes.Size = new Size(120, 30);
            lblTagPendientes.TabIndex = 0;
            lblTagPendientes.Text = "📝 0 por aprender";
            lblTagPendientes.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BorderColor = Color.FromArgb(226, 232, 240);
            btnCancelar.BorderRadius = 8;
            btnCancelar.BorderThickness = 2;
            btnCancelar.CustomizableEdges = customizableEdges17;
            btnCancelar.FillColor = Color.White;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(74, 85, 104);
            btnCancelar.Location = new Point(20, 710);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnCancelar.Size = new Size(150, 45);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Transparent;
            btnCrear.BorderRadius = 8;
            btnCrear.CustomizableEdges = customizableEdges19;
            btnCrear.FillColor = Color.FromArgb(102, 126, 234);
            btnCrear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(290, 710);
            btnCrear.Name = "btnCrear";
            btnCrear.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnCrear.Size = new Size(150, 45);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear Lista";
            btnCrear.Click += btnCrear_Click;
            // 
            // FrmNuevaListaVocabulario
            // 
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(480, 680);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmNuevaListaVocabulario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva Lista de Vocabulario";
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconHeader).EndInit();
            panelBody.ResumeLayout(false);
            panelPreview.ResumeLayout(false);
            panelPreviewTags.ResumeLayout(false);
            tagFavoritas.ResumeLayout(false);
            tagPendientes.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}