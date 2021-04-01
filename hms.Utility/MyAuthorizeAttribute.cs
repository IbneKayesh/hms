using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.Utility
{
    public enum PermissionItem
    {
        User,
        Product,
        Contact,
        Review,
        Client
    }

    public enum PermissionAction
    {
        Read,
        Create,
    }


    public class MyAuthorizeAttribute : TypeFilterAttribute
    {
        public MyAuthorizeAttribute(PermissionItem item, PermissionAction action)
        : base(typeof(AuthorizeActionFilter))
        {
            Arguments = new object[] { item, action };
        }

        public class AuthorizeActionFilter : IAuthorizationFilter
        {
            private readonly PermissionItem _item;
            private readonly PermissionAction _action;
            public AuthorizeActionFilter(PermissionItem item, PermissionAction action)
            {
                _item = item;
                _action = action;
            }
            public void OnAuthorization(AuthorizationFilterContext context)
            {
                bool isAuthorized = true;// MumboJumboFunction(context.HttpContext.User, _item, _action); // :)

                if (!isAuthorized)
                {
                    context.Result = new ForbidResult();
                }
            }
            public bool MumboJumboFunction(string user, PermissionItem item, PermissionAction action)
            {
                return true;
            }
        }

    }
}
