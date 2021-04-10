using hms.DataAccess;
using hms.DataAccess.Repository;
using hms.DataAccess.Repository.IRepository;
using hms.DataModel;
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
        private readonly hmsDbContext db;
        public MyDbTestController(hmsDbContext _db)
        {
            db=_db;
        }
        public IActionResult ExecuteSqlCommand()
        {
            RawSql obj = new RawSql(db);
            var p1 = new SqlParameter("@p1", "New Value");
            obj.ExecuteSqlCommand(query: @"update US_UNIT SET UNIT_NAME=@p1 WHERE ID=2", parameters: new object[] { p1 });
            return View();
        }
        public IActionResult ExecuteSqlQuery()
        {
            ModelSql<US_UNIT> obj = new ModelSql<US_UNIT>(db);
            var _obj = obj.ExecuteSqlQuery(@"Select * FROM US_UNIT").ToList();
            return View(_obj);
        }
    }
}
