using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHS_TESTSRepository : IRepository<HS_TESTS>
    {
        void Update(HS_TESTS objData);
    }
}
