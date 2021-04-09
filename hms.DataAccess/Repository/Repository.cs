using hms.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly hmsDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(hmsDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entity)
        {
            dbSet.AddRange(entity);
        }

        public T Get(Int64 id)
        {
            return dbSet.Find(id);
        }

        //======================
        public T Gets(Int64 id)
        {
            return dbSet.Find(id);
        }
        //======================

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var inclprop in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(inclprop);
                }
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            return query.ToList();
        }

        public T GetFirstOrDefult(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var inclprop in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(inclprop);
                }
            }
            return query.FirstOrDefault();
        }

        public void Remove(int id)
        {
            T entity = dbSet.Find(id);
            Remove(entity);
        }
        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        //======================
        public void Removes(Int64 id)
        {
            T entity = dbSet.Find(id);
            Removes(entity);
        }
        public void Removes(T entity)
        {
            dbSet.Remove(entity);
        }
        //======================

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
        public void ExecuteSqlCommand(string _sql, params object[] _parameters)
        {
            _db.Database.ExecuteSqlRaw(sql: _sql, parameters: _parameters);
        }

    }
}
