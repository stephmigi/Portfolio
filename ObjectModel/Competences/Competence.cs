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

        //public IEnumerable<Realisation> Realisations
        //{
        //    get
        //    {
        //        return Realisation.GetInstances(this.RealisationIds);
        //    }
        //}

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

        #region static methods

        /// <summary>
        /// Get an instance of a realisation from database
        /// </summary>
        /// <param name="dbId">The object's database id</param>
        /// <returns>The realisation or null if it doesn't exist</returns>
        public static Competence GetInstance(int dbId)
        {
            using (var db = new SMPortfolioEntities())
            {
                var dbObject = db.Competences.SingleOrDefault(r => r.Id == dbId);
                if (dbObject != null)
                {
                    return new Competence(dbObject);
                }
                return null;
            }
        }

        /// <summary>
        /// Get multiple instances of Realisation
        /// </summary>
        /// <param name="dbIds">List of database object ids</param>
        /// <returns>The Enumerable of realisations</returns>
        public static IEnumerable<Competence> GetInstances(IEnumerable<int> dbIds)
        {
            foreach (int id in dbIds)
            {
                yield return GetInstance(id);
            }
        }

        /// <summary>
        /// Get all Realisations from database
        /// </summary>
        /// <returns>All the realisations</returns>
        public static IEnumerable<Competence> GetAllInstances()
        {
            List<int> ids;

            using (var db = new SMPortfolioEntities())
            {
                ids = db.Competences.Select(r => r.Id).ToList();
            }

            return GetInstances(ids);
        }

        #endregion
    }
}
