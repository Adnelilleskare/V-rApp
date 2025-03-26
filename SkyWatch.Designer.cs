namespace VærApp
{
    partial class SkyWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkyWatch));
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Skriv inn din by her:";
            // 
            // SkyWatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(892, 513);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SkyWatch";
            Text = "SkyWatch";
            Load += SkyWatch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
    }
}
