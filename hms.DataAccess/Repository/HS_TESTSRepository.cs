using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using System.Linq;

namespace hms.DataAccess.Repository
{
    public class HS_TESTSRepository : Repository<HS_TESTS>, IHS_TESTSRepository
    {
        private readonly hmsDbContext _db;
        public HS_TESTSRepository(hmsDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HS_TESTS obj)
        {
            var dBobj = _db.HS_TESTS.FirstOrDefault(x => x.ID == obj.ID);
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
