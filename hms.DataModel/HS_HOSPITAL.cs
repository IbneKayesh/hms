using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_HOSPITAL : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string HOSPITAL_NAME { get; set; }

        [Display(Name = "Address")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string HOSPITAL_ADDRESS { get; set; }

        [Display(Name = "Mobile No")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string HOSPITAL_MOBILE { get; set; }

        [Display(Name = "Phone")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        //[Required(ErrorMessage = "{0} is required")]
        public string HOSPITAL_PHONE { get; set; }

        [Display(Name = "Hotline")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        //[Required(ErrorMessage = "{0} is required")]
        public string HOSPITAL_HOTLINE { get; set; }

        [Display(Name = "Email Address")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [DataType(DataType.EmailAddress)]
        public string HOSPITAL_EMAIL { get; set; }

        [Display(Name = "BIN")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        //[Required(ErrorMessage = "{0} is required")]
        public string HOSPITAL_BIN_NO { get; set; }

        [Display(Name = "Hospital Image")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "{0} length is {2} between {1}")]
        public string HOSPITAL_IMAGE { get; set; }
    }
}
