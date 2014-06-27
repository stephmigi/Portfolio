using ObjectModel;
using ObjectModel.Helpers;
using Portfolio.ViewModels.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class LayoutController : BaseController
    {
        public ActionResult NavigationBar()
        {
            var model = new NavBarViewModel(EnumHelpers.GetAllElementsWithResourceKey<NavigationBarItem>());

            return View("_Navbar", model);
        }

        public void ChangeLanguage(string id)
        {
            CreateCookie("Language", id);
            Response.Redirect(Request.UrlReferrer.ToString());
        }
    }
}
