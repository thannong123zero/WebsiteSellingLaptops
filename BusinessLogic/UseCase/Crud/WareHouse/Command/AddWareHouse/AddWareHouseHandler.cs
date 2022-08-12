using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IWareHouseRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.WareHouse.Command.AddWareHouse
{
    public class AddWareHouseHandler : IRequestHandler<AddWareHouseRequest, WareHouseViewModel>
    {
        private readonly IWareHouseCommandRepository _wareHouseCommandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AddWareHouseHandler(IWareHouseCommandRepository wareHouseCommandRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _wareHouseCommandRepository = wareHouseCommandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<WareHouseViewModel> Handle(AddWareHouseRequest request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<WareHouseModel>(request);
            _wareHouseCommandRepository.Add(model);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<WareHouseViewModel>(model);
        }
    }
}
