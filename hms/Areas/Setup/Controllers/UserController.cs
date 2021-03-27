﻿using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
            US_USER _obj = new US_USER();
            _obj.DATE_OF_BIRTH = DateTime.Now;
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageUser(US_USER _obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.US_USER.Add(_obj);
                _unitOfWork.Save();
                return RedirectToAction(nameof(ManageUser));
            }
            return View(_obj);
        }

    }
}
