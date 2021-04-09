using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HS_DEPARTMENT_ASSIGNRepository : Repository<HS_DEPARTMENT_ASSIGN>, IHS_DEPARTMENT_ASSIGNRepository
    {
        private readonly hmsDbContext _db;
        public HS_DEPARTMENT_ASSIGNRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HS_DEPARTMENT_ASSIGN obj)
        {
            var dBobj = _db.HS_DEPARTMENT_ASSIGN.FirstOrDefault(x => x.ID == obj.ID);
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
            var dBobj = _db.HS_DEPARTMENT_ASSIGN.Find(id);
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
