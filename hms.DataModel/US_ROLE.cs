using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace hms.DataModel
{
    public class US_ROLE : DEFAULT
    {
        //[Display(Name = "Id")]
        //[Required(ErrorMessage = "{0} is required")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Remote(action: "VerifyRoleId", controller: "Role")]
        public int ID { get; set; }

        [Display(Name = "Role Name")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        [Remote(action: "VerifyRoleName", controller: "Role", AdditionalFields="ID", ErrorMessage = "{0} is available")]
        public string ROLE_NAME { get; set; }
    }
}
