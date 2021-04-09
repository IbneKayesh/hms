using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_DEPARTMENT_ASSIGN : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Branch")]
        [Required(ErrorMessage = "{0} is required")]
        public int HS_BRANCH_ID { get; set; }

        [ForeignKey("HS_BRANCH_ID")]
        public HS_BRANCH HS_BRANCH { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "{0} is required")]
        public int HS_DEPARTMENT_ID { get; set; }

        [ForeignKey("HS_DEPARTMENT_ID")]
        public HS_DEPARTMENT HS_DEPARTMENT { get; set; }

        [Display(Name = "Remarks")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string REMARKS { get; set; }
    }
}
