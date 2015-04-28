using System.Collections.Generic;

using ObjectModel.Competences;
using ObjectModel.Realisations;

namespace Portfolio.ViewModels.Realisations
{
    /// <summary>
    /// ViewModel used to display one realisation in detail.
    /// </summary>
    public class DisplayViewModel
    {
        public int RealisationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public IEnumerable<Competence> LinkedCompetences { get; set; }

        public DisplayViewModel() { }

        public DisplayViewModel(Realisation instance)
        {
            this.RealisationId = instance.Id;
            this.Name = instance.Name;
            this.Description = instance.Description;
            this.ImageName = instance.ImageName;

            this.LinkedCompetences = new List<Competence>();
        }
    }
}
