using System.Web.Mvc;
using ErrorHandling.Controllers;

namespace ErrorHandling
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new SendErrorWithoutDetailsAttribute());
        }
    }
}