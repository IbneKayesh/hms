using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_BRANCH : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Hospital")]
        [Required(ErrorMessage = "{0} is required")]
        public int HS_HOSPITAL_ID { get; set; }

        [ForeignKey("HS_HOSPITAL_ID")]
        public HS_HOSPITAL HS_HOSPITAL { get; set; }

        [Display(Name = "Branch Name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string BRANCH_NAME { get; set; }

        [Display(Name = "Branch Bangla")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string BRANCH_NAME_BANGLA { get; set; }

        [Display(Name = "Address")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string BRANCH_ADDRESS { get; set; }

        [Display(Name = "Address Bangla")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string BRANCH_ADDRESS_BANGLA { get; set; }

        [Display(Name = "Mobile No")]
        // [RegularExpression("([-+]?[0-9]\.?[0-9]+[\/\+\-\])+([-+]?[0-9]*\.?[0-9]+)")]
        [StringLength(15, MinimumLength = 11, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string BRANCH_MOBILE { get; set; }

        [Display(Name = "Phone")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        //[Required(ErrorMessage = "{0} is required")]
        public string BRANCH_PHONE { get; set; }

        [Display(Name = "Hotline")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        //[Required(ErrorMessage = "{0} is required")]
        public string BRANCH_HOTLINE { get; set; }

        [Display(Name = "Email Address")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [DataType(DataType.EmailAddress)]
        public string BRANCH_EMAIL { get; set; }

        [Display(Name = "BIN")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        //[Required(ErrorMessage = "{0} is required")]
        public string BRANCH_BIN_NO { get; set; }

        [Display(Name = "Hospital Image")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "{0} length is {2} between {1}")]
        public string BRANCH_IMAGE { get; set; }
    }
}
