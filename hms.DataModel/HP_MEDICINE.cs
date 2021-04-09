using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HP_MEDICINE : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 ID { get; set; }

        [Display(Name = "Number")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string PRESCRIPTION_NUMBER { get; set; }

        [Display(Name = "Item Id")]
        [Required(ErrorMessage = "{0} is required")]
        public Int64 ITEM_ID { get; set; }
        [ForeignKey("ITEM_ID")]
        public HS_ITEM HS_ITEM { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string ITEM_NAME { get; set; }

        [Display(Name = "Duration")]
        public string DOSAGE_DURATION { get; set; }

        [Display(Name = "Frequency")]
        public string DOSAGE_FREQUENCY { get; set; }

        [Display(Name = "Suggestion")]
        public string SUGGESTION { get; set; }
    }
}
