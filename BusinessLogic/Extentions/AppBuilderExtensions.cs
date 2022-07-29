using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;


namespace BusinessLogic.Extentions
{
    public static class AppBuilderExtensions
    {
        public static object GetExceptionHandler(this IServiceProvider serviceProvider, Exception exception)
        {
            var concreteType = typeof(IExceptionHandler<,>).MakeGenericType(exception.GetType(), typeof(ProblemDetails));

            var exceptionHandler = serviceProvider.GetService(concreteType);

            if (exceptionHandler == null)
            {
                exceptionHandler = serviceProvider.GetService(typeof(IExceptionHandler<Exception, ProblemDetails>));
            }

            return exceptionHandler;
        }

    }
}
