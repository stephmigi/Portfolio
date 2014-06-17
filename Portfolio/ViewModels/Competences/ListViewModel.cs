using ObjectModel;
using ObjectModel.Realisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.ViewModels.Competences
{
    public class ListViewModel
    {
        public IEnumerable<Competence> Competences { get; set; }

        public ListViewModel(IEnumerable<Competence> instance)
        {
            Competences = instance;
        }
    }
}