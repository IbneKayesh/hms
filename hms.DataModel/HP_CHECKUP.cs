using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HP_CHECKUP:DEFAULT
    {
        public int ID { get; set; }
        public string PRESCRIPTION_NUMBER { get; set; }
        public string PATIENT_AGE { get; set; }
        public string PATIENT_SEX { get; set; }
        public string PATIENT_CONTACT { get; set; }
        public decimal BODY_TEMPERATURE { get; set; }
        public int BP_UP { get; set; }
        public int BP_DOWN { get; set; }
        public decimal WEIGHT { get; set; }
        public decimal HEIGHT { get; set; }

    }
}
