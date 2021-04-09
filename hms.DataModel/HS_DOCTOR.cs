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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Hospital")]
        [Required(ErrorMessage = "{0} is required")]
        public int HS_HOSPITAL_ID { get; set; }

        [ForeignKey("HS_HOSPITAL_ID")]
        public HS_HOSPITAL HS_HOSPITAL { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_NAME { get; set; }

        [Display(Name = "Name Bangla")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string DOCTOR_NAME_BANGLA { get; set; }

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
    }
}
