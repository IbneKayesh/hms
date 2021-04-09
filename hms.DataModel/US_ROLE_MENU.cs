using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hms.DataModel
{
    public class US_ROLE_MENU : DEFAULT
    {
        [Display(Name = "Role")]
        [Key, Column(Order = 0)]
        [Required(ErrorMessage = "{0} is required")]
        public int ROLE_ID { get; set; }
        [ForeignKey("ROLE_ID")]
        public US_ROLE US_ROLE { get; set; }

        [Display(Name = "Menu")]
        [Key, Column(Order = 1)]
        [Required(ErrorMessage = "{0} is required")]
        public int CHILD_MENU_ID { get; set; }
        [ForeignKey("CHILD_MENU_ID")]
        public US_CHILD_MENU US_CHILD_MENU { get; set; }
    }
}
