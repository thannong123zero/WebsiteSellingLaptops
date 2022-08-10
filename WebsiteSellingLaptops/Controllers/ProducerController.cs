using BusinessLogic.UseCase.Crud.Producer.Command.AddProducer;
using Microsoft.AspNetCore.Mvc;
using WebsiteSellingLaptops.CustomController;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/Producer")]
    public class ProducerController : BaseApi<ProducerController>
    {
        public ProducerController(ICommonComponents<ProducerController> commonComponents) : base(commonComponents)
        {
        }

        [HttpPost]
        [Route("AddProducer")]
        public async Task<IResponse> AddProducer([FromBody] AddProducerRequest addProducerRequest)
        {
            return Success(data: await _commonComponents.Router.Send(addProducerRequest));
        }
    }
}
