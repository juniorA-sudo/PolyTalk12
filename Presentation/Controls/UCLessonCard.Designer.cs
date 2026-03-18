namespace Presentation.Controls
{
    partial class UCLessonCard
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblTipo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblTipo = new Label();
            SuspendLayout();

            // UCLessonCard
            Size = new Size(280, 40);
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Padding = new Padding(10, 5, 10, 5);
            Cursor = Cursors.Hand;
            Margin = new Padding(5, 2, 5, 2);

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9F);
            lblTitulo.Location = new Point(10, 12);
            lblTitulo.Text = "Lesson Title";
            lblTitulo.Cursor = Cursors.Hand;

            // lblTipo
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 8F);
            lblTipo.ForeColor = Color.Gray;
            lblTipo.Location = new Point(170, 13);
            lblTipo.Text = "Type";
            lblTipo.Cursor = Cursors.Hand;

            Controls.Add(lblTitulo);
            Controls.Add(lblTipo);

            Click += UCLessonCard_Click;
            lblTitulo.Click += UCLessonCard_Click;
            lblTipo.Click += UCLessonCard_Click;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}