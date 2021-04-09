using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    [hmsAuthorization(controller_id = 6)]
    public class ChildMenuController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChildMenuController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageChildMenu(int? id)
        {
            DropDownFor_ManageChildMenu();
            US_CHILD_MENU _obj = new US_CHILD_MENU();
            if (id != null)
            {
                _obj = _unitOfWork.US_CHILD_MENU.Get(id.Value);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageChildMenu(US_CHILD_MENU _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    _obj.ID = _unitOfWork.US_CHILD_MENU.GetAll().Max(x => x.ID) + 1;
                    _obj.IS_ACTIVE = true;
                    _unitOfWork.US_CHILD_MENU.Add(_obj);
                }
                else
                {
                    _unitOfWork.US_CHILD_MENU.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageChildMenu));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            DropDownFor_ManageChildMenu();
            _obj.ID = 0;
            return View(_obj);
        }

        private void DropDownFor_ManageChildMenu()
        {
            ViewBag.US_MODULE_ID = _unitOfWork.US_MODULE.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.MODULE_NAME });
            ViewBag.US_PARENT_MENU_ID = _unitOfWork.US_PARENT_MENU.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.PARENT_NAME });
        }
        public IActionResult GetAll()
        {
            var obj = _unitOfWork.US_CHILD_MENU.GetAll(includeProperties: "US_MODULE,US_PARENT_MENU");
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(int id)
        {
            bool result = _unitOfWork.US_CHILD_MENU.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyChildMenuName(string CHILD_NAME, int ID)
        {
            if (ID != 0)
            {
                var obj = _unitOfWork.US_CHILD_MENU.Get(ID);
                if (obj.IS_ACTIVE == false && obj.CHILD_NAME == CHILD_NAME)
                {
                    return Json(true);
                }
            }
            bool result = _unitOfWork.US_CHILD_MENU.GetAll(x => x.CHILD_NAME == CHILD_NAME).Any();
            return Json(!result);
        }
    }
}
