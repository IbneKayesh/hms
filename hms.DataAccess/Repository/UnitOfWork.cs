using hms.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly hmsDbContext _db;
        public UnitOfWork(hmsDbContext db)
        {
            _db = db;
            US_USER = new US_USERRepository(_db);
            US_BLOOD_GROUP = new US_BLOOD_GROUPRepository(_db);
            US_CHILD_MENU = new US_CHILD_MENURepository(_db);
            US_GENDER = new US_GENDERRepository(_db);
            US_MARITAIL_STATUS = new US_MARITAIL_STATUSRepository(_db);
            US_MODULE = new US_MODULERepository(_db);
            US_PARENT_MENU = new US_PARENT_MENURepository(_db);
            US_RELIGION = new US_RELIGIONRepository(_db);
            US_ROLE_MENU=new US_ROLE_MENURepository(_db);
            US_ROLE = new US_ROLERepository(_db);
            US_USER_ROLE = new US_USER_ROLERepository(_db);
            US_TYPE = new US_TYPERepository(_db);

            HP_CHECKUP = new HP_CHECKUPRepository(_db);
            HP_DURATION = new HP_DURATIONRepository(_db);
            HP_FREQUENCY = new HP_FREQUENCYRepository(_db);
            HP_INVESTIGATION = new HP_INVESTIGATIONRepository(_db);
            HP_MEDICINE = new HP_MEDICINERepository(_db);
            HP_PRESCRIPTION = new HP_PRESCRIPTIONRepository(_db);
            HP_SHOW_TYPE = new HP_SHOW_TYPERepository(_db);
            HP_SUGGESSION = new HP_SUGGESSIONRepository(_db);
            HP_TOKEN = new HP_TOKENRepository(_db);
            HS_DOCTOR = new HS_DOCTORRepository(_db);
            HS_HOSPITAL = new HS_HOSPITALRepository(_db);
            HS_ITEM = new HS_ITEMRepository(_db);
            HS_PATIENT = new HS_PATIENTRepository(_db);
            HS_TESTS = new HS_TESTSRepository(_db);

        }
        public IUS_USERRepository US_USER { get; private set; }
        public IUS_BLOOD_GROUPRepository US_BLOOD_GROUP { get; private set; }
        public IUS_CHILD_MENURepository US_CHILD_MENU { get; private set; }
        public IUS_GENDERRepository US_GENDER { get; private set; }
        public IUS_MARITAIL_STATUSRepository US_MARITAIL_STATUS { get; private set; }
        public IUS_MODULERepository US_MODULE { get; private set; }
        public IUS_PARENT_MENURepository US_PARENT_MENU { get; private set; }
        public IUS_RELIGIONRepository US_RELIGION { get; private set; }
        public IUS_ROLE_MENURepository US_ROLE_MENU { get; private set; }
        public IUS_ROLERepository US_ROLE { get; private set; }
        public IUS_USER_ROLERepository US_USER_ROLE { get; private set; }        
        public IUS_TYPERepository US_TYPE { get; private set; }
        public IHP_CHECKUPRepository HP_CHECKUP { get; private set; }
        public IHP_DURATIONRepository HP_DURATION { get; private set; }
        public IHP_FREQUENCYRepository HP_FREQUENCY { get; private set; }
        public IHP_INVESTIGATIONRepository HP_INVESTIGATION { get; private set; }
        public IHP_MEDICINERepository HP_MEDICINE { get; private set; }
        public IHP_PRESCRIPTIONRepository HP_PRESCRIPTION { get; private set; }
        public IHP_SHOW_TYPERepository HP_SHOW_TYPE { get; private set; }
        public IHP_SUGGESSIONRepository HP_SUGGESSION { get; private set; }
        public IHP_TOKENRepository HP_TOKEN { get; private set; }
        public IHS_DOCTORRepository HS_DOCTOR { get; private set; }
        public IHS_HOSPITALRepository HS_HOSPITAL { get; private set; }
        public IHS_ITEMRepository HS_ITEM { get; private set; }
        public IHS_PATIENTRepository HS_PATIENT { get; private set; }
        public IHS_TESTSRepository HS_TESTS { get; private set; }      

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
