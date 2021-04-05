using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HP_CHECKUP : DEFAULT
    {
        public Int64 ID { get; set; }

        [Display(Name = "Number")]
        [Required(ErrorMessage = "{0} is required")]
        public Int64 PRESCRIPTION_NUMBER { get; set; }

        [Display(Name = "Age")]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string PATIENT_AGE { get; set; }

        [Display(Name = "Sex")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string PATIENT_SEX { get; set; }

        [Display(Name = "Mobile No")]
        // [RegularExpression("([-+]?[0-9]\.?[0-9]+[\/\+\-\])+([-+]?[0-9]*\.?[0-9]+)")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string PATIENT_CONTACT { get; set; }

        [Display(Name = "Temperature")]
        [RegularExpression(@"^(0|-?\d{0,16}(\.\d{0,2})?)$")]
        [Range(0, 999.99)]
        public decimal BODY_TEMPERATURE { get; set; }

        [Display(Name = "BP Up")]
        public int BP_UP { get; set; }

        [Display(Name = "BP Down")]
        public int BP_DOWN { get; set; }

        [Display(Name = "Weight")]
        [RegularExpression(@"^(0|-?\d{0,16}(\.\d{0,2})?)$")]
        [Range(0, 999.99)]
        public decimal WEIGHT { get; set; }

        [Display(Name = "Height")]
        [RegularExpression(@"^(0|-?\d{0,16}(\.\d{0,2})?)$")]
        [Range(0, 999.99)]
        public decimal HEIGHT { get; set; }

    }
}
