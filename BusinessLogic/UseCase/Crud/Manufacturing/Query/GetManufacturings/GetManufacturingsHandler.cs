using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories.IManufacturingRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Manufacturing.Query.GetManufacturings
{
    public class GetManufacturingsHandler : IRequestHandler<GetManufacturingsRequest, List<ManufacturingViewModel>>
    {
        private readonly IManufacturingQueryRepository _manufacturingQueryRepository;
        private readonly IMapper _mapper;
        public GetManufacturingsHandler(IManufacturingQueryRepository manufacturingQueryRepository, IMapper mapper)
        {
            _manufacturingQueryRepository = manufacturingQueryRepository;
            _mapper = mapper;
        }
        public async Task<List<ManufacturingViewModel>> Handle(GetManufacturingsRequest request, CancellationToken cancellationToken)
        {
            var listManufacturing = await _manufacturingQueryRepository.GetAllAsync();
            List<ManufacturingViewModel> manufacturingViewModels = new List<ManufacturingViewModel>();

            listManufacturing.ForEach(s => manufacturingViewModels.Add(_mapper.Map<ManufacturingViewModel>(s)));
            return manufacturingViewModels;
        }
    }
}
