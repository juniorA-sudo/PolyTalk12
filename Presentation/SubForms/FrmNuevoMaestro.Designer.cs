namespace Presentation
{
    partial class FrmNuevoMaestro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges ce1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges ce14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            // Header
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            btnCerrar = new Button();
            // Body
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            // Nombre
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            // Apellido
            lblApellido = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtApellido = new Guna.UI2.WinForms.Guna2TextBox();
            // Email
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            // Teléfono
            guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            // Nivel + Fecha
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbNivel = new ComboBox();
            guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtpFechaIngreso = new DateTimePicker();
            // Contraseña
            lblContrasena = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtContrasena = new Guna.UI2.WinForms.Guna2TextBox();
            lblConfirmar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtConfirmar = new Guna.UI2.WinForms.Guna2TextBox();
            // Botones
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            guna2Panel3.SuspendLayout();
            SuspendLayout();
            // ── HEADER ──────────────────────────────────────────
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(51, 51, 51);
            guna2HtmlLabel1.Location = new Point(62, 18);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(140, 23);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Nuevo Maestro";
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            iconPictureBox1.IconColor = Color.FromArgb(0, 82, 180);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 38;
            iconPictureBox1.Location = new Point(12, 10);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(38, 40);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Location = new Point(418, 8);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(22, 22);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "x";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            guna2Panel2.BackColor = SystemColors.ActiveBorder;
            guna2Panel2.CustomizableEdges = ce1;
            guna2Panel2.Dock = DockStyle.Bottom;
            guna2Panel2.Location = new Point(0, 59);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = ce2;
            guna2Panel2.Size = new Size(450, 1);
            guna2Panel2.TabIndex = 3;
            guna2Panel1.Controls.Add(btnCerrar);
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(iconPictureBox1);
            guna2Panel1.CustomizableEdges = ce3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = ce4;
            guna2Panel1.Size = new Size(450, 60);
            guna2Panel1.TabIndex = 2;
            // ── BODY ─────────────────────────────────────────────
            // Nombre
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.ForeColor = Color.FromArgb(51, 51, 51);
            guna2HtmlLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel2.Location = new Point(15, 12);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(55, 17);
            guna2HtmlLabel2.TabIndex = 0;
            guna2HtmlLabel2.Text = "Nombre *";
            txtNombre.BorderRadius = 5;
            txtNombre.CustomizableEdges = ce5;
            txtNombre.DefaultText = "";
            txtNombre.FillColor = Color.FromArgb(247, 250, 252);
            txtNombre.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombre.Location = new Point(15, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ej: Juan";
            txtNombre.SelectedText = "";
            txtNombre.ShadowDecoration.CustomizableEdges = ce6;
            txtNombre.Size = new Size(195, 32);
            txtNombre.TabIndex = 1;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // Apellido
            lblApellido.BackColor = Color.Transparent;
            lblApellido.ForeColor = Color.FromArgb(51, 51, 51);
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.Location = new Point(225, 12);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 17);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido *";
            txtApellido.BorderRadius = 5;
            txtApellido.CustomizableEdges = ce7;
            txtApellido.DefaultText = "";
            txtApellido.FillColor = Color.FromArgb(247, 250, 252);
            txtApellido.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtApellido.Location = new Point(225, 32);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ej: Pérez";
            txtApellido.SelectedText = "";
            txtApellido.ShadowDecoration.CustomizableEdges = ce8;
            txtApellido.Size = new Size(195, 32);
            txtApellido.TabIndex = 3;
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // Email
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.ForeColor = Color.FromArgb(51, 51, 51);
            guna2HtmlLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel3.Location = new Point(15, 74);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(40, 17);
            guna2HtmlLabel3.TabIndex = 4;
            guna2HtmlLabel3.Text = "Email *";
            txtEmail.BorderRadius = 5;
            txtEmail.CustomizableEdges = ce9;
            txtEmail.DefaultText = "";
            txtEmail.FillColor = Color.FromArgb(247, 250, 252);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(15, 94);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "maestro@polytalk.com";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = ce10;
            txtEmail.Size = new Size(405, 32);
            txtEmail.TabIndex = 5;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // Teléfono
            guna2HtmlLabel7.BackColor = Color.Transparent;
            guna2HtmlLabel7.ForeColor = Color.FromArgb(51, 51, 51);
            guna2HtmlLabel7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel7.Location = new Point(15, 136);
            guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            guna2HtmlLabel7.Size = new Size(55, 17);
            guna2HtmlLabel7.TabIndex = 6;
            guna2HtmlLabel7.Text = "Teléfono";
            txtTelefono.BorderRadius = 5;
            txtTelefono.CustomizableEdges = ce11;
            txtTelefono.DefaultText = "";
            txtTelefono.FillColor = Color.FromArgb(247, 250, 252);
            txtTelefono.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefono.Font = new Font("Segoe UI", 9F);
            txtTelefono.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTelefono.Location = new Point(15, 156);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "+1 809-123-4567";
            txtTelefono.SelectedText = "";
            txtTelefono.ShadowDecoration.CustomizableEdges = ce12;
            txtTelefono.Size = new Size(405, 32);
            txtTelefono.TabIndex = 7;
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // Nivel
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.ForeColor = Color.FromArgb(51, 51, 51);
            guna2HtmlLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel4.Location = new Point(15, 198);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(75, 17);
            guna2HtmlLabel4.TabIndex = 8;
            guna2HtmlLabel4.Text = "Nivel MCER *";
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Font = new Font("Segoe UI", 9F);
            cmbNivel.Location = new Point(15, 218);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(180, 25);
            cmbNivel.TabIndex = 9;
            // Fecha ingreso
            guna2HtmlLabel8.BackColor = Color.Transparent;
            guna2HtmlLabel8.ForeColor = Color.FromArgb(51, 51, 51);
            guna2HtmlLabel8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2HtmlLabel8.Location = new Point(225, 198);
            guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            guna2HtmlLabel8.Size = new Size(100, 17);
            guna2HtmlLabel8.TabIndex = 10;
            guna2HtmlLabel8.Text = "Fecha de ingreso";
            dtpFechaIngreso.Font = new Font("Segoe UI", 9F);
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(225, 218);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(195, 25);
            dtpFechaIngreso.TabIndex = 11;
            // Contraseña
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.ForeColor = Color.FromArgb(51, 51, 51);
            lblContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContrasena.Location = new Point(15, 260);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(80, 17);
            lblContrasena.TabIndex = 12;
            lblContrasena.Text = "Contraseña *";
            txtContrasena.BorderRadius = 5;
            txtContrasena.CustomizableEdges = ce13;
            txtContrasena.DefaultText = "";
            txtContrasena.FillColor = Color.FromArgb(247, 250, 252);
            txtContrasena.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContrasena.Font = new Font("Segoe UI", 9F);
            txtContrasena.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContrasena.Location = new Point(15, 280);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "Mínimo 6 caracteres";
            txtContrasena.SelectedText = "";
            txtContrasena.ShadowDecoration.CustomizableEdges = ce14;
            txtContrasena.Size = new Size(195, 32);
            txtContrasena.TabIndex = 13;
            txtContrasena.Enter += txtContrasena_Enter;
            txtContrasena.Leave += txtContrasena_Leave;
            // Confirmar contraseña
            lblConfirmar.BackColor = Color.Transparent;
            lblConfirmar.ForeColor = Color.FromArgb(51, 51, 51);
            lblConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConfirmar.Location = new Point(225, 260);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(115, 17);
            lblConfirmar.TabIndex = 14;
            lblConfirmar.Text = "Confirmar contraseña";
            txtConfirmar.BorderRadius = 5;
            txtConfirmar.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtConfirmar.DefaultText = "";
            txtConfirmar.FillColor = Color.FromArgb(247, 250, 252);
            txtConfirmar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmar.Font = new Font("Segoe UI", 9F);
            txtConfirmar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmar.Location = new Point(225, 280);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PlaceholderText = "Repetir contraseña";
            txtConfirmar.SelectedText = "";
            txtConfirmar.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtConfirmar.Size = new Size(195, 32);
            txtConfirmar.TabIndex = 15;
            txtConfirmar.Enter += txtConfirmar_Enter;
            txtConfirmar.Leave += txtConfirmar_Leave;
            // Botones
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(15, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 36);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            btnGuardar.BackColor = Color.FromArgb(0, 82, 180);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 22;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.Location = new Point(250, 335);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 36);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar Maestro";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // Panel body
            guna2Panel3.AutoScroll = true;
            guna2Panel3.Controls.Add(guna2HtmlLabel2);
            guna2Panel3.Controls.Add(txtNombre);
            guna2Panel3.Controls.Add(lblApellido);
            guna2Panel3.Controls.Add(txtApellido);
            guna2Panel3.Controls.Add(guna2HtmlLabel3);
            guna2Panel3.Controls.Add(txtEmail);
            guna2Panel3.Controls.Add(guna2HtmlLabel7);
            guna2Panel3.Controls.Add(txtTelefono);
            guna2Panel3.Controls.Add(guna2HtmlLabel4);
            guna2Panel3.Controls.Add(cmbNivel);
            guna2Panel3.Controls.Add(guna2HtmlLabel8);
            guna2Panel3.Controls.Add(dtpFechaIngreso);
            guna2Panel3.Controls.Add(lblContrasena);
            guna2Panel3.Controls.Add(txtContrasena);
            guna2Panel3.Controls.Add(lblConfirmar);
            guna2Panel3.Controls.Add(txtConfirmar);
            guna2Panel3.Controls.Add(btnCancelar);
            guna2Panel3.Controls.Add(btnGuardar);
            guna2Panel3.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel3.Dock = DockStyle.Fill;
            guna2Panel3.Location = new Point(0, 60);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.Padding = new Padding(0, 5, 0, 10);
            guna2Panel3.ShadowDecoration.CustomizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel3.Size = new Size(450, 440);
            guna2Panel3.TabIndex = 17;
            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 500);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevoMaestro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Maestro";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ResumeLayout(false);
        }

        // Controles existentes
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Button btnCerrar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private ComboBox cmbNivel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private DateTimePicker dtpFechaIngreso;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;

        // Controles nuevos
        private Guna.UI2.WinForms.Guna2HtmlLabel lblApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtApellido;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContrasena;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasena;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblConfirmar;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmar;
    }
}