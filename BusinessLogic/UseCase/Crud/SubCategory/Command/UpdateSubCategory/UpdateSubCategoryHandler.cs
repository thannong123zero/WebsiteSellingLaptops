using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ISubCategoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.SubCategory.Command.UpdateSubCategory
{
    public class UpdateSubCategoryHandler : IRequestHandler<UpdateSubCategoryRequest, SubCategoryViewModel>
    {
        private readonly ISubCategoryCommandRepository _subCategoryCommandRepository;
        private readonly ISubCategoryQueryRepository _subCategoryQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateSubCategoryHandler(ISubCategoryCommandRepository subCategoryCommandRepository,
            ISubCategoryQueryRepository subCategoryQueryRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _subCategoryCommandRepository = subCategoryCommandRepository;
            _subCategoryQueryRepository = subCategoryQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<SubCategoryViewModel> Handle(UpdateSubCategoryRequest request, CancellationToken cancellationToken)
        {
            var subCategoryUpdate = await _subCategoryQueryRepository.GetByIdAsync(request.Id);

            if (subCategoryUpdate == null)
            {
                throw new DomainException("SubCategory Id does not exist!");
            }
            _mapper.Map(request, subCategoryUpdate);
            subCategoryUpdate.UpdateAt = DateTime.Now;
            _subCategoryCommandRepository.Update(subCategoryUpdate);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<SubCategoryViewModel>(subCategoryUpdate);
        }
    }
}
