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
            //var x = obj.PopulateTheCityWeatherObject();
            System.Diagnostics.Debug.WriteLine("The return value = " + obj.PopulateTheCityWeatherObject().ToString());
            System.Diagnostics.Debug.WriteLine("The return value = View");
            //return View(obj.PopulateTheCityWeatherObject().ToString());
            return View();
        }
    }
}