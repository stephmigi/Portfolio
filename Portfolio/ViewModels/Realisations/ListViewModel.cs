using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ObjectModel.Realisations;

namespace Portfolio.ViewModels.Realisations
{
    using System.Web.Mvc;

    /// <summary>
    /// ViewModel used to display a list of realisations (not in detail)
    /// </summary>
    public class ListViewModel
    {
        public IEnumerable<Realisation> Realisations { get; set; }
        public IEnumerable<SelectListItem> RealisationTypesItems { get; set; }

        public ListViewModel(IEnumerable<Realisation> instance, IEnumerable<RealisationType> realisationTypes)
        {
            this.Realisations = instance;
            this.RealisationTypesItems = EnumsToSelectListItems(realisationTypes);
        }

        private IEnumerable<SelectListItem> EnumsToSelectListItems(IEnumerable<RealisationType> enumValues)
        {
            var selectList = enumValues.Select(enumValue => new SelectListItem { Text = enumValue.ToString(), Value = ((int)enumValue).ToString() }).ToList();
            selectList.Add( new SelectListItem { Text = "All", Value = "-1" });
            return selectList.OrderBy(p => Int32.Parse(p.Value));
        }
    }
}