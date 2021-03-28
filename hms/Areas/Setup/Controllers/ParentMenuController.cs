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
    public class ParentMenuController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ParentMenuController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageParentMenu()
        {
            US_PARENT_MENU _obj = new US_PARENT_MENU();
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageParentMenu(US_PARENT_MENU _obj)
        {
            if (ModelState.IsValid)
            {
                _obj.ID = _unitOfWork.US_PARENT_MENU.GetAll().Max(x => x.ID) + 1;
                _obj.IS_ACTIVE = true;
                _unitOfWork.US_PARENT_MENU.Add(_obj);
                _unitOfWork.Save();
                return RedirectToAction(nameof(ManageParentMenu));
            }
            return View(_obj);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyParentMenuName(string PARENT_NAME)
        {
            if (_unitOfWork.US_PARENT_MENU.GetAll(x => x.PARENT_NAME == PARENT_NAME).Any())
            {
                return Json($"Name {PARENT_NAME} is already in use.");
            }
            return Json(true);
        }
    }
}
