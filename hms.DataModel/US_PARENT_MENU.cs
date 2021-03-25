using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class US_PARENT_MENU
    {
        public int ID { get; set; }

        [Display(Name = "Menu Name")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string PARENT_NAME { get; set; }

        [Display(Name = "Name Bangla")]
        [StringLength(20)]
        public string PARENT_BN_NAME { get; set; }

        [StringLength(20)]
        public string PARENT_ICON { get; set; }
    }
}
