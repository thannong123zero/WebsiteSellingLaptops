using AutoMapper;
using BusinessLogic.ViewModel;
using DataAccess.EntityModel;
using DataAccess.IRepositories;
using DataAccess.IRepositories.ICategoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.UseCase.Crud.Category.Command.UpdateCategory
{
    public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryRequest, CategoryViewModel>
    {
        private readonly ICategoryCommandRepository _categoryCommandRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateCategoryHandler(ICategoryCommandRepository categoryCommandRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _categoryCommandRepository = categoryCommandRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<CategoryViewModel> Handle(UpdateCategoryRequest request, CancellationToken cancellationToken)
        {
            CategoryModel categoryModel = _mapper.Map<CategoryModel>(request);
            _categoryCommandRepository.Update(categoryModel);
            await  _unitOfWork.SaveChangesAsync();

            return _mapper.Map<CategoryViewModel>(categoryModel);
        }
    }
}
