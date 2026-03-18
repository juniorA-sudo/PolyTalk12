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
    public partial class FrmVisualizarGrupo : Form
    {
        // Variables para guardar los datos
        private int grupoId;
        private string nombreGrupo;
        private string codigoGrupo;
        private string nivel;
        private string maestro;
        private int cupoTotal;
        private int inscritos;

        // Constructor vacío (el que ya tienes)
        public FrmVisualizarGrupo()
        {
            InitializeComponent();
        }


        // NUEVO: Constructor con 7 parámetros
        public FrmVisualizarGrupo(int id, string nombre, string codigo,
                                  string nivelGrupo, string nombreMaestro,
                                  int cupo, int inscritosActuales)
        {
            InitializeComponent();
            ConfigurarFormulario();

            // Guardar los datos
            grupoId = id;
            nombreGrupo = nombre;
            codigoGrupo = codigo;
            nivel = nivelGrupo;
            maestro = nombreMaestro;
            cupoTotal = cupo;
            inscritos = inscritosActuales;

            // Mostrar la información
            CargarInfoGrupo();
            CargarEstudiantes();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Visualizar Grupo";
            this.Size = new Size(694, 461);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void CargarInfoGrupo()
        {
            // Asumiendo que tienes estos labels (cámbialos por los nombres reales)
            lblNombreGrupo.Text = nombreGrupo;
            lblGrupo.Text = nombreGrupo;
            lblCodigo.Text = codigoGrupo;
            lblNivel.Text = nivel;
            lblMaestro.Text = maestro;
            lblCupo.Text = $"{inscritos}/{cupoTotal}";
        }

        private void CargarEstudiantes()
        {
            // Aquí cargas los estudiantes del grupo usando grupoId
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                DataTable dt = db.ObtenerEstudiantesPorGrupo(grupoId);
                dgvEstudiantes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estudiantes: " + ex.Message);
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar estudiante por nombre, email o nivel...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar estudiante por nombre, email o nivel...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower().Trim();

            // Si el texto es el placeholder, no filtrar
            if (busqueda == "buscar estudiante por nombre, email o nivel...")
                busqueda = "";

            // Aplicar filtro al DataGridView
            foreach (DataGridViewRow row in dgvEstudiantes.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible = false;

                // Buscar en las columnas de nombre y email
                if (row.Cells["Nombre"].Value != null)
                {
                    string nombre = row.Cells["Nombre"].Value.ToString().ToLower();
                    if (nombre.Contains(busqueda))
                        visible = true;
                }

                if (!visible && row.Cells["Email"].Value != null)
                {
                    string email = row.Cells["Email"].Value.ToString().ToLower();
                    if (email.Contains(busqueda))
                        visible = true;
                }

                // Mostrar u ocultar la fila
                row.Visible = visible || string.IsNullOrEmpty(busqueda);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
