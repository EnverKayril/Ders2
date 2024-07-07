using Microsoft.AspNetCore.Mvc.Filters;

namespace _12_MVC_ActionFilter.Filters
{
    public class LogActionFilter : IActionFilter
    {
        // Controller Action çalıştırıldıktan sonra bu metot çalışır.
        public void OnActionExecuted(ActionExecutedContext context)
        {
            string cntrlName = context.RouteData.Values["controller"].ToString();
            string actionName = context.RouteData.Values["action"].ToString();

            string logMessage = $"Executed {cntrlName} - {actionName} at {DateTime.Now}";

            LogToYourSystem(logMessage);
        }

        // Controller Action çalıştırılmadan önce bu metot çalışır.
        public void OnActionExecuting(ActionExecutingContext context)
        {
            string cntrlName = context.RouteData.Values["controller"].ToString();
            string actionName = context.RouteData.Values["action"].ToString();

            string logMessage = $"Executing {cntrlName} - {actionName} at {DateTime.Now}";
            LogToYourSystem(logMessage);
        }

        private void LogToYourSystem(string message)
        {

        }
    }
}
