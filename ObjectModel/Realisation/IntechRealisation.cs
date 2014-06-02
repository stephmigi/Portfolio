using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class IntechRealisation : Realisation
    {
        public IntechSemester Semester { get; set; }



        public IntechRealisation(string name, int id, string imageName) : base(name, id, imageName) { }
    }
}