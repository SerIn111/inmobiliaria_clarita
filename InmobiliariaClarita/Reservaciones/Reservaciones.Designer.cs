namespace InmobiliariaClarita.Reservaciones
{
    partial class Reservaciones
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
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 23);
            label1.Name = "label1";
            label1.Size = new Size(346, 42);
            label1.TabIndex = 0;
            label1.Text = "Nueva Reservacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 126);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // Reservaciones
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 512);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Reservaciones";
            Text = "Nueva Reservacion";
            Load += Casas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}