using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectModel.Realisations;
using ObjectModel.Competences;

namespace ObjectModel
{
    /// <summary>
    /// Service class containing a realisation and a competence repo.
    /// Deals with querying the repositories in simple and complex ways.
    /// Dependent on two IEntityRepository<TEntity, T>
    /// </summary>
    public class RealisationAndCompetenceService
    {
        private IEntityRepository<Database.Realisation, Realisation> _realisationRepository;
        private IEntityRepository<Database.Competence, Competence> _competenceRepository;

        public RealisationAndCompetenceService(IEntityRepository<Database.Realisation, Realisation> realRepo, IEntityRepository<Database.Competence, Competence> compRepo)
        {
            _realisationRepository = realRepo;
            _competenceRepository = compRepo;
        }

        public IEnumerable<Realisation> GetAllRealisations()
        {
            return _realisationRepository.GetAll();
        }

        public IEnumerable<Competence> GetAllCompetences()
        {
            return _competenceRepository.GetAll();
        }

        public Competence GetCompetenceById(int id)
        {
            return _competenceRepository.GetById(id);
        }

        public Realisation GetRealisationById(int id)
        {
            return _realisationRepository.GetById(id);
        }

        /// <summary>
        /// Returns the competences linked to a realisation
        /// </summary>
        /// <param name="realisationId">The realisation's id</param>
        /// <returns>The linked competences</returns>
        public IEnumerable<Competence> GetLinkedCompetences(int realisationId)
        {
            var realisation = _realisationRepository.GetById(realisationId);
            foreach (var linked in realisation.CompetenceIds)
            {
                yield return GetCompetenceById(linked);
            }
        }

        /// <summary>
        /// Returns the realisations linked to a competence
        /// </summary>
        /// <param name="competenceId">The competence's id</param>
        /// <returns>The linked realisations</returns>
        public IEnumerable<Realisation> GetLinkedRealisations(int competenceId)
        {
            var competence = _competenceRepository.GetById(competenceId);
            foreach (var linked in competence.RealisationIds)
            {
                yield return GetRealisationById(linked);
            }
        }
    }
}
