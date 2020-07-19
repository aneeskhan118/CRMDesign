using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult customer()
        {
            return View();
        }

        public ActionResult customerInfo()
        {
            return View();
        }
    }
}