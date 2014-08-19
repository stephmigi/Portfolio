using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ObjectModel.Services;
using ObjectModel.Repositories;
using ObjectModel.Database;

using Portfolio.ViewModels.Realisations;

namespace Portfolio.Controllers
{
    using ObjectModel.Helpers;
    using ObjectModel.Realisations;

    public class RealisationController : BaseController
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
            var model = new ListViewModel(realisationList, EnumHelpers.GetValues<RealisationType>());
            return View("Index", model);  
        }

        public ActionResult Detail(int id)
        {
            var realisation = _realAndCompService.GetRealisationById(id);

            if (realisation == null)
                return View("404");

            var model = new DisplayViewModel(realisation);
            model.LinkedCompetences = _realAndCompService.GetLinkedCompetences(realisation.Id);

            return View("Detail", model);
        }
    }
}