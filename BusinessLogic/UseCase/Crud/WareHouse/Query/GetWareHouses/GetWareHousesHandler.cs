using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IWareHouseRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.WareHouse.Query.GetWareHouses
{
    public class GetWareHousesHandler : IRequestHandler<GetWareHousesRequest, List<WareHouseViewModel>>
    {
        private readonly IWareHouseQueryRepository _wareHouseQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetWareHousesHandler(IWareHouseQueryRepository wareHouseQueryRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _wareHouseQueryRepository = wareHouseQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<WareHouseViewModel>> Handle(GetWareHousesRequest request, CancellationToken cancellationToken)
        {
            var listWare = await _wareHouseQueryRepository.GetAllAsync();

            List<WareHouseViewModel> result = new List<WareHouseViewModel>();

            listWare.ForEach(s => result.Add(_mapper.Map<WareHouseViewModel>(s)));

            return result;
        }
    }
}
