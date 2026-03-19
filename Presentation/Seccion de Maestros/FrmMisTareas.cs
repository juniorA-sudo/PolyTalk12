using Presentation.Login__Register__Principal;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Seccion_de_Maestros
{
    public partial class FrmMisTareas : Form
    {
        private readonly TaskService taskService;
        private readonly int teacherId;
        private int tareaSeleccionadaId = -1;

        public FrmMisTareas(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            taskService = new TaskService();
        }

        private void FrmMisTareas_Load(object sender, EventArgs e)
        {
            CargarTareas();
        }

        private void CargarTareas()
        {
            try
            {
                DataTable dt = taskService.ObtenerTareasMaestro(teacherId);
                dgvTareas.DataSource = dt;
                lblTotalTareas.Text = $"{dt.Rows.Count} tareas";

                foreach (DataGridViewColumn col in dgvTareas.Columns)
                    col.Visible = false;

                MostrarColumna("task_id", "ID", 50);
                MostrarColumna("title", "Título", 200);
                MostrarColumna("group_name", "Grupo", 120);
                MostrarColumna("due_date", "Entrega", 100);
                MostrarColumna("total_submissions", "Entregas", 80);
                MostrarColumna("total_students", "Estudiantes", 90);
                MostrarColumna("computed_status", "Estado", 90);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarColumna(string nombre, string header, int width)
        {
            if (dgvTareas.Columns.Contains(nombre))
            {
                dgvTareas.Columns[nombre].Visible = true;
                dgvTareas.Columns[nombre].HeaderText = header;
                dgvTareas.Columns[nombre].Width = width;
            }
        }

        private void dgvTareas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0) return;

            var row = dgvTareas.SelectedRows[0];
            tareaSeleccionadaId = Convert.ToInt32(row.Cells["task_id"].Value);

            lblTituloTarea.Text = row.Cells["title"].Value?.ToString() ?? "";
            lblGrupoTarea.Text = $"Grupo: {row.Cells["group_name"].Value}";
            lblFechaTarea.Text = $"Entrega: {Convert.ToDateTime(row.Cells["due_date"].Value):dd/MM/yyyy}";

            CargarEntregas(tareaSeleccionadaId);
        }

        private void CargarEntregas(int taskId)
        {
            try
            {
                DataTable dt = taskService.ObtenerEntregasDeTarea(taskId);
                dgvEntregas.DataSource = dt;

                foreach (DataGridViewColumn col in dgvEntregas.Columns)
                    col.Visible = false;

                MostrarColumnaEntregas("submission_id", "ID", 40);
                MostrarColumnaEntregas("student_name", "Estudiante", 150);
                MostrarColumnaEntregas("submitted_at", "Entregó", 130);
                MostrarColumnaEntregas("file_name", "Archivo", 150);
                MostrarColumnaEntregas("is_late", "Tarde", 50);
                MostrarColumnaEntregas("score", "Nota", 60);
                MostrarColumnaEntregas("status", "Estado", 90);

                lblTotalEntregas.Text = $"{dt.Rows.Count} entregas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarColumnaEntregas(string nombre, string header, int width)
        {
            if (dgvEntregas.Columns.Contains(nombre))
            {
                dgvEntregas.Columns[nombre].Visible = true;
                dgvEntregas.Columns[nombre].HeaderText = header;
                dgvEntregas.Columns[nombre].Width = width;
            }
        }

        private void dgvEntregas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEntregas.SelectedRows.Count == 0) return;

            var row = dgvEntregas.SelectedRows[0];
            txtCalificacion.Text = row.Cells["score"].Value?.ToString() ?? "";
            txtFeedback.Text = row.Cells["feedback"]?.Value?.ToString() ?? "";
            lblEstudianteNombre.Text = row.Cells["student_name"].Value?.ToString() ?? "";

            string archivo = row.Cells["file_name"].Value?.ToString();
            lblArchivoEntregado.Text = string.IsNullOrEmpty(archivo)
                ? "Sin archivo" : $"📄 {archivo}";

            string comentario = row.Cells["comment"]?.Value?.ToString();
            txtComentarioEstudiante.Text = string.IsNullOrEmpty(comentario)
                ? "Sin comentario" : comentario;
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (dgvEntregas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una entrega para calificar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!decimal.TryParse(txtCalificacion.Text.Trim(), out decimal score))
            {
                MessageBox.Show("Ingresa una calificación válida (ej: 85.5)", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCalificacion.Focus();
                return;
            }

            var row = dgvEntregas.SelectedRows[0];
            int submissionId = Convert.ToInt32(row.Cells["submission_id"].Value);

            // ✅ Fix: usar índice de columna en lugar de Contains con string
            int maxScore = 100;
            if (dgvTareas.SelectedRows.Count > 0)
            {
                var tareaRow = dgvTareas.SelectedRows[0];
                if (dgvTareas.Columns["max_score"] != null &&
                    tareaRow.Cells["max_score"].Value != null &&
                    tareaRow.Cells["max_score"].Value != DBNull.Value)
                {
                    maxScore = Convert.ToInt32(tareaRow.Cells["max_score"].Value);
                }
            }

            if (score < 0 || score > maxScore)
            {
                MessageBox.Show($"La calificación debe estar entre 0 y {maxScore}.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (taskService.CalificarEntrega(submissionId, score, txtFeedback.Text.Trim()))
            {
                MessageBox.Show("✅ Calificación guardada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEntregas(tareaSeleccionadaId);
            }
        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmCrearTarea(teacherId))
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                    CargarTareas();
            }
        }

        private void dgvTareas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvTareas.Columns[e.ColumnIndex].Name == "computed_status")
            {
                string status = e.Value?.ToString();
                e.CellStyle.ForeColor = status switch
                {
                    "Active" => Color.FromArgb(56, 161, 105),
                    "Expired" => Color.FromArgb(197, 48, 48),
                    "Completed" => Color.FromArgb(44, 82, 130),
                    "Draft" => Color.FromArgb(113, 128, 150),
                    _ => Color.Black
                };
                e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                e.FormattingApplied = true;
            }

            if (dgvTareas.Columns[e.ColumnIndex].Name == "is_late" && e.Value != null)
            {
                e.Value = Convert.ToBoolean(e.Value) ? "⚠️ Sí" : "✅ No";
                e.FormattingApplied = true;
            }
        }
    }
}