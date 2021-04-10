using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository.IRepository
{
    public interface IModelSql<T> where T : class
    {
        String ModelSql(T model);
        List<string> ModelSqlList(List<T> model);
    }
}
