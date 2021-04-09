using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_DOCTOR_ASSIGN : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Doctor")]
        [Required(ErrorMessage = "{0} is required")]
        public int HS_DOCTOR_ID { get; set; }

        [ForeignKey("HS_DOCTOR_ID")]
        public HS_DOCTOR HS_DOCTOR { get; set; }

        [Display(Name = "Branch")]
        [Required(ErrorMessage = "{0} is required")]
        public int HS_BRANCH_ID { get; set; }

        [ForeignKey("HS_BRANCH_ID")]
        public HS_BRANCH HS_BRANCH { get; set; }

        [Display(Name = "Office Time")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string OFFICE_TIME { get; set; }

        [Display(Name = "Office Time Bangla")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string OFFICE_TIME_BANGLA { get; set; }

        [Display(Name = "Remarks")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string REMARKS { get; set; }

        [Display(Name = "Remarks Bangla")]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        public string REMARKS_BANGLA { get; set; }
    }
}
