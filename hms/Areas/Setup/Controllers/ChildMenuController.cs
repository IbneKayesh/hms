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
            US_CHILD_MENU _obj = new US_CHILD_MENU();
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageChildMenu(US_CHILD_MENU _obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.US_CHILD_MENU.Add(_obj);
                _unitOfWork.Save();
                return RedirectToAction(nameof(ManageChildMenu));
            }
            return View(_obj);
        }
    }
}
