using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_ITEM : DEFAULT
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int64 ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        [Remote(action: "VerifyItemName", controller: "Item", AdditionalFields = "ID", ErrorMessage = "{0} is available")]
        public string ITEM_NAME { get; set; }

        [Display(Name = "Unit")]
        [Required(ErrorMessage = "{0} is required")]
        public int UNIT_ID { get; set; }

        [ForeignKey("UNIT_ID")]
        public US_UNIT US_UNIT { get; set; }

        [Display(Name = "Purchase Rate")]
        [RegularExpression(@"^(0|-?\d{0,16}(\.\d{0,2})?)$")]
        [Column(TypeName = "decimal(7,2)")]
        public decimal DP_RATE { get; set; }

        [Display(Name = "MRP Rate")]
        [RegularExpression(@"^(0|-?\d{0,16}(\.\d{0,2})?)$")]
        [Column(TypeName = "decimal(7,2)")]
        public decimal MRP_RATE { get; set; }
    }
}
