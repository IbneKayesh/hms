using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.DataModel.ViewModels;
using hms.Models;
using hms.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace hms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            //FormsAuthentication.SignOut();
            //ViewBag.ReturnUrl = returnUrl;
            return View();
        }


        //[AllowAnonymous]
        [HttpPost]
        public IActionResult Login(US_USER _obj, string nexturl)
        {
            try
            {
                //FormsAuthentication.SetAuthCookie(user.LOGIN_ID.ToUpper().Trim(), false);
                string userId = _obj.LOGIN_ID.ToLower().Trim();
                string userPass = _obj.PASSWORD;

                US_USER _data = _unitOfWork.US_USER.GetFirstOrDefult(x => x.LOGIN_ID.ToLower() == userId && x.PASSWORD == userPass);
                if (_data == null)
                {
                    TempData["message"] = "Enter Valid Information !!!";
                    return View(_obj);
                }
                else
                {
                    HttpContext.Session.SetInt32("sessionID", _data.ID);
                    HttpContext.Session.SetString("sessionLOGIN_ID", _data.LOGIN_ID);
                    //HttpContext.Session.SetString("sessionPASSWORD", _data.PASSWORD);
                }
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message.ToString();
                return View(_obj);
            }

            return RedirectToLocal(nexturl);
        }

        private IActionResult RedirectToLocal(string nexturl)
        {
            if (Url.IsLocalUrl(nexturl))
            {
                return Redirect(nexturl);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            //HttpContext.Session.Remove("sessionKeyInt");
            //HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        //[hmsAuthorization(role_name ="abc")]
        public IActionResult LeaderBoard()
        {
            //IEnumerable<US_MODULE> _data = _unitOfWork.US_MODULE.GetAll(x => x.IS_ACTIVE == true);
            //return View(_data);

            var obj = (from rm in _unitOfWork.US_ROLE_MENU.GetAll()
                       join ur in _unitOfWork.US_USER_ROLE.GetAll().Where(x => x.US_USER_ID == HttpContext.Session.GetInt32("sessionID") && x.IS_ACTIVE == true) on rm.US_ROLE_ID equals ur.US_ROLE_ID
                       join cm in _unitOfWork.US_CHILD_MENU.GetAll().Where(x => x.IS_ACTIVE == true) on rm.US_CHILD_MENU_ID equals cm.ID
                       join pm in _unitOfWork.US_PARENT_MENU.GetAll().Where(x => x.IS_ACTIVE == true) on cm.US_PARENT_MENU_ID equals pm.ID
                       join m in _unitOfWork.US_MODULE.GetAll().Where(x => x.IS_ACTIVE == true) on cm.US_MODULE_ID equals m.ID
                       select new US_USER_MODULE_ROLE_MENU_VM
                       {
                           Module_Id = m.ID,
                           Module_Icon = m.MODULE_ICON,
                           Module_Name = m.MODULE_NAME,
                           View_Order = m.VIEW_ORDER,
                           Method_Name = m.METHOD_NAME,
                           Parent_name = pm.PARENT_NAME,
                           Parent_Icon = cm.CHILD_ICON,
                           Child_Id = cm.ID,
                           Child_Icon = cm.CHILD_ICON,
                           Child_Name = cm.CHILD_NAME,
                           Area_Name = cm.AREA_NAME,
                           Controller_Name = cm.CONTROLLER_NAME,
                           Action_Name = cm.ACTION_NAME
                       }
                       ).ToList();



            //var obj = (from rm in _unitOfWork.US_ROLE_MENU.GetAll()
            //           join ur in _unitOfWork.US_USER_ROLE.GetAll().Where(x => x.US_USER_ID == HttpContext.Session.GetInt32("sessionID") && x.IS_ACTIVE == true) on rm.US_ROLE_ID equals ur.US_ROLE_ID
            //           join cm in _unitOfWork.US_CHILD_MENU.GetAll().Where(x => x.IS_ACTIVE == true) on rm.US_CHILD_MENU_ID equals cm.ID
            //           join pm in _unitOfWork.US_PARENT_MENU.GetAll().Where(x => x.IS_ACTIVE == true) on cm.US_PARENT_MENU_ID equals pm.ID
            //           join m in _unitOfWork.US_MODULE.GetAll().Where(x => x.IS_ACTIVE == true) on cm.US_MODULE_ID equals m.ID
            //           select new US_USER_MODULE_ROLE_MENU_VM
            //           {
            //               Module_Id = m.ID,
            //               Module_Icon = m.MODULE_ICON,
            //               Module_Name = m.MODULE_NAME,
            //               View_Order = m.VIEW_ORDER,
            //               Method_Name = m.METHOD_NAME,
            //               Controller_Name = cm.CONTROLLER_NAME,
            //               Action_Name = cm.ACTION_NAME
            //           }
            //          ).ToList();

            //SessionHelper.SetObjectAsJson(HttpContext.Session, "_menus", obj.ToList());

            return View(obj);
        }

        public IActionResult LeaderBoardOptions(US_USER_MODULE_ROLE_MENU_VM obj) //(int id)
        {
            //IEnumerable<US_CHILD_MENU> _data1 = _unitOfWork.US_CHILD_MENU
            //                                   .GetAll(x => x.IS_ACTIVE == true, includeProperties: "US_PARENT_MENU")
            //                                   .Where(y => y.US_MODULE_ID == id);
            //TempData["_menu"] = _data1.ToList();

            IEnumerable<US_CHILD_MENU> _data1 = _unitOfWork.US_CHILD_MENU
                                               .GetAll(x => x.IS_ACTIVE == true, includeProperties: "US_PARENT_MENU")
                                               .Where(y => y.US_MODULE_ID == obj.Module_Id);

            //===========================For Session==============
            SessionHelper.SetObjectAsJson(HttpContext.Session, "_menus", _data1.ToList());
            //===========================For Session==============

            IEnumerable<US_MODULE> _data = _unitOfWork.US_MODULE.GetAll(x => x.IS_ACTIVE == true);
            return View("LeaderBoard", _data);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
