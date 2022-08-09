using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.User.Command.AddUser
{
    public class AddUserHandler : IRequestHandler<AddUserRequest, UserViewModel>
    {
        public AddUserHandler()
        {

        }
        public async Task<UserViewModel> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {

            return null;
        }
    }
}
