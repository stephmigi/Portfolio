using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Competence
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public readonly int Id;
        public CompetenceType Type { get; set; }

        public List<Realisation> Realisations { get; set; }

        public Competence(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            this.Realisations = new List<Realisation>();
        }

        public void AddRealisation(Realisation real)
        {
            if (real != null && !this.Realisations.Contains(real))
            {
                this.Realisations.Add(real);
            }
            else
            {
                throw new InvalidOperationException("Realisation must not be null or already be present in competence");
            }
        }

        public void AddRealisations(List<Realisation> reals)
        {
            foreach (var r in reals)
            {
                this.AddRealisation(r);
            }
        }
    }
}
