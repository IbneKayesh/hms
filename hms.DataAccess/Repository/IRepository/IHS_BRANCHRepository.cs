using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHS_BRANCHRepository : IRepository<HS_BRANCH>
    {
        void Update(HS_BRANCH objData);
        bool Delete(int id);
    }
}
