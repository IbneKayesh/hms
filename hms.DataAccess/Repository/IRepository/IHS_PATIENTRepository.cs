using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHS_PATIENTRepository : IRepository<HS_PATIENT>
    {
        void Update(HS_PATIENT objData);
        bool Delete(Int64 id);
    }
}
