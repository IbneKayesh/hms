using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    [hmsAuthorization(controller_id = 5)]
    public class RoleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageRole(int? id)
        {
            US_ROLE _obj = new US_ROLE();
            if (id != null)
            {
                _obj = _unitOfWork.US_ROLE.GetFirstOrDefult(x => x.ID == id);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageRole(US_ROLE _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    _obj.ID = _unitOfWork.US_ROLE.GetAll().Max(x => x.ID) + 1;
                    _obj.IS_ACTIVE = true;
                    _unitOfWork.US_ROLE.Add(_obj);
                }
                else
                {
                    _unitOfWork.US_ROLE.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageRole));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            _obj.ID = 0;
            return View(_obj);
        }

        public IActionResult GetAll()
        {
            var obj = _unitOfWork.US_ROLE.GetAll();
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(int id)
        {
            bool result = _unitOfWork.US_ROLE.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyRoleName(string ROLE_NAME, int ID)
        {
            if (ID != 0)
            {
                var obj = _unitOfWork.US_ROLE.Get(ID);
                if (obj.IS_ACTIVE == false && obj.ROLE_NAME == ROLE_NAME)
                {
                    return Json(true);
                }
            }
            bool result = _unitOfWork.US_ROLE.GetAll(x => x.ROLE_NAME == ROLE_NAME).Any();
            return Json(!result);
        }

        //[AcceptVerbs("GET", "POST")]
        //public IActionResult VerifyRoleId(int ID)
        //{
        //    if (_unitOfWork.US_ROLE.GetAll(x => x.ID == ID).Any())
        //    {
        //       int _maxId =  _unitOfWork.US_ROLE.GetMaxId();
        //        return Json($"Role {ID} is already in use. {_maxId} will be next Id");
        //    }
        //    return Json(true);
        //}
    }
}
