using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHP_INVESTIGATIONRepository : IRepository<HP_INVESTIGATION>
    {
        void Update(HP_INVESTIGATION objData);

    }
}
