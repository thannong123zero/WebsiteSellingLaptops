using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Producer.Command.UpdateProducer
{
    public class UpdateProducerRequest : IRequest<ProducerViewModel>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string NumberPhone { get; set; }
    }
}
