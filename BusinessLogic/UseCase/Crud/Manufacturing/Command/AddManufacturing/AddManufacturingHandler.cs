using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IManufacturingRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Manufacturing.Command.AddManufacturing
{
    public class AddManufacturingHandler : IRequestHandler<AddManufacturingRequest, ManufacturingViewModel>
    {
        public readonly IManufacturingCommandRepository _manufacturingCommandRepository;
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public AddManufacturingHandler(IManufacturingCommandRepository manufacturingCommandRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _manufacturingCommandRepository = manufacturingCommandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ManufacturingViewModel> Handle(AddManufacturingRequest request, CancellationToken cancellationToken)
        {
            var manufacturing  = _mapper.Map<ManufacturingModel>(request);
            _manufacturingCommandRepository.Add(manufacturing);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ManufacturingViewModel>(manufacturing);
        }
    }
}
