using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel.ViewModels
{
    public class US_LEADERBOARD_MODULE_VM
    {
        public int Module_Id { get; set; }
        public string Module_Icon { get; set; }
        public string Module_Name { get; set; }
        public int View_Order { get; set; }
        public string Module_Controller { get; set; }
        public string Module_Method { get; set; }
    }
}
