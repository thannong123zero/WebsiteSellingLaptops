using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories.IManufacturingRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Manufacturing.Query.GetManufacturing
{
    public class GetManufacturingHandler : IRequestHandler<GetManufacturingRequest, ManufacturingViewModel>
    {
        private readonly IManufacturingQueryRepository _manufacturingQueryRepository;
        private readonly IMapper _mapper;
        public GetManufacturingHandler(IManufacturingQueryRepository manufacturingQueryRepository, IMapper mapper)
        {
            _manufacturingQueryRepository = manufacturingQueryRepository;
            _mapper = mapper;
        }
        public async Task<ManufacturingViewModel> Handle(GetManufacturingRequest request, CancellationToken cancellationToken)
        {
            var manufacturing = _manufacturingQueryRepository.Find(s => s.Id == request.Id).FirstOrDefault();
            if(manufacturing == null)
            {
                throw new DomainException("ManufacturingId does not exist!");
            }
            return _mapper.Map<ManufacturingViewModel>(manufacturing);
        }
    }
}
