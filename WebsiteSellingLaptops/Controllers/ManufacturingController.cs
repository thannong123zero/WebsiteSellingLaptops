using BusinessLogic.UseCase.Crud.Manufacturing.Command.AddManufacturing;
using BusinessLogic.UseCase.Crud.Manufacturing.Command.DeleteManufacturing;
using BusinessLogic.UseCase.Crud.Manufacturing.Command.RestoreManufacturing;
using BusinessLogic.UseCase.Crud.Manufacturing.Command.UpdateManufacturing;
using BusinessLogic.UseCase.Crud.Manufacturing.Query.GetManufacturing;
using BusinessLogic.UseCase.Crud.Manufacturing.Query.GetManufacturings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebsiteSellingLaptops.CustomController;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/Manufacturings")]
    [Authorize(Roles ="Admin,Staff")]
    public class ManufacturingController : BaseApi<ManufacturingController>
    {
        public ManufacturingController(ICommonComponents<ManufacturingController> commonComponents) : base(commonComponents){}

        [HttpPost]
        [Route("AddManufacturing")]
        public async Task<IResponse> AddManufacturing([FromBody] AddManufacturingRequest addManufacturingRequest)
        {
            return Success(data: await _commonComponents.Router.Send(addManufacturingRequest));
        }

        [HttpPut]
        [Route("UpdateManufacturing")]
        public async Task<IResponse> UpdateManufacturing([FromBody] UpdateManufacturingRequest updateManufacturingRequest)
        {
            return Success(data: await _commonComponents.Router.Send(updateManufacturingRequest));
        }

        [HttpDelete]
        [Route("DeleteManufacturing")]
        public async Task<IResponse> DeleteManufacturing([FromQuery] DeleteManufacturingRequest deleteManufacturingRequest)
        {
            return Success(data: await _commonComponents.Router.Send(deleteManufacturingRequest));
        }
        [HttpPatch]
        [Route("RestoreManufacturing")]
        public async Task<IResponse> RestoreManufacturing([FromQuery] RestoreManufacturingRequest restoreManufacturingRequest)
        {
            return Success(data: await _commonComponents.Router.Send(restoreManufacturingRequest));
        }

        [HttpGet]
        [Route("GetManufacturings")]
        [AllowAnonymous]
        public async Task<IResponse> GetManufacturings([FromQuery] GetManufacturingsRequest getManufacturingsRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getManufacturingsRequest));
        }
        [HttpGet]
        [Route("GetManufacturing")]
        public async Task<IResponse> GetManufacturing([FromQuery] GetManufacturingRequest getManufacturingRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getManufacturingRequest));
        }
    }
}
