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
            CityWeather model = new CityWeather();
            obj.PopulateTheCityWeatherObject(ref model);
            return View(model);
        }
    }
}