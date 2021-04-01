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
    public class RoleMenuController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoleMenuController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageRoleMenu(int? Role)
        {
            ViewBag.Role = _unitOfWork.US_ROLE.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.ROLE_NAME });
            US_ROLE_MENU_VM _obj = new US_ROLE_MENU_VM();
            if (Role != null)
            {
                var obj = (from cm in _unitOfWork.US_CHILD_MENU.GetAll()
                           join pm in _unitOfWork.US_PARENT_MENU.GetAll() on cm.US_PARENT_MENU_ID equals pm.ID

                           join cm_rm in _unitOfWork.US_ROLE_MENU.GetAll().Where(x => x.US_ROLE_ID == Role) on cm.ID equals cm_rm.US_CHILD_MENU_ID into cm_rm_s
                           from cm_rm_rslt in cm_rm_s.DefaultIfEmpty()

                           select new US_ROLE_MENU_LIST_VM
                           {
                               Parent_Name = pm.PARENT_NAME,
                               Parent_Icon = pm.PARENT_ICON,
                               Child_Id = cm.ID,
                               Child_Name = cm.CHILD_NAME,
                               Child_Icon = cm.CHILD_ICON,
                               Active = cm_rm_rslt == null ? false : cm_rm_rslt.IS_ACTIVE
                           }
                          ).ToList();


                //var xobj = (from a in _unitOfWork.US_ROLE_MENU.GetAll().Where(x => x.US_ROLE_ID == Role)
                //            join c in _unitOfWork.US_CHILD_MENU.GetAll() on a.US_CHILD_MENU_ID equals c.ID
                //            join b in _unitOfWork.US_ROLE.GetAll() on a.US_ROLE_ID equals b.ID
                //            join d in _unitOfWork.US_PARENT_MENU.GetAll() on c.US_PARENT_MENU_ID equals d.ID
                //            select new US_ROLE_MENU_LIST_VM
                //            {
                //                Parent_Name = d.PARENT_NAME,
                //                Parent_Icon = d.PARENT_ICON,
                //                Child_Id = c.ID,
                //                Child_Name = c.CHILD_NAME,
                //                Child_Icon = c.CHILD_ICON,
                //                Active = a.IS_ACTIVE,
                //            }
                //       ).ToList();
                _obj.ROLE_MENU_LIST = obj;
            }
            return View(_obj);
        }

        //ViewBag.US_ROLE_ID = _unitOfWork.US_ROLE.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.ROLE_NAME });
        //ViewBag.US_CHILD_MENU_ID = _unitOfWork.US_CHILD_MENU.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.CHILD_NAME });

        [HttpGet]
        //need to change this method HttpPost
        public IActionResult RoleMenuSetup(string post_data)
        {
            try
            {
                var _post_data_vm = JsonConvert.DeserializeObject<List<post_data_vm>>(post_data);
                foreach (var item in _post_data_vm)
                {
                    var _obj = _unitOfWork.US_ROLE_MENU.GetFirstOrDefult(x => x.US_ROLE_ID == item.myrole && x.US_CHILD_MENU_ID == item.mymenu);
                    if (_obj != null && _obj.IS_ACTIVE != item.mystate)
                    {
                        _obj.IS_ACTIVE = item.mystate;
                        _unitOfWork.US_ROLE_MENU.Update(_obj);
                    }
                    else if (_obj == null && item.mystate == true)
                    {
                        US_ROLE_MENU uS = new US_ROLE_MENU();
                        uS.US_ROLE_ID = item.myrole;
                        uS.US_CHILD_MENU_ID = item.mymenu;
                        _unitOfWork.US_ROLE_MENU.Add(uS);
                    }
                    else
                    {
                        //do nothing
                    }
                    _unitOfWork.Save();
                }
                return Json(new { success = true, messages = SweetMsg._SaveSuccess });
            }
            catch
            {
                return Json(new { success = false, messages = SweetMsg._SaveError });
            }

        }

    }
}
