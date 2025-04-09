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
            ByHenter = new TextBox();
            HentVær = new Button();
            Langtidsvarsel = new Button();
            Temp = new Label();
            Vær = new Label();
            VindHas = new Label();
            Humidity = new Label();
            Lufttrykk = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ByHenter
            // 
            ByHenter.Anchor = AnchorStyles.None;
            ByHenter.Location = new Point(338, 11);
            ByHenter.Margin = new Padding(3, 2, 3, 2);
            ByHenter.Name = "ByHenter";
            ByHenter.Size = new Size(149, 27);
            ByHenter.TabIndex = 0;
            ByHenter.Text = "Skriv inn din by her:";
            ByHenter.TextChanged += ByHenter_TextChanged;
            ByHenter.KeyDown += ByHenter_KeyDown;
            // 
            // HentVær
            // 
            HentVær.Anchor = AnchorStyles.None;
            HentVær.Location = new Point(618, 12);
            HentVær.Margin = new Padding(4, 2, 4, 2);
            HentVær.Name = "HentVær";
            HentVær.Size = new Size(94, 29);
            HentVær.TabIndex = 1;
            HentVær.Text = "Hent vær";
            HentVær.UseVisualStyleBackColor = true;
            HentVær.Click += HentVær_Click;
            // 
            // Langtidsvarsel
            // 
            Langtidsvarsel.Anchor = AnchorStyles.None;
            Langtidsvarsel.Location = new Point(798, 14);
            Langtidsvarsel.Margin = new Padding(4);
            Langtidsvarsel.Name = "Langtidsvarsel";
            Langtidsvarsel.Size = new Size(129, 29);
            Langtidsvarsel.TabIndex = 2;
            Langtidsvarsel.Text = "Langtidsvarsel";
            Langtidsvarsel.UseVisualStyleBackColor = true;
            Langtidsvarsel.Click += Langtidsvarsel_Click;
            // 
            // Temp
            // 
            Temp.Anchor = AnchorStyles.None;
            Temp.AutoSize = true;
            Temp.BackColor = Color.Transparent;
            Temp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Temp.ForeColor = SystemColors.ButtonHighlight;
            Temp.Location = new Point(422, 102);
            Temp.Margin = new Padding(4, 0, 4, 0);
            Temp.Name = "Temp";
            Temp.Size = new Size(0, 28);
            Temp.TabIndex = 4;
            Temp.Click += Temp_Click;
            // 
            // Vær
            // 
            Vær.Anchor = AnchorStyles.None;
            Vær.AutoSize = true;
            Vær.BackColor = Color.Transparent;
            Vær.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Vær.ForeColor = SystemColors.ButtonHighlight;
            Vær.Location = new Point(422, 132);
            Vær.Margin = new Padding(4, 0, 4, 0);
            Vær.Name = "Vær";
            Vær.Size = new Size(0, 28);
            Vær.TabIndex = 5;
            // 
            // VindHas
            // 
            VindHas.Anchor = AnchorStyles.None;
            VindHas.AutoSize = true;
            VindHas.BackColor = Color.Transparent;
            VindHas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VindHas.ForeColor = SystemColors.ButtonHighlight;
            VindHas.Location = new Point(422, 159);
            VindHas.Margin = new Padding(4, 0, 4, 0);
            VindHas.Name = "VindHas";
            VindHas.Size = new Size(0, 28);
            VindHas.TabIndex = 6;
            // 
            // Humidity
            // 
            Humidity.Anchor = AnchorStyles.None;
            Humidity.AutoSize = true;
            Humidity.BackColor = Color.Transparent;
            Humidity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Humidity.ForeColor = SystemColors.ButtonHighlight;
            Humidity.Location = new Point(422, 185);
            Humidity.Margin = new Padding(4, 0, 4, 0);
            Humidity.Name = "Humidity";
            Humidity.Size = new Size(0, 28);
            Humidity.TabIndex = 7;
            // 
            // Lufttrykk
            // 
            Lufttrykk.Anchor = AnchorStyles.None;
            Lufttrykk.AutoSize = true;
            Lufttrykk.BackColor = Color.Transparent;
            Lufttrykk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lufttrykk.ForeColor = SystemColors.ButtonHighlight;
            Lufttrykk.Location = new Point(422, 211);
            Lufttrykk.Margin = new Padding(4, 0, 4, 0);
            Lufttrykk.Name = "Lufttrykk";
            Lufttrykk.Size = new Size(0, 28);
            Lufttrykk.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-126, 256);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 337);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(368, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 10;
            label1.Text = "Været akkurat nå:";
            label1.Click += label1_Click;
            // 
            // SkyWatch
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.SkyBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 638);
            Controls.Add(label1);
            Controls.Add(Lufttrykk);
            Controls.Add(Humidity);
            Controls.Add(VindHas);
            Controls.Add(Vær);
            Controls.Add(Temp);
            Controls.Add(Langtidsvarsel);
            Controls.Add(HentVær);
            Controls.Add(ByHenter);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "SkyWatch";
            Text = "SkyWatch";
            Load += SkyWatch_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Temp;
        private Label Vær;
        private Label VindHas;
        private Label Humidity;
        private Label Lufttrykk;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        public TextBox ByHenter;
        public Button HentVær;
        public Button Langtidsvarsel;
        public Label label1;
    }
}
