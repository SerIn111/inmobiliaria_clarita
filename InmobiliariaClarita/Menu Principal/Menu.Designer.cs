namespace InmobiliariaClarita.Menu_Principal
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnAtras = new Button();
            label1 = new Label();
            btnPlaza = new Button();
            btnPlaya = new Button();
            btnApartamentos = new Button();
            btnMontania = new Button();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackgroundImage = (Image)resources.GetObject("btnAtras.BackgroundImage");
            btnAtras.BackgroundImageLayout = ImageLayout.Stretch;
            btnAtras.FlatAppearance.MouseDownBackColor = Color.Red;
            btnAtras.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Location = new Point(3, 449);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(100, 81);
            btnAtras.TabIndex = 100;
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 28);
            label1.Name = "label1";
            label1.Size = new Size(517, 42);
            label1.TabIndex = 1;
            label1.Text = "Seleccione la opcion deseada";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnPlaza
            // 
            btnPlaza.BackColor = Color.WhiteSmoke;
            btnPlaza.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnPlaza.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnPlaza.FlatStyle = FlatStyle.Flat;
            btnPlaza.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnPlaza.Location = new Point(210, 102);
            btnPlaza.Name = "btnPlaza";
            btnPlaza.Size = new Size(246, 160);
            btnPlaza.TabIndex = 1;
            btnPlaza.Text = "Plaza Comercial Universitaria\r\n(Blvr UNAH-VS)\r\n";
            btnPlaza.UseVisualStyleBackColor = false;
            // 
            // btnPlaya
            // 
            btnPlaya.BackColor = Color.WhiteSmoke;
            btnPlaya.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnPlaya.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnPlaya.FlatStyle = FlatStyle.Flat;
            btnPlaya.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnPlaya.Location = new Point(492, 102);
            btnPlaya.Name = "btnPlaya";
            btnPlaya.Size = new Size(246, 160);
            btnPlaya.TabIndex = 2;
            btnPlaya.Text = "Casa de Playa\r\n(Tela, Atlantida)";
            btnPlaya.UseVisualStyleBackColor = false;
            // 
            // btnApartamentos
            // 
            btnApartamentos.BackColor = Color.WhiteSmoke;
            btnApartamentos.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnApartamentos.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnApartamentos.FlatStyle = FlatStyle.Flat;
            btnApartamentos.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnApartamentos.Location = new Point(210, 280);
            btnApartamentos.Name = "btnApartamentos";
            btnApartamentos.Size = new Size(246, 160);
            btnApartamentos.TabIndex = 3;
            btnApartamentos.Text = "Apartamentos\r\n(Colonia Trejo, SPS)";
            btnApartamentos.UseVisualStyleBackColor = false;
            // 
            // btnMontania
            // 
            btnMontania.BackColor = Color.WhiteSmoke;
            btnMontania.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnMontania.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            btnMontania.FlatStyle = FlatStyle.Flat;
            btnMontania.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnMontania.Location = new Point(492, 280);
            btnMontania.Name = "btnMontania";
            btnMontania.Size = new Size(246, 160);
            btnMontania.TabIndex = 4;
            btnMontania.Text = "Casa de Montaña\r\n(Las Peñitas, SPS)";
            btnMontania.UseVisualStyleBackColor = false;
            btnMontania.Click += button4_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 533);
            Controls.Add(btnMontania);
            Controls.Add(btnApartamentos);
            Controls.Add(btnPlaya);
            Controls.Add(btnPlaza);
            Controls.Add(label1);
            Controls.Add(btnAtras);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label label1;
        private Button btnPlaza;
        private Button btnPlaya;
        private Button btnApartamentos;
        private Button btnMontania;
    }
}