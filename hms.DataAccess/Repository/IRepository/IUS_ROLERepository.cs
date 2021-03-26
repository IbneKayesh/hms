using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUS_ROLERepository : IRepository<US_ROLE>
    {
        void Update(US_ROLE objData);
    }
}
