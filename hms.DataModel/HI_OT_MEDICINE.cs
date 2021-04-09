using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HI_OT_MEDICINE
    {
        public Int64 ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
        public int ITEM_QUANTITY { get; set; }
        public decimal ITEM_RATE { get; set; }
        public decimal DISCOUNT_AMOUNT { get; set; }
        public int DISCOUNT_PERCENT { get; set; }
        public decimal LINE_TOTAL_AMOUNT { get; set; }
    }
}
