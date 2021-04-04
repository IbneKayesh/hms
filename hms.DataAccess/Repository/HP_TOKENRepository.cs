using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HP_TOKENRepository : Repository<HP_TOKEN>, IHP_TOKENRepository
    {
        private readonly hmsDbContext _db;
        public HP_TOKENRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HP_TOKEN obj)
        {
            var dBobj = _db.HP_TOKEN.FirstOrDefault(x => x.ID == obj.ID);
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
