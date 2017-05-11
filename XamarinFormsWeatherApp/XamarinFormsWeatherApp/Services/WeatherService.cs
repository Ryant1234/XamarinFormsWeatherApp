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
            private  string Key = "";
      

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

    }
}
