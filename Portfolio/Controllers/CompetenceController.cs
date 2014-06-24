using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ObjectModel.Database;
using ObjectModel.Repositories;
using ObjectModel.Services;

using Portfolio.ViewModels.Competences;

namespace Portfolio.Controllers
{
    public class CompetenceController : BaseController
    {
        private RealisationAndCompetenceService _realAndCompService;

        public CompetenceController()
        {
            @ViewBag.Active = "Competence";
            this._realAndCompService = new RealisationAndCompetenceService(new SMEntityRepository<ObjectModel.Database.Realisation, ObjectModel.Realisations.Realisation>(new SMPortfolioEntities()), new SMEntityRepository<ObjectModel.Database.Competence, ObjectModel.Competences.Competence>(new SMPortfolioEntities()));
        }

        public ActionResult Index()
        {
            var competenceList = _realAndCompService.GetAllCompetences();
            var model = new ListViewModel(competenceList);
            return View("Index", model);    
        }

        public ActionResult Detail(int id)
        {
            var competence = _realAndCompService.GetCompetenceById(id);

            if (competence == null)
                return View("404");

            var model = new DisplayViewModel(competence);
            model.LinkedRealisations = _realAndCompService.GetLinkedRealisations(competence.Id);

            return View("Detail", model);
        }
    }
}
