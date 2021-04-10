using hms.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class ModelSql<T> : IModelSql<T>, IDisposable where T : class
    {
        private readonly hmsDbContext db;
        internal DbSet<T> dbSet;
        public ModelSql(hmsDbContext _db)
        {
            this.db = _db;
            this.dbSet = _db.Set<T>();
        }
        public void Dispose()
        {
            if (db != null)
                db.Dispose();
        }
        public IEnumerable<T> ExecuteSqlQuery(string query, object[] parameters = null)
        {
            if(parameters == null)
            {
                return dbSet.FromSqlRaw<T>(query);
            }
            else
            {
                return dbSet.FromSqlRaw<T>(query, parameters);
            }
        }
    }
}
