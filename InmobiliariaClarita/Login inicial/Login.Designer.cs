namespace InmobiliariaClarita.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtContra = new TextBox();
            btnAceptar = new Button();
            tpUsuario = new ToolTip(components);
            tpContra = new ToolTip(components);
            tpAceptar = new ToolTip(components);
            btnSalir = new Button();
            tpSalir = new ToolTip(components);
            txtUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtContra
            // 
            txtContra.BackColor = Color.FromArgb(245, 246, 250);
            txtContra.BorderStyle = BorderStyle.None;
            txtContra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContra.ForeColor = Color.Black;
            txtContra.Location = new Point(51, 9);
            txtContra.Multiline = true;
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.Size = new Size(261, 27);
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
            btnAceptar.Location = new Point(159, 313);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(245, 52);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(210, 100, 60);
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Zoom;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Red;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(1, 373);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(126, 54);
            btnSalir.TabIndex = 101;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(245, 246, 250);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(51, 9);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(261, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(142, 214);
            label3.Name = "label3";
            label3.Size = new Size(136, 29);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 111);
            label2.Name = "label2";
            label2.Size = new Size(96, 29);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(200, 79, 36);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(btnSalir);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(btnAceptar);
            splitContainer1.Size = new Size(1075, 428);
            splitContainer1.SplitterDistance = 530;
            splitContainer1.TabIndex = 102;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 226);
            label1.Name = "label1";
            label1.Size = new Size(276, 58);
            label1.TabIndex = 104;
            label1.Text = "Soluciones inmobiliarias\r\ncon confianza.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 103;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(245, 246, 250);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(txtContra);
            panel2.Location = new Point(142, 247);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 43);
            panel2.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 246, 250);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(142, 152);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 43);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(142, 25);
            label4.Name = "label4";
            label4.Size = new Size(277, 52);
            label4.TabIndex = 4;
            label4.Text = "Iniciar sesión";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1075, 428);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            Load += Logincs_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtContra;
        private Button btnAceptar;
        private ToolTip tpUsuario;
        private ToolTip tpContra;
        private ToolTip tpAceptar;
        private Button btnSalir;
        private ToolTip tpSalir;
        private TextBox txtUsuario;
        private Label label3;
        private Label label2;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}