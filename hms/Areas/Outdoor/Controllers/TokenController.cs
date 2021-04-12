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
                _obj = _unitOfWork.HP_TOKEN.Get(id.Value);
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
                    //var a = _obj.TOKEN_DATE.ToString("dd/MM/yyyy");
                    //var b = _obj.TOKEN_DATE.ToShortDateString();
                    var b = _obj.TOKEN_DATE.Date;

                    //var data = context.t_quoted_value.Where(x => x.region_name == "Hong Kong"
                    //&& DateTime.Compare(x.price_date.Value.Date, dt.Date) == 0)
                    //.ToList();
                    //db.Meals.Where(c => String.Format("{0:M/d/yyyy}", c.MealDate) == date && c.SessionID == SessionID && c.MealType == MealType).FirstOrDefault();

                    try
                    {
                        _obj.SERIAL_NO = _unitOfWork.HP_TOKEN.GetAll(x => x.TOKEN_DATE.Date == _obj.TOKEN_DATE.Date).Max(x => x.SERIAL_NO) + 1;
                    }
                    catch 
                    {
                        _obj.SERIAL_NO = 1;
                    }

                    //_obj.SERIAL_NO = _unitOfWork.HP_TOKEN.GetAll(x => x.TOKEN_DATE == _obj.TOKEN_DATE).Max(x => x.SERIAL_NO) + 1;
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
            ViewBag.EMPLOYEE_ID = _unitOfWork.HS_EMPLOYEE.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.EMPLOYEE_NAME });
        }
        public IActionResult GetAll()
        {
            var obj = _unitOfWork.HP_TOKEN.GetAll(includeProperties: "HS_DOCTOR").OrderByDescending(x => x.TOKEN_DATE);
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
