using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Outdoor.Controllers
{
    [Area("Outdoor")]
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
                HP_DURATION_Ins();
                HP_SUGGESSION_Ins();
                HP_FREQUENCY_Ins();
                HP_SHOW_TYPE_Ins();
                HS_DOCTOR_Ins();
                HS_PATIENT_Ins();
                HS_ITEM_Ins();
                return Content("Data Config Iniliazation Succeeded");
            }
            catch (Exception ex) { return Content(ex.Message); }
        }
        private void HP_DURATION_Ins()
        {
            List<HP_DURATION> _d = new List<HP_DURATION>
            {
                new HP_DURATION{ID=1, DURATION_NAME="1 Days" },
                new HP_DURATION{ID=2, DURATION_NAME="2 Days" },
                new HP_DURATION{ID=3, DURATION_NAME="3 Days" },
                new HP_DURATION{ID=4, DURATION_NAME="5 Days" },
                new HP_DURATION{ID=5, DURATION_NAME="7 Days" },
                new HP_DURATION{ID=6, DURATION_NAME="15 Days" },
                new HP_DURATION{ID=7, DURATION_NAME="1 Month" },
                new HP_DURATION{ID=8, DURATION_NAME="3 Month" },
            };
            _unitOfWork.HP_DURATION.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HP_SUGGESSION_Ins()
        {
            List<HP_SUGGESSION> _d = new List<HP_SUGGESSION>
            {
                new HP_SUGGESSION{ID=1, SUGGESTION_NAME="After Meal" },
                new HP_SUGGESSION{ID=2, SUGGESTION_NAME="Before Meal" },
                new HP_SUGGESSION{ID=3, SUGGESTION_NAME="When Feel Pain" },
                new HP_SUGGESSION{ID=4, SUGGESTION_NAME="Stop When Feeling Good" },
                new HP_SUGGESSION{ID=5, SUGGESTION_NAME="Continue unitl end of Dosage" },
            };
            _unitOfWork.HP_SUGGESSION.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HP_FREQUENCY_Ins()
        {
            List<HP_FREQUENCY> _d = new List<HP_FREQUENCY>
            {
                new HP_FREQUENCY{ID=1, FREQUENCY_NAME="0-0-1" },
                new HP_FREQUENCY{ID=2, FREQUENCY_NAME="0-1-0" },
                new HP_FREQUENCY{ID=3, FREQUENCY_NAME="1-0-0" },
                new HP_FREQUENCY{ID=4, FREQUENCY_NAME="1-1-0" },
                new HP_FREQUENCY{ID=5, FREQUENCY_NAME="0-1-1" },
                new HP_FREQUENCY{ID=6, FREQUENCY_NAME="1-0-1" },
                new HP_FREQUENCY{ID=7, FREQUENCY_NAME="1-1-1" },

                new HP_FREQUENCY{ID=8, FREQUENCY_NAME="0-0-2" },
                new HP_FREQUENCY{ID=9, FREQUENCY_NAME="0-2-0" },
                new HP_FREQUENCY{ID=10, FREQUENCY_NAME="2-0-0" },
                new HP_FREQUENCY{ID=11, FREQUENCY_NAME="2-2-0" },
                new HP_FREQUENCY{ID=12, FREQUENCY_NAME="0-2-2" },
                new HP_FREQUENCY{ID=13, FREQUENCY_NAME="2-0-2" },
                new HP_FREQUENCY{ID=14, FREQUENCY_NAME="2-2-2" },
            };
            _unitOfWork.HP_FREQUENCY.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HP_SHOW_TYPE_Ins()
        {
            List<HP_SHOW_TYPE> _d = new List<HP_SHOW_TYPE>
            {
                new HP_SHOW_TYPE{ID=1,SHOW_NAME="Visit"},
                new HP_SHOW_TYPE{ID=1,SHOW_NAME="ReVisit"},
                new HP_SHOW_TYPE{ID=1,SHOW_NAME="Report"},
            };
            _unitOfWork.HP_SHOW_TYPE.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HS_HOSPITAL_Ins()
        {
            List<HS_HOSPITAL> _d = new List<HS_HOSPITAL>
            {
                new HS_HOSPITAL{ID=1,HOSPITAL_NAME="My Care Pvt. Ltd."},
            };
            _unitOfWork.HS_HOSPITAL.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HS_DOCTOR_Ins()
        {
            List<HS_DOCTOR> _d = new List<HS_DOCTOR>
            {
                new HS_DOCTOR{ID=1,DOCTOR_NAME="Mr. Careful"},
            };
            _unitOfWork.HS_DOCTOR.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HS_PATIENT_Ins()
        {
            List<HS_PATIENT> _d = new List<HS_PATIENT>
            {
                new HS_PATIENT{ID=1,PATIENT_NAME="Mr. Seek", DATE_OF_BIRTH=Convert.ToDateTime("01-FEB-2000")},
            };
            _unitOfWork.HS_PATIENT.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HS_ITEM_Ins()
        {
            List<HS_ITEM> _d = new List<HS_ITEM>
            {
                new HS_ITEM{ID=1,ITEM_NAME="Napa Extra"},
                new HS_ITEM{ID=2,ITEM_NAME="Seclo"},
                new HS_ITEM{ID=3,ITEM_NAME="Metryl"},
                new HS_ITEM{ID=4,ITEM_NAME="Histacin"},
                new HS_ITEM{ID=5,ITEM_NAME="Tuska Plus"},
            };
            _unitOfWork.HS_ITEM.AddRange(_d);
            _unitOfWork.Save();
        }
        private void HS_TESTS_Ins()
        {
            List<HS_TESTS> _d = new List<HS_TESTS>
            {
                new HS_TESTS{ID=1,TESTS_NAME="CBC"},
                new HS_TESTS{ID=2,TESTS_NAME="Lipid Profile"},
                new HS_TESTS{ID=3,TESTS_NAME="Covid-19"},
                new HS_TESTS{ID=4,TESTS_NAME="X-Ray"},
            };
            _unitOfWork.HS_TESTS.AddRange(_d);
            _unitOfWork.Save();
        }

    }
}
