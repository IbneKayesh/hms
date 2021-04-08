using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_PARTNERSHIP_PAYMENT
    {
        public Int64 PARTNERSHIP_ID { get; set; }
        public int BRANCH_ID { get; set; }
        public Int64 TEST_ID { get; set; }
        public int DISCOUNT_PERCENT { get; set; }
        public DateTime PAYMENT_DATE { get; set; }
        public string RECEIVED_BY { get; set; }
        public string PAYMENT_METHOD { get; set; }
    }
}
