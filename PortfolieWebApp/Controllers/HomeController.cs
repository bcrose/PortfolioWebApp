using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolieWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My Current Job Resume";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ben Rose";

            return View();
        }
    }
}