using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Presentation.Helpers;

namespace Presentation.Seccion_de_Estudiantes
{
    public partial class FrmMisCalificaciones : Form
    {
        private int studentId;
        private DatabaseHelper dbHelper;
        private DataTable dtCalificaciones;
        private FrmPrincipal frmPrincipal;

        // Colores PolyTalk
        private readonly Color COLOR_PRIMARY = Color.FromArgb(249, 199, 79);
        private readonly Color COLOR_BACKGROUND = Color.FromArgb(255, 247, 237);
        private readonly Color COLOR_WHITE = Color.White;
        private readonly Color COLOR_DARK = Color.FromArgb(51, 51, 51);
        private readonly Color COLOR_GRAY = Color.FromArgb(130, 120, 100);
        private readonly Color COLOR_SUCCESS = Color.FromArgb(34, 139, 34);
        private readonly Color COLOR_WARNING = Color.FromArgb(210, 126, 30);
        private readonly Color COLOR_DANGER = Color.FromArgb(180, 30, 30);

        public FrmMisCalificaciones(int studentId = -1, FrmPrincipal frmPrincipal = null)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.frmPrincipal = frmPrincipal;
            dbHelper = new DatabaseHelper();
            this.DoubleBuffered = true;
            ConfigurarDiseño();
        }

        private void FrmMisCalificaciones_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCalificaciones();
                ActualizarFecha();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar calificaciones: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDiseño()
        {
            this.BackColor = COLOR_BACKGROUND;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(900, 600);
        }

