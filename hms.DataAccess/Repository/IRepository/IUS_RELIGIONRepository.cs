using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUS_RELIGIONRepository : IRepository<US_RELIGION>
    {
        void Update(US_RELIGION objData);
    }
}
