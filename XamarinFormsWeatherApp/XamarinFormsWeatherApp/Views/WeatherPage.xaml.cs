using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsWeatherApp.Services;

namespace XamarinFormsWeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage  
    {
        private WeatherService _weatherService = new WeatherService();
        private string lat = "-43.5321";
        private string lon = "-123.41670367098749";
        private string jsonObject;

        public WeatherPage()
        {
            InitializeComponent();
            GetCurrentPosition();
          
        }

      public  async void Button_Clicked(object sender, EventArgs e)
        {
       


         

       var    jsonObject = await  _weatherService.GetWeather(lat, lon);
            await Navigation.PushAsync( new WeatherDetailPage(jsonObject));
        }







        public async void GetCurrentPosition()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;
            var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

            lat = position.Latitude.ToString();
            lon = position.Longitude.ToString(); 
        }

    }
}
