using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    [hmsAuthorization(controller_id = 8)]
    public class ParentMenuController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ParentMenuController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageParentMenu(int? id)
        {
            US_PARENT_MENU _obj = new US_PARENT_MENU();
            if (id != null)
            {
                _obj = _unitOfWork.US_PARENT_MENU.Get(id.Value);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageParentMenu(US_PARENT_MENU _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    _obj.ID = _unitOfWork.US_PARENT_MENU.GetAll().Max(x => x.ID) + 1;
                    _obj.IS_ACTIVE = true;
                    _unitOfWork.US_PARENT_MENU.Add(_obj);
                }
                else
                {
                    _unitOfWork.US_PARENT_MENU.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageParentMenu));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            _obj.ID = 0;
            return View(_obj);
        }
        public IActionResult GetAll()
        {
            var obj = _unitOfWork.US_PARENT_MENU.GetAll();
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(int id)
        {
            bool result = _unitOfWork.US_PARENT_MENU.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyParentMenuName(string PARENT_NAME, int ID)
        {
            if (ID != 0)
            {
                var obj = _unitOfWork.US_PARENT_MENU.Get(ID);
                if (obj.IS_ACTIVE == false && obj.PARENT_NAME == PARENT_NAME)
                {
                    return Json(true);
                }
            }
            bool result = _unitOfWork.US_PARENT_MENU.GetAll(x => x.PARENT_NAME == PARENT_NAME).Any();
            return Json(!result);
        }
    }
}
