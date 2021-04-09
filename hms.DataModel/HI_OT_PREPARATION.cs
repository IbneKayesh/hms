using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HI_OT_PREPARATION
    {
        public Int64 ID { get; set; }
        public int ROOM_ID { get; set; }
        public DateTime OT_DATE { get; set; }
        public bool IS_PACKAGE { get; set; }
        public decimal OT_AMOUNT { get; set; }
        public decimal MEDICINE_AMOUNT { get; set; }
        public string OT_CASE_DETAIL { get; set; }
        public Int64 REFERANCE_DOCTOR { get; set; }
        public Int64 PARTNERSHIP_ID { get; set; }
    }
}
