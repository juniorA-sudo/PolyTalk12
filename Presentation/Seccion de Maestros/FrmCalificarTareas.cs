using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Presentation.Helpers;

namespace Presentation.Seccion_de_Maestros
{
    /// <summary>
    /// Formulario para que maestros califiquen las tareas entregadas por estudiantes
    /// Permite ver entregas pendientes, ingresar nota y feedback
    /// </summary>
    public partial class FrmCalificarTareas : Form
    {
        private TaskService taskService;
        private int teacherId;
        private DataTable dtTareas;
        private DataTable dtEntregas;
        private int tareaSeleccionadaId = -1;
        private int entregaSeleccionadaId = -1;

        public FrmCalificarTareas(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            taskService = new TaskService();
            this.DoubleBuffered = true;
            ConfigurarDataGridViews();
        }

        private void FrmCalificarTareas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarTareasMaestro();
                ActualizarEtiquetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Configura propiedades iniciales de DataGridViews</summary>
        private void ConfigurarDataGridViews()
        {
            // Tareas
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.ReadOnly = true;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.MultiSelect = false;
            dgvTareas.RowHeadersVisible = false;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Entregas
            dgvEntregas.AllowUserToAddRows = false;
            dgvEntregas.ReadOnly = true;
            dgvEntregas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntregas.MultiSelect = false;
            dgvEntregas.RowHeadersVisible = false;
            dgvEntregas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>Carga las tareas del maestro</summary>
        private void CargarTareasMaestro()
        {
            try
            {
                dtTareas = taskService.ObtenerTareasMaestro(teacherId);
                dgvTareas.Rows.Clear();

                if (dtTareas == null || dtTareas.Rows.Count == 0)
                {
                    MostrarMensaje("No tienes tareas asignadas.", Color.Gray);
                    return;
                }

                foreach (DataRow row in dtTareas.Rows)
                {
                    int taskId = Convert.ToInt32(row["task_id"]);
                    string titulo = row["title"].ToString();
                    string grupo = row["group_name"].ToString();
                    DateTime dueDate = Convert.ToDateTime(row["due_date"]);
                    int totalStudents = Convert.ToInt32(row["total_students"]);
                    int totalSubmissions = Convert.ToInt32(row["total_submissions"]);
                    int diasRestantes = Convert.ToInt32(row["days_remaining"]);

                    // Calcular entregas pendientes de calificar
                    int pendientes = totalSubmissions; // Asumiendo que aún no están calificadas todas

                    string estado = diasRestantes < 0 ? "❌ Vencida" : (diasRestantes == 0 ? "⚠️ HOY" : "⏳ Activa");

                    dgvTareas.Rows.Add(
                        taskId,
                        titulo,
                        grupo,
                        dueDate.ToString("dd/MM/yyyy"),
                        $"{totalSubmissions}/{totalStudents}",
                        pendientes,
                        estado
                    );
                }

                this.Text = $"Calificar Tareas ({dgvTareas.Rows.Count} tareas)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Evento cuando selecciona una tarea - carga sus entregas</summary>
        private void dgvTareas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTareas.SelectedRows.Count == 0) return;

                tareaSeleccionadaId = Convert.ToInt32(dgvTareas.SelectedRows[0].Cells[0].Value);
                CargarEntregasDeTarea(tareaSeleccionadaId);
                LimpiarFormularioCalificacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Carga las entregas de una tarea específica</summary>
        private void CargarEntregasDeTarea(int taskId)
        {
            try
            {
                dtEntregas = taskService.ObtenerEntregasDeTarea(taskId);
                dgvEntregas.Rows.Clear();

                if (dtEntregas == null || dtEntregas.Rows.Count == 0)
                {
                    MostrarMensaje("No hay entregas para esta tarea.", Color.Gray);
                    return;
                }

                foreach (DataRow row in dtEntregas.Rows)
                {
                    int submissionId = Convert.ToInt32(row["submission_id"]);
                    string studentName = row["student_name"].ToString();
                    DateTime submittedAt = Convert.ToDateTime(row["submitted_at"]);
                    bool isLate = Convert.ToBoolean(row["is_late"]);
                    string status = row["status"].ToString();
                    object score = row["score"];
                    string feedback = row["feedback"]?.ToString() ?? "";

                    string statusDisplay = status switch
                    {
                        "Submitted" => "⏳ Pendiente calificar",
                        "Graded" => "✅ Calificada",
                        _ => status
                    };

                    string lateDisplay = isLate ? "🔴 Atrasada" : "✅ A tiempo";
                    string scoreDisplay = score == DBNull.Value ? "—" : score.ToString();

                    dgvEntregas.Rows.Add(
                        submissionId,
                        studentName,
                        submittedAt.ToString("dd/MM/yyyy HH:mm"),
                        lateDisplay,
                        statusDisplay,
                        scoreDisplay,
                        feedback.Length > 0 ? "Sí" : "No"
                    );
                }

                // Se actualiza el grid automáticamente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar entregas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Evento cuando selecciona una entrega - carga sus detalles</summary>
        private void dgvEntregas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvEntregas.SelectedRows.Count == 0) return;

                entregaSeleccionadaId = Convert.ToInt32(dgvEntregas.SelectedRows[0].Cells[0].Value);
                CargarDetallesEntrega(entregaSeleccionadaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Carga detalles de una entrega específica</summary>
        private void CargarDetallesEntrega(int submissionId)
        {
            try
            {
                DataRow row = null;
                foreach (DataRow r in dtEntregas.Rows)
                {
                    if (Convert.ToInt32(r["submission_id"]) == submissionId)
                    {
                        row = r;
                        break;
                    }
                }

                if (row == null) return;

                // Mostrar detalles
                lblEstudianteVal.Text = row["student_name"].ToString();
                txtComentario.Text = row["comment"]?.ToString() ?? "";

                // Cargar nota y feedback existentes si ya fue calificada
                object scoreObj = row["score"];
                if (scoreObj != DBNull.Value)
                {
                    nudNota.Value = Convert.ToDecimal(scoreObj);
                    txtFeedback.Text = row["feedback"]?.ToString() ?? "";
                }
                else
                {
                    nudNota.Value = 0;
                    txtFeedback.Text = "";
                }

                btnCalificar.Enabled = true;
                btnLimpiar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Valida la calificación antes de guardar</summary>
        private bool ValidarCalificacion()
        {
            if (tareaSeleccionadaId == -1)
            {
                FormValidator.MostrarError("Selecciona una tarea primero.");
                return false;
            }

            if (entregaSeleccionadaId == -1)
            {
                FormValidator.MostrarError("Selecciona una entrega para calificar.");
                return false;
            }

            if (nudNota.Value < 0 || nudNota.Value > 100)
            {
                FormValidator.MostrarError("La nota debe estar entre 0 y 100.");
                nudNota.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                FormValidator.MostrarError("Debes escribir un feedback/comentario para el estudiante.");
                txtFeedback.Focus();
                return false;
            }

            return true;
        }

        /// <summary>Guarda la calificación en la BD</summary>
        private void GuardarCalificacion()
        {
            try
            {
                decimal nota = nudNota.Value;
                string feedback = txtFeedback.Text.Trim();

                if (taskService.CalificarEntrega(entregaSeleccionadaId, nota, feedback))
                {
                    MessageBox.Show($"✅ Calificación guardada correctamente.\n\nEstudiante: {lblEstudianteVal.Text}\nNota: {nota}/100",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar entregas para reflejar cambios
                    CargarEntregasDeTarea(tareaSeleccionadaId);
                    LimpiarFormularioCalificacion();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la calificación. Intenta nuevamente.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Limpia el formulario de calificación</summary>
        private void LimpiarFormularioCalificacion()
        {
            lblEstudianteVal.Text = "—";
            txtComentario.Text = "";
            nudNota.Value = 0;
            txtFeedback.Text = "";
            entregaSeleccionadaId = -1;
            btnCalificar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        /// <summary>Muestra un mensaje en el panel de entregas</summary>
        private void MostrarMensaje(string mensaje, Color color)
        {
            dgvEntregas.Rows.Clear();
            var lbl = new Label
            {
                Text = mensaje,
                Font = new Font("Segoe UI", 11),
                ForeColor = color,
                AutoSize = true,
                Margin = new Padding(20)
            };
        }

        /// <summary>Actualiza etiquetas de información</summary>
        private void ActualizarEtiquetas()
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMMM, yyyy");
        }

        // ===== EVENTOS DE BOTONES =====

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (!ValidarCalificacion())
                return;

            if (FormValidator.MostrarConfirmacion($"¿Confirmas la calificación de {nudNota.Value}/100 para {lblEstudianteVal.Text}?"))
                GuardarCalificacion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioCalificacion();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarTareasMaestro();
            LimpiarFormularioCalificacion();
        }
    }
}
