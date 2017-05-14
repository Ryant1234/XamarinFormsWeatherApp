using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFormsWeatherApp.ValueConverters
{
public    class ColorConverter
    {


        public string setTemperatureBackGroundColor(double temp)
        {

            if (temp <= 4.9)
            {
                return "#bceefb";
            }

            if (temp >= 5 && temp <= 9.9)
            {
                return "#b9ecd8";
            }

            if (temp >= 10 && temp <= 14.9)
            {
             
                return "#cadb92";
            }

            if (temp >= 15 && temp <= 19.9)
            {
                return "#ffeb88";
            }

            if (temp >= 20 && temp <= 27)
            {
                return "#FBC25E";
            }

            if (temp >= 25 && temp <= 34)
            {
                return "#FF9933";
            }

            if (temp >= 35 && temp <= 39)
            {
                return "#cd5b12";
            }

            else 
                    {
                return "#ff0000";
            }


        }



    }
}
