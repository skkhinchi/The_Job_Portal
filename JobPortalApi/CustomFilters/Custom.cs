

using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace JobPortalApi.CustomFilters
{
    public class Custom : ActionFilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // throw new System.NotImplementedException();
            Debug.WriteLine("Hello OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // throw new System.NotImplementedException();
            Debug.WriteLine("Hello OnActionExecuting");
        }
    }
}
