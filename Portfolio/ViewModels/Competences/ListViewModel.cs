using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ObjectModel.Competences;

namespace Portfolio.ViewModels.Competences
{
    /// <summary>
    /// ViewModel used to display a list of competences. (not in detail)
    /// </summary>
    public class ListViewModel
    {
        public IEnumerable<Competence> Competences { get; set; }

        public ListViewModel(IEnumerable<Competence> instance)
        {
            this.Competences = instance;
        }
    }
}