using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_HOSPITAL : DEFAULT
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string HOSPITAL_NAME { get; set; }
    }
}
