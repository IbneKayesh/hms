using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HB_BILL_COLLECTION
    {
        public Int64 BILL_MASTER_ID { get; set; }
        public int LINE_NO { get; set; }
        public string PAYMENT_METHOD { get; set; }
        public decimal PAYMENT_AMOUNT { get; set; }
        public decimal DUE_AMOUNT { get; set; }
        public decimal RETURN_AMOUNT { get; set; }
    }
}
