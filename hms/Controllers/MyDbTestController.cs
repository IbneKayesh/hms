using hms.DataAccess;
using hms.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hms.Controllers
{
    public class MyDbTestController : Controller
    {
        private readonly IRawSql _db;
        public MyDbTestController(IRawSql db)
        {
            _db = db;
        }
        public IActionResult ExecuteSqlCommand()
        {
            var p1 = new SqlParameter("@p1", "New Value");
            _db.ExecuteSqlCommand(query: @"update US_UNIT SET UNIT_NAME=@p1 WHERE ID=2", parameters: new object[] { p1 });
            return View();
        }
    }
}
