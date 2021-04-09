using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    [hmsAuthorization(controller_id = 7)]
    public class ModuleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ModuleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageModule(int? id)
        {
            US_MODULE _obj = new US_MODULE();
            if (id != null)
            {
                _obj = _unitOfWork.US_MODULE.Get(id.Value);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageModule(US_MODULE _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    _obj.ID = _unitOfWork.US_MODULE.GetAll().Max(x => x.ID) + 1;
                _obj.IS_ACTIVE = true;
                _unitOfWork.US_MODULE.Add(_obj);
                }
                else
                {
                    _unitOfWork.US_MODULE.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageModule));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            _obj.ID = 0;
            return View(_obj);
        }

        public IActionResult GetAll()
        {
            var obj = _unitOfWork.US_MODULE.GetAll();
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(int id)
        {
            bool result = _unitOfWork.US_MODULE.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyModuleName(string MODULE_NAME, int ID)
        {
            if (ID != 0)
            {
                var obj = _unitOfWork.US_MODULE.Get(ID);
                if (obj.IS_ACTIVE == false && obj.MODULE_NAME == MODULE_NAME)
                {
                    return Json(true);
                }
            }
            bool result = _unitOfWork.US_MODULE.GetAll(x => x.MODULE_NAME == MODULE_NAME).Any();
            return Json(!result);
        }
    }
}
