using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Presentation.Controls;
using Presentation.Seccion_de_Maestros;      // ✅ FrmNuevaLeccion
using Microsoft.Data.SqlClient;

namespace Presentation
{
    public partial class UCUnidad : UserControl
    {
        private DatabaseHelper dbHelper;
        private int _unitId;
        private int _numeroUnidad;

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
                lblNumeroUnidad.Text = $"Unidad {_numeroUnidad}";
            }
        }

        public int UnitId
        {
            get => _unitId;
            set
            {
                _unitId = value;
                CargarLecciones();
            }
        }

        public UCUnidad()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            ConfigurarFlowLayoutPanel();
        }

        private void ActualizarLabelUnidad()
        {
            if (lblNumero != null)
            {
                lblNumero.Text = $"Unidad {_numeroUnidad}";
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Label label &&
                        (label.Text.Contains("Unidad") || label.Name.ToLower().Contains("unidad")))
                    {
                        label.Text = $"Unidad {_numeroUnidad}";
                        break;
                    }
                }
            }
        }

        private void ConfigurarFlowLayoutPanel()
        {
            if (flpLecciones != null)
            {
                flpLecciones.FlowDirection = FlowDirection.TopDown;
                flpLecciones.WrapContents = false;
                flpLecciones.AutoScroll = true;
            }
        }

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
                    var leccionControl = new UCLeccion();
                    leccionControl.LessonId = Convert.ToInt32(row["lesson_id"]);
                    leccionControl.SetTitulo(row["lesson_title"].ToString());
                    leccionControl.LessonType = row["lesson_type"].ToString();
                    leccionControl.Width = flpLecciones.Width - 20;
                    leccionControl.Height = 30;
                    leccionControl.Margin = new Padding(0);
                    leccionControl.Padding = new Padding(15, 0, 15, 0);

                    string titulo = row["lesson_title"].ToString();
                    leccionControl.LessonClicked += (sender, lessonId) =>
                        MessageBox.Show($"Abriendo lección: {titulo}", "Lección",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void MostrarMensajeSinLecciones(string mensaje)
        {
            var lbl = new Label
            {
                Text = $"    {mensaje}",
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                AutoSize = false,
                Width = flpLecciones.Width - 10,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft
            };
            flpLecciones.Controls.Add(lbl);
        }

        private void ActualizarContadorLecciones(int total)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label label && label.Name.ToLower().Contains("lecciones"))
                {
                    label.Text = $"{total} lecciones";
                    break;
                }
            }
        }

        private void flpLecciones_Paint(object sender, PaintEventArgs e) { }
    }
}