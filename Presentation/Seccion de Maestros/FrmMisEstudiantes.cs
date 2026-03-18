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

namespace Presentation
{
    public partial class FrmMisEstudiantes : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private List<UCEstudiante> listaEstudiantes = new List<UCEstudiante>();
        private int maestroId = 2; // Cambia por el ID del maestro actual

        public FrmMisEstudiantes()
        {
            InitializeComponent();
            CargarEstudiantes();
        }

        // =====================================================
        // CARGAR ESTUDIANTES EN EL FLOWLAYOUTPANEL
        // =====================================================
        private void CargarEstudiantes()
        {
            try
            {
                flpEstudiantes.Controls.Clear();
                listaEstudiantes.Clear();

                DataTable dt = ObtenerEstudiantesDeBD();

                if (dt.Rows.Count == 0)
                {
                    Label lblSinEstudiantes = new Label();
                    lblSinEstudiantes.Text = "No hay estudiantes asignados";
                    lblSinEstudiantes.Font = new Font("Segoe UI", 12);
                    lblSinEstudiantes.ForeColor = Color.Gray;
                    lblSinEstudiantes.AutoSize = true;
                    lblSinEstudiantes.Location = new Point(20, 20);
                    flpEstudiantes.Controls.Add(lblSinEstudiantes);
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    UCEstudiante uc = new UCEstudiante();

                    uc.NombreEstudiante = row["Nombre"].ToString();
                    uc.EmailEstudiante = row["Email"].ToString();
                    uc.TelefonoEstudiante = row["Telefono"]?.ToString() ?? "";

                    if (row["FechaIngreso"] != DBNull.Value)
                        uc.FechaIngreso = Convert.ToDateTime(row["FechaIngreso"]).ToString("dd/MM/yyyy");

                    // 👇 CORREGIDO: Usar el nombre correcto de la columna (Grupos, no Grupo)
                    uc.GrupoEstudiante = row["Grupos"]?.ToString() ?? "Sin grupo";

                    uc.NivelEstudiante = row["Nivel"].ToString();

                    // Valores por defecto
                    uc.Asistencia = 85;
                    uc.Promedio = 8.5m;
                    uc.TareasCompletadas = 12;
                    uc.Progreso = 65;

                    listaEstudiantes.Add(uc);
                    flpEstudiantes.Controls.Add(uc);
                    uc.Margin = new Padding(5);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estudiantes: " + ex.Message);
            }
        }

        // =====================================================
        // OBTENER ESTUDIANTES DE LA BASE DE DATOS - VERSIÓN 100% FUNCIONAL
        // =====================================================
        private DataTable ObtenerEstudiantesDeBD()
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    u.username AS Nombre,
                    u.email AS Email,
                    u.phone AS Telefono,
                    s.current_english_level AS Nivel,
                    s.enrollment_date AS FechaIngreso,
                    STUFF((
                        SELECT ', ' + g2.group_name
                        FROM enrollments e2
                        INNER JOIN groups g2 ON e2.group_id = g2.group_id
                        WHERE e2.student_id = s.student_id 
                          AND e2.status = 'activo'
                          AND g2.teacher_id = @maestroId
                        FOR XML PATH('')
                    ), 1, 2, '') AS Grupos
                FROM students s
                INNER JOIN users u ON s.user_id = u.user_id
                WHERE EXISTS (
                    SELECT 1 
                    FROM enrollments e3
                    INNER JOIN groups g3 ON e3.group_id = g3.group_id
                    WHERE e3.student_id = s.student_id 
                      AND e3.status = 'activo'
                      AND g3.teacher_id = @maestroId
                )
                ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(db.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maestroId", maestroId);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // =====================================================
        // BUSCADOR 
        // =====================================================
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower().Trim();

            flpEstudiantes.Controls.Clear();

            if (string.IsNullOrEmpty(busqueda))
            {
                foreach (var uc in listaEstudiantes)
                    flpEstudiantes.Controls.Add(uc);
                return;
            }

            var filtrados = listaEstudiantes.Where(uc =>
                uc.NombreEstudiante.ToLower().Contains(busqueda) ||
                uc.EmailEstudiante.ToLower().Contains(busqueda) ||
                uc.NivelEstudiante.ToLower().Contains(busqueda) ||
                uc.GrupoEstudiante.ToLower().Contains(busqueda)
            ).ToList();

            foreach (var uc in filtrados)
                flpEstudiantes.Controls.Add(uc);
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar estudiante por nombre, email o nivel...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar estudiante por nombre, email o nivel...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void guna2Panel14_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}