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
        //
        // GET: /Realisation/

        public ActionResult Index()
        {
            var fake = FakeProfileSimulator.GetAFakeProfile();
            return View("Index", fake.Realisations);  
        }

        public ActionResult Detail(int id)
        {
            var fake = FakeProfileSimulator.GetAFakeProfile();
            return View("Detail", fake.GetARealisation(id));
        }
    }
}
