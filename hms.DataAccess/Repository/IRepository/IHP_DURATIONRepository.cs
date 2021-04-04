using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHP_DURATIONRepository : IRepository<HP_DURATION>
    {
        void Update(HP_DURATION objData);

    }
}
