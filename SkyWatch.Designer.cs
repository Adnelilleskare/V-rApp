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
            ByHenter.Location = new Point(432, 37);
            ByHenter.Margin = new Padding(2);
            ByHenter.Name = "ByHenter";
            ByHenter.Size = new Size(120, 23);
            ByHenter.TabIndex = 0;
            ByHenter.Text = "Skriv inn din by her:";
            ByHenter.KeyDown += ByHenter_KeyDown;
            // 
            // HentVær
            // 
            HentVær.Anchor = AnchorStyles.None;
            HentVær.Location = new Point(656, 38);
            HentVær.Margin = new Padding(3, 2, 3, 2);
            HentVær.Name = "HentVær";
            HentVær.Size = new Size(75, 23);
            HentVær.TabIndex = 1;
            HentVær.Text = "Hent vær";
            HentVær.UseVisualStyleBackColor = true;
            HentVær.Click += HentVær_Click;
            // 
            // Langtidsvarsel
            // 
            Langtidsvarsel.Anchor = AnchorStyles.None;
            Langtidsvarsel.Location = new Point(800, 39);
            Langtidsvarsel.Name = "Langtidsvarsel";
            Langtidsvarsel.Size = new Size(103, 23);
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
            Temp.Location = new Point(500, 110);
            Temp.Name = "Temp";
            Temp.Size = new Size(0, 21);
            Temp.TabIndex = 4;
            // 
            // Vær
            // 
            Vær.Anchor = AnchorStyles.None;
            Vær.AutoSize = true;
            Vær.BackColor = Color.Transparent;
            Vær.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Vær.ForeColor = SystemColors.ButtonHighlight;
            Vær.Location = new Point(500, 134);
            Vær.Name = "Vær";
            Vær.Size = new Size(0, 21);
            Vær.TabIndex = 5;
            // 
            // VindHas
            // 
            VindHas.Anchor = AnchorStyles.None;
            VindHas.AutoSize = true;
            VindHas.BackColor = Color.Transparent;
            VindHas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VindHas.ForeColor = SystemColors.ButtonHighlight;
            VindHas.Location = new Point(500, 155);
            VindHas.Name = "VindHas";
            VindHas.Size = new Size(0, 21);
            VindHas.TabIndex = 6;
            // 
            // Humidity
            // 
            Humidity.Anchor = AnchorStyles.None;
            Humidity.AutoSize = true;
            Humidity.BackColor = Color.Transparent;
            Humidity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Humidity.ForeColor = SystemColors.ButtonHighlight;
            Humidity.Location = new Point(500, 176);
            Humidity.Name = "Humidity";
            Humidity.Size = new Size(0, 21);
            Humidity.TabIndex = 7;
            // 
            // Lufttrykk
            // 
            Lufttrykk.Anchor = AnchorStyles.None;
            Lufttrykk.AutoSize = true;
            Lufttrykk.BackColor = Color.Transparent;
            Lufttrykk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lufttrykk.ForeColor = SystemColors.ButtonHighlight;
            Lufttrykk.Location = new Point(500, 197);
            Lufttrykk.Name = "Lufttrykk";
            Lufttrykk.Size = new Size(0, 21);
            Lufttrykk.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 233);
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
            label1.Location = new Point(456, 80);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 10;
            label1.Text = "Været akkurat nå:";
            // 
            // SkyWatch
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.SkyBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1268, 567);
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
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1284, 685);
            MinimumSize = new Size(773, 559);
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
