using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class UCUnidadesEstudiante : UserControl
    {
        // =====================================================
        // PROPIEDADES PÚBLICAS
        // =====================================================
        public string TituloUnidad
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public int NumeroUnidad
        {
            get { return _numeroUnidad; }
            set
            {
                _numeroUnidad = value;
                lblNumero.Text = $"Unidad {value}";
            }
        }

        public int Progreso
        {
            get { return _progreso; }
            set
            {
                _progreso = value;
                ActualizarProgreso(value);
            }
        }

        public int UnidadId { get; set; }

        // =====================================================
        // CAMPOS PRIVADOS
        // =====================================================
        private int _numeroUnidad;
        private int _progreso;

        // =====================================================
        // EVENTO PERSONALIZADO (SOLO UNO)
        // =====================================================
        public event EventHandler UnidadClick;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================
        public UCUnidadesEstudiante()
        {
            InitializeComponent();

            // Conectar eventos - TODO el control es clickeable
            this.Click += UCUnidadesEstudiante_Click;

            // También conectar los labels internos
            if (lblTitulo != null)
                lblTitulo.Click += UCUnidadesEstudiante_Click;

            if (lblNumero != null)
                lblNumero.Click += UCUnidadesEstudiante_Click;

            if (lblProgreso != null)
                lblProgreso.Click += UCUnidadesEstudiante_Click;

            if (progressBar != null)
                progressBar.Click += UCUnidadesEstudiante_Click;
        }

        // =====================================================
        // MÉTODOS PRIVADOS
        // =====================================================
        private void ActualizarProgreso(int progreso)
        {
            progreso = Math.Max(0, Math.Min(100, progreso));

            if (progressBar != null)
            {
                progressBar.Value = progreso;
            }

            if (lblProgreso != null)
            {
                lblProgreso.Text = $"{progreso}% completado";
            }
        }

        // =====================================================
        // EVENTO CLICK
        // =====================================================
        private void UCUnidadesEstudiante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click dentro de UCUnidadesEstudiante");

            UnidadClick?.Invoke(this, EventArgs.Empty);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Mantener vacío
        }
    }
}