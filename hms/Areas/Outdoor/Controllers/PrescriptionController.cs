using hms.Utility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Outdoor.Controllers
{
    [Area("Outdoor")]
    public class PrescriptionController : Controller
    {
        public IActionResult Prescribe()
        {
            SideBarCollapse();
            return View();
        }
        private void SideBarCollapse()
        {
            TempData["sbc"] = SweetMsg._SideBarCollapse;
        }
    }
}
