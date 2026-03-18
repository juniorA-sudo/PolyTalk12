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
    public partial class FrmContenido : Form
    {
        // =====================================================
        // CAMPOS PRIVADOS
        // =====================================================
        private DatabaseHelper db = new DatabaseHelper();

        // =====================================================
        // CONSTRUCTOR
        // =====================================================
        public FrmContenido()
        {
            InitializeComponent();
            CargarInfoNiveles();

            // Cargar nivel A1 por defecto
            ActualizarEstadisticasCompletas(1, "Nivel A1 - Principiante");
        }

        // =====================================================
        // MÉTODOS PARA CARGAR NIVELES
        // =====================================================

        /// <summary>
        /// Carga la información de los niveles en los labels
        /// </summary>
        private void CargarInfoNiveles()
        {
            try
            {
                // Obtener niveles desde la base de datos
                DataTable dtNiveles = db.ObtenerNiveles();

                // Crear un diccionario para acceder fácilmente por código de nivel
                Dictionary<string, DataRow> nivelesDict = new Dictionary<string, DataRow>();

                foreach (DataRow row in dtNiveles.Rows)
                {
                    string codigo = row["level_code"].ToString();
                    nivelesDict[codigo] = row;
                }

                // Actualizar labels para A1
                if (nivelesDict.ContainsKey("A1"))
                {
                    DataRow row = nivelesDict["A1"];
                    lblA1.Text = row["level_code"].ToString();
                    lblNombreA1.Text = row["level_name"].ToString();
                }

                // Actualizar labels para A2
                if (nivelesDict.ContainsKey("A2"))
                {
                    DataRow row = nivelesDict["A2"];
                    lblA2.Text = row["level_code"].ToString();
                    lblNombreA2.Text = row["level_name"].ToString();
                }

                // Actualizar labels para B1
                if (nivelesDict.ContainsKey("B1"))
                {
                    DataRow row = nivelesDict["B1"];
                    lblB1.Text = row["level_code"].ToString();
                    lblNombreB1.Text = row["level_name"].ToString();
                }

                // Actualizar labels para B2
                if (nivelesDict.ContainsKey("B2"))
                {
                    DataRow row = nivelesDict["B2"];
                    lblB2.Text = row["level_code"].ToString();
                    lblNombreB2.Text = row["level_name"].ToString();
                }

                // Actualizar labels para C1
                if (nivelesDict.ContainsKey("C1"))
                {
                    DataRow row = nivelesDict["C1"];
                    lblC1.Text = row["level_code"].ToString();
                    lblNombreC1.Text = row["level_name"].ToString();
                }

                // Actualizar labels para C2
                if (nivelesDict.ContainsKey("C2"))
                {
                    DataRow row = nivelesDict["C2"];
                    lblC2.Text = row["level_code"].ToString();
                    lblNombreC2.Text = row["level_name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar información de niveles: " + ex.Message);
            }
        }

        // =====================================================
        // NUEVO MÉTODO: ACTUALIZAR ESTADÍSTICAS COMPLETAS
        // =====================================================
        private void ActualizarEstadisticasCompletas(int nivelId, string nombreNivel)
        {
            try
            {
                // 1. Actualizar título del nivel seleccionado
                lblNivelSeleccionado.Text = nombreNivel;

                // 2. Actualizar UNIDADES
                int totalUnidades = db.ObtenerTotalUnidades(nivelId);
                string textoUnidades = totalUnidades == 1 ? "unidad" : "unidades";
                lblCantidadUnidades.Text = $"{totalUnidades} {textoUnidades}";

                // 3. Actualizar LECCIONES (NUEVO)
                int totalLecciones = ContarLeccionesPorNivel(nivelId);
                string textoLecciones = totalLecciones == 1 ? "lección" : "lecciones";
                lblCantidadLecciones.Text = $"{totalLecciones} {textoLecciones}";

                // 4. Opcional: Actualizar HORAS (si tienes ese dato)
                // int totalHoras = CalcularHorasPorNivel(nivelId);
                // lblCantidadHoras.Text = $"{totalHoras} horas";

                // 5. Cargar las unidades del nivel
                CargarUnidades(nivelId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar estadísticas: " + ex.Message);
            }
        }

        // =====================================================
        // NUEVO MÉTODO: CONTAR LECCIONES POR NIVEL
        // =====================================================
        private int ContarLeccionesPorNivel(int nivelId)
        {
            try
            {
                string query = @"
                    SELECT COUNT(*) 
                    FROM lessons l
                    INNER JOIN units u ON l.unit_id = u.unit_id
                    WHERE u.level_id = @nivelId AND l.is_active = 1";

                using (SqlConnection conn = new SqlConnection(db.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nivelId", nivelId);
                        conn.Open();
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch
            {
                return 0; // Si hay error, devolver 0
            }
        }

        // =====================================================
        // MÉTODO OPCIONAL: CALCULAR HORAS POR NIVEL
        // =====================================================
        private int CalcularHorasPorNivel(int nivelId)
        {
            try
            {
                string query = @"
                    SELECT ISNULL(SUM(l.duration_minutes), 0) / 60 
                    FROM lessons l
                    INNER JOIN units u ON l.unit_id = u.unit_id
                    WHERE u.level_id = @nivelId AND l.is_active = 1";

                using (SqlConnection conn = new SqlConnection(db.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nivelId", nivelId);
                        conn.Open();
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        // =====================================================
        // EVENTOS DE BOTONES DE NIVEL (ACTUALIZADOS)
        // =====================================================
        private void btnNivelA1_Click(object sender, EventArgs e)
        {
            ActualizarEstadisticasCompletas(1, "Nivel A1 - Principiante");
        }

        private void btnNivelA2_Click(object sender, EventArgs e)
        {
            ActualizarEstadisticasCompletas(2, "Nivel A2 - Básico");
        }

        private void btnNivelB1_Click(object sender, EventArgs e)
        {
            ActualizarEstadisticasCompletas(3, "Nivel B1 - Intermedio");
        }

        private void btnNivelB2_Click(object sender, EventArgs e)
        {
            ActualizarEstadisticasCompletas(4, "Nivel B2 - Intermedio Alto");
        }

        private void btnNivelC1_Click(object sender, EventArgs e)
        {
            ActualizarEstadisticasCompletas(5, "Nivel C1 - Avanzado");
        }

        private void btnNivelC2_Click(object sender, EventArgs e)
        {
            ActualizarEstadisticasCompletas(6, "Nivel C2 - Maestría");
        }

        // =====================================================
        // MÉTODO PARA CARGAR UNIDADES (SIN CAMBIOS)
        // =====================================================
        // En FrmContenido.cs, modificar CargarUnidades()
        private void CargarUnidades(int nivelId)
        {
            try
            {
                flpUnidades.Controls.Clear();
                DataTable dtUnidades = db.ObtenerUnidadesPorNivel(nivelId);

                foreach (DataRow row in dtUnidades.Rows)
                {
                    UCUnidad ucUnidad = new UCUnidad();
                    int unitId = Convert.ToInt32(row["unit_id"]);

                    // Obtener las lecciones de esta unidad
                    DataTable dtLecciones = db.ObtenerLeccionesPorUnidad(unitId);

                    // Por cada lección, verificar su tipo
                    foreach (DataRow leccionRow in dtLecciones.Rows)
                    {
                        string lessonType = leccionRow["lesson_type"].ToString();
                        int lessonId = Convert.ToInt32(leccionRow["lesson_id"]);
                        string lessonTitle = leccionRow["lesson_title"].ToString();

                        // Si es vocabulario, hacerla clickeable para gestionar palabras
                        if (lessonType == "vocabulary")
                        {
                            // Aquí necesitas una forma de identificar esta lección en la UI
                            // Podrías agregar un botón o hacer clickeable el nombre
                        }
                    }

                    ucUnidad.UnitId = unitId;
                    ucUnidad.TituloUnidad = row["unit_title"].ToString();
                    ucUnidad.NumeroUnidad = Convert.ToInt32(row["unit_number"]);

                    flpUnidades.Controls.Add(ucUnidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =====================================================
        // EVENTOS DEL FORMULARIO (SIN CAMBIOS)
        // =====================================================
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
        private void guna2Panel10_Paint(object sender, PaintEventArgs e) { }
        private void guna2Button4_Click(object sender, EventArgs e) { }

        private void lblB1_Click(object sender, EventArgs e)
        {

        }
    }
}