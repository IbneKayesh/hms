using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IModelSql<T> where T : class
    {
        IEnumerable<T> ExecuteSqlQuery(string query, object[] parameters = null);
    }
}
