using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HP_INVESTIGATION : DEFAULT
    {
        [Display(Name = "Id")]
        public Int64 ID { get; set; }
        public string PRESCRIPTION_NUMBER { get; set; }
        public int ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
        public string SUGGESTION { get; set; }
    }
}
