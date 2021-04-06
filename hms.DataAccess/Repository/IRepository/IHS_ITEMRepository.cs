using hms.DataModel;
using System;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHS_ITEMRepository : IRepository<HS_ITEM>
    {
        void Update(HS_ITEM objData);
        bool Delete(Int64 id);
    }
}
