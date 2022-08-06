using System.Net;
using BusinessLogic.Extentions;
using Microsoft.AspNetCore.Mvc;

namespace WebsiteSellingLaptops.CustomController
{
    [ApiController]
    public abstract class BaseApi<TConcreteApi> : ControllerBase where TConcreteApi : class
    {
        protected readonly ICommonComponents<TConcreteApi> _commonComponents;

        protected BaseApi(ICommonComponents<TConcreteApi> commonComponents)
        {
            _commonComponents = commonComponents;
        }

        //protected PaginationResponse<T> CreatePaginationResponse<T>(PagedList<T> data,
        //                                                            string message = Constants.RequestHandling.Messages.Success,
        //                                                            HttpStatusCode statusCode = HttpStatusCode.OK)
        //{
        //    return new PaginationResponse<T>(data, message, statusCode);
        //}

        protected Response<T> Success<T>(string message = Constants.RequestHandling.Messages.Success, HttpStatusCode statusCode = HttpStatusCode.OK, T data = default)
        {
            return new Response<T>(message, statusCode, data: data);
        }

        protected Response Success(string message = Constants.RequestHandling.Messages.Success, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return new Response(message, statusCode);
        }
    }
}
