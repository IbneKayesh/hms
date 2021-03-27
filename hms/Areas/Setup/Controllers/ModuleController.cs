using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    public class ModuleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ModuleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult ManageModule()
        {
            US_MODULE _obj = new US_MODULE();
            return View(_obj);
        }
        [HttpPost]
        public IActionResult ManageModule(US_MODULE _obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.US_MODULE.Add(_obj);
                _unitOfWork.Save();
                return RedirectToAction(nameof(ManageModule));
            }
            return View(_obj);
        }
    }
}
