using ObjectModel.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel.Realisations
{
    public class RealisationRepository : IRealisationRepository
    {
        private readonly SMPortfolioEntities _context;

        public RealisationRepository(SMPortfolioEntities context)
        {
            this._context = context;
        }

        public Realisation GetById(int id)
        {
            Database.Realisation dbObject = _context.Realisations.Where(r => r.Id == id).First();
            return this.CopyFromDbObject(dbObject);
        }

        public IEnumerable<Realisation> GetByIds(List<int> ids)
        {
            foreach (int id in ids)
            {
                yield return this.GetById(id);
            }
        }

        public IEnumerable<Realisation> GetAll()
        {
            List<int> ids;
            ids = _context.Realisations.Select(r => r.Id).ToList();
            return GetByIds(ids);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private Realisation CopyFromDbObject(Database.Realisation dbObject)
        {
            return new Realisation(dbObject);
        }
    }
}
