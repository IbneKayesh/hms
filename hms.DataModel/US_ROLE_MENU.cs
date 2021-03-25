using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
   public class US_ROLE_MENU : DEFAULT
    {
        [Key, Column(Order = 0)]
        public int US_ROLE_ID { get; set; }
        [ForeignKey("US_ROLE_ID")]
        public US_ROLE US_ROLE { get; set; }

        [Key, Column(Order = 1)]
        public int US_CHILD_MENU_ID { get; set; }
        [ForeignKey("US_CHILD_MENU_ID")]
        public US_CHILD_MENU US_CHILD_MENU { get; set; }
    }
}
