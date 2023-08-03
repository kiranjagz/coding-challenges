using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

public class ExecutionTimeLogFilter : IActionFilter
{
    private readonly ILogger<ExecutionTimeLogFilter> _logger;
    private DateTime _startTime;

    public ExecutionTimeLogFilter(ILogger<ExecutionTimeLogFilter> logger)
    {
        _logger = logger;
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        // This method is executed before the action method is called.

        context.HttpContext.Items["NewKey"] = "NewValue";

        _startTime = DateTime.Now;
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        // This method is executed after the action method has been called.
        var executionTime = DateTime.Now - _startTime;

        // Log the execution time.
        _logger.LogInformation($"Action '{context.ActionDescriptor.DisplayName}' took {executionTime.TotalMilliseconds} ms to execute.");
    }
}
