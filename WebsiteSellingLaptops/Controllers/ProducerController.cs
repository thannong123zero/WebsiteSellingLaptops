using BusinessLogic.UseCase.Crud.Producer.Command.AddProducer;
using BusinessLogic.UseCase.Crud.Producer.Command.DeleteProducer;
using BusinessLogic.UseCase.Crud.Producer.Command.RestoreProducer;
using BusinessLogic.UseCase.Crud.Producer.Command.UpdateProducer;
using BusinessLogic.UseCase.Crud.Producer.Query.GetProducer;
using BusinessLogic.UseCase.Crud.Producer.Query.GetProducers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebsiteSellingLaptops.CustomController;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/Producers")]
    [Authorize(Roles = "Admin")]
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
        [HttpPut]
        [Route("UpdateProducer")]
        public async Task<IResponse> UpdateProducer([FromBody] UpdateProducerRequest updateProducerRequest)
        {
            return Success(data: await _commonComponents.Router.Send(updateProducerRequest));
        }

        [HttpDelete]
        [Route("DeleteProducer")]
        public async Task<IResponse> DeleteProducer([FromQuery] DeleteProducerRequest deleteProducerRequest)
        {
            return Success(data: await _commonComponents.Router.Send(deleteProducerRequest));
        }
        [HttpPatch]
        [Route("RestoreProducer")]
        public async Task<IResponse> RestoreProducer([FromQuery] RestoreProducerRequest restoreProducerRequest)
        {
            return Success(data: await _commonComponents.Router.Send(restoreProducerRequest));
        }

        [HttpGet]
        [Route("GetProducers")]
        [AllowAnonymous]
        public async Task<IResponse> GetProducers([FromQuery] GetProducersRequest getProducersRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getProducersRequest));
        }
        [HttpGet]
        [Route("GetProducer")]
        [AllowAnonymous]
        public async Task<IResponse> GetProducer([FromQuery] GetProducerRequest getProducerRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getProducerRequest));
        }
    }
}
