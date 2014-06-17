using ObjectModel.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class StandardRepository<TEntity, T> 
        where T : class, new()
        where TEntity : class, new()
    {
        private readonly DbContext context;

        public StandardRepository(DbContext context)
        {
            this.context = context;
        }

        public T GetById(int id)
        {
            TEntity dbObject = context.Set<TEntity>().Find(id);
            return this.CopyFromDbObject(dbObject);
        }

        public IEnumerable<T> GetAll()
        {
            var allEntities = context.Set<TEntity>();
            foreach (TEntity entity in allEntities)
            {
                yield return CopyFromDbObject(entity);
            }
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

        private T CopyFromDbObject(TEntity dbObject)
        {
            var newInstance = Activator.CreateInstance(typeof(T), new object[] { dbObject }) as T;
            return newInstance;
        }
    }
}
