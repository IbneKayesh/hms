using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HB_BILL_DETAILS
    {
        public Int64 BILL_MASTER_ID { get; set; }
        public int LINE_NO { get; set; }
        public Int64 ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
        public int QTY { get; set; }
        public decimal RATE { get; set; }
        public decimal DISCOUNT_AMOUNT { get; set; }
        public int DISCOUNT_PERCENT { get; set; }
        public decimal LINE_TOTAL_AMOUNT { get; set; }
        public int REFERANCE_ID { get; set; } //referral id
    }
}
