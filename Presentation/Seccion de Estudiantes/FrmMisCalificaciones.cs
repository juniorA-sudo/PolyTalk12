using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Presentation.Helpers;

namespace Presentation.Seccion_de_Estudiantes
{
    public partial class FrmMisCalificaciones : Form
    {
        private int studentId;
        private DatabaseHelper dbHelper;
        private DataTable dtCalificaciones;

        // Colores PolyTalk
        private readonly Color COLOR_PRIMARY = Color.FromArgb(249, 199, 79);
        private readonly Color COLOR_BACKGROUND = Color.FromArgb(255, 247, 237);
        private readonly Color COLOR_WHITE = Color.White;
        private readonly Color COLOR_DARK = Color.FromArgb(51, 51, 51);
        private readonly Color COLOR_GRAY = Color.FromArgb(130, 120, 100);
        private readonly Color COLOR_SUCCESS = Color.FromArgb(34, 139, 34);
        private readonly Color COLOR_WARNING = Color.FromArgb(210, 126, 30);
        private readonly Color COLOR_DANGER = Color.FromArgb(180, 30, 30);

        public FrmMisCalificaciones(int studentId = -1)
        {
            InitializeComponent();
            this.studentId = studentId;
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

                ConfigurarDataGrid();
                CalcularEstadísticas();

                if (dtCalificaciones.Rows.Count == 0)
                {
                    lblMensaje.Text = "📭 No tienes calificaciones aún\n\nTus calificaciones aparecerán aquí cuando el maestro las registre.";
                    lblMensaje.Visible = true;
                    dgvCalificaciones.Visible = false;
                }
                else
                {
                    lblMensaje.Visible = false;
                    dgvCalificaciones.Visible = true;
                    dgvCalificaciones.DataSource = dtCalificaciones;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGrid()
        {
            dgvCalificaciones.AutoGenerateColumns = false;
            dgvCalificaciones.AllowUserToAddRows = false;
            dgvCalificaciones.AllowUserToDeleteRows = false;
            dgvCalificaciones.ReadOnly = true;
            dgvCalificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCalificaciones.BackgroundColor = COLOR_WHITE;
            dgvCalificaciones.BorderStyle = BorderStyle.None;
            dgvCalificaciones.ColumnHeadersHeight = 35;

            dgvCalificaciones.Columns.Clear();

            var colTarea = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Tarea",
                HeaderText = "📝 Tarea",
                Width = 200,
                DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 9F) }
            };
            dgvCalificaciones.Columns.Add(colTarea);

            var colFechaEntrega = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fecha Entrega",
                HeaderText = "📅 Entrega",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy HH:mm",
                    Font = new Font("Segoe UI", 8.5F)
                }
            };
            dgvCalificaciones.Columns.Add(colFechaEntrega);

            var colCalificacion = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Calificación",
                HeaderText = "⭐ Calificación",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "0",
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold)
                }
            };
            dgvCalificaciones.Columns.Add(colCalificacion);

            var colEstado = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "✓ Estado",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 8.5F)
                }
            };
            dgvCalificaciones.Columns.Add(colEstado);

            var colFeedback = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Feedback",
                HeaderText = "💬 Feedback",
                Width = 250,
                DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 8F) }
            };
            dgvCalificaciones.Columns.Add(colFeedback);

            dgvCalificaciones.RowTemplate.Height = 50;
            dgvCalificaciones.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = COLOR_PRIMARY,
                ForeColor = COLOR_DARK,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
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

        private void dgvCalificaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCalificaciones.Rows[e.RowIndex];
                string tarea = row.Cells["Tarea"].Value?.ToString() ?? "";
                string feedback = row.Cells["Feedback"].Value?.ToString() ?? "";
                object calificacion = row.Cells["Calificación"].Value;

                string mensaje = $"📝 Tarea: {tarea}\n\n";
                if (calificacion != null && calificacion != DBNull.Value)
                {
                    mensaje += $"⭐ Calificación: {calificacion}/100\n\n";
                }
                else
                {
                    mensaje += "⏳ Aún no calificada\n\n";
                }
                mensaje += $"💬 Feedback:\n{feedback}";

                MessageBox.Show(mensaje, "Detalles de Calificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
