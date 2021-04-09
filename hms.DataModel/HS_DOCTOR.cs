using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_DOCTOR : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Hospital")]
        [Required(ErrorMessage = "{0} is required")]
        public int HOSPITAL_ID { get; set; }
        [ForeignKey("HOSPITAL_ID")]
        public HS_HOSPITAL HS_HOSPITAL { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_NAME { get; set; }

        [Display(Name = "Name Bangla")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_NAME_BANGLA { get; set; }

        //Need to Link Table More Degree Setup (If Store)
        //Below for Pescription
        [Display(Name = "Degree")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_DEGREE { get; set; }

        [Display(Name = "Degree Bangla")]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_DEGREE_BANGLA { get; set; }

        [Display(Name = "Speciality")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_SPECIALITY { get; set; }

        [Display(Name = "Speciality Bangla")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_SPECIALITY_BANGLA { get; set; }

        [Display(Name = "Others")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_OTHERS { get; set; }

        [Display(Name = "Others Bangla")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_OTHERS_BANGLA { get; set; }

        [Display(Name = "Reg. No")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_REG_NO { get; set; }

        [Display(Name = "Reg. No Bangla")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_REG_NO_BANGLA { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "{0} is required")]
        public int US_GENDER_ID { get; set; }

        [ForeignKey("US_GENDER_ID")]
        public US_GENDER US_GENDER { get; set; }

        [Display(Name = "Blood")]
        [Required(ErrorMessage = "{0} is required")]
        public int US_BLOOD_GROUP_ID { get; set; }

        [ForeignKey("US_BLOOD_GROUP_ID")]
        public US_BLOOD_GROUP US_BLOOD_GROUP { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "{0} is required")]
        public int HS_DOCTOR_TYPE_ID { get; set; }

        [ForeignKey("HS_DOCTOR_TYPE_ID")]
        public HS_DOCTOR_TYPE HS_DOCTOR_TYPE { get; set; }

        [Display(Name = "Religion")]
        [Required(ErrorMessage = "{0} is required")]
        public int US_RELIGION_ID { get; set; }

        [ForeignKey("US_RELIGION_ID")]
        public US_RELIGION US_RELIGION { get; set; }

        [Display(Name = "Maritail Status")]
        [Required(ErrorMessage = "{0} is required")]
        public int US_MARITAIL_STATUS_ID { get; set; }

        [ForeignKey("US_MARITAIL_STATUS_ID")]
        public US_MARITAIL_STATUS US_MARITAIL_STATUS { get; set; }

        [Display(Name = "National Id")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_NATIONAL_ID { get; set; }
    }
}
