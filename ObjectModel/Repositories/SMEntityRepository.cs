using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjectModel.Database;

namespace ObjectModel.Repositories
{
    /// <summary>
    /// Implementation of IEntityRepository for SMPortfolioEntities
    /// This implementation strongly depends on each business model having a 
    /// constructor such as T(TEntity entity) (could maybe be replaced with something like automapper)
    /// This class is dependent on a DbContext.
    /// </summary>
    /// <typeparam name="TEntity">EF generated class</typeparam>
    /// <typeparam name="T">Corresponding business model class</typeparam>
    public class SMEntityRepository<TEntity, T> :  IEntityRepository<TEntity, T>
        where T : class, new()
        where TEntity : class, new()
    {
        private readonly DbContext _context;

        public SMEntityRepository(DbContext context)
        {
            this._context = context;
        }

        #region public

        /// <summary>
        /// Returns an instance of T by id
        /// </summary>
        /// <param name="id">The id to look for</param>
        /// <returns>The corresponding entity</returns>
        public T GetById(int id)
        {
            TEntity dbObject = _context.Set<TEntity>().Find(id);
            if (dbObject == null)
                return null;
            return this.CopyFromDbObject(dbObject);
        }

        /// <summary>
        /// Returns instances of every object of type T
        /// </summary>
        /// <returns>A list of all T</returns>
        public IEnumerable<T> GetAll()
        {
            var allEntities = _context.Set<TEntity>();
            foreach (TEntity entity in allEntities)
            {
                yield return CopyFromDbObject(entity);
            }
        }

        #endregion

        #region private

        /// <summary>
        /// Initializes a new instance of T based on the 
        /// linked TEntity instance.
        /// </summary>
        /// <param name="dbObject">TEntity object</param>
        /// <returns>T instance</returns>
        private T CopyFromDbObject(TEntity dbObject)
        {
            if (this.HasValidTEntityToTCtor(typeof(T), typeof(TEntity)) == false)
                throw new InvalidOperationException("Type T has to have a constructor of signature : public T(Tentity entity)");

            var newInstance = Activator.CreateInstance(typeof(T), new object[] { dbObject as TEntity }) as T;
            return newInstance;
        }

        /// <summary>
        /// Checks if type T has a constructor of signature : public T(TEntity entity)
        /// </summary>
        /// <param name="typeOfT">Type of T</param>
        /// <param name="typeOfTEntity">Type of TEntity</param>
        /// <returns>True if valid ctor is found</returns>
        private bool HasValidTEntityToTCtor(Type typeOfT, Type typeOfTEntity)
        {
            bool hasValid = false;

            var constructors = typeOfT.GetConstructors();
            foreach (var ctor in constructors)
            {
                foreach (var param in ctor.GetParameters())
                {
                    if (param.ParameterType == typeOfTEntity && ctor.GetParameters().Count() == 1)
                        hasValid = true;
                }
            }
            return hasValid;
        }

        #endregion

        #region IDisposable
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

        #endregion
    }
}
