using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult order()
        {
            return View();
        }

        public ActionResult orderRejectList()
        {
            return View();
        }

        public ActionResult customOrder()
        {
            return View();
        }

        public ActionResult customOrderRejectList()
        {
            return View();
        }

        public ActionResult unsoldCart()
        {
            return View();
        }

        public ActionResult cartList()
        {
            return View();
        }

        public ActionResult orderSummary()
        {
            return View();
        }
    }
}