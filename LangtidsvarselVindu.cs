using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace VærApp
{
    public partial class LangtidsvarselVindu : Form
    {
        public string? By { get; set; }
        string apiKey;
        private readonly HttpClient client = new HttpClient();

        public LangtidsvarselVindu()
        {
            string env = @$"C:\Users\{Environment.UserName}\source\repos\V-rApp\.env";
            InitializeComponent();
            Env.Load(env);
            apiKey = Environment.GetEnvironmentVariable("api");

            Debug.WriteLine(env);
        }

        public void SetBy(string by)
        {
            By = by;
            ByTekst.Text = $"Langtidsvarselet i {By}";
        }

        private async void LangtidsvarselVindu_Load(object sender, EventArgs e)
        {
            try
            {
                string url = $"https://api.openweathermap.org/data/2.5/forecast/daily?q={By}&cnt=5&appid={apiKey}&units=metric";
                Debug.WriteLine(url);
                string json = await client.GetStringAsync(url);
                Debug.WriteLine(json);

                var weatherData = JsonSerializer.Deserialize<WeatherResponse>(json);

                if (weatherData?.list != null && weatherData.list.Count > 0)
                {
                    
                    Idag.Text = $"Idag: {weatherData.list[0].temp.day}°C, {weatherData.list[0].weather[0].description}, Vind: {weatherData.list[0].speed} m/s";

                    Imorgen.Text = $"Imorgen: {weatherData.list[1].temp.day}°C, {weatherData.list[1].weather[0].description}, Vind: {weatherData.list[1].speed} m/s";

                 
                    DateTime date3 = DateTimeOffset.FromUnixTimeSeconds(weatherData.list[2].dt).DateTime.Date;
                    Dag3.Text = $"{date3.ToString("dd.MM")}: {weatherData.list[2].temp.day}°C, {weatherData.list[2].weather[0].description}, Vind: {weatherData.list[2].speed} m/s";

                    DateTime date4 = DateTimeOffset.FromUnixTimeSeconds(weatherData.list[3].dt).DateTime.Date;
                    Dag4.Text = $"{date4.ToString("dd.MM")}: {weatherData.list[3].temp.day}°C, {weatherData.list[3].weather[0].description}, Vind: {weatherData.list[3].speed} m/s";

                    DateTime date5 = DateTimeOffset.FromUnixTimeSeconds(weatherData.list[4].dt).DateTime.Date;
                    Dag5.Text = $"{date5.ToString("dd.MM")}: {weatherData.list[4].temp.day}°C, {weatherData.list[4].weather[0].description}, Vind: {weatherData.list[4].speed} m/s";
                }
                else
                {
                    MessageBox.Show("Weather data could not be retrieved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        public class WeatherResponse
        {
            public List<DailyForecast>? list { get; set; }
        }

        public class DailyForecast
        {
            public long dt { get; set; }
            public Temp? temp { get; set; }
            public List<Weather> weather { get; set; }
            public double speed { get; set; }
        }

        public class Temp
        {
            public double day { get; set; }
        }

        public class Weather
        {
            public string? description { get; set; }
        }
    }
}