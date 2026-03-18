using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation
{
    public partial class FrmAsignarEstudiantes : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtGrupos;
        private int grupoId;
        private List<int> idsEstudiantesSeleccionados = new List<int>();

        public FrmAsignarEstudiantes()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarGrupos();
        }
        private void ConfigurarFormulario()
        {
            this.Text = "Asignar Estudiantes";
            this.Size = new Size(450, 499);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void CargarGrupos()
        {
            try
            {
                dtGrupos = db.ObtenerGruposConCupo();
                dgvGrupos.Rows.Clear();

                foreach (DataRow row in dtGrupos.Rows)
                {
                    int id = Convert.ToInt32(row["group_id"]);
                    string nombre = row["group_name"].ToString();
                    int cupo = Convert.ToInt32(row["CupoDisponible"]);
                    dgvGrupos.Rows.Add(id, nombre, cupo);
                }

                if (dgvGrupos.Rows.Count > 0)
                {
                    dgvGrupos.Rows[0].Selected = true;
                    ActualizarCupoDesdeFila(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar grupos: " + ex.Message);
            }
        }

        private void dgvGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ActualizarCupoDesdeFila(e.RowIndex);
            }
        }

        private void ActualizarCupoDesdeFila(int rowIndex)
        {
            DataGridViewRow row = dgvGrupos.Rows[rowIndex];
            grupoId = Convert.ToInt32(row.Cells["colId"].Value);
            int cupo = Convert.ToInt32(row.Cells["colCupo"].Value);
            lblCupoDisponible.Text = cupo.ToString();

            if (cupo <= 0)
                lblCupoDisponible.ForeColor = Color.Red;
            else if (cupo <= 3)
                lblCupoDisponible.ForeColor = Color.Orange;
            else
                lblCupoDisponible.ForeColor = Color.Green;
        }

        private void btnSeleccionarEstudiantes_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un grupo primero");
                return;
            }

            int cupo = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells["colCupo"].Value);
            int grupoId = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells["colId"].Value);

            FrmSeleccionarEstudiantes frmSeleccionar = new FrmSeleccionarEstudiantes(cupo, grupoId);
            frmSeleccionar.StartPosition = FormStartPosition.CenterParent;

            if (frmSeleccionar.ShowDialog() == DialogResult.OK)
            {
                idsEstudiantesSeleccionados = frmSeleccionar.Tag as List<int>;
                MostrarEstudiantesSeleccionados(idsEstudiantesSeleccionados);
            }
        }

        private void MostrarEstudiantesSeleccionados(List<int> ids)
        {
            lstEstudiantes.Items.Clear();

            if (ids == null || ids.Count == 0)
            {
                lstEstudiantes.Items.Add("No hay estudiantes seleccionados");
                return;
            }

            DataTable dtEstudiantes = db.ObtenerEstudiantesParaSeleccion(grupoId);

            int contador = 1;
            foreach (int id in ids)
            {
                DataRow[] rows = dtEstudiantes.Select($"student_id = {id}");
                if (rows.Length > 0)
                {
                    string nombre = rows[0]["Nombre"].ToString();
                    string nivel = rows[0]["Nivel"].ToString();
                    lstEstudiantes.Items.Add($"{contador}. {nombre} - Nivel {nivel}");
                    contador++;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un grupo");
                return;
            }

            if (idsEstudiantesSeleccionados == null || idsEstudiantesSeleccionados.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un estudiante");
                return;
            }

            int grupoId = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells["colId"].Value);
            string nombreGrupo = dgvGrupos.SelectedRows[0].Cells["colGrupo"].Value.ToString();
            int cupoDisponible = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells["colCupo"].Value);

            if (idsEstudiantesSeleccionados.Count > cupoDisponible)
            {
                MessageBox.Show($"No puedes asignar más de {cupoDisponible} estudiantes");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"¿Guardar {idsEstudiantesSeleccionados.Count} estudiantes en el grupo {nombreGrupo}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                bool exito = db.GuardarInscripciones(grupoId, idsEstudiantesSeleccionados);

                if (exito)
                {
                    MessageBox.Show("Asignación guardada correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}