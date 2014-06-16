using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectModel.Realisations;
using ObjectModel.Competences;

namespace ObjectModel
{
    public class RealisationAndCompetenceService
    {
        private IRealisationRepository _realisationRepository;
        private ICompetenceRepository _competenceRepository;

        public RealisationAndCompetenceService(IRealisationRepository realRepo, ICompetenceRepository compRepo)
        {
            _realisationRepository = realRepo;
            _competenceRepository = compRepo;
        }

        public IEnumerable<Realisation> GetAllRealisations()
        {
            return _realisationRepository.GetAll();
        }

        public Realisation GetRealisationById(int id)
        {
            return _realisationRepository.GetById(id);
        }

        public IEnumerable<Competence> GetLinkedCompetences(int realisationId)
        {
            var realisation = _realisationRepository.GetById(realisationId);
            return _competenceRepository.GetByIds(realisation.CompetenceIds);
        }

        public IEnumerable<Realisation> GetLinkedRealisations(int competenceId)
        {
            var competence = _competenceRepository.GetById(competenceId);
            return _realisationRepository.GetByIds(competence.RealisationIds);
        }
    }
}
