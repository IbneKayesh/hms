using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_EMPLOYEE_SCHEDULE
    {
        public Int64 ID { get; set; }
        public int BRANCH_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public string SATURDAY { get; set; }
        public string SUNDAY { get; set; }
        public string MONDAY { get; set; }
        public string TUESDAY { get; set; }
        public string WEDNESDAY { get; set; }
        public string THRUSDAY { get; set; }
        public string FRIDAY { get; set; }
    }
}
