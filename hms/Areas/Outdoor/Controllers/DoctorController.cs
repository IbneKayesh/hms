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
    public class DoctorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public DoctorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult ManageDoctor(int? id)
        {
            HS_DOCTOR _obj = new HS_DOCTOR();
            if (id != null)
            {
                _obj = _unitOfWork.HS_DOCTOR.GetFirstOrDefult(x => x.ID == id);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageDoctor(HS_DOCTOR _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    _obj.IS_ACTIVE = true;
                    _unitOfWork.HS_DOCTOR.Add(_obj);
                }
                else
                {
                    _unitOfWork.HS_DOCTOR.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageDoctor));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            _obj.ID = 0;
            return View(_obj);
        }

        public IActionResult GetAll()
        {
            var obj = _unitOfWork.HS_DOCTOR.GetAll();
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(int id)
        {
            bool result = _unitOfWork.HS_DOCTOR.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }
    }
}
