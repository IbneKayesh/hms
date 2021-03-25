using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class US_CHILD_MENU : DEFAULT
    {
        public int ID { get; set; }

        [Display(Name = "Menu Name")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string CHILD_NAME { get; set; }

        [Display(Name = "Module Name Bangla")]
        [StringLength(20)]
        public string CHILD_BN_NAME { get; set; }

        [StringLength(20)]
        public string CHILD_ICON { get; set; }

        [StringLength(20)]
        public string AREA_NAME { get; set; }

        [StringLength(20)]
        public string CONTROLLER_NAME { get; set; }

        [StringLength(20)]
        public string ACTION_NAME { get; set; }

        public int US_MODULE_ID { get; set; }

        [ForeignKey("US_MODULE_ID")]
        public US_MODULE US_MODULE { get; set; }

        public int US_PARENT_MENU_ID { get; set; }

        [ForeignKey("US_PARENT_MENU_ID")]
        public  US_PARENT_MENU US_PARENT_MENU { get; set; }
    }
}
