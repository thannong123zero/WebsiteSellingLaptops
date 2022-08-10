using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.User.Query.GetUser
{
    public class GetUserRequest : IRequest<UserViewModel>
    {
        public Guid Id { get; set; }
    }
}
