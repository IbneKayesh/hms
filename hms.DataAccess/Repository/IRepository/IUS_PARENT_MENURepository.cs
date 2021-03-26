using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUS_PARENT_MENURepository : IRepository<US_PARENT_MENU>
    {
        void Update(US_PARENT_MENU objData);
    }
}
