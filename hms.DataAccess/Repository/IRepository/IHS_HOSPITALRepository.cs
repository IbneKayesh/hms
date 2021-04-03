using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHS_HOSPITALRepository : IRepository<HS_HOSPITAL>
    {
        void Update(HS_HOSPITAL objData);
    }
}
