using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult productList()
        {
            return View();
        }

        public ActionResult myCollection()
        {
            return View();
        }

        public ActionResult myCatalouge()
        {
            return View();
        }

        public ActionResult addProductList()
        {
            return View();
        }
    }
}