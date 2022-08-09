using System;
using Microsoft.AspNetCore.Mvc;

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
        #region Feature Toggles

        //public static IApplicationBuilder UseFeatureToggles(this IApplicationBuilder applicationBuilder, Action<IApplicationBuilder, IFeatureProvider> setupAction)
        //{
        //    var featureProvider = applicationBuilder.ApplicationServices.GetRequiredService<IFeatureProvider>();

        //    setupAction?.Invoke(applicationBuilder, featureProvider);

        //    return applicationBuilder;
        //}

        //public static IApplicationBuilder UseOpenAPI(this IApplicationBuilder applicationBuilder, Action<SwaggerUIOptions> setupAction = null)
        //{
        //    applicationBuilder.UseSwagger();

        //    var apiVersionDescriptionsProvider = applicationBuilder.ApplicationServices.GetService<IApiVersionDescriptionProvider>();

        //    applicationBuilder.UseSwaggerUI(opts =>
        //    {
        //        opts.DisplayRequestDuration();
        //        opts.RoutePrefix = string.Empty;

        //        setupAction?.Invoke(opts);

        //        foreach (var description in apiVersionDescriptionsProvider.ApiVersionDescriptions)
        //        {
        //            opts.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
        //                                 description.GroupName.ToUpperInvariant());
        //        }
        //    });

        //    return applicationBuilder;
        //}

        //public static IApplicationBuilder ExecuteDataSeeding(this IApplicationBuilder applicationBuilder, IServiceScope serviceScope)
        //{
        //    var seedingContexts = serviceScope.ServiceProvider.GetServices<ISeedingContext>();

        //    foreach (var seedingContext in seedingContexts)
        //    {
        //        seedingContext.Seed();
        //    }

        //    return applicationBuilder;
        //}

        #endregion
    }
}
