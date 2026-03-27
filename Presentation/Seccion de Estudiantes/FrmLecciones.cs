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
        private FrmPrincipal frmPrincipal;
        private Guna.UI2.WinForms.Guna2Button btnNivelActivo;
        private string connectionString = ConfigurationHelper.GetConnectionString();

        // ── Constructores ───────────────────────────────────────
        public FrmLecciones(int studentId, FrmPrincipal frmPrincipal = null)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.frmPrincipal = frmPrincipal;
            CargarTextosEnBotones();
            ActivarBotonNivel(btnNivelA1);
            CargarUltimaUnidad(); // ✅ carga donde se quedó
        }

        public FrmLecciones()
        {
            InitializeComponent();
            this.studentId = 1;
            CargarTextosEnBotones();
            ActivarBotonNivel(btnNivelA1);
            if (btnNivelA1.Tag != null)
            {
                CargarUnidades((int)btnNivelA1.Tag);
                lblNivelSeleccionado.Text = "Unidades A1";
                lblSeleccionaUnidad.Visible = true;
            }
        }

        // =====================================================
        // ✅ CARGAR ÚLTIMA UNIDAD VISITADA
        // =====================================================
        private void CargarUltimaUnidad()
        {
            try
            {
                // Buscar la última lección en progreso del estudiante
                string query = @"
                    SELECT TOP 1
                        u.unit_id,
                        u.unit_number,
                        u.unit_title,
                        lv.level_id,
                        lv.level_code
                    FROM lesson_progress lp
                    INNER JOIN lessons l      ON lp.lesson_id = l.lesson_id
                    INNER JOIN units u        ON l.unit_id    = u.unit_id
                    INNER JOIN levels lv      ON u.level_id   = lv.level_id
                    WHERE lp.student_id = @studentId
                    ORDER BY lp.started_at DESC";

                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                conn.Open();
                using var r = cmd.ExecuteReader();

                if (r.Read())
                {
                    int unitId = r.GetInt32(0);
                    int unitNum = r.GetInt32(1);
                    string unitTitle = r.GetString(2);
                    int levelId = r.GetInt32(3);
                    string levelCode = r.GetString(4);

                    // Activar el botón del nivel correcto
                    ActivarBotonPorCodigo(levelCode);

                    // Cargar unidades del nivel y marcar la unidad activa
                    CargarUnidades(levelId);
                    lblNivelSeleccionado.Text = $"Unidades {levelCode}";

                    // Cargar directamente las lecciones de esa unidad
                    CargarLecciones(unitId);
                    lblSeleccionaUnidad.Visible = false;

                    // Mostrar banner de "continuando donde te quedaste"
                    MostrarBannerContinuar(levelCode, unitTitle);
                }
                else
                {
                    // Primera vez — cargar A1 por defecto
                    if (btnNivelA1.Tag != null)
                    {
                        CargarUnidades((int)btnNivelA1.Tag);
                        lblNivelSeleccionado.Text = "Unidades A1";
                        lblSeleccionaUnidad.Visible = true;
                    }
                }
            }
            catch
            {
                // Fallback a A1
                if (btnNivelA1.Tag != null)
                {
                    CargarUnidades((int)btnNivelA1.Tag);
                    lblNivelSeleccionado.Text = "Unidades A1";
                    lblSeleccionaUnidad.Visible = true;
                }
            }
        }

        private void ActivarBotonPorCodigo(string codigo)
        {
            var btn = codigo switch
            {
                "A1" => btnNivelA1,
                "A2" => btnNivelA2,
                "B1" => btnNivelB1,
                "B2" => btnNivelB2,
                "C1" => btnNivelC1,
                "C2" => btnNivelC2,
                _ => btnNivelA1
            };
            ActivarBotonNivel(btn);
        }

        private void MostrarBannerContinuar(string nivel, string unidad)
        {
            // Banner sutil en la parte de arriba del panel de lecciones
            var banner = new Guna.UI2.WinForms.Guna2HtmlLabel
            {
                Text = $"▶ Continuando desde {nivel} · {unidad}",
                Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(160, 100, 0),
                BackColor = System.Drawing.Color.FromArgb(255, 240, 200),
                AutoSize = false,
                Size = new System.Drawing.Size(flpLecciones.Width - 20, 26),
                TextAlignment = System.Drawing.ContentAlignment.MiddleLeft,
                Margin = new System.Windows.Forms.Padding(0, 0, 0, 6)
            };
            flpLecciones.Controls.Add(banner);
            flpLecciones.Controls.SetChildIndex(banner, 0); // al inicio
        }

        // =====================================================
        // ACTIVAR BOTÓN NIVEL
        // =====================================================
        private void ActivarBotonNivel(Guna.UI2.WinForms.Guna2Button btn)
        {
            foreach (var b in new[] { btnNivelA1, btnNivelA2, btnNivelB1, btnNivelB2, btnNivelC1, btnNivelC2 })
            {
                b.FillColor = Color.FromArgb(240, 237, 230);
                b.ForeColor = Color.FromArgb(130, 120, 100);
                b.ShadowDecoration.Enabled = false;
            }
            btn.FillColor = Color.FromArgb(255, 60, 120);
            btn.ForeColor = Color.White;
            btn.ShadowDecoration.Enabled = true;
            btn.ShadowDecoration.Depth = 5;
            btn.ShadowDecoration.Color = Color.FromArgb(40, 255, 60, 120);
            btnNivelActivo = btn;
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
                    int nivelId = Convert.ToInt32(row["level_id"]);
                    switch (codigo)
                    {
                        case "A1": btnNivelA1.Text = codigo; btnNivelA1.Tag = nivelId; break;
                        case "A2": btnNivelA2.Text = codigo; btnNivelA2.Tag = nivelId; break;
                        case "B1": btnNivelB1.Text = codigo; btnNivelB1.Tag = nivelId; break;
                        case "B2": btnNivelB2.Text = codigo; btnNivelB2.Tag = nivelId; break;
                        case "C1": btnNivelC1.Text = codigo; btnNivelC1.Tag = nivelId; break;
                        case "C2": btnNivelC2.Text = codigo; btnNivelC2.Tag = nivelId; break;
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

                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                conn.Open();
                using var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    int total = r.GetInt32(0);
                    int completadas = r.GetInt32(1);
                    int pct = total > 0 ? completadas * 100 / total : 0;
                    guna2ProgressBar1.Value = pct;
                    lblPorcentajeGrande.Text = $"{pct}%";
                    guna2HtmlLabel7.Text = $"{completadas} de {total} lecciones completadas";
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
            ActivarBotonNivel(btn);
            CargarUnidades((int)btn.Tag);
            lblNivelSeleccionado.Text = $"Unidades {btn.Text}";
            flpLecciones.Controls.Clear();
            lblLeccionesHeader.Text = "0/0 lecciones completadas";
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
                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@nivelId", nivelId);
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    flpUnidades.Controls.Add(new Label
                    {
                        Text = "Sin unidades",
                        ForeColor = Color.FromArgb(180, 170, 150),
                        Font = new Font("Segoe UI", 9F),
                        AutoSize = true,
                        Margin = new Padding(8)
                    });
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
                        Width = flpUnidades.Width - 10,
                        Height = 68,
                        Margin = new Padding(3, 3, 3, 4)
                    };
                    uc.UnidadClick += (s, e) =>
                    {
                        CargarLecciones(((UCUnidadesEstudiante)s).UnidadId);
                        lblSeleccionaUnidad.Visible = false;
                    };
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
                using var conn = new SqlConnection(connectionString);
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@unitId", unitId);
                conn.Open();
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    total++;
                    int lessonId = r.GetInt32(0);
                    string titulo = r.GetString(1);
                    string tipo = r.GetString(2);
                    bool completada = r.GetInt32(3) == 1;
                    if (completada) completadas++;

                    UCLessonCard card = new UCLessonCard();
                    card.SetLessonData(titulo, tipo, completada);
                    card.LessonId = lessonId;
                    card.Width = flpLecciones.Width - 20;
                    card.Margin = new Padding(0, 0, 0, 8);

                    card.LessonClicked += (s, id) =>
                    {
                        if (frmPrincipal != null)
                        {
                            var frm = new FrmVerLeccion(id, studentId, frmPrincipal);
                            frmPrincipal.AbrirFormEnPanel(frm);
                        }
                        else
                        {
                            using var frm = new FrmVerLeccion(id, studentId);
                            frm.StartPosition = FormStartPosition.CenterParent;
                            frm.ShowDialog();
                            CargarLecciones(unitId);
                            ActualizarProgresoGeneral();
                        }
                    };
                    flpLecciones.Controls.Add(card);
                }

                lblLeccionesHeader.Text = $"{completadas}/{total} lecciones completadas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar lecciones: {ex.Message}");
            }
        }

        private void guna2Panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
    }
}