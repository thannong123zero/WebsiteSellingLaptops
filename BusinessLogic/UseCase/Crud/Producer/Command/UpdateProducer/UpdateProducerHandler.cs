using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IProducerRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Producer.Command.UpdateProducer
{
    public class UpdateProducerHandler : IRequestHandler<UpdateProducerRequest, ProducerViewModel>
    {
        public readonly IProducerQueryRepository _producerQueryRepository;
        public readonly IProducerCommandRepository _producerCommandRepository;
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public UpdateProducerHandler(IProducerQueryRepository producerQueryRepository,
            IProducerCommandRepository producerCommandRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _producerQueryRepository = producerQueryRepository;
            _producerCommandRepository = producerCommandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ProducerViewModel> Handle(UpdateProducerRequest request, CancellationToken cancellationToken)
        {
            var producer = await _producerQueryRepository.GetByIdAsync(request.Id);

            if (producer == null)
            {
                throw new DomainException("ProducerId does not exist!");
            }
            _mapper.Map(request, producer);
            producer.UpdateAt = DateTime.Now;
            _producerCommandRepository.Update(producer);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ProducerViewModel>(producer);
        }
    }
}
