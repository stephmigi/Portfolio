using ObjectModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
            @ViewBag.Active = "Home";
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View("Contact");
        }

        [HttpGet]
        public ActionResult ChangeLanguage(string id)
        {
            CreateCookie("Language", id);

            return RedirectToAction("Index");
        }
    }
}
