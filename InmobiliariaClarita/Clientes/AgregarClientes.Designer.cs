namespace InmobiliariaClarita.Clientes
{
    partial class AgregarClientes
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
            label1 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label5 = new Label();
            txtCiudad = new TextBox();
            label10 = new Label();
            txtRTN = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            label12 = new Label();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtCorreo = new TextBox();
            label9 = new Label();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 30);
            label1.Name = "label1";
            label1.Size = new Size(382, 42);
            label1.TabIndex = 0;
            label1.Text = "Agregar nuevo cliente";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCiudad);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtRTN);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(112, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 223);
            panel1.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(590, 106);
            label11.Name = "label11";
            label11.Size = new Size(25, 32);
            label11.TabIndex = 9;
            label11.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(590, 64);
            label5.Name = "label5";
            label5.Size = new Size(25, 32);
            label5.TabIndex = 8;
            label5.Text = "*";
            // 
            // txtCiudad
            // 
            txtCiudad.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCiudad.Location = new Point(206, 159);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(378, 30);
            txtCiudad.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(10, 160);
            label10.Name = "label10";
            label10.Size = new Size(90, 29);
            label10.TabIndex = 7;
            label10.Text = "Ciudad";
            // 
            // txtRTN
            // 
            txtRTN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRTN.Location = new Point(206, 64);
            txtRTN.Name = "txtRTN";
            txtRTN.Size = new Size(378, 30);
            txtRTN.TabIndex = 1;
            txtRTN.KeyPress += txtRTN_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 64);
            label4.Name = "label4";
            label4.Size = new Size(190, 29);
            label4.TabIndex = 3;
            label4.Text = "RTN o identidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(150, 12);
            label3.Name = "label3";
            label3.Size = new Size(293, 36);
            label3.TabIndex = 2;
            label3.Text = "Informacion personal";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(206, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(378, 30);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 109);
            label2.Name = "label2";
            label2.Size = new Size(101, 29);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtDireccion);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(112, 366);
            panel2.Name = "panel2";
            panel2.Size = new Size(620, 219);
            panel2.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(590, 156);
            label13.Name = "label13";
            label13.Size = new Size(25, 32);
            label13.TabIndex = 10;
            label13.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(590, 61);
            label12.Name = "label12";
            label12.Size = new Size(25, 32);
            label12.TabIndex = 9;
            label12.Text = "*";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(206, 156);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(378, 30);
            txtDireccion.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(206, 63);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(378, 30);
            txtTelefono.TabIndex = 4;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 156);
            label6.Name = "label6";
            label6.Size = new Size(115, 29);
            label6.TabIndex = 5;
            label6.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 64);
            label7.Name = "label7";
            label7.Size = new Size(110, 29);
            label7.TabIndex = 3;
            label7.Text = "Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(137, 14);
            label8.Name = "label8";
            label8.Size = new Size(332, 36);
            label8.TabIndex = 2;
            label8.Text = "Informacion de contacto";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(206, 109);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(378, 30);
            txtCorreo.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 109);
            label9.Name = "label9";
            label9.Size = new Size(88, 29);
            label9.TabIndex = 0;
            label9.Text = "Correo";
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnLimpiar.Location = new Point(259, 631);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(133, 72);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnAgregar.Location = new Point(458, 631);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 72);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar Cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AgregarClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 759);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AgregarClientes";
            Text = "Agregar nuevo cliente";
            Load += AgregarClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private TextBox txtRTN;
        private Label label4;
        private Label label10;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtCorreo;
        private Label label9;
        private Button btnLimpiar;
        private Button btnAgregar;
        private TextBox txtCiudad;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label label11;
        private Label label5;
        private Label label13;
        private Label label12;
    }
}