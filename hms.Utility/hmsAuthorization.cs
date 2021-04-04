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
        public string role_name { get; set; }
        private readonly ISession session;
        private IHttpContextAccessor _httpContextAccessor;
        public hmsAuthorization()
        {

        }
        public hmsAuthorization(IHttpContextAccessor httpContextAccessor)
        {
            this.session = httpContextAccessor.HttpContext.Session;
            _httpContextAccessor = httpContextAccessor;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var _data = SessionHelper.GetObjectFromJson<List<US_USER_MODULE_ROLE_MENU_VM>>(session, "_all_menus");
            string path = _httpContextAccessor.HttpContext.Request.Path;
            string query = _httpContextAccessor.HttpContext.Request.Scheme;
            string redirectUrl = string.Format("?next_ride={0}", query);// filterContext.HttpContext.Request.Url.PathAndQuery);
            var SessionData = this.session.GetString("roles");

            if (SessionData == null)
            {
                CleanSession();
                filterContext.Result = new RedirectResult("~/Accounts/Signin" + redirectUrl, true);
                return;
            }
            List<string> roles = role_name.Split(',').ToList<string>();
            var _session_id = Convert.ToString(SessionData);
            bool is_accessable = false;
            foreach (string item in roles)
            {
                if (item == _session_id)
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
                CleanSession();
                filterContext.HttpContext.Response.Redirect("~/Accounts/Signin", true);
                return;
            }
        }

        public void CleanSession()
        {
            //HttpContext.Current.Session.Clear();
            //HttpContext.Current.Session.Abandon();
            this.session.Clear();
        }
    }
}
