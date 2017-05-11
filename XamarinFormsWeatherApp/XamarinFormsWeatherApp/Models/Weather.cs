using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsWeatherApp.Services;

namespace XamarinFormsWeatherApp.Models
{

    public class Weather
    {
       


        public class RootObject
        {



            [JsonProperty(PropertyName = "latitude")]
            public double Latitude { get; set; }

            [JsonProperty(PropertyName = "longitude")]
            public double Longitude { get; set; }

            [JsonProperty(PropertyName = "timezone")]
            public string Timezone { get; set; }

            [JsonProperty(PropertyName = "currently")]
            public Currently Currently { get; set; }

            [JsonProperty(PropertyName = "minutely")]
            public Minutely Minutely { get; set; }

            [JsonProperty(PropertyName = "hourly")]
            public Hourly Hourly { get; set; }

            [JsonProperty(PropertyName = "daily")]
            public Daily Daily { get; set; }

            [JsonProperty(PropertyName = "alerts")]
            public List<Alert> Alerts { get; set; }
        }



        public class Currently
        {

            WeatherService weatherService = new WeatherService();


            public int Time { get; set; }

            [JsonProperty(PropertyName = "summary")]
            public string Summary { get; set; }

            [JsonProperty(PropertyName = "icon")]
            public string Icon { get; set; }

            [JsonProperty(PropertyName = "nearestStormDistance")]
            public int NearestStormDistance { get; set; }

            [JsonProperty(PropertyName = "precipIntensity")]
            public double PrecipIntensity { get; set; }

            [JsonProperty(PropertyName = "precipIntensityError")]
            public double PrecipIntensityError { get; set; }

            [JsonProperty(PropertyName = "precipProbability")]
            public int PrecipProbability { get; set; }

            [JsonProperty(PropertyName = "precipType")]
            public string PrecipType { get; set; }

            [JsonProperty(PropertyName = "temperature")]
            public double Temperature { get; set; }

            [JsonProperty(PropertyName = "apparentTemperature")]
            public double ApparentTemperature { get; set; }

            [JsonProperty(PropertyName = "dewPoint")]
            public double DewPoint { get; set; }

            [JsonProperty(PropertyName = "humidity")]
            public double Humidity { get; set; }

            [JsonProperty(PropertyName = "windSpeed")]
            public double WindSpeed { get; set; }

            [JsonProperty(PropertyName = "windBearing")]
            public string WindBearing {
                get
                {
                    return this.WindDirection;
                }
                 set {
                    this.WindDirection = weatherService.GetWindDirection(int.Parse(value));
                   
                }

                }   
                
              

            [JsonProperty(PropertyName = "visibility")]
            public double Visibility { get; set; }

            [JsonProperty(PropertyName = "cloudCover")]
            public double CloudCover { get; set; }

            [JsonProperty(PropertyName = "pressure")]
            public double Pressure { get; set; }

            [JsonProperty(PropertyName = "ozone")]
            public double Ozone { get; set; }




            public string WindDirection
            {
                get; set;
            }
               


        }

        public class MinutelyData
        {

            [JsonProperty(PropertyName = "time")]
            public int Time { get; set; }

            [JsonProperty(PropertyName = "precipIntensity")]
            public double PrecipIntensity { get; set; }

            [JsonProperty(PropertyName = "precipIntensityError")]
            public double PrecipIntensityError { get; set; }

            [JsonProperty(PropertyName = "precipProbability")]
            public int PrecipProbability { get; set; }

            [JsonProperty(PropertyName = "precipType")]
            public string PrecipType { get; set; }
        }

        public class Minutely
        {
            [JsonProperty(PropertyName = "summary")]
            public string Summary { get; set; }

            [JsonProperty(PropertyName = "icon")]
            public string Icon { get; set; }

            [JsonProperty(PropertyName = "data")]
            public List<MinutelyData> Data { get; set; }

        }


        public class HourlyData
        {
            [JsonProperty(PropertyName = "time")]
            public int Time { get; set; }

            [JsonProperty(PropertyName = "summary")]
            public string Summary { get; set; }

            [JsonProperty(PropertyName = "icon")]
            public string Icon { get; set; }

            [JsonProperty(PropertyName = "precipIntensity")]
            public double PrecipIntensity { get; set; }

            [JsonProperty(PropertyName = "precipProbability")]
            public double PrecipProbability { get; set; }

            [JsonProperty(PropertyName = "precipType")]
            public string PrecipType { get; set; }

            [JsonProperty(PropertyName = "temperature")]
            public double Temperature { get; set; }

            [JsonProperty(PropertyName = "apparentTemperature")]
            public double ApparentTemperature { get; set; }

