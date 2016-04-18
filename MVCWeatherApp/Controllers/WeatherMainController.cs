using MVCWeatherApp.BL;
using MVCWeatherApp.DAL;
using MVCWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWeatherApp.Controllers
{
    public class WeatherMainController : AsyncController
    {
        // GET: WeatherMain
        public ActionResult WeatherMainView()
        {
            PopulateModelsWithData obj = new PopulateModelsWithData();
            CityWeather objCity = new CityWeather();
            obj.PopulateTheCityWeatherObject(objCity);
            return View();
        }
    }
}