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

namespace BusinessLogic.UseCase.Crud.WareHouse.Command.DeleteWareHouse
{
    public class DeleteWareHouseHandler : IRequestHandler<DeleteWareHouseRequest, IActionResult>
    {
        private readonly IWareHouseCommandRepository _wareHouseCommandRepository;
        private readonly IWareHouseQueryRepository _wareHouseQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DeleteWareHouseHandler(IWareHouseCommandRepository wareHouseCommandRepository,
            IWareHouseQueryRepository wareHouseQueryRepository,
             IUnitOfWork unitOfWork, IMapper mapper)
        {
            _wareHouseCommandRepository = wareHouseCommandRepository;
            _wareHouseQueryRepository = wareHouseQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Handle(DeleteWareHouseRequest request, CancellationToken cancellationToken)
        {
            var wareHouse = _wareHouseQueryRepository.Find(p => p.Id == request.Id).FirstOrDefault();
            if (wareHouse == null)
            {
                throw new DomainException("WareHouse Id does not exist!");
            }
            _wareHouseCommandRepository.SoftDelete(wareHouse);

            await _unitOfWork.SaveChangesAsync();

            return new StatusCodeResult(200);
        }
    }
}
