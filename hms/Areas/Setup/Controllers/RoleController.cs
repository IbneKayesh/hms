﻿using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Utility;
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
        public IActionResult ManageRole(int? id)
        {
            US_ROLE _obj = new US_ROLE();
            if (id != null)
            {
                _obj = _unitOfWork.US_ROLE.GetFirstOrDefult(x => x.ID == id);
                if (_obj == null)
                {
                    TempData["msg"] = SweetMsg.Warning("No data found");
                }
            }
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageRole(US_ROLE _obj)
        {
            if (ModelState.IsValid)
            {
                if (_obj.ID == 0)
                {
                    _obj.ID = _unitOfWork.US_ROLE.GetAll().Max(x => x.ID) + 1;
                    _obj.IS_ACTIVE = true;
                    _unitOfWork.US_ROLE.Add(_obj);
                }
                else
                {
                    _unitOfWork.US_ROLE.Update(_obj);
                }
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.Success("Role Saved");
                return RedirectToAction(nameof(ManageRole));
            }
            TempData["msg"] = SweetMsg.Success("Role saved failed");
            _obj.ID = 0;
            return View(_obj);
        }

        public IActionResult GetAll()
        {
            var obj = _unitOfWork.US_ROLE.GetAll();
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(int id)
        {
            bool result = _unitOfWork.US_ROLE.Delete(id);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = "Delete successful" });
            }
            return Json(new { success = false, messages = "Delete failed" });
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyRoleName(string ROLE_NAME)
        {
            bool result = _unitOfWork.US_ROLE.GetAll(x => x.ROLE_NAME == ROLE_NAME).Any();
            return Json(!result);
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
    }
}
