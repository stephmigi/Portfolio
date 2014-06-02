using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class WorkRealisation : Realisation
    {
        public Company Company { get; set; }
        public WorkRealisation(string name, int id, string imageName) : base(name, id, imageName) { }
    }
}