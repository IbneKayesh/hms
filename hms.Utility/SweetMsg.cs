using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.Utility
{
    public class SweetMsg
    {
        public static string Success(string _msg)
        {
            return "Swal.fire('success','" + _msg + "','success')";
        }
        public static string Error(string _msg)
        {
            return "Swal.fire('error','" + _msg + "','error')";
        }
        public static string Warning(string _msg)
        {
            return "Swal.fire('warning','" + _msg + "','warning')";
        }
    }
}
