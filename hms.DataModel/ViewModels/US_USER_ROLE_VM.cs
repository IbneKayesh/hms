using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.DataModel.ViewModels
{
    public class US_USER_ROLE_VM
    {
        public int USER_ID { get; set; }
        [DisplayName("User Id")]
        public string UserId { get; set; }
        [DisplayName("User Name")]
        public string UserName { get; set; }
        public List<user_role_list_vm> user_role_list { get; set; }
    }
    public class user_role_list_vm
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool Active { get; set; }
    }

}
