using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HP_DURATIONRepository : Repository<HP_DURATION>, IHP_DURATIONRepository
    {
        private readonly hmsDbContext _db;
        public HP_DURATIONRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HP_DURATION obj)
        {
            var dBobj = _db.HP_DURATION.FirstOrDefault(x => x.DURATION_NAME == obj.DURATION_NAME);
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
