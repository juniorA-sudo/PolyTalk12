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
        private DataTable dtTareas;
        private DataTable dtEntregas;

        public FrmMisTareas(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            taskService = new TaskService();
        }

        private void FrmMisTareas_Load(object sender, EventArgs e) => CargarTareas();

        // ── Cargar tareas ───────────────────────────────────────
        private void CargarTareas()
        {
            try
            {
                dtTareas = taskService.ObtenerTareasMaestro(teacherId);
                RenderizarTareas(dtTareas);
                lblTotalTareas.Text = $"{dtTareas.Rows.Count} tareas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderizarTareas(DataTable dt)
        {
            flpTareas.Controls.Clear();
            LimpiarPanelDerecho();

            if (dt == null || dt.Rows.Count == 0)
            {
                flpTareas.Controls.Add(new Label
                {
                    Text = "No hay tareas creadas. Crea una nueva.",
                    Font = new Font("Segoe UI", 11F),
                    ForeColor = Color.FromArgb(180, 160, 120),
                    AutoSize = false,
                    Size = new Size(flpTareas.Width - 20, 50),
                    TextAlign = ContentAlignment.MiddleCenter
                });
                return;
            }

            foreach (DataRow row in dt.Rows)
                flpTareas.Controls.Add(CrearCardTarea(row));
        }

        private Panel CrearCardTarea(DataRow row)
        {
            int taskId = Convert.ToInt32(row["task_id"]);
            string titulo = row["title"]?.ToString() ?? "";
            string grupo = row["group_name"]?.ToString() ?? "";
            string status = row["computed_status"]?.ToString() ?? "Active";
            int entregas = row.Table.Columns.Contains("total_submissions")
                             ? Convert.ToInt32(row["total_submissions"]) : 0;
            int total = row.Table.Columns.Contains("total_students")
                             ? Convert.ToInt32(row["total_students"]) : 0;
            DateTime due = row["due_date"] != DBNull.Value
                             ? Convert.ToDateTime(row["due_date"]) : DateTime.Today;

            (Color bg, Color accent, string statusTxt) = status switch
            {
                "Active" => (Color.FromArgb(255, 248, 235), Color.FromArgb(255, 183, 0), "Activa"),
                "Expired" => (Color.FromArgb(255, 240, 240), Color.FromArgb(197, 48, 48), "Vencida"),
                "Completed" => (Color.FromArgb(235, 248, 255), Color.FromArgb(66, 153, 225), "Completada"),
                _ => (Color.FromArgb(245, 245, 245), Color.FromArgb(160, 160, 160), "Borrador")
            };

            var card = new Panel
            {
                Size = new Size(flpTareas.Width - 24, 86),
                BackColor = bg,
                Cursor = Cursors.Hand,
                Tag = taskId,
                Margin = new Padding(0, 0, 0, 8)
            };

            var borde = new Panel { Size = new Size(5, 86), Location = new Point(0, 0), BackColor = accent };

            var lblTit = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 25, 35),
                Location = new Point(14, 10),
                Size = new Size(260, 20),
                BackColor = Color.Transparent
            };
            var lblGrp = new Label
            {
                Text = grupo,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(130, 120, 100),
                Location = new Point(14, 32),
                Size = new Size(200, 16),
                BackColor = Color.Transparent
            };
            var lblFecha = new Label
            {
                Text = $"Entrega: {due:dd/MM/yyyy}",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(150, 140, 120),
                Location = new Point(14, 52),
                Size = new Size(160, 16),
                BackColor = Color.Transparent
            };
            var lblEnt = new Label
            {
                Text = $"{entregas}/{total} entregas",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = accent,
                Location = new Point(14, 68),
                Size = new Size(120, 16),
                BackColor = Color.Transparent
            };
            var lblSt = new Label
            {
                Text = statusTxt,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = accent,
                BackColor = Color.FromArgb(30, accent.R, accent.G, accent.B),
                Location = new Point(card.Width - 105, 10),
                Size = new Size(90, 22),
                TextAlign = ContentAlignment.MiddleCenter
            };

            card.Controls.AddRange(new Control[] { borde, lblTit, lblGrp, lblFecha, lblEnt, lblSt });

            card.MouseEnter += (s, e) => card.BackColor = Color.FromArgb(
                Math.Max(0, bg.R - 10), Math.Max(0, bg.G - 10), Math.Max(0, bg.B - 10));
            card.MouseLeave += (s, e) => card.BackColor = bg;

            Action click = () => SeleccionarTarea(taskId);
            card.Click += (s, e) => click();
            foreach (Control c in card.Controls) c.Click += (s, e) => click();

            return card;
        }

        // ── Seleccionar tarea → cargar entregas ─────────────────
        private void SeleccionarTarea(int taskId)
        {
            tareaSeleccionadaId = taskId;
            DataRow row = null;
            foreach (DataRow r in dtTareas.Rows)
                if (Convert.ToInt32(r["task_id"]) == taskId) { row = r; break; }
            if (row == null) return;

            lblDetalleTitulo.Text = row["title"].ToString();
            lblDetalleGrupo.Text = row["group_name"].ToString();
            lblDetalleFecha.Text = $"Entrega: {Convert.ToDateTime(row["due_date"]):dd/MM/yyyy}";

            panelDerecho.Visible = true;
            CargarEntregas(taskId);
        }

        private void CargarEntregas(int taskId)
        {
            try
            {
                dtEntregas = taskService.ObtenerEntregasDeTarea(taskId);
                RenderizarEntregas(dtEntregas);
                lblTotalEntregas.Text = $"{dtEntregas.Rows.Count} entregas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderizarEntregas(DataTable dt)
        {
            flpEntregas.Controls.Clear();
            LimpiarCalificacion();

            if (dt == null || dt.Rows.Count == 0)
            {
                flpEntregas.Controls.Add(new Label
                {
                    Text = "Sin entregas aún.",
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = Color.FromArgb(180, 160, 120),
                    AutoSize = false,
                    Size = new Size(flpEntregas.Width - 16, 40),
                    TextAlign = ContentAlignment.MiddleCenter
                });
                return;
            }

            foreach (DataRow row in dt.Rows)
                flpEntregas.Controls.Add(CrearCardEntrega(row));
        }

        private Panel CrearCardEntrega(DataRow row)
        {
            int subId = Convert.ToInt32(row["submission_id"]);
            string nombre = row["student_name"]?.ToString() ?? "";
            string status = row["status"]?.ToString() ?? "Submitted";
            string archivo = row["file_name"]?.ToString() ?? "";
            bool tarde = row.Table.Columns.Contains("is_late") && row["is_late"] != DBNull.Value
                              && Convert.ToBoolean(row["is_late"]);
            string notaTxt = row["score"] != DBNull.Value ? row["score"].ToString() : "-";

            (Color bg, Color accent) = status switch
            {
                "Graded" => (Color.FromArgb(235, 252, 240), Color.FromArgb(56, 161, 105)),
                _ => (Color.White, Color.FromArgb(255, 183, 0))
            };

            var card = new Panel
            {
                Size = new Size(flpEntregas.Width - 16, 64),
                BackColor = bg,
                Cursor = Cursors.Hand,
                Tag = subId,
                Margin = new Padding(0, 0, 0, 6)
            };
            var borde = new Panel { Size = new Size(4, 64), Location = new Point(0, 0), BackColor = accent };
            var lblN = new Label
            {
                Text = nombre,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 25, 35),
                Location = new Point(12, 8),
                Size = new Size(200, 20),
                BackColor = Color.Transparent
            };
            var lblF = new Label
            {
                Text = string.IsNullOrEmpty(archivo) ? "Sin archivo" : archivo,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(130, 120, 100),
                Location = new Point(12, 30),
                Size = new Size(200, 16),
                BackColor = Color.Transparent
            };
            var lblNota = new Label
            {
                Text = status == "Graded" ? $"{notaTxt}pts" : "Pendiente",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = accent,
                Location = new Point(card.Width - 95, 12),
                Size = new Size(82, 20),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            var lblTarde = new Label
            {
                Text = tarde ? "Tarde" : "A tiempo",
                Font = new Font("Segoe UI", 8F),
                ForeColor = tarde ? Color.FromArgb(180, 30, 30) : Color.FromArgb(56, 161, 105),
                Location = new Point(card.Width - 95, 36),
                Size = new Size(82, 14),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };

            card.Controls.AddRange(new Control[] { borde, lblN, lblF, lblNota, lblTarde });

            Action click = () => SeleccionarEntrega(subId);
            card.Click += (s, e) => click();
            foreach (Control c in card.Controls) c.Click += (s, e) => click();

            return card;
        }

        // ── Seleccionar entrega → calificar ─────────────────────
        private void SeleccionarEntrega(int submissionId)
        {
            DataRow row = null;
            foreach (DataRow r in dtEntregas.Rows)
                if (Convert.ToInt32(r["submission_id"]) == submissionId) { row = r; break; }
            if (row == null) return;

            panelCalificar.Visible = true;
            panelCalificar.Tag = submissionId;
            lblCalNombre.Text = row["student_name"]?.ToString() ?? "";
            lblCalArchivo.Text = row["file_name"]?.ToString() ?? "Sin archivo";
            txtCalComentario.Text = row["comment"]?.ToString() ?? "";
            txtCalificacion.Text = row["score"] != DBNull.Value ? row["score"].ToString() : "";
            txtFeedback.Text = row.Table.Columns.Contains("feedback")
                                          ? row["feedback"]?.ToString() ?? "" : "";
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (panelCalificar.Tag == null) return;
            int subId = Convert.ToInt32(panelCalificar.Tag);

            if (!decimal.TryParse(txtCalificacion.Text.Trim(), out decimal score))
            {
                MessageBox.Show("Ingresa una calificación válida.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCalificacion.Focus(); return;
            }
            if (score < 0 || score > 100)
            {
                MessageBox.Show("La calificación debe ser entre 0 y 100.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (taskService.CalificarEntrega(subId, score, txtFeedback.Text.Trim()))
            {
                MessageBox.Show("Calificacion guardada.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEntregas(tareaSeleccionadaId);
                LimpiarCalificacion();
            }
        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            using var frm = new FrmCrearTarea(teacherId);
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK) CargarTareas();
        }

        private void LimpiarPanelDerecho() => panelDerecho.Visible = false;

        private void LimpiarCalificacion()
        {
            panelCalificar.Visible = false;
            panelCalificar.Tag = null;
            txtCalificacion.Text = "";
            txtFeedback.Text = "";
        }
    }
}