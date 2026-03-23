using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentation.Seccion_de_Estudiantes
{
    public partial class FrmTareasEstudiante : Form
    {
        private readonly TaskService taskService;
        private readonly int studentId;
        private int tareaSeleccionadaId = -1;
        private bool yaEntrego = false;
        private DataTable dtTareas;

        public FrmTareasEstudiante(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            taskService = new TaskService();
        }

        private void FrmTareasEstudiante_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                // 1. Verificar si el estudiante existe
                string checkStudent = "SELECT * FROM students WHERE student_id = @id";
                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(checkStudent, conn))
                {
                    cmd.Parameters.AddWithValue("@id", studentId);
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string studentName = reader["student_code"]?.ToString() ?? $"ID: {studentId}";
                        MessageBox.Show($"✅ Estudiante encontrado: {studentName}",
                            "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"❌ Estudiante con ID {studentId} NO encontrado",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    reader.Close();
                }

                // 2. Verificar el grupo del estudiante (directamente desde students)
                // Asumiendo que el estudiante tiene un campo group_id o similar
                string groupIdColumn = "group_id";
                string groupNameColumn = "group_name";

                // Verificar qué columnas existen en la tabla groups
                string checkGroupsColumns = @"
                    SELECT COLUMN_NAME 
                    FROM INFORMATION_SCHEMA.COLUMNS 
                    WHERE TABLE_NAME = 'groups'";

                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(checkGroupsColumns, conn))
                {
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    var groupColumns = new System.Collections.Generic.List<string>();
                    while (reader.Read())
                    {
                        groupColumns.Add(reader["COLUMN_NAME"].ToString());
                    }
                    reader.Close();

                    if (groupColumns.Contains("group_id"))
                        groupIdColumn = "group_id";
                    else if (groupColumns.Contains("group_1_id"))
                        groupIdColumn = "group_1_id";

                    if (groupColumns.Contains("group_name"))
                        groupNameColumn = "group_name";
                    else if (groupColumns.Contains("group_1_name"))
                        groupNameColumn = "group_1_name";
                }

                // Obtener el grupo del estudiante (asumiendo que students tiene group_id)
                // Primero verificamos si la columna group_id existe en students
                string checkStudentColumns = @"
                    SELECT COLUMN_NAME 
                    FROM INFORMATION_SCHEMA.COLUMNS 
                    WHERE TABLE_NAME = 'students'";

                int studentGroupId = -1;
                string studentGroupName = "Sin grupo";
                bool hasGroupColumn = false;

                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(checkStudentColumns, conn))
                {
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    var studentColumns = new System.Collections.Generic.List<string>();
                    while (reader.Read())
                    {
                        studentColumns.Add(reader["COLUMN_NAME"].ToString());
                    }
                    reader.Close();

                    hasGroupColumn = studentColumns.Contains("group_id") ||
                                    studentColumns.Contains("group_1_id");

                    if (hasGroupColumn)
                    {
                        string groupCol = studentColumns.Contains("group_id") ? "group_id" : "group_1_id";
                        string query = $"SELECT {groupCol} FROM students WHERE student_id = @id";
                        using (var cmd2 = new SqlCommand(query, conn))
                        {
                            cmd2.Parameters.AddWithValue("@id", studentId);
                            var result = cmd2.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                studentGroupId = Convert.ToInt32(result);

                                // Obtener nombre del grupo
                                string groupQuery = $"SELECT {groupNameColumn} FROM groups WHERE {groupIdColumn} = @groupId";
                                using (var cmd3 = new SqlCommand(groupQuery, conn))
                                {
                                    cmd3.Parameters.AddWithValue("@groupId", studentGroupId);
                                    var groupNameResult = cmd3.ExecuteScalar();
                                    if (groupNameResult != null)
                                        studentGroupName = groupNameResult.ToString();
                                }
                            }
                        }
                    }
                }

                if (studentGroupId > 0)
                {
                    MessageBox.Show($"📚 Estudiante asignado al grupo: {studentGroupName} (ID: {studentGroupId})",
                        "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("⚠️ El estudiante NO está asignado a ningún grupo.\n\n" +
                        "Las tareas se asignan por grupo, por lo que no verás ninguna tarea.\n" +
                        "Contacta a tu maestro para que te asigne a un grupo.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // 3. Cargar tareas
                CargarTareas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga inicial: {ex.Message}\n\n{ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Cargar tareas ───────────────────────────────────────
        private void CargarTareas()
        {
            try
            {
                dtTareas = taskService.ObtenerTareasEstudiante(studentId);

                if (dtTareas == null || dtTareas.Rows.Count == 0)
                {
                    flpTareas.Controls.Clear();
                    var lbl = new Label
                    {
                        Text = "📭 No hay tareas asignadas para ti.\n\n" +
                               "Posibles causas:\n" +
                               "• No estás asignado a ningún grupo\n" +
                               "• Tu grupo no tiene tareas creadas\n" +
                               "• Las tareas aún no han sido publicadas\n\n" +
                               "Consulta con tu maestro para más información.",
                        Font = new Font("Segoe UI", 11F),
                        ForeColor = Color.FromArgb(100, 100, 100),
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Margin = new Padding(20)
                    };
                    flpTareas.Controls.Add(lbl);

                    lblCntPendientes.Text = "0";
                    lblCntEntregadas.Text = "0";
                    lblCntVencidas.Text = "0";
                    lblCntCalificadas.Text = "0";
                    return;
                }

                RenderizarTarjetas(dtTareas);

                int pendientes = 0, entregadas = 0, vencidas = 0, calificadas = 0;
                foreach (DataRow row in dtTareas.Rows)
                {
                    string s = row["task_status"].ToString();
                    if (s == "Pending") pendientes++;
                    else if (s == "Submitted") entregadas++;
                    else if (s == "Expired") vencidas++;
                    else if (s == "Graded") calificadas++;
                }

                lblCntPendientes.Text = pendientes.ToString();
                lblCntEntregadas.Text = entregadas.ToString();
                lblCntVencidas.Text = vencidas.ToString();
                lblCntCalificadas.Text = calificadas.ToString();

                LimpiarDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Renderizar tarjetas de tarea ────────────────────────
        private void RenderizarTarjetas(DataTable dt)
        {
            flpTareas.Controls.Clear();

            if (dt == null || dt.Rows.Count == 0)
            {
                var lbl = new Label
                {
                    Text = "🎉 No tienes tareas pendientes.",
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.FromArgb(160, 150, 130),
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                flpTareas.Controls.Add(lbl);
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["task_id"]);
                string titulo = row["title"].ToString();
                string grupo = row["group_name"].ToString();
                string maestro = row["teacher_name"].ToString();
                string status = row["task_status"].ToString();
                string fecha = Convert.ToDateTime(row["due_date"]).ToString("dd/MM/yyyy");
                string dias = row["days_remaining"].ToString();

                Color cardBg, badgeBg, badgeFg, borderColor;
                string badge, diasTexto;
                int diasNum = int.TryParse(dias, out int d) ? d : 0;

                switch (status)
                {
                    case "Graded":
                        cardBg = Color.FromArgb(240, 255, 245);
                        badgeBg = Color.FromArgb(200, 255, 225);
                        badgeFg = Color.FromArgb(20, 120, 60);
                        borderColor = Color.FromArgb(180, 230, 200);
                        badge = "🏆 Calificada";
                        diasTexto = "Calificada";
                        break;
                    case "Submitted":
                        cardBg = Color.FromArgb(235, 245, 255);
                        badgeBg = Color.FromArgb(210, 230, 255);
                        badgeFg = Color.FromArgb(30, 80, 180);
                        borderColor = Color.FromArgb(180, 210, 255);
                        badge = "📤 Entregada";
                        diasTexto = "Entregada";
                        break;
                    case "Expired":
                        cardBg = Color.FromArgb(255, 240, 240);
                        badgeBg = Color.FromArgb(255, 210, 210);
                        badgeFg = Color.FromArgb(180, 30, 30);
                        borderColor = Color.FromArgb(255, 180, 180);
                        badge = "❌ Vencida";
                        diasTexto = "Vencida";
                        break;
                    default:
                        if (diasNum <= 2 && diasNum >= 0)
                        {
                            cardBg = Color.FromArgb(255, 248, 230);
                            badgeBg = Color.FromArgb(255, 235, 180);
                            badgeFg = Color.FromArgb(160, 90, 0);
                            borderColor = Color.FromArgb(255, 210, 140);
                            badge = "⚠️ Urgente";
                        }
                        else
                        {
                            cardBg = Color.White;
                            badgeBg = Color.FromArgb(255, 240, 200);
                            badgeFg = Color.FromArgb(160, 100, 0);
                            borderColor = Color.FromArgb(235, 225, 205);
                            badge = "⏳ Pendiente";
                        }
                        diasTexto = diasNum >= 0 ? $"{diasNum} días restantes" : "Vencida";
                        break;
                }

                var card = new Panel
                {
                    Size = new Size(flpTareas.Width - 24, 88),
                    BackColor = cardBg,
                    Cursor = Cursors.Hand,
                    Tag = id,
                    Margin = new Padding(0, 0, 0, 8)
                };
                card.Paint += (s2, e2) =>
                {
                    using var pen = new Pen(borderColor, 1.5f);
                    e2.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
                };

                var barra = new Panel
                {
                    Size = new Size(5, 88),
                    Location = new Point(0, 0),
                    BackColor = badgeFg
                };
                card.Controls.Add(barra);

                var lblT = new Label
                {
                    Text = titulo,
                    Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(25, 25, 35),
                    Location = new Point(16, 10),
                    Size = new Size(270, 22),
                    BackColor = Color.Transparent
                };
                card.Controls.Add(lblT);

                var lblSub = new Label
                {
                    Text = $"👥 {grupo}  ·  👨‍🏫 {maestro}",
                    Font = new Font("Segoe UI", 8.5F),
                    ForeColor = Color.FromArgb(130, 120, 100),
                    Location = new Point(16, 34),
                    Size = new Size(270, 18),
                    BackColor = Color.Transparent
                };
                card.Controls.Add(lblSub);

                var lblF = new Label
                {
                    Text = $"📅 {fecha}",
                    Font = new Font("Segoe UI", 8F),
                    ForeColor = Color.FromArgb(150, 140, 120),
                    Location = new Point(16, 56),
                    Size = new Size(120, 16),
                    BackColor = Color.Transparent
                };
                card.Controls.Add(lblF);

                var pBadge = new Panel
                {
                    Size = new Size(95, 24),
                    Location = new Point(card.Width - 110, 10),
                    BackColor = badgeBg
                };
                var lblBadge = new Label
                {
                    Text = badge,
                    Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                    ForeColor = badgeFg,
                    AutoSize = false,
                    Size = new Size(95, 24),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Transparent
                };
                pBadge.Controls.Add(lblBadge);
                card.Controls.Add(pBadge);

                var lblDias = new Label
                {
                    Text = diasTexto,
                    Font = new Font("Segoe UI", 8F),
                    ForeColor = diasNum < 0 ? Color.FromArgb(180, 30, 30)
                               : diasNum <= 2 ? Color.FromArgb(160, 90, 0)
                               : Color.FromArgb(130, 120, 100),
                    Location = new Point(card.Width - 110, 40),
                    Size = new Size(95, 16),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Transparent
                };
                card.Controls.Add(lblDias);

                EventHandler clickHandler = (s2, e2) => MostrarDetalleTarea(id);
                card.Click += clickHandler;
                barra.Click += clickHandler;
                lblT.Click += clickHandler;
                lblSub.Click += clickHandler;
                lblF.Click += clickHandler;
                pBadge.Click += clickHandler;
                lblBadge.Click += clickHandler;
                lblDias.Click += clickHandler;

                flpTareas.Controls.Add(card);
            }
        }

        // ── Mostrar detalle de tarea ────────────────────────────
        private void MostrarDetalleTarea(int taskId)
        {
            tareaSeleccionadaId = taskId;
            DataRow row = null;
            foreach (DataRow r in dtTareas.Rows)
                if (Convert.ToInt32(r["task_id"]) == taskId) { row = r; break; }
            if (row == null) return;

            foreach (Control c in flpTareas.Controls)
            {
                if (c is Panel p && p.Tag != null)
                {
                    p.BackColor = Convert.ToInt32(p.Tag) == taskId
                        ? Color.FromArgb(255, 248, 235)
                        : ObtenerColorFondoStatus(row["task_status"].ToString());
                }
            }

            string status = row["task_status"].ToString();
            string titulo = row["title"].ToString();
            string maestro = row["teacher_name"].ToString();
            string fecha = Convert.ToDateTime(row["due_date"]).ToString("dd/MM/yyyy");
            string desc = row.Table.Columns.Contains("description")
                              ? row["description"]?.ToString() ?? "" : "";

            lblDetalleTitulo.Text = titulo;
            lblDetalleMaestro.Text = $"👨‍🏫 {maestro}";
            lblDetalleFecha.Text = $"📅 Entrega: {fecha}";
            lblDetalleDesc.Text = string.IsNullOrWhiteSpace(desc) ? "Sin descripción." : desc;

            (lblDetalleEstado.Text, lblDetalleEstado.ForeColor, lblDetalleEstado.BackColor) = status switch
            {
                "Graded" => ("🏆 Calificada", Color.FromArgb(20, 120, 60), Color.FromArgb(200, 255, 225)),
                "Submitted" => ("📤 Entregada", Color.FromArgb(30, 80, 180), Color.FromArgb(210, 230, 255)),
                "Expired" => ("❌ Vencida", Color.FromArgb(180, 30, 30), Color.FromArgb(255, 210, 210)),
                _ => ("⏳ Pendiente", Color.FromArgb(160, 90, 0), Color.FromArgb(255, 235, 180))
            };

            yaEntrego = status == "Submitted" || status == "Graded";

            panelEntregar.Visible = status == "Pending";
            panelEntregado.Visible = yaEntrego;
            panelCalificacion.Visible = status == "Graded";
            panelDetalle.Visible = true;

            if (yaEntrego)
            {
                string archivo = row.Table.Columns.Contains("submitted_file")
                                   ? row["submitted_file"]?.ToString() : "";
                string comentario = row.Table.Columns.Contains("student_comment")
                                   ? row["student_comment"]?.ToString() : "";
                lblArchivoEntregado.Text = string.IsNullOrEmpty(archivo) ? "Sin archivo" : $"📄 {archivo}";
                lblComentarioEntregado.Text = string.IsNullOrEmpty(comentario) ? "Sin comentario" : comentario;
            }

            if (status == "Graded")
            {
                string nota = row["score"]?.ToString() ?? "-";
                string feedback = row.Table.Columns.Contains("feedback")
                                  ? row["feedback"]?.ToString() ?? "Sin comentario" : "Sin comentario";
                lblNota.Text = $"🏆 {nota} puntos";
                lblFeedback.Text = feedback;
            }
        }

        private static Color ObtenerColorFondoStatus(string status) => status switch
        {
            "Graded" => Color.FromArgb(240, 255, 245),
            "Submitted" => Color.FromArgb(235, 245, 255),
            "Expired" => Color.FromArgb(255, 240, 240),
            _ => Color.White
        };

        private void LimpiarDetalle()
        {
            panelDetalle.Visible = false;
            panelEntregar.Visible = false;
            panelEntregado.Visible = false;
            panelCalificacion.Visible = false;
            tareaSeleccionadaId = -1;
        }

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

        private void FiltrarPor(string status)
        {
            if (dtTareas == null) return;
            var view = dtTareas.DefaultView;
            view.RowFilter = string.IsNullOrEmpty(status) ? "" : $"task_status = '{status}'";
            RenderizarTarjetas(view.ToTable());
            LimpiarDetalle();
        }

        private void btnFiltroTodas_Click(object sender, EventArgs e) => FiltrarPor("");
        private void btnFiltroPendientes_Click(object sender, EventArgs e) => FiltrarPor("Pending");
        private void btnFiltroEntregadas_Click(object sender, EventArgs e) => FiltrarPor("Submitted");
        private void btnFiltroVencidas_Click(object sender, EventArgs e) => FiltrarPor("Expired");
        private void btnFiltroCalificadas_Click(object sender, EventArgs e) => FiltrarPor("Graded");
    }
}