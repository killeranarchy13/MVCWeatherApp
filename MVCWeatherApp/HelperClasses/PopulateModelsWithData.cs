using MVCWeatherApp.DAL;
using MVCWeatherApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWeatherApp.BL
{
    public class PopulateModelsWithData
    {
        public void PopulateTheCityWaetherObject(CityWeather cityWthr)
        {
            GetWeatherDataContext gt = new GetWeatherDataContext();
            string WeatherInfo = gt.GetWeatherDataFromWebAPI("Bangalore").ToString();

            cityWthr = JsonConvert.DeserializeObject<CityWeather>(WeatherInfo);
            Console.WriteLine(cityWthr.WindData.Speed);
        }
    }
}