using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Realisation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public readonly int Id;

        public RealisationType Type { get; set; }

        public List<Competence> Competences { get; set; }

        public Realisation(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            this.Competences = new List<Competence>();
        }

        public void AddCompetence(Competence comp)
        {
            if (comp != null && !this.Competences.Contains(comp))
            {
                this.Competences.Add(comp);
            }
            else
            {
                throw new InvalidOperationException("Competence must not be null or already be present in competence");
            }
        }

        public void AddCompetences(List<Competence> comp)
        {
            foreach (var c in comp)
            {
                this.AddCompetence(c);
            }
        }

        public List<Competence> GetCompetencesByType(CompetenceType type)
        {
            return Competences.Where(c => c.Type == type).ToList();
        }
    }
}
