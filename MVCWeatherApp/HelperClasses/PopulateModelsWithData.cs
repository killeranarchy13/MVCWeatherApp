using MVCWeatherApp.DAL;
using MVCWeatherApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace MVCWeatherApp.BL
{
    public class PopulateModelsWithData
    {
        public string PopulateTheCityWeatherObject(CityWeather objCity)
        {
            try
            {
                string WeatherInfo;
                GetWeatherDataContext gt = new GetWeatherDataContext();
                WeatherInfo = gt.GetWeatherDataFromWebAPI("Bangalore");

                objCity = JsonConvert.DeserializeObject<CityWeather>(WeatherInfo);
                return WeatherInfo;
            }
            catch (Exception ex)
            {
                return "";
            }

        }
        
    }
}