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
        IUS_ROLE_MENURepository US_ROLE_MENU { get; }
        IUS_USER_ROLERepository US_USER_ROLE { get; }
        IUS_TYPERepository US_TYPE { get; }
        IHP_CHECKUPRepository HP_CHECKUP { get; }
        IHP_DURATIONRepository HP_DURATION { get; }
        IHP_FREQUENCYRepository HP_FREQUENCY { get; }
        IHP_INVESTIGATIONRepository HP_INVESTIGATION { get; }
        IHP_MEDICINERepository HP_MEDICINE { get; }
        IHP_PRESCRIPTIONRepository HP_PRESCRIPTION { get; }
        IHP_SHOW_TYPERepository HP_SHOW_TYPE { get; }
        IHP_SUGGESSIONRepository HP_SUGGESSION { get; }
        IHP_TOKENRepository HP_TOKEN { get; }
        IHS_DOCTORRepository HS_DOCTOR { get; }
        IHS_HOSPITALRepository HS_HOSPITAL { get; }
        IHS_ITEMRepository HS_ITEM { get; }
        IHS_PATIENTRepository HS_PATIENT { get; }
        IHS_TESTSRepository HS_TESTS { get; }
        void Save();

    }
}
