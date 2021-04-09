using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HS_EMPLOYEE_TYPERepository : Repository<HS_EMPLOYEE_TYPE>, IHS_EMPLOYEE_TYPERepository
    {
        private readonly hmsDbContext _db;
        public HS_EMPLOYEE_TYPERepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HS_EMPLOYEE_TYPE obj)
        {
            var dBobj = _db.HS_EMPLOYEE_TYPE.FirstOrDefault(x => x.ID == obj.ID);
            if (dBobj != null)
            {
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
        public bool Delete(int id)
        {
            var dBobj = _db.HS_EMPLOYEE_TYPE.Find(id);
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
