using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        T Get(Int64 id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        T GetFirstOrDefult(
           Expression<Func<T, bool>> filter = null,
           string includeProperties = null
           );

        void Add(T entity);
        void AddRange(IEnumerable<T> entity);

        void Remove(int id);
        void Remove(Int64 id);
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}
