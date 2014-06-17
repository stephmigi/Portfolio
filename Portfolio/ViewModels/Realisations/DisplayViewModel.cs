﻿using ObjectModel;
using ObjectModel.Realisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.ViewModels.Realisations
{
    public class DisplayViewModel
    {
        public int RealisationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public IEnumerable<Competence> LinkedCompetences { get; set; }

        public DisplayViewModel() { }

        public DisplayViewModel(Realisation instance)
        {
            this.RealisationId = instance.Id;
            this.Name = instance.Name;
            this.Description = instance.Description;
            this.ImageName = instance.ImageName;

            LinkedCompetences = new List<Competence>();
        }
    }
}