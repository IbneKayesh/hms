using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUS_USER_ROLERepository : IRepository<US_USER_ROLE>
    {
        void Update(US_USER_ROLE objData);
        bool Delete(int id, int id1);
    }
}
