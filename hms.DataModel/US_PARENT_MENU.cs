using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hms.DataModel
{
    public class US_PARENT_MENU:DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Menu Name")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        [Remote(action: "VerifyParentMenuName", controller: "ParentMenu", AdditionalFields = "ID", ErrorMessage = "{0} is not available")]
        public string PARENT_NAME { get; set; }

        [Display(Name = "Name Bangla")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is required")]
        public string PARENT_BN_NAME { get; set; }

        [Display(Name = "Icon")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is required")]
        public string PARENT_ICON { get; set; }
    }
}
