using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

namespace Presentation
{
    public partial class FrmNuevaLeccion : Form
    {
        public int UnitId { get; set; }
        public string UnitTitle { get; set; }
        public int LevelId { get; set; }
        public string LevelName { get; set; }

        private string connectionString = @"Data Source=JUNIOR\JUNIOR;Initial Catalog=PruebaPolyTalk;Integrated Security=True;TrustServerCertificate=True;";
        private string placeholderTitulo = "Ej: Movie Vocabulary";
        private string placeholderDescripcion = "Ej: Aprende vocabulario relacionado con películas y cine";

        private int? unidadSeleccionadaId = null;

        public FrmNuevaLeccion()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarNiveles();
            CargarTiposLeccion();
            ConfigurarPlaceholders();

            if (LevelId > 0 && UnitId > 0)
                SeleccionarNivelUnidad();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Crear Nueva Lección";
            this.Size = new Size(450, 589);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            if (dtpFechaPublicacion != null)
                dtpFechaPublicacion.Value = DateTime.Now;
        }

        private void ConfigurarPlaceholders()
        {
            // Título
            txtTitulo.Text = placeholderTitulo;
            txtTitulo.ForeColor = Color.Gray;

            // Descripción
            txtDescripcion.Text = placeholderDescripcion;
            txtDescripcion.ForeColor = Color.Gray;

            // Duración
            nudDuracion.Text = "30";
            nudDuracion.ForeColor = Color.Gray;
        }

