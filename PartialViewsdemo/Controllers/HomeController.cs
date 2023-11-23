using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewsdemo.Controllers
{
    public class HomeController : Controller
    {
        static List<string> names = new List<string>() {"Anil","Amit","Sunil","Pravin" };

        [Authorize()]
        [RequireHttps]
        public ActionResult SalesData() 
        {
            return View();
        }


        public ActionResult Index()
        {
            ViewBag.listdata = names;
            return View();
        }

        [ChildActionOnly]
        public ActionResult GetAddress()
        {
           
            return PartialView("_Address");
        }

        [NonAction]
        public string Greet()
        {
            return "Good day!!!";

        }
        public ActionResult About()
        {
            string greetings = Greet();
            ViewBag.gr = greetings;
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