using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class US_USER_ROLE : DEFAULT
    {
        public int ID { get; set; }
        public int USER_ID { get; set; }
        public int ROLE_ID { get; set; }
    }
}
