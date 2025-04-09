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
            // LangtidsvarselVindu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1141, 590);
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
    }
}