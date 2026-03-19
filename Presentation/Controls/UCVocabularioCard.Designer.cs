using Guna.UI2.WinForms;

namespace Presentation.Controls
{
    partial class UCVocabularioCard
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private Guna2Panel panelCard;
        private Guna2HtmlLabel lblTitulo;
        private Guna2HtmlLabel lblContador;
        private Guna2Button btnFavorito;
        private FlowLayoutPanel panelTags;
        private Guna2Panel tagFavoritas;
        private Guna2HtmlLabel lblTagFavoritas;
        private Guna2Panel tagPendientes;
        private Guna2HtmlLabel lblTagPendientes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelCard = new Guna2Panel();
            btnIcono = new Guna2Button();
            tagPendientes = new Guna2Panel();
            lblTagPendientes = new Guna2HtmlLabel();
            lblTitulo = new Guna2HtmlLabel();
            lblContador = new Guna2HtmlLabel();
            panelTags = new FlowLayoutPanel();
            tagFavoritas = new Guna2Panel();
            lblTagFavoritas = new Guna2HtmlLabel();
            btnFavorito = new Guna2Button();
            panelCard.SuspendLayout();
            tagPendientes.SuspendLayout();
            panelTags.SuspendLayout();
            tagFavoritas.SuspendLayout();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.Transparent;
            panelCard.BorderColor = Color.White;
            panelCard.BorderRadius = 15;
            panelCard.BorderThickness = 5;
            panelCard.Controls.Add(btnIcono);
            panelCard.Controls.Add(tagPendientes);
            panelCard.Controls.Add(lblTitulo);
            panelCard.Controls.Add(lblContador);
            panelCard.Controls.Add(panelTags);
            panelCard.Controls.Add(btnFavorito);
            panelCard.Cursor = Cursors.Hand;
            panelCard.CustomizableEdges = customizableEdges9;
            panelCard.FillColor = Color.White;
            panelCard.ForeColor = Color.Transparent;
            panelCard.Location = new Point(0, 0);
            panelCard.Name = "panelCard";
            panelCard.ShadowDecoration.BorderRadius = 15;
            panelCard.ShadowDecoration.Color = Color.FromArgb(30, 0, 0, 0);
            panelCard.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelCard.ShadowDecoration.Depth = 5;
            panelCard.Size = new Size(220, 130);
            panelCard.TabIndex = 0;
            // 
            // btnIcono
            // 
            btnIcono.BackColor = Color.Transparent;
            btnIcono.CustomizableEdges = customizableEdges1;
            btnIcono.FillColor = Color.Transparent;
            btnIcono.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIcono.ForeColor = Color.White;
            btnIcono.Location = new Point(3, 8);
            btnIcono.Name = "btnIcono";
            btnIcono.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnIcono.Size = new Size(64, 50);
            btnIcono.TabIndex = 4;
            btnIcono.Text = "🐕";
            // 
            // tagPendientes
            // 
            tagPendientes.BackColor = Color.Transparent;
            tagPendientes.BorderRadius = 15;
            tagPendientes.Controls.Add(lblTagPendientes);
            tagPendientes.CustomizableEdges = customizableEdges3;
            tagPendientes.FillColor = Color.FromArgb(40, 40, 40);
            tagPendientes.Location = new Point(93, 85);
            tagPendientes.Name = "tagPendientes";
            tagPendientes.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tagPendientes.Size = new Size(65, 30);
            tagPendientes.TabIndex = 1;
            // 
            // lblTagPendientes
            // 
            lblTagPendientes.AutoSize = false;
            lblTagPendientes.BackColor = Color.Transparent;
            lblTagPendientes.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagPendientes.ForeColor = Color.White;
            lblTagPendientes.Location = new Point(-1, 0);
            lblTagPendientes.Name = "lblTagPendientes";
            lblTagPendientes.Size = new Size(65, 30);
            lblTagPendientes.TabIndex = 0;
            lblTagPendientes.Text = " 0";
            lblTagPendientes.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(70, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Animales";
            lblTitulo.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblContador
            // 
            lblContador.AutoSize = false;
            lblContador.BackColor = Color.Transparent;
            lblContador.Font = new Font("Segoe UI", 9F);
            lblContador.ForeColor = Color.White;
            lblContador.Location = new Point(70, 47);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(150, 18);
            lblContador.TabIndex = 2;
            lblContador.Text = "0 palabras · 0 aprendidas";
            lblContador.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // panelTags
            // 
            panelTags.BackColor = Color.Transparent;
            panelTags.Controls.Add(tagFavoritas);
            panelTags.Location = new Point(15, 85);
            panelTags.Name = "panelTags";
            panelTags.Size = new Size(150, 30);
            panelTags.TabIndex = 3;
            // 
            // tagFavoritas
            // 
            tagFavoritas.BackColor = Color.Transparent;
            tagFavoritas.BorderRadius = 15;
            tagFavoritas.Controls.Add(lblTagFavoritas);
            tagFavoritas.CustomizableEdges = customizableEdges5;
            tagFavoritas.FillColor = Color.FromArgb(40, 40, 40);
            tagFavoritas.Location = new Point(0, 0);
            tagFavoritas.Margin = new Padding(0, 0, 10, 0);
            tagFavoritas.Name = "tagFavoritas";
            tagFavoritas.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tagFavoritas.Size = new Size(65, 30);
            tagFavoritas.TabIndex = 0;
            // 
            // lblTagFavoritas
            // 
            lblTagFavoritas.AutoSize = false;
            lblTagFavoritas.BackColor = Color.Transparent;
            lblTagFavoritas.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagFavoritas.ForeColor = Color.White;
            lblTagFavoritas.Location = new Point(0, 0);
            lblTagFavoritas.Name = "lblTagFavoritas";
            lblTagFavoritas.Size = new Size(65, 30);
            lblTagFavoritas.TabIndex = 0;
            lblTagFavoritas.Text = "⭐ 0";
            lblTagFavoritas.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnFavorito
            // 
            btnFavorito.BackColor = Color.Transparent;
            btnFavorito.BorderRadius = 15;
            btnFavorito.Cursor = Cursors.Hand;
            btnFavorito.CustomizableEdges = customizableEdges7;
            btnFavorito.DisabledState.BorderColor = Color.DarkGray;
            btnFavorito.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFavorito.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFavorito.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFavorito.FillColor = Color.Transparent;
            btnFavorito.Font = new Font("Segoe UI", 14F);
            btnFavorito.ForeColor = Color.FromArgb(255, 215, 0);
            btnFavorito.HoverState.FillColor = Color.Transparent;
            btnFavorito.HoverState.ForeColor = Color.FromArgb(255, 235, 100);
            btnFavorito.Location = new Point(175, 85);
            btnFavorito.Name = "btnFavorito";
            btnFavorito.PressedColor = Color.Transparent;
            btnFavorito.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnFavorito.Size = new Size(30, 30);
            btnFavorito.TabIndex = 1;
            btnFavorito.Text = "☆";
            btnFavorito.TextOffset = new Point(0, -1);
            // 
            // UCVocabularioCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelCard);
            Margin = new Padding(8);
            Name = "UCVocabularioCard";
            Padding = new Padding(5);
            Size = new Size(220, 130);
            panelCard.ResumeLayout(false);
            tagPendientes.ResumeLayout(false);
            panelTags.ResumeLayout(false);
            tagFavoritas.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Guna2Button btnIcono;
    }
}