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
            IdagVær = new Button();
            Temp = new Label();
            Vær = new Label();
            VindHas = new Label();
            SuspendLayout();
            // 
            // ByHenter
            // 
            ByHenter.Location = new Point(296, 9);
            ByHenter.Margin = new Padding(3, 2, 3, 2);
            ByHenter.Name = "ByHenter";
            ByHenter.Size = new Size(134, 23);
            ByHenter.TabIndex = 0;
            ByHenter.Text = "Skriv inn din by her:";
            // 
            // HentVær
            // 
            HentVær.Location = new Point(453, 8);
            HentVær.Margin = new Padding(3, 2, 3, 2);
            HentVær.Name = "HentVær";
            HentVær.Size = new Size(82, 22);
            HentVær.TabIndex = 1;
            HentVær.Text = "Hent vær";
            HentVær.UseVisualStyleBackColor = true;
            HentVær.Click += HentVær_Click;
            // 
            // Langtidsvarsel
            // 
            Langtidsvarsel.Location = new Point(673, 350);
            Langtidsvarsel.Name = "Langtidsvarsel";
            Langtidsvarsel.Size = new Size(95, 23);
            Langtidsvarsel.TabIndex = 2;
            Langtidsvarsel.Text = "Langtidsvarsel";
            Langtidsvarsel.UseVisualStyleBackColor = true;
            // 
            // IdagVær
            // 
            IdagVær.Location = new Point(673, 299);
            IdagVær.Name = "IdagVær";
            IdagVær.Size = new Size(95, 23);
            IdagVær.TabIndex = 3;
            IdagVær.Text = "Været i dag";
            IdagVær.UseVisualStyleBackColor = true;
            // 
            // Temp
            // 
            Temp.AutoSize = true;
            Temp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Temp.ForeColor = SystemColors.ButtonHighlight;
            Temp.Location = new Point(296, 60);
            Temp.Name = "Temp";
            Temp.Size = new Size(38, 21);
            Temp.TabIndex = 4;
            Temp.Text = "erer";
            // 
            // Vær
            // 
            Vær.AutoSize = true;
            Vær.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Vær.ForeColor = SystemColors.ButtonHighlight;
            Vær.Location = new Point(296, 81);
            Vær.Name = "Vær";
            Vær.Size = new Size(38, 21);
            Vær.TabIndex = 5;
            Vær.Text = "erer";
            // 
            // VindHas
            // 
            VindHas.AutoSize = true;
            VindHas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VindHas.ForeColor = SystemColors.ButtonHighlight;
            VindHas.Location = new Point(296, 102);
            VindHas.Name = "VindHas";
            VindHas.Size = new Size(38, 21);
            VindHas.TabIndex = 6;
            VindHas.Text = "erer";
            // 
            // SkyWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(780, 385);
            Controls.Add(VindHas);
            Controls.Add(Vær);
            Controls.Add(Temp);
            Controls.Add(IdagVær);
            Controls.Add(Langtidsvarsel);
            Controls.Add(HentVær);
            Controls.Add(ByHenter);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "SkyWatch";
            Text = "SkyWatch";
            Load += SkyWatch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ByHenter;
        private Button HentVær;
        private Button Langtidsvarsel;
        private Button IdagVær;
        private Label Temp;
        private Label Vær;
        private Label VindHas;
    }
}
