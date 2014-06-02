using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Company
    {
        private string _name { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        private string _imagePath { get; set; }

        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
        }

        public Company(string name)
        {
            this._name = Name;
        }
    }
}
