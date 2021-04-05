using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_PATIENT : DEFAULT
    {
        public Int64 ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string PATIENT_NAME { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "{0} is required")]
        public DateTime DATE_OF_BIRTH { get; set; }
    }
}
