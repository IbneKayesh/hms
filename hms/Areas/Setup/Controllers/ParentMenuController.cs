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
                _unitOfWork.US_PARENT_MENU.Add(_obj);
                _unitOfWork.Save();
                return RedirectToAction(nameof(ManageParentMenu));
            }
            return View(_obj);
        }
    }
}
