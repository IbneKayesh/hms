using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HP_PRESCRIPTIONRepository : Repository<HP_PRESCRIPTION>, IHP_PRESCRIPTIONRepository
    {
        private readonly hmsDbContext _db;
        public HP_PRESCRIPTIONRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HP_PRESCRIPTION obj)
        {
            var dBobj = _db.HP_PRESCRIPTION.FirstOrDefault(x => x.PRESCRIPTION_NUMBER == obj.PRESCRIPTION_NUMBER);
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
