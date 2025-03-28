﻿using AutoMapper;
using BusinessLogic.ViewModel;
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

namespace BusinessLogic.UseCase.Crud.WareHouse.Command.UpdateWareHouse
{
    public class UpdateWareHouseHandler : IRequestHandler<UpdateWareHouseRequest, WareHouseViewModel>
    {
        private readonly IWareHouseCommandRepository _wareHouseCommandRepository;
        private readonly IWareHouseQueryRepository _wareHouseQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateWareHouseHandler(IWareHouseCommandRepository wareHouseCommandRepository,
            IWareHouseQueryRepository wareHouseQueryRepository,
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            _wareHouseCommandRepository = wareHouseCommandRepository;
            _wareHouseQueryRepository = wareHouseQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<WareHouseViewModel> Handle(UpdateWareHouseRequest request, CancellationToken cancellationToken)
        {
            var wareHouse = await _wareHouseQueryRepository.GetByIdAsync(request.Id);

            if (wareHouse == null)
            {
                throw new DomainException("WareHouse Id does not exist!");
            }
            _mapper.Map(request, wareHouse);
            wareHouse.UpdateAt = DateTime.Now;
            _wareHouseCommandRepository.Update(wareHouse);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<WareHouseViewModel>(wareHouse);
        }
    }
}
