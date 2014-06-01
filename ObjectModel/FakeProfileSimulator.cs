using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public static class FakeProfileSimulator
    {
        public static FakeProfile GetAFakeProfile()
        {
            var c1 = new Competence("C#", 1);
            c1.Type = CompetenceType.TechnicalProject;
            var c2 = new Competence("Git et SVN", 2);
            c2.Type = CompetenceType.TechnicalProject;
            var c3 = new Competence("Bases de données / SQL", 3);
            c3.Type = CompetenceType.TechnicalProject;
            var c4 = new Competence("PHP", 4);
            c4.Type = CompetenceType.TechnicalProject;
            var c5 = new Competence("Orchard", 5);
            c5.Type = CompetenceType.TechnicalProject;

            var r1 = new Realisation("TiDoi", 1);
            r1.Description = @"Tidoi est un projet innovant et ayant un objectif bien réel. C'est un site web qui permet
            de comparer les bons plans concernant les activités tels que la restauration où les bars.
            Réalisé sur deux semestres, cela a été une vraie opportunité pour nous de démontrer notre savoir-faire et nos compétences que ce soit sur le plan technique ou humain.
            Ayant été chef de projet lors du premier semestre, j'ai pu me rendre compte des difficultés de la gestion d'une équipe ainsi que d'une vraie relation client.";
            r1.Type = RealisationType.Technical;
            
            var r2 = new Realisation("BlogOn", 2);
            r2.Type = RealisationType.Technical;

            var r3 = new Realisation("MKS", 3);
            r3.Type = RealisationType.Technical;

            c1.AddRealisations(new List<Realisation>{ r1, r3 });
            c2.AddRealisations(new List<Realisation> { r1, r2, r3 });
            c3.AddRealisations(new List<Realisation> { r1, r2, r3 });
            c4.AddRealisations(new List<Realisation> { r2 });
            c5.AddRealisations(new List<Realisation> { r1 });

            r1.AddCompetences(new List<Competence> { c1, c2, c3, c5});
            r2.AddCompetences(new List<Competence> { c2, c3, c4 });
            r3.AddCompetences(new List<Competence> { c1, c2, c3 });

            var competences = new List<Competence>();
            competences.Add(c1);
            competences.Add(c2);
            competences.Add(c3);
            competences.Add(c4);
            competences.Add(c5);

            var realisations = new List<Realisation>();
            realisations.Add(r1);
            realisations.Add(r2);
            realisations.Add(r3);

            return new FakeProfile(competences, realisations);
        }
    }

    public class FakeProfile
    {
        public List<Competence> Competences { get; set; }
        public List<Realisation> Realisations { get; set; }

        public FakeProfile(List<Competence> c, List<Realisation> r)
        {
            this.Competences = c;
            this.Realisations = r;
        }

        public Competence GetACompetence(int id)
        {
            return Competences.Where(c => c.Id == id).First();
        }

        public Realisation GetARealisation(int id)
        {
            return Realisations.Where(c => c.Id == id).First();
        }
    }
}
