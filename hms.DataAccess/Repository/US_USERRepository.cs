using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class US_USERRepository : Repository<US_USER>, IUS_USERRepository
    {
        private readonly hmsDbContext _db;
        public US_USERRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(US_USER user)
        {
            var dBobj = _db.US_USER.FirstOrDefault(x => x.ID == user.ID);
            if (dBobj != null)
            {
                dBobj.PASSWORD = user.PASSWORD;
                dBobj.EMAIL_ID = user.EMAIL_ID;
            }
        }
    }
}
