using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

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
                var lbl = new Guna2HtmlLabel
                {
                    Text = "No hay tareas creadas. Crea una nueva.",
                    Font = new Font("Segoe UI", 11F),
                    ForeColor = Color.FromArgb(180, 160, 120),
                    AutoSize = false,
                    Size = new Size(flpTareas.Width - 20, 50)
                };
                flpTareas.Controls.Add(lbl);
                return;
            }

            foreach (DataRow row in dt.Rows)
                flpTareas.Controls.Add(CrearCardTarea(row));
        }

        // ── Función auxiliar para determinar el estado ─────────
        private string DeterminarEstado(DateTime dueDate, string publishedStatus)
        {
            if (publishedStatus.ToLower() == "draft")
                return "Draft";

            if (DateTime.Today > dueDate)
                return "Expired";

            if (DateTime.Today == dueDate || DateTime.Today.AddDays(1) == dueDate)
                return "Active";

            return "Active";
        }

        private Guna2Panel CrearCardTarea(DataRow row)
        {
            int taskId = Convert.ToInt32(row["task_id"]);
            string titulo = row["title"]?.ToString() ?? "";
            string grupo = row["group_name"]?.ToString() ?? "";

            DateTime due = row["due_date"] != DBNull.Value
                             ? Convert.ToDateTime(row["due_date"]) : DateTime.Today;

            string publishedStatus = "published";
            if (row.Table.Columns.Contains("status"))
            {
                publishedStatus = row["status"]?.ToString() ?? "published";
            }

            string status = DeterminarEstado(due, publishedStatus);

            int entregas = row.Table.Columns.Contains("total_submissions")
                             ? Convert.ToInt32(row["total_submissions"]) : 0;
            int total = row.Table.Columns.Contains("total_students")
                             ? Convert.ToInt32(row["total_students"]) : 0;

            (Color bg, Color accent, string statusTxt) = status switch
            {
                "Active" => (Color.FromArgb(255, 248, 235), Color.FromArgb(255, 183, 0), "Activa"),
                "Expired" => (Color.FromArgb(255, 240, 240), Color.FromArgb(197, 48, 48), "Vencida"),
                "Completed" => (Color.FromArgb(235, 248, 255), Color.FromArgb(66, 153, 225), "Completada"),
                "Draft" => (Color.FromArgb(245, 245, 245), Color.FromArgb(160, 160, 160), "Borrador"),
                _ => (Color.FromArgb(245, 245, 245), Color.FromArgb(160, 160, 160), "Borrador")
            };

            var card = new Guna2Panel
            {
                Size = new Size(flpTareas.Width - 20, 90),
                FillColor = bg,
                BorderRadius = 12,
                Cursor = Cursors.Hand,
                Tag = taskId,
                Margin = new Padding(0, 0, 0, 8)
            };

            card.ShadowDecoration.Enabled = true;
            card.ShadowDecoration.Depth = 4;
            card.ShadowDecoration.Color = Color.FromArgb(12, 0, 0, 0);

            // Barra lateral de color
            var barre = new Guna2Panel
            {
                Size = new Size(5, 90),
                Location = new Point(0, 0),
                FillColor = accent,
                BorderRadius = 0
            };
            card.Controls.Add(barre);

            // Título
            var lblTit = new Guna2HtmlLabel
            {
                Text = titulo,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 25, 35),
                Location = new Point(14, 10),
                Size = new Size(280, 22),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblTit);

            // Grupo
            var lblGrp = new Guna2HtmlLabel
            {
                Text = grupo,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(130, 120, 100),
                Location = new Point(14, 34),
                Size = new Size(200, 16),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblGrp);

            // Fecha
            var lblFecha = new Guna2HtmlLabel
            {
                Text = $"Entrega: {due:dd/MM/yyyy}",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(150, 140, 120),
                Location = new Point(14, 52),
                Size = new Size(160, 16),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblFecha);

            // Entregas
            var lblEnt = new Guna2HtmlLabel
            {
                Text = $"{entregas}/{total} entregas",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = accent,
                Location = new Point(14, 70),
                Size = new Size(120, 16),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblEnt);

            // Status Badge
            var badgePanel = new Guna2Panel
            {
                Size = new Size(90, 24),
                Location = new Point(card.Width - 100, 10),
                FillColor = Color.FromArgb(25, accent.R / 2, accent.G / 2, accent.B / 2),
                BorderRadius = 8
            };
            badgePanel.ShadowDecoration.Enabled = false;

            var lblSt = new Guna2HtmlLabel
            {
                Text = statusTxt,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = accent,
                Location = new Point(0, 0),
                Size = new Size(90, 24),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            badgePanel.Controls.Add(lblSt);
            card.Controls.Add(badgePanel);

            // Eventos
            card.MouseEnter += (s, e) =>
            {
                card.FillColor = Color.FromArgb(
                    Math.Max(0, bg.R - 15),
                    Math.Max(0, bg.G - 15),
                    Math.Max(0, bg.B - 15));
            };
            card.MouseLeave += (s, e) => card.FillColor = bg;

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
                var lbl = new Guna2HtmlLabel
                {
                    Text = "Sin entregas aún.",
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = Color.FromArgb(180, 160, 120),
                    AutoSize = false,
                    Size = new Size(flpEntregas.Width - 16, 40)
                };
                flpEntregas.Controls.Add(lbl);
                return;
            }

            foreach (DataRow row in dt.Rows)
                flpEntregas.Controls.Add(CrearCardEntrega(row));
        }

        private Guna2Panel CrearCardEntrega(DataRow row)
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

            var card = new Guna2Panel
            {
                Size = new Size(flpEntregas.Width - 16, 68),
                FillColor = bg,
                BorderRadius = 10,
                Cursor = Cursors.Hand,
                Tag = subId,
                Margin = new Padding(0, 0, 0, 6)
            };

            card.ShadowDecoration.Enabled = true;
            card.ShadowDecoration.Depth = 3;
            card.ShadowDecoration.Color = Color.FromArgb(10, 0, 0, 0);

            // Barra lateral
            var borde = new Guna2Panel
            {
                Size = new Size(4, 68),
                Location = new Point(0, 0),
                FillColor = accent,
                BorderRadius = 0
            };
            card.Controls.Add(borde);

            // Nombre
            var lblN = new Guna2HtmlLabel
            {
                Text = nombre,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 25, 35),
                Location = new Point(12, 8),
                Size = new Size(220, 20),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblN);

            // Archivo
            var lblF = new Guna2HtmlLabel
            {
                Text = string.IsNullOrEmpty(archivo) ? "Sin archivo" : archivo,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(130, 120, 100),
                Location = new Point(12, 30),
                Size = new Size(220, 16),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblF);

            // Nota
            var lblNota = new Guna2HtmlLabel
            {
                Text = status == "Graded" ? $"{notaTxt}pts" : "Pendiente",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = accent,
                Location = new Point(card.Width - 95, 12),
                Size = new Size(82, 20),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblNota);

            // A tiempo / Tarde
            var lblTarde = new Guna2HtmlLabel
            {
                Text = tarde ? "Tarde" : "A tiempo",
                Font = new Font("Segoe UI", 8F),
                ForeColor = tarde ? Color.FromArgb(180, 30, 30) : Color.FromArgb(56, 161, 105),
                Location = new Point(card.Width - 95, 36),
                Size = new Size(82, 14),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblTarde);

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
                txtCalificacion.Focus();
                return;
            }
            if (score < 0 || score > 100)
            {
                MessageBox.Show("La calificación debe ser entre 0 y 100.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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