using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLogic.UseCase.Crud.Producer.Command.DeleteProducer
{
    public class DeleteProducerRequest : IRequest<IActionResult>
    {
        public Guid Id { get; set; }
    }
}
