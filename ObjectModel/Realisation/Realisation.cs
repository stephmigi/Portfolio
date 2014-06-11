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
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public RealisationType Type { get; set; }

        public List<Competence> Competences { get; set; }

        #endregion

        #region constructors  

        /// <summary>
        /// Initialize a new instance of Realisation
        /// </summary>
        /// <param name="name">the name</param>
        /// <param name="id">the id</param>
        /// <param name="imageName">the optional imagename</param>
        public Realisation(string name, int id, string imageName = null)
        {
            this.Name = name;
            this.Id = id;
            this.Competences = new List<Competence>();
            this._imageName = imageName;
        }

        /// <summary>
        /// Private constructor, only use this to
        /// Initialize an instance of realisation with a 
        /// dbobject id.
        /// </summary>
        /// <param name="dbId"></param>
        private Realisation(int dbId)
        {
            using (var db = new SMPortfolioEntities())
            {
                var dbObject = db.Realisations.First(r => r.Id == dbId);

                this.Id = dbObject.Id;
                this._imageName = dbObject.LogoName;
                this.Description = dbObject.Description;
                this.Name = dbObject.Name;
            }
        }

        #endregion

        #region public methods
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

        #endregion

        #region static

        /// <summary>
        /// Get an instance of a realisation from database
        /// </summary>
        /// <param name="dbId">The object's database id</param>
        /// <returns>The realisation</returns>
        public static Realisation GetInstance(int dbId)
        {
            return new Realisation(dbId);
        }

         /// <summary>
         /// Get multiple instances of Realisation
         /// </summary>
         /// <param name="dbIds">List of database object ids</param>
         /// <returns>The list of realisations</returns>
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
                ids = db.Realisations.Select(r => r.Id).ToList(); ;
            }

            return GetInstances(ids);
        }

        #endregion
    }
}