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
        public SkyWatch()
        {
            InitializeComponent();
            Env.Load("C:\\Users\\adnel\\source\\repos\\VærApp\\.env");
            apiKey = Environment.GetEnvironmentVariable("api");
        }

        private void SkyWatch_Load(object sender, EventArgs e)
        {
        }

        private async void HentVær_Click(object sender, EventArgs e)
        {
            try
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={ByHenter.Text}&appid={apiKey}&units=metric";
                Debug.WriteLine(url);
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
        public float Temp { get; set; }
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
        
    