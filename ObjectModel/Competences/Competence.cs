using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjectModel.Database;

namespace ObjectModel.Competences
{
    using ObjectModel.Extensions;

    public class Competence
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public readonly int Id;
        public CompetenceType Type { get; set; }

        private string _imageName { get; set; }

        public string ShortDescription
        {
            get
            {
                return Description.EllipseString(200);

            }
        }

        public string ImageName
        {
            get
            {
                return this._imageName;
            }
        }

        public Competence() { }

        public Competence(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            _imageName = "NoLogo.gif";
        }

        public List<int> RealisationIds { get; set; }

        /// <summary>
        /// Private constructor, only use this to
        /// Initialize an instance of realisation with a 
        /// dbobject.
        /// </summary>
        /// <param name="dbId"></param>
        public Competence(Database.Competence dbObject)
        {
            this.Id = dbObject.Id;
            this.Description = dbObject.Description;
            this.Name = dbObject.Name;
            this._imageName = "NoLogo.gif";

            this.Type = (CompetenceType)dbObject.CompetenceType;

            this.RealisationIds = new List<int>();

            foreach (var competence in dbObject.Realisations)
            {
                this.RealisationIds.Add(competence.Id);
            }
        }
    }
}
