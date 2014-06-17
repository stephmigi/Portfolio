using ObjectModel.Database;
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

        public Competence(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public List<int> RealisationIds { get; set; }

        /// <summary>
        /// Private constructor, only use this to
        /// Initialize an instance of realisation with a 
        /// dbobject.
        /// </summary>
        /// <param name="dbId"></param>
        internal Competence(Database.Competence dbObject)
        {
            this.Id = dbObject.Id;
            this.Description = dbObject.Description;
            this.Name = dbObject.Name;

            this.Type = (CompetenceType)dbObject.CompetenceType;

            this.RealisationIds = new List<int>();

            foreach (var competence in dbObject.Realisations)
            {
                this.RealisationIds.Add(competence.Id);
            }
        }
    }
}
