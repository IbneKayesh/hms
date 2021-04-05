using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_TESTS:DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int64 ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string TESTS_NAME { get; set; }
    }
}
