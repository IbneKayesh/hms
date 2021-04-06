using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hms.DataModel
{
    public class US_CHILD_MENU : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Menu Name")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        [Remote(action: "VerifyChildMenuName", controller: "ChildMenu", AdditionalFields = "ID", ErrorMessage = "{0} is available")]
        public string CHILD_NAME { get; set; }

        [Display(Name = "Menu Bangla")]
        [StringLength(30)]
        [Required(ErrorMessage = "{0} is required")]
        public string CHILD_BN_NAME { get; set; }

        [Display(Name = "Icon")]
        [StringLength(30)]
        [Required(ErrorMessage = "{0} is required")]
        public string CHILD_ICON { get; set; }

        [Display(Name = "Area Name")]
        [StringLength(15)]
        [Required(ErrorMessage = "{0} is required")]
        public string AREA_NAME { get; set; }

        [Display(Name = "Controller Name")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is required")]
        public string CONTROLLER_NAME { get; set; }

        [Display(Name = "Action Name")]
        [StringLength(30)]
        [Required(ErrorMessage = "{0} is required")]
        public string ACTION_NAME { get; set; }

        [Display(Name = "Module")]
        [Required(ErrorMessage = "{0} is required")]
        public int US_MODULE_ID { get; set; }

        [ForeignKey("US_MODULE_ID")]
        public US_MODULE US_MODULE { get; set; }

        [Display(Name = "Parent Menu")]
        [Required(ErrorMessage = "{0} is required")]
        public int US_PARENT_MENU_ID { get; set; }

        [ForeignKey("US_PARENT_MENU_ID")]
        public  US_PARENT_MENU US_PARENT_MENU { get; set; }
    }
}
