using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.User.Command.DeteleUser
{
    public class DeleteUserRequest : IRequest<IActionResult>
    {
        public Guid Id { get; set; }
    }
}