        private void CargarNiveles()
        {
            try
            {
                cmbNivel.Items.Clear();

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT level_id, level_code, level_name FROM levels WHERE is_active = 1 ORDER BY display_order", conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string texto = $"{reader.GetString(1)} - {reader.GetString(2)}";
                            cmbNivel.Items.Add(new { Text = texto, Value = id });
                        }
                    }
                }

                cmbNivel.DisplayMember = "Text";
                cmbNivel.ValueMember = "Value";

                if (cmbNivel.Items.Count > 0)
                    cmbNivel.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando niveles: {ex.Message}");
            }
        }

        private void CargarTiposLeccion()
        {
            cmbTipoLeccion.Items.Clear();
            cmbTipoLeccion.Items.Add("🔤 Vocabulario");
            cmbTipoLeccion.Items.Add("📚 Gramática");
            cmbTipoLeccion.Items.Add("🗣️ Speaking");
            cmbTipoLeccion.Items.Add("🎧 Listening");
            cmbTipoLeccion.Items.Add("📖 Lectura");
            cmbTipoLeccion.Items.Add("✍️ Escritura");
            cmbTipoLeccion.Items.Add("✏️ Ejercicio");
            cmbTipoLeccion.Items.Add("📝 Quiz");
            cmbTipoLeccion.Items.Add("🎬 Video");
            cmbTipoLeccion.SelectedIndex = 0;
        }

        private void CargarUnidades(int nivelId)
        {
            dgvUnidades.Rows.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(@"
                    SELECT unit_id, unit_number, unit_title 
                    FROM units 
                    WHERE level_id = @nivelId AND is_active = 1 
                    ORDER BY unit_number", conn))
                {
                    cmd.Parameters.AddWithValue("@nivelId", nivelId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            int num = reader.GetInt32(1);
                            string titulo = reader.GetString(2);
                            string texto = $"Unidad {num} - {titulo}";
                            dgvUnidades.Rows.Add(id, texto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando unidades: {ex.Message}");
            }
        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedItem != null)
            {
                dynamic item = cmbNivel.SelectedItem;
                CargarUnidades(item.Value);
                unidadSeleccionadaId = null; // resetear selección
            }
        }

        private void dgvUnidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUnidades.Rows[e.RowIndex];
                unidadSeleccionadaId = Convert.ToInt32(row.Cells["colUnitId"].Value);

                // Resaltar fila seleccionada
                foreach (DataGridViewRow r in dgvUnidades.Rows)
                    r.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.BackColor = Color.FromArgb(230, 240, 255);
            }
        }

        private void SeleccionarNivelUnidad()
        {
            // Seleccionar nivel
            for (int i = 0; i < cmbNivel.Items.Count; i++)
            {
                dynamic item = cmbNivel.Items[i];
                if (item.Value == LevelId)
                {
                    cmbNivel.SelectedIndex = i;
                    break;
                }
            }

            Application.DoEvents();

            // Seleccionar unidad en el DataGridView
            for (int i = 0; i < dgvUnidades.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvUnidades.Rows[i].Cells["colUnitId"].Value) == UnitId)
                {
                    dgvUnidades.Rows[i].Selected = true;
                    dgvUnidades_CellClick(null, new DataGridViewCellEventArgs(i, 0));
                    break;
                }
            }
        }

        private bool ValidarCampos()
        {
            if (txtTitulo.Text == placeholderTitulo || string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título de la lección es requerido");
                txtTitulo.Focus();
                return false;
            }

            if (cmbNivel.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un nivel");
                return false;
            }

            if (unidadSeleccionadaId == null)
            {
                MessageBox.Show("Debes seleccionar una unidad de la lista");
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                int unidadId = unidadSeleccionadaId.Value;

                string tipoSeleccionado = cmbTipoLeccion.SelectedItem?.ToString() ?? "exercise";
                string tipo = tipoSeleccionado.Contains(" ") ?
                    tipoSeleccionado.Substring(tipoSeleccionado.IndexOf(" ") + 1).ToLower() : "exercise";

                int duracion = 30;
                int.TryParse(nudDuracion.Text, out duracion);

                int nextNumber = ObtenerSiguienteNumero(unidadId);

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO lessons (unit_id, lesson_number, lesson_title, lesson_description, 
                        lesson_type, duration_minutes, display_order, is_active, created_at)
                    VALUES (@uid, @num, @tit, @desc, @tipo, @dur, @num, 1, @fecha);
                    SELECT SCOPE_IDENTITY();", conn))
                {
                    cmd.Parameters.AddWithValue("@uid", unidadId);
                    cmd.Parameters.AddWithValue("@num", nextNumber);
                    cmd.Parameters.AddWithValue("@tit", txtTitulo.Text.Trim());

                    string desc = txtDescripcion.Text == placeholderDescripcion ? "" : txtDescripcion.Text.Trim();
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@dur", duracion);
                    cmd.Parameters.AddWithValue("@fecha", dtpFechaPublicacion.Value);

                    conn.Open();
                    int id = Convert.ToInt32(cmd.ExecuteScalar());

                    if (id > 0)
                    {
                        MessageBox.Show("Lección agregada correctamente");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }
        }

        private int ObtenerSiguienteNumero(int unidadId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(MAX(lesson_number), 0) + 1 FROM lessons WHERE unit_id = @uid", conn))
                {
                    cmd.Parameters.AddWithValue("@uid", unidadId);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch
            {
                return 1;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cancelar? Los cambios no guardados se perderán.",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(sender, e);
        }

        // Placeholders
        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            if (txtTitulo.Text == placeholderTitulo)
            {
                txtTitulo.Text = "";
                txtTitulo.ForeColor = Color.Black;
            }
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                txtTitulo.Text = placeholderTitulo;
                txtTitulo.ForeColor = Color.Gray;
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == placeholderDescripcion)
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.Text = placeholderDescripcion;
                txtDescripcion.ForeColor = Color.Gray;
            }
        }

        private void nudDuracion_Enter(object sender, EventArgs e)
        {
            if (nudDuracion.Text == "30")
            {
                nudDuracion.Text = "";
                nudDuracion.ForeColor = Color.Black;
            }
        }

        private void nudDuracion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nudDuracion.Text))
            {
                nudDuracion.Text = "30";
                nudDuracion.ForeColor = Color.Gray;
            }
        }
    }
}