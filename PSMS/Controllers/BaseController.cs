using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSMS.Controllers
{
    public class BaseController : Controller
    {
        public long UserId
        {
            get
            {
                return 1;
                //HttpCookie userCookie = (HttpCookie)Session[Constants.SESSION_USER];
                //long Id = userCookie == null ? 0 : Convert.ToInt64(userCookie["UserID"]);
                //return Id;
            }
            set { }
        }

        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    filterContext.ExceptionHandled = true;
        //    filterContext.Result = View("Error", new HandleErrorInfo(filterContext.Exception, "controller", "action"));
        //}
    }
}