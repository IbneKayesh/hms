using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class US_MARITAIL_STATUS : DEFAULT 
    {
        public int ID { get; set; }

        [Display(Name = "Maritail Status")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string MARITAIL_STATUS_NAME { get; set; }
    }
}
