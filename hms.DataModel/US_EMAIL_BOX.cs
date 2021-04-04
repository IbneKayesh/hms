using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{

    public class US_EMAIL_BOX
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public DateTime MAIL_DATE { get; set; }
        [StringLength(500, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string MAIL_TO { get; set; }
        [StringLength(500, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        public string MAIL_CC { get; set; }
        [StringLength(500, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        public string MAIL_BCC { get; set; }
        [StringLength(500, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string MAIL_SUBJECT { get; set; }
        [StringLength(5000, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string MAIL_BODY_HTML { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public DateTime MAIL_SEND_TIME { get; set; }
        [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} length is {2} between {1}")]
        [Required(ErrorMessage = "{0} is required")]
        public string MAIL_REFERENCE { get; set; }
        public bool MAIL_STATUS { get; set; } = false;
        public bool MAIL_CANCEL { get; set; } = false;
    }
}
