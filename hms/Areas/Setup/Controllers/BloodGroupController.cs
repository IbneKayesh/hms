using hms.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    public class BloodGroupController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BloodGroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult ManageBloodGroup()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            var obj = _unitOfWork.US_BLOOD_GROUP.GetAll();
            return Json(new { data = obj });
        }
    }
}
