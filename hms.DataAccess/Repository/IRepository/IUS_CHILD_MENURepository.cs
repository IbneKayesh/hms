using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUS_CHILD_MENURepository : IRepository<US_CHILD_MENU>
    {
        void Update(US_CHILD_MENU objData);
    }
}
