using BusinessLogic.Extentions;
using System.Net;

namespace WebsiteSellingLaptops.CustomController
{
    public sealed class Response : IResponse
    {
        public Response(string message = Constants.RequestHandling.Messages.Success,
                        HttpStatusCode httpStatusCode = HttpStatusCode.OK)
        {
            Message = message;
            StatusCode = httpStatusCode;
        }

        public HttpStatusCode StatusCode { get; }

        public string Message { get; }
    }

    public sealed class Response<T> : IResponse<T>
    {
        public Response(string message = Constants.RequestHandling.Messages.Success,
                        HttpStatusCode httpStatusCode = HttpStatusCode.OK,
                        T data = default)
        {
            Message = message;
            StatusCode = httpStatusCode;
            Data = data;
        }

        public HttpStatusCode StatusCode { get; }

        public string Message { get; }

        public T Data { get; }
    }
}
