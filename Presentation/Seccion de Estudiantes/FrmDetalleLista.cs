using Presentation.Seccion_de_Estudiantes;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Web;
using System.Windows.Forms;

namespace Presentation.Login__Register__Principal
{
    public partial class FrmDetalleLista : Form
    {
        private readonly VocabularyService vocabularyService;
        private readonly int listId;
        private readonly int userId;
        private readonly string listName;
        private readonly string colorHex;
        private readonly string icono;
        private readonly FrmPrincipal frmPrincipal; // ✅ referencia al padre

        // ✅ Constructor actualizado — recibe FrmPrincipal
        public FrmDetalleLista(int listId, int userId, string listName,
                               string icono, string colorHex, FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.listId = listId;
            this.userId = userId;
            this.listName = listName;
            this.icono = icono;
            this.colorHex = colorHex;
            this.frmPrincipal = frmPrincipal;
            vocabularyService = new VocabularyService();
        }

        private void FrmDetalleLista_Load(object sender, EventArgs e)
        {
            ConfigurarUI();
            CargarPalabras();
        }

        private void ConfigurarUI()
        {
            lblTituloLista.Text = $"{icono} {listName}";
            try { panelHeader.FillColor = ColorTranslator.FromHtml(colorHex); }
            catch { panelHeader.FillColor = Color.FromArgb(102, 126, 234); }

            dgvPalabras.Columns.Clear();
            dgvPalabras.AutoGenerateColumns = false;

            dgvPalabras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIngles",
                HeaderText = "🇺🇸 Inglés",
                DataPropertyName = "word_english",
                Width = 200
            });
            dgvPalabras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEspanol",
                HeaderText = "🇪🇸 Español",
                DataPropertyName = "word_spanish",
                Width = 200
            });
            dgvPalabras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colImagen",
                HeaderText = "Imagen",
                DataPropertyName = "image_url",
                Width = 100
            });

            var btnAudio = new DataGridViewButtonColumn
            {
                Name = "colAudio",
                HeaderText = "Audio",
                Text = "🔊",
                UseColumnTextForButtonValue = true,
                Width = 70
            };
            dgvPalabras.Columns.Add(btnAudio);

            var btnEliminar = new DataGridViewButtonColumn
            {
                Name = "colEliminar",
                HeaderText = "",
                Text = "🗑",
                UseColumnTextForButtonValue = true,
                Width = 50
            };
            dgvPalabras.Columns.Add(btnEliminar);

            dgvPalabras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colWordId",
                DataPropertyName = "word_id",
                Visible = false
            });

            dgvPalabras.RowHeadersVisible = false;
            dgvPalabras.AllowUserToAddRows = false;
            dgvPalabras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarPalabras()
        {
            try
            {
                DataTable palabras = vocabularyService.ObtenerPalabrasDeLista(listId);
                dgvPalabras.DataSource = palabras;
                int total = palabras.Rows.Count;
                lblTotalPalabras.Text = $"{total} {(total == 1 ? "palabra" : "palabras")}";
                btnPracticar.Enabled = total >= 4;
                lblMinimo.Visible = total < 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarPalabra_Click(object sender, EventArgs e)
        {
            using (FrmAgregarPalabra frm = new FrmAgregarPalabra(listId))
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                    CargarPalabras();
            }
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            if (frmPrincipal != null)
            {
                var frm = new FrmPracticar(listId, userId, listName, frmPrincipal,
                                           colorHex, icono);
                frmPrincipal.AbrirFormEnPanel(frm);
            }

            else
            {
                // Fallback
                using (var frm = new FrmPracticar(listId, userId, listName, null, colorHex, icono))
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                    CargarPalabras();
                }
            }
        }

        // ✅ VOLVER — regresa al FrmVocabulario en el panel contenedor
        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormEnPanel(new FrmVocabulario(userId));
            }
            else
            {
                this.Close();
            }
        }

        private void dgvPalabras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPalabras.Columns[e.ColumnIndex].Name == "colAudio")
            {
                string palabra = dgvPalabras.Rows[e.RowIndex].Cells["colIngles"].Value?.ToString();
                if (!string.IsNullOrEmpty(palabra))
                    EscucharPalabra(palabra);
            }

            if (dgvPalabras.Columns[e.ColumnIndex].Name == "colEliminar")
            {
                if (MessageBox.Show("¿Eliminar esta palabra?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int wordId = Convert.ToInt32(dgvPalabras.Rows[e.RowIndex].Cells["colWordId"].Value);
                    if (vocabularyService.EliminarPalabra(wordId))
                        CargarPalabras();
                }
            }
        }

        private void dgvPalabras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPalabras.Columns[e.ColumnIndex].Name == "colImagen")
            {
                e.Value = string.IsNullOrEmpty(e.Value?.ToString()) ? "Sin imagen" : "✅ Tiene imagen";
                e.FormattingApplied = true;
            }
        }

        // =====================================================
        // AUDIO — VBScript + SAPI
        // =====================================================
        private void EscucharPalabra(string palabra)
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                try
                {
                    string vbs = Path.Combine(Path.GetTempPath(), "tts_temp.vbs");
                    File.WriteAllText(vbs, $"CreateObject(\"SAPI.SpVoice\").Speak \"{palabra}\"");

                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "cscript",
                        Arguments = $"//NoLogo \"{vbs}\"",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (var proc = System.Diagnostics.Process.Start(psi))
                        proc.WaitForExit();

                    if (File.Exists(vbs)) File.Delete(vbs);
                }
                catch (Exception ex)
                {
                    this.Invoke((Action)(() =>
                        MessageBox.Show($"Error: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                }
            });
        }
    }
}