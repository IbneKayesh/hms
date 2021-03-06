using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HS_HOSPITALRepository : Repository<HS_HOSPITAL>, IHS_HOSPITALRepository
    {
        private readonly hmsDbContext _db;
        public HS_HOSPITALRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HS_HOSPITAL obj)
        {
            var dBobj = _db.HS_HOSPITAL.FirstOrDefault(x => x.ID == obj.ID);
            if (dBobj != null)
            {
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
    }
}
