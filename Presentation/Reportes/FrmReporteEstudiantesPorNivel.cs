using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation
{
    public partial class FrmReporteEstudiantesPorNivel : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable niveles;

        public FrmReporteEstudiantesPorNivel()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            CargarNiveles();
            ConfigurarEventos();
            ActualizarInfoHeader();
        }

        private void ConfigurarEventos()
        {
            cmbNivel.SelectedIndexChanged += CmbNivel_SelectedIndexChanged;
        }

        private void CargarNiveles()
        {
            try
            {
                niveles = dbHelper.ObtenerNiveles();
                cmbNivel.Items.Clear();

                if (niveles.Rows.Count > 0)
                {
                    cmbNivel.Items.Add("Todos los niveles");

                    foreach (DataRow row in niveles.Rows)
                    {
                        string nivelNombre = row["level_name"].ToString();
                        cmbNivel.Items.Add(nivelNombre);
                    }

                    cmbNivel.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron niveles en la base de datos.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar niveles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstudiantesPorNivel(string nivelSeleccionado)
        {
            try
            {
                dgvEstudiantes.Rows.Clear();
                DataTable estudiantes;

                if (nivelSeleccionado == "Todos los niveles")
                {
                    estudiantes = dbHelper.ObtenerEstudiantesConDetalle(null);
                }
                else
                {
                    // Buscar el código del nivel seleccionado
                    string nivelCodigo = ObtenerCodigoNivel(nivelSeleccionado);
                    estudiantes = dbHelper.ObtenerEstudiantesConDetalle(nivelCodigo);
                }

                if (estudiantes.Rows.Count > 0)
                {
                    foreach (DataRow row in estudiantes.Rows)
                    {
                        string nombre = row["Nombre"].ToString();
                        string nivel = row["Nivel"].ToString();
                        string fechaIngreso = Convert.ToDateTime(row["FechaIngreso"]).ToString("dd/MM/yyyy");
                        string grupo = row["Grupo"] == DBNull.Value ? "Sin grupo" : row["Grupo"].ToString();
                        string maestro = row["Maestro"] == DBNull.Value ? "Sin asignar" : row["Maestro"].ToString();

                        // Calcular progreso y calificación (puedes implementar lógica real)
                        string progreso = CalcularProgresoAleatorio();
                        string calificacion = CalcularCalificacionAleatoria();

                        if (nombre.Length > 15)
                            nombre = nombre.Substring(0, 12) + "...";

                        dgvEstudiantes.Rows.Add(nombre, nivel, progreso, calificacion, fechaIngreso, grupo, maestro);
                    }
                }
                else
                {
                    dgvEstudiantes.Rows.Add("No hay estudiantes", nivelSeleccionado, "0%", "0", "N/A", "N/A", "N/A");
                }

                this.Text = $"Reporte: Estudiantes por Nivel - {nivelSeleccionado} ({dgvEstudiantes.Rows.Count} estudiantes)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estudiantes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerCodigoNivel(string nivelNombre)
        {
            foreach (DataRow row in niveles.Rows)
            {
                if (row["level_name"].ToString() == nivelNombre)
                {
                    return row["level_code"].ToString();
                }
            }
            return null;
        }

        private string ObtenerGrupoEstudiante(int studentId)
        {
            try
            {
                string[] grupos = { "A1-01", "A2-01", "B1-01", "B2-01", "C1-01" };
                Random rand = new Random();
                return grupos[rand.Next(grupos.Length)];
            }
            catch
            {
                return "N/A";
            }
        }

        private string ObtenerMaestroDelGrupo(string grupo)
        {
            try
            {
                string[] maestros = { "Laura Gómez", "Roberto Díaz", "Carolina Silva", "Pedro Méndez", "Ana Torres" };
                Random rand = new Random();
                return maestros[rand.Next(maestros.Length)];
            }
            catch
            {
                return "N/A";
            }
        }

        private string CalcularProgresoAleatorio()
        {
            Random rand = new Random();
            int progreso = rand.Next(40, 101);
            return $"{progreso}%";
        }

        private string CalcularCalificacionAleatoria()
        {
            Random rand = new Random();
            double calificacion = rand.Next(50, 101) / 10.0;
            return calificacion.ToString("0.0");
        }

        private void CmbNivel_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbNivel.SelectedItem != null)
            {
                string nivelSeleccionado = cmbNivel.SelectedItem.ToString() ?? "";
                CargarEstudiantesPorNivel(nivelSeleccionado);
            }
        }

        private void ActualizarInfoHeader()
        {
            lblFecha.Text = DateTime.Now.ToString("dd MMMM, yyyy");
        }
    }
}