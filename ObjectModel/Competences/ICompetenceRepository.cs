using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel.Competences
{
    public interface ICompetenceRepository
    {
        Competence GetById(int id);
        IEnumerable<Competence> GetByIds(List<int> ids);
        IEnumerable<Competence> GetAll();
        void Dispose();
    }
}
