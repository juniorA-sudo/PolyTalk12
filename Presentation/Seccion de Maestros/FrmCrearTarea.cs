using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Seccion_de_Maestros
{
    public partial class FrmCrearTarea : Form
    {
        private readonly TaskService taskService;
        private readonly int teacherId;

        public FrmCrearTarea(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            taskService = new TaskService();
        }

        private void FrmCrearTarea_Load(object sender, EventArgs e)
        {
            CargarGrupos();
            CargarUnidades();
            cmbTipoEntrega.Items.AddRange(new[] { "File", "Text", "Image", "Review" });
            cmbTipoEntrega.SelectedIndex = 0;
            dtpAsignacion.Value = DateTime.Today;
            dtpFechaEntrega.Value = DateTime.Today.AddDays(7);
            numMaxScore.Value = 100;
            chkShowGrade.Checked = true;
        }

        private void CargarGrupos()
        {
            DataTable dt = taskService.ObtenerGruposDelMaestro(teacherId);
            cmbGrupo.DataSource = dt;
            cmbGrupo.DisplayMember = "group_name";
            cmbGrupo.ValueMember = "group_id";
            if (dt.Rows.Count == 0)
                MessageBox.Show("No tienes grupos asignados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // En FrmCreaTarea.cs, modifica el método CargarUnidades

        private void CargarUnidades()
        {
            try
            {
                DataTable dt = taskService.ObtenerUnidades();

                if (dt == null || dt.Rows.Count == 0)
                {
                    // Crear opción por defecto
                    DataTable defaultDt = new DataTable();
                    defaultDt.Columns.Add("unit_id", typeof(int));
                    defaultDt.Columns.Add("unit_title", typeof(string));
                    defaultDt.Rows.Add(-1, "Selecciona una unidad");
                    cmbUnidad.DataSource = defaultDt;
                    cmbUnidad.DisplayMember = "unit_title";
                    cmbUnidad.ValueMember = "unit_id";
                    return;
                }

                // Verificar que la columna existe
                if (!dt.Columns.Contains("unit_title"))
                {
                    // Renombrar la columna si es necesario
                    if (dt.Columns.Contains("unit_name"))
                    {
                        dt.Columns["unit_name"].ColumnName = "unit_title";
                    }
                    else
                    {
                        // Crear columna unit_title si no existe
                        dt.Columns.Add("unit_title", typeof(string), "unit_name");
                    }
                }

                // Agregar opción "Sin unidad" al inicio
                DataRow defaultRow = dt.NewRow();
                defaultRow["unit_id"] = -1;
                defaultRow["unit_title"] = "--- Sin unidad ---";
                dt.Rows.InsertAt(defaultRow, 0);

                cmbUnidad.DataSource = dt;
                cmbUnidad.DisplayMember = "unit_title";
                cmbUnidad.ValueMember = "unit_id";
                cmbUnidad.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar unidades: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Crear DataTable de respaldo
                DataTable fallbackDt = new DataTable();
                fallbackDt.Columns.Add("unit_id", typeof(int));
                fallbackDt.Columns.Add("unit_title", typeof(string));
                fallbackDt.Rows.Add(-1, "--- Sin unidad ---");
                cmbUnidad.DataSource = fallbackDt;
                cmbUnidad.DisplayMember = "unit_title";
                cmbUnidad.ValueMember = "unit_id";
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MostrarError("Escribe un titulo para la tarea.");
                txtTitulo.Focus(); return;
            }
            if (cmbGrupo.SelectedValue == null)
            {
                MostrarError("Selecciona un grupo."); return;
            }
            if (dtpFechaEntrega.Value.Date <= dtpAsignacion.Value.Date)
            {
                MostrarError("La fecha de entrega debe ser posterior a la de asignacion."); return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MostrarError("Escribe una descripción para la tarea.");
                txtDescripcion.Focus();
                return;
            }
            if (numMaxScore.Value <= 0)
            {
                MostrarError("La puntuación máxima debe ser mayor a 0.");
                numMaxScore.Focus();
                return;
            }


            int groupId = Convert.ToInt32(cmbGrupo.SelectedValue);
            int? unitId = null;
            if (cmbUnidad.SelectedValue != null && cmbUnidad.SelectedValue != DBNull.Value &&
                int.TryParse(cmbUnidad.SelectedValue.ToString(), out int uid))
                unitId = uid;

            string status = chkDraft.Checked ? "Draft" : "Active";

            int taskId = taskService.CrearTarea(
                txtTitulo.Text.Trim(),
                txtDescripcion.Text.Trim(),
                teacherId, groupId, unitId,
                dtpAsignacion.Value, dtpFechaEntrega.Value,
                (int)numMaxScore.Value,
                cmbTipoEntrega.SelectedItem?.ToString() ?? "File",
                chkAllowLate.Checked, chkShowGrade.Checked, status);

            if (taskId > 0)
            {
                MessageBox.Show("Tarea creada correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void MostrarError(string msg) =>
            MessageBox.Show(msg, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}