using System;
using Newtonsoft.Json;
using System.Net;
namespace weather_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string apikey = "6ef7b0f7014580571a8a93baf166d5fa";
        private void btnsearch_Click(object sender, EventArgs e)
        {
            getweather();
        }
        void getweather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q={tbcityname.Text}&appid={apikey}";
                    var json = web.DownloadString(url);
                    weather_info.root Info = JsonConvert.DeserializeObject<weather_info.root>(json);
                    lcondition.Text = Info.weather[0].main;
                    ldescription.Text = Info.weather[0].description;
                    double tempreture = Info.main.temp;
                    tempreture = tempreture - 273.15;
                    ltempreture.Text = tempreture.ToString("F2") + "°C";
                    lsunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                    lsunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                    lwindspeed.Text = Info.wind.speed.ToString();
                    lpressure.Text = Info.main.pressure.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("City Not Found");
            }

        }

        private void tbcityname_TextChanged(object sender, EventArgs e)
        {

        }
        DateTime convertDateTime(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();
            return day;
        }
    }
}