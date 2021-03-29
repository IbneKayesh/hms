using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    //[Route("Setup/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageUser()
        {
            ViewBag.US_GENDER_ID = _unitOfWork.US_GENDER.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.GENDER_NAME });
            ViewBag.US_RELIGION_ID = _unitOfWork.US_RELIGION.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.RELIGION_NAME });
            ViewBag.US_BLOOD_GROUP_ID = _unitOfWork.US_BLOOD_GROUP.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.BLOOD_GROUP_NAME });
            ViewBag.US_MARITAIL_STATUS_ID = _unitOfWork.US_MARITAIL_STATUS.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.MARITAIL_STATUS_NAME });
            ViewBag.US_TYPE_ID = _unitOfWork.US_TYPE.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.TYPE_NAME });
            US_USER _obj = new US_USER();
            _obj.DATE_OF_BIRTH = DateTime.Now;
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageUser(US_USER _obj)
        {
            if (ModelState.IsValid)
            {
                _obj.IS_ACTIVE = true;
                _unitOfWork.US_USER.Add(_obj);
                _unitOfWork.Save();
                TempData["msg"] = "Swal.fire('success','Role saved','success')";
                return RedirectToAction(nameof(ManageUser));
            }
            TempData["msg"] = "Swal.fire('error','Role saved failed','error')";
            return View(_obj);
        }
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyLoginId(string LOGIN_ID)
        {
            var regex = new Regex(@"^[a-zA-Z0-9]*$");
            var r = regex.Match(LOGIN_ID);
            if (!r.Success)
            {
                return Json($"Login Id {LOGIN_ID} is not available");
            }
            if (_unitOfWork.US_USER.GetAll(x => x.LOGIN_ID == LOGIN_ID).Any())
            {
                return Json($"Login Id {LOGIN_ID} is not available.");
            }
            return Json(true);
        }
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyPassword(string PASSWORD)
        {
            var regex = new Regex(@"^(?=.*\d)(?=.*[a-zA-Z])(?=.*[\W_]).{6}");
            var r = regex.Match(PASSWORD);
            if (!r.Success)
            {
                return Json($"Password {PASSWORD} is too weak [6Char, 1Special Char, 1Number]");
            }
            return Json(true);
        }

    }
}
