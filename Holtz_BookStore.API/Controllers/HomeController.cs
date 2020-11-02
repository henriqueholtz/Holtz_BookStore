using Holtz_BookStore.API.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Holtz_BookStore.API.Controllers
{
    //[LogActionFilter()] //My Custom Log Action Filter
    public class HomeController : Controller
    {
        //[Route("{station:(spring|summer|autumn|winter)}")] //Error here
        public string ActionStation(string station)
        {
            return "Hello! Welcome to station " + station;
        }


        //[LogActionFilter()] //My Custom Log Action Filter
        public string Str()
        {
            return "STR ACTION!";
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}