using ObjectModel;
using ObjectModel.Database;
using ObjectModel.Realisations;
using ObjectModel.Competences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class RealisationController : Controller
    {
        private RealisationAndCompetenceService _realAndCompService;

        public RealisationController()
        {
            @ViewBag.Active = "Realisation";
            this._realAndCompService = new RealisationAndCompetenceService(new RealisationRepository(new SMPortfolioEntities()), new CompetenceRepository(new SMPortfolioEntities()));
        }

        public ActionResult Index()
        {
            var realisationList = _realAndCompService.GetAllRealisations();
            return View("Index", realisationList);  
        }

        public ActionResult Detail(int id)
        {
            var currentRealisation = _realAndCompService.GetRealisationById(id);
            return currentRealisation != null ? View("SimpleDetail", currentRealisation) : View("404");
        }
    }
}