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
                _unitOfWork.US_ROLE.Add(_obj);
                _unitOfWork.Save();
                return RedirectToAction(nameof(ManageRole));
            }
            return View(_obj);
        }
    }
}
