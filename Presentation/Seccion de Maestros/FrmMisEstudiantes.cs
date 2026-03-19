using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
            teacherId = 0;
        }

        private void FrmMisEstudiantes_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
        }

        // =====================================================
        // CARGAR DATOS
        // =====================================================
        private void CargarEstudiantes()
        {
            try
            {
                dtEstudiantes = db.ObtenerEstudiantesPorMaestro(teacherId);
                dgvEstudiantes.DataSource = dtEstudiantes;
                ConfigurarColumnas();
                ActualizarContadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnas()
        {
            foreach (DataGridViewColumn col in dgvEstudiantes.Columns)
                col.Visible = false;

            MostrarCol("Nombre", "👤 Estudiante", 180);
            MostrarCol("Email", "📧 Email", 200);
            MostrarCol("Telefono", "📱 Teléfono", 120);
            MostrarCol("Nivel", "🎓 Nivel", 70);
            MostrarCol("FechaIngreso", "📅 Fecha ingreso", 110);
            MostrarCol("Grupo", "👥 Grupo", 120);
        }

        private void MostrarCol(string nombre, string header, int width)
        {
            if (dgvEstudiantes.Columns[nombre] != null)
            {
                dgvEstudiantes.Columns[nombre].Visible = true;
                dgvEstudiantes.Columns[nombre].HeaderText = header;
                dgvEstudiantes.Columns[nombre].Width = width;
            }
        }

        private void ActualizarContadores()
        {
            int total = dtEstudiantes?.Rows.Count ?? 0;
            lblTotalEstudiantes.Text = total.ToString();

            // Contar por nivel
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

            lblA1.Text = a1.ToString();
            lblA2.Text = a2.ToString();
            lblB1.Text = b1.ToString();
            lblB2.Text = b2.ToString();
            lblC1.Text = c1.ToString();
            lblC2.Text = c2.ToString();
        }

        // =====================================================
        // BÚSQUEDA
        // =====================================================
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (dtEstudiantes == null) return;

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
            if (dtEstudiantes == null) return;

            string nivel = cmbNivel.SelectedItem?.ToString() ?? "Todos";

            foreach (DataGridViewRow row in dgvEstudiantes.Rows)
            {
                row.Visible = nivel == "Todos" ||
                    row.Cells["Nivel"]?.Value?.ToString() == nivel;
            }
        }

        // =====================================================
        // FORMATO DE FILAS
        // =====================================================
        private void dgvEstudiantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvEstudiantes.Columns[e.ColumnIndex].Name == "Nivel" && e.Value != null)
            {
                string nivel = e.Value.ToString().ToUpper();
                e.CellStyle.ForeColor = nivel switch
                {
                    "A1" => Color.FromArgb(153, 60, 29),
                    "A2" => Color.FromArgb(133, 79, 11),
                    "B1" => Color.FromArgb(59, 109, 17),
                    "B2" => Color.FromArgb(15, 110, 86),
                    "C1" => Color.FromArgb(24, 95, 165),
                    "C2" => Color.FromArgb(83, 74, 183),
                    _ => Color.FromArgb(45, 55, 72)
                };
                e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                e.FormattingApplied = true;
            }
        }
    }
}