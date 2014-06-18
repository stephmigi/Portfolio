﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjectModel.Extensions;
using ObjectModel.Database;

namespace ObjectModel.Realisations
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
                return Description.EllipseString(200);
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

        #endregion

        #region constructors  

        public Realisation() { }

        /// <summary>
        /// Private constructor, only use this to
        /// Initialize an instance of realisation with a 
        /// dbobject.
        /// </summary>
        /// <param name="dbId"></param>
        public Realisation(Database.Realisation dbObject)
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
    }
}