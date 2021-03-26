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
            US_USER = new US_USERRepository(_db);
            US_BLOOD_GROUP = new US_BLOOD_GROUPRepository(_db);
        }
        public IUS_USERRepository US_USER { get; private set; }
        public IUS_BLOOD_GROUPRepository US_BLOOD_GROUP { get; private set; }
        public IUS_CHILD_MENURepository US_CHILD_MENU { get; private set; }
        public IUS_GENDERRepository US_GENDER { get; private set; }
        public IUS_MARITAIL_STATUSRepository US_MARITAIL_STATUS { get; private set; }
        public IUS_MODULERepository US_MODULE { get; private set; }
        public IUS_PARENT_MENURepository US_PARENT_MENU { get; private set; }
        public IUS_RELIGIONRepository US_RELIGION { get; private set; }
        public IUS_ROLERepository US_ROLE { get; private set; }
        public IUS_TYPERepository US_TYPE { get; private set; }








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
