namespace Galeria_Arte_Progra2
{
    partial class Galeria_2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Galeria_2));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_Siguiente = new Button();
            btn_Anterior = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(941, 1102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(929, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1014, 1102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btn_Siguiente
            // 
            btn_Siguiente.Location = new Point(944, 771);
            btn_Siguiente.Name = "btn_Siguiente";
            btn_Siguiente.Size = new Size(254, 61);
            btn_Siguiente.TabIndex = 3;
            btn_Siguiente.Text = "Siguiente";
            btn_Siguiente.UseVisualStyleBackColor = true;
            btn_Siguiente.Click += btn_Siguiente_Click;
            // 
            // btn_Anterior
            // 
            btn_Anterior.Location = new Point(660, 771);
            btn_Anterior.Name = "btn_Anterior";
            btn_Anterior.Size = new Size(254, 61);
            btn_Anterior.TabIndex = 4;
            btn_Anterior.Text = "Anterior";
            btn_Anterior.UseVisualStyleBackColor = true;
            btn_Anterior.Click += btn_Anterior_Click;
            // 
            // Galeria_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 1055);
            Controls.Add(btn_Anterior);
            Controls.Add(btn_Siguiente);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Galeria_2";
            Text = "Galería de Arte";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_Siguiente;
        private Button btn_Anterior;
    }
}
