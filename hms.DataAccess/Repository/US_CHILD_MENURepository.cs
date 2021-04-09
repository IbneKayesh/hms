using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_CHILD_MENURepository : Repository<US_CHILD_MENU>, IUS_CHILD_MENURepository
    {
        private readonly hmsDbContext _db;
        public US_CHILD_MENURepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_CHILD_MENU obj)
        {
            var dBobj = _db.US_CHILD_MENU.FirstOrDefault(x => x.ID == obj.ID);
            if (dBobj != null)
            {
                dBobj.CHILD_NAME = obj.CHILD_NAME;
                dBobj.CHILD_BN_NAME = obj.CHILD_BN_NAME;
                dBobj.CHILD_ICON = obj.CHILD_ICON;
                dBobj.AREA_NAME = obj.AREA_NAME;
                dBobj.CONTROLLER_NAME = obj.CONTROLLER_NAME;
                dBobj.ACTION_NAME = obj.ACTION_NAME;
                dBobj.MODULE_ID = obj.MODULE_ID;
                dBobj.PARENT_MENU_ID = obj.PARENT_MENU_ID;
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
        public bool Delete(int id)
        {
            var dBobj = _db.US_CHILD_MENU.Find(id);
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
