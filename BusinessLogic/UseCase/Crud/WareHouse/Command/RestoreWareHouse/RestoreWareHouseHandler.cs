using AutoMapper;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IWareHouseRepository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.WareHouse.Command.RestoreWareHouse
{
    public class RestoreWareHouseHandler : IRequestHandler<RestoreWareHouseRequest, IActionResult>
    {
        private readonly IWareHouseCommandRepository _wareHouseCommandRepository;
        private readonly IWareHouseQueryRepository _wareHouseQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RestoreWareHouseHandler(IWareHouseCommandRepository wareHouseCommandRepository,
            IWareHouseQueryRepository wareHouseQueryRepository,
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            _wareHouseCommandRepository = wareHouseCommandRepository;
            _wareHouseQueryRepository = wareHouseQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Handle(RestoreWareHouseRequest request, CancellationToken cancellationToken)
        {
            var wareHouse = _wareHouseQueryRepository.Find(p => p.Id == request.Id,withDeleteFlag:false).FirstOrDefault();
            if (wareHouse == null)
            {
                throw new DomainException("WareHouse Id does not exist!");
            }
            _wareHouseCommandRepository.RestoreDelete(wareHouse);

            await _unitOfWork.SaveChangesAsync();

            return new StatusCodeResult(200);
        }
    }
}
