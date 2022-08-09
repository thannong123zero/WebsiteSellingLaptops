using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ICategoryRepository;
using DataAccess.IRepositories.ISubCategoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWA.Core.Domain.Exceptions;

namespace BusinessLogic.UseCase.Crud.SubCategory.Command.AddSubCategory
{
    public class AddSubCategoryHandler : IRequestHandler<AddSubCategoryRequest, SubCategoryViewModel>
    {
        private readonly ISubCategoryCommandRepository _subCategoryCommandRepository;
        private readonly ICategoryQueryRepository _categoryQueryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AddSubCategoryHandler(ISubCategoryCommandRepository subCategoryCommandRepository,
            ICategoryQueryRepository categoryQueryRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _subCategoryCommandRepository = subCategoryCommandRepository;
            _categoryQueryRepository = categoryQueryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<SubCategoryViewModel> Handle(AddSubCategoryRequest request, CancellationToken cancellationToken)
        {
            var Category = _categoryQueryRepository.Find(c => c.Id == request.CategoryId).FirstOrDefault();
            if (Category == null)
            {
                throw new DomainException("Category Id does not exist!");
            }
            SubCategoryModel subCategory = _mapper.Map<SubCategoryModel>(request);
            _subCategoryCommandRepository.Add(subCategory);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<SubCategoryViewModel>(subCategory);
        }
    }
}
