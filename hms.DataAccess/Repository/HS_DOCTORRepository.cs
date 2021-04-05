using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HS_DOCTORRepository : Repository<HS_DOCTOR>, IHS_DOCTORRepository
    {
        private readonly hmsDbContext _db;
        public HS_DOCTORRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HS_DOCTOR obj)
        {
            var dBobj = _db.HS_DOCTOR.FirstOrDefault(x => x.ID == obj.ID);
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
            var dBobj = _db.HS_DOCTOR.Find(id);
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
