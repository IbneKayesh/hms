using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HP_FREQUENCYRepository : Repository<HP_FREQUENCY>, IHP_FREQUENCYRepository
    {
        private readonly hmsDbContext _db;
        public HP_FREQUENCYRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HP_FREQUENCY obj)
        {
            var dBobj = _db.HP_FREQUENCY.FirstOrDefault(x => x.FREQUENCY_NAME == obj.FREQUENCY_NAME);
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
