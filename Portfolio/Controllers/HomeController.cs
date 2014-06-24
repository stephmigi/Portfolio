using ObjectModel;
using Portfolio.ViewModels.Layout;
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

        public void ChangeLanguage(string id)
        {
            CreateCookie("Language", id);
            Response.Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult NavigationBar()
        {
            var model = new NavBarViewModel(NavBarManager.GetAllNavBarItemsWithResourceTexts());

            return View("_Navbar", model);
        }
    }
}
