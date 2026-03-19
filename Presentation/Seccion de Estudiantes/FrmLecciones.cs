using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Presentation.Controls;

namespace Presentation
{
    public partial class FrmLecciones : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int studentId;
        private string connectionString = @"Data Source=JUNIOR\JUNIOR;Initial Catalog=PruebaPolyTalk;Integrated Security=True;TrustServerCertificate=True;";

        // ✅ Constructor con studentId
        public FrmLecciones(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            CargarTextosEnBotones();
            if (btnNivelA1.Tag != null)
            {
                CargarUnidades((int)btnNivelA1.Tag);
                lblNivelSeleccionado.Text = "Unidades — A1";
                lblSeleccionaUnidad.Visible = true;
            }
        }

        public FrmLecciones()
        {
            InitializeComponent();
            this.studentId = 1;
            CargarTextosEnBotones();
            if (btnNivelA1.Tag != null)
            {
                CargarUnidades((int)btnNivelA1.Tag);
                lblNivelSeleccionado.Text = "Unidades — A1";
                lblSeleccionaUnidad.Visible = true;
            }
        }

        // =====================================================
        // NIVELES
        // =====================================================
        private void CargarTextosEnBotones()
        {
            try
            {
                DataTable dtNiveles = db.ObtenerNiveles();
                foreach (DataRow row in dtNiveles.Rows)
                {
                    string codigo = row["level_code"].ToString();
                    string nombre = row["level_name"].ToString();
                    int nivelId = Convert.ToInt32(row["level_id"]);

                    switch (codigo)
                    {
                        case "A1": btnNivelA1.Text = $"{codigo} - {nombre}"; btnNivelA1.Tag = nivelId; break;
                        case "A2": btnNivelA2.Text = $"{codigo} - {nombre}"; btnNivelA2.Tag = nivelId; break;
                        case "B1": btnNivelB1.Text = $"{codigo} - {nombre}"; btnNivelB1.Tag = nivelId; break;
                        case "B2": btnNivelB2.Text = $"{codigo} - {nombre}"; btnNivelB2.Tag = nivelId; break;
                        case "C1": btnNivelC1.Text = $"{codigo} - {nombre}"; btnNivelC1.Tag = nivelId; break;
                        case "C2": btnNivelC2.Text = $"{codigo} - {nombre}"; btnNivelC2.Tag = nivelId; break;
                    }
                }
                ActualizarProgresoGeneral();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar niveles: " + ex.Message);
            }
        }

