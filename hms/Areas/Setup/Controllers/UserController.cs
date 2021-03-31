using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
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
        public IActionResult ManageUser(int? id)
        {
            DropDownFor_ManageUser();
            US_USER _obj = new US_USER();
            _obj.DATE_OF_BIRTH = DateTime.Now;
            if (id != null)
            {
                _obj = _unitOfWork.US_USER.GetFirstOrDefult(x => x.ID == id);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageUser(US_USER _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    _obj.PASSWORD = TextEncryption.TextEnc(_obj.PASSWORD);
                    _obj.IS_ACTIVE = true;
                    _unitOfWork.US_USER.Add(_obj);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(_obj.PASSWORD))
                    {
                        _obj.PASSWORD = TextEncryption.TextEnc(_obj.PASSWORD);
                    }
                    _unitOfWork.US_USER.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageUser));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            DropDownFor_ManageUser();
            return View(_obj);
        }
        private void DropDownFor_ManageUser()
        {
            ViewBag.US_GENDER_ID = _unitOfWork.US_GENDER.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.GENDER_NAME });
            ViewBag.US_RELIGION_ID = _unitOfWork.US_RELIGION.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.RELIGION_NAME });
            ViewBag.US_BLOOD_GROUP_ID = _unitOfWork.US_BLOOD_GROUP.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.BLOOD_GROUP_NAME });
            ViewBag.US_MARITAIL_STATUS_ID = _unitOfWork.US_MARITAIL_STATUS.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.MARITAIL_STATUS_NAME });
            ViewBag.US_TYPE_ID = _unitOfWork.US_TYPE.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.TYPE_NAME });
        }
        public IActionResult GetAll(string LOGIN_ID, string USER_NAME)
        {
            List<US_USER> obj = new List<US_USER>();
            if (!string.IsNullOrWhiteSpace(LOGIN_ID))
            {
                obj = _unitOfWork.US_USER.GetAll(x => x.LOGIN_ID == LOGIN_ID, includeProperties: "US_BLOOD_GROUP,US_TYPE").ToList();
            }
            else if (!string.IsNullOrWhiteSpace(USER_NAME))
            {
                obj = _unitOfWork.US_USER.GetAll(x => x.USER_NAME.ToLower().Contains(USER_NAME.ToLower()), includeProperties: "US_BLOOD_GROUP,US_TYPE").ToList();
            }
            else
            {
                obj = new List<US_USER>();
            }
            //obj = _unitOfWork.US_USER.GetAll(includeProperties: "US_BLOOD_GROUP,US_TYPE").ToList();
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(int id)
        {
            bool result = _unitOfWork.US_USER.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyLoginId(string LOGIN_ID, int ID)
        {
            var regex = new Regex(@"^[a-zA-Z0-9]*$");
            var r = regex.Match(LOGIN_ID);
            if (!r.Success)
            {
                return Json($"Login Id {LOGIN_ID} is not available");
            }

            if (ID != 0)
            {
                var obj = _unitOfWork.US_USER.Get(ID);
                if (obj.IS_ACTIVE == false && obj.LOGIN_ID == LOGIN_ID)
                {
                    return Json(true);
                }
            }
            bool result = _unitOfWork.US_USER.GetAll(x => x.LOGIN_ID == LOGIN_ID).Any();
            return Json(!result);

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
