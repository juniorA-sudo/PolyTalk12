using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Presentation.Helpers;

namespace Presentation.Seccion_de_Estudiantes
{
    public partial class FrmDashboardEstudiante : Form
    {
        private DatabaseHelper dbHelper;
        private int studentId;

        public FrmDashboardEstudiante(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            dbHelper = new DatabaseHelper();
            ConfigurarDiseño();
        }

        private void FrmDashboardEstudiante_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
        }

        private void ConfigurarDiseño()
        {
            this.BackColor = Color.FromArgb(255, 247, 237);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = "📊 Mi Dashboard";
        }

        private void CargarEstadisticas()
        {
            try
            {
                // Crear panels para estadísticas
                this.Controls.Clear();

                var panelHeader = new Guna2Panel
                {
                    Dock = DockStyle.Top,
                    Height = 60,
                    FillColor = Color.White,
                    BorderRadius = 0
                };
                var lblTitulo = new Guna2HtmlLabel
                {
                    Text = "📊 Dashboard de Progreso",
                    Font = new Font("Segoe UI Black", 18F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(51, 51, 51),
                    Location = new Point(20, 15),
                    AutoSize = false,
                    Size = new Size(400, 30)
                };
                panelHeader.Controls.Add(lblTitulo);
                this.Controls.Add(panelHeader);

                // Panel de contenido con scroll
                var panelContenido = new Panel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    BackColor = Color.FromArgb(255, 247, 237)
                };

                int y = 20;

                // Estadísticas generales
                CrearCardEstadistica(panelContenido, "Tareas Completadas",
                    ObtenerTareasCompletadas().ToString(), "✓",
                    Color.FromArgb(34, 139, 34), ref y);

                CrearCardEstadistica(panelContenido, "Calificación Promedio",
                    ObtenerPromedioCalificaciones().ToString("F1"),
                    "⭐", Color.FromArgb(249, 199, 79), ref y);

                CrearCardEstadistica(panelContenido, "Lecciones Completadas",
                    ObtenerLeccionesCompletadas().ToString(), "📚",
                    Color.FromArgb(66, 153, 225), ref y);

                CrearCardEstadistica(panelContenido, "Tareas Pendientes",
                    ObtenerTareasPendientes().ToString(), "⏳",
                    Color.FromArgb(210, 126, 30), ref y);

                // Gráfico de calificaciones
                y += 20;
                var panelGrafico = new Guna2Panel
                {
                    Location = new Point(15, y),
                    Size = new Size(panelContenido.Width - 30, 250),
                    FillColor = Color.White,
                    BorderRadius = 12
                };
                panelGrafico.ShadowDecoration.Enabled = true;
                panelGrafico.ShadowDecoration.Depth = 4;

                var lblGrafico = new Guna2HtmlLabel
                {
                    Text = "📈 Distribución de Calificaciones",
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(51, 51, 51),
                    Location = new Point(15, 15),
                    AutoSize = true
                };
                panelGrafico.Controls.Add(lblGrafico);

                DibujarGraficoCalificaciones(panelGrafico);

                panelContenido.Controls.Add(panelGrafico);

                this.Controls.Add(panelContenido);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearCardEstadistica(Panel parent, string titulo, string valor,
            string icono, Color color, ref int y)
        {
            var card = new Guna2Panel
            {
                Location = new Point(15, y),
                Size = new Size(parent.Width - 30, 80),
                FillColor = Color.White,
                BorderRadius = 12,
                Margin = new Padding(0, 0, 0, 15)
            };
            card.ShadowDecoration.Enabled = true;
            card.ShadowDecoration.Depth = 4;

            // Barra lateral
            var barre = new Guna2Panel
            {
                Size = new Size(5, 80),
                Location = new Point(0, 0),
                FillColor = color,
                BorderRadius = 0
            };
            card.Controls.Add(barre);

            // Ícono
            var lblIcono = new Label
            {
                Text = icono,
                Font = new Font("Segoe UI", 24F),
                Location = new Point(15, 15),
                Size = new Size(50, 50),
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(lblIcono);

            // Título
            var lblTitulo = new Guna2HtmlLabel
            {
                Text = titulo,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(130, 120, 100),
                Location = new Point(70, 15),
                AutoSize = true
            };
            card.Controls.Add(lblTitulo);

            // Valor
            var lblValor = new Guna2HtmlLabel
            {
                Text = valor,
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = color,
                Location = new Point(70, 35),
                AutoSize = true
            };
            card.Controls.Add(lblValor);

            parent.Controls.Add(card);
            y += 95;
        }

        private void DibujarGraficoCalificaciones(Guna2Panel panel)
        {
            try
            {
                var datos = ObtenerDistribucionCalificaciones();

                // Crear un panel para el gráfico simple
                var panelBarras = new Panel
                {
                    Location = new Point(15, 50),
                    Size = new Size(panel.Width - 30, 180),
                    BackColor = Color.White
                };

                if (datos.Count == 0)
                {
                    var lblVacio = new Label
                    {
                        Text = "Sin calificaciones aún",
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.FromArgb(180, 160, 120)
                    };
                    panelBarras.Controls.Add(lblVacio);
                }
                else
                {
                    // Dibujar barras simples
                    using (var g = Graphics.FromHwnd(panelBarras.Handle))
                    {
                        int barWidth = panelBarras.Width / (datos.Count + 1);
                        int x = 10;

                        foreach (var item in datos)
                        {
                            string rango = item.Key; // "90-100", "80-89", etc
                            int cantidad = item.Value;
                            int maxAltura = 150;
                            int altura = Math.Max(10, (cantidad * maxAltura) / 5); // Normalizar

                            // Dibujar barra
                            var rect = new Rectangle(x, panelBarras.Height - altura - 20, barWidth - 10, altura);
                            Color colorBarra = ObtenerColorRango(rango);
                            g.FillRectangle(new SolidBrush(colorBarra), rect);
                            g.DrawRectangle(new Pen(colorBarra), rect);

                            // Dibujar etiqueta
                            g.DrawString(rango, new Font("Segoe UI", 8F), new SolidBrush(Color.FromArgb(130, 120, 100)),
                                new PointF(x, panelBarras.Height - 10));

                            x += barWidth;
                        }
                    }
                }

                panel.Controls.Add(panelBarras);
            }
            catch { }
        }

        private Color ObtenerColorRango(string rango)
        {
            return rango switch
            {
                "90-100" => Color.FromArgb(34, 139, 34),
                "80-89" => Color.FromArgb(66, 153, 225),
                "70-79" => Color.FromArgb(249, 199, 79),
                "60-69" => Color.FromArgb(210, 126, 30),
                _ => Color.FromArgb(197, 48, 48)
            };
        }

        // ── MÉTODOS DE DATOS ────────────────────────────
        private int ObtenerTareasCompletadas()
        {
            try
            {
                string query = @"
                    SELECT COUNT(*) FROM task_submissions
                    WHERE student_id = @studentId AND status = 'Graded'";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        private double ObtenerPromedioCalificaciones()
        {
            try
            {
                string query = @"
                    SELECT AVG(CAST(score AS FLOAT))
                    FROM task_submissions
                    WHERE student_id = @studentId AND score IS NOT NULL AND status = 'Graded'";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToDouble(result) : 0;
                }
            }
            catch { return 0; }
        }

        private int ObtenerLeccionesCompletadas()
        {
            try
            {
                string query = @"
                    SELECT COUNT(*) FROM lesson_progress
                    WHERE student_id = @studentId AND completed_at IS NOT NULL";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        private int ObtenerTareasPendientes()
        {
            try
            {
                string query = @"
                    SELECT COUNT(*) FROM task_submissions
                    WHERE student_id = @studentId AND status != 'Graded'";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        private System.Collections.Generic.Dictionary<string, int> ObtenerDistribucionCalificaciones()
        {
            var dict = new System.Collections.Generic.Dictionary<string, int>
            {
                { "90-100", 0 },
                { "80-89", 0 },
                { "70-79", 0 },
                { "60-69", 0 },
                { "<60", 0 }
            };

            try
            {
                string query = @"
                    SELECT score FROM task_submissions
                    WHERE student_id = @studentId AND score IS NOT NULL";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal score = reader.GetDecimal(0);
                            if (score >= 90) dict["90-100"]++;
                            else if (score >= 80) dict["80-89"]++;
                            else if (score >= 70) dict["70-79"]++;
                            else if (score >= 60) dict["60-69"]++;
                            else dict["<60"]++;
                        }
                    }
                }
            }
            catch { }

            return dict;
        }
    }
}
