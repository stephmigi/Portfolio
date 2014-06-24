using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public static class NavBarManager
    {
        public static IEnumerable<NavigationBarItem> GetAllNavBarItems()
        {
            return EnumHelpers.GetValues<NavigationBarItem>();
        }

        public static Dictionary<NavigationBarItem, string> GetAllNavBarItemsWithResourceTexts()
        {
            return EnumHelpers.GetAllElementsWithResourceKey<NavigationBarItem>();
        }
    }

    public enum NavigationBarItem
    {
        [Description("NAVBAR_MENUITEM_HOME")]
        Home,

        [Description("NAVBAR_MENUITEM_COMP")]
        Competences,

        [Description("NAVBAR_MENUITEM_REAL")]
        Realisations,

        [Description("NAVBAR_MENUITEM_CONTACT")]
        Contact
    }
}
