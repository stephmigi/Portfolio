using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel.Realisations
{
    public interface IRealisationRepository
    {
        Realisation GetById(int id);
        IEnumerable<Realisation> GetByIds(List<int> ids);
        IEnumerable<Realisation> GetAll();
        void Dispose();
    }
}
