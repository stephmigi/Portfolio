using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ObjectModel.Realisations;

namespace Portfolio.ViewModels.Realisations
{
    /// <summary>
    /// ViewModel used to display a list of realisations (not in detail)
    /// </summary>
    public class ListViewModel
    {
        public IEnumerable<Realisation> Realisations { get; set; }

        public ListViewModel(IEnumerable<Realisation> instance)
        {
            Realisations = instance;
        }
    }
}