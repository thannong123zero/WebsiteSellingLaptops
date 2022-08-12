using AutoMapper;
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

namespace BusinessLogic.UseCase.Crud.WareHouse.Query.GetWareHouse
{
    public class GetWareHouseHandler : IRequestHandler<GetWareHouseRequest, WareHouseViewModel>
    {
        private readonly IWareHouseQueryRepository _wareHouseQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetWareHouseHandler(IWareHouseQueryRepository wareHouseQueryRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _wareHouseQueryRepository = wareHouseQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<WareHouseViewModel> Handle(GetWareHouseRequest request, CancellationToken cancellationToken)
        {
            var wareHouse = _wareHouseQueryRepository.Find(c => c.Id == request.Id).FirstOrDefault();
            if (wareHouse == null)
            {
                throw new DomainException("WareHouse Id does not exist!");
            }
            return _mapper.Map<WareHouseViewModel>(wareHouse);
        }
    }
}
