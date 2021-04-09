using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.DataModel.ViewModels;
using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    [hmsAuthorization(controller_id = 4)]
    public class UserRoleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserRoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageUserRole(US_USER_ROLE_VM _obj)
        {
            if (string.IsNullOrWhiteSpace(_obj.UserId))
            {
                _obj = new US_USER_ROLE_VM();
            }
            else
            {
                var _obj1 = _unitOfWork.US_USER.GetFirstOrDefult(x => x.LOGIN_ID == _obj.UserId);
                if (_obj1 != null)
                {
                    var obj2 = (from r in _unitOfWork.US_ROLE.GetAll()

                                join u_r in _unitOfWork.US_USER_ROLE.GetAll().Where(x => x.USER_ID == _obj1.ID) on r.ID equals u_r.ROLE_ID into u_r_s
                                from u_r_rslt in u_r_s.DefaultIfEmpty()

                                select new user_role_list_vm
                                {
                                    RoleId = r.ID,
                                    RoleName = r.ROLE_NAME,
                                    Active = u_r_rslt == null ? false : u_r_rslt.IS_ACTIVE
                                }
                         ).ToList();
                    _obj.USER_ID = _obj1.ID;
                    _obj.UserName = _obj1.USER_NAME;
                    _obj.user_role_list = obj2;
                }
            }
            return View(_obj);
        }

        [HttpGet]
        //need to change this method HttpPost
        public IActionResult UserRoleSetup(string post_data)
        {
            try
            {
                bool _save = false;
                var _post_data_vm = JsonConvert.DeserializeObject<List<post_data2_vm>>(post_data);
                var _obj1 = _unitOfWork.US_USER.GetFirstOrDefult(x => x.LOGIN_ID == _post_data_vm.FirstOrDefault().myuser);
                foreach (var item in _post_data_vm)
                {
                    var _obj = _unitOfWork.US_USER_ROLE.GetFirstOrDefult(x => x.ROLE_ID == item.myrole && x.USER_ID == _obj1.ID);
                    if (_obj != null && _obj.IS_ACTIVE != item.mystate)
                    {
                        _obj.IS_ACTIVE = item.mystate;
                        _unitOfWork.US_USER_ROLE.Update(_obj);
                        _save = true;
                    }
                    else if (_obj == null && item.mystate == true)
                    {
                        US_USER_ROLE uS = new US_USER_ROLE();
                        uS.ROLE_ID = item.myrole;
                        uS.USER_ID = _obj1.ID;
                        _unitOfWork.US_USER_ROLE.Add(uS);
                        _save = true;
                    }
                    else
                    {
                        _save = false;
                    }
                    if (_save) { _unitOfWork.Save(); }
                }
                return Json(new { success = true, messages = SweetMsg._SaveSuccess });
            }
            catch
            {
                return Json(new { success = false, messages = SweetMsg._SaveError });
            }

        }






        //        DropDownFor_ManageUserRole();
        //        US_USER_ROLE _obj = new US_USER_ROLE();
        //            if (id != null && id1 != null)
        //            {
        //                _obj = _unitOfWork.US_USER_ROLE.GetFirstOrDefult(x => x.US_USER_ID == id && x.US_ROLE_ID == id1);
        //                if (_obj == null)
        //                {
        //                    TempData["msg"] = SweetMsg.SaveWarningOK();
        //                }
        //}


        [HttpPost]
        public IActionResult ManageUserRole(US_USER_ROLE _obj)
        {
            if (ModelState.IsValid)
            {
                _obj.IS_ACTIVE = true;
                _unitOfWork.US_USER_ROLE.Add(_obj);
                _unitOfWork.Save();
                TempData["msg"] = SweetMsg.SaveSuccess();
                return RedirectToAction(nameof(ManageUserRole));
            }
            TempData["msg"] = SweetMsg.SaveErrorOK();
            DropDownFor_ManageUserRole();
            return View(_obj);
        }

        private void DropDownFor_ManageUserRole()
        {
            ViewBag.US_USER_ID = _unitOfWork.US_USER.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.USER_NAME });
            ViewBag.US_ROLE_ID = _unitOfWork.US_ROLE.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.ROLE_NAME });
        }

        public IActionResult GetAll()
        {
            var obj = _unitOfWork.US_USER_ROLE.GetAll(includeProperties: "US_USER,US_ROLE");
            return Json(new { data = obj });
        }

        //[AcceptVerbs("PUT")]
        public IActionResult Remove(int id, int id1)
        {
            bool result = _unitOfWork.US_USER_ROLE.Delete(id, id1);
            if (result)
            {
                _unitOfWork.Save();
                return Json(new { success = true, messages = SweetMsg._DeleteSuccess });
            }
            return Json(new { success = false, messages = SweetMsg._DeleteError });
        }

    }
}
