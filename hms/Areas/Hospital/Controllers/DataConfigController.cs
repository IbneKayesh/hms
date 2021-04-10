using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Hospital.Controllers
{
    [Area("Hospital")]
    public class DataConfigController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public DataConfigController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Initialize()
        {
            try
            {
                HS_HOSPITAL_Ins();
                HS_BRANCH_Ins();
                HS_DEPARTMENT_ASSIGN_Ins();
                HP_DURATION_Ins();
                HP_SUGGESSION_Ins();
                HP_FREQUENCY_Ins();
                HP_SHOW_TYPE_Ins();
                HS_DOCTOR_TYPE_Ins();
                HS_DOCTOR_Ins();
                HS_EMPLOYEE_TYPE_Ins();
                HS_EMPLOYEE_Ins();
                HS_DEPARTMENT_Ins();
                HS_PATIENT_Ins();
                HS_ITEM_Ins();
                return Content("Data Config Iniliazation Succeeded");
            }
            catch (Exception ex) { return Content(ex.Message); }
        }
        private void HS_HOSPITAL_Ins()
        {
            List<HS_HOSPITAL> _d = new List<HS_HOSPITAL>
            {
                new HS_HOSPITAL{HOSPITAL_NAME="My Care Pvt. Ltd.", HOSPITAL_ADDRESS="Dhaka, Bangladesh", HOSPITAL_MOBILE="01946358034", HOSPITAL_PHONE="01946358034",HOSPITAL_HOTLINE="123",HOSPITAL_EMAIL="care@gmail.com", HOSPITAL_BIN_NO="123"},
            };
            _unitOfWork.HS_HOSPITAL.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HS_BRANCH_Ins()
        {
            List<HS_BRANCH> _d = new List<HS_BRANCH>
            {
                new HS_BRANCH{HOSPITAL_ID=1, BRANCH_NAME="Care-1", BRANCH_NAME_BANGLA="Care-1", BRANCH_ADDRESS="Badda, Dhaka", BRANCH_ADDRESS_BANGLA="Badda, Dhaka", 
                    BRANCH_MOBILE="01946358034",  BRANCH_PHONE="01946358034", BRANCH_HOTLINE="123", BRANCH_EMAIL="care1@gmail.com",  BRANCH_BIN_NO="123"},
            };
            _unitOfWork.HS_BRANCH.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HS_DEPARTMENT_ASSIGN_Ins()
        {
            List<HS_DEPARTMENT_ASSIGN> _d = new List<HS_DEPARTMENT_ASSIGN>
            {
                new HS_DEPARTMENT_ASSIGN{BRANCH_ID=1, DEPARTMENT_ID=1, REMARKS="Test"},
            };
            _unitOfWork.HS_DEPARTMENT_ASSIGN.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HP_DURATION_Ins()
        {
            #region HP_DURATION_Ins
            List<HP_DURATION> _d = new List<HP_DURATION>
            {
                new HP_DURATION{DURATION_NAME="1 Days" },
                new HP_DURATION{DURATION_NAME="2 Days" },
                new HP_DURATION{DURATION_NAME="3 Days" },
                new HP_DURATION{DURATION_NAME="4 Days" },
                new HP_DURATION{DURATION_NAME="5 Days" },
                new HP_DURATION{DURATION_NAME="6 Days" },
                new HP_DURATION{DURATION_NAME="7 Days" },
                new HP_DURATION{DURATION_NAME="8 Days" },
                new HP_DURATION{DURATION_NAME="9 Days" },
                new HP_DURATION{DURATION_NAME="10 Days" },
                new HP_DURATION{DURATION_NAME="11 Days" },
                new HP_DURATION{DURATION_NAME="12 Days" },
                new HP_DURATION{DURATION_NAME="13 Days" },
                new HP_DURATION{DURATION_NAME="14 Days" },
                new HP_DURATION{DURATION_NAME="16 Days" },
                new HP_DURATION{DURATION_NAME="17 Days" },
                new HP_DURATION{DURATION_NAME="18 Days" },
                new HP_DURATION{DURATION_NAME="19 Days" },
                new HP_DURATION{DURATION_NAME="20 Days" },
                new HP_DURATION{DURATION_NAME="21 Days" },
                new HP_DURATION{DURATION_NAME="22 Days" },
                new HP_DURATION{DURATION_NAME="23 Days" },
                new HP_DURATION{DURATION_NAME="24 Days" },
                new HP_DURATION{DURATION_NAME="25 Days" },
                new HP_DURATION{DURATION_NAME="1 Month" },
                new HP_DURATION{DURATION_NAME="1.5 Month" },
                new HP_DURATION{DURATION_NAME="2 Month" },
                new HP_DURATION{DURATION_NAME="2.5 Month" },
                new HP_DURATION{DURATION_NAME="3 Month" },
                new HP_DURATION{DURATION_NAME="3.5 Month" },
                new HP_DURATION{DURATION_NAME="4 Month" },
                new HP_DURATION{DURATION_NAME="4.5 Month" },
                new HP_DURATION{DURATION_NAME="5 Month" },
                new HP_DURATION{DURATION_NAME="5.5 Month" },
                new HP_DURATION{DURATION_NAME="6 Month" },
            };
            _unitOfWork.HP_DURATION.AddRange(_d);
            _unitOfWork.Save();
            #endregion
        }
        private void HP_SUGGESSION_Ins()
        {
            #region HP_SUGGESSION_Ins
            List<HP_SUGGESSION> _d = new List<HP_SUGGESSION>
            {
                new HP_SUGGESSION{SUGGESTION_NAME="After Meal" },
                new HP_SUGGESSION{SUGGESTION_NAME="Before Meal" },
                new HP_SUGGESSION{SUGGESTION_NAME="When Feel Pain" },
                new HP_SUGGESSION{SUGGESTION_NAME="Stop When Feeling Good" },
                new HP_SUGGESSION{SUGGESTION_NAME="Continue unitl end of Dosage" },
            };
            _unitOfWork.HP_SUGGESSION.AddRange(_d);
            _unitOfWork.Save();
            #endregion
        }
        private void HP_FREQUENCY_Ins()
        {
            #region HP_FREQUENCY_Ins
            List<HP_FREQUENCY> _d = new List<HP_FREQUENCY>
            {
                new HP_FREQUENCY{FREQUENCY_NAME="0-0-1" },
                new HP_FREQUENCY{FREQUENCY_NAME="0-1-0" },
                new HP_FREQUENCY{FREQUENCY_NAME="1-0-0" },
                new HP_FREQUENCY{FREQUENCY_NAME="1-1-0" },
                new HP_FREQUENCY{FREQUENCY_NAME="0-1-1" },
                new HP_FREQUENCY{FREQUENCY_NAME="1-0-1" },
                new HP_FREQUENCY{FREQUENCY_NAME="1-1-1" },

                new HP_FREQUENCY{FREQUENCY_NAME="0-0-2" },
                new HP_FREQUENCY{FREQUENCY_NAME="0-2-0" },
                new HP_FREQUENCY{FREQUENCY_NAME="2-0-0" },
                new HP_FREQUENCY{FREQUENCY_NAME="2-2-0" },
                new HP_FREQUENCY{FREQUENCY_NAME="0-2-2" },
                new HP_FREQUENCY{FREQUENCY_NAME="2-0-2" },
                new HP_FREQUENCY{FREQUENCY_NAME="2-2-2" },
            };
            _unitOfWork.HP_FREQUENCY.AddRange(_d);
            _unitOfWork.Save();
            #endregion
        }
        private void HP_SHOW_TYPE_Ins()
        {
            #region HP_SHOW_TYPE_Ins
            List<HP_SHOW_TYPE> _d = new List<HP_SHOW_TYPE>
            {
                new HP_SHOW_TYPE{SHOW_NAME="Visit"},
                new HP_SHOW_TYPE{SHOW_NAME="ReVisit"},
                new HP_SHOW_TYPE{SHOW_NAME="Report"},
            };
            _unitOfWork.HP_SHOW_TYPE.AddRange(_d);
            _unitOfWork.Save();
            #endregion
        }

        private void HS_DOCTOR_TYPE_Ins()
        {
            #region HS_DOCTOR_TYPE_Ins
            List<HS_DOCTOR_TYPE> _d = new List<HS_DOCTOR_TYPE>
            {
                new HS_DOCTOR_TYPE{DOCTOR_TYPE_NAME="Medicine" },
            };
            _unitOfWork.HS_DOCTOR_TYPE.AddRange(_d);
            _unitOfWork.Save();
            #endregion
        }
        private void HS_DOCTOR_Ins()
        {
            List<HS_DOCTOR> _d = new List<HS_DOCTOR>
            {
                new HS_DOCTOR{HOSPITAL_ID=1, DOCTOR_NAME="Mr. Careful", DOCTOR_NAME_BANGLA="Mr. Careful", DOCTOR_DEGREE="FCPS,MBBS", DOCTOR_DEGREE_BANGLA="FCPS,MBBS",
                DOCTOR_SPECIALITY="Medicine", DOCTOR_SPECIALITY_BANGLA="Medicine", DOCTOR_OTHERS="BSMMU", DOCTOR_OTHERS_BANGLA="BSMMU", DOCTOR_REG_NO="123",DOCTOR_REG_NO_BANGLA="123",
                US_GENDER_ID=1, US_BLOOD_GROUP_ID=1, HS_DOCTOR_TYPE_ID=1, US_RELIGION_ID=1, US_MARITAIL_STATUS_ID=1, DOCTOR_NATIONAL_ID="123" },
            };
            _unitOfWork.HS_DOCTOR.AddRange(_d);
            _unitOfWork.Save();
        }

        private void HS_EMPLOYEE_TYPE_Ins()
        {
            #region HS_EMPLOYEE_TYPE_Ins
            List<HS_EMPLOYEE_TYPE> _d = new List<HS_EMPLOYEE_TYPE>
            {
                new HS_EMPLOYEE_TYPE{EMPLOYEE_TYPE_NAME= "General" },
                new HS_EMPLOYEE_TYPE{EMPLOYEE_TYPE_NAME= "Nurse" },
            };
            _unitOfWork.HS_EMPLOYEE_TYPE.AddRange(_d);
            _unitOfWork.Save();
            #endregion
        }
        private void HS_EMPLOYEE_Ins()
        {
            List<HS_EMPLOYEE> _d = new List<HS_EMPLOYEE>
            {
                new  HS_EMPLOYEE{ID=1, HOSPITAL_ID=1, EMPLOYEE_NAME="Mr. X", PRESENT_ADDRESS="Badda, Dhaka-1212", PERMANENT_ADDRESS="Naogaon, Rajshahi",
                EMPLOYEE_DEGREE="Msc in CSE", EMPLOYEE_SPECIALITY="Computer Science", EMPLOYEE_REG_NO="123",
                GENDER_ID=1, MARITAIL_STATUS_ID=1, BLOOD_GROUP_ID=1, EMPLOYEE_TYPE_ID=1, RELIGION_ID=1, EMPLOYEE_NATIONAL_ID="123" },
            };
            _unitOfWork.HS_EMPLOYEE.AddRange(_d);
            _unitOfWork.Save();
        }

        private void HS_DEPARTMENT_Ins()
        {
            List<HS_DEPARTMENT> _d = new List<HS_DEPARTMENT>
            {
                new  HS_DEPARTMENT{ DEPARTMENT_NAME="Urology" },
            };
            _unitOfWork.HS_DEPARTMENT.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HS_PATIENT_Ins()
        {
            List<HS_PATIENT> _d = new List<HS_PATIENT>
            {
                new HS_PATIENT{ID=1, PATIENT_NAME="Mr. Seek", DATE_OF_BIRTH=Convert.ToDateTime("01-FEB-2000")},
            };
            _unitOfWork.HS_PATIENT.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HS_ITEM_Ins()
        {
            List<HS_ITEM> _d = new List<HS_ITEM>
            {
                new HS_ITEM{ID=1, ITEM_NAME="Napa Extra", UNIT_ID=1, DP_RATE=1, MRP_RATE= 1.1M},
                new HS_ITEM{ID=2, ITEM_NAME="Seclo", UNIT_ID=1, DP_RATE=2, MRP_RATE= 2.1M},
                new HS_ITEM{ID=3, ITEM_NAME="Metryl", UNIT_ID=1, DP_RATE=3, MRP_RATE= 3.1M},
                new HS_ITEM{ID=4, ITEM_NAME="Histacin", UNIT_ID=1, DP_RATE=4, MRP_RATE= 4.1M},
                new HS_ITEM{ID=5, ITEM_NAME="Tuska Plus", UNIT_ID=1, DP_RATE=5, MRP_RATE= 5.1M},
            };
            _unitOfWork.HS_ITEM.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HS_TESTS_Ins()
        {
            List<HS_TESTS> _d = new List<HS_TESTS>
            {
                new HS_TESTS{TESTS_NAME="CBC"},
                new HS_TESTS{TESTS_NAME="Lipid Profile"},
                new HS_TESTS{TESTS_NAME="Covid-19"},
                new HS_TESTS{TESTS_NAME="X-Ray"},
            };
            _unitOfWork.HS_TESTS.AddRange(_d);
            _unitOfWork.Save();
        }

    }
}
