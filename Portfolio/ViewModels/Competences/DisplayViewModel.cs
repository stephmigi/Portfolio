using ObjectModel;
using ObjectModel.Realisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.ViewModels.Competences
{
    public class DisplayViewModel
    {
        public int CompetenceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Realisation> LinkedRealisations { get; set; }

        public DisplayViewModel() { }

        public DisplayViewModel(Competence instance)
        {
            this.CompetenceId = instance.Id;
            this.Name = instance.Name;
            this.Description = instance.Description;

            LinkedRealisations = new List<Realisation>();
        }
    }
}