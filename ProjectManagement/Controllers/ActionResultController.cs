using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ActionResultController : Controller
    {
        public ActionResult RedirectPermanent()
        {
            return Content("This message is sent from the Index action!”;");
        }
        public ActionResult RedirectToActionInTheSameController()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}