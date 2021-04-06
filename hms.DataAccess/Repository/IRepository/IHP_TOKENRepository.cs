using hms.DataModel;
using System;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHP_TOKENRepository : IRepository<HP_TOKEN>
    {
        void Update(HP_TOKEN objData);
        bool Delete(Int64 id);
    }
}
