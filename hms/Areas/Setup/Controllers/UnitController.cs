using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    //[Route("Setup/[controller]/[action]")]
    //[hmsAuthorization(controller_id = 10)]
    public class UnitController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;
        public UnitController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult ManageUnit(int? id)
        {
            US_UNIT _obj = new US_UNIT();
            if (id != null)
            {
                _obj = _unitOfWork.US_UNIT.Get(id.Value);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }

        [HttpPost]
        public IActionResult ManageUnit(US_UNIT _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    try
                    {
                        _obj.ID = _unitOfWork.US_UNIT.GetAll().Max(x => x.ID) + 1;
                    }
                    catch
                    {
                        _obj.ID = 1;
                    }                    
                    _obj.IS_ACTIVE = true;
                    _unitOfWork.US_UNIT.Add(_obj);
                }
                else
                {
                    _unitOfWork.US_UNIT.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageUnit));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            return View(_obj);
        }
        public IActionResult GetAll()
        {
            var obj = _unitOfWork.US_UNIT.GetAll();
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(int id)
        {
            bool result = _unitOfWork.US_UNIT.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyUnitName(string UNIT_NAME, int ID)
        {
            if (ID != 0)
            {
                var obj = _unitOfWork.US_UNIT.Get(ID);
                if (obj.IS_ACTIVE == false && obj.UNIT_NAME == UNIT_NAME)
                {
                    return Json(true);
                }
            }
            bool result = _unitOfWork.US_UNIT.GetAll(x => x.UNIT_NAME == UNIT_NAME).Any();
            return Json(!result);

        }
    }
}
