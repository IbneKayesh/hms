using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hms.DataModel
{
    public class US_USER : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Login Id")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        [Remote(action: "VerifyLoginId", controller: "User", AdditionalFields = "ID", ErrorMessage = "{0} is available")]
        public string LOGIN_ID { get; set; }

        [Display(Name = "Password")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        [Remote(action: "VerifyPassword", controller: "User")]
        [DataType(DataType.Password)]
        public string PASSWORD { get; set; }

        [Display(Name = "User Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string USER_NAME { get; set; }

        [Display(Name = "Mobile No")]
        // [RegularExpression("([-+]?[0-9]\.?[0-9]+[\/\+\-\])+([-+]?[0-9]*\.?[0-9]+)")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string MOBILE_NO { get; set; }

        [Display(Name = "Email Address")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [DataType(DataType.EmailAddress)]
        public string EMAIL_ID { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DATE_OF_BIRTH { get; set; }

        [Display(Name = "User Image")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "{0} length is {2} between {1}")]
        public string PROFILE_IMAGE { get; set; }

        [NotMapped]
        public IFormFile PROFILE_IMAGE_FILE { get; set; }


        [Display(Name = "Gender")]
        [Required(ErrorMessage = "{0} is required")]
        public int GENDER_ID { get; set; }
        [ForeignKey("GENDER_ID")]
        public US_GENDER US_GENDER { get; set; }

        [Display(Name = "Religion")]
        [Required(ErrorMessage = "{0} is required")]
        public int RELIGION_ID { get; set; }
        [ForeignKey("RELIGION_ID")]
        public US_RELIGION US_RELIGION { get; set; }

        [Display(Name = "Blood Group")]
        [Required(ErrorMessage = "{0} is required")]
        public int BLOOD_GROUP_ID { get; set; }
        [ForeignKey("BLOOD_GROUP_ID")]
        public US_BLOOD_GROUP US_BLOOD_GROUP { get; set; }

        [Display(Name = "Marital Status")]
        [Required(ErrorMessage = "{0} is required")]
        public int MARITAIL_STATUS_ID { get; set; }
        [ForeignKey("MARITAIL_STATUS_ID")]
        public US_MARITAIL_STATUS US_MARITAIL_STATUS { get; set; }

        [Display(Name = "User Type")]
        [Required(ErrorMessage = "{0} is required")]
        public int TYPE_ID { get; set; }
        [ForeignKey("TYPE_ID")]
        public US_TYPE US_TYPE { get; set; }
    }
}
