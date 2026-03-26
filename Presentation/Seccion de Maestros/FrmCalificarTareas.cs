using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Presentation.Helpers;

namespace Presentation.Seccion_de_Maestros
{
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
            ConfigurarControles();
        }

        private void FrmCalificarTareas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarTareasMaestro();
                ActualizarFecha();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarControles()
        {
            flpTareas.AutoScroll = true;
            flpTareas.FlowDirection = FlowDirection.TopDown;
            flpTareas.WrapContents = false;
            flpTareas.BackColor = Color.Transparent;

            flpEntregas.AutoScroll = true;
            flpEntregas.FlowDirection = FlowDirection.TopDown;
            flpEntregas.WrapContents = false;
            flpEntregas.BackColor = Color.Transparent;

            // Configurar el NumericUpDown
            nudNota.Maximum = 100;
            nudNota.Minimum = 0;
            nudNota.BackColor = Color.White;
        }

        private void ActualizarFecha()
        {
            lblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", new System.Globalization.CultureInfo("es-ES"));
        }

        private void CargarTareasMaestro()
        {
            try
            {
                dtTareas = taskService.ObtenerTareasMaestro(teacherId);
                flpTareas.Controls.Clear();

                if (dtTareas == null || dtTareas.Rows.Count == 0)
                {
                    MostrarMensajeSinTareas();
                    this.Text = "📝 Calificar Tareas (0 tareas)";
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

                    var tarjeta = CrearTarjetaTarea(taskId, titulo, grupo, dueDate,
                        totalSubmissions, totalStudents, diasRestantes);
                    flpTareas.Controls.Add(tarjeta);
                    contador++;
                }

                this.Text = $"📝 Calificar Tareas ({contador} tareas)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarMensajeSinTareas()
        {
            var lblMensaje = new Label
            {
                Text = "📭 No tienes tareas asignadas\n\nLas tareas aparecerán aquí cuando las crees.",
                ForeColor = Color.FromArgb(130, 120, 100),
                Font = new Font("Segoe UI", 11F),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(20)
            };
            flpTareas.Controls.Add(lblMensaje);
        }

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
                    var lblMensaje = new Label
                    {
                        Text = "📭 No hay entregas para esta tarea.\n\nLos estudiantes aún no han entregado.",
                        ForeColor = Color.FromArgb(130, 120, 100),
                        Font = new Font("Segoe UI", 11F),
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Margin = new Padding(20)
                    };
                    flpEntregas.Controls.Add(lblMensaje);
                    return;
                }

                foreach (DataRow row in dtEntregas.Rows)
                {
                    int submissionId = Convert.ToInt32(row["submission_id"]);
                    string studentName = row["student_name"].ToString();
                    DateTime submittedAt = Convert.ToDateTime(row["submitted_at"]);
                    bool isLate = row["is_late"] != DBNull.Value && Convert.ToBoolean(row["is_late"]);
                    string status = row["status"].ToString();
                    object score = row["score"];
                    string feedback = row["feedback"]?.ToString() ?? "";

                    var tarjeta = CrearTarjetaEntrega(submissionId, studentName, submittedAt,
                        isLate, status, score, feedback);
                    flpEntregas.Controls.Add(tarjeta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar entregas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDetallesEntrega(int submissionId)
        {
            try
            {
                entregaSeleccionadaId = submissionId;
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

                // Resaltar tarjeta seleccionada
                foreach (Control c in flpEntregas.Controls)
                {
                    if (c is Panel p)
                    {
                        p.BackColor = (p.Tag != null && Convert.ToInt32(p.Tag) == submissionId)
                            ? Color.FromArgb(255, 248, 235)
                            : Color.White;
                    }
                }

                lblEstudianteVal.Text = row["student_name"].ToString();
                txtComentario.Text = row["comment"]?.ToString() ?? "";

                if (row["score"] != DBNull.Value)
                {
                    nudNota.Value = Convert.ToDecimal(row["score"]);
                    txtFeedback.Text = row["feedback"]?.ToString() ?? "";
                    btnCalificar.Enabled = true;
                    btnLimpiar.Enabled = true;
                }
                else
                {
                    nudNota.Value = 0;
                    txtFeedback.Text = "";
                    btnCalificar.Enabled = true;
                    btnLimpiar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCalificacion()
        {
            if (tareaSeleccionadaId == -1)
            {
                MessageBox.Show("Selecciona una tarea primero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (entregaSeleccionadaId == -1)
            {
                MessageBox.Show("Selecciona una entrega para calificar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudNota.Value < 0 || nudNota.Value > 100)
            {
                MessageBox.Show("La nota debe estar entre 0 y 100.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudNota.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                MessageBox.Show("Debes escribir un feedback para el estudiante.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFeedback.Focus();
                return false;
            }

            return true;
        }

        private void GuardarCalificacion()
        {
            try
            {
                decimal nota = nudNota.Value;
                string feedback = txtFeedback.Text.Trim();

                if (taskService.CalificarEntrega(entregaSeleccionadaId, nota, feedback))
                {
                    MessageBox.Show($"✅ Calificación guardada correctamente.\n\n" +
                        $"Estudiante: {lblEstudianteVal.Text}\nNota: {nota}/100",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        // ===== CREACIÓN DE TARJETAS =====

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
                Tag = taskId
            };

            // Barra de acento izquierda
            var accentBar = new Panel
            {
                Width = 5,
                Height = panel.Height,
                BackColor = Color.FromArgb(249, 199, 79),
                Dock = DockStyle.Left
            };
            panel.Controls.Add(accentBar);

            // Título
            var lblTitulo = new Label
            {
                Text = titulo.Length > 45 ? titulo.Substring(0, 42) + "..." : titulo,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(15, 10),
                Size = new Size(ancho - 100, 20),
                AutoSize = false
            };
            panel.Controls.Add(lblTitulo);

            // Grupo
            var lblInfo = new Label
            {
                Text = $"👥 {grupo}",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(130, 120, 100),
                Location = new Point(15, 32),
                Size = new Size(ancho - 100, 18),
                AutoSize = false
            };
            panel.Controls.Add(lblInfo);

            // Entregas
            var lblEntregas = new Label
            {
                Text = $"📤 {entregas}/{totalEstudiantes} entregas",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(30, 80, 180),
                Location = new Point(15, 52),
                Size = new Size(ancho - 100, 18),
                AutoSize = false
            };
            panel.Controls.Add(lblEntregas);

            // Badge de días restantes
            Color badgeColor;
            string textoDias;
            if (diasRestantes < 0)
            {
                textoDias = "❌ Vencida";
                badgeColor = Color.FromArgb(180, 30, 30);
            }
            else if (diasRestantes == 0)
            {
                textoDias = "⚠️ Vence HOY";
                badgeColor = Color.FromArgb(210, 126, 30);
            }
            else if (diasRestantes <= 3)
            {
                textoDias = $"⏳ {diasRestantes} días";
                badgeColor = Color.FromArgb(210, 126, 30);
            }
            else
            {
                textoDias = $"📅 {diasRestantes} días";
                badgeColor = Color.FromArgb(34, 139, 34);
            }

            var pBadge = new Panel
            {
                Size = new Size(85, 26),
                Location = new Point(panel.Width - 100, 12),
                BackColor = Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.None
            };

            var lblDias = new Label
            {
                Text = textoDias,
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                ForeColor = badgeColor,
                Size = new Size(85, 26),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            pBadge.Controls.Add(lblDias);
            panel.Controls.Add(pBadge);

            // Evento Click
            panel.Click += (s, e) => CargarEntregasDeTarea(taskId);
            foreach (Control ctrl in panel.Controls)
                ctrl.Click += (s, e) => CargarEntregasDeTarea(taskId);

            // Hover effect
            panel.MouseEnter += (s, e) => panel.BackColor = Color.FromArgb(255, 248, 235);
            panel.MouseLeave += (s, e) => panel.BackColor = Color.White;

            return panel;
        }

        private Panel CrearTarjetaEntrega(int submissionId, string studentName, DateTime submittedAt,
                                          bool isLate, string status, object score, string feedback)
        {
            int ancho = flpEntregas.Width - 32;
            var panel = new Panel
            {
                Width = ancho > 200 ? ancho : 300,
                Height = 75,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 10),
                Cursor = Cursors.Hand,
                Tag = submissionId
            };

            // Determinar color de barra según estado
            Color accentColor = Color.FromArgb(249, 199, 79);
            if (status == "Graded")
                accentColor = Color.FromArgb(34, 139, 34);
            else if (isLate)
                accentColor = Color.FromArgb(180, 30, 30);

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
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(15, 8),
                Size = new Size(ancho - 100, 20),
                AutoSize = false
            };
            panel.Controls.Add(lblNombre);

            // Fecha de entrega
            var lblFecha = new Label
            {
                Text = submittedAt.ToString("dd/MM/yyyy HH:mm"),
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(130, 120, 100),
                Location = new Point(15, 30),
                Size = new Size(ancho - 100, 16),
                AutoSize = false
            };
            panel.Controls.Add(lblFecha);

            // Estado
            string textoEstado;
            Color colorEstado;
            if (status == "Graded" && score != DBNull.Value)
            {
                textoEstado = $"🏆 Calificada · {score}/100";
                colorEstado = Color.FromArgb(34, 139, 34);
            }
            else if (isLate)
            {
                textoEstado = "🔴 Entrega atrasada";
                colorEstado = Color.FromArgb(180, 30, 30);
            }
            else
            {
                textoEstado = "⏳ Pendiente calificar";
                colorEstado = Color.FromArgb(160, 90, 0);
            }

            var lblEstado = new Label
            {
                Text = textoEstado,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = colorEstado,
                Location = new Point(15, 48),
                Size = new Size(ancho - 100, 18),
                AutoSize = false
            };
            panel.Controls.Add(lblEstado);

            // Badge de calificada
            if (status == "Graded")
            {
                var pBadge = new Panel
                {
                    Size = new Size(70, 24),
                    Location = new Point(panel.Width - 85, 25),
                    BackColor = Color.FromArgb(225, 255, 235),
                    BorderStyle = BorderStyle.None
                };
                var lblBadge = new Label
                {
                    Text = "✓ Calificada",
                    Font = new Font("Segoe UI", 7F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(34, 139, 34),
                    Size = new Size(70, 24),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Transparent
                };
                pBadge.Controls.Add(lblBadge);
                panel.Controls.Add(pBadge);
            }

            // Evento Click
            panel.Click += (s, e) => CargarDetallesEntrega(submissionId);
            foreach (Control ctrl in panel.Controls)
                ctrl.Click += (s, e) => CargarDetallesEntrega(submissionId);

            // Hover effect
            panel.MouseEnter += (s, e) => panel.BackColor = Color.FromArgb(255, 248, 235);
            panel.MouseLeave += (s, e) => panel.BackColor = Color.White;

            return panel;
        }

        // ===== EVENTOS DE BOTONES =====

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (!ValidarCalificacion()) return;

            if (MessageBox.Show($"¿Confirmas la calificación de {nudNota.Value}/100 para {lblEstudianteVal.Text}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GuardarCalificacion();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioCalificacion();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarTareasMaestro();
            flpEntregas.Controls.Clear();
            LimpiarFormularioCalificacion();
            tareaSeleccionadaId = -1;
        }

        private void flpTareas_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
