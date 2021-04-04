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

        [Display(Name = "Number")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string PRESCRIPTION_NUMBER { get; set; }

        [Display(Name = "Item Id")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public int ITEM_ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string ITEM_NAME { get; set; }

        [Display(Name = "Suggestion")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} length is {2} between {1}")]
        public string SUGGESTION { get; set; }
    }
}
