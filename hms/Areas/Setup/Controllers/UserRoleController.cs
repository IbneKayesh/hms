using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ViewBag.US_USER_ID = _unitOfWork.US_USER.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.USER_NAME });
            ViewBag.US_ROLE_ID = _unitOfWork.US_ROLE.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.ROLE_NAME });
            US_USER_ROLE _obj = new US_USER_ROLE();
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageUserRole(US_USER_ROLE _obj)
        {
            if (ModelState.IsValid)
            {
                _obj.IS_ACTIVE = true;
                _unitOfWork.US_USER_ROLE.Add(_obj);
                _unitOfWork.Save();
                TempData["msg"] = "Swal.fire('success','Role saved','success')";
                return RedirectToAction(nameof(ManageUserRole));
            }
            TempData["msg"] = "Swal.fire('error','Role saved failed','error')";
            return View(_obj);
        }
    }
}
