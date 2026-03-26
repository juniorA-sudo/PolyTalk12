using System;
using System.Windows.Forms;
using Presentation.Seccion_de_Administrador;

namespace Presentation.Seccion_de_Administrador
{
    public partial class FrmGestionReportes : Form
    {
        public FrmGestionReportes()
        {
            InitializeComponent();
        }

        // Método para abrir formularios hijos dentro del panel
        private void AbrirFormEnPanel(Form formHijo)
        {
            panelReportes.Controls.Clear();          // Limpiar el panel
            formHijo.TopLevel = false;                // No es una ventana independiente
            formHijo.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            formHijo.Dock = DockStyle.Fill;           // Que ocupe todo el panel
            panelReportes.Controls.Add(formHijo);     // Agregar al panel
            formHijo.Show();                           // Mostrar
        }

        private void btnEstudiantesPorNivel_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteEstudiantesPorNivel());
        }

        private void btnUnidadesPorNivel_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteUnidadesPorNivel());
        }

        private void btnEstudiantesPorGrupo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteEstudiantesPorGrupo());
        }

        private void btnEstudiantesPorMaestro_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteEstudiantesPorMaestro());
        }

        private void btnMaestrosPorNivel_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteMaestrosPorNivel());
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteMaestros());
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteGrupos());
        }

        private void btnProgresoGrupo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteProgresoGrupo());
        }

        private void btnDesempenioTareas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReporteDesempenioTareas());
        }
    }
}