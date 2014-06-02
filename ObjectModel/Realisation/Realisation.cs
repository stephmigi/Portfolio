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

        public string ShortDescription
        {
            get
            {
                return Description.EllipseString(25);
            }
        }

        public readonly int Id;

        private string _imageName { get; set; }

        public string ImageName 
        { 
            get
            {
                return this._imageName ?? "NoLogo.gif";
            }
        }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public RealisationType Type { get; set; }

        public List<Competence> Competences { get; set; }

        public Realisation(string name, int id, string imageName = null)
        {
            this.Name = name;
            this.Id = id;
            this.Competences = new List<Competence>();
            this._imageName = imageName;
        }

        public void AddCompetence(Competence comp)
        {
            if (comp == null || this.Competences.Contains(comp))
                throw new InvalidOperationException("Competence must not be null or already be present in competence");

            this.Competences.Add(comp);
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
            return this.Competences.Where(c => c.Type == type).ToList();
        }
    }
}