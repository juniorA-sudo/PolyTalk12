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

        /// <summary>Configura propiedades iniciales de FlowLayoutPanels</summary>
        private void ConfigurarDataGridViews()
        {
            // Configurar FlowLayoutPanels
            flpTareas.AutoScroll = true;
            flpTareas.FlowDirection = FlowDirection.TopDown;
            flpTareas.WrapContents = false;

            flpEntregas.AutoScroll = true;
            flpEntregas.FlowDirection = FlowDirection.TopDown;
            flpEntregas.WrapContents = false;
        }

        /// <summary>Carga las tareas del maestro</summary>
        private void CargarTareasMaestro()
        {
            try
            {
                dtTareas = taskService.ObtenerTareasMaestro(teacherId);
                flpTareas.Controls.Clear();

                if (dtTareas == null || dtTareas.Rows.Count == 0)
                {
                    var lblSinTareas = new Label
                    {
                        Text = "No tienes tareas asignadas.",
                        ForeColor = Color.FromArgb(160, 160, 160),
                        Font = new Font("Segoe UI", 10F),
                        AutoSize = true,
                        Margin = new Padding(8)
                    };
                    flpTareas.Controls.Add(lblSinTareas);
                    this.Text = "Calificar Tareas (0 tareas)";
                    return;
                }

                int contador = 0;
                foreach (DataRow row in dtTareas.Rows)
                {
                    int taskId = Convert.ToInt32(row["task_id"]);
                    string titulo = row["title"].ToString();
                    string grupo = row["group_name"].ToString();
                    DateTime dueDate = Convert.ToDateTime(row["due_date"]);
                    int totalStudents = Convert.ToInt32(row["total_students"]);
                    int totalSubmissions = Convert.ToInt32(row["total_submissions"]);
                    int diasRestantes = Convert.ToInt32(row["days_remaining"]);

                    var tarjeta = CrearTarjetaTarea(taskId, titulo, grupo, dueDate, totalSubmissions, totalStudents, diasRestantes);
                    flpTareas.Controls.Add(tarjeta);
                    contador++;
                }

                this.Text = $"Calificar Tareas ({contador} tareas)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>Carga las entregas de una tarea específica</summary>
        private void CargarEntregasDeTarea(int taskId)
        {
            try
            {
                tareaSeleccionadaId = taskId;
                dtEntregas = taskService.ObtenerEntregasDeTarea(taskId);
                flpEntregas.Controls.Clear();
                LimpiarFormularioCalificacion();

                if (dtEntregas == null || dtEntregas.Rows.Count == 0)
                {
                    var lblSinEntregas = new Label
                    {
                        Text = "No hay entregas para esta tarea.",
                        ForeColor = Color.FromArgb(160, 160, 160),
                        Font = new Font("Segoe UI", 10F),
                        AutoSize = true,
                        Margin = new Padding(8)
                    };
                    flpEntregas.Controls.Add(lblSinEntregas);
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

                    var tarjeta = CrearTarjetaEntrega(submissionId, studentName, submittedAt, isLate, status, score, feedback);
                    flpEntregas.Controls.Add(tarjeta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar entregas: {ex.Message}", "Error",
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
                    MessageBox.Show($"✅ Calificación guardada correctamente.\n\nEstudiante: {lblEstudiante.Text}\nNota: {nota}/100",
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


        /// <summary>Actualiza etiquetas de información</summary>
        private void ActualizarEtiquetas()
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMMM, yyyy");
        }

        /// <summary>Crea una tarjeta visual para una tarea</summary>
        private Panel CrearTarjetaTarea(int taskId, string titulo, string grupo, DateTime dueDate,
                                        int entregas, int totalEstudiantes, int diasRestantes)
        {
            int ancho = flpTareas.Width - 32;
            var panel = new Panel
            {
                Width = ancho > 200 ? ancho : 300,
                Height = 85,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 10),
                Cursor = Cursors.Hand,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Barra de acento izquierda
            var accentBar = new Panel
            {
                Width = 5,
                Height = panel.Height,
                BackColor = Color.FromArgb(255, 183, 0),
                Dock = DockStyle.Left
            };
            panel.Controls.Add(accentBar);

            // Título
            var lblTitulo = new Label
            {
                Text = titulo.Length > 40 ? titulo.Substring(0, 37) + "..." : titulo,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 25, 35),
                Location = new Point(15, 10),
                MaximumSize = new Size(ancho - 30, 20),
                AutoSize = false,
                TextAlign = ContentAlignment.TopLeft
            };
            panel.Controls.Add(lblTitulo);

            // Información: Grupo y entregas
            var lblInfo = new Label
            {
                Text = $"👥 {grupo} · {entregas}/{totalEstudiantes} entregas",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(113, 128, 150),
                Location = new Point(15, 32),
                MaximumSize = new Size(ancho - 30, 18),
                AutoSize = false,
                TextAlign = ContentAlignment.TopLeft
            };
            panel.Controls.Add(lblInfo);

            // Vencimiento
            string textoVencimiento;
            Color colorVencimiento;
            if (diasRestantes < 0)
            {
                textoVencimiento = "❌ Vencida";
                colorVencimiento = Color.FromArgb(197, 48, 48);
            }
            else if (diasRestantes == 0)
            {
                textoVencimiento = "⚠️ Vence HOY";
                colorVencimiento = Color.FromArgb(210, 126, 30);
            }
            else if (diasRestantes <= 3)
            {
                textoVencimiento = $"⏳ {diasRestantes} día(s)";
                colorVencimiento = Color.FromArgb(210, 126, 30);
            }
            else
            {
                textoVencimiento = $"📅 {diasRestantes} días";
                colorVencimiento = Color.FromArgb(34, 197, 94);
            }

            var lblVencimiento = new Label
            {
                Text = textoVencimiento,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = colorVencimiento,
                Location = new Point(15, 54),
                MaximumSize = new Size(ancho - 30, 16),
                AutoSize = false,
                TextAlign = ContentAlignment.TopLeft
            };
            panel.Controls.Add(lblVencimiento);

            // Evento Click
            panel.Click += (s, e) => CargarEntregasDeTarea(taskId);
            foreach (Control ctrl in panel.Controls)
                ctrl.Click += (s, e) => CargarEntregasDeTarea(taskId);

            // Hover effects
            panel.MouseEnter += (s, e) =>
            {
                panel.BackColor = Color.FromArgb(249, 249, 251);
                panel.BorderStyle = BorderStyle.FixedSingle;
            };
            panel.MouseLeave += (s, e) =>
            {
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
            };

            return panel;
        }

        /// <summary>Crea una tarjeta visual para una entrega</summary>
        private Panel CrearTarjetaEntrega(int submissionId, string studentName, DateTime submittedAt,
                                          bool isLate, string status, object score, string feedback)
        {
            int ancho = flpEntregas.Width - 32;
            var panel = new Panel
            {
                Width = ancho > 200 ? ancho : 300,
                Height = 80,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 10),
                Cursor = Cursors.Hand,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Determinar color de barra de acento según estado
            Color accentColor = Color.FromArgb(255, 183, 0); // Amarillo (pendiente)
            if (status == "Graded")
                accentColor = Color.FromArgb(56, 161, 105); // Verde (calificada)
            else if (isLate)
                accentColor = Color.FromArgb(197, 48, 48); // Rojo (atrasada)

            // Barra de acento izquierda
            var accentBar = new Panel
            {
                Width = 5,
                Height = panel.Height,
                BackColor = accentColor,
                Dock = DockStyle.Left
            };
            panel.Controls.Add(accentBar);

            // Nombre del estudiante
            var lblNombre = new Label
            {
                Text = studentName.Length > 35 ? studentName.Substring(0, 32) + "..." : studentName,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 25, 35),
                Location = new Point(15, 10),
                MaximumSize = new Size(ancho - 30, 20),
                AutoSize = false,
                TextAlign = ContentAlignment.TopLeft
            };
            panel.Controls.Add(lblNombre);

            // Fecha de entrega
            var lblFecha = new Label
            {
                Text = submittedAt.ToString("📅 dd/MM/yyyy HH:mm"),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(113, 128, 150),
                Location = new Point(15, 32),
                MaximumSize = new Size(ancho - 30, 18),
                AutoSize = false,
                TextAlign = ContentAlignment.TopLeft
            };
            panel.Controls.Add(lblFecha);

            // Estado y nota
            string textoEstado;
            Color colorEstado;
            if (status == "Graded" && score != DBNull.Value)
            {
                textoEstado = $"✅ Calificada · {score}/100";
                colorEstado = Color.FromArgb(56, 161, 105);
            }
            else if (isLate)
            {
                textoEstado = "🔴 Atrasada";
                colorEstado = Color.FromArgb(197, 48, 48);
            }
            else
            {
                textoEstado = "⏳ Pendiente calificar";
                colorEstado = Color.FromArgb(160, 160, 160);
            }

            var lblEstado = new Label
            {
                Text = textoEstado,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = colorEstado,
                Location = new Point(15, 54),
                MaximumSize = new Size(ancho - 30, 16),
                AutoSize = false,
                TextAlign = ContentAlignment.TopLeft
            };
            panel.Controls.Add(lblEstado);

            // Evento Click
            panel.Click += (s, e) => CargarDetallesEntrega(submissionId);
            foreach (Control ctrl in panel.Controls)
                ctrl.Click += (s, e) => CargarDetallesEntrega(submissionId);

            // Hover effects
            panel.MouseEnter += (s, e) =>
            {
                panel.BackColor = Color.FromArgb(249, 249, 251);
                panel.BorderStyle = BorderStyle.FixedSingle;
            };
            panel.MouseLeave += (s, e) =>
            {
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
            };

            return panel;
        }

        // ===== EVENTOS DE BOTONES =====

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (!ValidarCalificacion())
                return;

            if (FormValidator.MostrarConfirmacion($"¿Confirmas la calificación de {nudNota.Value}/100 para {lblEstudiante.Text}?"))
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
