using ObjectModel;
using ObjectModel.Database;
using ObjectModel.Realisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class RealisationController : Controller
    {
        private IRealisationRepository _repo;

        public RealisationController()
        {
            @ViewBag.Active = "Realisation";
            this._repo = new RealisationRepository(new SMPortfolioEntities());
        }

        public ActionResult Index()
        {
            var realisationList2 = _repo.GetAll();
            return View("Index", realisationList2);  
        }

        public ActionResult Detail(int id)
        {
            var currentRealisation = _repo.GetById(id);

            return currentRealisation != null ? View("SimpleDetail", currentRealisation) : View("404");
        }
    }
}