using MediatR;
namespace WebsiteSellingLaptops.CustomController
{
    public interface ICommonComponents<TCaller>
    {
        IMediator Router { get; }

        ILogger Logger { get; }
    }
}
