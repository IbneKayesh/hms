using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HS_DEPARTMENTRepository : Repository<HS_DEPARTMENT>, IHS_DEPARTMENTRepository
    {
        private readonly hmsDbContext _db;
        public HS_DEPARTMENTRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HS_DEPARTMENT obj)
        {
            var dBobj = _db.HS_DEPARTMENT.FirstOrDefault(x => x.ID == obj.ID);
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
            var dBobj = _db.HS_DEPARTMENT.Find(id);
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
