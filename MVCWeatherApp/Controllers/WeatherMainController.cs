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
    public class WeatherMainController : Controller
    {
        // GET: WeatherMain
        public ActionResult WeatherMainView()
        {
            PopulateModelsWithData obj = new PopulateModelsWithData();
            GetWeatherDataContext gt = new GetWeatherDataContext();
            CityWeather cwthr = new CityWeather();
            obj.PopulateTheCityWaetherObject(cwthr);

            return View();
        }
    }
}