using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HP_MEDICINERepository : Repository<HP_MEDICINE>, IHP_MEDICINERepository
    {
        private readonly hmsDbContext _db;
        public HP_MEDICINERepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HP_MEDICINE obj)
        {
            var dBobj = _db.HP_MEDICINE.FirstOrDefault(x => x.ID == obj.ID);
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
