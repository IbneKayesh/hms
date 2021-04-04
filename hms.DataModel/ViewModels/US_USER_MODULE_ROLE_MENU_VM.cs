using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel.ViewModels
{
    public class US_USER_MODULE_ROLE_MENU_VM
    {
        public int Module_Id { get; set; }
        public string Module_Icon { get; set; }
        public string Module_Name { get; set; }
        public int View_Order { get; set; }
        public string Method_Name { get; set; }
        public string Parent_name { get; set; }
        public string Parent_Icon { get; set; }
        public int Child_Id { get; set; }
        public string Child_Icon { get; set; }
        public string Child_Name { get; set; }
        public string Area_Name { get; set; }
        public string Controller_Name { get; set; }
        public string Action_Name { get; set; }
    }
}
