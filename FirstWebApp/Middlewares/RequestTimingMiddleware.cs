using System.Diagnostics;

namespace FirstWebApp.Middlewares
{
    public class RequestTimingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestTimingMiddleware> _logger;

        // The pipeline passes the next middleware component through the constructor
        public RequestTimingMiddleware(RequestDelegate next, ILogger<RequestTimingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        // This method must be named Invoke or InvokeAsync
        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            // 1. Logic BEFORE the next middleware runs
            _logger.LogInformation($"Starting request: {context.Request.Method} {context.Request.Path}");

            // 2. Call the next middleware in the pipeline
            await _next(context);

            // 3. Logic AFTER the next middleware runs
            stopwatch.Stop();
            var elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            _logger.LogInformation($"Finished request in {elapsedMilliseconds}ms with Status Code: {context.Response.StatusCode}");
        }
    }
}
