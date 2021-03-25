using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class US_BLOOD_GROUP : DEFAULT
    {
        public int ID { get; set; }

        [Display(Name = "Blood Group")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        [ConcurrencyCheck]
        public string BLOOD_GROUP_NAME { get; set; }
    }
}
