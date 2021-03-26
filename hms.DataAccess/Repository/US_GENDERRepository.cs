using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_GENDERRepository : Repository<US_GENDER>, IUS_GENDERRepository
    {
        private readonly hmsDbContext _db;
        public US_GENDERRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_GENDER obj)
        {
            var dBobj = _db.US_GENDER.FirstOrDefault(x => x.ID == obj.ID);
            if (dBobj != null)
            {
                dBobj.GENDER_NAME = obj.GENDER_NAME;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
    }
}
