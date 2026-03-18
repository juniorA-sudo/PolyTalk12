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
    public partial class FrmStudiante : Form
    {
        public FrmStudiante()
        {
            InitializeComponent();
            if (panelGeneral != null)
            {
                FrmBienvenida frmbienvenida = new FrmBienvenida();
                AbrirFormularioEnPanel(frmbienvenida);
            }
        }
        private void btnMision_Click_1(object sender, EventArgs e)
        {
            FrmMisionEstudiante frmmision = new FrmMisionEstudiante();
            AbrirFormularioEnPanel(frmmision);
            panelGeneral.Dock = DockStyle.None;
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        { 
            FrmLeccionesEstudiantes frmlecciones = new FrmLeccionesEstudiantes();
            AbrirFormularioEnPanel(frmlecciones);
            panelGeneral.Dock = DockStyle.Right;
        }

        private void btnPractica_Click_1(object sender, EventArgs e)
        {
            FrmPractica frmpractica = new FrmPractica();
            AbrirFormularioEnPanel(frmpractica);
            panelGeneral.Dock = DockStyle.None;
        }

        private void btnVocabulario_Click(object sender, EventArgs e)
        {
            FrmVocabulario frmvocabulario = new FrmVocabulario();
            AbrirFormularioEnPanel(frmvocabulario);
            panelGeneral.Dock = DockStyle.None;
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {

        }

        private void btnTop_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // Limpiar el panel de controles anteriores
            panelGeneral.Controls.Clear();

            // CONFIGURACIÓN CRÍTICA QUE TE FALTA:
            formularioHijo.TopLevel = false; // Esto es esencial
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            formularioHijo.Dock = DockStyle.Fill; // Para que ocupe todo el panel

            // Agregar al panel
            panelGeneral.Controls.Add(formularioHijo);
            formularioHijo.Show();
        }
    }
}