        private void ActualizarProgresoGeneral()
        {
            try
            {
                string query = @"
                    SELECT COUNT(DISTINCT l.lesson_id) AS total,
                           COUNT(DISTINCT lp.lesson_id) AS completadas
                    FROM lessons l
                    LEFT JOIN lesson_progress lp ON l.lesson_id = lp.lesson_id
                        AND lp.student_id = @studentId
                    WHERE l.is_active = 1";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            int total = r.GetInt32(0);
                            int completadas = r.GetInt32(1);
                            int pct = total > 0 ? completadas * 100 / total : 0;
                            guna2ProgressBar1.Value = pct;
                            guna2HtmlLabel7.Text = $"{pct}% completado";
                        }
                    }
                }
            }
            catch { }
        }

        // =====================================================
        // BOTONES DE NIVEL
        // =====================================================
        private void CambiarNivel(Guna.UI2.WinForms.Guna2Button btn)
        {
            if (btn.Tag == null) return;
            CargarUnidades((int)btn.Tag);
            lblNivelSeleccionado.Text = $"Unidades — {btn.Text.Split('-')[0].Trim()}";
            flpLecciones.Controls.Clear();
            lblLeccionesHeader.Text = "0/0 completados";
            lblSeleccionaUnidad.Visible = true;
        }

        private void btnNivelA1_Click(object sender, EventArgs e) => CambiarNivel(btnNivelA1);
        private void btnNivelA2_Click(object sender, EventArgs e) => CambiarNivel(btnNivelA2);
        private void btnNivelB1_Click(object sender, EventArgs e) => CambiarNivel(btnNivelB1);
        private void btnNivelB2_Click(object sender, EventArgs e) => CambiarNivel(btnNivelB2);
        private void btnNivelC1_Click(object sender, EventArgs e) => CambiarNivel(btnNivelC1);
        private void btnNivelC2_Click(object sender, EventArgs e) => CambiarNivel(btnNivelC2);

        // =====================================================
        // UNIDADES
        // =====================================================
        private void CargarUnidades(int nivelId)
        {
            try
            {
                flpUnidades.Controls.Clear();

                string query = @"
                    SELECT u.unit_id, u.unit_number, u.unit_title,
                           COUNT(l.lesson_id) AS total_lecciones,
                           COUNT(lp.lesson_id) AS completadas
                    FROM units u
                    LEFT JOIN lessons l ON u.unit_id = l.unit_id AND l.is_active = 1
                    LEFT JOIN lesson_progress lp ON l.lesson_id = lp.lesson_id
                        AND lp.student_id = @studentId
                    WHERE u.level_id = @nivelId AND u.is_active = 1
                    GROUP BY u.unit_id, u.unit_number, u.unit_title
                    ORDER BY u.unit_number";

                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.Parameters.AddWithValue("@nivelId", nivelId);
                    conn.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }

                if (dt.Rows.Count == 0)
                {
                    Label lbl = new Label
                    {
                        Text = "Sin unidades disponibles",
                        ForeColor = Color.Gray,
                        AutoSize = true
                    };
                    flpUnidades.Controls.Add(lbl);
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    int total = Convert.ToInt32(row["total_lecciones"]);
                    int completadas = Convert.ToInt32(row["completadas"]);
                    int pct = total > 0 ? completadas * 100 / total : 0;

                    UCUnidadesEstudiante uc = new UCUnidadesEstudiante
                    {
                        TituloUnidad = row["unit_title"].ToString(),
                        NumeroUnidad = Convert.ToInt32(row["unit_number"]),
                        UnidadId = Convert.ToInt32(row["unit_id"]),
                        Progreso = pct,
                        Width = flpUnidades.Width - 25,
                        Height = 80,
                        Margin = new Padding(5)
                    };

                    uc.UnidadClick += (s, e) => CargarLecciones(((UCUnidadesEstudiante)s).UnidadId);
                    flpUnidades.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar unidades: " + ex.Message);
            }
        }

        // =====================================================
        // LECCIONES
        // =====================================================
        private void CargarLecciones(int unitId)
        {
            try
            {
                flpLecciones.Controls.Clear();
                lblSeleccionaUnidad.Visible = false;

                string query = @"
                    SELECT l.lesson_id, l.lesson_title, l.lesson_type,
                           CASE WHEN lp.completed_at IS NOT NULL THEN 1 ELSE 0 END AS completada,
                           ISNULL(lp.score, 0) AS score
                    FROM lessons l
                    LEFT JOIN lesson_progress lp ON l.lesson_id = lp.lesson_id
                        AND lp.student_id = @studentId
                    WHERE l.unit_id = @unitId AND l.is_active = 1
                    ORDER BY l.display_order";

                int total = 0, completadas = 0;

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.Parameters.AddWithValue("@unitId", unitId);
                    conn.Open();

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            total++;
                            int lessonId = r.GetInt32(0);
                            string titulo = r.GetString(1);
                            string tipo = r.GetString(2);
                            bool completada = r.GetInt32(3) == 1;
                            decimal score = r.GetDecimal(4);

                            if (completada) completadas++;

                            UCLessonCard card = new UCLessonCard();
                            card.SetLessonData(titulo, tipo, completada);
                            card.LessonId = lessonId;
                            card.Width = flpLecciones.Width - 40;
                            card.Margin = new Padding(0, 0, 0, 5);

                            // ✅ Abrir FrmVerLeccion al hacer clic
                            card.LessonClicked += (s, id) =>
                            {
                                FrmVerLeccion frm = new FrmVerLeccion(id, studentId);
                                frm.StartPosition = FormStartPosition.CenterParent;
                                frm.ShowDialog();
                                // Recargar lecciones para actualizar progreso
                                CargarLecciones(unitId);
                                ActualizarProgresoGeneral();
                            };

                            flpLecciones.Controls.Add(card);
                        }
                    }
                }

                lblLeccionesHeader.Text = $"Lecciones {completadas}/{total} completados";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar lecciones: {ex.Message}");
            }
        }

        private void guna2Panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
    }
}