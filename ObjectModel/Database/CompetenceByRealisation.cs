//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObjectModel.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompetenceByRealisation
    {
        public int Id { get; set; }
        public int CompetenceId { get; set; }
        public int RealisationId { get; set; }
    
        public virtual Competence Competence { get; set; }
        public virtual Realisation Realisation { get; set; }
    }
}
