using AutoMapper;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IManufacturingRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Manufacturing.Command.DeleteManufacturing
{
    public class DeleteManufacturingHandler : IRequestHandler<DeleteManufacturingRequest, IActionResult>
    {
        public readonly IManufacturingCommandRepository _manufacturingCommandRepository;
        public readonly IManufacturingQueryRepository _manufacturingQueryRepository;
        public readonly IUnitOfWork _unitOfWork;
        public DeleteManufacturingHandler(IManufacturingCommandRepository manufacturingCommandRepository,
            IManufacturingQueryRepository manufacturingQueryRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _manufacturingCommandRepository = manufacturingCommandRepository;
            _manufacturingQueryRepository = manufacturingQueryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Handle(DeleteManufacturingRequest request, CancellationToken cancellationToken)
        {
            var manufacturing = _manufacturingQueryRepository.Find(s => s.Id == request.Id).FirstOrDefault();
            if(manufacturing == null)
            {
                throw new DomainException("ManufacturingId is not empty!");
            }
            _manufacturingCommandRepository.SoftDelete(manufacturing);
            await _unitOfWork.SaveChangesAsync();
            return new StatusCodeResult(200);
        }
    }
}
