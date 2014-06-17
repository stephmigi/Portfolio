using ObjectModel;
using ObjectModel.Competences;
using ObjectModel.Database;
using ObjectModel.Realisations;
using Portfolio.ViewModels.Competences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class CompetenceController : Controller
    {
        private RealisationAndCompetenceService _realAndCompService { get; set; }

        public CompetenceController()
        {
            @ViewBag.Active = "Competence";
            this._realAndCompService = new RealisationAndCompetenceService(new RealisationRepository(new SMPortfolioEntities()), new CompetenceRepository(new SMPortfolioEntities()));
        }

        public ActionResult Index()
        {
            var competenceList = _realAndCompService.GetAllCompetences();

            var model = new ListViewModel(competenceList);

            return View("Index", model);    
        }

        public ActionResult Detail(int id)
        {
            var currentCompetence = _realAndCompService.GetCompetenceById(id);

            var model = new DisplayViewModel(currentCompetence);
            model.LinkedRealisations = _realAndCompService.GetLinkedRealisations(currentCompetence);

            return View("Detail", model);
        }
    }
}
