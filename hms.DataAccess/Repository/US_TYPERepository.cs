using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_TYPERepository : Repository<US_TYPE>, IUS_TYPERepository
    {
        private readonly hmsDbContext _db;
        public US_TYPERepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_TYPE obj)
        {
            var dBobj = _db.US_TYPE.FirstOrDefault(x => x.ID == obj.ID);
            if (dBobj != null)
            {
                dBobj.TYPE_NAME = obj.TYPE_NAME;
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
    }
}
