using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUS_TYPERepository : IRepository<US_TYPE>
    {
        void Update(US_TYPE objData);
    }
}
