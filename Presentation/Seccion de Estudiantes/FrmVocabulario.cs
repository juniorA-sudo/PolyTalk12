using Guna.UI2.WinForms;
using Presentation;
using Presentation.Controls;
using Presentation.Login__Register__Principal;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Seccion_de_Estudiantes
{
    public partial class FrmVocabulario : Form
    {
        private VocabularyService vocabularyService;
        private int userId;

        public FrmVocabulario(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            vocabularyService = new VocabularyService();
            ConfigurarFormulario();
            CargarListasDesdeBD();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Vocabulario";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void CargarListasDesdeBD()
        {
            try
            {
                flpCategorias.SuspendLayout();
                flpCategorias.Controls.Clear();

                DataTable listas = vocabularyService.ObtenerListasUsuario(userId, true);

                if (listas.Rows.Count == 0)
                {
                    Label lblSinListas = new Label
                    {
                        Text = "No hay listas de vocabulario. ¡Crea una nueva!",
                        Font = new Font("Segoe UI", 12),
                        ForeColor = Color.Gray,
                        AutoSize = true
                    };
                    flpCategorias.Controls.Add(lblSinListas);
                }
                else
                {
                    foreach (DataRow row in listas.Rows)
                    {
                        int listId = Convert.ToInt32(row["list_id"]);
                        string nombre = row["list_name"].ToString();
                        string icono = row["icon"].ToString();
                        string colorHex = row["color_code"].ToString();
                        int totalPalabras = Convert.ToInt32(row["total_words"]);

                        Color colorFondo;
                        try { colorFondo = ColorTranslator.FromHtml(colorHex); }
                        catch { colorFondo = Color.FromArgb(102, 126, 234); }

                        UCVocabularioCard card = new UCVocabularioCard
                        {
                            Titulo = nombre,
                            TotalPalabras = totalPalabras,
                            IconoTexto = icono,
                            ColorFondo = colorFondo,
                            Tag = listId,
                            Margin = new Padding(5)
                        };

                        card.CategoriaClick += (s, args) =>
                        {
                            AbrirDetalleLista(listId, nombre, icono, colorHex);
                        };

                        card.FavoritoClick += (s, args) =>
                        {
                            MessageBox.Show(card.EsFavorito
                                ? $"⭐ {nombre} agregada a favoritos"
                                : $"☆ {nombre} quitada de favoritos",
                                "Favorito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        };

                        flpCategorias.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar listas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                flpCategorias.ResumeLayout();
            }
        }

        // ✅ CORREGIDO — abre FrmDetalleLista dentro del panelContenedor del FrmPrincipal
        private void AbrirDetalleLista(int listId, string nombre, string icono, string colorHex)
        {
            FrmPrincipal frmPrincipal = Application.OpenForms["FrmPrincipal"] as FrmPrincipal;

            if (frmPrincipal != null)
            {
                // Abre dentro del panel del FrmPrincipal pasando la referencia
                var frm = new FrmDetalleLista(listId, userId, nombre, icono, colorHex, frmPrincipal);
                frmPrincipal.AbrirFormEnPanel(frm);
            }
            else
            {
                // Fallback: si no se encuentra el FrmPrincipal, abre como diálogo normal
                using (var frm = new FrmDetalleLista(listId, userId, nombre, icono, colorHex, null))
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                    CargarListasDesdeBD();
                }
            }
        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            using (FrmNuevaListaVocabulario frm = new FrmNuevaListaVocabulario(userId))
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarListasDesdeBD();
                    MessageBox.Show($"Lista '{frm.NombreLista}' creada correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToLower();
            foreach (Control ctrl in flpCategorias.Controls)
            {
                if (ctrl is UCVocabularioCard card)
                {
                    card.Visible = string.IsNullOrEmpty(filtro) ||
                                   card.Titulo.ToLower().Contains(filtro);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}