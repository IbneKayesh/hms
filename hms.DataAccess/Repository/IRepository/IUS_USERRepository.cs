using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUS_USERRepository : IRepository<US_USER>
    {
        void Update(US_USER us_user);
    }
}
