using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace MVCWeatherApp.DAL
{
    public class GetWeatherDataContext
    {
        public string GetWeatherDataFromWebAPI(string CityName)
        {
            try
            {
                string WeatherData;
                using (var client = new WebClient())
                {
                    WeatherData = client.DownloadString("http://api.openweathermap.org/data/2.5/weather?q={"+ CityName + "}");
                    return WeatherData;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}