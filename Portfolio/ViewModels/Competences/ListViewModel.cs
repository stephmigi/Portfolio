using ObjectModel.Competences;
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
            this.Competences = instance;
        }
    }
}