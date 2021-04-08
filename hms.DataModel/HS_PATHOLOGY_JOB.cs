using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
   public class HS_PATHOLOGY_JOB
    {

        public Int64 BILL_MASTER_ID { get; set; }
        public int LINE_NO { get; set; }
        public Int64 ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
        public int QTY { get; set; }
        public DateTime COLLECTION_DATE { get; set; }
        public DateTime DALIVERY_DATE { get; set; }
        public bool IS_DELIVERD { get; set; }
    }
}
