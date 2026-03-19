using Guna.UI2.WinForms;
using Presentation;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Seccion_de_Estudiantes
{
    public partial class FrmNuevaListaVocabulario : Form
    {
        // Propiedades públicas
        public string NombreLista { get; private set; } = string.Empty;
        public string Descripcion { get; private set; } = string.Empty;
        public Color ColorLista { get; private set; }
        public string Icono { get; private set; } = string.Empty;
        public int ListaId { get; private set; } = 0;

        private int userId; // ✅ Ya no hardcodeado
        private VocabularyService vocabularyService;
        private bool esEdicion = false;

        private Color[] colores = new Color[]
        {
            Color.FromArgb(66, 153, 225),   // Azul
            Color.FromArgb(245, 101, 101),  // Rojo
            Color.FromArgb(72, 187, 120),   // Verde
            Color.FromArgb(237, 137, 54),   // Naranja
            Color.FromArgb(159, 122, 234),  // Púrpura
            Color.FromArgb(237, 100, 166),  // Rosa
            Color.FromArgb(56, 178, 172),   // Teal
            Color.FromArgb(102, 126, 234)   // Índigo
        };

        private string[] iconos = new string[]
        {
            "🐕", "🐈", "🐦", "🐟", "🐒", "🐘", "🦒", "🦓",
            "🍎", "🍕", "🥗", "🍣", "🍩", "☕", "🧃", "🥑",
            "✈️", "🚗", "🚢", "🚲", "🏖️", "🗽", "🗼", "🌋",
            "🏠", "🛋️", "🚪", "🪑", "🛏️", "🚿", "🧹", "🧺"
        };

        private int colorSeleccionado = 0;
        private int iconoSeleccionado = 0;

        // ✅ Constructor para CREAR lista — recibe el userId del usuario logueado
        public FrmNuevaListaVocabulario(int userId)
        {
            InitializeComponent();
            this.userId = userId; // ✅ Asigna dinámicamente
            vocabularyService = new VocabularyService();
            ConfigurarFormulario();
            CargarColores();
            CargarIconos();
            ActualizarVistaPrevia();
            esEdicion = false;
            btnCrear.Text = "Crear Lista";
        }

        // ✅ Constructor para EDITAR lista — también recibe el userId
        public FrmNuevaListaVocabulario(int userId, int listaId, string nombre, string descripcion, string icono, string colorHex)
        {
            InitializeComponent();
            this.userId = userId; // ✅ Asigna dinámicamente
            vocabularyService = new VocabularyService();
            ConfigurarFormulario();
            CargarColores();
            CargarIconos();

            this.ListaId = listaId;
            this.esEdicion = true;

            txtNombre.Text = nombre;
            txtNombre.ForeColor = Color.Black;

            if (!string.IsNullOrEmpty(descripcion) && descripcion != "Ej: Vocabulario básico de animales")
            {
                txtDescripcion.Text = descripcion;
                txtDescripcion.ForeColor = Color.Black;
            }

            SeleccionarColorPorHex(colorHex);
            SeleccionarIconoPorValor(icono);
            ActualizarVistaPrevia();

            this.Text = "Editar Lista de Vocabulario";
            btnCrear.Text = "Actualizar Lista";
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Nueva Lista de Vocabulario";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(480, 650);
        }

        private void SeleccionarColorPorHex(string hexColor)
        {
            try
            {
                Color color = ColorTranslator.FromHtml(hexColor);
                for (int i = 0; i < colores.Length; i++)
                {
                    if (colores[i].ToArgb() == color.ToArgb())
                    {
                        colorSeleccionado = i;
                        ResaltarColorSeleccionado();
                        break;
                    }
                }
            }
            catch { }
        }

        private void SeleccionarIconoPorValor(string icono)
        {
            for (int i = 0; i < iconos.Length; i++)
            {
                if (iconos[i] == icono)
                {
                    iconoSeleccionado = i;
                    ResaltarIconoSeleccionado();
                    btnPreviewIcon.Text = iconos[iconoSeleccionado];
                    break;
                }
            }
        }

        private void CargarColores()
        {
            flowLayoutPanelColores.Controls.Clear();
            flowLayoutPanelColores.AutoScroll = true;
            flowLayoutPanelColores.WrapContents = true;
            flowLayoutPanelColores.Padding = new Padding(5);

            for (int i = 0; i < colores.Length; i++)
            {
                Guna2Button btnColor = new Guna2Button
                {
                    Size = new Size(40, 40),
                    FillColor = colores[i],
                    BorderRadius = 8,
                    BorderThickness = 0,
                    Tag = i,
                    Cursor = Cursors.Hand,
                    Margin = new Padding(3)
                };

                int index = i;
                btnColor.Click += (s, e) =>
                {
                    colorSeleccionado = index;
                    ResaltarColorSeleccionado();
                    ActualizarVistaPrevia();
                };

                flowLayoutPanelColores.Controls.Add(btnColor);
            }

            ResaltarColorSeleccionado();
            flowLayoutPanelColores.Refresh();
        }

        private void ResaltarColorSeleccionado()
        {
            for (int i = 0; i < flowLayoutPanelColores.Controls.Count; i++)
            {
                if (flowLayoutPanelColores.Controls[i] is Guna2Button btn)
                {
                    if (i == colorSeleccionado)
                    {
                        btn.BorderThickness = 3;
                        btn.BorderColor = Color.FromArgb(45, 55, 72);
                    }
                    else
                    {
                        btn.BorderThickness = 0;
                    }
                }
            }
        }

        private void CargarIconos()
        {
            flowLayoutPanelIconos.Controls.Clear();
            flowLayoutPanelIconos.AutoScroll = true;
            flowLayoutPanelIconos.WrapContents = true;
            flowLayoutPanelIconos.Padding = new Padding(5);

            for (int i = 0; i < iconos.Length; i++)
            {
                Guna2Button btnIcono = new Guna2Button
                {
                    Size = new Size(45, 45),
                    Text = iconos[i],
                    Font = new Font("Segoe UI Emoji", 16F),
                    FillColor = Color.FromArgb(248, 250, 252),
                    BorderColor = Color.FromArgb(226, 232, 240),
                    BorderThickness = 1,
                    BorderRadius = 8,
                    ForeColor = Color.FromArgb(74, 85, 104),
                    Tag = i,
                    Cursor = Cursors.Hand,
                    Margin = new Padding(3)
                };

                int index = i;
                btnIcono.Click += (s, e) =>
                {
                    iconoSeleccionado = index;
                    ResaltarIconoSeleccionado();
                    btnPreviewIcon.Text = iconos[iconoSeleccionado];
                    ActualizarVistaPrevia();
                };

                flowLayoutPanelIconos.Controls.Add(btnIcono);
            }

            ResaltarIconoSeleccionado();
            flowLayoutPanelIconos.Refresh();
        }

        private void ResaltarIconoSeleccionado()
        {
            for (int i = 0; i < flowLayoutPanelIconos.Controls.Count; i++)
            {
                if (flowLayoutPanelIconos.Controls[i] is Guna2Button btn)
                {
                    if (i == iconoSeleccionado)
                    {
                        btn.FillColor = Color.FromArgb(102, 126, 234);
                        btn.ForeColor = Color.White;
                        btn.BorderColor = Color.FromArgb(102, 126, 234);
                    }
                    else
                    {
                        btn.FillColor = Color.FromArgb(248, 250, 252);
                        btn.ForeColor = Color.FromArgb(74, 85, 104);
                        btn.BorderColor = Color.FromArgb(226, 232, 240);
                    }
                }
            }
        }

        private void ActualizarVistaPrevia()
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombre) || nombre == "Ej: Animales")
                    nombre = "Animales";

                Color color = colores[colorSeleccionado];
                panelPreview.FillColor = color;

                btnPreviewIcon.Text = iconos[iconoSeleccionado];
                lblPreviewTitle.Text = nombre;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ActualizarVistaPrevia();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text == "Ej: Animales")
            {
                MessageBox.Show("Ingresa un nombre para la lista", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            // Asignar valores
            NombreLista = txtNombre.Text.Trim();
            Descripcion = (txtDescripcion.Text == "Ej: Vocabulario básico de animales" || string.IsNullOrWhiteSpace(txtDescripcion.Text))
                ? ""
                : txtDescripcion.Text.Trim();
            ColorLista = colores[colorSeleccionado];
            Icono = iconos[iconoSeleccionado];
            string colorHex = ColorTranslator.ToHtml(ColorLista);

            try
            {
                int newListId = vocabularyService.CrearLista(userId, NombreLista, Descripcion, Icono, colorHex);

                if (newListId > 0)
                {
                    this.ListaId = newListId;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error al crear la lista. Intenta de nuevo.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Placeholders
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Ej: Animales")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Ej: Animales";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Ej: Vocabulario básico de animales")
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.Text = "Ej: Vocabulario básico de animales";
                txtDescripcion.ForeColor = Color.Gray;
            }
        }
    }
}