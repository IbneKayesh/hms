using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HP_SUGGESSIONRepository : Repository<HP_SUGGESSION>, IHP_SUGGESSIONRepository
    {
        private readonly hmsDbContext _db;
        public HP_SUGGESSIONRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HP_SUGGESSION obj)
        {
            var dBobj = _db.HP_SUGGESSION.FirstOrDefault(x => x.SUGGESTION_NAME == obj.SUGGESTION_NAME);
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
