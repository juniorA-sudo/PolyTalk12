using System;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string archivoSeleccionado = "";

        public FrmTareasEstudiante(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            taskService = new TaskService();

            // Configuración del formulario
            this.DoubleBuffered = true;
            this.BackColor = Color.FromArgb(252, 248, 240);
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

                    if (!reader.Read())
                    {
                        MessageBox.Show($"❌ Estudiante con ID {studentId} NO encontrado",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    reader.Close();
                }

                // 2. Obtener información del grupo
                ObtenerInfoGrupo(db);

                // 3. Cargar tareas
                CargarTareas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga inicial: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerInfoGrupo(DatabaseHelper db)
        {
            try
            {
                string checkStudentColumns = @"
                    SELECT COLUMN_NAME 
                    FROM INFORMATION_SCHEMA.COLUMNS 
                    WHERE TABLE_NAME = 'students'";

                int studentGroupId = -1;

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

                    if (studentColumns.Contains("group_id") || studentColumns.Contains("group_1_id"))
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
                            }
                        }
                    }
                }

                if (studentGroupId <= 0)
                {
                    MostrarMensajeGrupo();
                }
            }
            catch
            {
                // Continuar aunque falle la verificación del grupo
            }
        }

        private void MostrarMensajeGrupo()
        {
            flpTareas.Controls.Clear();
            var lbl = new Label
            {
                Text = "⚠️ No estás asignado a ningún grupo\n\n" +
                       "Las tareas se asignan por grupo.\n" +
                       "Contacta a tu maestro para que te asigne.",
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(100, 100, 100),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(20)
            };
            flpTareas.Controls.Add(lbl);
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
                        Text = "📭 No hay tareas asignadas\n\n" +
                               "Posibles causas:\n" +
                               "• No estás en ningún grupo\n" +
                               "• Tu grupo sin tareas\n" +
                               "• Tareas no publicadas",
                        Font = new Font("Segoe UI", 11F),
                        ForeColor = Color.FromArgb(100, 100, 100),
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Margin = new Padding(20)
                    };
                    flpTareas.Controls.Add(lbl);

                    ActualizarContadores(0, 0, 0, 0);
                    return;
                }

                RenderizarTarjetas(dtTareas);
                ActualizarContadores();
                LimpiarDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarContadores(int pendientes = -1, int entregadas = -1, int vencidas = -1, int calificadas = -1)
        {
            if (pendientes < 0 && dtTareas != null)
            {
                pendientes = 0;
                entregadas = 0;
                vencidas = 0;
                calificadas = 0;

                foreach (DataRow row in dtTareas.Rows)
                {
                    string s = row["task_status"].ToString();
                    if (s == "Pending") pendientes++;
                    else if (s == "Submitted") entregadas++;
                    else if (s == "Expired") vencidas++;
                    else if (s == "Graded") calificadas++;
                }
            }

            lblCntPendientes.Text = pendientes.ToString();
            lblCntEntregadas.Text = entregadas.ToString();
            lblCntVencidas.Text = vencidas.ToString();
            lblCntCalificadas.Text = calificadas.ToString();
        }

        // ── Renderizar tarjetas de tarea ────────────────────────

        private void RenderizarTarjetas(DataTable dt)
        {
            flpTareas.Controls.Clear();

            if (dt == null || dt.Rows.Count == 0)
            {
                var lbl = new Label
                {
                    Text = "🎉 No tienes tareas.",
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
                CrearTarjeta(row);
            }
        }

        private void CrearTarjeta(DataRow row)
        {
            int id = Convert.ToInt32(row["task_id"]);
            string titulo = row["title"].ToString();
            string grupo = row["group_name"].ToString();
            string maestro = row["teacher_name"].ToString();
            string status = row["task_status"].ToString();
            string fecha = Convert.ToDateTime(row["due_date"]).ToString("dd/MM/yyyy");
            string dias = row["days_remaining"].ToString();

            int diasNum = int.TryParse(dias, out int d) ? d : 0;
            var (cardBg, badgeBg, badgeFg, borderColor, badge, diasTexto) = ObtenerEstilosCard(status, diasNum);

            var card = new Panel
            {
                Size = new Size(flpTareas.Width - 24, 90),
                BackColor = cardBg,
                Cursor = Cursors.Hand,
                Tag = id,
                Margin = new Padding(0, 0, 0, 8)
            };

            // Borde
            card.Paint += (s2, e2) =>
            {
                using var pen = new Pen(borderColor, 1.5f);
                e2.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
            };

            // Barra lateral
            var barra = new Panel
            {
                Size = new Size(5, 90),
                Location = new Point(0, 0),
                BackColor = badgeFg
            };
            card.Controls.Add(barra);

            // Título
            var lblT = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 25, 35),
                Location = new Point(12, 8),
                Size = new Size(240, 20),
                BackColor = Color.Transparent,
                AutoSize = false
            };
            card.Controls.Add(lblT);

            // Grupo y Maestro
            var lblSub = new Label
            {
                Text = $"👥 {grupo}  •  👨‍🏫 {maestro}",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(130, 120, 100),
                Location = new Point(12, 30),
                Size = new Size(240, 15),
                BackColor = Color.Transparent,
                AutoSize = false
            };
            card.Controls.Add(lblSub);

            // Fecha
            var lblF = new Label
            {
                Text = $"📅 {fecha}",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(150, 140, 120),
                Location = new Point(12, 48),
                Size = new Size(200, 14),
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblF);

            // Badge
            var pBadge = new Panel
            {
                Size = new Size(85, 24),
                Location = new Point(card.Width - 100, 8),
                BackColor = badgeBg,
                Cursor = Cursors.Hand
            };

            var lblBadge = new Label
            {
                Text = badge,
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                ForeColor = badgeFg,
                AutoSize = false,
                Size = new Size(85, 24),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            pBadge.Controls.Add(lblBadge);
            card.Controls.Add(pBadge);

            // Días
            var lblDias = new Label
            {
                Text = diasTexto,
                Font = new Font("Segoe UI", 8F),
                ForeColor = diasNum < 0 ? Color.FromArgb(180, 30, 30)
                           : diasNum <= 2 ? Color.FromArgb(160, 90, 0)
                           : Color.FromArgb(130, 120, 100),
                Location = new Point(card.Width - 100, 36),
                Size = new Size(85, 14),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblDias);

            // Event handlers
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

        private (Color bg, Color badgeBg, Color badgeFg, Color border, string badge, string diasText) ObtenerEstilosCard(string status, int diasNum)
        {
            return status switch
            {
                "Graded" => (
                    Color.FromArgb(240, 255, 245),
                    Color.FromArgb(200, 255, 225),
                    Color.FromArgb(20, 120, 60),
                    Color.FromArgb(180, 230, 200),
                    "🏆 Calificada",
                    "Calificada"
                ),
                "Submitted" => (
                    Color.FromArgb(235, 245, 255),
                    Color.FromArgb(210, 230, 255),
                    Color.FromArgb(30, 80, 180),
                    Color.FromArgb(180, 210, 255),
                    "📤 Entregada",
                    "Entregada"
                ),
                "Expired" => (
                    Color.FromArgb(255, 240, 240),
                    Color.FromArgb(255, 210, 210),
                    Color.FromArgb(180, 30, 30),
                    Color.FromArgb(255, 180, 180),
                    "❌ Vencida",
                    "Vencida"
                ),
                _ => diasNum <= 2 && diasNum >= 0
                    ? (
                        Color.FromArgb(255, 248, 230),
                        Color.FromArgb(255, 235, 180),
                        Color.FromArgb(160, 90, 0),
                        Color.FromArgb(255, 210, 140),
                        "⚠️ Urgente",
                        $"{diasNum} días"
                    )
                    : (
                        Color.White,
                        Color.FromArgb(255, 240, 200),
                        Color.FromArgb(160, 100, 0),
                        Color.FromArgb(235, 225, 205),
                        "⏳ Pendiente",
                        diasNum >= 0 ? $"{diasNum} días" : "Vencida"
                    )
            };
        }

        private static Color ObtenerColorFondoStatus(string status) => status switch
        {
            "Graded" => Color.FromArgb(240, 255, 245),
            "Submitted" => Color.FromArgb(235, 245, 255),
            "Expired" => Color.FromArgb(255, 240, 240),
            _ => Color.White
        };

        // ── Mostrar detalle de tarea ────────────────────────────

        private void MostrarDetalleTarea(int taskId)
        {
            tareaSeleccionadaId = taskId;
            DataRow row = null;

            foreach (DataRow r in dtTareas.Rows)
            {
                if (Convert.ToInt32(r["task_id"]) == taskId)
                {
                    row = r;
                    break;
                }
            }

            if (row == null) return;

            // Actualizar highlighting
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
            lblDetalleFecha.Text = $"📅 {fecha}";
            lblDetalleDesc.Text = string.IsNullOrWhiteSpace(desc) ? "Sin descripción." : desc;

            var (labelText, foreColor, backColor) = status switch
            {
                "Graded" => ("🏆 Calificada", Color.FromArgb(20, 120, 60), Color.FromArgb(200, 255, 225)),
                "Submitted" => ("📤 Entregada", Color.FromArgb(30, 80, 180), Color.FromArgb(210, 230, 255)),
                "Expired" => ("❌ Vencida", Color.FromArgb(180, 30, 30), Color.FromArgb(255, 210, 210)),
                _ => ("⏳ Pendiente", Color.FromArgb(160, 90, 0), Color.FromArgb(255, 235, 180))
            };

            lblDetalleEstado.Text = labelText;
            lblDetalleEstado.ForeColor = foreColor;
            lblDetalleEstado.BackColor = backColor;

            yaEntrego = status == "Submitted" || status == "Graded";

            // Mostrar u ocultar paneles según el estado
            panelEntregar.Visible = status == "Pending";
            panelEntregado.Visible = yaEntrego;
            panelCalificacion.Visible = status == "Graded";

            if (yaEntrego)
            {
                string archivo = row.Table.Columns.Contains("submitted_file")
                                   ? row["submitted_file"]?.ToString() : "";
                string comentario = row.Table.Columns.Contains("student_comment")
                                   ? row["student_comment"]?.ToString() : "";

                lblArchivoEntregado.Text = string.IsNullOrEmpty(archivo) ? "📄 Sin archivo" : $"📄 {archivo}";
                lblComentarioEntregado.Text = string.IsNullOrEmpty(comentario) ? "Sin comentario" : comentario;
            }

            if (status == "Graded")
            {
                string nota = row["score"]?.ToString() ?? "-";
                string feedback = row.Table.Columns.Contains("feedback")
                                  ? row["feedback"]?.ToString() ?? "Sin comentario" : "Sin comentario";

                lblNota.Text = $"{nota} pts";
                lblFeedback.Text = feedback;
            }
        }

        private void LimpiarDetalle()
        {
            panelEntregar.Visible = false;
            panelEntregado.Visible = false;
            panelCalificacion.Visible = false;
            tareaSeleccionadaId = -1;

            lblDetalleTitulo.Text = "Selecciona una tarea";
            lblDetalleEstado.Text = "Pendiente";
            lblDetalleEstado.ForeColor = Color.FromArgb(160, 90, 0);
            lblDetalleEstado.BackColor = Color.FromArgb(255, 235, 180);
            lblDetalleMaestro.Text = "";
            lblDetalleFecha.Text = "";
            lblDetalleDesc.Text = "";
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Selecciona el archivo de tu tarea";
                    ofd.Filter = "Todos los archivos (*.*)|*.*|PDF (*.pdf)|*.pdf|Documentos (*.doc;*.docx)|*.doc;*.docx|Imágenes (*.jpg;*.png)|*.jpg;*.png|Comprimidos (*.zip;*.rar)|*.zip;*.rar";
                    ofd.FilterIndex = 1;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        archivoSeleccionado = ofd.FileName;
                        string nombreArchivo = Path.GetFileName(archivoSeleccionado);
                        txtNombreArchivo.Text = nombreArchivo;

                        FileInfo fileInfo = new FileInfo(archivoSeleccionado);
                        double sizeMB = fileInfo.Length / (1024.0 * 1024.0);
                        string sizeText = sizeMB > 0 ? $" ({sizeMB:F2} MB)" : "";

                        lblArchivoSize.Text = $"✓ Archivo seleccionado: {nombreArchivo}{sizeText}";
                        lblArchivoSize.ForeColor = Color.FromArgb(20, 120, 60);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar archivo: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show("Agrega un comentario o selecciona un archivo.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Confirmas la entrega de esta tarea?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string rutaEntrega = "";
                    if (!string.IsNullOrEmpty(archivoSeleccionado) && File.Exists(archivoSeleccionado))
                    {
                        string carpetaEntregas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Entregas");
                        if (!Directory.Exists(carpetaEntregas))
                        {
                            Directory.CreateDirectory(carpetaEntregas);
                        }

                        string nombreEntrega = $"{studentId}_{tareaSeleccionadaId}_{DateTime.Now:yyyyMMdd_HHmmss}_{Path.GetFileName(archivoSeleccionado)}";
                        rutaEntrega = Path.Combine(carpetaEntregas, nombreEntrega);

                        File.Copy(archivoSeleccionado, rutaEntrega, true);
                    }

                    if (taskService.EntregarTarea(tareaSeleccionadaId, studentId, comentario, rutaEntrega))
                    {
                        MessageBox.Show("✅ Tarea entregada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtComentario.Clear();
                        txtNombreArchivo.Clear();
                        lblArchivoSize.Text = "";
                        archivoSeleccionado = "";

                        CargarTareas();
                    }
                    else
                    {
                        MessageBox.Show("❌ Error al entregar la tarea.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar la entrega: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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