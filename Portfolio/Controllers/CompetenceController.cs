using ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class CompetenceController : Controller
    {
        //
        // GET: /Competence/

        public ActionResult Index()
        {
            var fake = FakeProfileSimulator.GetAFakeProfile();
            return View("Index", fake.Competences);    
        }

        public ActionResult Detail(int id)
        {
            var fake = FakeProfileSimulator.GetAFakeProfile();
            return View("Detail", fake.GetACompetence(id));
        }
    }
}
