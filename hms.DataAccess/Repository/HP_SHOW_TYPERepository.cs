using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HP_SHOW_TYPERepository : Repository<HP_SHOW_TYPE>, IHP_SHOW_TYPERepository
    {
        private readonly hmsDbContext _db;
        public HP_SHOW_TYPERepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HP_SHOW_TYPE obj)
        {
            var dBobj = _db.HP_SHOW_TYPE.FirstOrDefault(x => x.ID == obj.ID);
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
