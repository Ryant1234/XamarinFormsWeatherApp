using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsWeatherApp.Models;
using static XamarinFormsWeatherApp.Models.Weather;

namespace XamarinFormsWeatherApp.Services
{
   public class WeatherService
    {

        private string lat = "42.3601";
        private string lon = "-71.0589";

        private const string Url = "https://api.darksky.net/forecast/";
            private  string Key = "a6c2c72e14790919d09621e9ec339207";
      

        private HttpClient _client = new HttpClient(new NativeMessageHandler());

        public async Task<RootObject> GetWeather(string latitude, string longitude)
        {
            try
            {
                // Gets a single movie for the detail page
                var response = await _client.GetAsync($"{Url}{Key}/{lat},{lon}");

                // If response statuscode is equal to StatusCode NotFound
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    return null;

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RootObject>(content);
            }
            catch (Exception)
            {

                throw;
            }

         
            }






        public string  GetWindDirection(int windAngle)
        {
            if (windAngle >= 348.75 || windAngle < 33.75)
            {
                return "N";
            }



            if (windAngle >= 33.75 && windAngle < 78.75)
            {
                return "NE";
            }

            if (windAngle >= 78.75 && windAngle < 123.75)
            {
                return "E";
            }

            if (windAngle >= 123.75 && windAngle < 168.75)
            {
                return "SE";
            }

            if (windAngle >= 168.75 && windAngle < 213.75)
            {
                return "S";
            }

            if (windAngle >= 213.75 && windAngle < 258.75)
            {
                return "SW";
            }

            if (windAngle >= 258.75 && windAngle < 303.75)
            {
                return "W";
            }

            if (windAngle >= 303.75 && windAngle < 348.75)
            {
                return "NW";
            }

            else
            {
                return "Error!";
            }

        }



    }










}
