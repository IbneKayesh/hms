using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HP_PRESCRIPTION : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string PRESCRIPTION_NUMBER { get; set; }

        [Display(Name = "Date")]
        public DateTime PRESCRIPTION_DATE { get; set; }



        [Display(Name = "Hospital Id")]
        [StringLength(6, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public int HOSPITAL_ID { get; set; }

        [Display(Name = "Doctor Id")]
        [StringLength(6, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public int DOCTOR_ID { get; set; }

        [Display(Name = "Patient Id")]
        [Required(ErrorMessage = "{0} is required")]
        public Int64 PATIENT_ID { get; set; }

        [Display(Name = "Show Type")]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public int SHOW_TYPE_ID { get; set; }

        [Display(Name = "Token Id")]
        public Int64 TOKEN_ID { get; set; }

        [Display(Name = "Refer")]
        public int REFER_FOR_ADMIT { get; set; } = 0;

        [Display(Name = "Prescription")]
        public string PREVIOUS_PRESCRIPTION { get; set; }

    }
}
