using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUS_BLOOD_GROUPRepository : IRepository<US_BLOOD_GROUP>
    {
        void Update(US_BLOOD_GROUP objData);
    }
}
