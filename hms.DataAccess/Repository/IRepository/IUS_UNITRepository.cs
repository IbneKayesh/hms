using hms.DataModel;
using System;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUS_UNITRepository : IRepository<US_UNIT>
    {
        void Update(US_UNIT objData);
        bool Delete(int id);
    }
}
