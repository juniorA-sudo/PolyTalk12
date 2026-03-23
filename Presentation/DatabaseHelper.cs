using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Presentation
{
    internal class DatabaseHelper
    {
        // =====================================================
        // CONFIGURACIÓN DE CONEXIÓN
        // =====================================================

        private readonly string connectionString = @"Data Source=JUNIOR\JUNIOR;Initial Catalog=PruebaPolyTalk;Integrated Security=True;TrustServerCertificate=True;";

        public string ConnectionString
        {
            get { return connectionString; }
        }

        // =====================================================
        // MÉTODOS DE UTILIDAD
        // =====================================================

        /// <summary>
        /// Prueba la conexión a la base de datos
        /// </summary>
        public bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
                return false;
            }
        }

        // =====================================================
        // MÉTODOS PARA ESTUDIANTES
        // =====================================================

        #region Métodos de Estudiantes

        /// <summary>
        /// Obtiene todos los estudiantes
        /// </summary>
        public DataTable ObtenerEstudiantes()
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT
            s.student_id    AS ID,
            u.username      AS Usuario,
            u.email         AS Email,
            u.phone         AS Teléfono,
            s.current_english_level AS Nivel,
            s.enrollment_date AS 'Fecha Ingreso'
        FROM students s
        INNER JOIN users u ON s.user_id = u.user_id
        ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        public DataTable BuscarEstudiantes(string busqueda)
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT
            s.student_id    AS ID,
            u.username      AS Usuario,
            u.email         AS Email,
            u.phone         AS Teléfono,
            s.current_english_level AS Nivel,
            s.enrollment_date AS 'Fecha Ingreso'
        FROM students s
        INNER JOIN users u ON s.user_id = u.user_id
        WHERE u.username LIKE @busqueda
           OR u.email    LIKE @busqueda
           OR s.current_english_level LIKE @busqueda
        ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        /// <summary>
        /// Filtra estudiantes por nivel
        /// </summary>
        public DataTable FiltrarEstudiantesPorNivel(string nivel)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    s.student_id AS ID,
                    u.username AS Usuario,
                    u.email AS Email,
                    u.phone AS Teléfono,
                    s.current_english_level AS Nivel,
                    s.enrollment_date AS 'Fecha Ingreso'
                FROM students s
                INNER JOIN users u ON s.user_id = u.user_id
                WHERE s.current_english_level = @nivel
                ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nivel", nivel);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        /// <summary>
        /// Obtiene el conteo de estudiantes por nivel
        /// </summary>
        public Dictionary<string, int> ObtenerConteoPorNivel()
        {
            Dictionary<string, int> conteo = new Dictionary<string, int>();

            string query = @"
                SELECT current_english_level, COUNT(*) as cantidad
                FROM students
                GROUP BY current_english_level";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nivel = reader["current_english_level"].ToString();
                            int cantidad = Convert.ToInt32(reader["cantidad"]);
                            conteo[nivel] = cantidad;
                        }
                    }
                }
            }

            return conteo;
        }

        #endregion

        // =====================================================
        // MÉTODOS PARA MAESTROS
        // =====================================================

        #region Métodos de Maestros

        /// <summary>
        /// Obtiene todos los maestros
        /// </summary>
        public DataTable ObtenerMaestros()
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            t.teacher_id AS ID,
            u.username   AS Usuario,
            u.email      AS Email,
            u.phone      AS Teléfono,
            t.english_level AS Nivel,
            t.hire_date  AS 'Fecha Ingreso',
            (SELECT COUNT(*) FROM groups WHERE teacher_id = t.teacher_id) AS Grupos,
            (SELECT COUNT(*) FROM enrollments e 
             INNER JOIN groups g ON e.group_id = g.group_id 
             WHERE g.teacher_id = t.teacher_id) AS Estudiantes
        FROM teachers t
        INNER JOIN users u ON t.user_id = u.user_id
        ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        /// <summary>
        /// Busca maestros por nombre, email o teléfono
        /// </summary>
        public DataTable BuscarMaestros(string busqueda)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    t.teacher_id AS ID,
                    u.username AS Usuario,
                    u.email AS Email,
                    u.phone AS Teléfono,
                    t.english_level AS Nivel,
                    t.hire_date AS 'Fecha Ingreso',
                    (SELECT COUNT(*) FROM groups WHERE teacher_id = t.teacher_id) AS Grupos,
                    (SELECT COUNT(*) FROM enrollments e 
                     INNER JOIN groups g ON e.group_id = g.group_id 
                     WHERE g.teacher_id = t.teacher_id) AS Estudiantes,
                    CASE WHEN u.is_active = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                FROM teachers t
                INNER JOIN users u ON t.user_id = u.user_id
                WHERE u.username LIKE @busqueda 
                   OR u.email LIKE @busqueda
                   OR u.phone LIKE @busqueda
                ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Filtra maestros por nivel
        /// </summary>
        public DataTable FiltrarMaestrosPorNivel(string nivel)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    t.teacher_id AS ID,
                    u.username AS Usuario,
                    u.email AS Email,
                    u.phone AS Teléfono,
                    t.english_level AS Nivel,
                    t.hire_date AS 'Fecha Ingreso',
                    (SELECT COUNT(*) FROM groups WHERE teacher_id = t.teacher_id) AS Grupos,
                    (SELECT COUNT(*) FROM enrollments e 
                     INNER JOIN groups g ON e.group_id = g.group_id 
                     WHERE g.teacher_id = t.teacher_id) AS Estudiantes,
                    CASE WHEN u.is_active = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                FROM teachers t
                INNER JOIN users u ON t.user_id = u.user_id
                WHERE t.english_level = @nivel
                ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nivel", nivel);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Obtiene el conteo de maestros por nivel
        /// </summary>
        public Dictionary<string, int> ObtenerConteoMaestrosPorNivel()
        {
            Dictionary<string, int> conteo = new Dictionary<string, int>();

            string query = @"
                SELECT english_level, COUNT(*) as cantidad
                FROM teachers
                GROUP BY english_level";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nivel = reader["english_level"].ToString();
                            int cantidad = Convert.ToInt32(reader["cantidad"]);
                            conteo[nivel] = cantidad;
                        }
                    }
                }
            }

            return conteo;
        }

        #endregion

        // =====================================================
        // MÉTODOS PARA GRUPOS
        // =====================================================

        #region Métodos de Grupos

        /// <summary>
        /// Obtiene todos los grupos
        /// </summary>
        public DataTable ObtenerGrupos()
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    g.group_id AS ID,
                    g.group_name AS Grupo,
                    g.group_code AS Código,
                    g.english_level AS Nivel,
                    ISNULL(u.username, 'Sin asignar') AS Maestro,
                    g.max_capacity AS Cupo,
                    (SELECT COUNT(*) FROM enrollments e WHERE e.group_id = g.group_id) AS Inscritos
                FROM groups g
                LEFT JOIN teachers t ON g.teacher_id = t.teacher_id
                LEFT JOIN users u ON t.user_id = u.user_id
                ORDER BY g.group_name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Busca grupos por nombre, código, nivel o maestro
        /// </summary>
        public DataTable BuscarGrupos(string busqueda)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    g.group_id AS ID,
                    g.group_name AS Grupo,
                    g.group_code AS Código,
                    g.english_level AS Nivel,
                    ISNULL(u.username, 'Sin asignar') AS Maestro,
                    g.max_capacity AS Cupo,
                    (SELECT COUNT(*) FROM enrollments e WHERE e.group_id = g.group_id) AS Inscritos
                FROM groups g
                LEFT JOIN teachers t ON g.teacher_id = t.teacher_id
                LEFT JOIN users u ON t.user_id = u.user_id
                WHERE g.group_name LIKE @busqueda 
                   OR g.group_code LIKE @busqueda
                   OR g.english_level LIKE @busqueda
                   OR u.username LIKE @busqueda
                ORDER BY g.group_name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Filtra grupos por nivel
        /// </summary>
        public DataTable FiltrarGruposPorNivel(string nivel)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    g.group_id AS ID,
                    g.group_name AS Grupo,
                    g.group_code AS Código,
                    g.english_level AS Nivel,
                    ISNULL(u.username, 'Sin asignar') AS Maestro,
                    g.max_capacity AS Cupo,
                    (SELECT COUNT(*) FROM enrollments e WHERE e.group_id = g.group_id) AS Inscritos
                FROM groups g
                LEFT JOIN teachers t ON g.teacher_id = t.teacher_id
                LEFT JOIN users u ON t.user_id = u.user_id
                WHERE g.english_level = @nivel
                ORDER BY g.group_name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nivel", nivel);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Obtiene el conteo de grupos por nivel
        /// </summary>
        public Dictionary<string, int> ObtenerConteoGruposPorNivel()
        {
            Dictionary<string, int> conteo = new Dictionary<string, int>();

            string query = @"
                SELECT english_level, COUNT(*) as cantidad
                FROM groups
                GROUP BY english_level";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nivel = reader["english_level"].ToString();
                            int cantidad = Convert.ToInt32(reader["cantidad"]);
                            conteo[nivel] = cantidad;
                        }
                    }
                }
            }

            return conteo;
        }

        /// <summary>
        /// Obtiene grupos para llenar ComboBox
        /// </summary>
        public DataTable ObtenerGruposParaCombo()
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT group_id, group_name, english_level
                FROM groups 
                ORDER BY group_name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Inserta un nuevo grupo
        /// </summary>
        public int InsertarGrupo(string nombre, string nivel, int? maestroId, int capacidad, string horario, string aula)
        {
            string codigo = "GRP" + DateTime.Now.ToString("yyMMddHHmmss");

            string query = @"
                INSERT INTO groups (group_name, group_code, english_level, teacher_id, max_capacity, schedule, classroom)
                VALUES (@nombre, @codigo, @nivel, @maestroId, @capacidad, @horario, @aula);
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@nivel", nivel);
                    cmd.Parameters.AddWithValue("@maestroId", maestroId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@capacidad", capacidad);
                    cmd.Parameters.AddWithValue("@horario", horario ?? "");
                    cmd.Parameters.AddWithValue("@aula", aula ?? "");

                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        /// <summary>
        /// Obtiene maestros para llenar ComboBox
        /// </summary>
        public DataTable ObtenerMaestrosParaCombo()
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT t.teacher_id, u.username 
                FROM teachers t
                INNER JOIN users u ON t.user_id = u.user_id
                WHERE u.is_active = 1
                ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        #endregion

        /// <summary>
        /// Obtiene grupos con información de cupo
        /// </summary>
        public DataTable ObtenerGruposConCupo()
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    g.group_id,
                    g.group_name,
                    g.english_level,
                    g.max_capacity AS CupoTotal,
                    (SELECT COUNT(*) FROM enrollments WHERE group_id = g.group_id) AS Inscritos,
                    g.max_capacity - (SELECT COUNT(*) FROM enrollments WHERE group_id = g.group_id) AS CupoDisponible
                FROM groups g
                ORDER BY g.group_name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Obtiene todos los estudiantes para el CheckedListBox
        /// </summary>
        public DataTable ObtenerEstudiantesParaSeleccion(int grupoId)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    s.student_id,
                    u.username AS Nombre,
                    u.email AS Email,
                    s.current_english_level AS Nivel
                FROM students s
                INNER JOIN users u ON s.user_id = u.user_id
                WHERE u.is_active = 1 
                AND s.student_id NOT IN (
                    SELECT student_id 
                    FROM enrollments 
                    WHERE group_id = @grupoId
                )
                ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@grupoId", grupoId);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Guarda las inscripciones de estudiantes en un grupo
        /// </summary>
        public bool GuardarInscripciones(int grupoId, List<int> estudiantesIds)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (int estudianteId in estudiantesIds)
                    {
                        string queryEnrollment = @"
                            INSERT INTO enrollments (student_id, group_id, enrollment_date, status)
                            VALUES (@studentId, @groupId, GETDATE(), 'activo')";

                        using (SqlCommand cmd = new SqlCommand(queryEnrollment, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@studentId", estudianteId);
                            cmd.Parameters.AddWithValue("@groupId", grupoId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar inscripciones: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Obtiene estudiantes por grupo (VERSIÓN CORREGIDA)
        /// </summary>
        public DataTable ObtenerEstudiantesPorGrupo(int grupoId)
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT 
            s.student_id,
            u.username AS Nombre,
            s.current_english_level AS Nivel,
            e.enrollment_date AS FechaInscripcion
        FROM enrollments e
        INNER JOIN students s ON e.student_id = s.student_id
        INNER JOIN users u ON s.user_id = u.user_id
        WHERE e.group_id = @grupoId AND e.status = 'activo'
        ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@grupoId", grupoId);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // =====================================================
        // MÉTODOS PARA MAESTROS
        // =====================================================

        /// <summary>
        /// Inserta un nuevo maestro
        /// </summary>
        public bool InsertarMaestro(string username, string email, string telefono,
                               string nivel, DateTime fechaIngreso, string teacherCode,
                               string contrasena = "maestro123") // ✅ 7mo parámetro
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Insertar en users con contraseña personalizada
                    string queryUser = @"
                INSERT INTO users (username, email, phone, password, user_role, is_active, created_at)
                VALUES (@username, @email, @phone, @password, 'maestro', 1, GETDATE());
                SELECT SCOPE_IDENTITY();";

                    int userId;
                    using (SqlCommand cmd = new SqlCommand(queryUser, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", telefono ?? "");
                        cmd.Parameters.AddWithValue("@password", contrasena); // ✅ contraseña personalizada
                        userId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Insertar en teachers
                    string queryTeacher = @"
                INSERT INTO teachers (user_id, teacher_code, english_level, hire_date)
                VALUES (@userId, @teacherCode, @nivel, @fechaIngreso)";

                    using (SqlCommand cmd = new SqlCommand(queryTeacher, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@teacherCode", teacherCode);
                        cmd.Parameters.AddWithValue("@nivel", nivel);
                        cmd.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // =====================================================
        // MÉTODOS PARA NIVELES
        // =====================================================

        #region Métodos de Niveles

        /// <summary>
        /// Obtiene todos los niveles activos
        /// </summary>
        public DataTable ObtenerNiveles()
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    level_id,
                    level_code,
                    level_name,
                    display_order
                FROM levels
                WHERE is_active = 1
                ORDER BY display_order";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Obtiene el total de unidades de un nivel
        /// </summary>
        public int ObtenerTotalUnidades(int nivelId)
        {
            int total = 0;

            string query = @"
                SELECT COUNT(*) 
                FROM units 
                WHERE level_id = @nivelId AND is_active = 1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nivelId", nivelId);
                    conn.Open();
                    total = (int)cmd.ExecuteScalar();
                }
            }
            return total;
        }

        #endregion

        // =====================================================
        // MÉTODO PARA OBTENER UNIDADES POR NIVEL
        // =====================================================
        public DataTable ObtenerUnidadesPorNivel(int nivelId)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    unit_id,
                    unit_number,
                    unit_title,
                    unit_description,
                    display_order
                FROM units
                WHERE level_id = @nivelId AND is_active = 1
                ORDER BY display_order";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nivelId", nivelId);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        /// <summary>
        /// Obtiene estudiantes por maestro (VERSIÓN CORREGIDA)
        /// </summary>
        public DataTable ObtenerEstudiantesPorMaestro(int maestroId)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    u.username AS Nombre,
                    u.email AS Email,
                    u.phone AS Telefono,
                    s.current_english_level AS Nivel,        -- 👈 CORREGIDO: current_level → current_english_level
                    s.enrollment_date AS FechaIngreso,
                    g.group_name AS Grupo
                FROM students s
                INNER JOIN users u ON s.user_id = u.user_id
                LEFT JOIN enrollments e ON s.student_id = e.student_id AND e.status = 'activo'  -- 👈 CORREGIDA LA RELACIÓN
                LEFT JOIN groups g ON e.group_id = g.group_id
                WHERE g.teacher_id = @maestroId
                ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
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
        // MÉTODO PARA OBTENER LECCIONES POR UNIDAD
        // =====================================================
        public DataTable ObtenerLeccionesPorUnidad(int unitId)
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT 
            lesson_id,
            lesson_number,
            lesson_title,
            lesson_type,
            duration_minutes
        FROM lessons
        WHERE unit_id = @unitId AND is_active = 1
        ORDER BY display_order";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@unitId", unitId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }// =====================================================
         // MÉTODO PARA OBTENER LECCIONES POR UNIDAD
         // =====================================================


        // =====================================================
        // MÉTODO PARA CONTAR LECCIONES POR NIVEL
        // =====================================================
        public int ContarLeccionesPorNivel(int nivelId)
        {
            int total = 0;

            string query = @"
        SELECT COUNT(*) 
        FROM lessons l
        INNER JOIN units u ON l.unit_id = u.unit_id
        WHERE u.level_id = @nivelId AND l.is_active = 1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nivelId", nivelId);
                    conn.Open();
                    total = (int)cmd.ExecuteScalar();
                }
            }
            return total;
        }

        /// <summary>
        /// Obtiene el detalle completo de unidades con lecciones
        /// </summary>
        public DataTable ObtenerUnidadesConDetalle(int nivelId)
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT 
            u.unit_id,
            u.unit_number,
            u.unit_title,
            u.unit_description,
            COUNT(l.lesson_id) AS total_lecciones,
            ISNULL(SUM(l.duration_minutes), 0) AS duracion_total
        FROM units u
        LEFT JOIN lessons l ON u.unit_id = l.unit_id AND l.is_active = 1
        WHERE u.level_id = @nivelId AND u.is_active = 1
        GROUP BY u.unit_id, u.unit_number, u.unit_title, u.unit_description, u.display_order
        ORDER BY u.display_order";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nivelId", nivelId);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }


        public DataTable ObtenerEstudiantesConDetalle(string? nivel = null)
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT 
            s.student_id,
            u.username AS Nombre,
            s.current_english_level AS Nivel,
            s.enrollment_date AS FechaIngreso,
            g.group_name AS Grupo,
            u2.username AS Maestro
        FROM students s
        INNER JOIN users u ON s.user_id = u.user_id
        LEFT JOIN enrollments e ON s.student_id = e.student_id AND e.status = 'activo'
        LEFT JOIN groups g ON e.group_id = g.group_id
        LEFT JOIN teachers t ON g.teacher_id = t.teacher_id
        LEFT JOIN users u2 ON t.user_id = u2.user_id
        WHERE u.is_active = 1";

            if (!string.IsNullOrEmpty(nivel))
            {
                query += " AND s.current_english_level = @nivel";
            }

            query += " ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(nivel))
                    {
                        cmd.Parameters.AddWithValue("@nivel", nivel);
                    }

                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        /// <summary>
        /// Obtiene todos los maestros con información de grupos
        /// </summary>
        public DataTable ObtenerMaestrosConGrupos(string nivel = null)
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT 
            t.teacher_id,
            u.username AS Usuario,
            u.email AS Email,
            t.english_level AS Nivel,
            t.hire_date AS FechaIngreso,
            STRING_AGG(g.group_name, ', ') AS Grupos
        FROM teachers t
        INNER JOIN users u ON t.user_id = u.user_id
        LEFT JOIN groups g ON t.teacher_id = g.teacher_id
        WHERE u.is_active = 1";

            if (!string.IsNullOrEmpty(nivel))
            {
                query += " AND t.english_level = @nivel";
            }

            query += " GROUP BY t.teacher_id, u.username, u.email, t.english_level, t.hire_date ORDER BY u.username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(nivel))
                    {
                        cmd.Parameters.AddWithValue("@nivel", nivel);
                    }

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }



    }
}