using hms.DataModel.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.Utility
{
    public class hmsAuthorization : ActionFilterAttribute
    {
        public int controller_id { get; set; }
        public hmsAuthorization()
        {

        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var _data = hms.Utility.SessionHelper.GetObjectFromJson<List<US_USER_MODULE_ROLE_MENU_VM>>(filterContext.HttpContext.Session, "_all_menus");
            string path = filterContext.HttpContext.Request.Path;
            string nexturl = string.Format("?next_ride={0}", path);

            if (_data == null)
            {
                CleanSession(filterContext);
                filterContext.Result = new RedirectResult("~/Home/Login" + nexturl, true);
                return;
            }
            bool is_accessable = false;
            foreach (var item in _data)
            {

                if (item.Child_Id == controller_id)
                {
                    is_accessable = true;
                    break;
                }
            }

            if (is_accessable)
            {
                base.OnActionExecuting(filterContext);
            }
            else
            {
                CleanSession(filterContext);
                filterContext.Result = new RedirectResult("~/Home/Login" + nexturl, true);
                return;
            }
        }

        public void CleanSession(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Session.Clear();
        }
    }
}
