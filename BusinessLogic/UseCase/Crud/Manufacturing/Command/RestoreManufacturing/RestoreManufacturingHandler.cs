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

namespace BusinessLogic.UseCase.Crud.Manufacturing.Command.RestoreManufacturing
{
    public class RestoreManufacturingHandler : IRequestHandler<RestoreManufacturingRequest, IActionResult>
    {
        public readonly IManufacturingCommandRepository _manufacturingCommandRepository;
        public readonly IManufacturingQueryRepository _manufacturingQueryRepository;
        public readonly IUnitOfWork _unitOfWork;
        public RestoreManufacturingHandler(IManufacturingCommandRepository manufacturingCommandRepository,
            IManufacturingQueryRepository manufacturingQueryRepository,
            IUnitOfWork unitOfWork)
        {
            _manufacturingCommandRepository = manufacturingCommandRepository;
            _manufacturingQueryRepository = manufacturingQueryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Handle(RestoreManufacturingRequest request, CancellationToken cancellationToken)
        {
            var manufacturing = _manufacturingQueryRepository.Find(s => s.Id == request.Id, withDeleteFlag: false).FirstOrDefault();
            if (manufacturing == null)
            {
                throw new DomainException("ManufacturingId is not empty!");
            }
            _manufacturingCommandRepository.RestoreDelete(manufacturing);
            await _unitOfWork.SaveChangesAsync();
            return new StatusCodeResult(200);
        }
    }
}
