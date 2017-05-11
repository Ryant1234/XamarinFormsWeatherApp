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
        private string lat = "47.20296790272209";
        private string lon = "-123.41670367098749";
        private string jsonObject;

        public WeatherPage()
        {
            InitializeComponent();
        }

      public  async void Button_Clicked(object sender, EventArgs e)
        {
       var    jsonObject = await  _weatherService.GetWeather(lat, lon);
            await Navigation.PushAsync( new WeatherDetailPage(jsonObject));
        }
    }
}
