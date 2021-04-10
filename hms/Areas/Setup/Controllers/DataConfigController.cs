using hms.DataAccess;
using hms.DataAccess.Repository;
using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    //[Route("Setup/[controller]/[action]")]
    public class DataConfigController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly hmsDbContext _db;

        public DataConfigController(IUnitOfWork unitOfWork, hmsDbContext db)
        {
            _unitOfWork = unitOfWork;
            _db = db;
        }

        [HttpGet]
        public IActionResult Initialize()
        {
            try
            {
         US_BLOOD_GROUP_Ins();
                US_GENDER_Ins();
                US_MARITAIL_STATUS_Ins();
                US_RELIGION_Ins();
                US_ROLE_Ins();
                US_TYPE_Ins();
                US_MODULE_Ins();
                US_PARENT_MENU_Ins();
                US_CHILD_MENU_Ins();
                US_USER_Ins();
                US_ROLE_MENU_Ins();
                US_USER_ROLE_Ins();
                US_UNIT_Ins();
                return Content("Data Config Iniliazation Succeeded");
            }
            catch (Exception ex) { return Content(ex.InnerException.Message); }
        }

        #region No Change
        private void US_BLOOD_GROUP_Ins()
        {
            List<US_BLOOD_GROUP> _d = new List<US_BLOOD_GROUP>
            {
                new US_BLOOD_GROUP{ ID=1, BLOOD_GROUP_NAME="A+" },
                new US_BLOOD_GROUP{ ID=2,BLOOD_GROUP_NAME="A-" },
                new US_BLOOD_GROUP{ ID=3,BLOOD_GROUP_NAME="B+" },
                new US_BLOOD_GROUP{ ID=4,BLOOD_GROUP_NAME="B-" },
                new US_BLOOD_GROUP{ ID=5,BLOOD_GROUP_NAME="O+" },
                new US_BLOOD_GROUP{ ID=6,BLOOD_GROUP_NAME="O-" },
                new US_BLOOD_GROUP{ ID=7,BLOOD_GROUP_NAME="AB+" },
                new US_BLOOD_GROUP{ ID=8,BLOOD_GROUP_NAME="AB-" },
            };
            _unitOfWork.US_BLOOD_GROUP.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_GENDER_Ins()
        {
            List<US_GENDER> _d = new List<US_GENDER>
            {
                new US_GENDER{ID=1, GENDER_NAME="Male" },
                new US_GENDER{ ID=2,GENDER_NAME="Female" },
                new US_GENDER{ ID=3,GENDER_NAME="3rdGender" },
            };
            _unitOfWork.US_GENDER.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_MARITAIL_STATUS_Ins()
        {
            List<US_MARITAIL_STATUS> _d = new List<US_MARITAIL_STATUS>
            {
                new US_MARITAIL_STATUS{ID=1, MARITAIL_STATUS_NAME="Single" },
                new US_MARITAIL_STATUS{ ID=2,MARITAIL_STATUS_NAME="Married" },
                new US_MARITAIL_STATUS{ ID=3,MARITAIL_STATUS_NAME="Widowed" },
                new US_MARITAIL_STATUS{ ID=4,MARITAIL_STATUS_NAME="Separated" },
                new US_MARITAIL_STATUS{ID=5, MARITAIL_STATUS_NAME="Divorced" },
            };
            _unitOfWork.US_MARITAIL_STATUS.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_RELIGION_Ins()
        {
            List<US_RELIGION> _d = new List<US_RELIGION>
            {
                new US_RELIGION{ ID=1,RELIGION_NAME="Islam" },
                new US_RELIGION{ ID=2,RELIGION_NAME="Hindu" },
                new US_RELIGION{ ID=3,RELIGION_NAME="Christians" },
                new US_RELIGION{ ID=4,RELIGION_NAME="Buddhists" },
                new US_RELIGION{ ID=5,RELIGION_NAME="Others" },
            };
            _unitOfWork.US_RELIGION.AddRange(_d);
            _unitOfWork.Save();
        }
        #endregion

        #region Role and Type
        private void US_ROLE_Ins()
        {
            List<US_ROLE> _d = new List<US_ROLE>
            {
                new US_ROLE{ ID=1,ROLE_NAME="SuperAdmin" },
                new US_ROLE{ ID=2,ROLE_NAME="Admin" },
                new US_ROLE{ ID=3,ROLE_NAME="Operator" },
                new US_ROLE{ID=4, ROLE_NAME="Audit" },
                new US_ROLE{ ID=5,ROLE_NAME="Report" }
            };
            _unitOfWork.US_ROLE.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_TYPE_Ins()
        {
            List<US_TYPE> _d = new List<US_TYPE>
            {
                new US_TYPE{ ID=1,TYPE_NAME="General" },
                new US_TYPE{ ID=2,TYPE_NAME="Entry" },
                new US_TYPE{ ID=3,TYPE_NAME="Approver" },
                new US_TYPE{ ID=4,TYPE_NAME="EntryApprover" }
            };
            _unitOfWork.US_TYPE.AddRange(_d);
            _unitOfWork.Save();
        }
        #endregion

        private void US_MODULE_Ins()
        {
            List<US_MODULE> _d = new List<US_MODULE>
            {
                new US_MODULE{ ID=1, MODULE_NAME="Setup", MODULE_BN_NAME="Setup", MODULE_ICON="fas fa-cogs",VIEW_ORDER=1,CONTROLLER_NAME="Home",METHOD_NAME="IndexOptions" },
                new US_MODULE{ ID=2,MODULE_NAME="Order", MODULE_BN_NAME="Order", MODULE_ICON="fas fa-cubes",VIEW_ORDER=2,CONTROLLER_NAME="Home",METHOD_NAME="IndexOptions" },
                new US_MODULE{ ID=3,MODULE_NAME="Outdoor", MODULE_BN_NAME="Outdoor", MODULE_ICON="fas fa-cubes",VIEW_ORDER=4,CONTROLLER_NAME="Home",METHOD_NAME="IndexOptions" },
                new US_MODULE{ ID=4,MODULE_NAME="Hospital", MODULE_BN_NAME="Hospital", MODULE_ICON="fas fa-cubes",VIEW_ORDER=3,CONTROLLER_NAME="Home",METHOD_NAME="IndexOptions" },
                new US_MODULE{ ID=5,MODULE_NAME="Indoor", MODULE_BN_NAME="Indoor", MODULE_ICON="fas fa-cubes",VIEW_ORDER=5,CONTROLLER_NAME="Home",METHOD_NAME="IndexOptions" },
                new US_MODULE{ ID=6,MODULE_NAME="OT", MODULE_BN_NAME="OT", MODULE_ICON="fas fa-cubes",VIEW_ORDER=6,CONTROLLER_NAME="Home",METHOD_NAME="IndexOptions" },
            };
            _unitOfWork.US_MODULE.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_PARENT_MENU_Ins()
        {
            List<US_PARENT_MENU> _d = new List<US_PARENT_MENU>
            {
                new US_PARENT_MENU{ ID=1,PARENT_NAME="Setup", PARENT_BN_NAME="Setup", PARENT_ICON="fa fa-cogs" },
                new US_PARENT_MENU{ ID=2,PARENT_NAME="Sales", PARENT_BN_NAME="Sales", PARENT_ICON="fa fa-cubes" },
                new US_PARENT_MENU{ ID=3,PARENT_NAME="Outdoor", PARENT_BN_NAME="Outdoor", PARENT_ICON="fa fa-cubes" },
                new US_PARENT_MENU{ ID=4,PARENT_NAME="Hospital", PARENT_BN_NAME="Hospital", PARENT_ICON="fa fa-cubes" },
                new US_PARENT_MENU{ ID=5,PARENT_NAME="Indoor", PARENT_BN_NAME="Indoor", PARENT_ICON="fa fa-cubes" },
                new US_PARENT_MENU{ ID=6,PARENT_NAME="OT", PARENT_BN_NAME="OT", PARENT_ICON="fa fa-cubes" },
            };
            _unitOfWork.US_PARENT_MENU.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_CHILD_MENU_Ins()
        {
            List<US_CHILD_MENU> _d = new List<US_CHILD_MENU>
            {
                //=================Setup==================== 1 to 50 
                new US_CHILD_MENU{ ID=1, CHILD_NAME="Data Config", CHILD_BN_NAME="Data Config", CHILD_ICON="fa fa-cogs", AREA_NAME="Setup", CONTROLLER_NAME="DataConfig", ACTION_NAME="Initialize", MODULE_ID=1, PARENT_MENU_ID=1 },
                new US_CHILD_MENU{ ID=2, CHILD_NAME="User", CHILD_BN_NAME="User", CHILD_ICON="fa fa-users", AREA_NAME="Setup", CONTROLLER_NAME="User", ACTION_NAME="ManageUser", MODULE_ID=1, PARENT_MENU_ID=1 },
                new US_CHILD_MENU{ ID=3, CHILD_NAME="Blood Group", CHILD_BN_NAME="Blood Group", CHILD_ICON="fa fa-users", AREA_NAME="Setup", CONTROLLER_NAME="BloodGroup", ACTION_NAME="ManageBloodGroup", MODULE_ID=1, PARENT_MENU_ID=1 },
                new US_CHILD_MENU{ ID=4, CHILD_NAME="User Role", CHILD_BN_NAME="User Role", CHILD_ICON="fa fa-users", AREA_NAME="Setup", CONTROLLER_NAME="UserRole", ACTION_NAME="ManageUserRole", MODULE_ID=1, PARENT_MENU_ID=1 },
                new US_CHILD_MENU{ ID=5, CHILD_NAME="Role", CHILD_BN_NAME="Role", CHILD_ICON="fa fa-users", AREA_NAME="Setup", CONTROLLER_NAME="Role", ACTION_NAME="ManageRole", MODULE_ID=1, PARENT_MENU_ID=1 },
                new US_CHILD_MENU{ ID=6, CHILD_NAME="Child Menu", CHILD_BN_NAME="Child Menu", CHILD_ICON="fa fa-users", AREA_NAME="Setup", CONTROLLER_NAME="ChildMenu", ACTION_NAME="ManageChildMenu", MODULE_ID=1, PARENT_MENU_ID=1 },
                new US_CHILD_MENU{ ID=7, CHILD_NAME="Module", CHILD_BN_NAME="Module", CHILD_ICON="fa fa-users", AREA_NAME="Setup", CONTROLLER_NAME="Module", ACTION_NAME="ManageModule", MODULE_ID=1, PARENT_MENU_ID=1 },
                new US_CHILD_MENU{ ID=8, CHILD_NAME="Parent Menu", CHILD_BN_NAME="Parent Menu", CHILD_ICON="fa fa-users", AREA_NAME="Setup", CONTROLLER_NAME="ParentMenu", ACTION_NAME="ManageParentMenu", MODULE_ID=1, PARENT_MENU_ID=1 },
                new US_CHILD_MENU{ ID=9, CHILD_NAME="Role Menu", CHILD_BN_NAME="Role Menu", CHILD_ICON="fa fa-users", AREA_NAME="Setup", CONTROLLER_NAME="RoleMenu", ACTION_NAME="ManageRoleMenu", MODULE_ID=1, PARENT_MENU_ID=1 },
                new US_CHILD_MENU{ ID=10, CHILD_NAME="Unit", CHILD_BN_NAME="Unit", CHILD_ICON="fa fa-users", AREA_NAME="Setup", CONTROLLER_NAME="Unit", ACTION_NAME="ManageUnit", MODULE_ID=1, PARENT_MENU_ID=1 },
                
                 //=================Order==================== 51 to 100
                 new US_CHILD_MENU{ ID=51, CHILD_NAME="Sales", CHILD_BN_NAME="Sales", CHILD_ICON="fa fa-users", AREA_NAME="Order", CONTROLLER_NAME="Sales", ACTION_NAME="Sale", MODULE_ID=2, PARENT_MENU_ID=2 },

                 //=================Outdoor==================== 101 to 150
                 new US_CHILD_MENU{ ID=101, CHILD_NAME="Prescription", CHILD_BN_NAME="Prescription", CHILD_ICON="fa fa-users", AREA_NAME="Outdoor", CONTROLLER_NAME="Prescription", ACTION_NAME="Prescribe", MODULE_ID=3, PARENT_MENU_ID=3 },
                 new US_CHILD_MENU{ ID=102, CHILD_NAME="Token", CHILD_BN_NAME="Token", CHILD_ICON="fa fa-users", AREA_NAME="Outdoor", CONTROLLER_NAME="Token", ACTION_NAME="ManageToken", MODULE_ID=3, PARENT_MENU_ID=3 },
                 
                 //=================Hospital==================== 151 to 200
                 new US_CHILD_MENU{ ID=151, CHILD_NAME="Doctor", CHILD_BN_NAME="Doctor", CHILD_ICON="fa fa-users", AREA_NAME="Hospital", CONTROLLER_NAME="Doctor", ACTION_NAME="ManageDoctor", MODULE_ID=4, PARENT_MENU_ID=4 },
                 new US_CHILD_MENU{ ID=152, CHILD_NAME="Patient", CHILD_BN_NAME="Patient", CHILD_ICON="fa fa-users", AREA_NAME="Hospital", CONTROLLER_NAME="Patient", ACTION_NAME="ManagePatient", MODULE_ID=4, PARENT_MENU_ID=4 },
                 new US_CHILD_MENU{ ID=153, CHILD_NAME="Item", CHILD_BN_NAME="Item", CHILD_ICON="fa fa-users", AREA_NAME="Hospital", CONTROLLER_NAME="Item", ACTION_NAME="ManageItem", MODULE_ID=4, PARENT_MENU_ID=4 },

                  //=================Indoor==================== 201 to 250
                 new US_CHILD_MENU{ ID=201, CHILD_NAME="Home", CHILD_BN_NAME="Home", CHILD_ICON="fa fa-users", AREA_NAME="Indoor", CONTROLLER_NAME="Home", ACTION_NAME="Index", MODULE_ID=5, PARENT_MENU_ID=5 },
                 //=================OT==================== 251 to 300
                 new US_CHILD_MENU{ ID=251, CHILD_NAME="Home", CHILD_BN_NAME="Home", CHILD_ICON="fa fa-users", AREA_NAME="OT", CONTROLLER_NAME="Home", ACTION_NAME="Index", MODULE_ID=6, PARENT_MENU_ID=6 },
            };
            _unitOfWork.US_CHILD_MENU.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_ROLE_MENU_Ins()
        {
            List<US_ROLE_MENU> _d = new List<US_ROLE_MENU>
            {
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=1 },
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=2 },
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=3 },
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=4 },
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=5 },
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=6 },
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=7 },
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=8 },
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=9 },

                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=51 },

                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=101 },
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=102 },

                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=151 },
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=152 },
                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=153 },

                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=201 },

                new US_ROLE_MENU{ ROLE_ID=1,CHILD_MENU_ID=251 },
            };
            _unitOfWork.US_ROLE_MENU.AddRange(_d);
            _unitOfWork.Save();
        }

        private void US_USER_Ins()
        {
            List<US_USER> _d = new List<US_USER>
            {
                new US_USER{ ID=1, LOGIN_ID ="admin",PASSWORD=TextEncryption.EncryptionWithSh("a"),USER_NAME="Administrator",MOBILE_NO="01000000000",EMAIL_ID="admin@hms.com",DATE_OF_BIRTH=DateTime.Now.Date,PROFILE_IMAGE="-",GENDER_ID=1,RELIGION_ID=1,BLOOD_GROUP_ID=1,MARITAIL_STATUS_ID=1,TYPE_ID=1}
            };
            _unitOfWork.US_USER.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_USER_ROLE_Ins()
        {
            List<US_USER_ROLE> _d = new List<US_USER_ROLE>
            {
                new US_USER_ROLE{ ROLE_ID=1,USER_ID=1 }
            };
            _unitOfWork.US_USER_ROLE.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_UNIT_Ins()
        {
            List<US_UNIT> _d = new List<US_UNIT>
            {
                new US_UNIT{ ID=1, UNIT_NAME="Pcs" },
                new US_UNIT{ ID=2, UNIT_NAME="Box" },
                new US_UNIT{ ID=3, UNIT_NAME="Kg" },
            };
            _unitOfWork.US_UNIT.AddRange(_d);
            _unitOfWork.Save();
        }


        [HttpGet]
        public IActionResult DropInitialize()
        {
            RawSql rawSql = new RawSql(_db);

            try
            {
                object[] pram = new object[] { };
                List<string> sql_ls = new List<string>();
                sql_ls.Add(@"DROP DATABASE hmsDb");

                //sql_ls.Add(@"DELETE FROM US_USER_ROLE");
                //sql_ls.Add(@"DELETE FROM US_ROLE_MENU");

                //sql_ls.Add(@"DELETE FROM US_USER");

                //sql_ls.Add(@"DELETE FROM US_TYPE");
                //sql_ls.Add(@"DELETE FROM US_ROLE");
                //sql_ls.Add(@"DELETE FROM US_RELIGION");
                //sql_ls.Add(@"DELETE FROM US_MARITAIL_STATUS");
                //sql_ls.Add(@"DELETE FROM US_GENDER");
                //sql_ls.Add(@"DELETE FROM US_BLOOD_GROUP");

                //sql_ls.Add(@"DELETE FROM US_CHILD_MENU");
                //sql_ls.Add(@"DELETE FROM US_PARENT_MENU");
                //sql_ls.Add(@"DELETE FROM US_MODULE");

                //sql_ls.Add(@"DELETE FROM US_EMAIL_SERVER");
                //sql_ls.Add(@"DELETE FROM US_EMAIL_BOX");

                foreach (string sql in sql_ls)
                {
                    rawSql.ExecuteSqlCommand(sql, pram);
                }
                return Content("Data Config Drop Iniliazation Succeeded");
            }
            catch (Exception ex) { return Content(ex.Message); }
        }
    }
}
