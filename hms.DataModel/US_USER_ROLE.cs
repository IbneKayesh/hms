using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hms.DataModel
{
    public class US_USER_ROLE : DEFAULT
    {
        [Display(Name = "User")]
        [Key, Column(Order = 0)]
        public int US_USER_ID { get; set; }
        [ForeignKey("US_USER_ID")]
        public US_USER US_USER { get; set; }


        [Display(Name = "Role")]
        [Key, Column(Order = 1)]
        public int US_ROLE_ID { get; set; }
        [ForeignKey("US_ROLE_ID")]
        public US_ROLE US_ROLE { get; set; }
    }
}
