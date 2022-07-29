using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using BusinessLogic.Extentions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebsiteSellingLaptops.MiddleWare
{
    public sealed class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }

        }

        private async Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            var exceptionHandler = httpContext.RequestServices.GetExceptionHandler(exception);

            ProblemDetails problemDetails = null;

            if (exceptionHandler != null)
            {
                var method = exceptionHandler.GetType().GetMethod(nameof(IExceptionHandler<Exception, ProblemDetails>.Handle));
                if (method != null)
                {
                    problemDetails = (ProblemDetails)method.Invoke(exceptionHandler, new object[] { exception });
                }
            }

            if (problemDetails == null)
            {
                problemDetails = new ProblemDetails
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Title = Constants.RequestHandling.Messages.UnhandledExceptionTitle,
                    Detail = exception.ToString()
                };
            }

            problemDetails.Instance = httpContext.Request.Path;

            httpContext.Response.StatusCode = problemDetails.Status.GetValueOrDefault((int)HttpStatusCode.BadRequest);
            httpContext.Response.ContentType = Constants.HTTPClient.Formatters.RESTfullProblemDetails;

            await httpContext.Response.WriteAsync(JsonSerializer.Serialize<object>(problemDetails));
        }
    }
}
