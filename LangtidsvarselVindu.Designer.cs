namespace VærApp
{
    partial class LangtidsvarselVindu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LangtidsvarselVindu));
            pictureBox1 = new PictureBox();
            ByTekst = new Label();
            Idag = new Label();
            Imorgen = new Label();
            Dag4 = new Label();
            Dag3 = new Label();
            Dag5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-93, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 337);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ByTekst
            // 
            ByTekst.AutoSize = true;
            ByTekst.Font = new Font("Segoe UI", 16F);
            ByTekst.Location = new Point(301, 9);
            ByTekst.Name = "ByTekst";
            ByTekst.Size = new Size(206, 37);
            ByTekst.TabIndex = 1;
            ByTekst.Text = "Langtidsvarsel i:";
            ByTekst.Click += label1_Click;
            // 
            // Idag
            // 
            Idag.AutoSize = true;
            Idag.Font = new Font("Segoe UI", 12F);
            Idag.Location = new Point(457, 77);
            Idag.Name = "Idag";
            Idag.Size = new Size(60, 28);
            Idag.TabIndex = 2;
            Idag.Text = "Idag: ";
            // 
            // Imorgen
            // 
            Imorgen.AutoSize = true;
            Imorgen.Font = new Font("Segoe UI", 12F);
            Imorgen.Location = new Point(457, 116);
            Imorgen.Name = "Imorgen";
            Imorgen.Size = new Size(95, 28);
            Imorgen.TabIndex = 3;
            Imorgen.Text = "Imorgen: ";
            // 
            // Dag4
            // 
            Dag4.AutoSize = true;
            Dag4.Font = new Font("Segoe UI", 12F);
            Dag4.Location = new Point(457, 197);
            Dag4.Name = "Dag4";
            Dag4.Size = new Size(68, 28);
            Dag4.TabIndex = 5;
            Dag4.Text = "Dag 4:";
            // 
            // Dag3
            // 
            Dag3.AutoSize = true;
            Dag3.Font = new Font("Segoe UI", 12F);
            Dag3.Location = new Point(457, 158);
            Dag3.Name = "Dag3";
            Dag3.Size = new Size(68, 28);
            Dag3.TabIndex = 4;
            Dag3.Text = "Dag 3:";
            // 
            // Dag5
            // 
            Dag5.AutoSize = true;
            Dag5.Font = new Font("Segoe UI", 12F);
            Dag5.Location = new Point(457, 236);
            Dag5.Name = "Dag5";
            Dag5.Size = new Size(68, 28);
            Dag5.TabIndex = 6;
            Dag5.Text = "Dag 5:";
            // 
            // LangtidsvarselVindu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1141, 590);
            Controls.Add(Dag5);
            Controls.Add(Dag4);
            Controls.Add(Dag3);
            Controls.Add(Imorgen);
            Controls.Add(Idag);
            Controls.Add(ByTekst);
            Controls.Add(pictureBox1);
            Name = "LangtidsvarselVindu";
            Text = "Langtidsvarsel";
            Load += LangtidsvarselVindu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label ByTekst;
        private Label Idag;
        private Label Imorgen;
        private Label Dag4;
        private Label Dag3;
        private Label Dag5;
    }
}