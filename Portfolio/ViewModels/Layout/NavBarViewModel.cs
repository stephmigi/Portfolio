using ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.ViewModels.Layout
{
    public class NavBarViewModel
    {
        public Dictionary<NavigationBarItem, string> NavItems { get; set; }
        
        public NavBarViewModel(Dictionary<NavigationBarItem, string> navItems)
        {
            NavItems = navItems;
        }
    }
}
