using ObjectModel;
using ObjectModel.Helpers;
using Portfolio.ViewModels.Layout;

using System.Web.Mvc;

namespace Portfolio.Controllers
{
    using System;
    using System.Collections.Generic;

    public class LayoutController : BaseController
    {
        public ActionResult NavigationBar(Dictionary<string,string> activeTabInfo)
        {
            var activeTab = this.GetActiveNavBarItem(activeTabInfo["controller"], activeTabInfo["action"]);
            var model = new NavBarViewModel(EnumHelpers.GetAllElementsWithResourceKey<NavigationBarItem>(), activeTab);

            return View("_Navbar", model);
        }

        public void ChangeLanguage(string id)
        {
            CreateCookie("Language", id);
            Response.Redirect(Request.UrlReferrer.ToString());
        }

        private NavigationBarItem GetActiveNavBarItem(string controller, string action)
        {
            switch (controller)
            {
                case "Home":
                    return action == "Contact" ? NavigationBarItem.Contact : NavigationBarItem.Home;
                case "Realisation":
                    return NavigationBarItem.Realisations;
                case "Competence":
                    return NavigationBarItem.Competences;
            }
            throw new NotSupportedException("Action must exist");
        }
    }
}
