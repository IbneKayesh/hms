using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class DEFAULT
    {
        public DEFAULT()
        {
            IS_ACTIVE = true;
            CREATE_BY = "Admin";
            UPDATE_BY = "Admin";
            CREATE_DATE = DateTime.Now;
            UPDATE_DATE = DateTime.Now;
            CREATE_DEVICE = Environment.MachineName;
            UPDATE_DEVICE = Environment.MachineName;
        }

        [Display(Name = "Status")]
        public bool IS_ACTIVE { get; set; }
        public DateTime CREATE_DATE { get; set; }

        [StringLength(15)]
        public string CREATE_BY { get; set; }

        [StringLength(50)]
        public string CREATE_DEVICE { get; set; }
        public DateTime UPDATE_DATE { get; set; }

        [StringLength(15)]
        public string UPDATE_BY { get; set; }

        [StringLength(50)]
        public string UPDATE_DEVICE { get; set; }
        
        
        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
