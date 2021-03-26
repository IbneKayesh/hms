using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUS_MARITAIL_STATUSRepository : IRepository<US_MARITAIL_STATUS>
    {
        void Update(US_MARITAIL_STATUS objData);
    }
}
