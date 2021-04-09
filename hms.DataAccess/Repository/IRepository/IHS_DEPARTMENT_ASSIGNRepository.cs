using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHS_DEPARTMENT_ASSIGNRepository : IRepository<HS_DEPARTMENT_ASSIGN>
    {
        void Update(HS_DEPARTMENT_ASSIGN objData);
        bool Delete(int id);
    }
}
