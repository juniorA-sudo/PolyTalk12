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
        private FrmPrincipal frmPrincipal;

        public FrmTareasEstudiante(int studentId, FrmPrincipal frmPrincipal = null)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.frmPrincipal = frmPrincipal;
            taskService = new TaskService();
            this.DoubleBuffered = true;
        }

        private void FrmTareasEstudiante_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
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

                CargarTareas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTareas()
        {
            try
            {
                dtTareas = taskService.ObtenerTareasEstudiante(studentId);

                if (dtTareas == null || dtTareas.Rows.Count == 0)
                {
                    MostrarMensajeSinTareas();
                    ActualizarContadores(0, 0, 0, 0);
                    return;
                }

                // Verificar que las columnas necesarias existan
                if (!VerificarColumnasTareas())
                {
                    MostrarMensajeErrorColumnas();
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
                MostrarMensajeSinTareas();
            }
        }

        private bool VerificarColumnasTareas()
        {
            var columnasNecesarias = new[] { "task_id", "title", "group_name", "teacher_name",
                "task_status", "due_date", "days_remaining" };

            foreach (var col in columnasNecesarias)
            {
                if (!dtTareas.Columns.Contains(col))
                {
                    System.Diagnostics.Debug.WriteLine($"Columna faltante: {col}");
                    return false;
                }
            }
            return true;
        }

        private void MostrarMensajeSinTareas()
        {
            flpTareas.Controls.Clear();
            var lbl = new Label
            {
                Text = "📭 No hay tareas asignadas\n\n• No estás en ningún grupo\n• Tu grupo sin tareas\n• Tareas no publicadas",
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(100, 100, 100),
                AutoSize = true,
                Margin = new Padding(20)
            };
            flpTareas.Controls.Add(lbl);
        }

        private void MostrarMensajeErrorColumnas()
        {
            flpTareas.Controls.Clear();
            var lbl = new Label
            {
                Text = "⚠️ Error en la configuración de tareas\n\nContacta al administrador",
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(180, 80, 80),
                AutoSize = true,
                Margin = new Padding(20)
            };
            flpTareas.Controls.Add(lbl);
        }

        private void ActualizarContadores(int pendientes = -1, int entregadas = -1, int vencidas = -1, int calificadas = -1)
        {
            if (pendientes < 0 && dtTareas != null)
            {
                pendientes = 0; entregadas = 0; vencidas = 0; calificadas = 0;
                foreach (DataRow row in dtTareas.Rows)
                {
                    string s = row["task_status"].ToString();
                    if (s == "Pending") pendientes++;
                    else if (s == "Submitted") entregadas++;
                    else if (s == "Expired") vencidas++;
                    else if (s == "Graded") calificadas++;
                }
            }

            if (lblCntPendientes != null) lblCntPendientes.Text = pendientes.ToString();
            if (lblCntEntregadas != null) lblCntEntregadas.Text = entregadas.ToString();
            if (lblCntVencidas != null) lblCntVencidas.Text = vencidas.ToString();
            if (lblCntCalificadas != null) lblCntCalificadas.Text = calificadas.ToString();
        }

        private void RenderizarTarjetas(DataTable dt)
        {
            flpTareas.Controls.Clear();
            if (dt == null || dt.Rows.Count == 0) return;

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    CrearTarjeta(row);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error al crear tarjeta: {ex.Message}");
                }
            }
        }

        private void CrearTarjeta(DataRow row)
        {
            try
            {
                // Obtener valores con validación
                int id = Convert.ToInt32(row["task_id"]);
                string titulo = row["title"]?.ToString() ?? "Sin título";
                string grupo = row["group_name"]?.ToString() ?? "Sin grupo";
                string maestro = row["teacher_name"]?.ToString() ?? "Sin maestro";
                string status = row["task_status"]?.ToString() ?? "Pending";
                string fecha = row["due_date"] != DBNull.Value ? Convert.ToDateTime(row["due_date"]).ToString("dd/MM/yyyy") : "Sin fecha";

                int diasNum = 0;
                if (row["days_remaining"] != DBNull.Value)
                    int.TryParse(row["days_remaining"].ToString(), out diasNum);

                // ✅ NUEVA: Obtener nota si existe
                string nota = "";
                if (row.Table.Columns.Contains("score") && row["score"] != DBNull.Value)
                {
                    nota = row["score"].ToString();
                }

                var (cardBg, badgeBg, badgeFg, borderColor, badge, diasTexto) = ObtenerEstilosCard(status, diasNum);

                var card = new Panel
                {
                    Size = new Size(flpTareas.Width - 24, 90),
                    BackColor = cardBg,
                    Cursor = Cursors.Hand,
                    Tag = id,
                    Margin = new Padding(0, 0, 0, 8)
                };

                card.Paint += (s, e) =>
                {
                    using var pen = new Pen(borderColor, 1.5f);
                    e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
                };

                var barra = new Panel { Size = new Size(5, 90), Location = new Point(0, 0), BackColor = badgeFg };
                card.Controls.Add(barra);

                var lblT = new Label
                {
                    Text = titulo,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(25, 25, 35),
                    Location = new Point(12, 8),
                    Size = new Size(240, 20),
                    BackColor = Color.Transparent
                };
                card.Controls.Add(lblT);

                var lblSub = new Label
                {
                    Text = $"👥 {grupo}  •  👨‍🏫 {maestro}",
                    Font = new Font("Segoe UI", 8F),
                    ForeColor = Color.FromArgb(130, 120, 100),
                    Location = new Point(12, 30),
                    Size = new Size(240, 15),
                    BackColor = Color.Transparent
                };
                card.Controls.Add(lblSub);

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

                var pBadge = new Panel { Size = new Size(85, 24), Location = new Point(card.Width - 100, 8), BackColor = badgeBg };
                var lblBadge = new Label
                {
                    Text = badge,
                    Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                    ForeColor = badgeFg,
                    Size = new Size(85, 24),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Transparent
                };
                pBadge.Controls.Add(lblBadge);
                card.Controls.Add(pBadge);

                // ✅ NUEVA: Mostrar nota si está calificada
                var lblDias = new Label
                {
                    Font = new Font("Segoe UI", 8F),
                    ForeColor = diasNum < 0 ? Color.FromArgb(180, 30, 30) : diasNum <= 2 ? Color.FromArgb(160, 90, 0) : Color.FromArgb(130, 120, 100),
                    Location = new Point(card.Width - 100, 36),
                    Size = new Size(85, 14),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Transparent
                };

                if (status == "Graded" && !string.IsNullOrEmpty(nota))
                {
                    lblDias.Text = $"📊 Nota: {nota}";
                    lblDias.ForeColor = Color.FromArgb(20, 120, 60);
                }
                else
                {
                    lblDias.Text = diasNum >= 0 ? $"{diasNum} días" : "Vencida";
                }

                card.Controls.Add(lblDias);

                EventHandler clickHandler = (s, e) => MostrarDetalleTarea(id);
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
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en CrearTarjeta: {ex.Message}");
            }
        }

        private (Color bg, Color badgeBg, Color badgeFg, Color border, string badge, string diasText) ObtenerEstilosCard(string status, int diasNum)
        {
            return status switch
            {
                "Graded" => (Color.FromArgb(240, 255, 245), Color.FromArgb(200, 255, 225), Color.FromArgb(20, 120, 60), Color.FromArgb(180, 230, 200), "🏆 Calificada", "Calificada"),
                "Submitted" => (Color.FromArgb(235, 245, 255), Color.FromArgb(210, 230, 255), Color.FromArgb(30, 80, 180), Color.FromArgb(180, 210, 255), "📤 Entregada", "Entregada"),
                "Expired" => (Color.FromArgb(255, 240, 240), Color.FromArgb(255, 210, 210), Color.FromArgb(180, 30, 30), Color.FromArgb(255, 180, 180), "❌ Vencida", "Vencida"),
                _ when diasNum <= 2 && diasNum >= 0 => (Color.FromArgb(255, 248, 230), Color.FromArgb(255, 235, 180), Color.FromArgb(160, 90, 0), Color.FromArgb(255, 210, 140), "⚠️ Urgente", $"{diasNum} días"),
                _ => (Color.White, Color.FromArgb(255, 240, 200), Color.FromArgb(160, 100, 0), Color.FromArgb(235, 225, 205), "⏳ Pendiente", diasNum >= 0 ? $"{diasNum} días" : "Vencida")
            };
        }

        private static Color ObtenerColorFondoStatus(string status) => status switch
        {
            "Graded" => Color.FromArgb(240, 255, 245),
            "Submitted" => Color.FromArgb(235, 245, 255),
            "Expired" => Color.FromArgb(255, 240, 240),
            _ => Color.White
        };

        private void MostrarDetalleTarea(int taskId)
        {
            try
            {
                tareaSeleccionadaId = taskId;
                DataRow row = null;
                foreach (DataRow r in dtTareas.Rows)
                    if (Convert.ToInt32(r["task_id"]) == taskId) { row = r; break; }
                if (row == null) return;

                foreach (Control c in flpTareas.Controls)
                    if (c is Panel p && p.Tag != null && Convert.ToInt32(p.Tag) == taskId)
                        p.BackColor = Color.FromArgb(255, 248, 235);

                string status = row["task_status"]?.ToString() ?? "Pending";
                string titulo = row["title"]?.ToString() ?? "Sin título";
                string maestro = row["teacher_name"]?.ToString() ?? "Sin maestro";
                string fecha = row["due_date"] != DBNull.Value ? Convert.ToDateTime(row["due_date"]).ToString("dd/MM/yyyy") : "Sin fecha";
                string desc = row.Table.Columns.Contains("description") ? row["description"]?.ToString() ?? "" : "";

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

                panelEntregar.Visible = status == "Pending";
                panelEntregado.Visible = yaEntrego;
                panelCalificacion.Visible = status == "Graded";

                if (yaEntrego)
                {
                    string archivo = row.Table.Columns.Contains("submitted_file") ? row["submitted_file"]?.ToString() : "";
                    string comentario = row.Table.Columns.Contains("student_comment") ? row["student_comment"]?.ToString() : "";
                    lblArchivoEntregado.Text = string.IsNullOrEmpty(archivo) ? "📄 Sin archivo" : $"📄 {archivo}";
                    lblComentarioEntregado.Text = string.IsNullOrEmpty(comentario) ? "Sin comentario" : comentario;
                }

                if (status == "Graded")
                {
                    string nota = row["score"]?.ToString() ?? "-";
                    string feedback = row.Table.Columns.Contains("feedback") ? row["feedback"]?.ToString() ?? "Sin comentario" : "Sin comentario";
                    lblNota.Text = $"{nota} pts";
                    lblFeedback.Text = feedback;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en MostrarDetalleTarea: {ex.Message}");
            }
        }

        private void LimpiarDetalle()
        {
            panelEntregar.Visible = false;
            panelEntregado.Visible = false;
            panelCalificacion.Visible = false;
            tareaSeleccionadaId = -1;

            if (lblDetalleTitulo != null) lblDetalleTitulo.Text = "Selecciona una tarea";
            if (lblDetalleEstado != null)
            {
                lblDetalleEstado.Text = "Pendiente";
                lblDetalleEstado.ForeColor = Color.FromArgb(160, 90, 0);
                lblDetalleEstado.BackColor = Color.FromArgb(255, 235, 180);
            }
            if (lblDetalleMaestro != null) lblDetalleMaestro.Text = "";
            if (lblDetalleFecha != null) lblDetalleFecha.Text = "";
            if (lblDetalleDesc != null) lblDetalleDesc.Text = "";
            if (txtComentario != null) txtComentario.Clear();
            if (txtNombreArchivo != null) txtNombreArchivo.Clear();
            if (lblArchivoSize != null) lblArchivoSize.Text = "";
            archivoSeleccionado = "";
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecciona el archivo de tu tarea";
                ofd.Filter = "Todos los archivos (*.*)|*.*|PDF (*.pdf)|*.pdf|Documentos (*.doc;*.docx)|*.doc;*.docx|Imágenes (*.jpg;*.png)|*.jpg;*.png";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    archivoSeleccionado = ofd.FileName;
                    string nombreArchivo = Path.GetFileName(archivoSeleccionado);
                    if (txtNombreArchivo != null) txtNombreArchivo.Text = nombreArchivo;

                    FileInfo fileInfo = new FileInfo(archivoSeleccionado);
                    double sizeMB = fileInfo.Length / (1024.0 * 1024.0);
                    if (lblArchivoSize != null)
                    {
                        lblArchivoSize.Text = $"✓ Archivo: {nombreArchivo} ({(sizeMB > 0 ? sizeMB.ToString("F2") + " MB" : fileInfo.Length / 1024 + " KB")})";
                        lblArchivoSize.ForeColor = Color.FromArgb(20, 120, 60);
                    }
                }
            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrega())
                return;

            if (!FormValidator.MostrarConfirmacion("¿Confirmas la entrega de esta tarea?"))
                return;

            try
            {
                string comentario = txtComentario?.Text.Trim() ?? "";
                string rutaEntrega = "";

                // Validar y copiar archivo si existe
                if (!string.IsNullOrEmpty(archivoSeleccionado) && File.Exists(archivoSeleccionado))
                {
                    if (!FormValidator.ValidarArchivo(archivoSeleccionado, out string errorArchivo))
                    {
                        FormValidator.MostrarError(errorArchivo);
                        return;
                    }

                    string carpetaEntregas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Entregas");
                    Directory.CreateDirectory(carpetaEntregas);
                    string nombreEntrega = $"{studentId}_{tareaSeleccionadaId}_{DateTime.Now:yyyyMMdd_HHmmss}_{Path.GetFileName(archivoSeleccionado)}";
                    rutaEntrega = Path.Combine(carpetaEntregas, nombreEntrega);
                    File.Copy(archivoSeleccionado, rutaEntrega, true);
                }

                // Guardar entrega en BD
                if (taskService.EntregarTarea(tareaSeleccionadaId, studentId, comentario, rutaEntrega))
                {
                    MessageBox.Show("✅ Tarea entregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDetalle();
                    CargarTareas();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la entrega. Intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (UnauthorizedAccessException)
            {
                FormValidator.MostrarError("No tienes permisos para guardar el archivo. Contacta al administrador.");
            }
            catch (IOException ex)
            {
                FormValidator.MostrarError($"Error al guardar el archivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                FormValidator.MostrarError($"Error inesperado: {ex.Message}");
            }
        }

        /// <summary>Valida todos los requisitos antes de entregar tarea</summary>
        private bool ValidarEntrega()
        {
            var errores = new System.Collections.Generic.List<string>();

            // 1. Verificar que hay tarea seleccionada
            if (tareaSeleccionadaId == -1)
            {
                errores.Add("Selecciona una tarea primero.");
            }

            // 2. Verificar que ya no fue entregada
            if (yaEntrego)
            {
                errores.Add("Esta tarea ya fue entregada. No puedes entregarla nuevamente.");
            }

            // 3. Verificar que hay contenido (archivo o comentario)
            string comentario = txtComentario?.Text.Trim() ?? "";
            if (string.IsNullOrEmpty(comentario) && string.IsNullOrEmpty(archivoSeleccionado))
            {
                errores.Add("Debes añadir un comentario o seleccionar un archivo.");
            }

            // 4. Validar longitud de comentario si existe
            if (!string.IsNullOrEmpty(comentario) && comentario.Length > 1000)
            {
                errores.Add("El comentario no puede exceder 1000 caracteres.");
            }

            // 5. Validar que archivo existe si fue seleccionado
            if (!string.IsNullOrEmpty(archivoSeleccionado) && !File.Exists(archivoSeleccionado))
            {
                errores.Add("El archivo seleccionado no existe o fue removido.");
            }

            // Mostrar todos los errores si hay
            if (errores.Count > 0)
            {
                FormValidator.MostrarErrores(errores);
                return false;
            }

            return true;
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