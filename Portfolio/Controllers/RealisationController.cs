using ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class RealisationController : Controller
    {
        public RealisationController()
        {
            @ViewBag.Active = "Realisation";
        }

        public ActionResult Index()
        {
            var realisationList = Realisation.GetAllInstances().ToList();
            return View("Index", realisationList);  
        }

        public ActionResult Detail(int id)
        {
            var currentRealisation = Realisation.GetInstance(id);

            return currentRealisation != null ? View("SimpleDetail", currentRealisation) : View("404");
        }
    }
}