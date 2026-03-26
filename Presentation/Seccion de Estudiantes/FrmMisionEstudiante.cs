using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentation
{
    public partial class FrmMisionEstudiante : Form
    {
        private FrmPrincipal _principalForm;
        private int _studentId;
        private string _nombreEstudiante = "Estudiante";
        private DatabaseHelper db = new DatabaseHelper();

        public FrmMisionEstudiante(FrmPrincipal principalForm)
        {
            InitializeComponent();
            _principalForm = principalForm;
        }

        public FrmMisionEstudiante(FrmPrincipal principalForm, int studentId) : this(principalForm)
        {
            _studentId = studentId;
        }

        private void FrmMisionEstudiante_Load(object sender, EventArgs e)
        {
            CargarDatosEstudiante();
            CargarEstadisticas();
            CargarTareasPendientes();
            CargarUltimaLeccion();
        }

        // =====================================================
        // CARGAR DATOS DEL ESTUDIANTE
        // =====================================================
        private void CargarDatosEstudiante()
        {
            try
            {
                string query = @"
                    SELECT u.username AS nombre
                    FROM students s
                    INNER JOIN users u ON s.user_id = u.user_id
                    WHERE s.student_id = @studentId";

                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", _studentId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _nombreEstudiante = reader["nombre"].ToString();
                        }
                    }
                }

                if (lblNombreEstudiante != null)
                    lblNombreEstudiante.Text = $"¡Hola, {_nombreEstudiante}!";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error cargando estudiante: {ex.Message}");
                if (lblNombreEstudiante != null)
                    lblNombreEstudiante.Text = "¡Hola, Estudiante!";
            }
        }

        // =====================================================
        // ESTADISTICAS DEL ESTUDIANTE
        // =====================================================
        private void CargarEstadisticas()
        {
            try
            {
                // Lecciones completadas
                try
                {
                    string queryLecciones = @"
                        SELECT COUNT(DISTINCT lp.lesson_id) AS completadas,
                               (SELECT COUNT(*) FROM lessons WHERE is_active = 1) AS total
                        FROM lesson_progress lp
                        WHERE lp.student_id = @studentId AND lp.completed_at IS NOT NULL";

                    using (var conn = new SqlConnection(db.ConnectionString))
                    using (var cmd = new SqlCommand(queryLecciones, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", _studentId);
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int completadas = reader["completadas"] != DBNull.Value ? Convert.ToInt32(reader["completadas"]) : 0;
                                int total = reader["total"] != DBNull.Value ? Convert.ToInt32(reader["total"]) : 1;
                                int porcentaje = total > 0 ? (completadas * 100 / total) : 0;

                                if (lblLeccionesCompletadas != null)
                                    lblLeccionesCompletadas.Text = $"{completadas} de {total} lecciones";
                                if (progressBarLecciones != null)
                                    progressBarLecciones.Value = Math.Min(porcentaje, 100);
                                if (lblPorcentajeLecciones != null)
                                    lblPorcentajeLecciones.Text = $"{porcentaje}%";
                            }
                        }
                    }
                }
                catch { }

                // Racha de días
                try
                {
                    string queryRacha = @"
                        SELECT COUNT(DISTINCT CAST(lp.completed_at AS DATE)) AS dias
                        FROM lesson_progress lp
                        WHERE lp.student_id = @studentId
                        AND lp.completed_at >= DATEADD(DAY, -30, GETDATE())";

                    using (var conn = new SqlConnection(db.ConnectionString))
                    using (var cmd = new SqlCommand(queryRacha, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", _studentId);
                        conn.Open();
                        var result = cmd.ExecuteScalar();
                        int dias = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        if (lblRachaDias != null)
                            lblRachaDias.Text = $"{dias} días";
                        if (lblRachaDiasStat != null)
                            lblRachaDiasStat.Text = $"{dias} días";
                    }
                }
                catch { }

                // XP total
                try
                {
                    string queryXP = @"
                        SELECT ISNULL(SUM(CAST(lp.score AS INT)), 0) AS total_xp
                        FROM lesson_progress lp
                        WHERE lp.student_id = @studentId";

                    using (var conn = new SqlConnection(db.ConnectionString))
                    using (var cmd = new SqlCommand(queryXP, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", _studentId);
                        conn.Open();
                        var result = cmd.ExecuteScalar();
                        int xp = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        if (lblXP != null)
                            lblXP.Text = $"⭐ {xp} XP";
                    }
                }
                catch { }

                // Palabras de vocabulario
                try
                {
                    string queryVocab = @"
                        SELECT COUNT(DISTINCT wv.word_id) AS palabras
                        FROM word_progress wv
                        WHERE wv.student_id = @studentId AND wv.mastery_level >= 3";

                    using (var conn = new SqlConnection(db.ConnectionString))
                    using (var cmd = new SqlCommand(queryVocab, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", _studentId);
                        conn.Open();
                        var result = cmd.ExecuteScalar();
                        int palabras = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        if (lblVocabulario != null)
                            lblVocabulario.Text = $"{palabras} palabras";
                    }
                }
                catch { }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error estadísticas: {ex.Message}");
            }
        }

        // =====================================================
        // TAREAS PENDIENTES
        // =====================================================
        private void CargarTareasPendientes()
        {
            try
            {
                if (flpTareasPendientes == null) return;
                flpTareasPendientes.Controls.Clear();

                string query = @"
                    SELECT TOP 3 t.task_id, t.title, t.due_date,
                           DATEDIFF(DAY, GETDATE(), t.due_date) AS dias_restantes
                    FROM tasks t
                    WHERE t.due_date >= GETDATE()
                    AND t.status = 'Active'
                    AND NOT EXISTS (
                        SELECT 1 FROM task_submissions ts
                        WHERE ts.task_id = t.task_id AND ts.student_id = @studentId
                    )
                    ORDER BY t.due_date ASC";

                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", _studentId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        bool hayTareas = false;
                        while (reader.Read())
                        {
                            hayTareas = true;
                            string titulo = reader["title"].ToString();
                            int diasRestantes = Convert.ToInt32(reader["dias_restantes"]);

                            var panelTarea = CrearPanelTarea(titulo, diasRestantes);
                            flpTareasPendientes.Controls.Add(panelTarea);
                        }

                        if (!hayTareas)
                        {
                            var lblSinTareas = new Label
                            {
                                Text = "¡No tienes tareas pendientes!",
                                ForeColor = Color.FromArgb(34, 197, 94),
                                Font = new Font("Segoe UI", 10F),
                                AutoSize = true
                            };
                            flpTareasPendientes.Controls.Add(lblSinTareas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error tareas: {ex.Message}");
            }
        }

        private Panel CrearPanelTarea(string titulo, int diasRestantes)
        {
            var panel = new Panel
            {
                Width = flpTareasPendientes?.Width > 0 ? flpTareasPendientes.Width - 20 : 400,
                Height = 50,
                BackColor = diasRestantes <= 1 ? Color.FromArgb(254, 226, 226) :
                             diasRestantes <= 3 ? Color.FromArgb(254, 243, 199) :
                             Color.FromArgb(220, 252, 231),
                Margin = new Padding(0, 0, 0, 5)
            };

            var lblTitulo = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(10, 8),
                AutoSize = true
            };

            var lblDias = new Label
            {
                Text = diasRestantes == 0 ? "¡Hoy!" :
                       diasRestantes == 1 ? "Mañana" :
                       $"{diasRestantes} días",
                Font = new Font("Segoe UI", 8F),
                ForeColor = diasRestantes <= 1 ? Color.FromArgb(153, 27, 27) :
                             diasRestantes <= 3 ? Color.FromArgb(146, 64, 14) :
                             Color.FromArgb(22, 101, 52),
                Location = new Point(10, 28),
                AutoSize = true
            };

            panel.Controls.Add(lblTitulo);
            panel.Controls.Add(lblDias);
            panel.Cursor = Cursors.Hand;

            panel.Click += (s, e) =>
            {
                if (_principalForm != null)
                {
                    _principalForm.AbrirFormEnPanel(new Seccion_de_Estudiantes.FrmTareasEstudiante(_studentId));
                }
            };

            return panel;
        }

        // =====================================================
        // ULTIMA LECCION
        // =====================================================
        private void CargarUltimaLeccion()
        {
            try
            {
                string query = @"
                    SELECT TOP 1 l.lesson_id, l.lesson_title, u.unit_title,
                           lp.completed_at
                    FROM lesson_progress lp
                    INNER JOIN lessons l ON lp.lesson_id = l.lesson_id
                    INNER JOIN units u ON l.unit_id = u.unit_id
                    WHERE lp.student_id = @studentId
                    ORDER BY lp.started_at DESC";

                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", _studentId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string titulo = reader["lesson_title"].ToString();
                            string unidad = reader["unit_title"].ToString();
                            bool completada = reader["completed_at"] != DBNull.Value;

                            if (btnContinuarLeccion != null)
                            {
                                btnContinuarLeccion.Text = completada ? $"✓ {titulo}" : $"▶ Continuar: {titulo}";
                                btnContinuarLeccion.Tag = reader["lesson_id"];
                            }

                            if (lblUltimaLeccion != null)
                                lblUltimaLeccion.Text = unidad;
                        }
                        else
                        {
                            if (btnContinuarLeccion != null)
                                btnContinuarLeccion.Text = "▶ Empezar tu primera lección";
                            if (lblUltimaLeccion != null)
                                lblUltimaLeccion.Text = "Introducción";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error última lección: {ex.Message}");
            }
        }

        // =====================================================
        // EVENTOS DE BOTONES
        // =====================================================
        private void btnContinuarLeccion_Click(object sender, EventArgs e)
        {
            if (_principalForm != null)
            {
                _principalForm.AbrirFormEnPanel(new FrmLecciones(_studentId));
            }
        }

        private void btnLeccionesRapido_Click(object sender, EventArgs e)
        {
            if (_principalForm != null)
            {
                _principalForm.AbrirFormEnPanel(new FrmLecciones(_studentId));
            }
        }

        private void btnVocabularioRapido_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT user_id FROM students WHERE student_id = @studentId";
                using (var conn = new SqlConnection(db.ConnectionString))
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", _studentId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    int userId = result != null ? Convert.ToInt32(result) : _studentId;

                    if (_principalForm != null)
                    {
                        _principalForm.AbrirFormEnPanel(new Seccion_de_Estudiantes.FrmVocabulario(userId));
                    }
                }
            }
            catch
            {
                if (_principalForm != null)
                {
                    _principalForm.AbrirFormEnPanel(new Seccion_de_Estudiantes.FrmVocabulario(_studentId));
                }
            }
        }

        private void btnTareasRapido_Click(object sender, EventArgs e)
        {
            if (_principalForm != null)
            {
                _principalForm.AbrirFormEnPanel(new Seccion_de_Estudiantes.FrmTareasEstudiante(_studentId));
            }
        }

        private void FrmMisionEstudiante_Load_1(object sender, EventArgs e)
        {
            // Este evento ya está cubierto por FrmMisionEstudiante_Load
        }
    }
}