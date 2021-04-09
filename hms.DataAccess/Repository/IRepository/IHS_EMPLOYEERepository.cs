using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHS_EMPLOYEERepository : IRepository<HS_EMPLOYEE>
    {
        void Update(HS_EMPLOYEE objData);
        bool Delete(int id);
    }
}
