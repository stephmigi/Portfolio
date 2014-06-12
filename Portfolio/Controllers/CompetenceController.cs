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
        public CompetenceController()
        {
            @ViewBag.Active = "Competence";
        }

        public ActionResult Index()
        {
            var competenceList = Competence.GetAllInstances().ToList();
            return View("Index", competenceList);    
        }

        public ActionResult Detail(int id)
        {
            var currentCompetence = Competence.GetInstance(id);
            return View("Detail", currentCompetence);
        }
    }
}
