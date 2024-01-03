using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspNetRequestLifeCycle.ActionFilters
{
    public class WarningFilterAttribute : ActionFilterAttribute
    {
        private readonly string _severity;

        public WarningFilterAttribute(string severity)
        {
            _severity = severity;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            
            Debug.WriteLine($"Pre-Warning on {context.ActionDescriptor.DisplayName}: {_severity}");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine($"Post-Warning on {context.ActionDescriptor.DisplayName}: {_severity}");
        }
    }
}
