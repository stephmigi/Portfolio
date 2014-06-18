using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ObjectModel.Competences;
using ObjectModel.Realisations;

namespace Portfolio.ViewModels.Competences
{
    /// <summary>
    /// ViewModel used to display in detail one competence
    /// </summary>
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

            this.LinkedRealisations = new List<Realisation>();
        }
    }
}