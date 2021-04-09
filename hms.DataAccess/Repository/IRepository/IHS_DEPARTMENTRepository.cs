using hms.DataModel;
using System;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHS_DEPARTMENTRepository : IRepository<HS_DEPARTMENT>
    {
        void Update(HS_DEPARTMENT objData);
        bool Delete(int id);
    }
}
