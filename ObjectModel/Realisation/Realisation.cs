using ObjectModel.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class Realisation
    {
        #region properties
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

        public RealisationType Type { get; set; }

        public List<int> CompetenceIds { get; set; }

        public IEnumerable<Competence> Competences
        {
            get
            {
                return Competence.GetInstances(this.CompetenceIds);
            }
        }

        #endregion

        #region constructors  

        ///// <summary>
        ///// Initialize a new instance of Realisation
        ///// </summary>
        ///// <param name="name">the name</param>
        ///// <param name="id">the id</param>
        ///// <param name="imageName">the optional imagename</param>
        //public Realisation(string name, int id, string imageName = null)
        //{
        //    this.Name = name;
        //    this.Id = id;
        //    this.Competences = new List<Competence>();
        //    this._imageName = imageName;
        //}

        /// <summary>
        /// Private constructor, only use this to
        /// Initialize an instance of realisation with a 
        /// dbobject.
        /// </summary>
        /// <param name="dbId"></param>
        private Realisation(Database.Realisation dbObject)
        {
            this.Id = dbObject.Id;
            this._imageName = dbObject.LogoName;
            this.Description = dbObject.Description;
            this.Name = dbObject.Name;

            this.CompetenceIds = new List<int>();

            foreach (var dbCompetence in dbObject.Competences)
            {
                this.CompetenceIds.Add(dbCompetence.Id);
            }
        }

        #endregion

        #region static methods

        /// <summary>
        /// Get an instance of a realisation from database
        /// </summary>
        /// <param name="dbId">The object's database id</param>
        /// <returns>The realisation or null if it doesn't exist</returns>
        public static Realisation GetInstance(int dbId)
        {
            using (var db = new SMPortfolioEntities())
            {
                var dbObject = db.Realisations.SingleOrDefault(r => r.Id == dbId);
                if (dbObject != null)
                {
                    return new Realisation(dbObject);
                }
                return null;
            }
        }

         /// <summary>
         /// Get multiple instances of Realisation
         /// </summary>
         /// <param name="dbIds">List of database object ids</param>
         /// <returns>The Enumerable of realisations</returns>
        public static IEnumerable<Realisation> GetInstances (IEnumerable<int> dbIds)
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
        public static IEnumerable<Realisation> GetAllInstances()
        {
            List<int> ids;

            using (var db = new SMPortfolioEntities())
            {
                ids = db.Realisations.Select(r => r.Id).ToList();
            }

            return GetInstances(ids);
        }

        #endregion
    }
}