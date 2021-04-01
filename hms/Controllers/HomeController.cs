using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
using hms.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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

        public IActionResult LeaderBoard()
        {
            IEnumerable<US_MODULE> _data = _unitOfWork.US_MODULE.GetAll(x => x.IS_ACTIVE == true);            
            return View(_data);
        }

        public IActionResult LeaderBoardOptions(int id)
        {
            IEnumerable<US_CHILD_MENU> _data1 = _unitOfWork.US_CHILD_MENU
                                               .GetAll(x => x.IS_ACTIVE == true,includeProperties:"US_PARENT_MENU")
                                               .Where(y=>y.US_MODULE_ID==id);
            TempData["_menu"] = _data1.ToList();

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
