using BusinessLogic.UseCase.Crud.Wallet.Command.AddWallet;
using BusinessLogic.UseCase.Crud.Wallet.Command.DeleteWallet;
using BusinessLogic.UseCase.Crud.Wallet.Command.RestoreWallet;
using BusinessLogic.UseCase.Crud.Wallet.Command.UpdateWallet;
using BusinessLogic.UseCase.Crud.Wallet.Query.GetWallet;
using BusinessLogic.UseCase.Crud.Wallet.Query.GetWallets;
using Microsoft.AspNetCore.Mvc;
using WebsiteSellingLaptops.CustomController;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/Wallets")]
    public class WalletController : BaseApi<WalletController>
    {

        public WalletController(ICommonComponents<WalletController> commonComponents) : base(commonComponents) { }


        [HttpPost]
        [Route("AddWallet")]
        public async Task<IResponse> AddWallet([FromBody] AddWalletRequest addWalletRequest)
        {
            return Success(data: await _commonComponents.Router.Send(addWalletRequest));
        }

        [HttpPut]
        [Route("UpdateWallet")]
        public async Task<IResponse> UpdateWallet([FromBody] UpdateWalletRequest updateWalletRequest)
        {
            return Success(data: await _commonComponents.Router.Send(updateWalletRequest));
        }

        [HttpDelete]
        [Route("DeleteWallet")]
        public async Task<IResponse> DeleteWallet([FromQuery] DeleteWalletRequest deleteWalletRequest)
        {
            return Success(data: await _commonComponents.Router.Send(deleteWalletRequest));
        }
        [HttpPatch]
        [Route("RestoreWallet")]
        public async Task<IResponse> RestoreWallet([FromQuery] RestoreWalletRequest restoreWalletRequest)
        {
            return Success(data: await _commonComponents.Router.Send(restoreWalletRequest));
        }

        [HttpGet]
        [Route("GetWallets")]
        public async Task<IResponse> GetCategories([FromQuery] GetWalletsRequest getCategoriesRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getCategoriesRequest));
        }
        [HttpGet]
        [Route("GetWallet")]
        public async Task<IResponse> GetWallet([FromQuery] GetWalletRequest getWalletRequest)
        {
            return Success(data: await _commonComponents.Router.Send(getWalletRequest));
        }

    }
}
