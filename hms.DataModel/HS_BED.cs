using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_BED
    {
        public string BED_NUMBER { get; set; }
        public string BED_CATEGORY_NAME_ID { get; set; }
        public Int64 BRANCH_ID { get; set; } //hospital branch
        public decimal DAILY_RENT { get; set; }
    }
}
