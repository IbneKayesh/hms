using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_USER_ROLERepository : Repository<US_USER_ROLE>, IUS_USER_ROLERepository
    {
        private readonly hmsDbContext _db;
        public US_USER_ROLERepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_USER_ROLE obj)
        {
            var dBobj = _db.US_USER_ROLE.FirstOrDefault(x => x.ROLE_ID == obj.ROLE_ID && x.USER_ID == obj.USER_ID);
            if (dBobj != null)
            {
                dBobj.ROLE_ID = obj.ROLE_ID;
                dBobj.USER_ID = obj.USER_ID;
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
        public bool Delete(int id, int id1)
        {
            var dBobj = _db.US_USER_ROLE.Find(id, id1);
            if (dBobj != null)
            {
                dBobj.IS_ACTIVE = false;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
                return true;
            }
            return false;
        }
    }
}
