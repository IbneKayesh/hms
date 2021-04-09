using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hms.DataModel
{
    public class US_USER_ROLE : DEFAULT
    {
        [Display(Name = "User")]
        [Key, Column(Order = 0)]
        [Required(ErrorMessage = "{0} is required")]
        public int USER_ID { get; set; }
        [ForeignKey("USER_ID")]
        public US_USER US_USER { get; set; }


        [Display(Name = "Role")]
        [Key, Column(Order = 1)]
        [Required(ErrorMessage = "{0} is required")]
        public int ROLE_ID { get; set; }
        [ForeignKey("ROLE_ID")]
        public US_ROLE US_ROLE { get; set; }
    }
}
