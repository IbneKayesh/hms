using hms.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IHS_DOCTORRepository : IRepository<HS_DOCTOR>
    {
        void Update(HS_DOCTOR objData);
        bool Delete(int id);
    }
}
