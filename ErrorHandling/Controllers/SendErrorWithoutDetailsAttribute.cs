using System;
using System.Net;
using System.Web.Mvc;

namespace ErrorHandling.Controllers
{
    public class SendErrorWithoutDetailsAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled)
            {
                return;
            }

            LogException(filterContext.Exception);

            filterContext.Result = new HttpStatusCodeResult(HttpStatusCode.InternalServerError);

            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Clear();
        }

        private void LogException(Exception exception)
        {
        }
    }
}