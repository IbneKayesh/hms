using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Areas.Setup.Controllers
{
    [Area("Setup")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
