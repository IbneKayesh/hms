using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HP_MEDICINE : DEFAULT
    {
        public Int64 ID { get; set; }

        [Display(Name = "Number")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string PRESCRIPTION_NUMBER { get; set; }

        [Display(Name = "Item Id")]
        [Required(ErrorMessage = "{0} is required")]
        public Int64 ITEM_ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string ITEM_NAME { get; set; }

        [Display(Name = "Duration")]
        public int DOSAGE_DURATION { get; set; }

        [Display(Name = "Frequency")]
        public string DOSAGE_FREQUENCY { get; set; }

        [Display(Name = "Suggestion")]
        public string SUGGESTION { get; set; }
    }
}
