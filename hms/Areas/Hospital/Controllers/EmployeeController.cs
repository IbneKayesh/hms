using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Hospital.Controllers
{
    [Area("Hospital")]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult ManageEmployee(int? id)
        {
            HS_EMPLOYEE _obj = new HS_EMPLOYEE();
            if (id != null)
            {
                _obj = _unitOfWork.HS_EMPLOYEE.GetFirstOrDefult(x => x.ID == id);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageEmployee(HS_EMPLOYEE _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    try
                    {
                        _obj.ID = _unitOfWork.HS_EMPLOYEE.GetAll().Max(x => x.ID) + 1;
                    }
                    catch
                    {
                        _obj.ID = 1;
                    }                    
                    _obj.IS_ACTIVE = true;
                    _unitOfWork.HS_EMPLOYEE.Add(_obj);
                }
                else
                {
                    _unitOfWork.HS_EMPLOYEE.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageEmployee));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            _obj.ID = 0;
            return View(_obj);
        }

        public IActionResult GetAll()
        {
            var obj = _unitOfWork.HS_EMPLOYEE.GetAll();
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(int id)
        {
            bool result = _unitOfWork.HS_EMPLOYEE.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }
    }
}
