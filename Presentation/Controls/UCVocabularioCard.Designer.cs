using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Controls
{
    partial class UCVocabularioCard
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelCard;
        private Guna2Panel panelIconoBg;
        // btnIcono eliminado — emoji se dibuja con Paint en UCVocabularioCard.cs
        private Guna2HtmlLabel lblTitulo;
        private Guna2HtmlLabel lblContador;
        private Guna2Panel panelBadge;
        private Guna2HtmlLabel lblTagPendientes;
        private Guna2HtmlLabel lblTagFavoritas;
        private Guna2Button btnFavorito;
        private Guna2Panel separador;

        // compat legacy
        private FlowLayoutPanel panelTags;
        private Guna2Panel tagFavoritas;
        private Guna2Panel tagPendientes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelCard = new Guna2Panel();
            panelIconoBg = new Guna2Panel();
            lblTitulo = new Guna2HtmlLabel();
            lblContador = new Guna2HtmlLabel();
            separador = new Guna2Panel();
            panelBadge = new Guna2Panel();
            lblTagFavoritas = new Guna2HtmlLabel();
            lblTagPendientes = new Guna2HtmlLabel();
            btnFavorito = new Guna2Button();
            panelTags = new FlowLayoutPanel();
            tagFavoritas = new Guna2Panel();
            tagPendientes = new Guna2Panel();
            panelCard.SuspendLayout();
            panelBadge.SuspendLayout();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.Transparent;
            panelCard.BorderColor = Color.FromArgb(235, 225, 205);
            panelCard.BorderRadius = 18;
            panelCard.BorderThickness = 1;
            panelCard.Controls.Add(panelIconoBg);
            panelCard.Controls.Add(lblTitulo);
            panelCard.Controls.Add(lblContador);
            panelCard.Controls.Add(separador);
            panelCard.Controls.Add(panelBadge);
            panelCard.Controls.Add(btnFavorito);
            panelCard.Cursor = Cursors.Hand;
            panelCard.CustomizableEdges = customizableEdges9;
            panelCard.FillColor = Color.White;
            panelCard.Location = new Point(0, 0);
            panelCard.Name = "panelCard";
            panelCard.ShadowDecoration.Color = Color.FromArgb(20, 0, 0, 0);
            panelCard.ShadowDecoration.CustomizableEdges = customizableEdges10;
            panelCard.ShadowDecoration.Depth = 6;
            panelCard.ShadowDecoration.Enabled = true;
            panelCard.Size = new Size(220, 130);
            panelCard.TabIndex = 0;
            // 
            // panelIconoBg
            // 
            panelIconoBg.BackColor = Color.Transparent;
            panelIconoBg.BorderRadius = 24;
            panelIconoBg.CustomizableEdges = customizableEdges1;
            panelIconoBg.FillColor = Color.FromArgb(255, 240, 210);
            panelIconoBg.Location = new Point(12, 12);
            panelIconoBg.Name = "panelIconoBg";
            panelIconoBg.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelIconoBg.Size = new Size(48, 48);
            panelIconoBg.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(25, 25, 35);
            lblTitulo.Location = new Point(68, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 22);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Mi Lista";
            lblTitulo.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblContador
            // 
            lblContador.AutoSize = false;
            lblContador.BackColor = Color.Transparent;
            lblContador.Font = new Font("Segoe UI", 8.5F);
            lblContador.ForeColor = Color.FromArgb(160, 150, 130);
            lblContador.Location = new Point(68, 36);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(128, 18);
            lblContador.TabIndex = 2;
            lblContador.Text = "0 palabras";
            lblContador.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // separador
            // 
            separador.CustomizableEdges = customizableEdges3;
            separador.FillColor = Color.FromArgb(240, 232, 215);
            separador.Location = new Point(12, 68);
            separador.Name = "separador";
            separador.ShadowDecoration.CustomizableEdges = customizableEdges4;
            separador.Size = new Size(196, 1);
            separador.TabIndex = 3;
            // 
            // panelBadge
            // 
            panelBadge.BackColor = Color.Transparent;
            panelBadge.Controls.Add(lblTagFavoritas);
            panelBadge.Controls.Add(lblTagPendientes);
            panelBadge.CustomizableEdges = customizableEdges5;
            panelBadge.FillColor = Color.Transparent;
            panelBadge.Location = new Point(12, 78);
            panelBadge.Name = "panelBadge";
            panelBadge.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelBadge.Size = new Size(160, 34);
            panelBadge.TabIndex = 4;
            // 
            // lblTagFavoritas
            // 
            lblTagFavoritas.AutoSize = false;
            lblTagFavoritas.BackColor = Color.FromArgb(255, 240, 200);
            lblTagFavoritas.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagFavoritas.ForeColor = Color.FromArgb(160, 100, 0);
            lblTagFavoritas.Location = new Point(0, 0);
            lblTagFavoritas.Name = "lblTagFavoritas";
            lblTagFavoritas.Size = new Size(62, 22);
            lblTagFavoritas.TabIndex = 0;
            lblTagFavoritas.Text = "⭐ 0";
            lblTagFavoritas.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTagPendientes
            // 
            lblTagPendientes.AutoSize = false;
            lblTagPendientes.BackColor = Color.FromArgb(220, 240, 255);
            lblTagPendientes.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagPendientes.ForeColor = Color.FromArgb(30, 90, 180);
            lblTagPendientes.Location = new Point(68, 0);
            lblTagPendientes.Name = "lblTagPendientes";
            lblTagPendientes.Size = new Size(72, 22);
            lblTagPendientes.TabIndex = 1;
            lblTagPendientes.Text = "📝 0";
            lblTagPendientes.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnFavorito
            // 
            btnFavorito.BackColor = Color.Transparent;
            btnFavorito.BorderRadius = 14;
            btnFavorito.Cursor = Cursors.Hand;
            btnFavorito.CustomizableEdges = customizableEdges7;
            btnFavorito.FillColor = Color.FromArgb(255, 245, 220);
            btnFavorito.Font = new Font("Segoe UI", 13F);
            btnFavorito.ForeColor = Color.FromArgb(255, 183, 0);
            btnFavorito.HoverState.FillColor = Color.FromArgb(255, 235, 180);
            btnFavorito.Location = new Point(180, 78);
            btnFavorito.Name = "btnFavorito";
            btnFavorito.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnFavorito.Size = new Size(30, 30);
            btnFavorito.TabIndex = 5;
            btnFavorito.Text = "☆";
            // 
            // panelTags
            // 
            panelTags.Location = new Point(0, 0);
            panelTags.Name = "panelTags";
            panelTags.Size = new Size(1, 1);
            panelTags.TabIndex = 1;
            panelTags.Visible = false;
            // 
            // tagFavoritas
            // 
            tagFavoritas.CustomizableEdges = customizableEdges11;
            tagFavoritas.Location = new Point(0, 0);
            tagFavoritas.Name = "tagFavoritas";
            tagFavoritas.ShadowDecoration.CustomizableEdges = customizableEdges12;
            tagFavoritas.Size = new Size(1, 1);
            tagFavoritas.TabIndex = 2;
            tagFavoritas.Visible = false;
            // 
            // tagPendientes
            // 
            tagPendientes.CustomizableEdges = customizableEdges13;
            tagPendientes.Location = new Point(0, 0);
            tagPendientes.Name = "tagPendientes";
            tagPendientes.ShadowDecoration.CustomizableEdges = customizableEdges14;
            tagPendientes.Size = new Size(1, 1);
            tagPendientes.TabIndex = 3;
            tagPendientes.Visible = false;
            // 
            // UCVocabularioCard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            Controls.Add(panelCard);
            Controls.Add(panelTags);
            Controls.Add(tagFavoritas);
            Controls.Add(tagPendientes);
            Cursor = Cursors.Hand;
            Margin = new Padding(8);
            Name = "UCVocabularioCard";
            Size = new Size(220, 130);
            panelCard.ResumeLayout(false);
            panelBadge.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}