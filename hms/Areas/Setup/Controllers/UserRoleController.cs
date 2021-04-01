using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    public class UserRoleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserRoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageUserRole(int? id, int? id1)
        {
            DropDownFor_ManageUserRole();
            US_USER_ROLE _obj = new US_USER_ROLE();
            if (id != null && id1 != null)
            {
                _obj = _unitOfWork.US_USER_ROLE.GetFirstOrDefult(x => x.US_USER_ID == id && x.US_ROLE_ID == id1);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageUserRole(US_USER_ROLE _obj)
        {
            if (ModelState.IsValid)
            {
                _obj.IS_ACTIVE = true;
                _unitOfWork.US_USER_ROLE.Add(_obj);
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageUserRole));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            DropDownFor_ManageUserRole();
            return View(_obj);
        }

        private void DropDownFor_ManageUserRole()
        {
            ViewBag.US_USER_ID = _unitOfWork.US_USER.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.USER_NAME });
            ViewBag.US_ROLE_ID = _unitOfWork.US_ROLE.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.ROLE_NAME });
        }

        public IActionResult GetAll()
        {
            var obj = _unitOfWork.US_USER_ROLE.GetAll(includeProperties: "US_USER,US_ROLE");
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(int id, int id1)
        {
            bool result = _unitOfWork.US_USER_ROLE.Delete(id, id1);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }

    }
}
