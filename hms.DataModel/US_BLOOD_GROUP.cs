using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hms.DataModel
{
    public class US_BLOOD_GROUP : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "Blood Group")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        [ConcurrencyCheck]
        public string BLOOD_GROUP_NAME { get; set; }
    }
}
