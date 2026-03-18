using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Presentation.Controls;

namespace Presentation
{
    public partial class FrmLecciones : Form
    {
        // =====================================================
        // CAMPOS PRIVADOS
        // =====================================================
        private DatabaseHelper db = new DatabaseHelper();
        private int studentId = 1; // ID del estudiante actual
        private string connectionString = @"Data Source=JUNIOR\JUNIOR;Initial Catalog=PruebaPolyTalk;Integrated Security=True;TrustServerCertificate=True;";

        // =====================================================
        // CONSTRUCTOR
        // =====================================================
        public FrmLecciones()
        {
            InitializeComponent();

            // Cargar textos en los botones de nivel
            CargarTextosEnBotones();

            // Cargar unidades del nivel A1 por defecto
            if (btnNivelA1.Tag != null)
            {
                CargarUnidades((int)btnNivelA1.Tag);
                lblNivelSeleccionado.Text = btnNivelA1.Text;
            }
        }

        // =====================================================
        // MÉTODO PARA CARGAR TEXTOS EN BOTONES DE NIVEL
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
                        case "A1":
                            btnNivelA1.Text = $"{codigo} - {nombre}";
                            btnNivelA1.Tag = nivelId;
                            break;
                        case "A2":
                            btnNivelA2.Text = $"{codigo} - {nombre}";
                            btnNivelA2.Tag = nivelId;
                            break;
                        case "B1":
                            btnNivelB1.Text = $"{codigo} - {nombre}";
                            btnNivelB1.Tag = nivelId;
                            break;
                        case "B2":
                            btnNivelB2.Text = $"{codigo} - {nombre}";
                            btnNivelB2.Tag = nivelId;
                            break;
                        case "C1":
                            btnNivelC1.Text = $"{codigo} - {nombre}";
                            btnNivelC1.Tag = nivelId;
                            break;
                        case "C2":
                            btnNivelC2.Text = $"{codigo} - {nombre}";
                            btnNivelC2.Tag = nivelId;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar textos de niveles: " + ex.Message);
            }
        }

        // =====================================================
        // EVENTOS DE BOTONES DE NIVEL
        // =====================================================
        private void btnNivelA1_Click(object sender, EventArgs e)
        {
            if (btnNivelA1.Tag != null)
            {
                int nivelId = (int)btnNivelA1.Tag;
                CargarUnidades(nivelId);
                lblNivelSeleccionado.Text = btnNivelA1.Text;
                // Limpiar lecciones al cambiar de nivel
                flpLecciones.Controls.Clear();
                lblLeccionesHeader.Text = "0/0 completados";
            }
        }

        private void btnNivelA2_Click(object sender, EventArgs e)
        {
            if (btnNivelA2.Tag != null)
            {
                int nivelId = (int)btnNivelA2.Tag;
                CargarUnidades(nivelId);
                lblNivelSeleccionado.Text = btnNivelA2.Text;
                flpLecciones.Controls.Clear();
                lblLeccionesHeader.Text = "0/0 completados";
            }
        }

        private void btnNivelB1_Click(object sender, EventArgs e)
        {
            if (btnNivelB1.Tag != null)
            {
                int nivelId = (int)btnNivelB1.Tag;
                CargarUnidades(nivelId);
                lblNivelSeleccionado.Text = btnNivelB1.Text;
                flpLecciones.Controls.Clear();
                lblLeccionesHeader.Text = "0/0 completados";
            }
        }

        private void btnNivelB2_Click(object sender, EventArgs e)
        {
            if (btnNivelB2.Tag != null)
            {
                int nivelId = (int)btnNivelB2.Tag;
                CargarUnidades(nivelId);
                lblNivelSeleccionado.Text = btnNivelB2.Text;
                flpLecciones.Controls.Clear();
                lblLeccionesHeader.Text = "0/0 completados";
            }
        }

        private void btnNivelC1_Click(object sender, EventArgs e)
        {
            if (btnNivelC1.Tag != null)
            {
                int nivelId = (int)btnNivelC1.Tag;
                CargarUnidades(nivelId);
                lblNivelSeleccionado.Text = btnNivelC1.Text;
                flpLecciones.Controls.Clear();
                lblLeccionesHeader.Text = "0/0 completados";
            }
        }

        private void btnNivelC2_Click(object sender, EventArgs e)
        {
            if (btnNivelC2.Tag != null)
            {
                int nivelId = (int)btnNivelC2.Tag;
                CargarUnidades(nivelId);
                lblNivelSeleccionado.Text = btnNivelC2.Text;
                flpLecciones.Controls.Clear();
                lblLeccionesHeader.Text = "0/0 completados";
            }
        }

        // =====================================================
        // CARGAR UNIDADES EN EL FLOWLAYOUTPANEL
        // =====================================================
        private void CargarUnidades(int nivelId)
        {
            try
            {
                // Limpiar el FlowLayoutPanel de unidades
                flpUnidades.Controls.Clear();

                // Obtener unidades desde la BD con progreso
                string query = @"
                    SELECT 
                        u.unit_id,
                        u.unit_number,
                        u.unit_title,
                        COUNT(l.lesson_id) AS total_lecciones,
                        COUNT(lp.lesson_id) AS completadas
                    FROM units u
                    LEFT JOIN lessons l ON u.unit_id = l.unit_id
                    LEFT JOIN lesson_progress lp ON l.lesson_id = lp.lesson_id AND lp.student_id = @studentId
                    WHERE u.level_id = @nivelId AND u.is_active = 1
                    GROUP BY u.unit_id, u.unit_number, u.unit_title
                    ORDER BY u.unit_number";

                DataTable dtUnidades = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@nivelId", nivelId);
                        conn.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dtUnidades);
                    }
                }

                if (dtUnidades.Rows.Count == 0)
                {
                    Label lblSinUnidades = new Label();
                    lblSinUnidades.Text = "No hay unidades disponibles para este nivel";
                    lblSinUnidades.ForeColor = Color.Gray;
                    lblSinUnidades.AutoSize = true;
                    lblSinUnidades.Location = new Point(10, 10);
                    flpUnidades.Controls.Add(lblSinUnidades);
                    return;
                }

                foreach (DataRow row in dtUnidades.Rows)
                {
                    // Crear nueva instancia de UCUnidadesEstudiante
                    UCUnidadesEstudiante ucUnidad = new UCUnidadesEstudiante();

                    int total = Convert.ToInt32(row["total_lecciones"]);
                    int completadas = Convert.ToInt32(row["completadas"]);
                    int porcentaje = total > 0 ? (completadas * 100 / total) : 0;

                    ucUnidad.TituloUnidad = row["unit_title"].ToString();
                    ucUnidad.NumeroUnidad = Convert.ToInt32(row["unit_number"]);
                    ucUnidad.UnidadId = Convert.ToInt32(row["unit_id"]);
                    ucUnidad.Progreso = porcentaje;
                    ucUnidad.Width = flpUnidades.Width - 25;
                    ucUnidad.Height = 80;
                    ucUnidad.Margin = new Padding(5);

                    // 👇 EVENTO PARA CARGAR LECCIONES AL HACER CLIC
                    ucUnidad.UnidadClick += (s, e) =>
                    {
                        UCUnidadesEstudiante unidad = (UCUnidadesEstudiante)s;
                        CargarLecciones(unidad.UnidadId);
                    };

                    flpUnidades.Controls.Add(ucUnidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar unidades: " + ex.Message);
            }
        }

        // =====================================================
        // CARGAR LECCIONES DE UNA UNIDAD EN EL flpLecciones
        // =====================================================
        private void CargarLecciones(int unitId)
        {
            try
            {
                // Limpiar el panel de lecciones
                flpLecciones.Controls.Clear();

                string query = @"
            SELECT 
                l.lesson_id,
                l.lesson_title,
                l.lesson_type,
                CASE WHEN lp.lesson_id IS NOT NULL THEN 1 ELSE 0 END AS completada
            FROM lessons l
            LEFT JOIN lesson_progress lp ON l.lesson_id = lp.lesson_id AND lp.student_id = @studentId
            WHERE l.unit_id = @unitId AND l.is_active = 1
            ORDER BY l.display_order";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@unitId", unitId);
                        conn.Open();

                        int total = 0;
                        int completadas = 0;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                total++;
                                int lessonId = reader.GetInt32(0);
                                string titulo = reader.GetString(1);
                                string tipo = reader.GetString(2);

                                // ✅ CORREGIDO: Convertir INT a BOOL
                                int completadaInt = reader.GetInt32(3);
                                bool completada = completadaInt == 1;

                                if (completada) completadas++;

                                // Crear tarjeta de lección
                                UCLessonCard card = new UCLessonCard();
                                card.SetLessonData(titulo, tipo, completada);
                                card.LessonId = lessonId;
                                card.Width = flpLecciones.Width - 40;
                                card.Margin = new Padding(0, 0, 0, 5);

                                // Evento al hacer clic en la lección
                                card.LessonClicked += (s, id) =>
                                {
                                    if (tipo == "vocabulary")
                                    {
                                        // Aquí abrirás el vocabulario después
                                        MessageBox.Show($"Abrir vocabulario: {titulo}");
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Abriendo lección: {titulo}");
                                    }
                                };

                                flpLecciones.Controls.Add(card);
                            }
                        }

                        // Actualizar el header de lecciones
                        lblLeccionesHeader.Text = $"Lecciones {completadas}/{total} completados";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar lecciones: {ex.Message}");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}