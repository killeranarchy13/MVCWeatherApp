using MVCWeatherApp.DAL;
using MVCWeatherApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MVCWeatherApp.BL
{
    public class PopulateModelsWithData
    {
        public async Task<string> PopulateTheCityWeatherObject()
        {
            GetWeatherDataContext gt = new GetWeatherDataContext();
            string WeatherInfo = await gt.GetWeatherDataFromWebAPI("Bangalore").ConfigureAwait(false);

            //cityWthr = JsonConvert.DeserializeObject<CityWeather>(WeatherInfo);
            System.Diagnostics.Debug.WriteLine("The return value = " + WeatherInfo);
            System.Diagnostics.Debug.WriteLine("The return value = Populate");

            return WeatherInfo;
        }
        
    }
}