using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_EMPLOYEE_TYPE : DEFAULT
    {
        public int ID { get; set; }
        public string EMPLOYEE_TYPE_NAME { get; set; } //Only Employee Nurse, Anesthesia
    }
}