            [JsonProperty(PropertyName = "dewPoint")]
            public double DewPoint { get; set; }

            [JsonProperty(PropertyName = "humidity")]
            public double Humidity { get; set; }

            [JsonProperty(PropertyName = "windSpeed")]
            public double WindSpeed { get; set; }

            [JsonProperty(PropertyName = "windBearing")]
            public int WindBearing { get; set; }

            [JsonProperty(PropertyName = "visibility")]
            public double Visibility { get; set; }

            [JsonProperty(PropertyName = "cloudCover")]
            public double CloudCover { get; set; }

            [JsonProperty(PropertyName = "pressure")]
            public double Pressure { get; set; }

            [JsonProperty(PropertyName = "ozone")]
            public double Ozone { get; set; }

        }

        public class Hourly
        {
            [JsonProperty(PropertyName = "summary")]
            public string Summary { get; set; }

            [JsonProperty(PropertyName = "icon")]
            public string Icon { get; set; }

            [JsonProperty(PropertyName = "data")]
            public List<HourlyData> Data { get; set; }
        }

        public class DailyData
        {
            [JsonProperty(PropertyName = "time")]
            public int Time { get; set; }

            [JsonProperty(PropertyName = "summary")]
            public string Summary { get; set; }

            [JsonProperty(PropertyName = "icon")]
            public string Icon { get; set; }

            [JsonProperty(PropertyName = "sunriseTime")]
            public int SunriseTime { get; set; }

            [JsonProperty(PropertyName = "sunsetTime")]
            public int SunsetTime { get; set; }

            [JsonProperty(PropertyName = "moonPhase")]
            public double MoonPhase { get; set; }

            [JsonProperty(PropertyName = "precipIntensity")]
            public double PrecipIntensity { get; set; }

            [JsonProperty(PropertyName = "precipIntensityMax")]
            public double PrecipIntensityMax { get; set; }

            [JsonProperty(PropertyName = "precipIntensityMaxTime")]
            public int PrecipIntensityMaxTime { get; set; }

            [JsonProperty(PropertyName = "precipProbability")]
            public double PrecipProbability { get; set; }

            [JsonProperty(PropertyName = "precipType")]
            public string PrecipType { get; set; }

            [JsonProperty(PropertyName = "temperatureMin")]
            public double TemperatureMin { get; set; }

            [JsonProperty(PropertyName = "temperatureMinTime")]
            public int TemperatureMinTime { get; set; }

            [JsonProperty(PropertyName = "temperatureMax")]
            public double TemperatureMax { get; set; }

            [JsonProperty(PropertyName = "temperatureMaxTime")]
            public int TemperatureMaxTime { get; set; }

            [JsonProperty(PropertyName = "apparentTemperatureMin")]
            public double ApparentTemperatureMin { get; set; }

            [JsonProperty(PropertyName = "apparentTemperatureMinTime")]
            public int ApparentTemperatureMinTime { get; set; }

            [JsonProperty(PropertyName = "apparentTemperatureMax")]
            public double ApparentTemperatureMax { get; set; }

            [JsonProperty(PropertyName = "apparentTemperatureMaxTime")]
            public int ApparentTemperatureMaxTime { get; set; }

            [JsonProperty(PropertyName = "dewPoint")]
            public double DewPoint { get; set; }

            [JsonProperty(PropertyName = "humidity")]
            public double Humidity { get; set; }


            [JsonProperty(PropertyName = "windSpeed")]
            public double WindSpeed { get; set; }

            [JsonProperty(PropertyName = "datawindBearing")]
            public int WindBearing { get; set; }

            [JsonProperty(PropertyName = "visibility")]
            public double Visibility { get; set; }

            [JsonProperty(PropertyName = "cloudCover")]
            public double CloudCover { get; set; }

            [JsonProperty(PropertyName = "pressure")]
            public double Pressure { get; set; }

            [JsonProperty(PropertyName = "ozone")]
            public double Ozone { get; set; }
        }

        public class Daily
        {
            [JsonProperty(PropertyName = "summary")]
            public string Summary { get; set; }

            [JsonProperty(PropertyName = "icon")]
            public string Icon { get; set; }

            [JsonProperty(PropertyName = "data")]
            public List<DailyData> Data { get; set; }
        }

        public class Alert
        {

            [JsonProperty(PropertyName = "title")]
            public string Title { get; set; }

            [JsonProperty(PropertyName = "time")]
            public int Time { get; set; }

            [JsonProperty(PropertyName = "expires")]
            public int Expires { get; set; }

            [JsonProperty(PropertyName = "description")]
            public string Description { get; set; }

            [JsonProperty(PropertyName = "uri")]
            public string Uri { get; set; }
        }
    }
}