using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_PARTNERSHIP_POLICY
    {
        public Int64 PARTNERSHIP_ID { get; set; }
        public int BRANCH_ID { get; set; }
        public Int64 TEST_ID { get; set; }
        public int DISCOUNT_PERCENT { get; set; }
        public bool POLICY_TYPE { get; set; } //0 for our, 1 for them
        public DateTime AGGREMENT_DATE { get; set; }
        public DateTime VALID_UNTIL { get; set; }
    }
}
