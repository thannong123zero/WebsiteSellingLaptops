using BusinessLogic.UseCase.Crud.User.Command.AddUser;
using BusinessLogic.UseCase.Crud.User.Command.DeteleUser;
using BusinessLogic.UseCase.Crud.User.Command.RestoreUser;
using BusinessLogic.UseCase.Crud.User.Command.UpdateUser;
using BusinessLogic.UseCase.Crud.User.Query.GetUser;
using BusinessLogic.UseCase.Crud.User.Query.GetUsers;
using BusinessLogic.UseCase.Crud.User.Query.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebsiteSellingLaptops.CustomController;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/Users")]
    [Authorize(Roles ="Admin, Staff")]
    public class UserController :BaseApi<UserController>
    {
        public UserController(ICommonComponents<UserController> commonComponents) : base(commonComponents) { }

    [HttpPost]
    [Route("AddUser")]
    public async Task<IResponse> AddUser([FromBody] AddUserRequest addUserRequest)
    {
        return Success(data: await _commonComponents.Router.Send(addUserRequest));
    }

    [HttpPut]
    [Route("UpdateUser")]
    public async Task<IResponse> UpdateUser([FromBody] UpdateUserRequest updateUserRequest)
    {
        return Success(data: await _commonComponents.Router.Send(updateUserRequest));
    }

    [HttpDelete]
    [Route("DeleteUser")]
    public async Task<IResponse> DeleteUser([FromQuery] DeleteUserRequest deleteUserRequest)
    {
        return Success(data: await _commonComponents.Router.Send(deleteUserRequest));
    }
    [HttpPatch]
    [Route("RestoreUser")]
    public async Task<IResponse> RestoreUser([FromQuery] RestoreUserRequest restoreUserRequest)
    {
        return Success(data: await _commonComponents.Router.Send(restoreUserRequest));
    }

    [HttpGet]
    [Route("GetUsers")]
    public async Task<IResponse> GetUsers([FromQuery] GetUsersRequest getUsersRequest)
    {
        return Success(data: await _commonComponents.Router.Send(getUsersRequest));
    }

    [HttpGet]
    [Route("GetUser")]
    public async Task<IResponse> GetUser([FromQuery] GetUserRequest getUserRequest)
    {
        return Success(data: await _commonComponents.Router.Send(getUserRequest));
    }

    [HttpPut]
    [Route("Login")]
    public async Task<IResponse> Login([FromBody] LoginRequest loginRequest)
        {
            return Success(data: await _commonComponents.Router.Send(loginRequest));
        }

    }
}
