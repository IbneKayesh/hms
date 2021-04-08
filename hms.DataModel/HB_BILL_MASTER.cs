using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HB_BILL_MASTER
    {
        public Int64 ID { get; set; }
        public string BILL_NO { get; set; }
        public int BRANCH_ID { get; set; }
        public Int64 PATIENT_ID { get; set; }
        public string PAYMENT_METHOD { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
        public string BILL_NOTE { get; set; }
        public bool IS_PAID { get; set; }
    }
}
