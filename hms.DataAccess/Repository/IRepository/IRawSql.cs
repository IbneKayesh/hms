using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IRawSql
    {
        void ExecuteSqlCommand(string query,  object[] parameters=null);
    }
}
