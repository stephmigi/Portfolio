using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ObjectModel.Realisations;

namespace Portfolio.ViewModels.Realisations
{
    public class ListViewModel
    {
        public IEnumerable<Realisation> Realisations { get; set; }

        public ListViewModel(IEnumerable<Realisation> instance)
        {
            Realisations = instance;
        }
    }
}