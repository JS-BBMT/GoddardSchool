using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FranchiseePortal.Web.Logging
{
    /// <summary>
    /// credit: https://blog.elmah.io/asp-net-core-request-logging-middleware/
    /// </summary>
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<RequestLoggingMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            finally
            {
                // Trying to follow default W3C format w/in reason
                // #Fields: date time c-ip s-computername s-ip s-port cs-method cs-uri-stem cs-uri-query sc-status time-taken cs-version cs-host cs(User-Agent) cs(Referer)
                _logger.LogInformation(
                    "{cs-method} {cs-uri-stem} {cs-uri-query} {sc-status} {cs(User-Agent)} {cs(Referer)}",
                    context.Request?.Method,                    
                    context.Request?.Path.Value,
                    string.IsNullOrEmpty(context.Request?.QueryString.Value) ? "-" : context.Request?.QueryString.Value,
                    context.Response?.StatusCode,
                    string.IsNullOrEmpty(context.Request?.Headers["User-Agent"]) ? "-" : context.Request?.Headers["User-Agent"],
                    string.IsNullOrEmpty(context.Request?.Headers["Referrer"]) ? "-" : context.Request?.Headers["Referer"]
                    );
            }
        }
    }
}
