//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObjectModel
//{
//    public static class FakeProfileSimulator
//    {
//        public static FakeProfile GetAFakeProfile()
//        {
//            var c1 = new Competence("C#", 1);
//            c1.Type = CompetenceType.TechnicalProject;
//            var c2 = new Competence("Git et SVN", 2);
//            c2.Type = CompetenceType.TechnicalProject;
//            var c3 = new Competence("Bases de données / SQL", 3);
//            c3.Type = CompetenceType.TechnicalProject;
//            var c4 = new Competence("PHP", 4);
//            c4.Type = CompetenceType.TechnicalProject;
//            var c5 = new Competence("Orchard", 5);
//            c5.Type = CompetenceType.TechnicalProject;

//            var r1 = new Realisation("TiDoi", 1, "TiDoi.png");
//            r1.Description = @"Tidoi est un projet innovant et ayant un objectif bien réel. C'est un site web qui permet
//            de comparer les bons plans concernant les activités tels que la restauration où les bars.
//            Réalisé sur deux semestres, cela a été une vraie opportunité pour nous de démontrer notre savoir-faire et nos compétences que ce soit sur le plan technique ou humain.
//            Ayant été chef de projet lors du premier semestre, j'ai pu me rendre compte des difficultés de la gestion d'une équipe ainsi que d'une vraie relation client.";
//            r1.Type = RealisationType.Technical;

//            var r2 = new Realisation("BlogOn", 2, "blogon.png");
//            r2.Description = @"Blog'On est un générateur de blogs. Il permet de créer et d'administrer son propre blog de manière autonome. Il est possible de 
//            créer des utilisateurs/administrateurs, de leur donner des droits, créer des articles ,changer le style du blog, et bien d'autres choses.";
//            r2.Type = RealisationType.Technical;

//            var r3 = new Realisation("MKS", 3, "LogoMKS.png");
//            r3.Description = @"Notre mission pour le semestre a été d'ajouter un module à une solution existante, MKS. Ce dernier a pour but de faciliter la gestion
//            d'IntechInfo. Notre module avait pour objectif de concevoir et développer un outil permettant, à l'équipe pédagogique et administrative du groupe 
//            ESIEA, d'alimenter et de gérer les catalogues de cours d'IN'TECH INFO et de l'ESIEA.";
//            r3.Type = RealisationType.Technical;

//            var r4 = new Realisation("Web Academy", 4, "webacademy.png");
//            r4.Description = @"Pour ce projet de semestre 3, notre objectif a été de former les étudiants de 1er semestre d'INTECH INFO au HTML et au CSS.
//            Le défi était de taille puisque leur apprentissage de ces technologies dépendait uniquement de nous. Nous leur avons donc dispensé quatre cours de 2h,
//            alliant parties théoriques (à l'aide de présentations PowerPoint) et pratiques (TP sur leur poste). Pour les TPs, l'objectif était de réaliser une galerie photo qui évoluait au fil des cours. A l'aide de ce
//            projet 'fil rouge', les étudiants se rendaient mieux compte de leur propre évolution.";
//            r4.Type = RealisationType.Human;

//            c1.AddRealisations(new List<Realisation>{ r1, r3 });
//            c2.AddRealisations(new List<Realisation> { r1, r2, r3 });
//            c3.AddRealisations(new List<Realisation> { r1, r2, r3 });
//            c4.AddRealisations(new List<Realisation> { r2 });
//            c5.AddRealisations(new List<Realisation> { r1 });

//            r1.AddCompetences(new List<Competence> { c1, c2, c3, c5});
//            r2.AddCompetences(new List<Competence> { c2, c3, c4 });
//            r3.AddCompetences(new List<Competence> { c1, c2, c3 });

//            var competences = new List<Competence>();
//            competences.Add(c1);
//            competences.Add(c2);
//            competences.Add(c3);
//            competences.Add(c4);
//            competences.Add(c5);

//            var realisations = new List<Realisation>();
//            realisations.Add(r1);
//            realisations.Add(r2);
//            realisations.Add(r3);
//            realisations.Add(r4);

//            return new FakeProfile(competences, realisations);
//        }
//    }

//    public class FakeProfile
//    {
//        public List<Competence> Competences { get; set; }
//        public List<Realisation> Realisations { get; set; }

//        public FakeProfile(List<Competence> c, List<Realisation> r)
//        {
//            this.Competences = c;
//            this.Realisations = r;
//        }

//        public Competence GetACompetence(int id)
//        {
//            return Competences.Where(c => c.Id == id).First();
//        }

//        public Realisation GetARealisation(int id)
//        {
//            return Realisations.Where(c => c.Id == id).First();
//        }
//    }
//}