using System;
using System.Windows.Forms;
using Presentation; // Para acceder a FrmGestionarVocabulario y FrmPrincipal

namespace Presentation.Controls
{
    public partial class UCLeccion : UserControl
    {
        public int LessonId { get; set; }
        public string LessonTitle { get; set; }
        public string LessonType { get; set; }

        public event EventHandler<int> LessonClicked;

        public UCLeccion()
        {
            InitializeComponent();
            this.Click += UCLeccion_Click;
            lblNombreLeccion.Click += UCLeccion_Click;
        }

        public void SetTitulo(string titulo)
        {
            LessonTitle = titulo;
            lblNombreLeccion.Text = titulo;
        }

        private void UCLeccion_Click(object sender, EventArgs e)
        {
            if (LessonType == "vocabulary")
            {
                AbrirVocabularioEnPanel();
            }
            else
            {
                LessonClicked?.Invoke(this, LessonId);
            }
        }

        private void AbrirVocabularioEnPanel()
        {
            try
            {
                // Buscar el formulario principal
                Form principal = this.FindForm();

                while (principal != null && !(principal is FrmPrincipal))
                {
                    principal = principal.ParentForm;
                }

                if (principal != null && principal is FrmPrincipal frmPrincipal)
                {
                    // Crear el formulario de vocabulario
                    FrmGestionarVocabulario frmVocab = new FrmGestionarVocabulario(LessonId, LessonTitle);

                    // Guardar referencia al principal para poder volver
                    frmVocab.FormPrincipal = frmPrincipal;

                    // Usar el método existente del FrmPrincipal
                    frmPrincipal.AbrirFormEnPanel(frmVocab);
                }
                else
                {
                    MessageBox.Show("No se encontró el formulario principal", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir vocabulario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}