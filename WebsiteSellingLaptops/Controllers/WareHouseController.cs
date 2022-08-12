using BusinessLogic.UseCase.Crud.WareHouse.Command.AddWareHouse;
using BusinessLogic.UseCase.Crud.WareHouse.Command.DeleteWareHouse;
using BusinessLogic.UseCase.Crud.WareHouse.Command.RestoreWareHouse;
using BusinessLogic.UseCase.Crud.WareHouse.Command.UpdateWareHouse;
using BusinessLogic.UseCase.Crud.WareHouse.Query.GetWareHouse;
using BusinessLogic.UseCase.Crud.WareHouse.Query.GetWareHouses;
using Microsoft.AspNetCore.Mvc;
using WebsiteSellingLaptops.CustomController;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/WareHouses")]
    public class WareHouseController : BaseApi<WareHouseController>
    {

        public WareHouseController(ICommonComponents<WareHouseController> commonComponents) : base(commonComponents) { }


        [HttpPost]
        [Route("AddWareHouse")]
        public async Task<IResponse> AddWareHouse([FromBody] AddWareHouseRequest addWareHouseRequest)
        {
            return Success(data: await _commonComponents.Router.Send(addWareHouseRequest));
        }

        [HttpPut]
        [Route("UpdateWareHouse")]
        public async Task<IResponse> UpdateWareHouse([FromBody] UpdateWareHouseRequest updateWareHouseRequest)
        {
            return Success(data: await _commonComponents.Router.Send(updateWareHouseRequest));
        }

        [HttpDelete]
        [Route("DeleteWareHouse")]
        public async Task<IResponse> DeleteWareHouse([FromQuery] DeleteWareHouseRequest deleteWareHouseRequest)
        {
            return Success(data: await _commonComponents.Router.Send(deleteWareHouseRequest));
        }
        [HttpPatch]
        [Route("RestoreWareHouse")]
        public async Task<IResponse> RestoreWareHouse([FromQuery] RestoreWareHouseRequest restoreWareHouseRequest)
        {
            return Success(data: await _commonComponents.Router.Send(restoreWareHouseRequest));
        }

        [HttpGet]
        [Route("GetWareHouses")]
        public async Task<IResponse> GetCategories([FromQuery] GetWareHousesRequest getWareHousesRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getWareHousesRequest));
        }
        [HttpGet]
        [Route("GetWareHouse")]
        public async Task<IResponse> GetWareHouse([FromQuery] GetWareHouseRequest getWareHouseRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getWareHouseRequest));
        }

    }
}
