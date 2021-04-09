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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 ID { get; set; }

        [Display(Name = "Number")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string PRESCRIPTION_NUMBER { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.DateTime)]
        public DateTime PRESCRIPTION_DATE { get; set; }



        [Display(Name = "Hospital")]
        public int HOSPITAL_ID { get; set; }
        [ForeignKey("HOSPITAL_ID")]
        public HS_HOSPITAL HS_HOSPITAL { get; set; }

        [Display(Name = "Doctor Id")]
        public int DOCTOR_ID { get; set; }
        [ForeignKey("DOCTOR_ID")]
        public HS_DOCTOR HS_DOCTOR { get; set; }

        [Display(Name = "Patient Id")]
        [Required(ErrorMessage = "{0} is required")]
        public Int64 PATIENT_ID { get; set; }
        [ForeignKey("PATIENT_ID")]
        public HS_PATIENT HS_PATIENT { get; set; }

        [Display(Name = "Show Type")]
        [Required(ErrorMessage = "{0} is required")]
        public int SHOW_TYPE_ID { get; set; }
        [ForeignKey("SHOW_TYPE_ID")]
        public HP_SHOW_TYPE HP_SHOW_TYPE { get; set; }

        [Display(Name = "Token Id")]
        public Int64 TOKEN_ID { get; set; }
        [ForeignKey("TOKEN_ID")]
        public HP_TOKEN HP_TOKEN { get; set; }

        [Display(Name = "Refer")]
        public int REFER_FOR_ADMIT { get; set; } = 0;

        [Display(Name = "Prescription")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string PREVIOUS_PRESCRIPTION { get; set; }

    }
}
