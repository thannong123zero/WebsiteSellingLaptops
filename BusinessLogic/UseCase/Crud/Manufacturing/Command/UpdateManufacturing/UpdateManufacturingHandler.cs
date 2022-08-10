using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.IManufacturingRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.Manufacturing.Command.UpdateManufacturing
{
    public class UpdateManufacturingHandler : IRequestHandler<UpdateManufacturingRequest, ManufacturingViewModel>
    {
        public readonly IManufacturingCommandRepository _manufacturingCommandRepository;
        public readonly IManufacturingQueryRepository _manufacturingQueryRepository;
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public UpdateManufacturingHandler(IManufacturingCommandRepository manufacturingCommandRepository,
            IManufacturingQueryRepository manufacturingQueryRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _manufacturingCommandRepository = manufacturingCommandRepository;
            _manufacturingQueryRepository = manufacturingQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ManufacturingViewModel> Handle(UpdateManufacturingRequest request, CancellationToken cancellationToken)
        {
            var manufacturing = await _manufacturingQueryRepository.GetByIdAsync(request.Id);

            if (manufacturing == null)
            {
                throw new DomainException("ManufacturingId does not exist!");
            }
            _mapper.Map(request, manufacturing);
            manufacturing.UpdateAt = DateTime.Now;
            _manufacturingCommandRepository.Update(manufacturing);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ManufacturingViewModel>(manufacturing);
        }
    }
}
