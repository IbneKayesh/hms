using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HP_TOKEN : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int64 ID { get; set; }

        [Display(Name = "Serial No")]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public int SERIAL_NO { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime TOKEN_DATE { get; set; }

        [Display(Name = "Doctor")]
        [Required(ErrorMessage = "{0} is required")]
        public int HS_DOCTOR_ID { get; set; }
        [ForeignKey("HS_DOCTOR_ID")]
        public HS_DOCTOR HS_DOCTOR { get; set; }

    }
}
