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
            ConfigurarFormulario();
            this.teacherId = teacherId;
            taskService = new TaskService();
        }

        private void FrmCrearTarea_Load(object sender, EventArgs e)
        {
            CargarGrupos();
            CargarUnidades();
            CargarTiposEntrega();

            dtpAsignacion.Value = DateTime.Today;
            dtpFechaEntrega.Value = DateTime.Today.AddDays(7);
            numMaxScore.Value = 100;
            chkAllowLate.Checked = false;
            chkShowGrade.Checked = true;
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Crear Nueva Tarea";
            this.Size = new Size(510, 520);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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

        private void CargarUnidades()
        {
            DataTable dt = taskService.ObtenerUnidades();
            DataRow fila = dt.NewRow();
            fila["unit_id"] = DBNull.Value;
            fila["unit_title"] = "-- Sin unidad --";
            fila["level_name"] = "";
            dt.Rows.InsertAt(fila, 0);

            cmbUnidad.DataSource = dt;
            cmbUnidad.DisplayMember = "unit_title";
            cmbUnidad.ValueMember = "unit_id";
            cmbUnidad.SelectedIndex = 0;
        }

        private void CargarTiposEntrega()
        {
            cmbTipoEntrega.Items.AddRange(new[] { "File", "Text", "Image", "Review" });
            cmbTipoEntrega.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Escribe un título para la tarea.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();
                return;
            }

            if (cmbGrupo.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un grupo.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpFechaEntrega.Value.Date <= dtpAsignacion.Value.Date)
            {
                MessageBox.Show("La fecha de entrega debe ser posterior a la de asignación.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int groupId = Convert.ToInt32(cmbGrupo.SelectedValue);

            int? unitId = null;
            if (cmbUnidad.SelectedValue != DBNull.Value && cmbUnidad.SelectedValue != null)
            {
                string val = cmbUnidad.SelectedValue.ToString();
                if (int.TryParse(val, out int uid))
                    unitId = uid;
            }

            string status = chkDraft.Checked ? "Draft" : "Active";

            int taskId = taskService.CrearTarea(
                txtTitulo.Text.Trim(),
                txtDescripcion.Text.Trim(),
                teacherId,
                groupId,
                unitId,
                dtpAsignacion.Value,
                dtpFechaEntrega.Value,
                (int)numMaxScore.Value,
                cmbTipoEntrega.SelectedItem.ToString(),
                chkAllowLate.Checked,
                chkShowGrade.Checked,
                status
            );

            if (taskId > 0)
            {
                MessageBox.Show("✅ Tarea creada correctamente.", "Éxito",
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
    }
}