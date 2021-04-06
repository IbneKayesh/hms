using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Outdoor.Controllers
{
    [Area("Outdoor")]
    public class PatientController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PatientController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult ManagePatient(int? id)
        {
            HS_PATIENT _obj = new HS_PATIENT();
            _obj.DATE_OF_BIRTH = DateTime.Now;
            if (id != null)
            {
                _obj = _unitOfWork.HS_PATIENT.GetFirstOrDefult(x => x.ID == id);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManagePatient(HS_PATIENT _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    _obj.ID = _unitOfWork.HS_PATIENT.GetAll().Max(x => x.ID) + 1;
                    _obj.IS_ACTIVE = true;
                    _unitOfWork.HS_PATIENT.Add(_obj);
                }
                else
                {
                    _unitOfWork.HS_PATIENT.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManagePatient));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            _obj.ID = 0;
            return View(_obj);
        }

        public IActionResult GetAll()
        {
            var obj = _unitOfWork.HS_PATIENT.GetAll();
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(Int64 id)
        {
            bool result = _unitOfWork.HS_PATIENT.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }
    }
}
