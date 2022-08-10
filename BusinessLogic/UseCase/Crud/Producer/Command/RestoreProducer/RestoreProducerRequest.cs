using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Producer.Command.RestoreProducer
{
    public class RestoreProducerRequest : IRequest<IActionResult>
    {
        public Guid Id { get; set; }
    }
}
