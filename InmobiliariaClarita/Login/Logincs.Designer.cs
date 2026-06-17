namespace InmobiliariaClarita.Login
{
    partial class Logincs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logincs));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            btnAceptar = new Button();
            tpUsuario = new ToolTip(components);
            tpContra = new ToolTip(components);
            tpAceptar = new ToolTip(components);
            label4 = new Label();
            label5 = new Label();
            btnSalir = new Button();
            tpSalir = new ToolTip(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(364, 104);
            label1.Name = "label1";
            label1.Size = new Size(253, 39);
            label1.TabIndex = 0;
            label1.Text = "Inicio de sesion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_Inmobiliaria_Clarita_Sin_Fondo;
            pictureBox1.Location = new Point(93, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 66);
            label2.Name = "label2";
            label2.Size = new Size(96, 29);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 164);
            label3.Name = "label3";
            label3.Size = new Size(136, 29);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(375, 193);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(274, 30);
            txtUsuario.TabIndex = 1;
            // 
            // txtContra
            // 
            txtContra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContra.ForeColor = Color.Black;
            txtContra.Location = new Point(375, 291);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.Size = new Size(274, 30);
            txtContra.TabIndex = 2;
            txtContra.KeyDown += txtContra_KeyDown;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.White;
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(392, 347);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(245, 52);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(190, 8);
            label4.Name = "label4";
            label4.Size = new Size(408, 54);
            label4.TabIndex = 4;
            label4.Text = "Inmobiliaria Clarita";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 62);
            label5.Name = "label5";
            label5.Size = new Size(528, 29);
            label5.TabIndex = 5;
            label5.Text = "Sistema de Gestión de Alquiler y Reservaciones";
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = Properties.Resources.atras1;
            btnSalir.BackgroundImageLayout = ImageLayout.Zoom;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Red;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(3, 400);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(126, 54);
            btnSalir.TabIndex = 101;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(340, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 351);
            panel1.TabIndex = 102;
            // 
            // Logincs
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(793, 457);
            Controls.Add(btnSalir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnAceptar);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Logincs";
            Text = "Login";
            Load += Logincs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private Button btnAceptar;
        private ToolTip tpUsuario;
        private ToolTip tpContra;
        private ToolTip tpAceptar;
        private Label label4;
        private Label label5;
        private Button btnSalir;
        private ToolTip tpSalir;
        private Panel panel1;
    }
}