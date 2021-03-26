using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Setup.Controllers
{
    [Area(nameof(Setup))]
    [Route("Setup/[controller]/[action]")]
    public class DataConfigController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DataConfigController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Insert()
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
            return View();
        }
        [HttpPost]
        public IActionResult Insert(string command)
        {
            return View();
        }
        private void US_BLOOD_GROUP_Ins()
        {
            List<US_BLOOD_GROUP> _d = new List<US_BLOOD_GROUP>
            {
                new US_BLOOD_GROUP{ BLOOD_GROUP_NAME="A+" },
                new US_BLOOD_GROUP{ BLOOD_GROUP_NAME="A-" },
                new US_BLOOD_GROUP{ BLOOD_GROUP_NAME="B+" },
                new US_BLOOD_GROUP{ BLOOD_GROUP_NAME="B-" },
                new US_BLOOD_GROUP{ BLOOD_GROUP_NAME="O+" },
                new US_BLOOD_GROUP{ BLOOD_GROUP_NAME="O-" },
                new US_BLOOD_GROUP{ BLOOD_GROUP_NAME="AB+" },
                new US_BLOOD_GROUP{ BLOOD_GROUP_NAME="AB-" },
            };
            _unitOfWork.US_BLOOD_GROUP.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_GENDER_Ins()
        {
            List<US_GENDER> _d = new List<US_GENDER>
            {
                new US_GENDER{ GENDER_NAME="Male" },
                new US_GENDER{ GENDER_NAME="Female" }
            };
            _unitOfWork.US_GENDER.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_MARITAIL_STATUS_Ins()
        {
            List<US_MARITAIL_STATUS> _d = new List<US_MARITAIL_STATUS>
            {
                new US_MARITAIL_STATUS{ MARITAIL_STATUS_NAME="Single" },
                new US_MARITAIL_STATUS{ MARITAIL_STATUS_NAME="Married" },
                new US_MARITAIL_STATUS{ MARITAIL_STATUS_NAME="Widowed" },
                new US_MARITAIL_STATUS{ MARITAIL_STATUS_NAME="Separated" },
                new US_MARITAIL_STATUS{ MARITAIL_STATUS_NAME="Divorced" },
            };
            _unitOfWork.US_MARITAIL_STATUS.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_RELIGION_Ins()
        {
            List<US_RELIGION> _d = new List<US_RELIGION>
            {
                new US_RELIGION{ RELIGION_NAME="Islam" },
                new US_RELIGION{ RELIGION_NAME="Hindu" },
                new US_RELIGION{ RELIGION_NAME="Christians" },
                new US_RELIGION{ RELIGION_NAME="Buddhists" },
                new US_RELIGION{ RELIGION_NAME="Others" },
            };
            _unitOfWork.US_RELIGION.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_ROLE_Ins()
        {
            List<US_ROLE> _d = new List<US_ROLE>
            {
                new US_ROLE{ ROLE_NAME="SuperAdmin" },
                new US_ROLE{ ROLE_NAME="Admin" },
                new US_ROLE{ ROLE_NAME="Operator" },
                new US_ROLE{ ROLE_NAME="Audit" },
                new US_ROLE{ ROLE_NAME="Report" }
            };
            _unitOfWork.US_ROLE.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_TYPE_Ins()
        {
            List<US_TYPE> _d = new List<US_TYPE>
            {
                new US_TYPE{ TYPE_NAME="Entry" },
                new US_TYPE{ TYPE_NAME="Approver" },
                new US_TYPE{ TYPE_NAME="EntryApprover" }
            };
            _unitOfWork.US_TYPE.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_MODULE_Ins()
        {
            List<US_MODULE> _d = new List<US_MODULE>
            {
                new US_MODULE{ MODULE_NAME="Setup", MODULE_BN_NAME="Setup", MODULE_ICON="fa fa-cogs",VIEW_ORDER=1,CONTROLLER_NAME="Home",METHOD_NAME="MenuMaker" },
                new US_MODULE{ MODULE_NAME="Order", MODULE_BN_NAME="Order", MODULE_ICON="fa fa-cubes",VIEW_ORDER=2,CONTROLLER_NAME="Home",METHOD_NAME="MenuMaker" },
            };
            _unitOfWork.US_MODULE.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_PARENT_MENU_Ins()
        {
            List<US_PARENT_MENU> _d = new List<US_PARENT_MENU>
            {
                new US_PARENT_MENU{ PARENT_NAME="Setup", PARENT_BN_NAME="Setup", PARENT_ICON="fa fa-cogs" },
                new US_PARENT_MENU{ PARENT_NAME="Sales", PARENT_BN_NAME="Sales", PARENT_ICON="fa fa-cubes" },
            };
            _unitOfWork.US_PARENT_MENU.AddRange(_d);
            _unitOfWork.Save();
        }
        private void US_CHILD_MENU_Ins()
        {
            List<US_CHILD_MENU> _d = new List<US_CHILD_MENU>
            {
                new US_CHILD_MENU{ CHILD_NAME="Data Config", CHILD_BN_NAME="Data Config", CHILD_ICON="fa fa-cogs",AREA_NAME="Setup",CONTROLLER_NAME="DataConfig",ACTION_NAME="Insert",US_MODULE_ID=1,US_PARENT_MENU_ID=1 },
                new US_CHILD_MENU{ CHILD_NAME="User", CHILD_BN_NAME="User", CHILD_ICON="fa fa-users", AREA_NAME="Setup",CONTROLLER_NAME="User",ACTION_NAME="ManageUser",US_MODULE_ID=1,US_PARENT_MENU_ID=1 },
                new US_CHILD_MENU{ CHILD_NAME="Blood Group", CHILD_BN_NAME="Blood Group", CHILD_ICON="fa fa-users", AREA_NAME="Setup",CONTROLLER_NAME="BloodGroup",ACTION_NAME="ManageBloodGroup",US_MODULE_ID=1,US_PARENT_MENU_ID=1 },
            };
            _unitOfWork.US_CHILD_MENU.AddRange(_d);
            _unitOfWork.Save();
        }

    }
}
