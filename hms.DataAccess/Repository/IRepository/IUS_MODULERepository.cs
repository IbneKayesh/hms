using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUS_MODULERepository : IRepository<US_MODULE>
    {
        void Update(US_MODULE objData);
        bool Delete(int id);
    }
}
