using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHP_CHECKUPRepository : IRepository<HP_CHECKUP>
    {
        void Update(HP_CHECKUP objData);
    }
}
