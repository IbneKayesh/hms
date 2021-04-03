using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHP_FREQUENCYRepository : IRepository<HP_FREQUENCY>
    {
        void Update(HP_FREQUENCY objData);

    }
}
