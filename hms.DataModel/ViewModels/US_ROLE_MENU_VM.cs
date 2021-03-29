using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel.ViewModels
{
    public class US_ROLE_MENU_VM
    {
        public string Parent_Name { get; set; }
        public string Parent_Icon { get; set; }
        public int Child_Id { get; set; }
        public string Child_Name { get; set; }
        public string Child_Icon { get; set; }
        public bool Active { get; set; }
    }
}
