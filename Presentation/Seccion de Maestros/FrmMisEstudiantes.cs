using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Maestros
{
    public partial class FrmMisEstudiantes : Form
    {
        private readonly DatabaseHelper db;
        private readonly int teacherId;
        private DataTable dtEstudiantes;

        public FrmMisEstudiantes(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            db = new DatabaseHelper();
        }

        public FrmMisEstudiantes()
        {
            InitializeComponent();
            db = new DatabaseHelper();
            teacherId = 1;
        }

        private void FrmMisEstudiantes_Load(object sender, EventArgs e)
        {
            try
            {
                CargarEstudiantes();
                ConfigurarBadgesNiveles();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
                dtEstudiantes = CrearDatosDemo();
                dgvEstudiantes.DataSource = dtEstudiantes;
                ConfigurarColumnas();
                ActualizarContadores();
            }
        }

        // =====================================================
        // CONFIGURAR BADGES
        // =====================================================
        private void ConfigurarBadgesNiveles()
        {
            try
            {
                // Limpiar panel primero
                panelNivelBadges.Controls.Clear();

                // Agregar controles al panel
                panelNivelBadges.Controls.Add(lblA1);
                panelNivelBadges.Controls.Add(lblA2);
                panelNivelBadges.Controls.Add(lblB1);
                panelNivelBadges.Controls.Add(lblB2);
                panelNivelBadges.Controls.Add(lblC1);
                panelNivelBadges.Controls.Add(lblC2);

                // A1 - Beginner (Marrón)
                ConfigurarBadge(lblA1, "A1", 0, Color.FromArgb(230, 220, 200), Color.FromArgb(153, 60, 29));

                // A2 - Elementary (Naranja)
                ConfigurarBadge(lblA2, "A2", 60, Color.FromArgb(245, 220, 180), Color.FromArgb(210, 120, 30));

                // B1 - Intermediate (Verde claro)
                ConfigurarBadge(lblB1, "B1", 120, Color.FromArgb(220, 240, 200), Color.FromArgb(59, 109, 17));

                // B2 - Upper Intermediate (Verde oscuro)
                ConfigurarBadge(lblB2, "B2", 180, Color.FromArgb(200, 230, 220), Color.FromArgb(15, 110, 86));

                // C1 - Advanced (Azul)
                ConfigurarBadge(lblC1, "C1", 240, Color.FromArgb(200, 220, 245), Color.FromArgb(24, 95, 165));

                // C2 - Mastery (Púrpura)
                ConfigurarBadge(lblC2, "C2", 300, Color.FromArgb(225, 215, 245), Color.FromArgb(83, 74, 183));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error configurando badges: {ex.Message}");
            }
        }

        private void ConfigurarBadge(Guna2HtmlLabel lbl, string texto, int x, Color bg, Color fg)
        {
            lbl.BackColor = bg;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl.ForeColor = fg;
            lbl.Location = new Point(x, 5);
            lbl.Size = new Size(52, 22);
            lbl.Text = texto;
            lbl.TextAlignment = ContentAlignment.MiddleCenter;
            lbl.Visible = true;
        }

        // =====================================================
        // CARGAR ESTUDIANTES
        // =====================================================
        private void CargarEstudiantes()
        {
            try
            {
                // ✅ Obtener SOLO los estudiantes asignados a este maestro
                dtEstudiantes = db.ObtenerEstudiantesPorMaestro(teacherId);

                // Si no hay estudiantes, mostrar tabla vacía (sin datos de demo)
                if (dtEstudiantes == null)
                {
                    dtEstudiantes = new DataTable();
                    dtEstudiantes.Columns.Add("StudentId", typeof(int));
                    dtEstudiantes.Columns.Add("Nombre", typeof(string));
                    dtEstudiantes.Columns.Add("Email", typeof(string));
                    dtEstudiantes.Columns.Add("Telefono", typeof(string));
                    dtEstudiantes.Columns.Add("Nivel", typeof(string));
                    dtEstudiantes.Columns.Add("FechaIngreso", typeof(string));
                    dtEstudiantes.Columns.Add("Grupo", typeof(string));
                }

                dgvEstudiantes.DataSource = dtEstudiantes;
                ConfigurarColumnas();
                ActualizarContadores();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al cargar estudiantes: {ex.Message}");
                // ✅ Mostrar tabla vacía en caso de error (sin datos de demo)
                dtEstudiantes = new DataTable();
                dtEstudiantes.Columns.Add("StudentId", typeof(int));
                dtEstudiantes.Columns.Add("Nombre", typeof(string));
                dtEstudiantes.Columns.Add("Email", typeof(string));
                dtEstudiantes.Columns.Add("Telefono", typeof(string));
                dtEstudiantes.Columns.Add("Nivel", typeof(string));
                dtEstudiantes.Columns.Add("FechaIngreso", typeof(string));
                dtEstudiantes.Columns.Add("Grupo", typeof(string));
                dgvEstudiantes.DataSource = dtEstudiantes;
                ConfigurarColumnas();
                ActualizarContadores();
            }
        }

        // =====================================================
        // DATOS DE DEMO
        // =====================================================
        private DataTable CrearDatosDemo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StudentId", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Telefono", typeof(string));
            dt.Columns.Add("Nivel", typeof(string));
            dt.Columns.Add("FechaIngreso", typeof(string));
            dt.Columns.Add("Grupo", typeof(string));

            dt.Rows.Add(1, "María González Pérez", "maria.gonzalez@email.com", "829-555-0101", "A1", "15/09/2023", "Grupo 1A");
            dt.Rows.Add(2, "Juan Carlos Méndez", "juan.mendez@email.com", "829-555-0102", "A2", "20/10/2023", "Grupo 1A");
            dt.Rows.Add(3, "Carlos López Muñoz", "carlos.lopez@email.com", "829-555-0103", "B1", "05/11/2023", "Grupo 2B");
            dt.Rows.Add(4, "Ana María Rodríguez", "ana.rodriguez@email.com", "829-555-0104", "B2", "12/12/2023", "Grupo 2B");
            dt.Rows.Add(5, "Pedro Martínez Silva", "pedro.martinez@email.com", "829-555-0105", "C1", "18/01/2024", "Grupo 3C");
            dt.Rows.Add(6, "Laura Fernanda García", "laura.garcia@email.com", "829-555-0106", "C2", "25/02/2024", "Grupo 3C");
            dt.Rows.Add(7, "Roberto Díaz Hernández", "roberto.diaz@email.com", "829-555-0107", "A1", "03/03/2024", "Grupo 1A");
            dt.Rows.Add(8, "Sofía Elena Torres", "sofia.torres@email.com", "829-555-0108", "B1", "10/03/2024", "Grupo 2B");
            dt.Rows.Add(9, "Miguel Ángel Sánchez", "miguel.sanchez@email.com", "829-555-0109", "A2", "17/03/2024", "Grupo 1A");
            dt.Rows.Add(10, "Elena Concepción Reyes", "elena.reyes@email.com", "829-555-0110", "C1", "24/03/2024", "Grupo 3C");

            return dt;
        }

        // =====================================================
        // CONFIGURAR COLUMNAS
        // =====================================================
        private void ConfigurarColumnas()
        {
            try
            {
                foreach (DataGridViewColumn col in dgvEstudiantes.Columns)
                    col.Visible = false;

                MostrarCol("Nombre", "👤 Estudiante", 180);
                MostrarCol("Email", "📧 Email", 200);
                MostrarCol("Telefono", "📱 Teléfono", 120);
                MostrarCol("Nivel", "🎓 Nivel", 70);
                MostrarCol("FechaIngreso", "📅 Ingreso", 110);
                MostrarCol("Grupo", "👥 Grupo", 120);
            }
            catch { }
        }

        private void MostrarCol(string nombre, string header, int width)
        {
            if (dgvEstudiantes.Columns.Contains(nombre))
            {
                dgvEstudiantes.Columns[nombre].Visible = true;
                dgvEstudiantes.Columns[nombre].HeaderText = header;
                dgvEstudiantes.Columns[nombre].Width = width;
            }
        }

        // =====================================================
        // ACTUALIZAR CONTADORES
        // =====================================================
        private void ActualizarContadores()
        {
            int total = dtEstudiantes?.Rows.Count ?? 0;
            lblTotalEstudiantes.Text = total.ToString();

            int a1 = 0, a2 = 0, b1 = 0, b2 = 0, c1 = 0, c2 = 0;

            if (dtEstudiantes != null)
            {
                foreach (DataRow row in dtEstudiantes.Rows)
                {
                    string nivel = row["Nivel"]?.ToString() ?? "";
                    switch (nivel.ToUpper())
                    {
                        case "A1": a1++; break;
                        case "A2": a2++; break;
                        case "B1": b1++; break;
                        case "B2": b2++; break;
                        case "C1": c1++; break;
                        case "C2": c2++; break;
                    }
                }
            }

            // Actualizar badges - IMPORTANTE: Mantener el texto sin paréntesis si es 0
            lblA1.Text = $"A1 ({a1})";
            lblA2.Text = $"A2 ({a2})";
            lblB1.Text = $"B1 ({b1})";
            lblB2.Text = $"B2 ({b2})";
            lblC1.Text = $"C1 ({c1})";
            lblC2.Text = $"C2 ({c2})";

            System.Diagnostics.Debug.WriteLine($"Contadores: A1={a1}, A2={a2}, B1={b1}, B2={b2}, C1={c1}, C2={c2}");
        }

        // =====================================================
        // BÚSQUEDA EN TIEMPO REAL
        // =====================================================
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (dgvEstudiantes.DataSource == null) return;

            string filtro = txtBuscar.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvEstudiantes.Rows)
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    row.Visible = true;
                    continue;
                }

                bool visible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Visible && cell.Value?.ToString().ToLower().Contains(filtro) == true)
                    {
                        visible = true;
                        break;
                    }
                }
                row.Visible = visible;
            }
        }

        // =====================================================
        // FILTRO POR NIVEL
        // =====================================================
        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvEstudiantes.DataSource == null) return;

            string nivel = cmbNivel.SelectedItem?.ToString() ?? "Todos";

            foreach (DataGridViewRow row in dgvEstudiantes.Rows)
            {
                bool visible = nivel == "Todos" ||
                    row.Cells["Nivel"]?.Value?.ToString() == nivel;
                row.Visible = visible;
            }
        }

        // =====================================================
        // FORMATO DE CELDAS
        // =====================================================
        private void dgvEstudiantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || !dgvEstudiantes.Columns.Contains("Nivel")) return;

            if (dgvEstudiantes.Columns[e.ColumnIndex].Name == "Nivel" && e.Value != null)
            {
                string nivel = e.Value.ToString().ToUpper();

                e.CellStyle.ForeColor = nivel switch
                {
                    "A1" => Color.FromArgb(153, 60, 29),
                    "A2" => Color.FromArgb(210, 120, 30),
                    "B1" => Color.FromArgb(59, 109, 17),
                    "B2" => Color.FromArgb(15, 110, 86),
                    "C1" => Color.FromArgb(24, 95, 165),
                    "C2" => Color.FromArgb(83, 74, 183),
                    _ => Color.FromArgb(45, 55, 72)
                };

                e.CellStyle.BackColor = nivel switch
                {
                    "A1" => Color.FromArgb(245, 230, 215),
                    "A2" => Color.FromArgb(250, 235, 210),
                    "B1" => Color.FromArgb(230, 245, 210),
                    "B2" => Color.FromArgb(215, 240, 230),
                    "C1" => Color.FromArgb(215, 230, 250),
                    "C2" => Color.FromArgb(235, 225, 250),
                    _ => Color.White
                };

                e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                e.FormattingApplied = true;
            }
        }
    }
}