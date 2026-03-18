using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmSeleccionarEstudiantes : Form
    {
        // =====================================================
        // CAMPOS PRIVADOS
        // =====================================================
        private DatabaseHelper db = new DatabaseHelper();
        private DataTable dtEstudiantes;
        private int grupoId;  // 👈 NUEVA VARIABLE
        private int cupoMaximo = 0;
        private List<int> idsSeleccionados = new List<int>(); // Para guardar IDs seleccionados

        // =====================================================
        // CONSTRUCTOR
        // =====================================================
        public FrmSeleccionarEstudiantes(int cupoDisponible, int idGrupo)
        {
            InitializeComponent();
            ConfigurarFormulario();
            cupoMaximo = cupoDisponible;
            grupoId = idGrupo;  // 👈 GUARDA EL ID DEL GRUPO
            lblContador.Text = $"0/{cupoMaximo}";

            // Configurar placeholder del TextBox
            txtBuscar.Text = "Buscar estudiante por nombre, email o nivel...";
            txtBuscar.ForeColor = Color.Gray;

            // Cargar niveles en ComboBox
            CargarNivelesEnComboBox();

            ConfigurarDataGridView();
            CargarEstudiantes();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Seleccionar Estudiantes";
            this.Size = new Size(450, 400);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        // =====================================================
        // CARGAR NIVELES EN EL COMBOBOX
        // =====================================================
        private void CargarNivelesEnComboBox()
        {
            cmbFiltroNivel.Items.Clear();
            cmbFiltroNivel.Items.Add("Todos los niveles");
            cmbFiltroNivel.Items.Add("A1");
            cmbFiltroNivel.Items.Add("A2");
            cmbFiltroNivel.Items.Add("B1");
            cmbFiltroNivel.Items.Add("B2");
            cmbFiltroNivel.Items.Add("C1");
            cmbFiltroNivel.Items.Add("C2");
            cmbFiltroNivel.SelectedIndex = 0;

            // Agregar evento
            cmbFiltroNivel.SelectedIndexChanged += cmbFiltroNivel_SelectedIndexChanged;
        }

        // =====================================================
        // CONFIGURAR DATAGRIDVIEW CON CHECKBOX
        // =====================================================
        private void ConfigurarDataGridView()
        {
            // Limpiar columnas existentes
            dgvStudents.Columns.Clear();

            // Desactivar generación automática
            dgvStudents.AutoGenerateColumns = false;

            // Configurar propiedades básicas
            dgvStudents.SelectionMode = DataGridViewSelectionMode.CellSelect; // Cambiado para permitir checkbox individual
            dgvStudents.MultiSelect = false; // No selección de filas
            dgvStudents.ReadOnly = false; // Permitir editar checkboxes
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Columna de selección (CheckBox) - INDICE 0
            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.Name = "Seleccion";
            chkColumn.HeaderText = "Sel";
            chkColumn.Width = 40;
            chkColumn.ReadOnly = false;
            dgvStudents.Columns.Add(chkColumn);

            // Columna ID (oculta)
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "student_id";
            colId.HeaderText = "ID";
            colId.DataPropertyName = "student_id";
            colId.Visible = false;
            colId.ReadOnly = true;
            dgvStudents.Columns.Add(colId);

            // Columna Nombre
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "Nombre";
            colNombre.Width = 150;
            colNombre.ReadOnly = true;
            dgvStudents.Columns.Add(colNombre);

            // Columna Email
            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "Email";
            colEmail.HeaderText = "Email";
            colEmail.DataPropertyName = "Email";
            colEmail.Width = 200;
            colEmail.ReadOnly = true;
            dgvStudents.Columns.Add(colEmail);

            // Columna Nivel
            DataGridViewTextBoxColumn colNivel = new DataGridViewTextBoxColumn();
            colNivel.Name = "Nivel";
            colNivel.HeaderText = "Nivel";
            colNivel.DataPropertyName = "Nivel";
            colNivel.Width = 60;
            colNivel.ReadOnly = true;
            dgvStudents.Columns.Add(colNivel);

            // Eventos para controlar selección por checkbox
            dgvStudents.CurrentCellDirtyStateChanged += dgvStudents_CurrentCellDirtyStateChanged;
            dgvStudents.CellValueChanged += dgvStudents_CellValueChanged;
        }

        // =====================================================
        // CARGAR ESTUDIANTES EN EL DATAGRIDVIEW
        // =====================================================
        private void CargarEstudiantes()
        {
            try
            {
                // 👇 AHORA PASA EL ID DEL GRUPO
                dtEstudiantes = db.ObtenerEstudiantesParaSeleccion(grupoId);

                if (dtEstudiantes == null || dtEstudiantes.Rows.Count == 0)
                {
                    MessageBox.Show("No hay estudiantes disponibles para este grupo");
                    return;
                }

                dgvStudents.DataSource = dtEstudiantes;
                dgvStudents.Columns["Seleccion"].DisplayIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estudiantes: " + ex.Message);
            }
        }

        // =====================================================
        // APLICAR FILTROS (NIVEL + BÚSQUEDA)
        // =====================================================
        private void AplicarFiltros()
        {
            if (dtEstudiantes == null) return;

            string nivel = cmbFiltroNivel.SelectedItem.ToString();
            string busqueda = txtBuscar.Text;

            // Si es el placeholder, tratar como vacío
            if (busqueda == "Buscar estudiante por nombre, email o nivel...")
                busqueda = "";

            DataView dv = dtEstudiantes.DefaultView;
            dv.RowFilter = "";

            List<string> filtros = new List<string>();

            // Filtro por nivel
            if (nivel != "Todos los niveles")
            {
                filtros.Add($"Nivel = '{nivel}'");
            }

            // Filtro por búsqueda
            if (!string.IsNullOrEmpty(busqueda))
            {
                filtros.Add($"(Nombre LIKE '%{busqueda}%' OR Email LIKE '%{busqueda}%')");
            }

            // Combinar filtros
            if (filtros.Count > 0)
            {
                dv.RowFilter = string.Join(" AND ", filtros);
            }

            dgvStudents.DataSource = dv;
        }

        // =====================================================
        // FILTRO POR NIVEL
        // =====================================================
        private void cmbFiltroNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        // =====================================================
        // BÚSQUEDA
        // =====================================================
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        // =====================================================
        // CONTROLAR LÍMITE DE SELECCIÓN POR CHECKBOX
        // =====================================================
        private void dgvStudents_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvStudents.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Solo interesa la columna de selección (índice 0)
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                int seleccionados = ContarSeleccionados();

                // Verificar si excede el límite
                if (seleccionados > cupoMaximo)
                {
                    // Desmarcar el último checkbox
                    dgvStudents.Rows[e.RowIndex].Cells[0].Value = false;
                    MessageBox.Show($"Solo puedes seleccionar {cupoMaximo} estudiantes", "Límite alcanzado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    seleccionados = ContarSeleccionados();
                }

                // Actualizar contador
                lblContador.Text = $"{seleccionados}/{cupoMaximo}";

                // Cambiar color si se alcanza el límite
                if (seleccionados >= cupoMaximo)
                    lblContador.ForeColor = Color.Red;
                else
                    lblContador.ForeColor = Color.FromArgb(79, 70, 229);
            }
        }

        private int ContarSeleccionados()
        {
            int count = 0;
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row.Cells["Seleccion"].Value != null && (bool)row.Cells["Seleccion"].Value)
                    count++;
            }
            return count;
        }

        // =====================================================
        // BOTONES DE SELECCIÓN RÁPIDA (OPCIONAL)
        // =====================================================
        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            int disponibles = dtEstudiantes.Rows.Count;
            if (disponibles > cupoMaximo)
            {
                MessageBox.Show($"Solo puedes seleccionar {cupoMaximo} estudiantes");
                return;
            }

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                row.Cells["Seleccion"].Value = true;
            }
            ActualizarContador();
        }

        private void btnLimpiarSeleccion_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                row.Cells["Seleccion"].Value = false;
            }
            ActualizarContador();
        }

        private void ActualizarContador()
        {
            int seleccionados = ContarSeleccionados();
            lblContador.Text = $"{seleccionados}/{cupoMaximo}";
        }

        // =====================================================
        // EVENTO ENTER - Cuando el usuario hace clic
        // =====================================================
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar estudiante por nombre, email o nivel...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        // =====================================================
        // EVENTO LEAVE - Cuando el usuario sale
        // =====================================================
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar estudiante por nombre, email o nivel...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        // =====================================================
        // BOTÓN AGREGAR
        // =====================================================
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ContarSeleccionados() == 0)
            {
                MessageBox.Show("Selecciona al menos un estudiante (marca los checkboxes)");
                return;
            }

            List<int> idsSeleccionados = new List<int>();

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row.Cells["Seleccion"].Value != null && (bool)row.Cells["Seleccion"].Value)
                {
                    int id = Convert.ToInt32(row.Cells["student_id"].Value);
                    idsSeleccionados.Add(id);
                }
            }

            this.Tag = idsSeleccionados;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}