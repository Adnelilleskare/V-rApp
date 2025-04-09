using DotNetEnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VærApp
{
    public partial class LangtidsvarselVindu : Form
    {
        public string By { get; set; }

        public LangtidsvarselVindu()
        {

            InitializeComponent();
            
        }

        public void SetBy(string by)
        {
            By = by;
            ByTekst.Text = $"Langtidsvarselet i {By}";
        }



        private void LangtidsvarselVindu_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
