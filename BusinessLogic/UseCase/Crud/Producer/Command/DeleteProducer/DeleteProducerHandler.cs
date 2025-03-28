﻿using AutoMapper;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IProducerRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Producer.Command.DeleteProducer
{
    public class DeleteProducerHandler : IRequestHandler<DeleteProducerRequest, IActionResult>
    {
        public readonly IProducerQueryRepository _producerQueryRepository;
        public readonly IProducerCommandRepository _producerCommandRepository;
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public DeleteProducerHandler(IProducerQueryRepository producerQueryRepository,
            IProducerCommandRepository producerCommandRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _producerQueryRepository = producerQueryRepository;
            _producerCommandRepository = producerCommandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Handle(DeleteProducerRequest request, CancellationToken cancellationToken)
        {
            var producer = _producerQueryRepository.Find(p => p.Id == request.Id).FirstOrDefault();
            if (producer == null)
            {
                throw new DomainException("Category Id does not exist!");
            }
            _producerCommandRepository.SoftDelete(producer);

            await _unitOfWork.SaveChangesAsync();

            return new StatusCodeResult(200);
        }
    }
}
