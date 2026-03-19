using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Controls
{
    public partial class UCVocabularioCard : UserControl
    {
        private Color colorFondo;
        private int _totalPalabras = 0;
        private string _titulo = "";

        public string Titulo
        {
            get { return _titulo; }
            set
            {
                _titulo = value ?? "";
                if (lblTitulo != null)
                {
                    lblTitulo.Text = _titulo;
                    lblTitulo.ForeColor = Color.White; // ✅ Siempre blanco
                }
            }
        }

        public int TotalPalabras
        {
            get { return _totalPalabras; }
            set
            {
                _totalPalabras = value;
                if (lblContador != null)
                {
                    string palabraTexto = value == 1 ? "palabra" : "palabras";
                    lblContador.Text = $"{value} {palabraTexto} · 0 aprendidas";
                    lblContador.ForeColor = Color.White; // ✅ Siempre blanco
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

        public Color ColorFondo
        {
            get { return colorFondo; }
            set
            {
                colorFondo = value;
                if (panelCard != null)
                {
                    panelCard.FillColor = value;

                    // ✅ Forzar blanco en todos los textos al asignar el color
                    if (lblTitulo != null) lblTitulo.ForeColor = Color.White;
                    if (lblContador != null) lblContador.ForeColor = Color.White;
                    if (btnIcono != null) btnIcono.ForeColor = Color.White;
                }
            }
        }

        public event EventHandler CategoriaClick;
        public event EventHandler FavoritoClick;

        public UCVocabularioCard()
        {
            InitializeComponent();

            // ✅ Forzar blanco desde el inicio
            if (lblTitulo != null) lblTitulo.ForeColor = Color.White;
            if (lblContador != null) lblContador.ForeColor = Color.White;
            if (btnIcono != null) btnIcono.ForeColor = Color.White;

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

        public void ActualizarProgreso(int favoritas, int pendientes)
        {
            if (lblTagFavoritas != null)
                lblTagFavoritas.Text = $"⭐ {favoritas}";
            if (lblTagPendientes != null)
                lblTagPendientes.Text = $"📝 {pendientes}";
        }
    }
}