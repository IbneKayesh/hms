using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_ROLE_MENURepository : Repository<US_ROLE_MENU>, IUS_ROLE_MENURepository
    {
        private readonly hmsDbContext _db;
        public US_ROLE_MENURepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_ROLE_MENU obj)
        {
            var dBobj = _db.US_ROLE_MENU.FirstOrDefault(x => x.ROLE_ID == obj.ROLE_ID && x.CHILD_MENU_ID == obj.CHILD_MENU_ID);
            if (dBobj != null)
            {
                dBobj.ROLE_ID = obj.ROLE_ID;
                dBobj.CHILD_MENU_ID = obj.CHILD_MENU_ID;
                dBobj.IS_ACTIVE = obj.IS_ACTIVE;

                dBobj.UPDATE_BY = new DEFAULT().UPDATE_BY;
                dBobj.UPDATE_DATE = new DEFAULT().UPDATE_DATE;
                dBobj.UPDATE_DEVICE = new DEFAULT().UPDATE_DEVICE;
            }
        }
    }
}
