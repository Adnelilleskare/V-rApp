using System;
using System.Windows.Forms;
using DotNetEnv;

namespace VærApp
{
    public partial class SkyWatch : Form
    {
        string apiKey;

        public SkyWatch()
        {
            InitializeComponent();
            Env.Load("C:\\Users\\adnel\\source\\repos\\VærApp\\.env");
            apiKey = Environment.GetEnvironmentVariable("api");
        }

        private void SkyWatch_Load(object sender, EventArgs e)
        {
            
        }
    }
}
