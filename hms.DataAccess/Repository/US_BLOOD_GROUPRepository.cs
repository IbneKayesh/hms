using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_BLOOD_GROUPRepository : Repository<US_BLOOD_GROUP>, IUS_BLOOD_GROUPRepository
    {
        private readonly hmsDbContext _db;
        public US_BLOOD_GROUPRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_BLOOD_GROUP obj)
        {
            var dBobj = _db.US_BLOOD_GROUP.FirstOrDefault(x => x.ID == obj.ID);
            if (dBobj != null)
            {
                dBobj.BLOOD_GROUP_NAME = obj.BLOOD_GROUP_NAME;
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
    }
}
