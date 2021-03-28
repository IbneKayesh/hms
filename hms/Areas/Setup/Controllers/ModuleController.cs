using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    public class ModuleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ModuleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageModule()
        {
            US_MODULE _obj = new US_MODULE();
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageModule(US_MODULE _obj)
        {
            if (ModelState.IsValid)
            {
                _obj.ID = _unitOfWork.US_MODULE.GetAll().Max(x => x.ID) + 1;
                _obj.IS_ACTIVE = true;
                _unitOfWork.US_MODULE.Add(_obj);
                _unitOfWork.Save();
                return RedirectToAction(nameof(ManageModule));
            }
            return View(_obj);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyModuleName(string MODULE_NAME)
        {
            if (_unitOfWork.US_MODULE.GetAll(x => x.MODULE_NAME == MODULE_NAME).Any())
            {
                return Json($"Name {MODULE_NAME} is already in use.");
            }
            return Json(true);
        }
    }
}
