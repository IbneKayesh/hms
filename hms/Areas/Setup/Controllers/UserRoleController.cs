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
    public class UserRoleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserRoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageUserRole()
        {
            US_USER_ROLE _obj = new US_USER_ROLE();
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageUserRole(US_USER_ROLE _obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.US_USER_ROLE.Add(_obj);
                _unitOfWork.Save();
                return RedirectToAction(nameof(ManageUserRole));
            }
            return View(_obj);
        }
    }
}
