using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Presentation.Seccion_de_Maestros
{
    public partial class UCTarjetaMisGrupos : UserControl
    {
        // Eventos
        public event EventHandler<int> ClickVerEstudiantes;
        public event EventHandler<int> ClickTarjeta;

        // Propiedades
        private int _idGrupo;
        private string _nombreGrupo;
        private int _totalEstudiantes;
        private string _horario;
        private string[] _materias;

        public int IdGrupo
        {
            get { return _idGrupo; }
            set { _idGrupo = value; }
        }

        public string NombreGrupo
        {
            get { return _nombreGrupo; }
            set
            {
                _nombreGrupo = value;
                lblNombre.Text = value;
            }
        }

        public int TotalEstudiantes
        {
            get { return _totalEstudiantes; }
            set
            {
                _totalEstudiantes = value;
                lblEstudiantes.Text = $"{value} estudiantes";
            }
        }

        public string Horario
        {
            get { return _horario; }
            set
            {
                _horario = value;
                lblHorario.Text = value;
            }
        }

        public string[] Materias
        {
            get { return _materias; }
            set
            {
                _materias = value;
                CargarMaterias(value);
            }
        }

        public UCTarjetaMisGrupos()
        {
            InitializeComponent();
            this.Margin = new Padding(8, 8, 8, 8);
            ConfigurarEventos();
        }

        public UCTarjetaMisGrupos(int id, string nombre, int estudiantes, string horario, string[] materias)
        {
            InitializeComponent();

            this.Margin = new Padding(8, 8, 8, 8);

            _idGrupo = id;
            _nombreGrupo = nombre;
            _totalEstudiantes = estudiantes;
            _horario = horario;
            _materias = materias;

            lblNombre.Text = nombre;
            lblEstudiantes.Text = $"{estudiantes} estudiantes";
            lblHorario.Text = horario;

            CargarMaterias(materias);
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            this.Click += (s, e) => ClickTarjeta?.Invoke(this, _idGrupo);
            panelFondo.Click += (s, e) => ClickTarjeta?.Invoke(this, _idGrupo);
            lblNombre.Click += (s, e) => ClickTarjeta?.Invoke(this, _idGrupo);
            lblEstudiantes.Click += (s, e) => ClickTarjeta?.Invoke(this, _idGrupo);
            lblHorario.Click += (s, e) => ClickTarjeta?.Invoke(this, _idGrupo);
            flpMaterias.Click += (s, e) => ClickTarjeta?.Invoke(this, _idGrupo);

            btnVer.Click += (s, e) => ClickVerEstudiantes?.Invoke(this, _idGrupo);
        }

        private void CargarMaterias(string[] materias)
        {
            flpMaterias.Controls.Clear();

            foreach (string materia in materias)
            {
                Guna2Panel tag = new Guna2Panel
                {
                    Size = new Size(65, 22),
                    FillColor = Color.FromArgb(240, 245, 255),
                    BorderRadius = 6,
                    Margin = new Padding(0, 0, 5, 0)
                };

                Guna2HtmlLabel lblMateria = new Guna2HtmlLabel
                {
                    Text = materia,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    ForeColor = Color.FromArgb(102, 126, 234),
                    Location = new Point(5, 3),
                    AutoSize = true,
                    BackColor = Color.Transparent
                };

                tag.Controls.Add(lblMateria);
                flpMaterias.Controls.Add(tag);
            }
        }

        private void btnVerEstudiantes_Paint(object sender, PaintEventArgs e)
        {
            using (Font font = new Font("Segoe UI", 10, FontStyle.Bold))
            {
                e.Graphics.DrawString("📋", font, new SolidBrush(Color.White), 7, 5);
            }
        }

        private void panelFondo_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 10;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panelFondo.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panelFondo.Width - radius, panelFondo.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panelFondo.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panelFondo.Region = new Region(path);
        }
    }
}