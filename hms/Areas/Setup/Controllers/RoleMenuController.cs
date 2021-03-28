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
    public class RoleMenuController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoleMenuController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageRoleMenu()
        {
            US_ROLE_MENU _obj = new US_ROLE_MENU();
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageRoleMenu(US_ROLE_MENU _obj)
        {
            if (ModelState.IsValid)
            {
                _obj.IS_ACTIVE = true;
                _unitOfWork.US_ROLE_MENU.Add(_obj);
                _unitOfWork.Save();
                return RedirectToAction(nameof(ManageRoleMenu));
            }
            return View(_obj);
        }
    }
}
