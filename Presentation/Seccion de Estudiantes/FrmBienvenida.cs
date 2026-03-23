using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmBienvenida : Form
    {
        private readonly string username;
        private readonly string nivel;
        private readonly int streakDias;
        private readonly FrmPrincipal frmPrincipal;

        private static readonly (string word, string meaning, string example, string pronunciation)[] palabras =
        {
            ("Star",    "Estrella",  "Look at the stars tonight.",   "/stAr/"),
            ("Apple",   "Manzana",   "I eat an apple every day.",    "/AP-el/"),
            ("Happy",   "Feliz",     "She is very happy today.",     "/HAP-ee/"),
            ("Friend",  "Amigo",     "He is my best friend.",        "/frend/"),
            ("School",  "Escuela",   "I love going to school.",      "/skool/"),
            ("Book",    "Libro",     "This book is interesting.",    "/buk/"),
            ("Water",   "Agua",      "Drink more water every day.",  "/WAH-ter/"),
            ("Sun",     "Sol",       "The sun is very bright.",      "/sun/"),
            ("Music",   "Musica",    "I love listening to music.",   "/MYOO-zik/"),
            ("Color",   "Color",     "What is your favorite color?", "/KUL-er/"),
            ("Family",  "Familia",   "My family is very big.",       "/FAM-ih-lee/"),
            ("Dream",   "Sueno",     "Follow your dream every day.", "/dreem/"),
        };

        private (string word, string meaning, string example, string pronunciation) palabraHoy;

        public FrmBienvenida(string username, string nivel, int streakDias, FrmPrincipal frmPrincipal = null)
        {
            InitializeComponent();
            this.username = username;
            this.nivel = nivel;
            this.streakDias = streakDias;
            this.frmPrincipal = frmPrincipal;
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            int idx = DateTime.Today.DayOfYear % palabras.Length;
            palabraHoy = palabras[idx];
            ActualizarUI();
            timerAutoCerrar.Start();
        }

        private void ActualizarUI()
        {
            lblSaludo.Text = "Hola, " + username + "!";
            lblNivel.Text = "Aprendiz de Ingles  |  Nivel " + nivel;
            lblPalabra.Text = palabraHoy.word;
            lblSignificado.Text = palabraHoy.meaning;
            lblEjemplo.Text = "\"" + palabraHoy.example + "\"";
            lblPronunciacion.Text = palabraHoy.pronunciation;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            timerAutoCerrar.Stop();
            var rng = new Random();
            palabraHoy = palabras[rng.Next(palabras.Length)];
            ActualizarUI();
            timerAutoCerrar.Start();
        }

        private void btnEscuchar_Click(object sender, EventArgs e)
        {
            EscucharPalabra(palabraHoy.word);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            timerAutoCerrar.Stop();
            Cerrar();
        }

        private void timerAutoCerrar_Tick(object sender, EventArgs e)
        {
            timerAutoCerrar.Stop();
            Cerrar();
        }

        private void Cerrar()
        {
            // Si estamos dentro del panel contenedor volvemos a la mision
            if (frmPrincipal != null)
            {
                int studentId = ObtenerStudentId();
                frmPrincipal.AbrirFormEnPanel(new FrmMisionEstudiante(frmPrincipal, studentId));
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private int ObtenerStudentId()
        {
            try
            {
                var db = new DatabaseHelper();
                using var conn = new Microsoft.Data.SqlClient.SqlConnection(db.ConnectionString);
                using var cmd = new Microsoft.Data.SqlClient.SqlCommand(
                    "SELECT s.student_id FROM students s INNER JOIN users u ON s.user_id=u.user_id WHERE u.username=@u", conn);
                cmd.Parameters.AddWithValue("@u", username);
                conn.Open();
                var r = cmd.ExecuteScalar();
                return r != null ? Convert.ToInt32(r) : 1;
            }
            catch { return 1; }
        }

        private void EscucharPalabra(string texto)
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                try
                {
                    string vbs = Path.Combine(Path.GetTempPath(), "tts_bienvenida.vbs");
                    File.WriteAllText(vbs, $"CreateObject(\"SAPI.SpVoice\").Speak \"{texto}\"");
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "cscript",
                        Arguments = $"//NoLogo \"{vbs}\"",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    using var proc = System.Diagnostics.Process.Start(psi);
                    proc.WaitForExit();
                    if (File.Exists(vbs)) File.Delete(vbs);
                }
                catch { }
            });
        }

        private void lblStreakValor_Click(object sender, EventArgs e)
        {

        }
    }
}