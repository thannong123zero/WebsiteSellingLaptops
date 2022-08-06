using MediatR;
namespace WebsiteSellingLaptops.CustomController
{
    public sealed class CommonComponents<TCaller> : ICommonComponents<TCaller>
    {
        public IMediator Router { get; }

        public ILogger Logger { get; }

        public CommonComponents(IMediator router, ILogger<TCaller> logger)
        {
            Router = router;
            Logger = logger;
        }
    }
}
