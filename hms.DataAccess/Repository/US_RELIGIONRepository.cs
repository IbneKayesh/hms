using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_RELIGIONRepository : Repository<US_RELIGION>, IUS_RELIGIONRepository
    {
        private readonly hmsDbContext _db;
        public US_RELIGIONRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_RELIGION obj)
        {
            var dBobj = _db.US_RELIGION.FirstOrDefault(x => x.ID == obj.ID);
            if (dBobj != null)
            {
                dBobj.RELIGION_NAME = obj.RELIGION_NAME;
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
    }
}
