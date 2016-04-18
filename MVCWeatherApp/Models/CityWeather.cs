using MVCWeatherApp.DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWeatherApp.Models
{
    public class CityWeather
    {
        //public Main TemperatureData { get; set; }
        //public string WindData { get; set; }

        //public Array coord { get; set; }
        //public Array weather { get; set; }
        //public Array base1 { get; set; }
        //public Array visibility { get; set; }
        //public Array wind { get; set; }
        //public Array clouds { get; set; }
        //public Array dt { get; set; }
        //public Array sys { get; set; }
        //public Array name { get; set; }
        
        public string temp { get; set; }
        public string humidity { get; set; }
    }

    public class Wrapper
    {
        [JsonProperty("main")]
        public CityWeather CityWeather { get; set; }
    }

    //public class Wind
    //{
    //    public int Speed { get; set; }
    //    public int Direction { get; set; }
    //}

    //public class Main
    //{
    //    public int Temperature { get; set; }
    //    public int Pressure { get; set; }
    //    public int Humidity { get; set; }
    //}
}