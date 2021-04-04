using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HP_SHOW_TYPE : DEFAULT
    {
        [Display(Name = "Id")]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string SHOW_NAME { get; set; }
    }
}
