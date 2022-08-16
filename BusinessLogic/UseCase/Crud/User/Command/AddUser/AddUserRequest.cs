using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.User.Command.AddUser
{
    public class AddUserRequest : IRequest<UserViewModel>
    {   
        public string CitizenId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public byte Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string? Avatatar { get; set; }

        public string Password { get; set; }
        public string PasswordConfirmed { get; set; }
    }
}
