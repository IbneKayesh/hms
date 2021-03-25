using hms.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly hmsDbContext _db;
        public UnitOfWork(hmsDbContext db)
        {
            _db = db;
        }



        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
