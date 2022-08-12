using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Cart.Command.RestoreCart
{
    public class RestoreCartRequest : IRequest<IActionResult>
    {
        public Guid Id { get; set; }
    }
}
