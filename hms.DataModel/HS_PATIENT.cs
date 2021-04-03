using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel
{
    public class HS_PATIENT
    {
        public int ID { get; set; }
        public string PATIENT_NAME { get; set; }
        public DateTime DATE_OF_BIRTH { get; set; }
    }
}
