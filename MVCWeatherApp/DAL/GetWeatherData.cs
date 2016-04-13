using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace MVCWeatherApp.DAL
{
    public class GetWeatherData
    {
        public async Task<string> GetWeatherDataFromWebAPI()
        {
            string WeatherData;
            using(var client=new HttpClient())
            {
                WeatherData = await client.GetStringAsync("api.openweathermap.org/data/2.5/weather?q={Bangalore}").ConfigureAwait(false);
            }
            return WeatherData;
        }
        JavaScriptSerializer sz = new JavaScriptSerializer();
    }
}