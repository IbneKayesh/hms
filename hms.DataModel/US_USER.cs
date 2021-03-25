using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class US_USER : DEFAULT
    {
        public int ID { get; set; }

        [Display(Name = "Login Id")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string LOGIN_ID { get; set; }

        [Display(Name = "Password")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
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

        public DateTime DATE_OF_BIRTH { get; set; }

        [Display(Name = "User Image")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "{0} length is {2} between {1}")]
        public string PROFILE_IMAGE { get; set; }
    }
}
