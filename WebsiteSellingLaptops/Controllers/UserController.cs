using BusinessLogic.UseCase.Crud.User.Command.AddUser;
using BusinessLogic.UseCase.Crud.User.Command.DeteleUser;
using BusinessLogic.UseCase.Crud.User.Command.RestoreUser;
using BusinessLogic.UseCase.Crud.User.Command.UpdateUser;
using BusinessLogic.UseCase.Crud.User.Query.GetUsers;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebsiteSellingLaptops.CustomController;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/Users")]
    public class UserController :BaseApi<UserController>
    {

        public UserController(ICommonComponents<UserController> commonComponents) : base(commonComponents)
    {
    }


    [HttpPost]
    [Route("UserCategory")]
    public async Task<IResponse> AddCategory([FromBody] AddUserRequest addUserRequest)
    {
        return Success(data: await _commonComponents.Router.Send(addUserRequest));
    }

    [HttpPut]
    [Route("UpdateUser")]
    public async Task<IResponse> UpdateCategory([FromBody] UpdateUserRequest updateUserRequest)
    {
        return Success(data: await _commonComponents.Router.Send(updateUserRequest));
    }

    [HttpDelete]
    [Route("DeleteUser")]
    public async Task<IResponse> DeleteCategory([FromQuery] DeleteUserRequest deleteUserRequest)
    {
        return Success(data: await _commonComponents.Router.Send(deleteUserRequest));
    }
    [HttpPatch]
    [Route("RestoreUser")]
    public async Task<IResponse> RestoreCategory([FromQuery] RestoreUserRequest restoreUserRequest)
    {
        return Success(data: await _commonComponents.Router.Send(restoreUserRequest));
    }

    [HttpGet]
    [Route("GetUsers")]
    public async Task<IResponse> GetCategories([FromQuery] GetUsersRequest getUsersRequest)
    {
        return Success(data: await _commonComponents.Router.Send(getUsersRequest));
    }

}
}
