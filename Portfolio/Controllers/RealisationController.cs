using ObjectModel;
using ObjectModel.Database;
using ObjectModel.Realisations;
using ObjectModel.Competences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.ViewModels.Realisations;

namespace Portfolio.Controllers
{
    public class RealisationController : Controller
    {
        private RealisationAndCompetenceService _realAndCompService;

        public RealisationController()
        {
            @ViewBag.Active = "Realisation";
            this._realAndCompService = new RealisationAndCompetenceService(new SMEntityRepository<ObjectModel.Database.Realisation, ObjectModel.Realisations.Realisation>(new SMPortfolioEntities()), new SMEntityRepository<ObjectModel.Database.Competence, ObjectModel.Competences.Competence>(new SMPortfolioEntities()));
        }

        public ActionResult Index()
        {
            var realisationList = _realAndCompService.GetAllRealisations();
            var model = new ListViewModel(realisationList);
            return View("Index", model);  
        }

        public ActionResult Detail(int id)
        {
            var currentRealisation = _realAndCompService.GetRealisationById(id);

            var model = new DisplayViewModel(currentRealisation);
            model.LinkedCompetences = _realAndCompService.GetLinkedCompetences(currentRealisation.Id);

            return View("Detail", model);
        }
    }
}