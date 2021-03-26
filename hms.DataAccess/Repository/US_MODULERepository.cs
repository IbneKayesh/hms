using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_MODULERepository : Repository<US_MODULE>, IUS_MODULERepository
    {
        private readonly hmsDbContext _db;
        public US_MODULERepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_MODULE obj)
        {
            var dBobj = _db.US_MODULE.FirstOrDefault(x => x.ID == obj.ID);
            if (dBobj != null)
            {
                dBobj.MODULE_NAME = obj.MODULE_NAME;
                dBobj.MODULE_BN_NAME = obj.MODULE_BN_NAME;
                dBobj.MODULE_ICON = obj.MODULE_ICON;
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
    }
}
