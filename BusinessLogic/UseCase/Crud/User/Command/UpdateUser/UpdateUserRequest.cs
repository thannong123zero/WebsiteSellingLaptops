using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.User.Command.UpdateUser
{
    public class UpdateUserRequest : IRequest<UserViewModel>
    {
        public Guid Id { get; set; }
        public string CitizenId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public byte Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string? Avatatar { get; set; }
    }
}
