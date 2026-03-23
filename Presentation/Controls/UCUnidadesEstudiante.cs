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
            get => lblTitulo.Text;
            set => lblTitulo.Text = value;
        }

        public int NumeroUnidad
        {
            get => _numeroUnidad;
            set
            {
                _numeroUnidad = value;
                lblNumero.Text = $"UNIDAD {value}";
            }
        }

        public int Progreso
        {
            get => _progreso;
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
        // EVENTO PERSONALIZADO
        // =====================================================
        public event EventHandler UnidadClick;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================
        public UCUnidadesEstudiante()
        {
            InitializeComponent();

            // ✅ Hover effect
            guna2Panel1.MouseEnter += (s, e) =>
            {
                guna2Panel1.FillColor = Color.FromArgb(255, 249, 238);
                guna2Panel1.BorderColor = Color.FromArgb(255, 140, 0);
            };
            guna2Panel1.MouseLeave += (s, e) =>
            {
                guna2Panel1.FillColor = Color.White;
                guna2Panel1.BorderColor = Color.FromArgb(238, 228, 210);
            };

            // ✅ Click en todos los controles hijos
            Control[] clickables = { this, guna2Panel1, lblTitulo, lblNumero, lblProgreso, progressBar, accentBar };
            foreach (Control c in clickables)
                if (c != null) c.Click += UCUnidadesEstudiante_Click;
        }

        // =====================================================
        // ACTUALIZAR PROGRESO CON COLORES DINÁMICOS
        // =====================================================
        private void ActualizarProgreso(int progreso)
        {
            progreso = Math.Max(0, Math.Min(100, progreso));

            // Color según avance
            Color color = progreso >= 100 ? Color.FromArgb(34, 197, 94)  // ✅ verde = completo
                        : progreso >= 50 ? Color.FromArgb(255, 140, 0)  // 🟠 naranja = mitad
                        : Color.FromArgb(255, 183, 0); // 🟡 amarillo = inicio

            progressBar.Value = progreso;
            progressBar.ProgressColor = color;
            lblProgreso.ForeColor = color;
            lblProgreso.Text = progreso == 100 ? "✓ Completada"
                                      : progreso == 0 ? "Sin iniciar"
                                      : $"{progreso}% completado";

            // Barra de acento izquierda cambia de color también
            accentBar.FillColor = color;
        }

        // =====================================================
        // EVENTO CLICK
        // =====================================================
        private void UCUnidadesEstudiante_Click(object sender, EventArgs e)
        {
            UnidadClick?.Invoke(this, EventArgs.Empty);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
    }
}