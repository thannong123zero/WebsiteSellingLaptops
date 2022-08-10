using AutoMapper;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IProducerRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Producer.Command.RestoreProducer
{
    public class RestoreProducerHandler : IRequestHandler<RestoreProducerRequest, IActionResult>
    {
        public readonly IProducerQueryRepository _producerQueryRepository;
        public readonly IProducerCommandRepository _producerCommandRepository;
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public RestoreProducerHandler(IProducerQueryRepository producerQueryRepository,
            IProducerCommandRepository producerCommandRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _producerQueryRepository = producerQueryRepository;
            _producerCommandRepository = producerCommandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Handle(RestoreProducerRequest request, CancellationToken cancellationToken)
        {
            var producer = _producerQueryRepository.Find(p => p.Id == request.Id).FirstOrDefault();
            if (producer == null)
            {
                throw new DomainException("Producer Id does not exist!");
            }

            _producerCommandRepository.RestoreDelete(producer);

            await _unitOfWork.SaveChangesAsync();

            return new StatusCodeResult(200);
        }
    }
}
