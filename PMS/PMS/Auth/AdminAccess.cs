using PMS.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Auth
{
    public class AdminAccess : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {

            if (httpContext.Session["user"] != null)
            {
                var user = (User)httpContext.Session["user"];
                if(user.Type.Equals("Admin"))
                    return true;
            }
            return false;
        }
    }
}