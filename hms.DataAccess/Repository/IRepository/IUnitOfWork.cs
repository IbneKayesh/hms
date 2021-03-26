using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUS_USERRepository US_USER { get; }
        IUS_BLOOD_GROUPRepository US_BLOOD_GROUP { get; }
        IUS_CHILD_MENURepository US_CHILD_MENU { get; }
        IUS_GENDERRepository US_GENDER { get; }
        IUS_MARITAIL_STATUSRepository US_MARITAIL_STATUS { get; }
        IUS_MODULERepository US_MODULE { get; }
        IUS_PARENT_MENURepository US_PARENT_MENU { get; }
        IUS_RELIGIONRepository US_RELIGION { get; }
        IUS_ROLERepository US_ROLE { get; }
        IUS_TYPERepository US_TYPE { get; }
        void Save();
    }
}
