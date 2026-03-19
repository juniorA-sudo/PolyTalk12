using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Seccion_de_Estudiantes
{
    public partial class FrmTareasEstudiante : Form
    {
        private readonly TaskService taskService;
        private readonly int studentId;
        private int tareaSeleccionadaId = -1;
        private bool yaEntrego = false;

        public FrmTareasEstudiante(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            taskService = new TaskService();
        }

        private void FrmTareasEstudiante_Load(object sender, EventArgs e)
        {
            CargarTareas();
        }

        // =====================================================
        // CARGAR TAREAS
        // =====================================================
        private void CargarTareas()
        {
            try
            {
                DataTable dt = taskService.ObtenerTareasEstudiante(studentId);
                dgvTareas.DataSource = dt;

                foreach (DataGridViewColumn col in dgvTareas.Columns)
                    col.Visible = false;

                MostrarColumna("task_id", "ID", 40);
                MostrarColumna("title", "Tarea", 200);
                MostrarColumna("group_name", "Grupo", 110);
                MostrarColumna("teacher_name", "Maestro", 110);
                MostrarColumna("due_date", "Entrega", 90);
                MostrarColumna("days_remaining", "Días", 50);
                MostrarColumna("task_status", "Estado", 90);
                MostrarColumna("score", "Nota", 60);

                // Contadores
                int pendientes = 0, entregadas = 0, vencidas = 0, calificadas = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string status = row["task_status"].ToString();
                    if (status == "Pending") pendientes++;
                    else if (status == "Submitted") entregadas++;
                    else if (status == "Expired") vencidas++;
                    else if (status == "Graded") calificadas++;
                }

                lblPendientes.Text = $"⏳ {pendientes} pendientes";
                lblEntregadas.Text = $"✅ {entregadas} entregadas";
                lblVencidas.Text = $"❌ {vencidas} vencidas";
                lblCalificadas.Text = $"🏆 {calificadas} calificadas";
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

        // =====================================================
        // SELECCIONAR TAREA
        // =====================================================
        private void dgvTareas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0) return;

            var row = dgvTareas.SelectedRows[0];
            tareaSeleccionadaId = Convert.ToInt32(row.Cells["task_id"].Value);
            string status = row.Cells["task_status"].Value?.ToString();

            // Info de la tarea
            lblTituloTarea.Text = row.Cells["title"].Value?.ToString() ?? "";
            lblMaestroTarea.Text = $"👨‍🏫 {row.Cells["teacher_name"].Value}";
            lblFechaEntrega.Text = $"📅 Entrega: {Convert.ToDateTime(row.Cells["due_date"].Value):dd/MM/yyyy}";
            lblEstadoTarea.Text = status;

            // Colorear estado
            lblEstadoTarea.ForeColor = status switch
            {
                "Pending" => Color.FromArgb(237, 137, 54),
                "Submitted" => Color.FromArgb(66, 153, 225),
                "Graded" => Color.FromArgb(56, 161, 105),
                "Expired" => Color.FromArgb(197, 48, 48),
                _ => Color.Gray
            };

            // Panel de entrega
            yaEntrego = status == "Submitted" || status == "Graded";
            panelEntregar.Visible = status == "Pending";
            panelEntregado.Visible = yaEntrego;
            panelCalificacion.Visible = status == "Graded";

            if (yaEntrego)
            {
                string archivo = row.Cells["submitted_file"]?.Value?.ToString();
                string comentario = row.Cells["student_comment"]?.Value?.ToString();
                lblArchivoEntregado.Text = string.IsNullOrEmpty(archivo) ? "Sin archivo" : $"📄 {archivo}";
                lblComentarioEntregado.Text = string.IsNullOrEmpty(comentario) ? "Sin comentario" : comentario;
            }

            if (status == "Graded")
            {
                string nota = row.Cells["score"].Value?.ToString() ?? "-";
                string feedback = row.Cells["feedback"]?.Value?.ToString() ?? "Sin comentario del maestro";
                lblNota.Text = $"🏆 {nota} puntos";
                lblFeedback.Text = feedback;
            }
        }

        // =====================================================
        // ENTREGAR TAREA
        // =====================================================
        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (tareaSeleccionadaId == -1)
            {
                MessageBox.Show("Selecciona una tarea primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string comentario = txtComentario.Text.Trim();
            string nombreArchivo = txtNombreArchivo.Text.Trim();

            if (string.IsNullOrEmpty(comentario) && string.IsNullOrEmpty(nombreArchivo))
            {
                MessageBox.Show("Agrega un comentario o el nombre de tu archivo.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Confirmas la entrega de esta tarea?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (taskService.EntregarTarea(tareaSeleccionadaId, studentId, comentario, nombreArchivo))
                {
                    MessageBox.Show("✅ Tarea entregada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtComentario.Clear();
                    txtNombreArchivo.Clear();
                    CargarTareas();
                }
            }
        }

        private void dgvTareas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvTareas.Columns[e.ColumnIndex].Name == "task_status")
            {
                string status = e.Value?.ToString();
                e.CellStyle.ForeColor = status switch
                {
                    "Pending" => Color.FromArgb(237, 137, 54),
                    "Submitted" => Color.FromArgb(66, 153, 225),
                    "Graded" => Color.FromArgb(56, 161, 105),
                    "Expired" => Color.FromArgb(197, 48, 48),
                    _ => Color.Gray
                };
                e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                // Traducir al español
                e.Value = status switch
                {
                    "Pending" => "⏳ Pendiente",
                    "Submitted" => "📤 Entregada",
                    "Graded" => "🏆 Calificada",
                    "Expired" => "❌ Vencida",
                    _ => status
                };
                e.FormattingApplied = true;
            }

            if (dgvTareas.Columns[e.ColumnIndex].Name == "days_remaining")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int dias))
                {
                    e.Value = dias < 0 ? "Vencida" : $"{dias}d";
                    e.CellStyle.ForeColor = dias < 0 ? Color.Red :
                                           dias <= 2 ? Color.OrangeRed : Color.Black;
                    e.FormattingApplied = true;
                }
            }
        }
    }
}