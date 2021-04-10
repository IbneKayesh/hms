using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Hospital.Controllers
{
    [Area("Hospital")]
    public class ItemController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult ManageItem(int? id)
        {
            DropDownFor_ManageItem();
            HS_ITEM _obj = new HS_ITEM();
            if (id != null)
            {
                _obj = _unitOfWork.HS_ITEM.Get(id.Value);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.SaveWarningOK();
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageItem(HS_ITEM _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    _obj.ID = _unitOfWork.HS_ITEM.GetAll().Max(x => x.ID) + 1;
                    _obj.IS_ACTIVE = true;
                    _unitOfWork.HS_ITEM.Add(_obj);
                }
                else
                {
                    _unitOfWork.HS_ITEM.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageItem));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            DropDownFor_ManageItem();
            _obj.ID = 0;
            return View(_obj);
        }

        private void DropDownFor_ManageItem()
        {
            ViewBag.US_UNIT_ID = _unitOfWork.US_UNIT.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.UNIT_NAME });
        }

        public IActionResult GetAll()
        {
            var obj = _unitOfWork.HS_ITEM.GetAll(includeProperties: "US_UNIT");
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(Int64 id)
        {
            bool result = _unitOfWork.HS_ITEM.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }


        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyItemName(string ITEM_NAME, Int64 ID)
        {
            if (ID != 0)
            {
                var obj = _unitOfWork.HS_ITEM.Get(ID);
                if (obj.IS_ACTIVE == false && obj.ITEM_NAME == ITEM_NAME)
                {
                    return Json(true);
                }
            }
            bool result = _unitOfWork.HS_ITEM.GetAll(x => x.ITEM_NAME == ITEM_NAME).Any();
            return Json(!result);
        }
    }
}
