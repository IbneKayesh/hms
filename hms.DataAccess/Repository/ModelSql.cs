using hms.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataAccess.Repository
{
    public class ModelSql<T> : IModelSql<T> where T : class
    {
        string IModelSql<T>.ModelSql(T model)
        {
            throw new NotImplementedException();
        }
        public List<string> ModelSqlList(List<T> model)
        {
            throw new NotImplementedException();
        }
    }
}
