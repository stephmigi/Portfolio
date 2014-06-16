using ObjectModel.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel.Competences
{
    public class CompetenceRepository : ICompetenceRepository
    {
        private readonly SMPortfolioEntities context;

        public CompetenceRepository(SMPortfolioEntities context)
        {
            this.context = context;
        }

        public Competence GetById(int id)
        {
            Database.Competence dbObject = context.Competences.Where(r => r.Id == id).First();
            return this.CopyFromDbObject(dbObject);
        }

        public IEnumerable<Competence> GetByIds(List<int> ids)
        {
            foreach (int id in ids)
            {
                yield return this.GetById(id);
            }
        }

        public IEnumerable<Competence> GetAll()
        {
            List<int> ids;
            ids = context.Competences.Select(r => r.Id).ToList();
            return GetByIds(ids);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private Competence CopyFromDbObject(Database.Competence dbObject)
        {
            return new Competence(dbObject);
        }
    }
}
