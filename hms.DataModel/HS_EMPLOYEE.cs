using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_EMPLOYEE : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Hospital")]
        [Required(ErrorMessage = "{0} is required")]
        public int HOSPITAL_ID { get; set; }

        [ForeignKey("HOSPITAL_ID")]
        public HS_HOSPITAL HS_HOSPITAL { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string EMPLOYEE_NAME { get; set; }

        [Display(Name = "Name Bangla")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string EMPLOYEE_NAME_BANGLA { get; set; }

        [Display(Name = "Present Address")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string PRESENT_ADDRESS { get; set; }

        [Display(Name = "Permanent Address")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string PERMANENT_ADDRESS { get; set; }

        [Display(Name = "Degree")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string EMPLOYEE_DEGREE { get; set; }

        [Display(Name = "Degree Bangla")]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string EMPLOYEE_DEGREE_BANGLA { get; set; }

        [Display(Name = "Speciality")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string EMPLOYEE_SPECIALITY { get; set; }

        [Display(Name = "Speciality Bangla")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string EMPLOYEE_SPECIALITY_BANGLA { get; set; }

        [Display(Name = "Others")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string EMPLOYEE_OTHERS { get; set; }

        [Display(Name = "Others Bangla")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        public string EMPLOYEE_OTHERS_BANGLA { get; set; }

        [Display(Name = "Reg. No")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string EMPLOYEE_REG_NO { get; set; }

        [Display(Name = "Reg. No Bangla")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string EMPLOYEE_REG_NO_BANGLA { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "{0} is required")]
        public int GENDER_ID { get; set; }
        [ForeignKey("GENDER_ID")]
        public US_GENDER US_GENDER { get; set; }

        [Display(Name = "Maritail Status")]
        [Required(ErrorMessage = "{0} is required")]
        public int MARITAIL_STATUS_ID { get; set; }
        [ForeignKey("MARITAIL_STATUS_ID")]
        public US_MARITAIL_STATUS US_MARITAIL_STATUS { get; set; }

        [Display(Name = "Blood")]
        [Required(ErrorMessage = "{0} is required")]
        public int BLOOD_GROUP_ID { get; set; }
        [ForeignKey("BLOOD_GROUP_ID")]
        public US_BLOOD_GROUP US_BLOOD_GROUP { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "{0} is required")]
        public int EMPLOYEE_TYPE_ID { get; set; }
        [ForeignKey("EMPLOYEE_TYPE_ID")]
        public HS_EMPLOYEE_TYPE HS_EMPLOYEE_TYPE { get; set; }

        [Display(Name = "Religion")]
        [Required(ErrorMessage = "{0} is required")]
        public int RELIGION_ID { get; set; }
        [ForeignKey("RELIGION_ID")]
        public US_RELIGION US_RELIGION { get; set; }

        [Display(Name = "National Id")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string EMPLOYEE_NATIONAL_ID { get; set; }

        //Need to Link Table Father's, Mother's, Degree, Spouse, Children, Salary and Others Info
    }
}
