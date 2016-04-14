using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWeatherApp.Models
{
    public class CityWeather
    {
        public Main TemperatureData { get; set; }
        public Wind WindData { get; set; }
    }

    public class Wind
    {
        public int Speed { get; set; }
        public int Direction { get; set; }
    }

    public class Main
    {
        public int Temperature { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }
}