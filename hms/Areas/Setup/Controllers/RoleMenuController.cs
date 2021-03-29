using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.DataModel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult ManageRoleMenu()
        {
            //ViewBag.US_ROLE_ID = _unitOfWork.US_ROLE.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.ROLE_NAME });
            //ViewBag.US_CHILD_MENU_ID = _unitOfWork.US_CHILD_MENU.GetAll().Select(i => new SelectListItem { Value = i.ID.ToString(), Text = i.CHILD_NAME });
            //US_ROLE_MENU _obj = new US_ROLE_MENU();
            //return View(_obj);
            var _obj = (from a in _unitOfWork.US_ROLE_MENU.GetAll()
                        join c in _unitOfWork.US_CHILD_MENU.GetAll() on a.US_CHILD_MENU_ID equals c.ID
                        join b in _unitOfWork.US_ROLE.GetAll() on a.US_ROLE_ID equals b.ID
                        join d in _unitOfWork.US_PARENT_MENU.GetAll() on c.US_PARENT_MENU_ID equals d.ID
                        select new US_ROLE_MENU_VM
                        {
                            Parent_Name = d.PARENT_NAME,
                            Parent_Icon = d.PARENT_ICON,
                            Child_Id = c.ID,
                            Child_Name = c.CHILD_NAME,
                            Child_Icon = c.CHILD_ICON,
                            Active = a.IS_ACTIVE,
                        }
                        ).ToList();
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageRoleMenu(US_ROLE_MENU _obj)
        {
            if (ModelState.IsValid)
            {
                _obj.IS_ACTIVE = true;
                _unitOfWork.US_ROLE_MENU.Add(_obj);
                _unitOfWork.Save();
                TempData["msg"] = "Swal.fire('success','Role saved','success')";
                return RedirectToAction(nameof(ManageRoleMenu));
            }
            TempData["msg"] = "Swal.fire('error','Role saved failed','error')";
            return View(_obj);
        }
    }
}
