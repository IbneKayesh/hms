using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_USERRepository : Repository<US_USER>, IUS_USERRepository
    {
        private readonly hmsDbContext _db;
        public US_USERRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_USER obj)
        {
            var dBobj = _db.US_USER.FirstOrDefault(x => x.ID == obj.ID);
            if (dBobj != null)
            {
                if (!string.IsNullOrWhiteSpace(obj.PROFILE_IMAGE))
                {
                    dBobj.PROFILE_IMAGE = obj.PROFILE_IMAGE;
                }
                dBobj.PASSWORD = obj.PASSWORD;
                dBobj.EMAIL_ID = obj.EMAIL_ID;
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
        public bool Delete(int id)
        {
            var dBobj = _db.US_USER.Find(id);
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
