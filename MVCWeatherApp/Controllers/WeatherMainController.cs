using MVCWeatherApp.DAL;
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
            GetWeatherDataContext gt = new GetWeatherDataContext();
            string x=gt.GetWeatherDataFromWebAPI("Bangalore").ToString();
            return View();
        }
    }
}