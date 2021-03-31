using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.Utility
{
    public class SweetMsg
    {
        public static string SuccessOK(string _msg)
        {
            return "Swal.fire('success','" + _msg + "','success')";
        }
        public static string ErrorOK(string _msg)
        {
            return "Swal.fire('error','" + _msg + "','error')";
        }
        public static string WarningOK(string _msg)
        {
            return "Swal.fire('warning','" + _msg + "','warning')";
        }

        public static string Success(string _msg)
        {
            return @"Swal.fire({position: 'top-end',icon: 'success', title: '" + _msg + @"', showConfirmButton: false,timer: 1500})";
        }

    }
}
