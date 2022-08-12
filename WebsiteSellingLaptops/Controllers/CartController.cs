using BusinessLogic.UseCase.Crud.Cart.Command.AddCart;
using BusinessLogic.UseCase.Crud.Cart.Command.DeleteCart;
using BusinessLogic.UseCase.Crud.Cart.Command.RestoreCart;
using BusinessLogic.UseCase.Crud.Cart.Command.UpdateCart;
using BusinessLogic.UseCase.Crud.Cart.Query.GetCart;
using BusinessLogic.UseCase.Crud.Cart.Query.GetCarts;
using Microsoft.AspNetCore.Mvc;
using WebsiteSellingLaptops.CustomController;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/Carts")]
    public class CartController : BaseApi<CartController>
    {
        public CartController(ICommonComponents<CartController> commonComponents) : base(commonComponents) { }


    [HttpPost]
    [Route("AddCart")]
    public async Task<IResponse> AddCart([FromBody] AddCartRequest addCartRequest)
    {
        return Success(data: await _commonComponents.Router.Send(addCartRequest));
    }

    [HttpPut]
    [Route("UpdateCart")]
    public async Task<IResponse> UpdateCart([FromBody] UpdateCartRequest updateCartRequest)
    {
        return Success(data: await _commonComponents.Router.Send(updateCartRequest));
    }

    [HttpDelete]
    [Route("DeleteCart")]
    public async Task<IResponse> DeleteCart([FromQuery] DeleteCartRequest deleteCartRequest)
    {
        return Success(data: await _commonComponents.Router.Send(deleteCartRequest));
    }
    [HttpPatch]
    [Route("RestoreCart")]
    public async Task<IResponse> RestoreCart([FromQuery] RestoreCartRequest restoreCartRequest)
    {
        return Success(data: await _commonComponents.Router.Send(restoreCartRequest));
    }

    [HttpGet]
    [Route("GetCarts")]
    public async Task<IResponse> GetCategories([FromQuery] GetCartsRequest getCartsRequest)
    {
        return Success(data: await _commonComponents.Router.Send(getCartsRequest));
    }
    [HttpGet]
    [Route("GetCart")]
    public async Task<IResponse> GetCart([FromQuery] GetCartRequest getCartRequest)
    {
        return Success(data: await _commonComponents.Router.Send(getCartRequest));
    }

}
}
