using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Presentation.Helpers;

namespace Presentation.Seccion_de_Maestros
{
    public partial class FrmDashboardMaestro : Form
    {
        private DatabaseHelper dbHelper;
        private int teacherId;

        public FrmDashboardMaestro(int teacherId = -1)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            dbHelper = new DatabaseHelper();
            this.DoubleBuffered = true;
            ConfigurarDiseño();
        }

        private void FrmDashboardMaestro_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
        }

        private void ConfigurarDiseño()
        {
            this.BackColor = Color.FromArgb(255, 247, 237);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = "📊 Dashboard Maestro";
        }

        private void CargarEstadisticas()
        {
            try
            {
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
                    Text = "📊 Dashboard de Enseñanza",
                    Font = new Font("Segoe UI Black", 18F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(51, 51, 51),
                    Location = new Point(20, 15),
                    AutoSize = false,
                    Size = new Size(400, 30)
                };
                panelHeader.Controls.Add(lblTitulo);
                this.Controls.Add(panelHeader);

                var panelContenido = new Panel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    BackColor = Color.FromArgb(255, 247, 237)
                };

                int y = 20;

                // Estadísticas generales
                CrearCardEstadistica(panelContenido, "Total Estudiantes",
                    ObtenerTotalEstudiantes().ToString(), "👥",
                    Color.FromArgb(66, 153, 225), ref y);

                CrearCardEstadistica(panelContenido, "Tareas Creadas",
                    ObtenerTotalTareas().ToString(), "📝",
                    Color.FromArgb(249, 199, 79), ref y);

                CrearCardEstadistica(panelContenido, "Entregas Pendientes",
                    ObtenerEntregasPendientes().ToString(), "⏳",
                    Color.FromArgb(210, 126, 30), ref y);

                CrearCardEstadistica(panelContenido, "Promedio de Clase",
                    ObtenerPromedioClase().ToString("F1"),
                    "⭐", Color.FromArgb(34, 139, 34), ref y);

                // Gráfico de entregas
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
                    Text = "📈 Distribución de Entregas",
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(51, 51, 51),
                    Location = new Point(15, 15),
                    AutoSize = true
                };
                panelGrafico.Controls.Add(lblGrafico);

                DibujarGraficoEntregas(panelGrafico);

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

        private void DibujarGraficoEntregas(Guna2Panel panel)
        {
            try
            {
                var datos = ObtenerDistribucionEntregas();

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
                        Text = "Sin entregas aún",
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.FromArgb(180, 160, 120)
                    };
                    panelBarras.Controls.Add(lblVacio);
                }
                else
                {
                    using (var g = Graphics.FromHwnd(panelBarras.Handle))
                    {
                        int barWidth = panelBarras.Width / (datos.Count + 1);
                        int x = 10;

                        foreach (var item in datos)
                        {
                            string estado = item.Key;
                            int cantidad = item.Value;
                            int maxAltura = 150;
                            int altura = Math.Max(10, (cantidad * maxAltura) / 10);

                            var rect = new Rectangle(x, panelBarras.Height - altura - 20, barWidth - 10, altura);
                            Color colorBarra = ObtenerColorEstado(estado);
                            g.FillRectangle(new SolidBrush(colorBarra), rect);
                            g.DrawRectangle(new Pen(colorBarra), rect);

                            g.DrawString(estado, new Font("Segoe UI", 8F), new SolidBrush(Color.FromArgb(130, 120, 100)),
                                new PointF(x, panelBarras.Height - 10));

                            x += barWidth;
                        }
                    }
                }

                panel.Controls.Add(panelBarras);
            }
            catch { }
        }

        private Color ObtenerColorEstado(string estado)
        {
            return estado switch
            {
                "Graded" => Color.FromArgb(34, 139, 34),
                "Pending" => Color.FromArgb(210, 126, 30),
                "Late" => Color.FromArgb(197, 48, 48),
                _ => Color.FromArgb(130, 120, 100)
            };
        }

        // ── MÉTODOS DE DATOS ────────────────────────────────
        private int ObtenerTotalEstudiantes()
        {
            try
            {
                string query = @"
                    SELECT COUNT(DISTINCT s.student_id) FROM task_submissions ts
                    INNER JOIN tasks t ON ts.task_id = t.task_id
                    WHERE t.teacher_id = @teacherId";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
            catch { return 0; }
        }

        private int ObtenerTotalTareas()
        {
            try
            {
                string query = @"SELECT COUNT(*) FROM tasks WHERE teacher_id = @teacherId";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        private int ObtenerEntregasPendientes()
        {
            try
            {
                string query = @"
                    SELECT COUNT(*) FROM task_submissions ts
                    INNER JOIN tasks t ON ts.task_id = t.task_id
                    WHERE t.teacher_id = @teacherId AND ts.status != 'Graded'";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        private double ObtenerPromedioClase()
        {
            try
            {
                string query = @"
                    SELECT AVG(CAST(ts.score AS FLOAT)) FROM task_submissions ts
                    INNER JOIN tasks t ON ts.task_id = t.task_id
                    WHERE t.teacher_id = @teacherId AND ts.score IS NOT NULL AND ts.status = 'Graded'";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToDouble(result) : 0;
                }
            }
            catch { return 0; }
        }

        private Dictionary<string, int> ObtenerDistribucionEntregas()
        {
            var dict = new Dictionary<string, int>
            {
                { "Graded", 0 },
                { "Pending", 0 },
                { "Late", 0 }
            };

            try
            {
                string query = @"
                    SELECT status, COUNT(*) as cantidad FROM task_submissions ts
                    INNER JOIN tasks t ON ts.task_id = t.task_id
                    WHERE t.teacher_id = @teacherId
                    GROUP BY status";
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(dbHelper.ConnectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string status = reader.GetString(0);
                            int cantidad = reader.GetInt32(1);
                            if (dict.ContainsKey(status))
                                dict[status] = cantidad;
                        }
                    }
                }
            }
            catch { }

            return dict;
        }
    }
}
