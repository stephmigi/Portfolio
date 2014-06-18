using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel.Repositories
{
    /// <summary>
    /// Generic interface representing an EF Repository.
    /// The main goal here is to be able to hide to the outside world
    /// anything related to TEntity type and to just deal with T objects.
    /// Therefore, we are assuming that every TEntity type has a corresponding T type.
    /// </summary>
    /// <typeparam name="TEntity">TEntity is the type of the EF generated classes.</typeparam>
    /// <typeparam name="T">T is the corresponding business logic type</typeparam>
    public interface IEntityRepository<TEntity, T>
    {
        /// <summary>
        /// Returns an element of type T by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Get all elements of type T
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
    }
}
