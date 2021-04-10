using hms.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;

namespace hms.DataAccess.Repository
{
    public class RawSql : IRawSql, IDisposable
    {
        private readonly hmsDbContext _db;
        public RawSql(hmsDbContext db)
        {
            _db = db;
        }

        public void ExecuteSqlCommand(string query, object[] parameters = null)
        {
            _db.Database.ExecuteSqlRaw(query, parameters);
        }

        public void Dispose()
        {
            if (_db != null)
                _db.Dispose();
        }
    }
}
