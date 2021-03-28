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
    public class RoleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageRole()
        {
            US_ROLE _obj = new US_ROLE();
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageRole(US_ROLE _obj)
        {
            if (ModelState.IsValid)
            {
                _obj.ID = _unitOfWork.US_ROLE.GetAll().Max(x => x.ID) + 1;
                _obj.IS_ACTIVE = true;
                _unitOfWork.US_ROLE.Add(_obj);
                _unitOfWork.Save();
                TempData["msg"] = "Swal.fire('success','Role saved','success')";
                return RedirectToAction(nameof(ManageRole));
            }
            TempData["msg"] = "Swal.fire('error','Role saved failed','error')";
            return View(_obj);
        }

        //[AcceptVerbs("GET", "POST")]
        //public IActionResult VerifyRoleId(int ID)
        //{
        //    if (_unitOfWork.US_ROLE.GetAll(x => x.ID == ID).Any())
        //    {
        //       int _maxId =  _unitOfWork.US_ROLE.GetMaxId();
        //        return Json($"Role {ID} is already in use. {_maxId} will be next Id");
        //    }
        //    return Json(true);
        //}

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyRoleName(string ROLE_NAME)
        {
            if (_unitOfWork.US_ROLE.GetAll(x => x.ROLE_NAME == ROLE_NAME).Any())
            {
                return Json($"Role {ROLE_NAME} is already in use.");
            }
            return Json(true);
        }
    }
}
