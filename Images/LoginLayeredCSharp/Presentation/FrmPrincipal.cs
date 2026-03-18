using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FontAwesome.Sharp;
using Presentation;

namespace ProyectoFInal
{
    public partial class FrmPrincipal : Form
    {

        // Botón principal
        Color colorFont = Color.FromArgb(51, 51, 51); // #0F0F0F 
        Color colorHover = Color.FromArgb(47, 116, 224);    // #2F74E0
        Color colorIconHover = Color.FromArgb(249, 199, 79); // #FFFFFF
        Color White = Color.FromArgb(255, 255, 255); // #FFFFFF 
        Color kk = Color.FromArgb(252, 247, 245); // #FFFFFF 

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            ButtonHover(btnUser, iconUser);
        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            ButtonLeave(btnUser, iconUser);
        }

        private void btnMaestros_MouseEnter(object sender, EventArgs e)
        {
            ButtonHover(btnMaestros, iconMaestros);
        }

        private void btnMaestros_MouseLeave(object sender, EventArgs e)
        {
            ButtonLeave(btnMaestros, iconMaestros);
        }

        private void btnCursos_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnCursos_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnReportes_MouseEnter(object sender, EventArgs e)
        {
            ButtonHover(btnReportes, iconReportes);
        }

        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            ButtonLeave(btnReportes, iconReportes);
        }

        private void btnConfiguracion_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnConfiguracion_MouseLeave(object sender, EventArgs e)
        {

        }


        private void ButtonHover(Guna2Button btn, IconPictureBox icon)
        {
            btn.FillColor = colorHover;
            btn.ForeColor = Color.White;

            icon.BackColor = colorHover;
            icon.IconColor = Color.White;
        }

        private void ButtonLeave(Guna2Button btn, IconPictureBox icon)
        {
            btn.FillColor = Color.Transparent;
            btn.ForeColor = colorFont;

            icon.BackColor = Color.Transparent;
            icon.IconColor = colorFont;
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmEstudiantesMaestros());
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
            OpenChildForm(new FrmMaestros());
        }
    }
}
