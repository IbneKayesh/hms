using hms.DataAccess.Repository.IRepository;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    [hmsAuthorization(controller_id = 3)]
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
