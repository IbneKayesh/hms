using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hms.DataModel
{
    public class US_MODULE : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        [Remote(action: "VerifyModuleName", controller: "Module", AdditionalFields = "ID", ErrorMessage = "{0} is not available")]
        public string MODULE_NAME { get; set; }

        [Display(Name = "Name Bangla")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is required")]
        public string MODULE_BN_NAME { get; set; }
        [StringLength(30)]

        [Display(Name = "Icon")]
        [Required(ErrorMessage = "{0} is required")]
        public string MODULE_ICON { get; set; }

        [Display(Name = "View Order")]
        [Required(ErrorMessage = "{0} is required")]
        public int VIEW_ORDER { get; set; }

        [Display(Name = "Controller Name")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is required")]
        public string CONTROLLER_NAME { get; set; }

        [Display(Name = "Method Name")]
        [StringLength(30)]
        [Required(ErrorMessage = "{0} is required")]
        public string METHOD_NAME { get; set; }
    }
}
