using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_PARENT_MENURepository : Repository<US_PARENT_MENU>, IUS_PARENT_MENURepository
    {
        private readonly hmsDbContext _db;
        public US_PARENT_MENURepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_PARENT_MENU obj)
        {
            var dBobj = _db.US_PARENT_MENU.FirstOrDefault(x => x.ID == obj.ID);
            if (dBobj != null)
            {
                dBobj.PARENT_NAME = obj.PARENT_NAME;
                dBobj.PARENT_BN_NAME = obj.PARENT_BN_NAME;
                dBobj.PARENT_ICON = obj.PARENT_ICON;
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
        public bool Delete(int id)
        {
            var dBobj = _db.US_PARENT_MENU.Find(id);
            if (dBobj != null)
            {
                dBobj.IS_ACTIVE = false;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
                return true;
            }
            return false;
        }
    }
}
