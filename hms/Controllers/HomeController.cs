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
            //return View();

            try
            {
                int UserId = HttpContext.Session.GetInt32("sessionID") ?? 0;
                if (UserId == 0)
                {
                    return RedirectToAction(nameof(Login));
                }

                List<US_USER_MODULE_ROLE_MENU_VM> _obj = SessionHelper.GetObjectFromJson<List<US_USER_MODULE_ROLE_MENU_VM>>(HttpContext.Session, "_all_menus");
                if (_obj == null)
                {
                    _obj = (from cm in _unitOfWork.US_CHILD_MENU.GetAll(x => x.IS_ACTIVE == true)
                            join pm in _unitOfWork.US_PARENT_MENU.GetAll(x => x.IS_ACTIVE == true) on cm.US_PARENT_MENU_ID equals pm.ID
                            join md in _unitOfWork.US_MODULE.GetAll(x => x.IS_ACTIVE == true) on cm.US_MODULE_ID equals md.ID
                            join rm in _unitOfWork.US_ROLE_MENU.GetAll(x => x.IS_ACTIVE == true) on cm.ID equals rm.US_CHILD_MENU_ID
                            join ur in _unitOfWork.US_USER_ROLE.GetAll(x => x.IS_ACTIVE == true && x.US_USER_ID == UserId) on rm.US_ROLE_ID equals ur.US_ROLE_ID
                            select new US_USER_MODULE_ROLE_MENU_VM
                            {
                                Module_Id = md.ID,
                                Module_Icon = md.MODULE_ICON,
                                Module_Name = md.MODULE_NAME,
                                View_Order = md.VIEW_ORDER,
                                Module_Controller = md.CONTROLLER_NAME,
                                Module_Method = md.METHOD_NAME,

                                Parent_Name = pm.PARENT_NAME,
                                Parent_Icon = pm.PARENT_ICON,

                                Child_Id = cm.ID,
                                Child_Icon = cm.CHILD_ICON,
                                Child_Name = cm.CHILD_NAME,
                                Area_Name = cm.AREA_NAME,
                                Controller_Name = cm.CONTROLLER_NAME,
                                Action_Name = cm.ACTION_NAME
                            }).Distinct().ToList();
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "_all_menus", _obj);
                }
                List<US_LEADERBOARD_MODULE_VM> obj = (_obj.GroupBy(x => x.Module_Id)
                                                       .Select(g => new
                                                       US_LEADERBOARD_MODULE_VM
                                                       {
                                                           Module_Id = g.Key,
                                                           Module_Icon = g.First().Module_Icon,
                                                           Module_Name = g.First().Module_Name,
                                                           View_Order = g.First().View_Order,
                                                           Module_Controller = g.First().Module_Controller,
                                                           Module_Method = g.First().Module_Method
                                                       }
                                                       )).ToList();
                if (_obj == null)
                {
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "_all_modules", _obj.ToList());
                }
                return View(obj);
            }
            catch { return RedirectToAction(nameof(Login)); }
        }

        public IActionResult IndexOptions(int id)
        {
            List<US_USER_MODULE_ROLE_MENU_VM> _obj = SessionHelper.GetObjectFromJson<List<US_USER_MODULE_ROLE_MENU_VM>>(HttpContext.Session, "_all_menus");
            List<US_LEADERBOARD_MODULE_VM> obj = new List<US_LEADERBOARD_MODULE_VM>();
            if (_obj != null)
            {
                obj = (_obj.GroupBy(x => x.Module_Id)
                                                  .Select(g => new
                                                  US_LEADERBOARD_MODULE_VM
                                                  {
                                                      Module_Id = g.Key,
                                                      Module_Icon = g.First().Module_Icon,
                                                      Module_Name = g.First().Module_Name,
                                                      View_Order = g.First().View_Order,
                                                      Module_Controller = g.First().Module_Controller,
                                                      Module_Method = g.First().Module_Method
                                                  }
                                                  )).ToList();
                List<US_CHILD_MENU_VM> data = (_obj.Where(x => x.Module_Id == id)
                    .Select(s =>
                    new US_CHILD_MENU_VM
                    {
                        PARENT_NAME = s.Parent_Name,
                        PARENT_ICON = s.Parent_Icon,
                        AREA_NAME = s.Area_Name,
                        CONTROLLER_NAME = s.Controller_Name,
                        ACTION_NAME = s.Action_Name,
                        CHILD_ICON = s.Child_Icon,
                        CHILD_NAME = s.Child_Name
                    }
                    )).ToList();
                SessionHelper.SetObjectAsJson(HttpContext.Session, "_menus", data.DistinctBy(x => x.CHILD_NAME));
            }
            return View("Index", obj);
        }

        //[AllowAnonymous]
        public IActionResult Login(string nexturl)
        {
            //FormsAuthentication.SignOut();
            //ViewBag.ReturnUrl = returnUrl;
            US_USER obj = new US_USER();
            obj.LOGIN_ID = "admin";
            obj.PASSWORD = "a";
            return View(obj);
        }


        //[AllowAnonymous]
        [HttpPost]
        public IActionResult Login(US_USER _obj, string nexturl)
        {
            try
            {
                //FormsAuthentication.SetAuthCookie(user.LOGIN_ID.ToUpper().Trim(), false);
                if (_obj.LOGIN_ID == null || _obj.PASSWORD ==null)
                {
                    TempData["message"] = "Enter Valid Information !!!";
                    return View(_obj);
                }
                string userId = _obj.LOGIN_ID.ToLower().Trim();
                string userPass = TextEncryption.EncryptionWithSh(_obj.PASSWORD);

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
                    //LeaderBoard();
                    Index();
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

        //public IActionResult LeaderBoard()
        //{
        //    try
        //    {
        //        int UserId = HttpContext.Session.GetInt32("sessionID") ?? 0;
        //        if (UserId == 0)
        //        {
        //            return RedirectToAction(nameof(Login));
        //        }

        //        List<US_USER_MODULE_ROLE_MENU_VM> _obj = SessionHelper.GetObjectFromJson<List<US_USER_MODULE_ROLE_MENU_VM>>(HttpContext.Session, "_all_menus");
        //        if (_obj == null)
        //        {
        //            _obj = (from cm in _unitOfWork.US_CHILD_MENU.GetAll(x => x.IS_ACTIVE == true)
        //                    join pm in _unitOfWork.US_PARENT_MENU.GetAll(x => x.IS_ACTIVE == true) on cm.US_PARENT_MENU_ID equals pm.ID
        //                    join md in _unitOfWork.US_MODULE.GetAll(x => x.IS_ACTIVE == true) on cm.US_MODULE_ID equals md.ID
        //                    join rm in _unitOfWork.US_ROLE_MENU.GetAll(x => x.IS_ACTIVE == true) on cm.ID equals rm.US_CHILD_MENU_ID
        //                    join ur in _unitOfWork.US_USER_ROLE.GetAll(x => x.IS_ACTIVE == true && x.US_USER_ID == UserId) on rm.US_ROLE_ID equals ur.US_ROLE_ID
        //                    select new US_USER_MODULE_ROLE_MENU_VM
        //                    {
        //                        Module_Id = md.ID,
        //                        Module_Icon = md.MODULE_ICON,
        //                        Module_Name = md.MODULE_NAME,
        //                        View_Order = md.VIEW_ORDER,
        //                        Module_Controller = md.CONTROLLER_NAME,
        //                        Module_Method = md.METHOD_NAME,

        //                        Parent_Name = pm.PARENT_NAME,
        //                        Parent_Icon = pm.PARENT_ICON,

        //                        Child_Id = cm.ID,
        //                        Child_Icon = cm.CHILD_ICON,
        //                        Child_Name = cm.CHILD_NAME,
        //                        Area_Name = cm.AREA_NAME,
        //                        Controller_Name = cm.CONTROLLER_NAME,
        //                        Action_Name = cm.ACTION_NAME
        //                    }).Distinct().ToList();
        //            SessionHelper.SetObjectAsJson(HttpContext.Session, "_all_menus", _obj);
        //        }
        //        List<US_LEADERBOARD_MODULE_VM> obj = (_obj.GroupBy(x => x.Module_Id)
        //                                               .Select(g => new
        //                                               US_LEADERBOARD_MODULE_VM
        //                                               {
        //                                                   Module_Id = g.Key,
        //                                                   Module_Icon = g.First().Module_Icon,
        //                                                   Module_Name = g.First().Module_Name,
        //                                                   View_Order = g.First().View_Order,
        //                                                   Module_Controller = g.First().Module_Controller,
        //                                                   Module_Method = g.First().Module_Method
        //                                               }
        //                                               )).ToList();
        //        if (_obj == null)
        //        {
        //            SessionHelper.SetObjectAsJson(HttpContext.Session, "_all_modules", _obj.ToList());
        //        }
        //        return View(obj);
        //    }
        //    catch { return RedirectToAction(nameof(Login)); }
        //}

        //public IActionResult LeaderBoardOptions(int id)
        //{
        //    List<US_USER_MODULE_ROLE_MENU_VM> _obj = SessionHelper.GetObjectFromJson<List<US_USER_MODULE_ROLE_MENU_VM>>(HttpContext.Session, "_all_menus");
        //    List<US_LEADERBOARD_MODULE_VM> obj = new List<US_LEADERBOARD_MODULE_VM>();
        //    if (_obj != null)
        //    {
        //        obj = (_obj.GroupBy(x => x.Module_Id)
        //                                          .Select(g => new
        //                                          US_LEADERBOARD_MODULE_VM
        //                                          {
        //                                              Module_Id = g.Key,
        //                                              Module_Icon = g.First().Module_Icon,
        //                                              Module_Name = g.First().Module_Name,
        //                                              View_Order = g.First().View_Order,
        //                                              Module_Controller = g.First().Module_Controller,
        //                                              Module_Method = g.First().Module_Method
        //                                          }
        //                                          )).ToList();
        //        List<US_CHILD_MENU_VM> data = (_obj.Where(x => x.Module_Id == id)
        //            .Select(s =>
        //            new US_CHILD_MENU_VM
        //            {
        //                PARENT_NAME = s.Parent_Name,
        //                PARENT_ICON = s.Parent_Icon,
        //                AREA_NAME = s.Area_Name,
        //                CONTROLLER_NAME = s.Controller_Name,
        //                ACTION_NAME = s.Action_Name,
        //                CHILD_ICON = s.Child_Icon,
        //                CHILD_NAME = s.Child_Name
        //            }
        //            )).ToList();
        //        SessionHelper.SetObjectAsJson(HttpContext.Session, "_menus", data.DistinctBy(x => x.CHILD_NAME));
        //    }
        //    return View("LeaderBoard", obj);
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
