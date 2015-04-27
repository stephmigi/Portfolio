using ObjectModel;

using System.Collections.Generic;

namespace Portfolio.ViewModels.Layout
{
    public class NavBarViewModel
    {
        public Dictionary<NavigationBarItem, string> NavItems { get; set; }

        public string CurrentController { get; set; }

        public NavigationBarItem ActiveTab { get; set; }
        
        public NavBarViewModel(Dictionary<NavigationBarItem, string> navItems, NavigationBarItem activeTab)
        {
            NavItems = navItems;
            ActiveTab = activeTab;
        }
    }
}
