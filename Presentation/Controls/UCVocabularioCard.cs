using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Controls
{
    public partial class UCVocabularioCard : UserControl
    {
        private Color colorFondo;

        // Propiedades públicas
        public string Titulo
        {
            get { return lblTitulo?.Text ?? ""; }
            set { if (lblTitulo != null) lblTitulo.Text = value; }
        }

        public int TotalPalabras
        {
            get
            {
                if (lblContador?.Text == null) return 0;
                try
                {
                    string[] partes = lblContador.Text.Split(' ');
                    if (partes.Length > 0 && int.TryParse(partes[0], out int total))
                        return total;
                    return 0;
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                if (lblContador != null)
                {
                    string texto = value == 1 ? "palabra" : "palabras";
                    int aprendidas = 0;
                    lblContador.Text = $"{value} {texto} · {aprendidas} aprendidas";
                }
            }
        }

        public string IconoTexto
        {
            get { return btnIcono?.Text ?? ""; }
            set { if (btnIcono != null) btnIcono.Text = value; }
        }

        public bool EsFavorito
        {
            get { return btnFavorito?.Text == "★"; }
            set
            {
                if (btnFavorito != null)
                {
                    btnFavorito.Text = value ? "★" : "☆";
                    if (lblTagFavoritas != null)
                        lblTagFavoritas.Text = value ? "⭐ 1" : "⭐ 0";
                }
            }
        }

        // 👈 Color de fondo (el que se elige en el formulario)
        public Color ColorFondo
        {
            get { return colorFondo; }
            set
            {
                colorFondo = value;
                if (panelCard != null)
                {
                    panelCard.FillColor = value;
                    // Ajustar color del texto según el fondo
                    if (EsColorOscuro(value))
                    {
                        lblTitulo.ForeColor = Color.White;
                        lblContador.ForeColor = Color.FromArgb(240, 240, 240);
                        btnIcono.ForeColor = Color.White;
                    }
                    else
                    {
                        lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
                        lblContador.ForeColor = Color.FromArgb(120, 120, 120);
                        btnIcono.ForeColor = Color.FromArgb(64, 64, 64);
                    }
                }
            }
        }

        // Eventos
        public event EventHandler CategoriaClick;
        public event EventHandler FavoritoClick;

        public UCVocabularioCard()
        {
            InitializeComponent();

            // Eventos de clic
            if (panelCard != null)
                panelCard.Click += (s, e) => CategoriaClick?.Invoke(this, e);

            if (lblTitulo != null)
                lblTitulo.Click += (s, e) => CategoriaClick?.Invoke(this, e);

            if (lblContador != null)
                lblContador.Click += (s, e) => CategoriaClick?.Invoke(this, e);

            if (btnIcono != null)
                btnIcono.Click += (s, e) => CategoriaClick?.Invoke(this, e);

            if (btnFavorito != null)
            {
                btnFavorito.Click += (s, e) =>
                {
                    EsFavorito = !EsFavorito;
                    FavoritoClick?.Invoke(this, e);
                };
            }

            // Efecto hover
            if (panelCard != null)
            {
                panelCard.MouseEnter += (s, e) =>
                {
                    if (panelCard.ShadowDecoration != null)
                        panelCard.ShadowDecoration.Depth = 12;
                };

                panelCard.MouseLeave += (s, e) =>
                {
                    if (panelCard.ShadowDecoration != null)
                        panelCard.ShadowDecoration.Depth = 8;
                };
            }
        }

        // Método auxiliar para determinar si un color es oscuro
        private bool EsColorOscuro(Color color)
        {
            double luminancia = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
            return luminancia < 0.5;
        }

        // Método para actualizar las etiquetas
        public void ActualizarProgreso(int favoritas, int pendientes)
        {
            if (lblTagFavoritas != null)
                lblTagFavoritas.Text = $"⭐ {favoritas}";

            if (lblTagPendientes != null)
                lblTagPendientes.Text = $"📝 {pendientes}";
        }
    }
}