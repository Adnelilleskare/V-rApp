using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using DotNetEnv;

namespace VærApp
{
    public partial class SkyWatch : Form
    {
        string apiKey;
        string directory = Directory.GetCurrentDirectory();
        private static LangtidsvarselVindu langtidsvarsel = new LangtidsvarselVindu();
        public string By { get; set ; }
        

        public SkyWatch()
        {
            string env = @$"C:\Users\{Environment.UserName}\source\repos\V-rApp\.env";
            InitializeComponent();
            Env.Load(env);
            apiKey = Environment.GetEnvironmentVariable("api");

            Debug.WriteLine(env);


        }

        public void SkyWatch_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(directory);
        }

        public async void HentVær_Click(object sender, EventArgs e)
        {
            try
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={ByHenter.Text}&appid={apiKey}&units=metric";
                Debug.WriteLine(url);
                By = ByHenter.Text;
                using (HttpClient client = new HttpClient())
                {
                    string json = await client.GetStringAsync(url);
                    Debug.WriteLine(json);
                    var weatherData = JsonSerializer.Deserialize<WeatherResponse>(json);

                    if (weatherData?.Main != null && weatherData.Weather != null && weatherData.Weather.Count > 0)
                    {
                        Temp.Text = $"Temperatur: {weatherData.Main.Temp}°C";
                        Vær.Text = $"Vær: {weatherData.Weather[0].description}";
                        VindHas.Text = $"Vindhastighet: {weatherData.Wind.speed} m/s";
                        Humidity.Text = $"Luftfuktighet: {weatherData.Main.Humidity}%";
                        Lufttrykk.Text = $"Lufttrykk: {weatherData.Main.pressure} hPa";
                       
                    }
                    else
                    {
                        MessageBox.Show("Weather data could not be retrieved.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Temp_Click(object sender, EventArgs e)
        {

        }

        public void ByHenter_TextChanged(object sender, EventArgs e)
        {

        }

        public void ByHenter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HentVær_Click(sender, e);
            }
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void Langtidsvarsel_Click(object sender, EventArgs e)
        {
            try
            {
                By = ByHenter.Text;
                langtidsvarsel = new LangtidsvarselVindu();
                langtidsvarsel.SetBy(By);
                langtidsvarsel.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

    public class WeatherResponse
    {
        [JsonPropertyName("main")]
        public MainInfo Main { get; set; }

        [JsonPropertyName("weather")]
        public List<WeatherCondition> Weather { get; set; }

        [JsonPropertyName("wind")]
        public Wind Wind { get; set; }
        
    }
        
    

    public class MainInfo
    {
        [JsonPropertyName("temp")]
        public double Temp { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("pressure")]
        public int pressure { get; set; }
    }

    public class WeatherCondition
    {
        [JsonPropertyName("main")]
        public string description { get; set; }
    }

    public class Wind
    {
        [JsonPropertyName("speed")]
        public float speed { get; set; }

    }
    
}
        
    