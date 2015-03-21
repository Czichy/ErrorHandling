using System;
using System.Web;
using System.Web.Mvc;

namespace ErrorHandling.Controllers
{
    public class CamelCaseJsonResult : System.Web.Mvc.JsonResult
    {
        public CamelCaseJsonResult()
        {
        }

        public CamelCaseJsonResult(object data)
        {
            Data = data;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = "application/json";

            string serializedData = Json.Serialize(Data);
            response.Write(serializedData);
        }
    }
}