using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Controls
{
    public partial class UCVocabularioCard : UserControl
    {
        private Color _colorFondo = Color.FromArgb(255, 140, 0);
        private int _totalPalabras = 0;
        private string _titulo = "";
        private string _icono = "📚";  // guardamos el emoji aquí

        // ── Propiedades ────────────────────────────────────────
        public string Titulo
        {
            get => _titulo;
            set { _titulo = value ?? ""; if (lblTitulo != null) lblTitulo.Text = _titulo; }
        }

        public int TotalPalabras
        {
            get => _totalPalabras;
            set
            {
                _totalPalabras = value;
                if (lblContador != null)
                    lblContador.Text = $"{value} {(value == 1 ? "palabra" : "palabras")}";
            }
        }

        /// <summary>
        /// El emoji se guarda en _icono y se pinta directamente en el panel
        /// usando el evento Paint — esto evita el problema de Label sobre Guna2Panel.
        /// </summary>
        public string IconoTexto
        {
            get => _icono;
            set
            {
                _icono = value ?? "📚";
                panelIconoBg?.Invalidate(); // fuerza repaint del emoji
            }
        }

        public bool EsFavorito
        {
            get => btnFavorito?.Text == "★";
            set
            {
                if (btnFavorito == null) return;
                btnFavorito.Text = value ? "★" : "☆";
                btnFavorito.ForeColor = value
                    ? Color.FromArgb(255, 183, 0)
                    : Color.FromArgb(200, 185, 150);
                if (lblTagFavoritas != null)
                    lblTagFavoritas.Text = value ? "⭐ 1" : "⭐ 0";
            }
        }

        public Color ColorFondo
        {
            get => _colorFondo;
            set
            {
                _colorFondo = value;
                if (panelIconoBg == null) return;
                int r = (value.R + 255 * 2) / 3;
                int g = (value.G + 255 * 2) / 3;
                int b = (value.B + 255 * 2) / 3;
                panelIconoBg.FillColor = Color.FromArgb(r, g, b);
                panelIconoBg.Invalidate();
            }
        }

        public event EventHandler CategoriaClick;
        public event EventHandler FavoritoClick;

        public UCVocabularioCard()
        {
            InitializeComponent();

            // ── Dibujar emoji directamente sobre el Guna2Panel ──
            // Esto soluciona el "?" que aparece cuando Label no hereda
            // transparencia de Guna2Panel con BorderRadius
            panelIconoBg.Paint += PanelIconoBg_Paint;

            // Clicks en toda la card
            panelCard.Click += (s, e) => CategoriaClick?.Invoke(this, e);
            lblTitulo.Click += (s, e) => CategoriaClick?.Invoke(this, e);
            lblContador.Click += (s, e) => CategoriaClick?.Invoke(this, e);
            panelIconoBg.Click += (s, e) => CategoriaClick?.Invoke(this, e);

            // Favorito
            btnFavorito.Click += (s, e) =>
            {
                EsFavorito = !EsFavorito;
                FavoritoClick?.Invoke(this, e);
            };

            // Hover
            panelCard.MouseEnter += (s, e) =>
            {
                panelCard.ShadowDecoration.Depth = 14;
                panelCard.BorderColor = Color.FromArgb(220, 210, 190);
            };
            panelCard.MouseLeave += (s, e) =>
            {
                panelCard.ShadowDecoration.Depth = 6;
                panelCard.BorderColor = Color.FromArgb(235, 225, 205);
            };
        }

        /// <summary>
        /// Dibuja el emoji centrado sobre el panelIconoBg usando Graphics.
        /// Este enfoque es 100% fiable — no depende de BackColor ni transparencia.
        /// </summary>
        private void PanelIconoBg_Paint(object sender, PaintEventArgs e)
        {
            if (string.IsNullOrEmpty(_icono)) return;

            Graphics g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            using var font = new Font("Segoe UI Emoji", 22F, FontStyle.Regular, GraphicsUnit.Point);
            SizeF sz = g.MeasureString(_icono, font);

            float x = (panelIconoBg.Width - sz.Width) / 2f;
            float y = (panelIconoBg.Height - sz.Height) / 2f;

            g.DrawString(_icono, font, Brushes.Black, x, y);
        }

        public void ActualizarProgreso(int favoritas, int pendientes)
        {
            if (lblTagFavoritas != null) lblTagFavoritas.Text = $"⭐ {favoritas}";
            if (lblTagPendientes != null) lblTagPendientes.Text = $"📝 {pendientes}";
        }
    }
}