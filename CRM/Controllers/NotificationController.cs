using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class NotificationController : Controller
    {
        // GET: Notification
        public ActionResult notificationMarketing()
        {
            return View();
        }

        public ActionResult splashMarketing()
        {
            return View();
        }

        public ActionResult systemSettings()
        {
            return View();
        }

        public ActionResult accessPermission()
        {
            return View();
        }

        public ActionResult userGroup()
        {
            return View();
        }

        public ActionResult sendSMS()
        {
            return View();
        }

        public ActionResult sendPush()
        {
            return View();
        }

        public ActionResult viewUser()
        {
            return View();
        }

        public ActionResult addUser()
        {
            return View();
        }
    }
}