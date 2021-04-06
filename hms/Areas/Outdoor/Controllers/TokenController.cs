using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Outdoor.Controllers
{
    [Area("Outdoor")]
    public class TokenController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TokenController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult ManageToken(Int64? id)
        {
            DropDownFor_ManageToken();
            HP_TOKEN _obj = new HP_TOKEN();
            _obj.TOKEN_DATE = DateTime.Now;
            if (id != null)
            {
                _obj = _unitOfWork.HP_TOKEN.GetFirstOrDefult(x => x.ID == id);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageToken(HP_TOKEN _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    var a = _obj.TOKEN_DATE.ToString("dd/MM/yyyy");

                    var b = _obj.TOKEN_DATE.ToShortDateString();

                    _obj.SERIAL_NO = _unitOfWork.HP_TOKEN.GetAll(x => x.TOKEN_DATE.ToShortDateString() == _obj.TOKEN_DATE.ToShortDateString()).Max(x => x.SERIAL_NO) + 1;
                    _obj.IS_ACTIVE = true;
                    _unitOfWork.HP_TOKEN.Add(_obj);
                }
                else
                {
                    _unitOfWork.HP_TOKEN.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageToken));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            DropDownFor_ManageToken();
            _obj.ID = 0;
            return View(_obj);
        }
        private void DropDownFor_ManageToken()
        {
            ViewBag.HS_DOCTOR_ID = _unitOfWork.HS_DOCTOR.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.DOCTOR_NAME });
        }
        public IActionResult GetAll()
        {
            var obj = _unitOfWork.HP_TOKEN.GetAll();
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(Int64 id)
        {
            bool result = _unitOfWork.HP_TOKEN.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }
    }
}
