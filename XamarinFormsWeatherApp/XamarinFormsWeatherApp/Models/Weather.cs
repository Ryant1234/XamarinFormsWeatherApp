using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFormsWeatherApp.Models
{

    public class Weather
    {
   


        public class RootObject
        {

        


            public double latitude { get; set; }
            public double longitude { get; set; }
            public string timezone { get; set; }
            public Currently currently { get; set; }
            public Minutely minutely { get; set; }
            public Hourly hourly { get; set; }
            public Daily daily { get; set; }
            public List<Alert> alerts { get; set; }
        }



        public class Currently
        {
            public int Time { get; set; }
            public string summary { get; set; }
            public string icon { get; set; }
            public int nearestStormDistance { get; set; }
            public double precipIntensity { get; set; }
            public double precipIntensityError { get; set; }
            public int precipProbability { get; set; }
            public string precipType { get; set; }
            public double temperature { get; set; }
            public double apparentTemperature { get; set; }
            public double dewPoint { get; set; }
            public double humidity { get; set; }
            public double windSpeed { get; set; }
            public int windBearing { get; set; }
            public double visibility { get; set; }
            public double cloudCover { get; set; }
            public double pressure { get; set; }
            public double ozone { get; set; }
        }

        public class MinutelyData
        {
            public int time { get; set; }
            public double precipIntensity { get; set; }
            public double precipIntensityError { get; set; }
            public int precipProbability { get; set; }
            public string precipType { get; set; }
        }

        public class Minutely
        {
            public string summary { get; set; }
            public string icon { get; set; }
            public List<MinutelyData> data { get; set; }
        }


        public class HourlyData
        {
            public int time { get; set; }
            public string summary { get; set; }
            public string icon { get; set; }
            public double precipIntensity { get; set; }
            public double precipProbability { get; set; }
            public string precipType { get; set; }
            public double temperature { get; set; }
            public double apparentTemperature { get; set; }
            public double dewPoint { get; set; }
            public double humidity { get; set; }
            public double windSpeed { get; set; }
            public int windBearing { get; set; }
            public double visibility { get; set; }
            public double cloudCover { get; set; }
            public double pressure { get; set; }
            public double ozone { get; set; }
        }

        public class Hourly
        {
            public string summary { get; set; }
            public string icon { get; set; }
            public List<HourlyData> data { get; set; }
        }

        public class DailyData
        {
            public int time { get; set; }
            public string summary { get; set; }
            public string icon { get; set; }
            public int sunriseTime { get; set; }
            public int sunsetTime { get; set; }
            public double moonPhase { get; set; }
            public double precipIntensity { get; set; }
            public double precipIntensityMax { get; set; }
            public int precipIntensityMaxTime { get; set; }
            public double precipProbability { get; set; }
            public string precipType { get; set; }
            public double temperatureMin { get; set; }
            public int temperatureMinTime { get; set; }
            public double temperatureMax { get; set; }
            public int temperatureMaxTime { get; set; }
            public double apparentTemperatureMin { get; set; }
            public int apparentTemperatureMinTime { get; set; }
            public double apparentTemperatureMax { get; set; }
            public int apparentTemperatureMaxTime { get; set; }
            public double dewPoint { get; set; }
            public double humidity { get; set; }
            public double windSpeed { get; set; }
            public int windBearing { get; set; }
            public double visibility { get; set; }
            public double cloudCover { get; set; }
            public double pressure { get; set; }
            public double ozone { get; set; }
        }

        public class Daily
        {
            public string summary { get; set; }
            public string icon { get; set; }
            public List<DailyData> data { get; set; }
        }

        public class Alert
        {
            public string title { get; set; }
            public int time { get; set; }
            public int expires { get; set; }
            public string description { get; set; }
            public string uri { get; set; }
        }
    }
}