        private void ActualizarFecha()
        {
            lblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy",
                new System.Globalization.CultureInfo("es-ES"));
        }

        private void CargarCalificaciones()
        {
            try
            {
                string query = @"
                    SELECT
                        ts.submission_id,
                        t.title as 'Tarea',
                        t.description as 'Descripción',
                        ts.submitted_at as 'Fecha Entrega',
                        ts.score as 'Calificación',
                        ts.feedback as 'Feedback',
                        ts.status as 'Estado',
                        ts.graded_at as 'Fecha Calificación'
                    FROM task_submissions ts
                    INNER JOIN tasks t ON ts.task_id = t.task_id
                    WHERE ts.student_id = @studentId
                    ORDER BY ts.submitted_at DESC";

                using (var conn = new System.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    new System.Data.SqlClient.SqlDataAdapter(cmd).Fill(dtCalificaciones ?? (dtCalificaciones = new DataTable()));
                }

                CalcularEstadísticas();
                RenderizarTarjetas();

                if (dtCalificaciones.Rows.Count == 0)
                {
                    lblMensaje.Text = "📭 No tienes calificaciones aún\n\nTus calificaciones aparecerán aquí cuando el maestro las registre.";
                    lblMensaje.Visible = true;
                    flpCalificaciones.Visible = false;
                }
                else
                {
                    lblMensaje.Visible = false;
                    flpCalificaciones.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderizarTarjetas()
        {
            flpCalificaciones.Controls.Clear();

            if (dtCalificaciones == null || dtCalificaciones.Rows.Count == 0) return;

            foreach (DataRow row in dtCalificaciones.Rows)
            {
                // Aplicar filtros
                if (!PasaFiltros(row)) continue;
                flpCalificaciones.Controls.Add(CrearTarjetaCalificacion(row));
            }
        }

        private bool PasaFiltros(DataRow row)
        {
            // Filtro por búsqueda de nombre
            if (!string.IsNullOrWhiteSpace(txtBuscar?.Text))
            {
                string tarea = row["Tarea"]?.ToString() ?? "";
                if (!tarea.ToLower().Contains(txtBuscar.Text.ToLower()))
                    return false;
            }

            // Filtro por estado
            string estado = row["Estado"]?.ToString() ?? "";
            if (cmbEstado?.SelectedItem?.ToString() == "Calificada" && estado != "Graded") return false;
            if (cmbEstado?.SelectedItem?.ToString() == "Pendiente" && estado == "Graded") return false;

            // Filtro por rango de calificación
            if (row["Calificación"] != DBNull.Value && cmbRango?.SelectedItem != null)
            {
                decimal cal = Convert.ToDecimal(row["Calificación"]);
                string rango = cmbRango.SelectedItem.ToString();

                return rango switch
                {
                    "90-100" => cal >= 90,
                    "80-89" => cal >= 80 && cal < 90,
                    "70-79" => cal >= 70 && cal < 80,
                    "60-69" => cal >= 60 && cal < 70,
                    "<60" => cal < 60,
                    "Todas" => true,
                    _ => true
                };
            }

            return true;
        }

        private Guna2Panel CrearTarjetaCalificacion(DataRow row)
        {
            string tarea = row["Tarea"]?.ToString() ?? "";
            DateTime fechaEntrega = row["Fecha Entrega"] != DBNull.Value
                ? Convert.ToDateTime(row["Fecha Entrega"]) : DateTime.Today;
            object calificacionObj = row["Calificación"];
            string feedback = row["Feedback"]?.ToString() ?? "";
            string estado = row["Estado"]?.ToString() ?? "Pending";

            decimal calificacion = calificacionObj != DBNull.Value ? Convert.ToDecimal(calificacionObj) : 0;

            // Determinar colores según calificación y estado
            (Color bgColor, Color accentColor, string estadoTxt) = estado switch
            {
                "Graded" => DeterminarColorPorCalificacion(calificacion),
                _ => (Color.FromArgb(255, 248, 240), Color.FromArgb(255, 183, 0), "⏳ Pendiente")
            };

            var card = new Guna2Panel
            {
                Size = new Size(flpCalificaciones.Width - 30, 95),
                FillColor = bgColor,
                BorderRadius = 10,
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 0, 0, 8)
            };

            card.ShadowDecoration.Enabled = true;
            card.ShadowDecoration.Depth = 3;
            card.ShadowDecoration.Color = Color.FromArgb(10, 0, 0, 0);

            // Barra lateral
            var barre = new Guna2Panel
            {
                Size = new Size(5, 95),
                Location = new Point(0, 0),
                FillColor = accentColor,
                BorderRadius = 0
            };
            card.Controls.Add(barre);

            // Nombre de tarea
            var lblTarea = new Guna2HtmlLabel
            {
                Text = tarea,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = COLOR_DARK,
                Location = new Point(14, 10),
                Size = new Size(450, 22),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblTarea);

            // Fecha de entrega
            var lblFecha = new Guna2HtmlLabel
            {
                Text = $"📅 {fechaEntrega:dd/MM/yyyy}",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = COLOR_GRAY,
                Location = new Point(14, 34),
                Size = new Size(200, 16),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblFecha);

            // Feedback (resumen)
            string feedbackCorto = feedback.Length > 60 ? feedback.Substring(0, 57) + "..." : feedback;
            var lblFeedback = new Guna2HtmlLabel
            {
                Text = string.IsNullOrEmpty(feedback) ? "Sin comentarios" : $"💬 {feedbackCorto}",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(150, 140, 120),
                Location = new Point(14, 52),
                Size = new Size(450, 16),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblFeedback);

            // Calificación/Estado (lado derecho)
            var lblCalif = new Guna2HtmlLabel
            {
                Text = estado == "Graded" ? $"⭐ {calificacion:F1}/100" : estadoTxt,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = accentColor,
                Location = new Point(card.Width - 110, 15),
                Size = new Size(100, 30),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblCalif);

            // Badge de estado
            var badgeText = estado == "Graded" ? "✓ Calificada" : "⏳ Pendiente";
            var lblEstado = new Guna2HtmlLabel
            {
                Text = badgeText,
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                ForeColor = accentColor,
                Location = new Point(card.Width - 110, 50),
                Size = new Size(100, 14),
                AutoSize = false,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblEstado);

            // Hover effect
            card.MouseEnter += (s, e) =>
            {
                card.FillColor = Color.FromArgb(
                    Math.Max(0, bgColor.R - 15),
                    Math.Max(0, bgColor.G - 15),
                    Math.Max(0, bgColor.B - 15));
                card.ShadowDecoration.Depth = 6;
            };
            card.MouseLeave += (s, e) =>
            {
                card.FillColor = bgColor;
                card.ShadowDecoration.Depth = 3;
            };

            // Click para ver detalles
            card.Click += (s, e) => MostrarDetalles(tarea, calificacion, feedback, estado);
            foreach (Control c in card.Controls) c.Click += (s, e) => MostrarDetalles(tarea, calificacion, feedback, estado);

            return card;
        }

        private (Color bgColor, Color accentColor, string estado) DeterminarColorPorCalificacion(decimal calificacion)
        {
            return calificacion switch
            {
                >= 90 => (Color.FromArgb(235, 252, 240), Color.FromArgb(34, 139, 34), "✓ Excelente"),
                >= 80 => (Color.FromArgb(235, 245, 255), Color.FromArgb(66, 153, 225), "✓ Muy Bien"),
                >= 70 => (Color.FromArgb(255, 248, 235), Color.FromArgb(255, 183, 0), "✓ Bien"),
                >= 60 => (Color.FromArgb(255, 245, 240), Color.FromArgb(210, 126, 30), "⚠ Necesita Mejorar"),
                _ => (Color.FromArgb(255, 240, 240), Color.FromArgb(180, 30, 30), "✗ Reprobada")
            };
        }

        private void MostrarDetalles(string tarea, decimal calificacion, string feedback, string estado)
        {
            string mensaje = $"📝 {tarea}\n\n";

            if (estado == "Graded")
            {
                mensaje += $"⭐ Calificación: {calificacion:F1}/100\n\n";
                var (_, _, estadoTexto) = DeterminarColorPorCalificacion(calificacion);
                mensaje += $"Estado: {estadoTexto}\n\n";
            }
            else
            {
                mensaje += "⏳ Esta tarea aún no ha sido calificada\n\n";
            }

            if (!string.IsNullOrEmpty(feedback))
                mensaje += $"💬 Comentarios del maestro:\n{feedback}";
            else
                mensaje += "El maestro no ha dejado comentarios";

            MessageBox.Show(mensaje, "Detalles de Calificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CalcularEstadísticas()
        {
            if (dtCalificaciones == null || dtCalificaciones.Rows.Count == 0)
            {
                lblTotal.Text = "0";
                lblCalificadas.Text = "0";
                lblPromedio.Text = "0.0";
                return;
            }

            int total = dtCalificaciones.Rows.Count;
            int calificadas = 0;
            decimal suma = 0;
            decimal promedio = 0;

            foreach (DataRow row in dtCalificaciones.Rows)
            {
                if (row["Calificación"] != DBNull.Value && row["Estado"].ToString() == "Graded")
                {
                    calificadas++;
                    suma += Convert.ToDecimal(row["Calificación"]);
                }
            }

            if (calificadas > 0)
                promedio = suma / calificadas;

            lblTotal.Text = total.ToString();
            lblCalificadas.Text = calificadas.ToString();
            lblPromedio.Text = promedio.ToString("0.0");

            // Actualizar progreso
            pbarProgreso.Maximum = total;
            pbarProgreso.Value = calificadas;
        }
    }
}
