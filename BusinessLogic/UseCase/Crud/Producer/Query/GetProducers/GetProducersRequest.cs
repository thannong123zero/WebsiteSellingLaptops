using BusinessLogic.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Producer.Query.GetProducers
{
    public class GetProducersRequest : IRequest<List<ProducerViewModel>>
    {
    }
}
