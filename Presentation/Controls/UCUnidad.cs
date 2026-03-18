using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Presentation.Controls;
using Microsoft.Data.SqlClient;

namespace Presentation
{
    public partial class UCUnidad : UserControl
    {
        // =====================================================
        // PROPIEDADES
        //=====================================================

        private DatabaseHelper dbHelper;
        private int _unitId;
        private int _numeroUnidad;

        // Título de la unidad (ej: "Entertainment")
        public string TituloUnidad
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        // Número de unidad (ej: 1, 2, 3...)
        public int NumeroUnidad
        {
            get => _numeroUnidad;
            set
            {
                _numeroUnidad = value;
                lblNumeroUnidad.Text = $"Unidad {_numeroUnidad}";
            }
        }

        // ID de la unidad en la base de datos
        public int UnitId
        {
            get { return _unitId; }
            set
            {
                _unitId = value;
                CargarLecciones(); // Auto-cargar lecciones cuando se asigna el ID
            }
        }

        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public UCUnidad()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            ConfigurarFlowLayoutPanel();
        }

        // =====================================================
        // MÉTODOS PRIVADOS
        // =====================================================

        private void ActualizarLabelUnidad()
        {
            // Buscar el Label que debe mostrar "Unidad X"
            if (lblNumero != null)
            {
                lblNumero.Text = $"Unidad {_numeroUnidad}";
            }
            else
            {
                // Buscar cualquier Label que pueda contener "Unidad"
                foreach (Control control in this.Controls)
                {
                    if (control is Label label && (label.Text.Contains("Unidad") || label.Name.ToLower().Contains("unidad")))
                    {
                        label.Text = $"Unidad {_numeroUnidad}";
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Configura el FlowLayoutPanel para mostrar las lecciones correctamente
        /// </summary>
        private void ConfigurarFlowLayoutPanel()
        {
            if (flpLecciones != null)
            {
                flpLecciones.FlowDirection = FlowDirection.TopDown;
                flpLecciones.WrapContents = false;
                flpLecciones.AutoScroll = true;
            }
        }

        /// <summary>
        /// Carga las lecciones de esta unidad en el FlowLayoutPanel
        /// </summary>
        private void CargarLecciones()
        {
            try
            {
                flpLecciones.Controls.Clear();

                if (_unitId <= 0)
                {
                    MostrarMensajeSinLecciones("Unidad no configurada correctamente");
                    return;
                }

                DataTable dtLecciones = dbHelper.ObtenerLeccionesPorUnidad(_unitId);

                if (dtLecciones == null || dtLecciones.Rows.Count == 0)
                {
                    MostrarMensajeSinLecciones("No hay lecciones disponibles");
                    ActualizarContadorLecciones(0);
                    return;
                }

                foreach (DataRow row in dtLecciones.Rows)
                {
                    UCLeccion leccionControl = new UCLeccion();

                    leccionControl.LessonId = Convert.ToInt32(row["lesson_id"]);
                    leccionControl.SetTitulo(row["lesson_title"].ToString());

                    // ✅ NUEVO: Asignar el tipo de lección
                    leccionControl.LessonType = row["lesson_type"].ToString();

                    // Configurar apariencia según el tipo (opcional)
                    if (leccionControl.LessonType == "vocabulary")
                    {
                        // Podrías poner un icono diferente o color
                        // leccionControl.BackColor = Color.LightBlue;
                    }

                    leccionControl.Width = flpLecciones.Width - 20;
                    leccionControl.Height = 30;
                    leccionControl.Margin = new Padding(0);
                    leccionControl.Padding = new Padding(15, 0, 15, 0);

                    // Todavía mantenemos el evento por si acaso, pero ya no se usará para vocabulario
                    leccionControl.LessonClicked += (sender, lessonId) =>
                    {
                        string tituloLeccion = row["lesson_title"].ToString();
                        MessageBox.Show($"Abriendo lección normal: {tituloLeccion}", "Lección",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    };

                    flpLecciones.Controls.Add(leccionControl);
                }

                ActualizarContadorLecciones(dtLecciones.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar lecciones: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarMensajeSinLecciones("Error al cargar lecciones");
            }
        }

        /// <summary>
        /// Muestra un mensaje cuando no hay lecciones
        /// </summary>
        private void MostrarMensajeSinLecciones(string mensaje)
        {
            Label lblSinLecciones = new Label();
            lblSinLecciones.Text = $"    {mensaje}";
            lblSinLecciones.ForeColor = Color.Gray;
            lblSinLecciones.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblSinLecciones.AutoSize = false;
            lblSinLecciones.Width = flpLecciones.Width - 10;
            lblSinLecciones.Height = 30;
            lblSinLecciones.TextAlign = ContentAlignment.MiddleLeft;
            flpLecciones.Controls.Add(lblSinLecciones);
        }

        /// <summary>
        /// Actualiza el texto que muestra el número de lecciones
        /// </summary>
        private void ActualizarContadorLecciones(int total)
        {
            // Buscar el Label que muestra las lecciones
            foreach (Control control in this.Controls)
            {
                if (control is Label label && label.Name.ToLower().Contains("lecciones"))
                {
                    label.Text = $"{total} lecciones";
                    break;
                }
            }
        }

        // =====================================================
        // EVENTOS DE CONTROLES
        // =====================================================

        private void btnAgregarLeccion_Click(object sender, EventArgs e)
        {
            if (_unitId > 0)  // 1. Verifica que la unidad tenga un ID válido
            {
                // 2. Crea y configura el formulario
                FrmNuevaLeccion frmNuevaLeccion = new FrmNuevaLeccion();
                frmNuevaLeccion.UnitId = _unitId;              // Pasa el ID
                frmNuevaLeccion.UnitTitle = TituloUnidad;      // Pasa el título
                frmNuevaLeccion.StartPosition = FormStartPosition.CenterParent; // Centrado

                // 3. Muestra el formulario y espera respuesta
                if (frmNuevaLeccion.ShowDialog() == DialogResult.OK)
                {
                    // 4. Si el usuario guardó, recarga las lecciones
                    CargarLecciones();
                }
            }
            else
            {
                // 5. Si no hay UnitId, muestra error
                MessageBox.Show("Error: No se ha asignado el ID de la unidad", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flpLecciones_Paint(object sender, PaintEventArgs e) { }
    }
}