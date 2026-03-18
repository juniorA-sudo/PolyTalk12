using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmMisionEstudiante : Form
    {
        // Referencia al formulario principal
        private FrmPrincipal _principalForm;

        public FrmMisionEstudiante(FrmPrincipal principalForm)
        {
            InitializeComponent();
            _principalForm = principalForm;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // Usar el método público del formulario principal para abrir FrmLecciones
            _principalForm.AbrirFormEnPanel(new FrmLecciones());
        }
    }
}