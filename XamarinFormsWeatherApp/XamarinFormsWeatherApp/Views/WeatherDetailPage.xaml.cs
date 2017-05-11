using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsWeatherApp.Services;
using static XamarinFormsWeatherApp.Models.Weather;

namespace XamarinFormsWeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherDetailPage : ContentPage
    {

        private WeatherService _weatherService = new WeatherService();
        private RootObject _rootObject;

        public WeatherDetailPage(RootObject rootObject)
        {
            InitializeComponent();

            if (rootObject == null)
                throw new ArgumentNullException(nameof(rootObject));

            _rootObject = rootObject;
            InitializeComponent();



            BindingContext = _rootObject;
        }
    }
}
