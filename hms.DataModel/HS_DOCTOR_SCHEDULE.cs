using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_DOCTOR_SCHEDULE
    {
        public Int64 BRANCH_ID { get; set; }
        public int DOCTOR_ID { get; set; }
        public string SATURDAY { get; set; }
        public string SUNDAY { get; set; }
        public string MONDAY { get; set; }
        public string TUESDAY { get; set; }
        public string WEDNESDAY { get; set; }
        public string THRUSDAY { get; set; }
        public string FRIDAY { get; set; }
    }
}
