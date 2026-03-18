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
    public partial class FormPrincipalMaestros : Form
    {
        public FormPrincipalMaestros()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLecciones());
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            panelContenedor.BringToFront();
            childForm.Show();
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmEstudiantesMaestros());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmComunidadMaestros());
        }
    }
}
