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
    public class ChildMenuController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChildMenuController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageChildMenu()
        {
            //ViewBag.US_MODULE_ID = _unitOfWork.US_MODULE.GetAll();
            //ViewBag.US_PARENT_MENU_ID = _unitOfWork.US_PARENT_MENU.GetAll();
            US_CHILD_MENU _obj = new US_CHILD_MENU();
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageChildMenu(US_CHILD_MENU _obj)
        {
            if (ModelState.IsValid)
            {
                _obj.ID = _unitOfWork.US_CHILD_MENU.GetAll().Max(x => x.ID) + 1;
                _obj.IS_ACTIVE = true;
                _unitOfWork.US_CHILD_MENU.Add(_obj);
                _unitOfWork.Save();
                return RedirectToAction(nameof(ManageChildMenu));
            }
            return View(_obj);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyChildMenuName(string CHILD_NAME)
        {
            if (_unitOfWork.US_CHILD_MENU.GetAll(x => x.CHILD_NAME == CHILD_NAME).Any())
            {
                return Json($"Name {CHILD_NAME} is already in use.");
            }
            return Json(true);
        }
    }
}
