using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class UCEstudiante : UserControl
    {
        // =====================================================
        // PROPIEDADES PÚBLICAS
        // =====================================================

        /// <summary>
        /// Nombre completo del estudiante (Ej: "Ana López")
        /// </summary>
        public string NombreEstudiante
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        /// <summary>
        /// Email del estudiante
        /// </summary>
        public string EmailEstudiante
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
        }

        /// <summary>
        /// Teléfono del estudiante
        /// </summary>
        public string TelefonoEstudiante
        {
            get { return lblTelefono.Text; }
            set { lblTelefono.Text = value; }
        }

        /// <summary>
        /// Fecha de ingreso del estudiante
        /// </summary>
        public string FechaIngreso
        {
            get { return lblFechaIngreso.Text; }
            set { lblFechaIngreso.Text = value; }
        }

        /// <summary>
        /// Grupo al que pertenece el estudiante
        /// </summary>
        public string GrupoEstudiante
        {
            get { return lblGrupo.Text; }
            set { lblGrupo.Text = value; }
        }

        /// <summary>
        /// Nivel del estudiante (A1, A2, B1, etc.)
        /// </summary>
        public string NivelEstudiante
        {
            get { return lblNivel.Text; }
            set
            {
                lblNivel.Text = value;
                // Opcional: cambiar color según nivel
                lblNivel.ForeColor = ObtenerColorNivel(value);
            }
        }

        /// <summary>
        /// Progreso en el nivel actual (0-100)
        /// </summary>
        public int Progreso
        {
            get { return _progreso; }
            set
            {
                _progreso = value;
                ActualizarProgreso(value);
            }
        }

        /// <summary>
        /// Porcentaje de asistencia
        /// </summary>
        public int Asistencia
        {
            get { return _asistencia; }
            set
            {
                _asistencia = value;
                lblAsistencia.Text = $"{value}%";
            }
        }

        /// <summary>
        /// Promedio de calificaciones
        /// </summary>
        public decimal Promedio
        {
            get { return _promedio; }
            set
            {
                _promedio = value;
                lblPromedio.Text = value.ToString("0.0");
            }
        }

        /// <summary>
        /// Total de tareas completadas
        /// </summary>
        public int TareasCompletadas
        {
            get { return _tareas; }
            set
            {
                _tareas = value;
                lblTareas.Text = value.ToString();
            }
        }

        // =====================================================
        // CAMPOS PRIVADOS
        // =====================================================
        private int _progreso;
        private int _asistencia;
        private decimal _promedio;
        private int _tareas;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================
        public UCEstudiante()  // 👈 CORREGIDO: debe coincidir con el nombre de la clase
        {
            InitializeComponent();
        }

        // =====================================================
        // MÉTODOS PRIVADOS
        // =====================================================
        private void ActualizarProgreso(int progreso)
        {
            progreso = Math.Max(0, Math.Min(100, progreso));

            if (progressBar != null)
                progressBar.Value = progreso;

            if (lblProgresoPorcentaje != null)
                lblProgresoPorcentaje.Text = $"{progreso}%";
        }

        // Método para cambiar color según nivel
        private Color ObtenerColorNivel(string nivel)
        {
            return nivel switch
            {
                "A1" => Color.FromArgb(79, 70, 229), // Morado
                "A2" => Color.FromArgb(16, 185, 129), // Verde
                "B1" => Color.FromArgb(245, 158, 11), // Naranja
                "B2" => Color.FromArgb(239, 68, 68), // Rojo
                "C1" => Color.FromArgb(139, 92, 246), // Púrpura
                "C2" => Color.FromArgb(59, 130, 246), // Azul
                _ => Color.Gray,
            };
        }
    }
}