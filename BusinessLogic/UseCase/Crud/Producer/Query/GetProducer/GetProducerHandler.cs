using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories.IProducerRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Producer.Query.GetProducer
{
    public class GetProducerHandler : IRequestHandler<GetProducerRequest, ProducerViewModel>
    {
        private readonly IProducerQueryRepository _producerQueryRepository;
        private readonly IMapper _mapper;
        public GetProducerHandler(IProducerQueryRepository producerQueryRepository,
        IMapper mapper)
        {
            _producerQueryRepository = producerQueryRepository;
            _mapper = mapper;
        }
        public async Task<ProducerViewModel> Handle(GetProducerRequest request, CancellationToken cancellationToken)
        {
            var producer = _producerQueryRepository.Find(c => c.Id == request.Id).FirstOrDefault();
            if (producer == null)
            {
                throw new DomainException("ProducerId does not exist!");
            }
            return _mapper.Map<ProducerViewModel>(producer);
        }
    }
}
