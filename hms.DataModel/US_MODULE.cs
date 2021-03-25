using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class US_MODULE : DEFAULT
    {
        public int ID { get; set; }

        [Display(Name = "Module Name")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string MODULE_NAME { get; set; }

        [Display(Name = "Module Name Bangla")]
        [StringLength(10)]
        public string MODULE_BN_NAME { get; set; }
        public string ICON_NAME { get; set; }
        public string VIEW_ORDER { get; set; }
        public string CONTROLLER_NAME { get; set; }
        public string METHOD_NAME { get; set; }
    }
}
