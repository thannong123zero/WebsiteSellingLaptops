using AutoMapper;
using BusinessLogic.Extentions;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IUserRepository;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.User.Command.AddUser
{
    public class AddUserHandler : IRequestHandler<AddUserRequest, UserViewModel>
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly IMapper _mapper;
        public AddUserHandler(
            UserManager<UserModel> userManager,
            IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<UserViewModel> Handle(AddUserRequest request, CancellationToken cancellationToken)
        { 
            var user = _mapper.Map<UserModel>(request);
            user.UserName = request.Email;

            var result = await _userManager.CreateAsync(user, request.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Staff");
            }
            if(result.Errors != null)
            {
                result.Errors.ToList().ForEach(error =>
                {
                    throw new Exception(error.ToString());
                });
            }

            return _mapper.Map<UserViewModel>(user);
        }
    }
}
