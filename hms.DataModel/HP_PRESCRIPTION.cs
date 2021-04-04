using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HP_PRESCRIPTION : DEFAULT
    {
        public string PRESCRIPTION_NUMBER { get; set; }
        public DateTime PRESCRIPTION_DATE { get; set; }


        public int HOSPITAL_ID { get; set; }
        public int DOCTOR_ID { get; set; }
        public int PATIENT_ID { get; set; }
        public int SHOW_TYPE { get; set; }

        public Int64 TOKEN_ID { get; set; }
        public int REFER_FOR_ADMIT { get; set; } = 0;
        public string PREVIOUS_PRESCRIPTION { get; set; }

    }
}
