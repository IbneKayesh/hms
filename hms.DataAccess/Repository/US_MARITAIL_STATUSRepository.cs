using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_MARITAIL_STATUSRepository : Repository<US_MARITAIL_STATUS>, IUS_MARITAIL_STATUSRepository
    {
        private readonly hmsDbContext _db;
        public US_MARITAIL_STATUSRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_MARITAIL_STATUS obj)
        {
            var dBobj = _db.US_MARITAIL_STATUS.FirstOrDefault(x => x.ID == obj.ID);
            if (dBobj != null)
            {
                dBobj.MARITAIL_STATUS_NAME = obj.MARITAIL_STATUS_NAME;
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
    }
}
